using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class Auth
    {
        /// <summary>
        /// Sends a request to get a user token for communicating securely with the robot
        /// </summary>
        /// <param name="Credentials"> Information needed to authenticate the robot </param>
        /// <returns> The usertoken </returns>
        public static string GetUserToken(this Robot Robot, RobotCredentials Credentials)
        {
            AuthService.AuthServiceClient _robotAuthServiceClient = new (Robot.EnsureChannelFor(Authority.Auth));
            GetAuthTokenRequest _authTokenRequest = new GetAuthTokenRequest() { Header = Robot.GetRequestHeader(), Username = Credentials.Username, Password = Credentials.Password };
            GetAuthTokenResponse _authTokenResponse = _robotAuthServiceClient.GetAuthToken(_authTokenRequest);

            if (_authTokenResponse.Header.Error.Code.ResultOk())
            {
                Console.WriteLine($"Got Token {_authTokenResponse.Token}");
                return _authTokenResponse.Token;
            }
            return string.Empty;
        }
    }
}
