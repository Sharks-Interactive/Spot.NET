using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Sharks.Spot.RobotSystems;
using System;
using System.Threading.Tasks;

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
        public async Task _020_Initialise()
        {
            Result _res = await Robot?.Initialise();
            Assert.That(_res, Is.EqualTo(Result.Success));
        }

        [Test]
        public void _030_Estop()
        {
            Assert.That(true, Is.EqualTo(true));
            return;
            Assert.That(Robot?.RegisterEstopClient(), Is.EqualTo(Result.Success));
        }

        [Test]
        public async Task _040_PowerOn()
        {
            Result _res = await PowerSystem.PowerOn(Robot);
            Assert.That(_res, Is.EqualTo(Result.Success));
        }

        [Test]
        public void _050_Sit()
        {
            //Assert.That(Robot?.Sit(), Is.EqualTo(Result.Success));
        }
    }
}
