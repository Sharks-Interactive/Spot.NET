using Bosdyn.Api;
using System.Text.Json;

namespace Sharks.Spot.RobotSystems
{
    public static class LeaseSystem
    {
        public static async void ManageLeaseLifecycle(this Robot Robot)
        {
            Robot.Lease = AquireLease(Robot);

            // Send keep-alives every 30 seconds on a seperate thread
            while (Robot.Lease != null)
            {
                await Task.Delay(30000);

                Robot.Lease = RetainLease(Robot, Robot.Lease);
            }
        }

        public static Lease AquireLease(this Robot Robot)
        {
            LeaseService.LeaseServiceClient _leaseService = new (Robot.EnsureChannelFor(Authority.Api));

            AcquireLeaseRequest _aquireLeaseRequest = new () { Header = Robot.GetRequestHeader(), Resource = "body" };
            AcquireLeaseResponse _aquireLeaseResponse = _leaseService.AcquireLease(_aquireLeaseRequest, Robot.RobotContact.Headers);

            if (_aquireLeaseResponse.Header.Error.Code.ResultOk() && _aquireLeaseResponse.Status == AcquireLeaseResponse.Types.Status.Ok) // Redundant?
                return _aquireLeaseResponse.Lease;

            return null;
        }

        public static Lease RetainLease(this Robot Robot, Lease Lease)
        {
            LeaseService.LeaseServiceClient _leaseService = new (Robot.EnsureChannelFor(Authority.Api));

            RetainLeaseRequest _retainLeaseRequest = new () { Header = Robot.GetRequestHeader(), Lease = Lease };
            RetainLeaseResponse _retainLeaseResponse = _leaseService.RetainLease(_retainLeaseRequest, Robot.RobotContact.Headers);

            if (_retainLeaseResponse.Header.Error.Code.ResultOk() && _retainLeaseResponse.LeaseUseResult.Status == LeaseUseResult.Types.Status.Ok) // Redundant?
                return _retainLeaseResponse.LeaseUseResult.LatestKnownLease;

            return null;
        }
    }
}
