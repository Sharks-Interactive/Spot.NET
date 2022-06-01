using NUnit.Framework;

namespace Sharks.Spot.Test
{
    public class ConnectionTest
    {
        Robot? Robot;

        [SetUp]
        public void Setup()
        {
            Robot = new Robot(
                new ContactInfo() 
                { 
                    Credentials = new RobotCredentials() 
                    { 
                        Username = "user",
                        Password = "",
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
    }
}