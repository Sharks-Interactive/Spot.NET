using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace Sharks.Spot.Test
{
    public class ConnectionTest
    {
        IConfiguration? Configuration { get; set; }
        Robot? Robot;

        [SetUp]
        public void Setup()
        {
            Configuration = new ConfigurationBuilder().AddUserSecrets<ConnectionTest>().Build();

            Robot = new Robot(
                new ContactInfo() 
                { 
                    Credentials = new RobotCredentials() 
                    { 
                        Username = "user",
                        Password = Configuration["SpotPass"],
                        Url = "192.168.80.3:443"
                    } 
                },
                "Spot.Net Tests"
            );
        }

        [Test]
        public void Connect()
        {
            Assert.True(Robot?.Connect() == Result.Success);
        }

        [Test]
        public void Initialise()
        {
            Assert.True(Robot?.Initialise() == Result.Success);
        }
    }
}