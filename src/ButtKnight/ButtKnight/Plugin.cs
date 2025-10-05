namespace ButtKnight;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.buttknight.ultrawide";
    internal const string PluginName = "ButtKnight Ultra-Wide";
    private const string PluginVersion = "0.1.0";

    internal static ManualLogSource Log { get; private set; }
    private static ConfigurationManager.ConfigurationManager ConfigurationManager => global::ConfigurationManager.ConfigurationManager.Instance;
    private static bool RequiresUpdate { get; set; }
    internal static PopupManager PopupManagerInstance { get; private set; }

    private void Awake()
    {
        Log = Logger;

        PopupManagerInstance = gameObject.AddComponent<PopupManager>();

        ConfigManager.Initialize(
            Config,
            onDisplayUpdate: () => UpdateAll(true),
            onHUDUpdate: Patches.Patches.UpdateFitters,
            onScanLinesUpdate: UIManager.ToggleScanLineImages,
            onVignetteUpdate: UIManager.ToggleVignetteImages,
            onForestSidesUpdate: UIManager.ToggleForestSides,
            onAlternateMapColorUpdate: UIManager.UpdateWorldMapBackgroundColor);

        SaveManager.RegisterDeleteSaveConfig(Config);

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static void UpdateAll(bool force = false)
    {
        Patches.Patches.UpdateAllCameras();
        UpdateDisplay(force);
    }

    private static void UpdateDisplay(bool force = false)
    {
        QualitySettings.vSyncCount = ConfigManager.GetVSyncCount();
        Application.targetFrameRate = QualitySettings.vSyncCount == 0 ? ConfigManager.TargetFramerate.Value : -1;

        if (force)
        {
            RequiresUpdate = true;
        }

        if (!RequiresUpdate) return;

        Screen.SetResolution(Resolutions.SelectedResolution.width, Resolutions.SelectedResolution.height, ConfigManager.FullScreenModeConfig.Value, Resolutions.MaxRefreshRate);
        Log.LogInfo($"Resolution updated: {Resolutions.SelectedResolution.width}x{Resolutions.SelectedResolution.height}, Full Screen Mode={ConfigManager.FullScreenModeConfig.Value}, Refresh Rate={Resolutions.RefreshRate}Hz");

        // Re-apply all scales for new aspect ratio
        Patches.Patches.UpdateAllTransformScales();

        if (ConfigurationManager && ConfigurationManager.DisplayingWindow)
        {
            ConfigurationManager.CloseWindow();
            ConfigurationManager.OpenWindow();
        }

        PopupManagerInstance.ShowPopupDlg(
            $"The display settings have been updated to {Resolutions.SelectedResolution.width}x{Resolutions.SelectedResolution.height} at {Resolutions.RefreshRate}Hz in {ConfigManager.FullScreenModeConfig.Value} mode. It is recommended to restart the game for the best experience.",
            "display_settings_updated",
            true);

        RequiresUpdate = false;
    }

    private static void SceneManagerOnSceneLoaded(Scene scene, LoadSceneMode arg1)
    {
        if (scene.name == "Logo")
        {
            SceneManager.LoadScene("Intro");
        }

        UIManager.CacheSceneImages();
        UIManager.UpdateAllImagesScale();
        UIManager.ToggleScanLineImages();
        UIManager.ToggleVignetteImages();
        UIManager.ToggleForestSides();
        UIManager.HandleSceneSpecificUI(scene);
    }

    internal enum SkipChoice
    {
        SkipAll,
        SkipNone,
        SkipInsertAnyCoinOnly
    }
}