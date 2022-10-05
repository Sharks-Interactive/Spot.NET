using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class PositionSystem
    {
        public static Result Sit(this Robot Robot)
        {
            RobotCommandService.RobotCommandServiceClient _robotCommandService = new RobotCommandService.RobotCommandServiceClient(Robot.RobotContact.Channel);

            StandCommand.Types.Request _sitReq = new StandCommand.Types.Request();

            // Build out command
            MobilityCommand.Types.Request _mobilityCmd = new MobilityCommand.Types.Request() { StandRequest = _sitReq };
            SynchronizedCommand.Types.Request _synchroCmd = new SynchronizedCommand.Types.Request() { MobilityCommand = _mobilityCmd };
            RobotCommand _sitCommandRequest = new RobotCommand() { SynchronizedCommand = _synchroCmd };

            // Send request
            RobotCommandRequest _robotCommandRequest = new RobotCommandRequest() { Header = Robot.GetRequestHeader(), Lease = Robot.Lease, Command = _sitCommandRequest };
            RobotCommandResponse _robotCommandResponse = _robotCommandService.RobotCommand(_robotCommandRequest, Robot.RobotContact.Headers);

            return Util.ResultFromBool(_robotCommandResponse.Header.Error.Code.ResultOk());
        }
    }
}
