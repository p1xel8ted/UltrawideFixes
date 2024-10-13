// Utilities.cs

using Il2CppInterop.Runtime;
using SeaOfStars.Core;
using Object = UnityEngine.Object;

namespace SeaOfStars.Utilities;

public static class Utilities
{
    public static List<T> FindIl2CppType<T>() where T : Object
    {
        var list = new List<T>();
        list.AddRange(Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }
    public static int[] MergeUnityRefreshRates()
    {
        var unityRates = Screen.resolutions.Select(a => a.refreshRate).Distinct().ToArray();
        return unityRates.Concat(Constants.CustomRefreshRates).Distinct().OrderBy(a => a).ToArray();
    }

    internal static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }
}