using Bosdyn.Api;

namespace Sharks.Spot.RobotSystems
{
    public static class DirectorySystem
    {
        private static List<ServiceEntry> _services = new ();

        public static async Task<Result> ListDirectories(this Robot Robot)
        {
            DirectoryService.DirectoryServiceClient _directoryService = new(Robot.EnsureChannelFor(Authority.Api));

            ListServiceEntriesRequest _listServicesRequest = new() { Header = Robot.GetRequestHeader() };
            ListServiceEntriesResponse _listServicesResponse = await _directoryService.ListServiceEntriesAsync(_listServicesRequest, Robot.RobotContact.Headers);

            if (_listServicesResponse.Header.Error.Code.ResultOk() || _listServicesResponse.ServiceEntries.Count < 1) return Result.Error;

            for (int i = 0; i < _listServicesResponse.ServiceEntries.Count; i++) 
                Console.WriteLine($"Ay: {_listServicesResponse.ServiceEntries[i].Authority} Nm: {_listServicesResponse.ServiceEntries[i].Name} Tp: {_listServicesResponse.ServiceEntries[i].Type}");
            _services = _listServicesResponse.ServiceEntries.ToList();

            return Result.Success;
        }

        public static ServiceEntry? ServiceFromName(string Name) => _services.Find(s => s.Name == Name);
    }
}
