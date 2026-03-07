namespace VampireSurvivors;

/// <summary>
/// Logging utility wrapping BepInEx Logger.
/// </summary>
internal static class Logger
{
    /// <summary>
    /// Logs a message using the BepInEx logger.
    /// </summary>
    /// <param name="message">The message to log.</param>
    /// <param name="warning">If true, logs as a warning; otherwise logs as info.</param>
    private static void Log(string message, bool warning = false)
    {
        if (warning)
         Console.WriteLine(message);
        else
            Console.WriteLine(message);
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
