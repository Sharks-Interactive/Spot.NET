using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Sharks.Spot.RobotSystems;
using System;

namespace Sharks.Spot.Test
{
    public class ConnectionTest
    {
        IConfiguration? Configuration { get; set; }
        Robot? Robot;

        [OneTimeSetUp]
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
        public void _010_Connect()
        {
            Assert.True(Robot?.Connect() == Result.Success);
        }

        [Test]
        public void _020_Initialise()
        {
            Assert.That(Robot?.Initialise(), Is.Not.EqualTo(null));
        }

        [Test]
        public void _030_Estop()
        {
            Assert.That(EstopSystem.RegisterEstopClient(Robot), Is.EqualTo(Result.Success));
        }

        [Test]
        public void _040_Sit()
        {
            Assert.That(PositionSystem.Sit(Robot), Is.EqualTo(Result.Success));
        }
    }
}
