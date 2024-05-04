namespace KazeWildMasks;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioEnforcer), nameof(AspectRatioEnforcer.Awake))]
    [HarmonyPatch(typeof(AspectRatioEnforcer), nameof(AspectRatioEnforcer.Update))]
    [HarmonyPatch(typeof(AspectRatioEnforcer), nameof(AspectRatioEnforcer.EnforceCameraToAspect))]
    public static void AspectRatioEnforcer_Patch(ref AspectRatioEnforcer __instance)
    {
        __instance._targetAspect = Plugin.MainAspectRatio;
        __instance._lastScreenHeight = Plugin.MainHeight;
        __instance._lastScreenWidth = Plugin.MainWidth;
        __instance._camera.aspect = Plugin.MainAspectRatio;
        __instance._camera.pixelRect = new Rect(0f, 0f, Plugin.MainWidth, Plugin.MainHeight);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(DefaultParticleSystem), nameof(DefaultParticleSystem.Play))]
    [HarmonyPatch(typeof(DefaultParticleSystem), nameof(DefaultParticleSystem.GetParticles))]
    [HarmonyPatch(typeof(DefaultParticleSystem), nameof(DefaultParticleSystem.SetParticles))]
    public static void DefaultParticleSystem_Play(ref DefaultParticleSystem __instance)
    {
        if (__instance.name.Equals("Rain"))
        {
            __instance.transform.rotation = Quaternion.Euler(0, 0, 0);
            __instance.transform.localScale = __instance.transform.localScale with {x = Plugin.PositiveScaleFactor};
            __instance._particleSystemInstance.maxParticles = 10000;
            __instance._particleSystemInstance.emissionRate = 1000;
        }


        var fogLeft = GameObject.Find("BackGroundWorld01(Clone)/Sky/Fog Left");
        fogLeft.gameObject.SetActive(false);

        var fogRight = GameObject.Find("BackGroundWorld01(Clone)/Sky/Fog Right");
        fogRight.gameObject.SetActive(false);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraManager), nameof(CameraManager.CalculateCameraBounds))]
    public static void CameraManager_FollowPlayer(CameraManager __instance)
    {
        var rect = __instance._calculatedRect;
        var x = rect.x;
        var y = rect.y;
        var height = rect.height;
        var width = height * Plugin.MainAspectRatio;
        //add 25% to the width so items spawn just outside of aspect ratio
        width *= 1.25f;
        rect = new Rect(x, y, width, height);
        __instance._calculatedRect = rect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(GetRect), nameof(GetRect.Invoke))]
    public static void GetRect_Invoke(ref Rect __result)
    {
        var x = __result.x;
        var y = __result.y;
        var height = __result.height;
        var width = height * Plugin.MainAspectRatio;
        //add 25% to the width so items spawn just outside of aspect ratio
        width *= 1.25f;
        __result = new Rect(x, y, width, height);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(BonusCompletedHUDState), nameof(BonusCompletedHUDState.StateOnEnable), typeof(GameHUDStates), typeof(Il2CppReferenceArray<Il2CppSystem.Object>))]
    [HarmonyPatch(typeof(BonusCompletedHUDState), nameof(BonusCompletedHUDState.StateOnEnable), typeof(GameHUDStates), typeof(Il2CppSystem.Object[]))]
    public static void BonusStageLoadingHud_Show(BonusCompletedHUDState __instance)
    {
        __instance.gameObject.TryAddComponent<BonusCompleteScaler>();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraDetectableLevelObject), nameof(CameraDetectableLevelObject.CheckIfVisibleByCamera))]
    public static void CameraDetectableLevelObject_CheckIfVisibleByCamera(ref bool __result)
    {
        __result = true;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(LoadingScreenView), nameof(LoadingScreenView.Awake))]
    [HarmonyPatch(typeof(LoadingScreenView), nameof(LoadingScreenView.FadeIn))]
    [HarmonyPatch(typeof(LoadingScreenView), nameof(LoadingScreenView.FadeOut))]
    [HarmonyPatch(typeof(LoadingScreenView), nameof(LoadingScreenView.PlayLoadingComplete))]
    public static void LoadingScreenView_Awake(ref LoadingScreenView __instance)
    {
        var bg = __instance.transform.FindChild("Canvas/Loading/TransitionCutscene");
        if (bg)
        {
            if (!bg.GetComponent<LoadingScreenScaler>())
            {
                bg.gameObject.AddComponent<LoadingScreenScaler>();
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UITransitionAnimator), nameof(UITransitionAnimator.UpdateScale))]
    public static void UITransitionAnimator_UpdateScale(ref UITransitionAnimator __instance)
    {
        var bg = __instance.transform.FindChild("Bkg/BG");
        var r = bg.GetComponent<RectTransform>();

        var y = r.sizeDelta.y;
        var x = y * Plugin.MainAspectRatio;
        r.sizeDelta = new Vector2(x, y);
    }

    private static void ReplaceImage(Image image, string graphic)
    {
        var y = image.rectTransform.sizeDelta.y;
        var x = y * Plugin.MainAspectRatio;
        image.rectTransform.sizeDelta = new Vector2(x, y);

        var pivot = image.rectTransform.pivot;

        var resourceName = Plugin.MainAspectRatio switch
        {
            >= Plugin.SuperWideAspectRatio => $"KazeWildMasks.assets.{graphic}-32-9.png",
            > Plugin.BaseAspectRatio => $"KazeWildMasks.assets.{graphic}-21-9.png",
            _ => $"KazeWildMasks.assets.{graphic}-21-9.png"
        };

        var assembly = Assembly.GetExecutingAssembly();
        var texture = new Texture2D(2, 2, TextureFormat.RGBA32, false);

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                Plugin.Logger.LogError($"Embedded image resource not found: {resourceName}");
                return;
            }

            var imageData = new byte[stream.Length];
            _ = stream.Read(imageData, 0, imageData.Length);
            if (!ImageConversion.LoadImage(texture, imageData))
            {
                Plugin.Logger.LogError("Failed to load image data into texture");
                return;
            }
        }

        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), pivot);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        var loading = __instance.transform.FindChild("Loading");
        if (loading)
        {
            var rect = loading.GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        }

        var slots = __instance.transform.FindChild("SlotScreen/ScreenLayout/ButtonArea");
        if (slots)
        {
            slots.localPosition = slots.localPosition with {x = 0};
        }
        var splash = __instance.transform.FindChild("Splash");
        if (splash)
        {
            var image = splash.GetComponent<Image>();
            ReplaceImage(image, "splash");
        }

        Plugin.UpdateBackgrounds();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(LogoScreenManager), nameof(LogoScreenManager.SceneAwake))]
    public static void LogoScreenManager_SceneAwake(ref LogoScreenManager __instance)
    {
        var splash = __instance.transform.FindChild("Splash");
        var image = splash.GetComponent<Image>();
        ReplaceImage(image, "splash");
        __instance._logosAnimation = string.Empty;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AlbumScene), nameof(AlbumScene.SceneStart))]
    public static void AlbumScene_SceneAwake(ref AlbumScene __instance)
    {
        var bg = __instance.transform.FindChild("View/Canvas/Lanes/LanesBackground");
        var image = bg.GetComponent<Image>();

        var y = image.rectTransform.sizeDelta.y;
        var x = y * Plugin.MainAspectRatio;
        image.rectTransform.sizeDelta = new Vector2(x, y);

        var pivot = image.rectTransform.pivot;

        var resourceName = Plugin.MainAspectRatio switch
        {
            >= Plugin.SuperWideAspectRatio => "KazeWildMasks.assets.album-32-9.png",
            > Plugin.BaseAspectRatio => "KazeWildMasks.assets.album-21-9.png",
            _ => "KazeWildMasks.assets.album-21-9.png"
        };

        var assembly = Assembly.GetExecutingAssembly();
        var texture = new Texture2D(2, 2, TextureFormat.RGBA32, false);

        using (var stream = assembly.GetManifestResourceStream(resourceName))
        {
            if (stream == null)
            {
                Plugin.Logger.LogError($"Embedded image resource not found: {resourceName}");
                return;
            }

            var imageData = new byte[stream.Length];
            _ = stream.Read(imageData, 0, imageData.Length);
            if (!ImageConversion.LoadImage(texture, imageData))
            {
                Plugin.Logger.LogError("Failed to load image data into texture");
                return;
            }
        }

        image.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), pivot);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuScene), nameof(MenuScene.SceneStart))]
    public static void MenuScene_SceneAwake(ref MenuScene __instance)
    {
        var sky1 = __instance.transform.FindChild("MenuBackground/SkyGlow");
        sky1.localScale = sky1.localScale with {x = Plugin.PositiveScaleFactor};

        var sky2 = __instance.transform.FindChild("MenuBackground/Sky");
        sky2.localScale = sky1.localScale with {x = Plugin.PositiveScaleFactor};
    }

    [HarmonyPostfix]
    // [HarmonyPatch(typeof(ResultsHUDState), nameof(ResultsHUDState.Initialize))]
    // [HarmonyPatch(typeof(ResultsHUDState), nameof(ResultsHUDState.StateInitialize))]
    [HarmonyPatch(typeof(ResultsHUDState), nameof(ResultsHUDState.Initialize))]
    public static void ResultsHUDState_Initialize(ref ResultsHUDState __instance)
    {
        var bg = __instance.transform.FindChild("TimeTrialResultsScreen/View/BKG");
        bg.transform.localScale = bg.transform.localScale with {x = Plugin.PositiveScaleFactor};
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameplayManager), nameof(GameplayManager.ShowCutsceneBars))]
    public static bool GameplayManager_ShowCutsceneBars()
    {
        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectZoomController), nameof(PixelPerfectZoomController.Update))]
    public static void PixelPerfectZoomController_Update(ref PixelPerfectZoomController __instance)
    {
        __instance._camera.cropFrameX = false;
        __instance._camera.cropFrameY = false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.Awake))]
    [HarmonyPatch(typeof(LetterboxCamera), nameof(LetterboxCamera.Update))]
    public static void LetterboxCamera_Patches(ref LetterboxCamera __instance)
    {
        __instance._camera.pixelRect = new Rect(0f, 0f, Plugin.MainWidth, Plugin.MainHeight);
        __instance._camera.aspect = Plugin.MainAspectRatio;
    }

}