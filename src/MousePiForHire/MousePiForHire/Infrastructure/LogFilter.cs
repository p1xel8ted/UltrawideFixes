using Object = UnityEngine.Object;

namespace MousePiForHire.Infrastructure;

// Hides noisy Unity engine warnings (e.g. BoxCollider negative-scale) from both Unity's player
// log and BepInEx's LogOutput.log. Add to SuppressedPrefixes to hide more - matched as a prefix
// so any trailing path/object name still gets caught.
internal sealed class LogFilter : ILogHandler
{
    private static readonly string[] SuppressedPrefixes =
    [
        "BoxCollider does not support negative scale",
    ];

    private static int _suppressedCount;
    private static int _bepInExSuppressedCount;
    private readonly ILogHandler _inner;

    private LogFilter(ILogHandler inner)
    {
        _inner = inner;
    }

    internal static void Install()
    {
        if (Debug.unityLogger.logHandler is LogFilter)
        {
            return;
        }
        Debug.unityLogger.logHandler = new LogFilter(Debug.unityLogger.logHandler);
        Plugin.Log.LogInfo($"[LogFilter] Installed Unity logHandler wrapper. Suppressing prefixes: {string.Join(", ", SuppressedPrefixes.Select(p => $"\"{p}\""))}.");
    }

    private static bool ShouldSuppress(string message)
    {
        return message != null && SuppressedPrefixes.Any(prefix => message.StartsWith(prefix, StringComparison.Ordinal));
    }

    // Called from the Harmony patch on BepInEx's UnityLogSource. Counts separately from the
    // Unity-side filter so a bug-report log shows which path actually caught it.
    internal static bool ShouldSuppressFromBepInEx(string message)
    {
        if (!ShouldSuppress(message)) return false;
        var n = Interlocked.Increment(ref _bepInExSuppressedCount);
        if (n == 1)
        {
            Plugin.Log.LogInfo("[LogFilter] First BepInEx-side suppression.");
        }
        return true;
    }

    public void LogFormat(LogType logType, Object context, string format, params object[] args)
    {
        if (ShouldSuppress(format))
        {
            var n = Interlocked.Increment(ref _suppressedCount);
            if (n == 1)
            {
                Plugin.Log.LogInfo("[LogFilter] First Unity-side suppression matched.");
            }
            return;
        }
        _inner.LogFormat(logType, context, format, args);
    }

    public void LogException(Exception exception, Object context)
    {
        _inner.LogException(exception, context);
    }
}
