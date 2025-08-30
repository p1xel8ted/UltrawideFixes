using MegaPixel.Menus;
using MegaPixel.VideoPlayer;
using TheHouseOfTheDead2Remake.Helpers;
using TheHouseOfTheDead2Remake.Misc;
using TheHouseOfTheDead2Remake.MonoBehaviours;

namespace TheHouseOfTheDead2Remake.Patches;

[Harmony]
public static class Patches
{
    /// <summary>
    /// Overrides quality settings set by the game based on user-preferences
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int))]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel()
    {
        QualSettings.UpdateSettings();
    }

    /// <summary>
    /// Forces game to apply expensive changes when quality settings are changed    
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    public static void QualitySettings_SetQualityLevel(ref bool applyExpensiveChanges)
    {
        applyExpensiveChanges = true;
    }


    [HarmonyPrefix]
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HD_CutsceneUI), nameof(HD_CutsceneUI.makeVisible))]
    [HarmonyPatch(typeof(HD_CutsceneUI), nameof(HD_CutsceneUI.slidePanels))]
    public static void HD_PlayerCamera_OnEnable(HD_CutsceneUI __instance, ref bool _visible)
    {
        _visible = false;
        __instance.upperPanel.gameObject.SetActive(false);
        __instance.lowerPanel.gameObject.SetActive(false);
        Plugin.Log.LogWarning($"HD_CutsceneUI makeVisible called with _visible={_visible}. This is a workaround for the game not setting it correctly. If you see this message, please report it to the plugin author.");
    }


    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        foreach (var vol in volume.profile.components)
        {
            var name = vol.name.Replace("(Clone)", "");
            var configEntryGlobal = Plugin.ConfigFile.Bind("06. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes.StartOrder-- }));
            configEntryGlobal.SettingChanged += (_, _) => { Volumes.UpdateVolumes(); };
            if (Volumes.ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
            {
                if (!Plugin.Notifications.Value) return;
                MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopLeft, 5, Color.white);
            }
        }
    }

    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.OnEnable))]
    public static void Volume_OnEnable(Volume __instance)
    {
        Volumes.UpdateVolumes();
    }

    /// <summary>
    /// Corrects scaling for certain UI components    
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        //unity explorer
        if (__instance.name.Contains("sinai")) return;

        //the post-processing notifications canvas
        if (__instance.name == "MessageCanvas") return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }

    /// <summary>
    /// Forces VideoPlayer to fit vertically, and scales the raw image accordingly so that the video is maintained to 16:9 and not cut-off.
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MP_VideoPlayableAsset), nameof(MP_VideoPlayableAsset.CreateVideoPlayer))]
    public static void MP_VideoPlayableAsset_CreateVideoPlayer(MP_VideoPlayableAsset __instance)
    {
        __instance.AspectRatio = VideoAspectRatio.FitVertically;
        Plugin.Log.LogWarning($"Aspect ratio for {__instance.name} set to FitVertically. This is a workaround for the game not setting it correctly.");
    }

    /// <summary>
    /// Forces VideoPlayer to fit vertically, and scales the raw image accordingly so that the video is maintained to 16:9 and not cut-off.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.Play))]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.PlayClip))]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.OnEnable))]
    [HarmonyPatch(typeof(MP_VideoPlayerController), nameof(MP_VideoPlayerController.showVideoImage))]
    public static void MP_VideoPlayerController_Play(MP_VideoPlayerController __instance)
    {
        if (__instance.videoPlayer)
        {
            Videos.UpdatePlayer(__instance);
    
            Videos.VideoPlayers.Add(__instance);
        }
    }
}