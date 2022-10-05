using Grpc.Core;

namespace Sharks.Spot
{
    /// <summary>
    /// Everything needed to talk to a robot
    /// </summary>
    public class ContactInfo
    {
        /// <summary>
        /// Credentials to authenticate with the robot
        /// </summary>
        public RobotCredentials Credentials;

        /// <summary>
        /// The channel used to communicate with the robot over
        /// </summary>
        public Channel? Channel;

        /// <summary>
        /// The channel used for the estop service
        /// </summary>
        public Channel? EstopChannel;

        /// <summary>
        /// Headers to contact the robot with
        /// </summary>
        public Metadata Headers;

        /// <summary>
        /// The lease we currently have on the robot
        /// </summary>
        public Bosdyn.Api.Lease? Lease;

        public ContactInfo()
        {
            Headers = new();
        }
    }
}
