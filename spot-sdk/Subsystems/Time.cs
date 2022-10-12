using Bosdyn.Api;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharks.Spot.RobotSystems
{
    public static class TimeSystem
    {
        public static TimeSyncRoundTrip? LastTrip = null;

        public static async Task<Result> TimeSyncThread()
        {

            return Result.Error;
        }

        public static async Task<Result> EstablishTimeSync(Robot Robot)
        {
            Result _result = Result.Error;
            while (_result != Result.Success)
                _result = await TimeSyncRoundTrip(Robot);

            return _result;
        }

        public static async Task<Result> TimeSyncRoundTrip(Robot Robot)
        {
            TimeSyncService.TimeSyncServiceClient _timeService = new(Robot.RobotContact.Channel);

            TimeSyncUpdateRequest _request = new TimeSyncUpdateRequest() { PreviousRoundTrip = LastTrip, ClockIdentifier = "fjkdlas", Header = Robot.GetRequestHeader() };
            TimeSyncUpdateResponse _response = await _timeService.TimeSyncUpdateAsync(_request, Robot.RobotContact.Headers);

            LastTrip = new()
            {
                ClientTx = _response.Header.RequestHeader.RequestTimestamp,
                ServerRx = _response.Header.RequestReceivedTimestamp,
                ServerTx = _response.Header.ResponseTimestamp,
                ClientRx = new Google.Protobuf.WellKnownTypes.Timestamp() { Seconds = DateTime.UtcNow.Second, Nanos = DateTime.UtcNow.Second / 1000000000 }
            };

            Console.WriteLine(_response.State?.Status);
 
            return _response.State?.Status == TimeSyncState.Types.Status.Ok ? Result.Success : Result.Error;
        }
    }
}
