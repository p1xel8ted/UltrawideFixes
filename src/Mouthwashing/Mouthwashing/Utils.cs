namespace Mouthwashing;

public static class Utils
{
    
    internal static float FindLowestFrameRateMultipleAboveFifty(double originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return (float)rate;
            }
        }

        return (float)originalRate;
    }

    public static string GetPath(this GameObject go)
    {
        var path = go.name;
        while (go.transform.parent != null)
        {
            go = go.transform.parent.gameObject;
            path = $"{go.name}/{path}";
        }

        return path;
    }

}