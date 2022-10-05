using Bosdyn.Api;
using Google.Protobuf.WellKnownTypes;

namespace Sharks.Spot.RobotSystems
{
    public static class EstopSystem
    {
        public static Result RegisterEstopClient(this Robot Robot)
        {
            EstopService.EstopServiceClient _eStopServiceClient = new (Robot.RobotContact.EstopChannel);

            RegisterEstopEndpointRequest _registerEndpointRequest = new ()
            {
                Header = Robot.GetRequestHeader(),
                TargetEndpoint = new EstopEndpoint()
                {
                    CutPowerTimeout = new Duration() { Seconds = 60 },
                    Name = Estop.DefaultServiceName,
                    Role = Estop.Role,
                }
            };

            RegisterEstopEndpointResponse _registerEndpointResponse = _eStopServiceClient.RegisterEstopEndpoint(_registerEndpointRequest);

            return Util.ResultFromBool(_registerEndpointResponse.Header.Error.Code.ResultOk());
        }
    }
}
