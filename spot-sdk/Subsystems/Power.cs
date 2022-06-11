using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class PowerSystem
    {
        public static Result PowerOn(Robot Robot)
        {
            PowerService.PowerServiceClient _powerService = new (Robot.RobotContact.Channel);

            // Send request
            PowerCommandRequest _powerCommandRequest = new () { Header = Robot.GetRequestHeader(), Lease = Robot.Lease, Request = PowerCommandRequest.Types.Request.On };
            PowerCommandResponse _powerCommandResponse = _powerService.PowerCommand(_powerCommandRequest, Robot.RobotContact.Headers);

            return Util.ResultFromBool(_powerCommandResponse.Header.Error.Code.ResultOk());
        }
    }
}
