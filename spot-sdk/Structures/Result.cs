namespace Sharks
{
    /// <summary>
    /// The result of an operation
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// The operation completed successfully
        /// </summary>
        Success,
        /// <summary>
        /// The operation did not complete successfully
        /// </summary>
        Error,
        /// <summary>
        /// The operation completed but something went wrong
        /// </summary>
        Warning
    }
}
