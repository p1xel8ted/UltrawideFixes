namespace TormentedSouls.Misc;

public static class Utils
{
    public static string GetPath(this GameObject go)
    {
        var path = go.name;
        while (go.transform.parent != null)
        {
            go = go.transform.parent.gameObject;
            path = go.name + "/" + path;
        }

        return path;
    }

    private static float GetNewScale(float reference)
    {
        var displayHeight = Plugin.MainHeight;
        var scale = 1f / (reference / displayHeight);
        return scale;
    }

    internal static void UpdateCanvasScaler(CanvasScaler scaler, float referenceResolutionHeight)
    {
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
        scaler.scaleFactor = GetNewScale(referenceResolutionHeight);
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