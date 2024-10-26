namespace TheMessenger;

public static class Utils
{
    //
    // internal static string GetPath(this GameObject go)
    // {
    //     var path = go.name;
    //     while (go.transform.parent != null)
    //     {
    //         go = go.transform.parent.gameObject;
    //         path = go.name + "/" + path;
    //     }
    //
    //     return path;
    // }
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