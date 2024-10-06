// ReSharper disable InconsistentNaming

namespace TheyAlwaysRun;

[Harmony]
public static class Patches
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(PureResolution), nameof(PureResolution.IsFitRatio))]
    public static bool PureResolution_IsFitRatio(PureResolution __instance, float ratio, ref bool __result)
    {
        //any ratio is a fit ratio
        __result = true;
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VersionUI), nameof(VersionUI.OnEnable))]
    public static void VersionUI_OnEnable(VersionUI __instance)
    {
        //hide the version number from anywhere
        __instance.Version.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuUI), nameof(MainMenuUI.SubMenusAll), MethodType.Getter)]
    [HarmonyPatch(typeof(MainMenuUI), nameof(MainMenuUI.SubMenusRelease), MethodType.Getter)]
    public static void MainMenuUI_SubMenusAll(MainMenuUI __instance, ref IEnumerable<MainMenuButtonUI> __result)
    {
        //removes the credits button from the main menu so that navigation functions correctly
        var subMenuList = new List<MainMenuButtonUI>(__result);
        subMenuList.RemoveAll(button => button.name == "ButtonCredits");
        __result = subMenuList;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LevelGraphicsBackController), nameof(LevelGraphicsBackController.Show), [])]
    [HarmonyPatch(typeof(LevelGraphicsBackController), nameof(LevelGraphicsBackController.SetParent))]
    [HarmonyPatch(typeof(LevelGraphicsBackController), nameof(LevelGraphicsBackController.Reset))]
    private static void LevelGraphicsBackController_Show(LevelGraphicsBackController __instance)
    {
        //scales the background parallax to fit the screen. Might look weird on some levels or at 32:9+
        var mainBackground = __instance.transform.Find("MainBack");
        if (mainBackground)
        {
            mainBackground.localScale = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuUI), nameof(MainMenuUI.Awake))]
    //[HarmonyPatch(typeof(MainMenuUI), nameof(MainMenuUI.Show))]
    public static void MainMenuUI_OnEnable(MainMenuUI __instance)
    {
        //disable useless buttons
        __instance.Credits.gameObject.SetActive(false);
        __instance.DiscordButton.gameObject.SetActive(false);
        __instance.SurveyButton.gameObject.SetActive(false);
        __instance.WishListButton.gameObject.SetActive(false);

        // Update the anchored position of the main menu elements to mimic 16:9. ContentSizeFitter didn't function here

        Utils.UpdateAnchoredXPosition(__instance.transform, Plugin.BlackBarSize - 200f);

        foreach (var menu in __instance.SubMenusAll)
        {
            Utils.UpdateAnchoredXPosition(menu.transform, Plugin.BlackBarSize - 200f);
        }

        foreach (var menu in __instance.SubMenusRelease)
        {
            Utils.UpdateAnchoredXPosition(menu.transform, Plugin.BlackBarSize - 200f);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuStartUI), nameof(MainMenuStartUI.Awake))]
    [HarmonyPatch(typeof(MainMenuSlotsUI), nameof(MainMenuSlotsUI.Awake))]
    [HarmonyPatch(typeof(MainMenuOptionsUI), nameof(MainMenuOptionsUI.Awake))]
    [HarmonyPatch(typeof(MainMenuControlUI), nameof(MainMenuControlUI.Awake))]
    [HarmonyPatch(typeof(MainMenuLevelsUI), nameof(MainMenuLevelsUI.Awake))]
    [HarmonyPatch(typeof(MainMenuExitUI), nameof(MainMenuExitUI.Awake))]
    [HarmonyPatch(typeof(MainMenuResetProgressConfirmationUI), nameof(MainMenuResetProgressConfirmationUI.Awake))]
    public static void MainMenuStartUI_OnEnable(MonoBehaviour __instance)
    {
        if (__instance.gameObject.GetFullPath().Contains("MenuGame")) return;

        // Update the anchored position of the main menu sub elements to mimic 16:9. ContentSizeFitter didn't function here
        Utils.UpdateAnchoredXPosition(__instance.transform, Plugin.BlackBarSize - 200f);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(DamageScreenUI), nameof(DamageScreenUI.Awake))]
    public static void DamageScreenUI_OnEnable(DamageScreenUI __instance)
    {
        //force death flash to be full screen regardless of settings
        Utils.AddFixedContentSizeFitter(__instance.gameObject, 1080 * Plugin.MainAspectRatio);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Prepare))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.Play))]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.StepForward))]
    public static void VideoPlayer_Play(VideoPlayer __instance)
    {
        //video is targeting a renderTexture so this does nothing...but..i..cant..stop..myself
        __instance.aspectRatio = VideoAspectRatio.FitVertically;

        //enable pillar boxing when video is playing
        Utils.EnablePillarBoxing();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(VideoPlayer), nameof(VideoPlayer.InvokeLoopPointReachedCallback_Internal))]
    public static void VideoPlayer_Stop(VideoPlayer __instance)
    {
        //turn off pillar boxing when video is done
        Utils.DisablePillarBoxing();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(UnitMessagesContainer), nameof(UnitMessagesContainer.Awake))]
    public static void UnitMessagesContainer_Start(DamageScreenUI __instance)
    {
        //add a contentSizeFitter to the unit messages container (the radio thing)
        Utils.AddContentSizeFitter(__instance.gameObject);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroUI), nameof(IntroUI.Awake))]
    public static void IntroUI_Show(IntroUI __instance)
    {
        //force the intro screen and videos to be 16:9 regardless of settings (otherwise it's stretched)
        Utils.AddFixedContentSizeFitter(__instance.gameObject, 1080 * Plugin.NativeAspectRatio);
    }



    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroShopUI), nameof(HeroShopUI.Awake))]
    public static void HeroShopUI_Start(HeroShopUI __instance)
    {
        //add a contentSizeFitter to the hero shop/skills/talents UI
        Utils.AddContentSizeFitter(__instance.gameObject);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(HeroShopUI), nameof(HeroShopUI.Show))]
    public static void HeroShopUI_Show(HeroShopUI __instance)
    {
        //toggle pillar boxing when the hero shop is open depending on settings
        if (Plugin.RestrictHUD.Value)
        {
            Utils.EnablePillarBoxing();
        }
        else
        {
            Utils.DisablePillarBoxing();
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeroShopUI), nameof(HeroShopUI.Hide))]
    public static void HeroShopUI_Hide(DamageScreenUI __instance)
    {
        Utils.DisablePillarBoxing();
    }
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(EngagingController), nameof(EngagingController.Update))]
    [HarmonyPatch(typeof(EngagingController), nameof(EngagingController.FixedUpdate))]
    public static void EngagingController_Update(EngagingController __instance)
    {
        __instance.Success();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains("sinai")) return;

        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        if (__instance.name == "InGameUI")
        {
            Utils.AddContentSizeFitter(__instance.gameObject);
        }

        if (__instance.name.Equals("MenuUI"))
        {
            var bg = __instance.transform.Find("Background");
            if (bg)
            {
                Utils.UpdateMenuBackground(bg.GetComponent<Image>());
            }

            var logo = __instance.transform.Find("Logo");
            if (logo)
            {
                logo.position = logo.position with { x = Plugin.BlackBarSize };
            }
        }
    }
}