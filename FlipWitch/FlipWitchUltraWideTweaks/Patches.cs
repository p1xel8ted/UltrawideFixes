using System.Diagnostics;

namespace FlipWitchUltraWideTweaks;

[Harmony]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SwitchDatabase), nameof(SwitchDatabase.Awake))]
    public static void SwitchDatabase_Awake(SwitchDatabase __instance)
    {
        var res = new Vector2Int(Plugin.MainWidth, Plugin.MainHeight);
        var exists = __instance.supportedResolutions.Any(a => a.x == res.x && a.y == res.y);
        if (!exists)
        {
            __instance.supportedResolutions.Add(res);
        }
        __instance.defaultResolution = res;
        __instance.defaultMaxResolution = res;

        if (!Plugin.SkipIntros.Value) return;

        __instance.skipIntroToMainMenu = true;
        __instance.skipIntro = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GamePlatformManager), nameof(GamePlatformManager.setAchievementsEnabled))]
    public static void GamePlatformManager_setAchievementsEnabled(ref bool enabled)
    {
        enabled = true;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GamePlatformManager), nameof(GamePlatformManager.updateAchievement))]
    public static void GamePlatformManager_updateAchievement(GamePlatformManager __instance)
    {
        __instance._achievementsEnabled = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BeginCutsceneIngame), nameof(BeginCutsceneIngame.OnEnable))]
    public static void BeginCutsceneInGame_OnEnable(BeginCutsceneIngame __instance)
    {
        if (SwitchDatabase.instance != null)
        {
            SwitchDatabase.instance.cutsceneBars.SetActive(false);
        }
    }

    private static void SetSixteenByNine(CanvasScaler scaler = null)
    {
        if (scaler != null)
        {
            scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        }
        if (!Plugin.LimitInGameMenuToSixteenByNine.Value) return;
        Display.displays[Plugin.DisplayToUse.Value].Activate();
        Screen.SetResolution(Plugin.SixteenNineWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
    }

    private static void SetMaxUltrawide(CanvasScaler scaler = null)
    {
        if (scaler != null)
        {
            UltraWideScaling(scaler);
        }
        Display.displays[Plugin.DisplayToUse.Value].Activate();
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ZoneBackrounds), nameof(ZoneBackrounds.setTextures))]
    public static void ZoneBackgrounds_setTextures(ZoneBackrounds __instance)
    {
        PerformPositiveXYScale(__instance.transform);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameObject), nameof(GameObject.SetActive))]
    public static void GameObject_SetActive(GameObject __instance, bool value)
    {
        if (!__instance.name.Equals("Pause Menu")) return;
        var scaler = __instance.GetComponentInParent<CanvasScaler>();
        if (value)
        {
            SetSixteenByNine(scaler);
        }
        else
        {
            UltraWideScaling(scaler);
            SetMaxUltrawide();
        }
    }

    private static void UltraWideScaling(CanvasScaler scaler)
    {
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        var instanceName = __instance.name;

        UltraWideScaling(__instance);

        var tf = __instance.transform;
        switch (instanceName)
        {
            case "Game Over Canvas":
            {
                var bg = tf.Find("bg");
                AddBlackBackgroundIfNeeded(tf);
                PerformNegativeXScale(bg);
                break;
            }
            case "Cutscenes Canvas":
            {
                var bg = tf.Find("Cutscene Manager");
                AddBlackBackgroundIfNeeded(tf);
                PerformNegativeXScale(bg);
                break;
            }
        }
    }

    private static void PerformPositiveXYScale(Transform tf)
    {
        tf.localScale = tf.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
    }

    private static void PerformNegativeXScale(Transform tf)
    {
        tf.localScale = tf.localScale with {x = Plugin.NegativeScaleFactor};
    }

    private static void AddBlackBackgroundIfNeeded(Transform parent)
    {
        if (parent.Find("bg_black") != null) return;
        var go = new GameObject("bg_black");
        go.transform.SetParent(parent, false);
        go.transform.SetAsFirstSibling();
        var img = go.AddComponent<Image>();
        img.color = Color.black;
        img.rectTransform.anchorMin = Vector2.zero;
        img.rectTransform.anchorMax = Vector2.one;
        img.rectTransform.sizeDelta = Vector2.zero;
        img.rectTransform.anchoredPosition = Vector2.zero;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution(ref int width, ref int height)
    {
        var callingMethod = new StackTrace().GetFrame(3).GetMethod();
        if (callingMethod.Name.Equals(nameof(GameObject_SetActive))) return;
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
}