namespace Astronomics.Patches;

[Harmony]
public static class Patches
{
    // private static readonly string[] AdjustThese = ["MapCanvas", "MainMenuCanvas", "TransitionCanvas", "NotificationCanvas", "CubeCorpBaseCanvas"];

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
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.OnEnable))]
    public static void Volume_OnEnable(PostProcessVolume __instance)
    {
        Volumes.UpdateSingleVolume(__instance);
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

    // /// <summary>
    // /// Overrides quality settings set by the game based on user-preferences
    // /// </summary>
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int))]
    // [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    // public static void QualitySettings_SetQualityLevel()
    // {
    //     QualSettings.UpdateSettings();
    // }
    //
    // /// <summary>
    // /// Forces game to apply expensive changes when quality settings are changed    
    // /// </summary>
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(QualitySettings), nameof(QualitySettings.SetQualityLevel), typeof(int), typeof(bool))]
    // public static void QualitySettings_SetQualityLevel(ref bool applyExpensiveChanges)
    // {
    //     applyExpensiveChanges = true;
    // }

    /// <summary>
    /// Makes the main display resolution the only one available.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuGraphicsControls), nameof(MainMenuGraphicsControls.FilterResolutions))]
    public static void MainMenuGraphicsControls_FilterResolutions(MainMenuGraphicsControls __instance, ref Resolution[] __result)
    {
        var res = __result.ToList();
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


    [HarmonyTranspiler]
    [HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.HideAllWindows))]
    public static IEnumerable<CodeInstruction> MainMenuController_HideAllWindows(IEnumerable<CodeInstruction> instructions)
    {
        var removed = 0;
        foreach (var instr in instructions)
        {
            // look for the first two calls to GameObject.SetActive(...)
            if (removed < 2
                && instr.opcode == OpCodes.Callvirt
                && instr.operand is MethodInfo { Name: nameof(GameObject.SetActive) } mi
                && mi.DeclaringType == typeof(GameObject))
            {
                // replace the callvirt (which would pop [object,bool]) with two Pops
                // to remove the bool and the GameObject reference from the stack
                var popInstr = new CodeInstruction(OpCodes.Pop) { labels = instr.labels };
                yield return popInstr;
                yield return new CodeInstruction(OpCodes.Pop);
                removed++;
            }
            else
            {
                yield return instr;
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuController), nameof(MainMenuController.OnEnable))]
    public static void MainMenuController_OnEnable(MainMenuController __instance)
    {
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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AsteroidRancherGameManager), nameof(AsteroidRancherGameManager.IsIntroCutsceneRunning), MethodType.Setter)]
    public static void AsteroidRancherGameManager_IsIntroCutsceneRunning(bool value)
    {
        if (value)
        {
            BlackBars.EnablePillarBoxing();
        }
        else
        {
            BlackBars.DisablePillarBoxing();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Behaviour), nameof(Behaviour.enabled), MethodType.Setter)]
    public static void Behaviour_enabled(Behaviour __instance, bool value)
    {
        if (__instance is VideoPlayer vp)
        {
            if (vp.clip && vp.clip.name == "earth_zoom_intro_video")
            {
                // if the intro video is playing, enable pillar boxing
                if (value)
                {
                    BlackBars.EnablePillarBoxing();
                }
                else
                {
                    BlackBars.DisablePillarBoxing();
                }
            }
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

        if (__instance.clip && __instance.clip.name == "earth_zoom_intro_video")
        {
            BlackBars.EnablePillarBoxing();
        }
        else
        {
            BlackBars.DisablePillarBoxing();
        }
    }

//    
//     /// <summary>
//     /// Scales the semi-transparent background of the sell screen to fit the screen
//     /// Clones the image to a new object and scales that, so its only the background that is scaled, not the UI
//     /// </summary>
//     [HarmonyPrefix]
//     [HarmonyPatch(typeof(CorpMenuViewSellResources), nameof(CorpMenuViewSellResources.ShowEarthDollarsPopup))]
//     public static void CorpMenuViewSellResources_ShowEarthDollarsPopup(CorpMenuViewSellResources __instance)
//     {
//         var img = __instance.m_earthDollarsPopup.GetComponent<Image>();
//         if (img)
//         {
//             Utils.CloneImage(img, __instance.m_earthDollarsPopup.transform, "NewBackground", true);
//             img.enabled = false;
//         }
//     }
//     
//    
     /// <summary>
     /// Increases scale from 10 to 14 for the black background of the map view notifications
     /// </summary>
     // [HarmonyPrefix]
     // [HarmonyPatch(typeof(MapViewController), nameof(MapViewController.Start))]
     // public static void MapViewController_Start(MapViewController __instance)
     // {
     //     var bg = __instance.transform.Find("CorpViewScanner/InfoPanelBackground");
     //     if (bg)
     //     {
     //         bg.transform.localScale = bg.transform.localScale with { x = 14 };
     //     }
     // }
     //

    /// <summary>
    /// Corrects the positioning of the map info panels so they are offscreen when not active
    /// Also increases the tween time to 4x
    /// </summary>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(MapItemInformationPanel), nameof(MapItemInformationPanel.TweenElementToXAxisCoordinate))]
    public static void SlideOffScreen_SlideOffScreen(MapItemInformationPanel __instance, Transform target, ref float xAxisCoodinate, ref float tweenTime)
    {
        tweenTime /= 4f;
        
        // //left side hidden
        // if (Mathf.Approximately(xAxisCoodinate, -900))
        // {
        //     xAxisCoodinate = -900 * Resolutions.ScaleFactor;
        // }
        //
        // //right side hidden
        // if (Mathf.Approximately(xAxisCoodinate, 1900f))
        // {
        //     xAxisCoodinate = 1900 * Resolutions.ScaleFactor;
        // }
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
}