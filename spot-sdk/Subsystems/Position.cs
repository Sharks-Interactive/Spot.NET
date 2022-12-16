using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class PositionSystem
    {
        public static Result Sit(this Robot Robot)
        {
            RobotCommandService.RobotCommandServiceClient _robotCommandService = new (Robot.EnsureChannelFor(Authority.Api));

            StandCommand.Types.Request _sitReq = new ();

            // Build out command
            MobilityCommand.Types.Request _mobilityCmd = new () { StandRequest = _sitReq };
            SynchronizedCommand.Types.Request _synchroCmd = new () { MobilityCommand = _mobilityCmd };
            RobotCommand _sitCommandRequest = new () { SynchronizedCommand = _synchroCmd };

            // Send request
            RobotCommandRequest _robotCommandRequest = new () { Header = Robot.GetRequestHeader(), Lease = Robot.Lease, Command = _sitCommandRequest };
            RobotCommandResponse _robotCommandResponse = _robotCommandService.RobotCommand(_robotCommandRequest, Robot.RobotContact.Headers);

            return Util.ResultFromBool(_robotCommandResponse.Header.Error.Code.ResultOk());
        }
    }
}
