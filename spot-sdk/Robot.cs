using Bosdyn.Api;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System.Text;

namespace Sharks.Spot
{
    /// <summary>
    /// Purpose: Handles connecting to spot and acts as a container for information to communicate with spot
    /// </summary>
    public class Robot
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
            _contactInfo.Channel?.ShutdownAsync();
        }

        /// <summary>
        /// Authenticates with an opens a channel with the Robot
        /// </summary>
        /// <returns> The result of the operation </returns>
        public Result Connect()
        {
            // Creates a channel with Spot to get auth infor
            _contactInfo.Channel = CreateAuthenticatedChannel(_contactInfo.Credentials.Url);

            // Gets a token to talk to Spot and adds it to our headers for future requests
            _userToken = GetUserToken(_contactInfo.Credentials);
            if (_userToken == string.Empty) return Result.Error;
            _contactInfo.Headers.Add(MetadataHeaders.Auth, _fullUserToken);

            // Closes the old channel and recreates a new authenticated one with the creds
            _contactInfo.Channel.ShutdownAsync(); // TODO: This may cause problems
            _contactInfo.Channel = CreateAuthenticatedChannel(_contactInfo.Credentials.Url, Authority.Api);
            _contactInfo.EstopChannel = CreateAuthenticatedChannel(_contactInfo.Credentials.Url, Authority.Estop);

            return Result.Success;
        }

        /// <summary>
        /// Registers an Estop client and acquires a lease for the robot
        /// </summary>
        /// <returns> The result of the operation </returns>
        public async Task<Result> Initialise()
        {
            if (await RobotSystems.TimeSystem.EstablishTimeSync(this) != Result.Success) return Result.Error;

            _contactInfo.Lease = RobotSystems.LeaseSystem.AquireLease(this);
            if (_contactInfo.Lease == null) return Result.Error;

            return Result.Success;
        }

        /// <summary>
        /// Creates an Authenticated GRPC channel with the given credentials
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Authority"></param>
        /// <returns> The created channel </returns>
        private GrpcChannel CreateAuthenticatedChannel(string Address, string Authority = Authority.Auth)
        {
            // Generate credentials
            HttpClientHandler _handler = new HttpClientHandler();
            _handler.ClientCertificates.Add(new System.Security.Cryptography.X509Certificates.X509Certificate(Encoding.ASCII.GetBytes(RootCert.Cert)));
            _handler.Properties.Add("grpc.ssl_target_name_override", Authority);

            Grpc.Core.CallCredentials _credentials = Grpc.Core.CallCredentials.FromInterceptor((context, metadata) =>
            {
                if (!string.IsNullOrEmpty(_userToken)) metadata.Add(MetadataHeaders.Auth, _fullUserToken);
                return Task.CompletedTask;
            });

            // Generate channel options
            //List<ChannelOption> _options = new () { new ChannelOption(ChannelOptions.SslTargetNameOverride, Authority) };

            // Create and return new channel
            return GrpcChannel.ForAddress(Address, new GrpcChannelOptions
            {
                HttpHandler = _handler,
                Credentials = Grpc.Core.ChannelCredentials.Create(Grpc.Core.ChannelCredentials.SecureSsl, _credentials),
            });
        }

        /// <summary>
        /// Sends a request to get a user token for communicating securely with the robot
        /// </summary>
        /// <param name="Credentials"> Information needed to authenticate the robot </param>
        /// <returns> The usertoken </returns>
        private string GetUserToken(RobotCredentials Credentials)
        {
            AuthService.AuthServiceClient _robotAuthServiceClient = new AuthService.AuthServiceClient(_contactInfo.Channel);
            GetAuthTokenRequest _authTokenRequest = new GetAuthTokenRequest() { Header = GetRequestHeader(), Username = Credentials.Username, Password = Credentials.Password };
            GetAuthTokenResponse _authTokenResponse = _robotAuthServiceClient.GetAuthToken(_authTokenRequest);
            
            if (_authTokenResponse.Header.Error.Code.ResultOk())
            {
                _userToken = _authTokenResponse.Token;
                _fullUserToken = $"Bearer {_userToken}";
                Console.WriteLine($"Got Token {_userToken}");
                return _userToken;
            }
            return string.Empty;
        }

        /// <summary>
        /// Generates a request header for talking to spot
        /// </summary>
        /// <param name="ClientName"> How to identify ourselves to spot, default is "Pilot"</param>
        /// <returns> The generated request header </returns>
        public static RequestHeader GetRequestHeader(string ClientName = "Pilot")
        {
            Timestamp _time = new Timestamp() { Seconds = DateTime.UtcNow.Second, Nanos = DateTime.UtcNow.Second / 1000000000 };
            return new RequestHeader() { ClientName = ClientName, RequestTimestamp = _time };
        }
    }
}
