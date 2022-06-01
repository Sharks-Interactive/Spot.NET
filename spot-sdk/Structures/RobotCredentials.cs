namespace Sharks.Spot
{
    /// <summary>
    /// Credentials needed to connect to the Robot
    /// </summary>
    public struct RobotCredentials
    {
        /// <summary>
        /// The concatenated ip address and port of the robot on the local network to connect to.
        /// Should include the port eg 192.168.80.3:443 if you do not know the port, use 443 as this is a default for a secure connection.
        /// </summary>
        public string Url;

        /// <summary>
        /// The username used to connect to spot in the app, use the spot app to create a new account for this sdk
        /// </summary>
        public string Username;
        /// <summary>
        /// The password used to connect to spot in the app, use the spot app to create a new account for this sdk
        /// </summary>
        public string Password;
    }
}
