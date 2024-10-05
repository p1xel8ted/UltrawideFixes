namespace WitchSpringR.Patches;

[Harmony]
public static class Patches
{
    private const string BlackPanelImage = "blackPanel";
    private const string PaperSideImage = "PaperSide";

    private const string TitleScene = "#Title";
    private const string HomePieberryScene = "#Home_Pieberry";

    private const string LetterboxRightPath = "Canvas/LetterBox_Right";
    private const string LetterboxLeftPath = "Canvas/LetterBox_Left";
    private const string VersionPath = "Canvas/Layer_Mid/UI_Title(Clone)/Under";
    private const string UITitle = "UI_Title";
    private const string RightHudMiniMapPanel = "RightHud/MiniMapPanel";
    private const string RightHudMapFrame = "RightHud/MiniMapPanel/MapFrame";
    private const string RightHudName = "RightHud";
    private const string LeftHudName = "LeftHud";


    private static readonly string[] LeftItems =
    [
        "Body/MainStatus",
        "Body/MiniMapPanel/PuzzleOperating",
        "Body/MiniMapPanel/FieldMenu",
        "Body/Gold"
    ];

    private readonly static string[] RightItems =
    [
        "Body/MapName",
        "Body/Icon_SkipScene",
        "Body/MiniMapPanel",
        "Body/RightUp"
    ];

    private static GameObject LeftHud { get; set; }
    private static GameObject RightHud { get; set; }

    private static void AdjustBlackImages()
    {
        var blackImages = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in blackImages)
        {
            switch (image.name)
            {
                case BlackPanelImage:
                    image.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
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
        var mapDots = __instance.transform.FindChild("RightHud/MapName/MapNameDot");
        mapDots.transform.localPosition = mapDots.transform.localPosition with { y = -40 };
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(UI_Field), nameof(UI_Field.SetMapName))]
    public static void UI_Field_SetMapName(ref UI_Field __instance)
    {
        __instance.cg_mapName = __instance.transform.FindChild("RightHud/MapName").GetComponent<CanvasGroup>();
        __instance.text_mapName = __instance.transform.FindChild("RightHud/MapName/Text").GetComponent<Text>();
        __instance.mapNameRect = __instance.transform.FindChild("RightHud/MapName/MapNameDot").GetComponent<RectTransform>();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Player), nameof(Player.ActivePlayer))]
    public static void Player_ActivePlayer(ref Player __instance)
    {
        __instance.gameObject.TryAddComponent<ClothsToggler>();
    }

    private static MainCamera MainCameraInstance { get; set; }

    internal static void UpdateCamera()
    {
        if (SceneManager.GetActiveScene().name.Equals(TitleScene)) return;
        if (SceneManager.GetActiveScene().name.Equals(HomePieberryScene)) return;
        MainCameraInstance.thisCamera.fieldOfView = 24 + 24 * (Plugin.FieldOfView.Value / 100f);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.Update))]
    public static void MainCamera_Update(ref MainCamera __instance)
    {
        MainCameraInstance = __instance;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.Awake))]
    [HarmonyPatch(typeof(MainCamera), nameof(MainCamera.SetCamera))]
    public static void MainCamera_Awake(ref MainCamera __instance)
    {
        MainCameraInstance = __instance;
        VolumeUpdateRequired = true;
        __instance.thisCamera.aspect = Plugin.MainAspect;
        __instance.thisCamera.pixelRect = Plugin.CameraRect;
        UpdateCamera();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(SubCamera), nameof(SubCamera.Awake))]
    public static void SubCamera_Awake(ref SubCamera __instance)
    {
        __instance.thisCamera.aspect = Plugin.MainAspect;
        __instance.thisCamera.pixelRect = Plugin.CameraRect;
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

            __instance.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        }


        if (!path.Contains(UITitle)) return;

        var x = Plugin.MainWidth - Plugin.BlackBarSize;
        __instance.transform.position = __instance.transform.position with { x = x };
        var scale = __instance.transform.localScale.x * Plugin.PositiveScaleFactor;
        __instance.transform.localScale = __instance.transform.localScale with { x = scale };
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        __instance.aspectRatio = Plugin.MainAspect;
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
    [HarmonyPatch(typeof(TitleScene), nameof(global::TitleScene.SetTitleImage))]
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

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        RunFixes();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UI_Field), nameof(UI_Field.Start))]
    public static void UI_Field_Start(ref UI_Field __instance)
    {
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
    }
    
    internal static bool VolumeUpdateRequired;
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Volume), nameof(Volume.Update))]
    public static void Volume_Update(ref Volume __instance)
    {
        if (!VolumeUpdateRequired) return;
        VolumeUpdateRequired = false;
        
        var ap = __instance.profile;

        ap.TryGet(out SplitToning splitToning);
        if (splitToning)
        {
            splitToning.active = Plugin.ToneMapping.Value;
        }

        ap.TryGet(out MotionBlur motionBlur);
        if (motionBlur)
        {
            motionBlur.active = false;
        }

        ap.TryGet(out Bloom bloom);
        if (bloom)
        {
            bloom.active = Plugin.Bloom.Value;
        }

        ap.TryGet(out Vignette vignette);
        if (vignette)
        {
            vignette.active = Plugin.Vignette.Value;
        }

        ap.TryGet(out DepthOfField dof);
        if (dof)
        {
            dof.active = Plugin.DepthOfField.Value;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.SetResolution), typeof(string))]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.SetResolution), typeof(ResolutionList))]
    [HarmonyPatch(typeof(OptionManager), nameof(OptionManager.SetScreenMode))]
    public static void OptionManager_SetResolution(ref OptionManager __instance)
    {
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, FullScreenMode.FullScreenWindow, Plugin.MaxRefresh);
    }
}