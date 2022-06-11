using Bosdyn.Api;
using System.Text.Json;

namespace Sharks.Spot.RobotSystems
{
    public static class LeaseSystem
    {
        public static Lease AquireLease(Robot Robot)
        {
            LeaseService.LeaseServiceClient _leaseService = new LeaseService.LeaseServiceClient(Robot.RobotContact.Channel);

            AcquireLeaseRequest _aquireLeaseRequest = new AcquireLeaseRequest() { Header = Robot.GetRequestHeader(), Resource = "body" };
            AcquireLeaseResponse _aquireLeaseResponse = _leaseService.AcquireLease(_aquireLeaseRequest, Robot.RobotContact.Headers);

            if (_aquireLeaseResponse.Header.Error.Code.ResultOk() && _aquireLeaseResponse.Status == AcquireLeaseResponse.Types.Status.Ok) // Redundant?
                return _aquireLeaseResponse.Lease;

            return null;
        }
    }
}
