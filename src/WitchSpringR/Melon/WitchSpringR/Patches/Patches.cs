namespace WitchSpringR.Patches;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class Patches
{
    // UI Element Names
    private const string BlackPanelImage = "blackPanel";
    private const string PaperSideImage = "PaperSide";
    private const string UITitle = "UI_Title";

    // Scene Names
    private const string TitleSceneText = "#Title";
    private const string HomePieberryScene = "#Home_Pieberry";

    // UI Paths - Canvas Elements
    private const string LetterboxRightPath = "Canvas/LetterBox_Right";
    private const string LetterboxLeftPath = "Canvas/LetterBox_Left";
    private const string VersionPath = "Canvas/Layer_Mid/UI_Title(Clone)/Under";

    // UI Paths - HUD Elements
    private const string RightHudName = "RightHud";
    private const string LeftHudName = "LeftHud";
    private const string RightHudMiniMapPanel = "RightHud/MiniMapPanel";
    private const string RightHudMapFrame = "RightHud/MiniMapPanel/MapFrame";
    private const string RightHudMapNamePath = "RightHud/MapName";
    private const string RightHudMapNameDotPath = "RightHud/MapName/MapNameDot";
    private const string RightHudMapNameTextPath = "RightHud/MapName/Text";
    private const string FieldMenuPath = "FieldMenu";

    // UI Position Constants
    private const float MapNameDotYPosition = -40f;


    private static readonly string[] LeftItems =
    [
        "Body/MainStatus",
        "Body/MiniMapPanel/PuzzleOperating",
        "Body/MiniMapPanel/FieldMenu",
        "Body/Gold"
    ];

    private static readonly string[] RightItems =
    [
        "Body/MapName",
        "Body/Icon_SkipScene",
        "Body/MiniMapPanel",
        "Body/RightUp"
    ];

    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];

    private static bool _volumeUpdateRequired;

    // Property to manage VolumeUpdateRequired flag and reset tracking when set to true
    internal static bool VolumeUpdateRequired
    {
        get => _volumeUpdateRequired;
        set
        {
            if (value && !_volumeUpdateRequired)
            {
                // Clear tracking only when transitioning from false to true (new update cycle)
                UpdatedVolumeIds.Clear();
            }

            _volumeUpdateRequired = value;
        }
    }

    private static GameObject LeftHud { get; set; }
    private static GameObject RightHud { get; set; }

    private static MainCamera MainCameraInstance { get; set; }

    // Cache for black images to avoid expensive FindObjectsOfTypeAll searches
    // private static readonly List<Image> CachedBlackImages = [];
    // private static string _lastSceneForImageCache = string.Empty;
    // private static string _lastSceneForRunFixes = string.Empty;

    // Track which volumes have been updated to handle multiple volumes correctly
    private static readonly HashSet<int> UpdatedVolumeIds = [];
    private static int _lastVolumeUpdateFrame = -1;

    private static void AdjustBlackImages()
    {
        var allImages = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in allImages)
        {
            if (!image) continue; // Skip destroyed objects

            switch (image.name)
            {
                case BlackPanelImage:
                    image.rectTransform.sizeDelta = new Vector2(Mod.NativeDisplayWidth, Mod.NativeDisplayHeight);
                    break;
                case PaperSideImage:
                    image.gameObject.SetActive(false);
                    break;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_Field), nameof(UI_Field.SetMapName))]
    public static void UI_Field_SetMapName_Postfix(ref UI_Field __instance)
    {
        var mapDots = __instance.transform.FindChild(RightHudMapNameDotPath);
        if (mapDots)
        {
            mapDots.transform.localPosition = mapDots.transform.localPosition with { y = MapNameDotYPosition };
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UI_Field), nameof(UI_Field.SetMapName))]
    public static void UI_Field_SetMapName(ref UI_Field __instance)
    {
        // Add null safety to prevent crashes if UI structure changes
        var mapNameTransform = __instance.transform.FindChild(RightHudMapNamePath);
        if (mapNameTransform)
        {
            var canvasGroup = mapNameTransform.GetComponent<CanvasGroup>();
            if (canvasGroup)
            {
                __instance.cg_mapName = canvasGroup;
            }
        }

        var textTransform = __instance.transform.FindChild(RightHudMapNameTextPath);
        if (textTransform)
        {
            var text = textTransform.GetComponent<Text>();
            if (text)
            {
                __instance.text_mapName = text;
            }
        }

        var dotTransform = __instance.transform.FindChild(RightHudMapNameDotPath);
        if (dotTransform)
        {
            var rectTransform = dotTransform.GetComponent<RectTransform>();
            if (rectTransform)
            {
                __instance.mapNameRect = rectTransform;
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Player), nameof(Player.ActivePlayer))]
    public static void Player_ActivePlayer(ref Player __instance)
    {
        __instance.gameObject.TryAddComponent<ClothsToggler>();
    }

    internal static void UpdateCamera()
    {
        if (!MainCameraInstance) return;

        // Cache scene name to avoid duplicate GetActiveScene calls
        var sceneName = SceneManager.GetActiveScene().name;
        if (sceneName is TitleSceneText or HomePieberryScene) return;

        MainCameraInstance.thisCamera.fieldOfView = 24 + 24 * (Mod.FieldOfView.Value / 100f);
    }

    // Removed MainCamera_Update patch - unnecessary per-frame overhead
    // MainCameraInstance is already cached in Awake and SetCamera patches

    // Helper method to configure camera aspect and pixel rect - reduces duplication
    private static void ConfigureCamera(Camera camera)
    {
        if (!camera) return;
        camera.aspect = Mod.MainAspect;
        camera.pixelRect = Mod.CameraRect;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.Awake))]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.SetCamera))]
    public static void MainCamera_Awake(ref MainCamera __instance)
    {
        MainCameraInstance = __instance;
        VolumeUpdateRequired = true;
        ConfigureCamera(__instance.thisCamera);
        UpdateCamera();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SubCamera), nameof(SubCamera.Awake))]
    public static void SubCamera_Awake(ref SubCamera __instance)
    {
        ConfigureCamera(__instance.thisCamera);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldMapControl), nameof(WorldMapControl.Start))]
    public static void WorldMapControl_Start(ref WorldMapControl __instance)
    {
        RunFixes();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TranslucentImage), nameof(TranslucentImage.OnEnable))]
    public static void TranslucentImage_OnEnable(ref TranslucentImage __instance)
    {
        var path = __instance.transform.GetFullPath();

        if (__instance.name.Equals("Translucent Image"))
        {
            if (path.Contains("Quest", StringComparison.OrdinalIgnoreCase)) return;
            if (path.Contains("Talk", StringComparison.OrdinalIgnoreCase)) return;
            if(path.Contains("Guide", StringComparison.OrdinalIgnoreCase)) return;

            __instance.rectTransform.sizeDelta = new Vector2(Mod.NativeDisplayWidth, Mod.NativeDisplayHeight);
        }


        if (!path.Contains(UITitle)) return;

        var x = Mod.NativeDisplayWidth - Mod.BlackBarSize;
        __instance.transform.position = __instance.transform.position with { x = x };
        var scale = __instance.transform.localScale.x * Mod.PositiveScaleFactor;
        __instance.transform.localScale = __instance.transform.localScale with { x = scale };
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        __instance.aspectRatio = Mod.MainAspect;
    }

    private static void DeactivateGameObject(string path)
    {
        var obj = GameObject.Find(path);
        if (obj)
        {
            obj.SetActive(false);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TitleScene), nameof(TitleScene.SetTitleImage))]
    public static void TitleScene_SetTitleImage(ref TitleScene __instance)
    {
        RunFixes();
    }

    private static void RunFixes()
    {
        DeactivateGameObject(LetterboxRightPath);
        DeactivateGameObject(LetterboxLeftPath);
        DeactivateGameObject(VersionPath);

        AdjustBlackImages();
    }

    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Mod.MainAspect > Mod.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        ProcessScaler(__instance);
        RunFixes();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_Field), nameof(UI_Field.Start))]
    public static void UI_Field_Start(ref UI_Field __instance)
    {
        // Clean up existing HUD objects if they exist to prevent duplicates on scene reload
        if (LeftHud)
        {
            UnityEngine.Object.Destroy(LeftHud);
            LeftHud = null;
        }

        if (RightHud)
        {
            UnityEngine.Object.Destroy(RightHud);
            RightHud = null;
        }

        LeftHud = new GameObject(LeftHudName);
        LeftHud.transform.SetParent(__instance.transform);
        foreach (var item in LeftItems)
        {
            var obj = __instance.transform.FindChild(item);
            if (obj)
            {
                obj.SetParent(LeftHud.transform);
            }
        }

        RightHud = new GameObject(RightHudName);
        RightHud.transform.SetParent(__instance.transform);
        foreach (var item in RightItems)
        {
            var obj = __instance.transform.FindChild(item);
            if (obj)
            {
                obj.SetParent(RightHud.transform);
            }
        }

        LeftHud.TryAddComponent<LeftHudMover>();
        LeftHud.TryAddComponent<FieldMenuToggler>();
        RightHud.TryAddComponent<RightHudMover>();

        var mapPanel = __instance.transform.FindChild(RightHudMiniMapPanel);
        if (mapPanel)
        {
            mapPanel.localScale = Vector3.one;
        }

        var miniMap = __instance.transform.FindChild(RightHudMapFrame);
        if (miniMap)
        {
            miniMap.gameObject.TryAddComponent<MiniMapMover>();
        }

        FieldMenu = LeftHud.transform.FindChild(FieldMenuPath);
        if (FieldMenu)
        {
            FieldMenu.gameObject.SetActive(Mod.FieldMenu.Value);
        }
    }

    private static Transform FieldMenu { get; set; }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.Update))]
    public static void Volume_Update(ref Volume __instance)
    {
        // Early exit if no update needed - avoids profile access every frame
        // This guard is important: Volume.Update runs every frame for EVERY Volume in the scene
        if (!VolumeUpdateRequired) return;

        var currentFrame = Time.frameCount;
        var instanceId = __instance.GetInstanceID();

        // If this is a new frame, clear the tracking HashSet
        if (_lastVolumeUpdateFrame != currentFrame)
        {
            UpdatedVolumeIds.Clear();
            _lastVolumeUpdateFrame = currentFrame;
        }

        // Check if this specific volume has already been updated in this frame
        // This handles multiple volumes correctly while avoiding redundant updates per frame
        if (UpdatedVolumeIds.Contains(instanceId)) return;

        UpdateVolumeSettings(__instance);
        UpdatedVolumeIds.Add(instanceId);
    }

    // Extract volume settings update to separate method for clarity and reusability
    private static void UpdateVolumeSettings(Volume volume)
    {
        if (!volume || !volume.profile) return;

        var profile = volume.profile;

        if (profile.TryGet(out SplitToning splitToning))
        {
            splitToning.active = Mod.ToneMapping.Value;
        }

        if (profile.TryGet(out MotionBlur motionBlur))
        {
            motionBlur.active = false;
        }

        if (profile.TryGet(out Bloom bloom))
        {
            bloom.active = Mod.Bloom.Value;
        }

        if (profile.TryGet(out Vignette vignette))
        {
            vignette.active = Mod.Vignette.Value;
        }

        if (profile.TryGet(out DepthOfField dof))
        {
            dof.active = Mod.DepthOfField.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.SetResolution), typeof(string))]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.SetResolution), typeof(ResolutionList))]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.SetScreenMode))]
    public static void OptionManager_SetResolution(ref OptionManager __instance)
    {
        Screen.SetResolution(Mod.NativeDisplayWidth, Mod.NativeDisplayHeight, Mod.FullScreenModeConfig.Value, Mod.MaxRefresh);
    }
}