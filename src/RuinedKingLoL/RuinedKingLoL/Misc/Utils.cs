namespace RuinedKingLoL.Misc;

public static class Utils
{
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        var component = go.GetComponent<T>();
        if (!component)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }

    private static float GetPreferredAspect()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:9" => 1.777777777777778f,
            "21:9" => 2.333333333333333f,
            "21.5:9" => 2.388888888888889f,
            "24:10" => 2.4f,
            "32:9" => 3.555555555555556f,
            "32:10" => 3.2f,
            "48:9" => 5.333333333333333f,
            "Auto" => Plugin.MainAspect,
            _ => Plugin.MainAspect
        };
        return width;
    }

    internal static int GetHudRes(float y)
    {
        return Mathf.RoundToInt(y * GetPreferredAspect());
    }
}