using Astronomics.Helpers;
using Astronomics.Misc;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Astronomics.Patches;

[Harmony]
public static class Patches
{
    private static readonly string[] AdjustThese = ["MapCanvas", "MainMenuCanvas", "TransitionCanvas", "NotificationCanvas", "CubeCorpBaseCanvas"];
    
    /// <summary>
    /// Dynamically registers configuration entries for each volume component when a new volume is registered.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume))]
    [HarmonyPatch(typeof(PostProcessManager), nameof(PostProcessManager.Register), typeof(PostProcessVolume), typeof(int))]
    public static void PostProcessManager_Register(PostProcessVolume volume)
    {
        Volumes.ProcessVolumeRegistration(volume);
    }
    
    /// <summary>
    /// Updates volume components when a volume is enabled.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessEffectSettings), nameof(PostProcessEffectSettings.OnEnable))]
    public static void PostProcessEffectSettings_OnEnable(PostProcessEffectSettings __instance)
    {
        Volumes.UpdateVolumes();
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
    /// Makes the main display resolution the only one available.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuGraphicsControls), nameof(MainMenuGraphicsControls.FilterResolutions))]
    public static void MainMenuGraphicsControls_FilterResolutions(MainMenuGraphicsControls __instance, ref Resolution[] __result)
    {
        var res = __result.ToList();
        res.Clear();
        res.Add(Resolutions.MainResolution);
        res.Add(Resolutions.MainResolution);
        res.Add(Resolutions.MainResolution);

#if DEBUG
        res.Add(Resolutions.SixteenTenRes);
        res.Add(Resolutions.ThirtyTwoNineRes);
        res.Add(Resolutions.FourtyEightNineRes);
#endif

        res = res.Distinct(new ResolutionEqualityComparer()).ToList();
        res.SortByPixelCount();
        __result = res.ToArray();
    }


    /// <summary>
    /// Because we destroy the object, this stops the game spewing out errors
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.HideWelcomeMessage))]
    public static bool MainMenuController_HideWelcomeMessage()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.OnEnable))]
    public static void MainMenuController_OnEnable(MainMenuController __instance)
    {
        // Remove the welcome message
        Object.Destroy(__instance.m_demoWelcomeMessage);
        Object.Destroy(__instance.m_playtestWelcomeMessage);
        
        //disable demo buttons
        var buttons = __instance.transform.Find("DemoButtons");
        if (buttons)
        {
            buttons.gameObject.SetActive(false);
        }
        
        //scale background image to fitt the screen
        var bg = __instance.transform.Find("BackgroundHalf");
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with { x = Resolutions.ScaleFactor };
        }
    }


    /// <summary>
    /// Ensures the main intro video plays in the correct aspect, and enables black bars to hide the gameworld behind
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        __instance.aspectRatio = VideoAspectRatio.FitVertically;
        __instance.loopPointReached += BlackBars.DisablePillarBoxing;

        if (__instance.clip.name == "earth_zoom_intro_video")
        {
            BlackBars.EnablePillarBoxing();  
        }
        else
        {
            BlackBars.DisablePillarBoxing();
        }
    }
    
   
    /// <summary>
    /// Scales the semi-transparent background of the sell screen to fit the screen
    /// Clones the image to a new object and scales that, so its only the background that is scaled, not the UI
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(CorpMenuViewSellResources), nameof(CorpMenuViewSellResources.ShowEarthDollarsPopup))]
    public static void CorpMenuViewSellResources_ShowEarthDollarsPopup(CorpMenuViewSellResources __instance)
    {
        var img = __instance.m_earthDollarsPopup.GetComponent<Image>();
        if (img)
        {
            Utils.CloneImage(img, __instance.m_earthDollarsPopup.transform, "NewBackground", true);
            img.enabled = false;
        }
    }
    
   
    /// <summary>
    /// Increases scale from 10 to 14 for the black background of the map view notifications
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MapViewController), nameof(MapViewController.Start))]
    public static void MapViewController_Start(MapViewController __instance)
    {
        var bg = __instance.transform.Find("CorpViewScanner/InfoPanelBackground");
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with { x = 14 };
        }
    }
    

    /// <summary>
    /// Corrects the positioning of the map info panels so they are offscreen when not active
    /// Also increases the tween time to 4x
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MapItemInformationPanel), nameof(MapItemInformationPanel.TweenElementToXAxisCoordinate))]
    public static void SlideOffScreen_SlideOffScreen(MapItemInformationPanel __instance, Transform target, ref float xAxisCoodinate, ref float tweenTime)
    {
        tweenTime /= 4f;
        
        //left side hidden
        if (Mathf.Approximately(xAxisCoodinate, -900))
        {
            xAxisCoodinate = -900 * Resolutions.ScaleFactor;
        }

        //right side hidden
        if (Mathf.Approximately(xAxisCoodinate, 1900f))
        {
            xAxisCoodinate = 1900 * Resolutions.ScaleFactor;
        }
    }


    /// <summary>
    /// Hacky solution to get certain backgrounds to stay centered. Only a couple and they aren't active all the time
    /// </summary>
    public class PositionEnforcer : MonoBehaviour
    {
        private void LateUpdate()
        {
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
    
    
    /// <summary>
    /// Scales backgrounds to fit the screen, expands the grid image, and forces the UI components to be 16:9, otherwise they are justified left
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CorpMenuViewCommon), nameof(CorpMenuViewCommon.ShowView))]
    [HarmonyPatch(typeof(CorpMenuViewCommon), nameof(CorpMenuViewCommon.ShowAnimiation))]
    public static void CorpMenuViewCommon_ShowView(CorpMenuViewCommon __instance)
    {
        var g1 = __instance.transform.Find("FullWidthNoGrid");
        if (g1)
        {
            g1.gameObject.SetActive(false);
        }
        var g2 = __instance.transform.Find("FullWidthGrid");
        if (g2)
        {
            g2.gameObject.SetActive(true);
        }
        var g3 = __instance.transform.Find("DoubleGridWidth");
        if (g3)
        {
            g3.gameObject.SetActive(false);
        }
        
        __instance.transform.localPosition = __instance.transform.localPosition with { x = 0 };

        var rect = __instance.GetComponent<RectTransform>();
        if (rect)
        {
            rect.sizeDelta = new Vector2(1080 * Resolutions.CurrentAspect, 1080);
        }

        var img = __instance.GetComponent<Image>();

        var newImg = Utils.CloneImage(img, __instance.transform, "NewBackground", true);

        img.enabled = false;

        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "NewBackground", LayoutController.LayoutSize.ForceFullScreen, 0f, false);

        newImg.gameObject.TryAddComponent<PositionEnforcer>();
    }

    /// <summary>
    /// Scales backgrounds to fit the screen, expands the grid image, and forces the UI components to be 16:9, otherwise they are justified left
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CorpMenuView), nameof(CorpMenuView.ActivateTheStartingItemForControllerUI))]
    public static void CorpMenuView_ShowView(CorpMenuView __instance)
    {
        if (__instance is CorpMenuViewCommon cmv)
        {
            var g1 = cmv.transform.Find("FullWidthNoGrid");
            if (g1)
            {
                g1.gameObject.SetActive(false);
            }
            var g2 = cmv.transform.Find("FullWidthGrid");
            if (g2)
            {
                g2.gameObject.SetActive(true);
            }
            var g3 = cmv.transform.Find("DoubleGridWidth");
            if (g3)
            {
                g3.gameObject.SetActive(false);
            }
            
            cmv.transform.localPosition = __instance.transform.localPosition with { x = 0 };

            var rect = cmv.GetComponent<RectTransform>();

            rect.sizeDelta = new Vector2(1080 * Resolutions.CurrentAspect, 1080);

            var newImg = __instance.transform.Find("NewBackground");
            if (newImg)
            {
                newImg.transform.localPosition = new Vector3(0, 0, 0);
            }
        }
    }

    /// <summary>
    /// Scales the background of the dialogue HUD to fit the screen
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUDItemGraphic), nameof(HUDItemGraphic.Start))]
    [HarmonyPatch(typeof(HUDItemGraphic), nameof(HUDItemGraphic.ShowItem))]
    public static void HUDItemGraphic_Start(HUDItemGraphic __instance)
    {
        var path = __instance.transform.GetPath();
        if (path.Contains("DialogueHUD"))
        {
            var width = Screen.width * 2f;
            LayoutController.AddLayoutControllerPath(__instance.transform, "BlackoutLayerCropped", LayoutController.LayoutSize.Custom, width, false);
            LayoutController.AddLayoutControllerPath(__instance.transform, "BlackoutLayerCropped (1)", LayoutController.LayoutSize.Custom, width, false);
            LayoutController.AddLayoutControllerPath(__instance.transform, "PanelBackground", LayoutController.LayoutSize.Custom, width, false);
        }
    }

    /// <summary>
    /// Can;t remember, something to do with the dialog
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HUDControllerNotifications), nameof(HUDControllerNotifications.Start))]
    public static void HUDControllerNotifications_Start(HUDControllerNotifications __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, false);
    }
    
    /// <summary>
    /// Reset the player hud scaling after displaying the summary
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CorpMenuViewExpeditionSummary), nameof(CorpMenuViewExpeditionSummary.HideView))]
    public static void CorpMenuViewExpeditionSummary_End(CorpMenuViewExpeditionSummary __instance)
    {
        var cs = Resources.FindObjectsOfTypeAll<CanvasScaler>().FirstOrDefault(a => a.name == "PlayerHUDCanvas");
        if (cs)
        {
            cs.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        }
    }

    
    /// <summary>
    /// The summary screen shares a scaler with the playerhud, but is too large. Sets to expand here and gets reset elsewhere
    /// Centers the summary screen
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CorpMenuViewExpeditionSummary), nameof(CorpMenuViewExpeditionSummary.ShowView))]
    public static void CorpMenuViewExpeditionSummary_Start(CorpMenuViewExpeditionSummary __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "BlackBackground", LayoutController.LayoutSize.Custom, Screen.width * 2f, false);

        var collectionSummary = __instance.transform.Find("CloudBackground");
        if (collectionSummary)
        {
            collectionSummary.gameObject.TryAddComponent<PositionEnforcer>();
        }
        
        var cs = Resources.FindObjectsOfTypeAll<CanvasScaler>().FirstOrDefault(a => a.name == "PlayerHUDCanvas");
        if (cs)
        {
            cs.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    
    /// <summary>
    /// Corrects scaling for certain scalers
    /// </summary>
    /// <param name="__instance"></param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (AdjustThese.Contains(__instance.name))
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }
}