namespace GIJoeWrathOfCobra;

public static class Utils
{

    public static string GetPath(this Transform transform)
    {
        var path = transform.name;
        while (transform.parent != null)
        {
            transform = transform.parent;
            path = transform.name + "/" + path;
        }

        return path;
    }
    
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

}