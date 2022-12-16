using Bosdyn.Api;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Sharks.Spot.RobotSystems;

namespace Sharks.Spot
{
    /// <summary>
    /// Purpose: Handles connecting to spot and acts as a container for information to communicate with spot
    /// </summary>
    public partial class Robot
    {
        /// <summary>
        /// Readonly robot contact info
        /// </summary>
        public ContactInfo RobotContact { get => _contactInfo; }

        /// <summary>
        /// Gets the robot lease, acquiring one if none exists
        /// </summary>
        public Lease Lease { get
            {
                if (_contactInfo.Lease != null) return _contactInfo.Lease;
                return RobotSystems.LeaseSystem.AquireLease(this);
            } 
            set => _contactInfo.Lease = value;
        }

        /// <summary>
        /// How we should identify ourselves to spot
        /// </summary>
        public string ClientName = "Pilot";

        private string _userToken; // The user's token
        private string _fullUserToken; // The user's token + Bearer prepended
        private ContactInfo _contactInfo; // Locally store robot contact within this class

        /// <summary>
        /// Connects and initializes a Spot Robot
        /// </summary>
        /// <param name="Credentials"> Information required to contact the robot </param>
        public Robot(ContactInfo Contact, string ClientName)
        {
            this.ClientName = ClientName;
            _contactInfo = Contact;
        }

        ~Robot()
        {
            Channels.Values.ToList().ForEach(async c => await c.ShutdownAsync());
        }

        /// <summary>
        /// Authenticates with an opens a channel with the Robot
        /// </summary>
        /// <returns> The result of the operation </returns>
        public Result Connect()
        {
            // Gets a token to talk to Spot and adds it to our headers for future requests
            _userToken = this.GetUserToken(_contactInfo.Credentials);
            _fullUserToken = $"Bearer {_userToken}";

            if (_userToken == string.Empty) return Result.Error;
            _contactInfo.Headers.Add(MetadataHeaders.Auth, _fullUserToken);

            // Closes the old channel and recreates a new authenticated one with the creds
            EnsureChannelFor(Authority.Auth).ShutdownAsync(); // TODO: This may cause problems

            return Result.Success;
        }

        /// <summary>
        /// Registers an Estop client and acquires a lease for the robot
        /// </summary>
        /// <returns> The result of the operation </returns>
        public async Task<Result> Initialise()
        {
            if (await this.ListDirectories() != Result.Success) return Result.Error;
            if (await this.EstablishTimeSync() != Result.Success) return Result.Error;

            _contactInfo.Lease = this.AquireLease();

            return (_contactInfo.Lease == null).ResultFromBool();
        }

        /// <summary>
        /// Generates a request header for talking to spot
        /// </summary>
        /// <param name="ClientName"> How to identify ourselves to spot, default is "Pilot"</param>
        /// <returns> The generated request header </returns>
        public static RequestHeader GetRequestHeader(string ClientName = "Pilot")
        {
            Timestamp _time = new () { Seconds = DateTime.UtcNow.Second, Nanos = DateTime.UtcNow.Second / 1000000000 };
            return new RequestHeader() { ClientName = ClientName, RequestTimestamp = _time };
        }
    }
}
