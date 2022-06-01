using Bosdyn.Api;
using Google.Protobuf.WellKnownTypes;

namespace Sharks.Spot.RobotSystems
{
    public static class EstopSystem
    {
        public static Result RegisterEstopClient(Robot Robot)
        {
            EstopService.EstopServiceClient _eStopServiceClient = new EstopService.EstopServiceClient(Robot.RobotContact.Channel);

            RegisterEstopEndpointRequest _registerEndpointRequest = new RegisterEstopEndpointRequest()
            {
                Header = Robot.GetRequestHeader(),
                TargetEndpoint = new EstopEndpoint()
                {
                    CutPowerTimeout = new Duration() { Seconds = 60 },
                    Name = Estop.DefaultServiceName,
                    Role = Estop.Role,
                    UniqueId = "0"
                }
            };

            RegisterEstopEndpointResponse _registerEndpointResponse = _eStopServiceClient.RegisterEstopEndpoint(_registerEndpointRequest);

            return Util.ResultFromBool(_registerEndpointResponse.Header.Error.Code.ResultOk());
        }
    }
}
