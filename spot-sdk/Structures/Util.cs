using Bosdyn.Api;

namespace Sharks.Spot
{
    public static class Util
    {
        public static bool ResultOk(this CommonError.Types.Code Code) => Code == CommonError.Types.Code.Ok;

        public static Result ResultFromBool(bool Status) => (Status ? Result.Success : Result.Error);
    }
}
