namespace Constance;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.constance.ultrawide";
    private const string PluginName = "Constance Ultra-Wide";
    private const string PluginVersion = "0.1.1";

    internal static ManualLogSource Log { get; private set; }

    internal static int CurrentWidth => Screen.currentResolution.width; //3440
    internal static int CurrentHeight => Screen.currentResolution.height; //1440
    internal static float CurrentAspect => (float)CurrentWidth / CurrentHeight; //2.3888889
    internal const float NativeAspect = 16f / 9f; //1.777778
    private const float ReferenceHeight = 2160f; // 4K reference resolution height
    private static ConfigEntry<string> HUDAspect { get; set; }


    private static float GetCanvasOffset(float targetAspect)
    {
        // Return 0 if target aspect is wider than or equal to current screen
        if (targetAspect >= CurrentAspect) return 0f;

        // Calculate canvas scale factor based on reference resolution
        var scaleFactor = CurrentHeight / ReferenceHeight; // 1440 / 2160 = 0.6667

        // Calculate canvas width in canvas coordinate space
        var canvasWidth = CurrentWidth / scaleFactor; // 3440 / 0.6667 = 5160

        // Calculate target width in screen pixels
        var targetWidthPixels = CurrentHeight * targetAspect; // 1440 * 1.777778 = 2560

        // Convert target width to canvas coordinates
        var targetWidthCanvas = targetWidthPixels / scaleFactor; // 2560 / 0.6667 = 3840

        // Return half the difference (offset from center for positioning)
        return (canvasWidth - targetWidthCanvas) / 2f; // (5160 - 3840) / 2 = 660
    }

    // Dictionary stores aspect ratio values. GetCanvasOffset() is called at runtime with these values.
    // Example: At 3440x1440 with 16:9 HUD -> GetCanvasOffset(16/9) = 660 in canvas coordinates
    private static readonly Dictionary<string, float> HUDAspectValues = new()
    {
        { "4:3", 4f / 3f }, // 1.333333
        { "16:10", 16f / 10f }, // 1.6
        { "16:9", 16f / 9f }, // 1.777778
        { "21:9", 21f / 9f }, // 2.333333
        { "21.5:9", 21.5f / 9f }, // 2.388889
        { "24:10", 24f / 10f }, // 2.4
        { "27:9", 27f / 9f }, // 3.0
        { "32:10", 32f / 10f }, // 3.2
        { "32:9", 32f / 9f }, // 3.555556
        { "48:9", 48f / 9f } // 5.333333
    };

    internal static float GetHudValue()
    {
        var selectedAspect = HUDAspect.Value;

        // If Auto, return 0 (no offset, use native aspect)
        if (selectedAspect == "Auto")
        {
            return 0f;
        }

        // Look up the aspect ratio and calculate canvas coordinate offset
        if (HUDAspectValues.TryGetValue(selectedAspect, out var aspectRatio))
        {
            return GetCanvasOffset(aspectRatio);
        }

        // Fallback to 0 if not found
        Log.LogWarning($"HUD aspect '{selectedAspect}' not found in dictionary!");
        return 0f;
    }

    private static string[] GetAvailableHUDAspects()
    {
        var currentAspect = CurrentAspect;
        var availableAspects = HUDAspectValues
            .Where(kvp => kvp.Value <= currentAspect + 0.01f) // Small tolerance for floating point comparison
            .OrderBy(kvp => kvp.Value)
            .Select(kvp => kvp.Key)
            .ToList();

        availableAspects.Add("Auto");
        return availableAspects.ToArray();
    }


    public static ConfigEntry<bool> Notifications { get; private set; }

    public static ConfigEntry<bool> UnlimitedPolaroids { get; private set; }
    internal static ConfigFile ConfigFile { get; private set; }
   
    private void Awake()
    {
        ConfigFile = Config;
        Log = Logger;

        HUDAspect = Config.Bind("01. UI", "UI Aspect", "Auto",
            new ConfigDescription(
                "Choose the aspect ratio for the game's user interface (UI). 'Auto' attempts to match your display's ratio. Can use +/- keys to cycle through options.",
                new AcceptableValueList<string>(GetAvailableHUDAspects()),
                new ConfigurationManagerAttributes { Order = 100 }));
        HUDAspect.SettingChanged += (_, _) =>
        {
            Log.LogInfo($"HUD Aspect changed to: {HUDAspect.Value}");
        };
        
        UnlimitedPolaroids = Config.Bind("02. Gameplay", "Unlimited Polaroids", false,
            new ConfigDescription(
                "Enable or disable unlimited polaroids for taking snapshots. When enabled, you can take as many snapshots as you want. Counters in-game will be updated to show how many you have taken.",
                null,
                new ConfigurationManagerAttributes { Order = 98 }));
        
        Notifications = Config.Bind("03. Post-Processing", "Post-Process Registration Notifications", true,
            new ConfigDescription(
                "Enable or disable notifications for post-processing effects being registered for configuration.",
                null,
                new ConfigurationManagerAttributes { Order = 99 }));
        
        
        SceneManager.sceneLoaded += OnSceneLoaded;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }

    private void Update()
    {
        // Cycle through HUD aspect ratios with +/- keys (using new Input System)
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        if (keyboard.equalsKey.wasPressedThisFrame || keyboard.numpadPlusKey.wasPressedThisFrame) // + key
        {
            CycleHudAspect(1);
        }
        else if (keyboard.minusKey.wasPressedThisFrame || keyboard.numpadMinusKey.wasPressedThisFrame) // - key
        {
            CycleHudAspect(-1);
        }
    }

    private static void CycleHudAspect(int direction)
    {
        var availableAspects = GetAvailableHUDAspects();
        var currentIndex = Array.IndexOf(availableAspects, HUDAspect.Value);

        if (currentIndex == -1) currentIndex = availableAspects.Length - 1; // Default to "Auto" if not found

        // Cycle to next/previous aspect
        var newIndex = (currentIndex + direction + availableAspects.Length) % availableAspects.Length;
        HUDAspect.Value = availableAspects[newIndex];
    }


    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Diagnostic logging for camera and aspect ratio
        Log.LogInfo($"Scene loaded: {scene.name}");
        Log.LogInfo($"Screen resolution: {CurrentWidth}x{CurrentHeight} (Aspect: {CurrentAspect:F4})");

        var mainCam = Camera.main;
        if (mainCam)
        {
            Log.LogInfo($"Camera.main aspect: {mainCam.aspect:F4}");
            Log.LogInfo($"Camera.main viewport: {mainCam.rect}");
            Log.LogInfo($"Camera.main pixelRect: {mainCam.pixelRect}");
        }
        else
        {
            Log.LogWarning("Camera.main is null!");
        }

        // Scale black overlay blockers for ultrawide
        var blockers = Resources.FindObjectsOfTypeAll<CConSelectionLayer_Blocker>();
        foreach (var blocker in blockers)
        {
            var image = blocker.GetComponent<Image>();
            if (image && image.name == "Overlay Black")
            {
                var arf = image.gameObject.GetComponent<AspectRatioFitter>();
                if (arf)
                {
                    arf.aspectRatio = CurrentAspect;
                    arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
                    Log.LogInfo($"Updated AspectRatioFitter on overlay blocker '{image.name}' to current aspect {CurrentAspect:F4}");
                }
            }
        }
    }
}