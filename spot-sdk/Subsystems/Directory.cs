using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class Directory
    {
        public static async Task ListDirectories(Robot Robot)
        {
            DirectoryService.DirectoryServiceClient _directoryService = new(Robot.RobotContact.Channel);

            ListServiceEntriesRequest _listServicesRequest = new ListServiceEntriesRequest() { Header = Robot.GetRequestHeader() };
            ListServiceEntriesResponse _listServicesResponse = _directoryService.ListServiceEntries(_listServicesRequest, Robot.RobotContact.Headers);

            for (int i = 0; i < _listServicesResponse.ServiceEntries.Count; i++)
            {
                Console.WriteLine(_listServicesResponse.ServiceEntries[i].Authority);
            }
        }
    }
}
