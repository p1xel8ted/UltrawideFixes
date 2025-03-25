namespace LandOfWar.Helpers;

public static class Utils
{
   
    /// <summary>
    /// Attempts to add a key-value pair to a dictionary. Returns false if the key already exists.
    /// </summary>
    internal static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, TValue value)
    {
        if (dict.ContainsKey(key)) return false;
        dict.Add(key, value);
        return true;
    }
}