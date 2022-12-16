using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharks.Spot
{
    public partial class Robot
    {
        public Dictionary<string, Channel> Channels = new ();

        public Channel EnsureChannelFor(string Authority)
        {
            if (Channels.ContainsKey(Authority)) return Channels[Authority];

            Channels[Authority] = CreateAuthenticatedChannel(_contactInfo.Credentials.Url, Authority);
            return Channels[Authority];
        }

        /// <summary>
        /// Creates an Authenticated GRPC channel with the given credentials
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Authority"></param>
        /// <returns> The created channel </returns>
        private Channel CreateAuthenticatedChannel(string Address, string Authority = Authority.Auth)
        {
            // Generate credentials
            CallCredentials _credentials = CallCredentials.FromInterceptor((context, metadata) =>
            {
                if (!string.IsNullOrEmpty(_userToken)) metadata.Add(MetadataHeaders.Auth, _fullUserToken);
                return Task.CompletedTask;
            });

            // Generate channel options
            List<ChannelOption> _options = new() { new ChannelOption(ChannelOptions.SslTargetNameOverride, Authority) };

            // Create and return new channel
            return new Channel(Address, new SslCredentials(RootCert.Cert), _options);
        }

    }
}
