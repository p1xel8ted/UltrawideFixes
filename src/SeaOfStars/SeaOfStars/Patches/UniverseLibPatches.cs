namespace SeaOfStars;

public static class UniverseLibPatches
{
    private static bool _previousAnyUIShowing;
    private static PropertyInfo _anyUIShowingProp;

    internal static void Apply(Harmony harmony)
    {
        var universalUIType = Type.GetType("UniverseLib.UI.UniversalUI, UniverseLib.BIE.IL2CPP.Interop");
        if (universalUIType == null)
        {
            Plugin.Logger.LogInfo("UniverseLib not detected - overlay UI toggle disabled");
            return;
        }

        var setUIActiveMethod = AccessTools.Method(universalUIType, "SetUIActive");
        if (setUIActiveMethod == null)
        {
            Plugin.Logger.LogWarning("UniverseLib SetUIActive method not found - skipping UI patches");
            return;
        }

        _anyUIShowingProp = AccessTools.Property(universalUIType, "AnyUIShowing");
        if (_anyUIShowingProp == null)
        {
            Plugin.Logger.LogWarning("UniverseLib AnyUIShowing property not found - skipping UI patches");
            return;
        }

        var postfix = new HarmonyMethod(AccessTools.Method(typeof(UniverseLibPatches), nameof(OnSetUIActive)));
        harmony.Patch(setUIActiveMethod, postfix: postfix);

        Plugin.Logger.LogInfo("UniverseLib detected - overlay UI toggle enabled");
    }

    public static void OnSetUIActive()
    {
        var anyShowing = (bool)_anyUIShowingProp.GetValue(null)!;
        if (anyShowing == _previousAnyUIShowing) return;

        _previousAnyUIShowing = anyShowing;
        Plugin.Logger.LogInfo($"UniverseLib UI visibility changed: {anyShowing}");
        SoSuiManager.HandleOverlayUI(anyShowing);
    }

    internal static bool IsAnyUIShowing()
    {
        if (_anyUIShowingProp == null) return false;
        return (bool)_anyUIShowingProp.GetValue(null)!;
    }
}