// ReSharper disable InconsistentNaming

namespace ButtKnight.Patches;

[Harmony]
public static class Patches
{
    #region Transpiler Patches

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(KidnapCutIn), nameof(KidnapCutIn.PlayCutIn))]
    [HarmonyPatch(typeof(KidnapCutIn), nameof(KidnapCutIn.PlayCutIn), MethodType.Enumerator)]
    [HarmonyPatch(typeof(CutInUI), nameof(CutInUI.EndHCut))]
    [HarmonyPatch(typeof(CutInUI), nameof(CutInUI.EndKissCut))]
    [HarmonyPatch(typeof(KidnapCutIn), nameof(KidnapCutIn.Start))]
    [HarmonyPatch(typeof(CutInUI), nameof(CutInUI.Start))]
    public static IEnumerable<CodeInstruction> PlayCutIn_Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase __originalMethod)
    {
        var originalCode = instructions.ToList();
        var modifiedCode = new List<CodeInstruction>(originalCode);

        try
        {
            for (var i = 0; i < modifiedCode.Count; i++)
            {
                if (modifiedCode[i].opcode != OpCodes.Ldc_R4) continue;

                var value = (float)modifiedCode[i].operand;

                if (!Mathf.Approximately(Mathf.Abs(value), 15f)) continue;

                modifiedCode[i] = new CodeInstruction(OpCodes.Ldc_R4, value);
                modifiedCode.Insert(i + 1, new CodeInstruction(OpCodes.Call, AccessTools.Method(typeof(Patches), nameof(GetAdjustedXOffset))));
                i++;
                Plugin.Log.LogInfo($"Patched {__originalMethod.DeclaringType?.Name}.{__originalMethod.Name} to adjust X offset ({value}f) for {Resolutions.CurrentAspect} aspect ratio.");
            }

            return modifiedCode;
        }
        catch (Exception e)
        {
            Plugin.Log.LogWarning($"Error in {__originalMethod.DeclaringType?.Name}.{__originalMethod.Name} transpiler: {e.Message}. Reverting to original code.");
            return originalCode;
        }
    }

    #endregion

    #region Fields

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    private static readonly List<CanvasScaler> CanvasScalers = [];
    private static readonly List<AspectRatioFitter> AspectRatioFitters = [];
    private static readonly Dictionary<int, Camera.GateFitMode> OriginalGateFits = new();
    internal static readonly List<SpriteRenderer> CreatedBackgroundFillers = [];

    private class TrackedTransform(Transform transform, Vector3 originalScale, float buffer, float verticalScaleFactor = 0f, bool recalculateBuffer = false)
    {
        public readonly Transform transform = transform;
        public readonly float buffer = buffer;
        public readonly Vector3 originalScale = originalScale;
        public readonly float verticalScaleFactor = verticalScaleFactor;
        public readonly bool recalculateBuffer = recalculateBuffer;
    }

    private static readonly Dictionary<int, TrackedTransform> TrackedTransformDict = new();

    #endregion

    #region Helper Methods
    
    private static void ToggleGalleryButton(bool visible)
    {
        var galleryButton = GameObject.Find("[UI]/UICamping/Root/@RB/Gallery");
        if (galleryButton)
        {
            galleryButton.gameObject.SetActive(visible);
        }
    }
    
    internal static void UpdateScalers(float aspect)
    {
        foreach (var scaler in CanvasScalers.Where(scaler => scaler))
        {
            if (!OriginalScreenMatchModes.TryGetValue(scaler.GetInstanceID(), out var originalMode))
            {
                OriginalScreenMatchModes.Add(scaler.GetInstanceID(), scaler.screenMatchMode);
                originalMode = scaler.screenMatchMode;
            }

            scaler.screenMatchMode = aspect > Resolutions.NativeAspect ? CanvasScaler.ScreenMatchMode.Expand : originalMode;
            Plugin.Log.LogInfo($"Updated CanvasScaler '{scaler.name}' (ID: {scaler.GetInstanceID()}): ScreenMatchMode={scaler.screenMatchMode}");
        }
    }

    internal static void CorrectTransformScale(Transform tr, float buffer = 0f, float verticalScaleFactor = 0f, bool recalculateBuffer = false)
    {
        var image = tr.GetComponent<Image>();
        if (image)
        {
            image.maskable = false;
            image.m_Maskable = false;
            if (image.activeSprite && image.activeSprite.name == "ScreenFX_A")
            {
                image.enabled = ConfigManager.ScanLines.Value;
            }

            image.SetAllDirty();
        }

        var id = tr.GetInstanceID();

        // Track this transform for future resolution updates
        if (!TrackedTransformDict.TryGetValue(id, out var tracked))
        {
            tracked = new TrackedTransform(tr, tr.localScale, buffer, verticalScaleFactor, recalculateBuffer);
            TrackedTransformDict.Add(id, tracked);
        }

        var baseScale = tracked.originalScale.x != 0 ? tracked.originalScale.x : 1f;
        var scaleFactor = buffer != 0 ? Resolutions.PositiveScaleFactor + buffer : Resolutions.PositiveScaleFactor;
        var newX = baseScale * scaleFactor;

        var baseScaleY = tracked.originalScale.y != 0 ? tracked.originalScale.y : 1f;
        var newY = verticalScaleFactor != 0 ? baseScaleY * verticalScaleFactor : tracked.originalScale.y;

        tr.localScale = new Vector3(newX, newY, tracked.originalScale.z);
    }

    private static void AddFitter(GameObject go, float aspect = 0)
    {
        if (!go) return;
        var arf = go.TryAddComponent<AspectRatioFitter>();
        arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
        if (aspect > 0)
        {
            arf.aspectRatio = aspect;
        }
        else
        {
            arf.aspectRatio = Resolutions.GetPreferredAspect();
            AspectRatioFitters.Add(arf);
        }
    }

    internal static void UpdateFitters()
    {
        foreach (var arf in AspectRatioFitters.Where(arf => arf))
        {
            arf.aspectRatio = Resolutions.GetPreferredAspect();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            Plugin.Log.LogInfo($"Updated AspectRatioFitter '{arf.name}' (ID: {arf.GetInstanceID()}): AspectRatio={arf.aspectRatio}");
        }
    }

    internal static void UpdateAllTransformScales()
    {
        var baseVerticalFactor = (Resolutions.MainHeight / 1080f) + 0.5f;
        var verticalBuffer = Resolutions.CurrentAspect >= 5.333f ? 0.15f : 0f; // Add buffer for 48:9+
        var verticalPositiveScaleFactor = baseVerticalFactor + verticalBuffer;

        foreach (var tracked in TrackedTransformDict.Values)
        {
            if (!tracked.transform) continue;

            var baseScale = tracked.originalScale.x != 0 ? tracked.originalScale.x : 1f;

            // Recalculate buffer ONLY for worldmap gradients
            var currentBuffer = tracked.recalculateBuffer ? Resolutions.GetGradientBuffer(Resolutions.CurrentAspect) : tracked.buffer;
            var scaleFactor = currentBuffer != 0 && !Mathf.Approximately(currentBuffer, -1) ? Resolutions.PositiveScaleFactor + currentBuffer : Resolutions.PositiveScaleFactor;
            var newX = baseScale * scaleFactor;

            var baseScaleY = tracked.originalScale.y != 0 ? tracked.originalScale.y : 1f;
            var newY = tracked.verticalScaleFactor != 0 ? baseScaleY * verticalPositiveScaleFactor : tracked.originalScale.y;

            tracked.transform.localScale = new Vector3(newX, newY, tracked.originalScale.z);
        }

        Plugin.Log.LogInfo($"Updated {TrackedTransformDict.Count} tracked transform scales for aspect ratio {Resolutions.CurrentAspect}");
    }

    internal static float GetAdjustedXOffset(float originalValue)
    {
        var value = originalValue * Resolutions.PositiveScaleFactor;
        Plugin.Log.LogInfo($"Adjusting X offset from {originalValue} to {value} for aspect ratio {Resolutions.CurrentAspect}");
        return value;
    }

    internal static void UpdateAllCameras()
    {
        var cameras = Camera.allCameras.ToList();
        foreach (var cam in cameras)
        {
            UpdateCamera(cam);
        }
    }

    private static void UpdateCamera(Camera cam)
    {
        if (!cam) return;

        var cameraID = cam.GetInstanceID();
        var gateFit = cam.gateFit;
        if (!OriginalGateFits.TryGetValue(cameraID, out var originalGateFit))
        {
            OriginalGateFits.Add(cameraID, gateFit);
            originalGateFit = gateFit;
        }

        cam.aspect = Resolutions.CurrentAspect;
        cam.pixelRect = new Rect(0, 0, Resolutions.MainWidth, Resolutions.MainHeight);
        cam.rect = new Rect(0, 0, 1, 1);
        cam.gateFit = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : originalGateFit;

        var camViewportScaler = cam.GetComponent<CameraViewportScaler>();
        if (camViewportScaler)
        {
            var scaledRes = new Vector2(camViewportScaler.TargetResolution.y * Resolutions.CurrentAspect, camViewportScaler.TargetResolution.y);
            camViewportScaler.TargetResolution = scaledRes;
            camViewportScaler.cachedResolution = scaledRes;
            camViewportScaler.targetResolution = scaledRes;
        }

        Plugin.Log.LogInfo($"Updated Camera '{cam.name}' (ID: {cameraID}): Aspect={cam.aspect}, PixelRect={cam.pixelRect}, Rect={cam.rect}, GateFit={cam.gateFit}");
    }

    #endregion

    #region Privacy & Rich Presence

    private static void EnsureSteamworksInitialized()
    {
        if (!Singleton<SteamworksManager>.Instance.IsInitialized)
        {
            Singleton<SteamworksManager>.Instance.Initialize();
        }
    }

    internal static void ClearRichPresence()
    {
        try
        {
            // Clear Steam
            if (SteamAPI.IsSteamRunning())
            {
                SteamFriends.ClearRichPresence();
                Plugin.Log.LogInfo("Cleared Steam Rich Presence");
            }

            // Clear Discord
            var discordManager = MonoSingleton<DiscordManager>.Instance;
            if (discordManager)
            {
                discordManager.UpdateState("");
                Plugin.Log.LogInfo("Cleared Discord Rich Presence");
            }
        }
        catch (Exception ex)
        {
            Plugin.Log.LogInfo($"Could not clear Rich Presence: {ex.Message}");
        }
    }

    internal static void TrySetSteamPresence(EPresenceType presenceType = EPresenceType.MainMenu)
    {
        EnsureSteamworksInitialized();

        if (!ConfigManager.RichPresence.Value)
        {
            Plugin.Log.LogInfo("Rich Presence disabled by user config");
            return;
        }

        if (ConfigManager.HidePresenceDuringAdultContent.Value &&
            presenceType == EPresenceType.HStory)
        {
            Plugin.Log.LogInfo("Rich Presence hidden during adult content");
            return;
        }

        var actualPresenceType = ConfigManager.UseGenericPresenceText.Value
            ? EPresenceType.MainMenu
            : presenceType;

        try
        {
            MonoSingleton<PresenceManager>.Instance.SetPresence(actualPresenceType);
        }
        catch (Exception ex)
        {
            Plugin.Log.LogInfo($"Could not set Steam Rich Presence: {ex.Message}");
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PresenceManager), nameof(PresenceManager.SetPresence))]
    public static bool PresenceManager_SetPresence(ref EPresenceType presenceType)
    {
        EnsureSteamworksInitialized();

        if (!ConfigManager.RichPresence.Value)
            return false;

        if (ConfigManager.HidePresenceDuringAdultContent.Value &&
            presenceType == EPresenceType.HStory)
            return false;

        if (ConfigManager.UseGenericPresenceText.Value)
            presenceType = EPresenceType.MainMenu;

        return true;
    }

    private static void InitializeIntroSceneCommon(IntroScene __instance)
    {
        // Gallery text color check
        if (MonoSingleton<GameManager>.Instance.SaveData.highScores.Count == 0)
        {
            __instance.galleryText.color = __instance.galleryDimColor;
        }

        // Nude sprite unlock check
        if (__instance.HasEnoughExtremeHighScores())
        {
            __instance.princessSpriteRenderer.sprite = __instance.PrincessNude;
            __instance.otherSpriteRenderer.sprite = __instance.otherNude;
        }

        TrySetSteamPresence();
    }

    #endregion

    #region Story & Camera Patches

    [HarmonyPostfix]
    [HarmonyPatch(typeof(StoryPlayer), nameof(StoryPlayer.PlayScript))]
    [HarmonyPatch(typeof(StoryPlayer), nameof(StoryPlayer.RunScript))]
    [HarmonyPatch(typeof(StoryPlayer), nameof(StoryPlayer.Start))]
    [HarmonyPatch(typeof(StoryPlayer), nameof(StoryPlayer.Awake))]
    public static void StoryPlayer_PlayScript()
    {
        var bg = GameObject.Find("Naninovel<Runtime>/Background/MainBackground");
        if (bg)
        {
            CreateBackgroundFiller(bg.transform, "BlackFiller", new Color(0.6f, 0.6f, 0.6f, 0.100f));
        }

        UpdateAllCameras();
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Naninovel.CameraManager), nameof(Naninovel.CameraManager.InitializeMainCamera))]
    [HarmonyPatch(typeof(Naninovel.CameraManager), nameof(Naninovel.CameraManager.InitializeUICamera))]
    public static void CameraConfiguration_EvaluateSceneRect(Naninovel.CameraManager __instance, ref Camera __result)
    {
        __result.aspect = Resolutions.CurrentAspect;
        __result.pixelRect = new Rect(0, 0, Resolutions.MainWidth, Resolutions.MainHeight);
        __result.rect = new Rect(0, 0, 1, 1);
        __result.gateFit = Resolutions.CurrentAspect > Resolutions.NativeAspect ? Camera.GateFitMode.Vertical : __result.gateFit;
        Plugin.Log.LogInfo($"Initialized main camera '{__result.name}' with Aspect={__result.aspect}, PixelRect={__result.pixelRect}, Rect={__result.rect}, GateFit={__result.gateFit}");

        UpdateAllCameras();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CameraViewportScaler), nameof(CameraViewportScaler.TargetResolution), MethodType.Setter)]
    public static void CameraViewportScaler_TargetResolution_Setter(CameraViewportScaler __instance, ref Vector2 value)
    {
        var width = value.y * Resolutions.CurrentAspect;
        value = new Vector2(width, value.y);
        Plugin.Log.LogInfo($"CameraViewportScaler.TargetResolution setter called on {__instance.name}, overriding to {value}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraViewportScaler), nameof(CameraViewportScaler.TargetResolution), MethodType.Getter)]
    public static void CameraViewportScaler_TargetResolution_Getter(CameraViewportScaler __instance, ref Vector2 __result)
    {
        var width = __result.y * Resolutions.CurrentAspect;
        __result = new Vector2(width, __result.y);
        Plugin.Log.LogInfo($"CameraViewportScaler.TargetResolution getter called on {__instance.name}, returning {__result}");
    }

    #endregion

    #region UI Component Patches

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CutInUI), nameof(CutInUI.Start))]
    public static void CutInUI_Start(CutInUI __instance)
    {
        __instance.gameObject.TryAddComponent<CutInUIEnforcer>();

        var root = __instance.transform.Find("Root");
        if (root)
        {
            AddFitter(root.gameObject);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(KeyFeedbackCamping), nameof(KeyFeedbackCamping.Start))]
    public static void KeyFeedbackCamping_Start(KeyFeedbackCamping __instance)
    {
        var root = __instance.transform.Find("Root");
        if (root)
        {
            AddFitter(root.gameObject);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(TransitionManager), nameof(TransitionManager.LoadSceneWithTransition))]
    public static void TransitionManager_LoadSceneWithTransition(ref TransitionSettings transition)
    {
        if (!ConfigManager.FasterSceneTransitions.Value) return;
        transition.transitionSpeed = 4f;
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(BossCutins), nameof(BossCutins.Start))]
    public static bool BossCutins_Start(BossCutins __instance)
    {
        AddFitter(__instance.gameObject, 1.78f);

        var grayBox = __instance.transform.Find("GrayBox");
        if (grayBox)
        {
            CorrectTransformScale(grayBox);
        }

        __instance.text.SetActive(false);
        __instance.targetXPos = __instance.transform.Find("CutIn_Img").transform.position.x * (Resolutions.CurrentAspect / 1.6f);
        __instance.bossCutInImage.transform.position = new Vector3(25f, __instance.bossCutInImage.transform.position.y);
        LeanTween.moveX(__instance.bossCutInImage, __instance.targetXPos, 0.75f).setOnComplete(() => { __instance.text.SetActive(true); });


        return false;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(csPauseMenu), nameof(csPauseMenu.Awake))]
    public static void csPauseMenu_Awake(csPauseMenu __instance)
    {
        var grayBox = __instance.transform.Find("Content/GrayBox");
        if (grayBox)
        {
            CorrectTransformScale(grayBox);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIStage), nameof(UIStage.Awake))]
    [HarmonyPatch(typeof(UIStage), nameof(UIStage.OnInitializeStage))]
    public static void UIStage_Awake(UIStage __instance)
    {
        var root = __instance.transform.Find("Root");
        if (root)
        {
            AddFitter(root.gameObject);
        }

        UpdateAllCameras();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIWorldMap), nameof(UIWorldMap.Start))]
    public static void UIWorldMap_Start(UIWorldMap __instance)
    {
        var blackBox = __instance.transform.Find("BlackBox");
        if (blackBox)
        {
            blackBox.gameObject.SetActive(false);
        }
    }

    private static string SceneName => SceneManager.GetActiveScene().name;

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldStageController), nameof(WorldStageController.Start))]
    public static void WorldStageController_Start(WorldStageController __instance)
    {
        if (!ConfigManager.AlternateWorldMapView.Value)
        {
            //option 1 - correct default game world map view for ultra-wide

            var buffer = Resolutions.GetGradientBuffer(Resolutions.CurrentAspect);
            var baseVerticalFactor = (Resolutions.MainHeight / 1080f) + 0.5f;
            var verticalBuffer = Resolutions.CurrentAspect >= 5.333f ? 0.15f : 0f; // Add buffer for 48:9+
            var verticalPositiveScaleFactor = baseVerticalFactor + verticalBuffer;

            // Handle gradients and ColorBg in one pass
            foreach (var name in new[] { "GradiantL", "GradiantR", "ColorBg" })
            {
                var tr = __instance.transform.Find(name);
                if (tr)
                {
                    // Apply buffer correction if needed (only for gradients)
                    if (buffer >= 0 && name != "ColorBg")
                    {
                        CorrectTransformScale(tr, buffer, verticalPositiveScaleFactor, recalculateBuffer: true);
                    }
                    else if (name == "ColorBg")
                    {
                        CorrectTransformScale(tr, 0f, verticalPositiveScaleFactor);
                    }
                }
            }
        }
        else
        {
            //option 2 - alternate view with dark grey background and no gradients

            // Create fullscreen dark grey background as first sibling
            // var sr = CreateBackgroundFiller(__instance.transform, "NewBackground", ConfigManager.AlternateMapColor.Value);
            // CreatedBackgroundFillers.Add(sr);

            if (Camera.main && SceneName == "World")
            {
                Camera.main.backgroundColor = ConfigManager.AlternateMapColor.Value;
            }

            //disable gradients and ColorBg, and lines
            foreach (var name in new[] { "GradiantL", "GradiantR", "ColorBg", "BeautifulLine_L", "BeautifulLine_R" })
            {
                var tr = __instance.transform.Find(name);
                if (tr)
                {
                    tr.gameObject.SetActive(false);
                }
            }
        }

        //anything below this stays regardless of user option chosen

        // Disable BlackBar
        var blackBar = __instance.transform.Find("BlackBar");
        if (blackBar)
        {
            blackBar.gameObject.SetActive(false);
        }

        UpdateAllCameras();
    }


    private static void CreateBackgroundFiller(Transform parent, string name, Color color, bool checkExisting = true)
    {
        if (checkExisting && parent.Find(name))
        {
            return;
        }

        var bgObject = new GameObject(name);
        bgObject.transform.SetParent(parent, false);
        bgObject.transform.SetAsFirstSibling();

        var texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, Color.white);
        texture.Apply();

        var sprite = Sprite.Create(texture, new Rect(0, 0, 1, 1), new Vector2(0.5f, 0.5f));
        var spriteRenderer = bgObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
        spriteRenderer.sortingOrder = -100;
        spriteRenderer.color = color;

        // Scale to fill screen
        bgObject.transform.localScale = new Vector3(Screen.width, Screen.height, 1);
        bgObject.transform.localPosition = Vector3.zero;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(RevealableTextPrinterPanel), nameof(RevealableTextPrinterPanel.Awake))]
    [HarmonyPatch(typeof(RevealableTextPrinterPanel), nameof(RevealableTextPrinterPanel.OnEnable))]
    [HarmonyPatch(typeof(RevealableTextPrinterPanel), nameof(RevealableTextPrinterPanel.HandleVisibilityChanged))]
    public static void RevealableTextPrinterPanel_OnEnable(RevealableTextPrinterPanel __instance)
    {
        var gradientOverlay = __instance.transform.Find("BlackGradient");
        if (gradientOverlay)
        {
            var image = gradientOverlay.GetComponent<Image>();
            if (image)
            {
                image.enabled = false;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai")) return;

        CanvasScalers.Add(__instance);

        UpdateScalers(Resolutions.CurrentAspect);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Movement2d), nameof(Movement2d.Awake))]
    [HarmonyPatch(typeof(Movement2d), nameof(Movement2d.Start))]
    public static void Movement2d_Awake(Movement2d __instance)
    {
        if (__instance.name == "Fog_Bg")
        {
            CorrectTransformScale(__instance.transform);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlaySoundFXRandom), nameof(PlaySoundFXRandom.OnEnable))]
    public static void PlaySoundFXRandom_OnEnable(PlaySoundFXRandom __instance)
    {
        if (__instance.name == "Thunder")
        {
            CorrectTransformScale(__instance.transform);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Gallery), nameof(Gallery.Open))]
    public static void Gallery_Open(Gallery __instance)
    {
        if (Resolutions.GetPreferredAspect() > Resolutions.NativeAspect)
        {
            ToggleGalleryButton(false);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Gallery), nameof(Gallery.Close))]
    public static void Gallery_Close(Gallery __instance)
    {
        ToggleGalleryButton(true);
    }

    #endregion

    #region Scene & Intro Patches

    private static void SkipAll(IntroScene __instance)
    {
        __instance.idleMovie.SetActive(false);
        __instance.introAnimator.gameObject.SetActive(true);
        __instance.introAnimator.speed = 100f;
        __instance.introAnimator.Update(100f);
        __instance.introAnimator.enabled = false;
        __instance.state = IntroScene.EState.ShowMenu;
        __instance.timerSinceStarted = 0f;
        __instance.pressAnyKey.SetActive(false);
        __instance.menuCanvasGroup.alpha = 1f;
        __instance.menuFadeTimer = float.MaxValue;

        foreach (var logo in __instance.logoObjects)
        {
            var pos = logo.transform.localPosition;
            logo.transform.localPosition = pos + Vector3.up * __instance.logoYDelta;
        }

        __instance.titleShadow.color = new Color(1f, 1f, 1f, 1f);
        LeanTween.cancel(__instance.titleShadow.gameObject);
        AchievementManager.CheckAllAchievementsFromSave();
        InitializeIntroSceneCommon(__instance);
    }

    private static void SkipIdleMovieOnly(IntroScene __instance)
    {
        __instance.idleMovie.SetActive(false);
        __instance.introAnimator.gameObject.SetActive(true);
        __instance.state = IntroScene.EState.IntroAnimationPlaying;
        __instance.timerSinceStarted = 0f;
        InitializeIntroSceneCommon(__instance);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(IntroScene), nameof(IntroScene.Start))]
    public static bool IntroScene_Start(IntroScene __instance)
    {
        switch (ConfigManager.SkipChoiceConfig.Value)
        {
            case Plugin.SkipChoice.SkipAll:
                SkipAll(__instance);
                return false;
            case Plugin.SkipChoice.SkipNone:
                return true;
            case Plugin.SkipChoice.SkipInsertAnyCoinOnly:
                SkipIdleMovieOnly(__instance);
                return false;
            default:
                return true;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(ChangeBackgroundByCharm), nameof(ChangeBackgroundByCharm.Start))]
    public static void ChangeBackgroundByCharm_Start()
    {
        if (Camera.main && SceneName == "GameOver")
        {
            Camera.main.backgroundColor = new Color(0.0824f, 0.0706f, 0.0627f, 1f);
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SceneSwitcher), nameof(SceneSwitcher.Update))]
    [HarmonyPatch(typeof(SceneSwitcher), nameof(SceneSwitcher.NextScene))]
    public static bool SceneSwitcher_Update(SceneSwitcher __instance)
    {
        var currentSceneName = SceneManager.GetActiveScene().name;
        return currentSceneName != "Logo";
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SettingsUI), nameof(SettingsUI.Show))]
    [HarmonyPatch(typeof(SettingsUI), nameof(SettingsUI.Awake))]
    public static void SettingsUI_Show(SettingsUI __instance)
    {
        __instance.resolution.gameObject.SetActive(false);
        __instance.screenMode.gameObject.SetActive(false);
    }

    #endregion
}