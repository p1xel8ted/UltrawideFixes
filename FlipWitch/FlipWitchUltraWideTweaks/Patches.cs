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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ZoneBackrounds), nameof(ZoneBackrounds.setTextures))]
    public static void ZoneBackgrounds_setTextures(ZoneBackrounds __instance)
    {
        var transform = __instance.transform;
        transform.localScale = transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        var y = __instance.referenceResolution.y;
        __instance.referenceResolution = __instance.referenceResolution with {x = y * Plugin.CurrentAspect};

        if (__instance.name.Equals("Game Over Canvas"))
        {
            if (__instance.transform.Find("bg_black") == null)
            {
                var go = new GameObject("bg_black");
                go.transform.SetParent(__instance.transform);
                go.transform.SetAsFirstSibling();
                var img = go.AddComponent<Image>();
                img.color = Color.black;
                img.rectTransform.anchorMin = new Vector2(0, 0);
                img.rectTransform.anchorMax = new Vector2(1, 1);
                img.rectTransform.sizeDelta = new Vector2(0, 0);
                img.rectTransform.anchoredPosition = new Vector2(0, 0);
                img.rectTransform.localScale = new Vector3(200f, 200f, 1);
            }
            var bg = __instance.transform.Find("bg");
            bg.localScale = bg.localScale with {x = Plugin.NegativeScaleFactor};
        }

        if (__instance.name.Equals("Gacha Machine Overlay"))
        {
            __instance.scaleFactor = Plugin.PositiveScaleFactor;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution(ref int width, ref int height)
    {
        width = Plugin.MainWidth;
        height = Plugin.MainHeight;
    }
}