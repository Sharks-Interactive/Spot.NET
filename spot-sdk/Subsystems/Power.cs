﻿using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class PowerSystem
    {
        public static async Task<Result> PowerOn(Robot Robot)
        {
            PowerService.PowerServiceClient _powerService = new (Robot.RobotContact.Channel);

            // Send request
            PowerCommandRequest _powerCommandRequest = new () { Request = PowerCommandRequest.Types.Request.OnMotors };
            PowerCommandResponse _powerCommandResponse = await _powerService.PowerCommandAsync(_powerCommandRequest, Robot.RobotContact.Headers);

            return _powerCommandResponse.LicenseStatus == LicenseInfo.Types.Status.Valid && 
                _powerCommandResponse.Status == PowerCommandStatus.StatusSuccess &&
                _powerCommandResponse.Header.Error.Code.ResultOk() ? Result.Success : Result.Error;
        }
    }
}
