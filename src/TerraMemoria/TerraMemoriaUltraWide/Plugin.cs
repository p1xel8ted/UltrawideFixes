namespace TerraMemoriaUltraWide;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.terramemoria.ultrawide";
    private const string PluginName = "Terra Memoria Ultra-Wide";
    private const string PluginVersion = "0.1.2";
    private const string SplashScreen = "LaMoutardeSplashScreenScene";
    private const string MainMenu = "StartScreenScene";

    private static NotificationCenterUIManager Notifications => NotificationCenterUIManager.Instance;

    internal readonly static Dictionary<CanvasScaler, CanvasScaler.ScreenMatchMode> OriginalScreenMatchModes = new();
    internal static float MainAspectRatio => MainWidth / (float) MainHeight;
    internal static float AspectDifference => (MainWidth - NormalWidth) / 2f;
    private static float BaseAspect => 16f / 9f;
    private static float NormalWidth => MainHeight * BaseAspect;
    private static ConfigEntry<int> DisplayToUse { get; set; }
    internal static ConfigEntry<bool> UltraWideFixes { get; set; }
    private static ConfigFile ConfigInstance { get; set; }
    private static ManualLogSource Logger { get; set; }
    internal static int MainWidth => Display.displays[DisplayToUse.Value].systemWidth;
    private static int MainHeight => Display.displays[DisplayToUse.Value].systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<KeyCode> ConfigReloadKeybind { get; set; }
    private static ConfigEntry<bool> SkipSplashScreens { get; set; }
    internal static ConfigEntry<bool> AdjustUIScalingBehaviour { get; private set; }
    private static ConfigEntry<bool> Vignette { get; set; }
    internal static ConfigEntry<bool> DepthOfField { get; private set; }
    private static ConfigEntry<bool> ChromaticAberration { get; set; }

    private static ConfigEntry<KeyCode> VignetteKeybind { get; set; }
    private static ConfigEntry<KeyCode> DepthOfFieldKeybind { get; set; }
    private static ConfigEntry<KeyCode> ChromaticAberrationKeybind { get; set; }
    private static ConfigEntry<KeyCode> AdjustUIScalingBehaviourKeybind { get; set; }
    internal static ConfigEntry<bool> ModifyFieldOfView { get; private set; }
    private static ConfigEntry<KeyCode> ModifyFieldOfViewKeybind { get; set; }
    internal static ConfigEntry<int> FieldOfViewValue { get; private set; }
    private static ConfigEntry<KeyCode> FieldOfViewIncreaseKeybind { get; set; }
    private static ConfigEntry<KeyCode> FieldOfViewDecreaseKeybind { get; set; }

    // private class MonoBehaviours : MonoBehaviour
    // {
    //     private void Update()
    //     {
    //         if (Input.GetKeyDown(ConfigReloadKeybind.Value))
    //         {
    //             RefreshVolumeProfiles();
    //             ConfigInstance.Reload();
    //             Logger.LogInfo("Config reloaded!");
    //             ShowMessage("Config reloaded!");
    //             return;
    //         }
    //
    //         if (Input.GetKeyDown(VignetteKeybind.Value))
    //         {
    //             RefreshVolumeProfiles();
    //             Vignette.Value = !Vignette.Value;
    //             UpdateVolumeProfiles();
    //             ShowMessage(Vignette.Value ? $"Vignette ON!" : $"Vignette OFF!");
    //             return;
    //         }
    //
    //         if (Input.GetKeyDown(DepthOfFieldKeybind.Value))
    //         {
    //             RefreshVolumeProfiles();
    //             DepthOfField.Value = !DepthOfField.Value;
    //             UpdateVolumeProfiles();
    //             ShowMessage(DepthOfField.Value ? $"Depth of Field ON!" : $"Depth of Field OFF!");
    //             return;
    //         }
    //
    //         if (Input.GetKeyDown(ChromaticAberrationKeybind.Value))
    //         {
    //             RefreshVolumeProfiles();
    //             ChromaticAberration.Value = !ChromaticAberration.Value;
    //             UpdateVolumeProfiles();
    //             ShowMessage(ChromaticAberration.Value ? $"Chromatic Aberration ON!" : $"Chromatic Aberration OFF!");
    //             return;
    //         }
    //
    //         if (Input.GetKeyDown(AdjustUIScalingBehaviourKeybind.Value))
    //         {
    //             if (!UltraWideFixes.Value) return;
    //             AdjustUIScalingBehaviour.Value = !AdjustUIScalingBehaviour.Value;
    //             ShowMessage(AdjustUIScalingBehaviour.Value ? "UI Scaling: Modified" : "UI Scaling: Default");
    //             return;
    //         }
    //
    //         if (Input.GetKeyDown(FieldOfViewIncreaseKeybind.Value))
    //         {
    //             if (!ModifyFieldOfView.Value)
    //             {
    //                 ShowMessage($"Press {ModifyFieldOfViewKeybind.Value.ToString()} to enable Field of View modification first!");
    //                 return;
    //             }
    //             FieldOfViewValue.Value += 1;
    //             UpdateCameraFoV();
    //             ShowMessage(FieldOfViewValue.Value == 0 ? "Default Field of View" : $"Field of View: {FieldOfViewValue.Value}");
    //             return;
    //         }
    //
    //         if (Input.GetKeyDown(FieldOfViewDecreaseKeybind.Value))
    //         {
    //             if (!ModifyFieldOfView.Value)
    //             {
    //                 ShowMessage($"Press {ModifyFieldOfViewKeybind.Value.ToString()} to enable Field of View modification first!");
    //                 return;
    //             }
    //             FieldOfViewValue.Value -= 1;
    //             UpdateCameraFoV();
    //             ShowMessage(FieldOfViewValue.Value == 0 ? "Default Field of View" : $"Field of View: {FieldOfViewValue.Value}");
    //         }
    //
    //         if (Input.GetKeyDown(ModifyFieldOfViewKeybind.Value))
    //         {
    //             ModifyFieldOfView.Value = !ModifyFieldOfView.Value;
    //             UpdateCameraFoV();
    //             ShowMessage(ModifyFieldOfView.Value ? "Field of View: Modified" : "Field of View: Default");
    //         }
    //     }
    // }

    private static void ShowMessage(string message)
    {
        if (Notifications is not null)
        {
            Notifications._pendingNotifications?.Clear();
            var notifications = Notifications.GetNewNotificationBox();
            notifications._textContent.text = message;
            Object.Destroy(notifications._iconContainer.gameObject);
            Notifications.AddNotificationToPending(notifications);
        }
    }

    public override void Load()
    {
        Logger = Log;
        ConfigInstance = Config;


        DisplayToUse = Config.Bind("01. Display", "Display To Use", 0, new ConfigDescription("Display to use", new AcceptableValueList<int>(Display.displays.Select((_, i) => i).ToArray())));
        UltraWideFixes = Config.Bind("01. Display", "Ultra-Wide Fixes", true, new ConfigDescription("Enable Ultra-Wide fixes."));
        SkipSplashScreens = Config.Bind("02. General", "Skip Splash Screens", true, new ConfigDescription("Skip splash screens on start up. There is a slight delay in loading the text on the main menu."));
        AdjustUIScalingBehaviour = Config.Bind("05. UI", "Adjust UI Scaling Behaviour", true, new ConfigDescription("Adjust UI scaling behaviour to expand instead of match width/height ratio. Will make everything not so big..."));
        Vignette = Config.Bind("03. Post-Processing", "Vignette", true, new ConfigDescription("Enable Vignette effect on the game screen."));
        DepthOfField = Config.Bind("03. Post-Processing", "Depth Of Field", true, new ConfigDescription("Enable Depth Of Field effect on the game screen."));
        ChromaticAberration = Config.Bind("03. Post-Processing", "Chromatic Aberration", true, new ConfigDescription("Enable Chromatic Aberration effect on the game screen."));
        //ConfigReloadKeybind = Config.Bind("04. Keybinds", "Reload Config", KeyCode.F5, new ConfigDescription("Reload the config file."));
        //VignetteKeybind = Config.Bind("04. Keybinds", "Vignette Keybind", KeyCode.F1, new ConfigDescription("Toggle Vignette effect."));
        //DepthOfFieldKeybind = Config.Bind("04. Keybinds", "Depth Of Field Keybind", KeyCode.F2, new ConfigDescription("Toggle Depth Of Field effect."));
       //ChromaticAberrationKeybind = Config.Bind("04. Keybinds", "Chromatic Aberration Keybind", KeyCode.F3, new ConfigDescription("Toggle Chromatic Aberration effect."));
        //AdjustUIScalingBehaviourKeybind = Config.Bind("04. Keybinds", "Adjust UI Scaling Behaviour Keybind", KeyCode.F4, new ConfigDescription("Toggle UI scaling behaviour."));
        ModifyFieldOfView = Config.Bind("06. Field of View", "Modify Field Of View", false, new ConfigDescription("Modify the field of view of the camera."));
        FieldOfViewValue = Config.Bind("06. Field of View", "Field Of View Value", 0, new ConfigDescription("Field of view value. This figure will get added to the original field of view value.", new AcceptableValueRange<int>(0,50)));
        //FieldOfViewIncreaseKeybind = Config.Bind("06. Field of View", "Field Of View Increase Keybind", KeyCode.F7, new ConfigDescription("Increase field of view value."));
        //FieldOfViewDecreaseKeybind = Config.Bind("06. Field of View", "Field Of View Decrease Keybind", KeyCode.F6, new ConfigDescription("Decrease field of view value."));
        //ModifyFieldOfViewKeybind = Config.Bind("06. Field of View", "Modify Field Of View Keybind", KeyCode.F8, new ConfigDescription("Toggle field of view modification."));

        Display.displays[DisplayToUse.Value].Activate(MainWidth, MainHeight, MaxRefresh);

        // AddComponent<MonoBehaviours>();
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>) OnSceneLoaded;

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1 / (float) MaxRefresh;

        if (SkipSplashScreens.Value && scene.name.Equals(SplashScreen))
        {
            SceneManager.LoadScene(MainMenu);
        }
        
        UpdateGraphicsQualitySettings();
        RefreshVolumeProfiles();
        // UpdateCameraFoV();
    }
    internal static List<VolumeProfile> VolumeProfiles { get; } = [];
    
    internal readonly static Dictionary<CinemachineVirtualCamera, float> VirtualCameras = [];

    internal static void RefreshVolumeProfiles()
    {
        var vp = Resources.FindObjectsOfTypeAll<VolumeProfile>();
        VolumeProfiles.AddRange(vp);
    }

    private static void UpdateCameraFoV()
    {
        // foreach (var cam in VirtualCameras)
        // {
        //     if (ModifyFieldOfView.Value)
        //     {
        //         cam.Key.m_Lens = cam.Key.m_Lens with {FieldOfView = FieldOfViewValue.Value + cam.Value};
        //     }
        //     else
        //     {
        //         cam.Key.m_Lens = cam.Key.m_Lens with {FieldOfView = cam.Value};
        //     }
        // }
    }

    internal static void UpdateVolumeProfiles()
    {
        foreach (var ap in VolumeProfiles)
        {
            ap.TryGet(out Vignette vignette);
            if (vignette is not null)
            {
                vignette.active = Vignette.Value;
            }


            ap.TryGet(out DepthOfField depthOfField);
            if (depthOfField is not null)
            {
                depthOfField.active = DepthOfField.Value;
            }


            ap.TryGet(out ChromaticAberration chromaticAberration);
            if (chromaticAberration is not null)
            {
                chromaticAberration.active = ChromaticAberration.Value;
            }
        }
    }

    private static void UpdateGraphicsQualitySettings()
    {
        QualitySettings.shadowResolution = UnityEngine.ShadowResolution.VeryHigh;
        QualitySettings.antiAliasing = 8;
        QualitySettings.realtimeReflectionProbes = true;
        QualitySettings.softParticles = true;
        QualitySettings.particleRaycastBudget = 4096;
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.ForceEnable;
        QualitySettings.lodBias = 10.0f;
        QualitySettings.maximumLODLevel = 0;
    }

}