using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class PowerSystem
    {
        public static async Task<Result> PowerOn(Robot Robot)
        {
            PowerService.PowerServiceClient _powerService = new (Robot.CreateAuthenticatedChannel("192.168.80.3:443", Authority.Power));

            // Send request

            
            PowerCommandRequest _powerCommandRequest = new () { Request = PowerCommandRequest.Types.Request.OnMotors, Lease = Robot.Lease, Header = Robot.GetRequestHeader() };
            PowerCommandResponse _powerCommandResponse = null;
            _powerCommandResponse = _powerService.PowerCommand(_powerCommandRequest, Robot.RobotContact.Headers);

            return _powerCommandResponse.LicenseStatus == LicenseInfo.Types.Status.Valid && 
                _powerCommandResponse.Status == PowerCommandStatus.StatusSuccess &&
                _powerCommandResponse.Header.Error.Code.ResultOk() ? Result.Success : Result.Error;
        }
    }
}
