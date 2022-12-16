using Bosdyn.Api;
using Google.Protobuf.WellKnownTypes;
using System.ComponentModel;

namespace Sharks.Spot.RobotSystems
{
    public static class EstopSystem
    {
        private struct EstopThreadArgument
        {
            public Robot Robot;
            public EstopEndpoint Endpoint;
        }

        public static bool ShouldRun = true;

        public static Result Estop(this Robot Robot)
        {
            BackgroundWorker _worker = new ();
            _worker.DoWork += CheckIn;
            _worker.RunWorkerAsync(argument: new EstopThreadArgument() 
            { 
                Robot = Robot, 
                Endpoint = RegisterClient(Robot, ConfigureClient(Robot))
            });

            return Result.Success;
        }

        private static void CheckIn(object sender, DoWorkEventArgs args)
        {
            EstopThreadArgument _data = (EstopThreadArgument)args.Argument;
            EstopService.EstopServiceClient _client = _data.Robot.EnsureClient<EstopService.EstopServiceClient>();
            EstopCheckInResponse _resp = null;

            while (ShouldRun)
            {
                EstopCheckInRequest _request = new()
                {
                    Endpoint = _data.Endpoint,
                    StopLevel = EstopStopLevel.EstopLevelNone,
                    Header = Robot.GetRequestHeader(),
                };
                if (_resp != null) _request.Response = ~_resp.Challenge;
                
                _resp = _client.EstopCheckIn(_request, _data.Robot.RobotContact.Headers);
                Thread.Sleep(1000);
            }
        }

        private static EstopConfig ConfigureClient(this Robot Robot)
        {
            EstopConfig _config = new ();
            _config.Endpoints.Add(
                new EstopEndpoint()
                {
                    Name = Robot.ClientName,
                    Role = ESTOP.Role,
                    Timeout = new Duration { Seconds = 3 },
                }
            );

            SetEstopConfigRequest _request = new()
            {
                Config = _config,
                Header = Robot.GetRequestHeader()
            };

            SetEstopConfigResponse _response = Robot.EnsureClient<EstopService.EstopServiceClient>().SetEstopConfig(_request, Robot.RobotContact.Headers);
            if (_response.Status != SetEstopConfigResponse.Types.Status.Success) throw new CommunicationException(_response.Status.ToString());

            return _response.ActiveConfig; 
        }

        private static EstopEndpoint RegisterClient(this Robot Robot, EstopConfig Config)
        {
            RegisterEstopEndpointRequest _registerEndpointRequest = new ()
            {
                Header = Robot.GetRequestHeader(),
                NewEndpoint = new()
                {
                    CutPowerTimeout = new Duration() { Seconds = 60 },
                    Name = ESTOP.DefaultServiceName,
                    Role = ESTOP.Role,
                    Timeout = new Duration() { Seconds = 60 },
                    UniqueId = Config.Endpoints[0].UniqueId
                },
                TargetConfigId = Config.UniqueId
            };

            return Robot.EnsureClient<EstopService.EstopServiceClient>().RegisterEstopEndpoint(_registerEndpointRequest).NewEndpoint;
        }
    }
}
