namespace Sharks.Spot
{
    public static class Authority
    {
        public const string Auth = "auth.spot.robot";
        public const string Api = "api.spot.robot";
    }

    public static class MetadataHeaders
    {
        public const string Auth = "authorization";
    }

    public static class Estop
    {
        public const string DefaultServiceName = "estop";
        public const string ServiceType = "bosdyn.api.EstopService";
        public const string Role = "PDB_rooted";
    }
}
