namespace TempMonitor.Libraries
{
    public enum SyncState
    {
        /// <summary>
        ///     Trying to synchronize
        /// </summary>
        Syncing,

        /// <summary>
        ///     Synchronization achived
        /// </summary>
        Synced,

        /// <summary>
        ///     Momentary out of sync
        /// </summary>
        OutOfSync,

        /// <summary>
        ///     Recoverable error
        /// </summary>
        Error,

        /// <summary>
        ///     Critical error. In this case the COM port must be closed
        /// </summary>
        CriticalError
    }
}