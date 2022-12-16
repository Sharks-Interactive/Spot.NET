using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class PowerSystem
    {
        public static async Task<Result> PowerOn(this Robot Robot)
        {
            PowerService.PowerServiceClient _powerService = new (Robot.EnsureChannelFor(Authority.Power));

            // Send request
            PowerCommandRequest _powerCommandRequest = new () { Request = PowerCommandRequest.Types.Request.OnMotors, Lease = Robot.Lease, Header = Robot.GetRequestHeader() };
            PowerCommandResponse _powerCommandResponse = await _powerService.PowerCommandAsync(_powerCommandRequest, Robot.RobotContact.Headers);

            return _powerCommandResponse.LicenseStatus == LicenseInfo.Types.Status.Valid && 
                _powerCommandResponse.Status == PowerCommandStatus.StatusInProgress &&
                _powerCommandResponse.Header.Error.Code.ResultOk() ? Result.Success : Result.Error;
        }
    }
}
