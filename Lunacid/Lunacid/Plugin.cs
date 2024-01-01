namespace Lunacid;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.lunacid.tweaks";
    private const string PluginName = "Lunacid Tweaks";
    private const string PluginVersion = "0.1.0";
    private const int UiReferenceResolutionHeight = 720;

    private readonly static string[] ObjectsToScale = ["mask", "overlay", "border", "mask1", "mask2", "border_3d", "overlay_new", "level_load", "level_load_alt"];
    private static float BaseAspect => 16f / 9f;
    private static float CurrentAspect => (float) Display.main.systemWidth / Display.main.systemHeight;
    private static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> ExpandHudConfig { get; set; }
    private static ConfigEntry<bool> IncreaseUpdateRate { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForUpdateRate { get; set; }
    private static ConfigEntry<bool> LoadSavePurpleEffect { get; set; }
    private static ManualLogSource LOG { get; set; }
    private static ConfigEntry<int> LeftSideAdjustment { get; set; }
    private static ConfigEntry<int> RightSideAdjustment { get; set; }
    private static ConfigEntry<bool> ConfigScaleConfig { get; set; }
    private static ConfigEntry<float> ConfigScale { get; set; }
    private static List<CanvasScaler> UiCanvasScalers { get; } = [];
    private static Dictionary<Transform, WriteOnce<float>> OriginalTransformPositions { get; set; } = [];

    private void Awake()
    {
        LOG = new ManualLogSource(PluginName);
        BepInEx.Logging.Logger.Sources.Add(LOG);

        ConfigScaleConfig = Config.Bind("01. Scale", "Enable Scale Adjustments", false, new ConfigDescription("Enable scale adjustments. This will override the default UI scaling.", null, new ConfigurationManagerAttributes {Order = 100}));
        ConfigScaleConfig.SettingChanged += (_, _) =>
        {
            ChangeScale();
        };
        ConfigScale = Config.Bind("01. Scale", "Overall Scale", GetNewScale(UiReferenceResolutionHeight),
            new ConfigDescription("Scale of the UI. Adjust as necessary to fit. The default value should OK.",
                new AcceptableValueRange<float>(0.1f, 5f), new ConfigurationManagerAttributes {Order = 99}));
        ConfigScale.SettingChanged += (_, _) =>
        {
            ChangeScale();
        };

        ExpandHudConfig = Config.Bind("03. HUD", "Expand Hud", true, new ConfigDescription("Expand the hud elements to the left and right of the screen.", null, new ConfigurationManagerAttributes {Order = 94}));
        ExpandHudConfig.SettingChanged += (_, _) =>
        {
            if (ExpandHudConfig.Value)
            {
                ExpandHud();
            }
            else
            {
                RestoreHud();
            }
        };
        LeftSideAdjustment = Config.Bind("03. HUD", "Left Side Adjustment", 210, new ConfigDescription("Adjust the hud elements on the left side of the screen", new AcceptableValueRange<int>(-500, 500), new ConfigurationManagerAttributes {Order = 93}));
        LeftSideAdjustment.SettingChanged += (_, _) =>
        {
            if (!ExpandHudConfig.Value) return;
            RestoreHud();
            ExpandHud();
        };
        RightSideAdjustment = Config.Bind("03. HUD", "Right Side Adjustment", 210, new ConfigDescription("Adjust the hud elements on the right side of the screen", new AcceptableValueRange<int>(-500, 500), new ConfigurationManagerAttributes {Order = 92}));
        RightSideAdjustment.SettingChanged += (_, _) =>
        {
            if (!ExpandHudConfig.Value) return;
            RestoreHud();
            ExpandHud();
        };
        LoadSavePurpleEffect = Config.Bind("04. UI Effects", "Purple Wave Effect", false, new ConfigDescription("Enable the purple wave effect on load and save screens.", null, new ConfigurationManagerAttributes {Order = 91}));
        LoadSavePurpleEffect.SettingChanged += (_, _) =>
        {
            TogglePurpleWave();
        };
        IncreaseUpdateRate = Config.Bind("05. Performance", "Increase Update Rate", false, new ConfigDescription("Increases the update rate of physics to the lowest multiple of your refresh rate that is above 50Hz (the default). So at 120Hz, the update rate will be 60fps. This will increase the CPU usage.", null, new ConfigurationManagerAttributes {Order = 90}));
        IncreaseUpdateRate.SettingChanged += (_, _) =>
        {
            FixUpdateRate();
        };
        UseRefreshRateForUpdateRate = Config.Bind("05. Performance", "Use Refresh Rate For Update Rate", false, new ConfigDescription("Use the refresh rate of the monitor for the update rate. This will increase the CPU usage.", null, new ConfigurationManagerAttributes {Order = 89}));
        UseRefreshRateForUpdateRate.SettingChanged += (_, _) =>
        {
            if (UseRefreshRateForUpdateRate.Value)
            {
                IncreaseUpdateRate.Value = true; 
            }
            FixUpdateRate();
        };
        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private static int FindLowestFrameRateMultipleAboveFifty(int originalRate)
    {
        for (var rate = originalRate / 2; rate > 50; rate--)
        {
            if (originalRate % rate == 0)
            {
                return rate;
            }
        }

        return originalRate;
    }
    private static void FixUpdateRate()
    {
        var newRate = FindLowestFrameRateMultipleAboveFifty(MaxRefresh);
        if (IncreaseUpdateRate.Value)
        {
            if (UseRefreshRateForUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / MaxRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / newRate;
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / 50f; //engine default
        }
    }
    private static void TogglePurpleWave()
    {
        var waveOne = GameObject.Find("PLAYER/Canvas/HUD/QUERY/waves");
        var waveTwo = GameObject.Find("PLAYER/Canvas/HUD/ROOT/FILE/waves");
        var waves = new[] {waveOne, waveTwo};
        foreach (var wave in waves.Where(a => a != null))
        {
            wave.SetActive(LoadSavePurpleEffect.Value);
        }
    }

    private static float GetNewScale(float reference)
    {
        var displayHeight = Display.main.systemHeight;
        var scale = 1f / (reference / displayHeight);
        return scale;
    }


    private static void ChangeScale()
    {
        if (ConfigScaleConfig.Value)
        {
            foreach (var scaler in UiCanvasScalers)
            {
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
                scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                scaler.scaleFactor = ConfigScale.Value;
            }
        }
        else
        {
            foreach (var scaler in UiCanvasScalers)
            {
                scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                scaler.scaleFactor = ConfigScale.Value;
            }
        }
    }

    private static void UpdateCanvasScaler(CanvasScaler scaler, float referenceResolutionHeight)
    {
        if (!ConfigScaleConfig.Value) return;
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Shrink;
        scaler.scaleFactor = GetNewScale(referenceResolutionHeight);
    }

    private static void RestoreHud()
    {
        OriginalTransformPositions = OriginalTransformPositions.Where(a => a.Key != null).ToDictionary(a => a.Key, a => a.Value);
        foreach (var entry in OriginalTransformPositions)
        {
            var localPosition = entry.Key.localPosition;
            var newX = entry.Value.Value;
            localPosition = new Vector3(newX, localPosition.y, localPosition.z);
            entry.Key.localPosition = localPosition;
        }
    }
    private static void ExpandHud()
    {
        OriginalTransformPositions = OriginalTransformPositions.Where(a => a.Key != null).ToDictionary(a => a.Key, a => a.Value);

        foreach (var entry in OriginalTransformPositions)
        {
            float newX = 0;
            var localPosition = entry.Key.localPosition;
            newX = localPosition.x switch
            {
                < 0 => localPosition.x - LeftSideAdjustment.Value,
                > 0 => localPosition.x + RightSideAdjustment.Value,
                _ => newX
            };
            localPosition = new Vector3(newX, localPosition.y, localPosition.z);
            entry.Key.localPosition = localPosition;
        }
    }

    private static void SceneManagerOnSceneLoaded(Scene __arg0, LoadSceneMode __arg1)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;

        FixUpdateRate();

        UpdateCanvasScalers();

        UpdateMasksAndOverlays();

        TogglePurpleWave();

        ScaleBlackReadThis();

        UpdateFlashes();

        BackupHudPositions();

        if (ExpandHudConfig.Value)
        {
            ExpandHud();
        }
        else
        {
            RestoreHud();
        }
    }

    private static void UpdateMasksAndOverlays()
    {
        var allObjects = Resources.FindObjectsOfTypeAll<GameObject>();

        foreach (var obj in allObjects.Where(a => a != null))
        {
            if (Array.IndexOf(ObjectsToScale, obj.name.ToLowerInvariant()) == -1) continue;
            SetScale(obj, PositiveScaleFactor, PositiveScaleFactor, 1f);
        }
    }

    private static void UpdateFlashes()
    {
        var states = GameObject.Find("PLAYER/Canvas/HUD/GAME/STATES");

        for (var i = 0; i < states.transform.childCount; i++)
        {
            var child = states.transform.GetChild(i);
            SetScale(child.gameObject, PositiveScaleFactor, PositiveScaleFactor, 1f);
        }
    }
    private static void UpdateCanvasScalers()
    {
        var canvasScalers = Resources.FindObjectsOfTypeAll<CanvasScaler>();
        foreach (var scaler in canvasScalers)
        {
            var refHeight = scaler.referenceResolution.y;
            UpdateCanvasScaler(scaler, refHeight);
            UiCanvasScalers.Add(scaler);
        }
    }
    private static void BackupHudPositions()
    {
        var gameHud = GameObject.Find("PLAYER/Canvas/HUD/GAME");
        for (var i = 0; i < gameHud.transform.childCount; i++)
        {
            var child = gameHud.transform.GetChild(i);
            if (!OriginalTransformPositions.ContainsKey(child))
            {
                OriginalTransformPositions.Add(child, new WriteOnce<float>(child.localPosition.x));
            }
        }
    }
    private static void ScaleBlackReadThis()
    {
        var black = GameObject.Find("PLAYER/Canvas/HUD/POP_TEXT/Extra_Effects/OVERLAY");
        if (black != null)
        {
            black.transform.localScale = new Vector3(50f, 50f, 1f);
        }
    }


    private static void SetScale(GameObject gameObject, float x, float y, float z)
    {
        gameObject.transform.localScale = new Vector3(x, y, z);
    }
}