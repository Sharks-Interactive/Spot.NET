namespace Sharks.Spot
{
    public static class Authority
    {
        public const string Auth = "auth.spot.robot";
        public const string Api = "api.spot.robot";
        public const string Estop = "estop.spot.robot";
        public const string Power = "power.spot.robot";
    }

    public static class MetadataHeaders
    {
        public const string Auth = "authorization";
    }

    public static class ESTOP
    {
        public const string DefaultServiceName = "estop";
        public const string ServiceType = "bosdyn.api.EstopService";
        public const string Role = "PDB_rooted";
    }
}
