using UnityEngine;

namespace GoGoGo;

public static class Helpers
{
    internal static void Log(string message)
    {
        if (Plugin.Debug.Value)
        {
            Plugin.LOG.LogWarning(message);
        }
    }
}