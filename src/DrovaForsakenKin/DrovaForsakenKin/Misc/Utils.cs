using Il2CppInterop.Runtime;
using UnityEngine;
using Object = UnityEngine.Object;

namespace DrovaForsakenKin.Misc;

public static class Utils
{
    internal static float FindLowestFrameRateMultipleAboveFifty(float originalRate)
    {
        var intRate = Mathf.RoundToInt(originalRate);
        for (var rate = intRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }

public static List<T> FindIl2CppType<T>() where T : Object
{
    // Use a HashSet to store unique objects based on their instance ID.
    var uniqueObjects = new HashSet<int>();
    var result = new List<T>();

    // Find all objects using Resources.FindObjectsOfTypeAll and add them if unique.
    foreach (var obj in Resources.FindObjectsOfTypeAll(Il2CppType.Of<T>()))
    {
        var castedObj = obj.TryCast<T>();
        if (castedObj != null && uniqueObjects.Add(castedObj.GetInstanceID()))
        {
            result.Add(castedObj);
        }
    }

    // Find all objects using Object.FindObjectsOfType and add them if unique.
    foreach (var obj in Object.FindObjectsOfType<T>())
    {
        if (obj != null && uniqueObjects.Add(obj.GetInstanceID()))
        {
            result.Add(obj);
        }
    }

    return result;
}

}