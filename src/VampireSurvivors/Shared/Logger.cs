namespace Shared;

/// <summary>
/// Framework-agnostic logging utility with conditional compilation for MelonLoader and BepInEx.
/// </summary>
internal static class Logger
{
    /// <summary>
    /// Logs a message using the appropriate framework-specific logger.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="warning">If true, logs as a warning; otherwise logs as info/message.</param>
    private static void Log(string message, bool warning = false)
    {
#if Melon
        if (warning)
            MelonLogger.Warning(message);
        else
            MelonLogger.Msg(message);
#else
        if (warning)
            VampireSurvivors.Plugin.Logger.LogWarning(message);
        else
            VampireSurvivors.Plugin.Logger.LogInfo(message);
#endif
    }

    /// <summary>
    /// Logs an informational message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    internal static void Info(string message) => Log(message, false);

    /// <summary>
    /// Logs a warning message.
    /// </summary>
    /// <param name="message">The message to log.</param>
    internal static void Warning(string message) => Log(message, true);
}
