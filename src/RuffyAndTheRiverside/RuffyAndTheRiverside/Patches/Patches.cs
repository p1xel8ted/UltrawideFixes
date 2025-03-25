using MapMinimap;
using RuffyAndTheRiverside.Helpers;
using RuffyAndTheRiverside.MonoBehaviours;

namespace RuffyAndTheRiverside.Patches;

[Harmony]
public static class Patches
{

    internal static void DisableDemoBarriers()
    {
        var demoStuff = GameObject.Find("Demo Assets Stadt/Parent/Stadt Demo Wände");
        // if (demoStuff)
        // {
        //     demoStuff.SetActive(false);
        //     
        // }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapViewer), nameof(MapViewer.Start))]
    [HarmonyPatch(typeof(MapViewer), nameof(MapViewer.RefreshMap))]
    public static void MapViewer_RefreshMap(MapViewer __instance)
    {
        DisableDemoBarriers();
        
        var black = __instance.transform.Find("Black");
        if (black)
        {
            var img = black.GetComponent<Image>();
            if (img)
            {
                img.color = Color.black;
                img.rectTransform.sizeDelta = img.rectTransform.sizeDelta with { x = 10000, y = 10000 };
                img.MarkDirty();
            }

            black.gameObject.SetActive(true);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapRenderer), nameof(MapRenderer.RenderMap))]
    public static void MapRenderer_RenderMap(MapRenderer __instance)
    {
        __instance.rect_child.localScale = Vector3.one;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MapViewer), nameof(MapViewer.Update))]
    public static void MapViewer_Update(MapViewer __instance)
    {
        __instance.map_render.refresh_rate = 0;
        var pos = Screen.width / 2f;
        __instance.transform.position = __instance.transform.position with { x = pos };
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DialogManager), nameof(DialogManager.Awake))]
    [HarmonyPatch(typeof(DialogManager), nameof(DialogManager.StartDialog))]
    public static void DialogManager_Awake(DialogManager __instance)
    {
        DisableDemoBarriers();
        
        //restrict to 16:9 aspect ratio, but the X position needs to be blackbar size
        if (__instance && __instance.transform)
        {
            LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false, true);
        }
    }


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

    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VolumeManager), nameof(VolumeManager.Register))]
    public static void VolumeManager_Register(Volume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
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
        if (__instance.name.Contains("Kompass")) return;

        //the post-processing notifications canvas
        if (__instance.name == "MessageCanvas") return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        if (__instance.name == "UI")
        {
            var bars = __instance.transform.Find("Balken");
            if (bars)
            {
                var topBar = bars.Find("Balken Oben");
                if (topBar)
                {
                    var image = topBar.GetComponent<Image>();
                    if (image)
                    {
                        var clonedTop = Utils.CloneImage(image, bars, "TopBar", true);
                        if (clonedTop)
                        {
                            image.enabled = false;
                            clonedTop.rectTransform.sizeDelta = clonedTop.rectTransform.sizeDelta with { x = Screen.width };
                        }
                    }

                    FixLine(topBar);
                }

                var bottomBar = bars.Find("Balken Unten");
                if (bottomBar)
                {
                    var image = bottomBar.GetComponent<Image>();
                    if (image)
                    {
                        var clonedBottom = Utils.CloneImage(image, bars, "BottomBar", true);
                        if (clonedBottom)
                        {
                            image.enabled = false;
                            clonedBottom.rectTransform.sizeDelta = clonedBottom.rectTransform.sizeDelta with { x = Screen.width };
                        }
                    }

                    FixLine(bottomBar);
                }
            }

            return;

            void FixLine(Transform tr)
            {
                var line = tr.Find("Balken Linie");
                if (line)
                {
                    var rect = line.GetComponent<RectTransform>();
                    if (rect)
                    {
                        rect.sizeDelta = rect.sizeDelta with { x = Screen.width };
                    }
                }
            }
        }
    }
}