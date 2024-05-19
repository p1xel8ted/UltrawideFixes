namespace Lunacid;

[Harmony]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.lunacid.tweaks";
    private const string PluginName = "Lunacid Tweaks";
    private const string PluginVersion = "0.1.1";

    private readonly static string[] ObjectsToScale = ["mask", "overlay", "border", "mask1", "mask2", "border_3d", "overlay_new", "level_load", "level_load_alt"];
    private static float BaseAspect => 16f / 9f;
    private static float CurrentAspect => (float) Display.main.systemWidth / Display.main.systemHeight;
    private static float PositiveScaleFactor => CurrentAspect / BaseAspect;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);
    private static ConfigEntry<bool> ExpandHudConfig { get; set; }
    private static ConfigEntry<bool> LoadSavePurpleEffect { get; set; }
    private static ManualLogSource LOG { get; set; }
    private static ConfigEntry<int> LeftSideAdjustment { get; set; }
    private static ConfigEntry<int> RightSideAdjustment { get; set; }
    internal static ConfigEntry<PostProcessLayer.Antialiasing> AntiAliasing { get; private set; }
    private static ConfigEntry<bool> AnisotropicFiltering { get; set; }
    private static ConfigEntry<bool> ModifyReticleTransparency { get; set; }
    private static ConfigEntry<float> ReticleTransparency { get; set; }
    private static Dictionary<Transform, WriteOnce<float>> OriginalTransformPositions { get; set; } = [];

    private void Awake()
    {
        LOG = Logger;

        ExpandHudConfig = Config.Bind("01. HUD", "Expand Hud", true, new ConfigDescription("Expand the hud elements to the left and right of the screen.", null, new ConfigurationManagerAttributes {Order = 94}));
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
        LeftSideAdjustment = Config.Bind("01. HUD", "Left Side Adjustment", 210, new ConfigDescription("Adjust the hud elements on the left side of the screen", new AcceptableValueRange<int>(-500, 500), new ConfigurationManagerAttributes {Order = 93}));
        LeftSideAdjustment.SettingChanged += (_, _) =>
        {
            if (!ExpandHudConfig.Value) return;
            RestoreHud();
            ExpandHud();
        };
        RightSideAdjustment = Config.Bind("01. HUD", "Right Side Adjustment", 210, new ConfigDescription("Adjust the hud elements on the right side of the screen", new AcceptableValueRange<int>(-500, 500), new ConfigurationManagerAttributes {Order = 92}));
        RightSideAdjustment.SettingChanged += (_, _) =>
        {
            if (!ExpandHudConfig.Value) return;
            RestoreHud();
            ExpandHud();
        };
        ModifyReticleTransparency = Config.Bind("02. Reticle", "Modify Reticle Transparency", false, new ConfigDescription("Modify the transparency of the reticle.", null, new ConfigurationManagerAttributes {Order = 91}));
        ModifyReticleTransparency.SettingChanged += (_, _) =>
        {
            UpdateReticle();
        };
        ReticleTransparency = Config.Bind("02. Reticle", "Reticle Transparency", 0.25f, new ConfigDescription("Transparency of the reticle.", new AcceptableValueRange<float>(0.10f, 1f), new ConfigurationManagerAttributes {Order = 90}));
        ReticleTransparency.SettingChanged += (_, _) =>
        {
            UpdateReticle();
        };
        LoadSavePurpleEffect = Config.Bind("03. UI Effects", "Purple Wave Effect", false, new ConfigDescription("Enable the purple wave effect on load and save screens.", null, new ConfigurationManagerAttributes {Order = 89}));
        LoadSavePurpleEffect.SettingChanged += (_, _) =>
        {
            TogglePurpleWave();
        };

        AnisotropicFiltering = Config.Bind("05. Quality", "Anisotropic Filtering", true, new ConfigDescription("Enable Anisotropic Filtering.", null,new ConfigurationManagerAttributes {Order = 88}));
        AnisotropicFiltering.SettingChanged += (_, _) =>
        {
            QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;
        };


        AntiAliasing = Config.Bind("06. Post-Processing", "Anti-Aliasing", PostProcessLayer.Antialiasing.TemporalAntialiasing, new ConfigDescription("Enable Anti-Aliasing effect on the game screen.",null,new ConfigurationManagerAttributes {Order = 87}));

        SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
        LOG.LogInfo($"Plugin {PluginName} is loaded!");
    }


    private static void UpdateReticle()
    {
        var always = GameObject.Find("PLAYER/Canvas/HUD/GAME/REDICLE/always");
        var magic = GameObject.Find("PLAYER/Canvas/HUD/GAME/REDICLE/magic");
        var bow = GameObject.Find("PLAYER/Canvas/HUD/GAME/REDICLE/bow");
        var reticles = new[] {always, magic, bow};
        foreach (var ret in reticles.Where(a => a))
        {
            var image = ret.GetComponent<Image>();
            if (!image) continue;
            var color = image.color;
            if (color.a <= 0) return;
            if (ModifyReticleTransparency.Value)
            {
                var newColor = new Color(color.r, color.g, color.b, ReticleTransparency.Value);
                image.color = newColor;
            }
            else
            {
                var newColor = new Color(color.r, color.g, color.b, 0.0314f); //games default value as of 1/1/2024
                image.color = newColor;
            }
        }
    }


    private static void TogglePurpleWave()
    {
        var waveOne = GameObject.Find("PLAYER/Canvas/HUD/QUERY/waves");
        var waveTwo = GameObject.Find("PLAYER/Canvas/HUD/ROOT/FILE/waves");
        var waves = new[] {waveOne, waveTwo};
        foreach (var wave in waves.Where(a => a))
        {
            wave.SetActive(LoadSavePurpleEffect.Value);
        }
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
        QualitySettings.anisotropicFiltering = AnisotropicFiltering.Value ? UnityEngine.AnisotropicFiltering.ForceEnable : UnityEngine.AnisotropicFiltering.Disable;
        
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

        UpdateReticle();
    }

    private static void UpdateMasksAndOverlays()
    {
        var allObjects = Resources.FindObjectsOfTypeAll<GameObject>();

        foreach (var obj in allObjects.Where(a => a))
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

    private static void BackupHudPositions()
    {
        var gameHud = GameObject.Find("PLAYER/Canvas/HUD/GAME");
        for (var i = 0; i < gameHud.transform.childCount; i++)
        {
            var child = gameHud.transform.GetChild(i);
            if (!OriginalTransformPositions.ContainsKey(child))
            {
                var original = new WriteOnce<float>
                {
                    Value = child.localPosition.x
                };
                OriginalTransformPositions.Add(child, original);
            }
        }
    }
    private static void ScaleBlackReadThis()
    {
        var black = GameObject.Find("PLAYER/Canvas/HUD/POP_TEXT/Extra_Effects/OVERLAY");
        if (black)
        {
            black.transform.localScale = new Vector3(50f, 50f, 1f);
        }
    }


    private static void SetScale(GameObject gameObject, float x, float y, float z)
    {
        gameObject.transform.localScale = new Vector3(x, y, z);
    }
}