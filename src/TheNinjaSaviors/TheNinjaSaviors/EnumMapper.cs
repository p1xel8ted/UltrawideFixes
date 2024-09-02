namespace TheNinjaSaviors;

public static class EnumMapper
{
    private static readonly Dictionary<AntialiasingMode, string> AntialiasingModeToStringMap = new Dictionary<AntialiasingMode, string>
    {
        { AntialiasingMode.None, "None" },
        { AntialiasingMode.FastApproximateAntialiasing, "FastApproximateAntialiasing" },
        { AntialiasingMode.SubpixelMorphologicalAntiAliasing, "SubpixelMorphologicalAntiAliasing" }
    };

    internal static readonly Dictionary<string, AntialiasingMode> StringToAntialiasingModeMap = new Dictionary<string, AntialiasingMode>
    {
        { "None", AntialiasingMode.None },
        { "FastApproximateAntialiasing", AntialiasingMode.FastApproximateAntialiasing },
        { "SubpixelMorphologicalAntiAliasing", AntialiasingMode.SubpixelMorphologicalAntiAliasing }
    };

    public static string ToFriendlyString(this AntialiasingMode mode)
    {
        return AntialiasingModeToStringMap.TryGetValue(mode, out var result) ? result : mode.ToString();
    }

    public static AntialiasingMode ToAntialiasingMode(this string modeString)
    {
        return StringToAntialiasingModeMap.GetValueOrDefault(modeString, AntialiasingMode.None);
    }
}