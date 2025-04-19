

using System.Reflection;
#if BEPINEX
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Drova;
using Drova.GUI;
using Drova.Vfx;
#endif
using DrovaForsakenKin.Misc;
using DrovaForsakenKin.MonoBehaviours;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;
#if MELONLOADER
using DrovaForsakenKin;
using Il2Cpp;
using Il2CppDrova;
using Il2CppDrova.GUI;
using Il2CppDrova.Vfx;

using MelonLoader;


[assembly: MelonInfo(typeof(DrovaMelon), "Drova Forsaken Kin Ultra-Wide (MelonLoader)", "0.1.2", "p1xel8ted")]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
namespace DrovaForsakenKin;

public class DrovaMelon : MelonMod
{
#endif

#if BEPINEX
namespace DrovaForsakenKin;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class BepInExPlugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.drovaforsakenkin.ultrawide";
    private const string PluginName = "Drova Forsaken Kin Ultra-Wide";
    private const string PluginVersion = "0.1.2";

#endif

    internal static int MainWidth => Display.main.systemWidth; //3440
    internal static int MainHeight => Display.main.systemHeight; //1440
    private static ActivateByPlatform Sp { get; set; }
    internal static float MainAspect => MainWidth / (float)MainHeight; //2.388888888888889
    private static WriteOnceFloat OriginalFixedDeltaTime { get; } = new();
    private static float NativeAspectRatio => 16f / 9f; //1.777777777777778
    public static float NegativeScaleFactor => NativeAspectRatio / MainAspect; //0.7454545454545455
    public static float PositiveScaleFactor => MainAspect / NativeAspectRatio; //1.338888888888889

#if BEPINEX
    private static ManualLogSource Logger { get; set; }
    private static ConfigEntry<bool> RunInBackground { get; set; }
    private static ConfigEntry<bool> MuteInBackground { get; set; }
    private static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    private static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }
    public static ConfigEntry<float> UIScale { get; private set; }
    public static ConfigEntry<bool> ConstrainMainMenu { get; private set; }
    internal static ConfigEntry<bool> RemoveFogLayer { get; set; }
    private static ConfigEntry<bool> MainMenuSocials { get; set; }
    private static ConfigEntry<bool> FeedbackInfo { get; set; }

    public override void Load()
    {
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector2>();
        Logger = Log;

        CorrectFixedUpdateRate = Config.Bind("01. Performance", "Modify Physics Rate", true,
            new ConfigDescription("Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix, may not be applicable to this particular game.", null, new ConfigurationManagerAttributes { Order = 94 }));
        CorrectFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        UseRefreshRateForFixedUpdateRate = Config.Bind("01. Performance", "Use Refresh Rate For Physics Rate", false,
            new ConfigDescription("Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.", null, new ConfigurationManagerAttributes { Order = 93 }));
        UseRefreshRateForFixedUpdateRate.SettingChanged += (_, _) => { UpdateFixedDeltaTime(); };

        ConstrainMainMenu = Config.Bind("02. UI", "Constrain Main Menu", true, new ConfigDescription("Keeps the main menu in the 16:9 view.", null, new ConfigurationManagerAttributes { Order = 91 }));
        ConstrainMainMenu.SettingChanged += (_, _) => { UpdateMainMenu(); };

        UIScale = Config.Bind("02. UI", "UI Scale", 4f, new ConfigDescription("Set the UI scale.", new AcceptableValueRange<float>(0.5f, 10f), new ConfigurationManagerAttributes { Order = 92 }));
        UIScale.SettingChanged += (_, _) =>
        {
            UIScale.Value = Mathf.Round(UIScale.Value * 4f) / 4f;
            UpdateScalers();
        };

        MainMenuSocials = Config.Bind("02. UI", "Main Menu Socials", true, new ConfigDescription("Toggle the socials from the main menu.", null, new ConfigurationManagerAttributes { Order = 84 }));
        MainMenuSocials.SettingChanged += (_, _) => { UpdateSocial(); };

        FeedbackInfo = Config.Bind("02. UI", "Feedback Info", true, new ConfigDescription("Toggle the feedback info from the main menu.", null, new ConfigurationManagerAttributes { Order = 85 }));
        FeedbackInfo.SettingChanged += (_, _) => { UpdateFeedback(); };

        RemoveFogLayer = Config.Bind("03. Misc", "Remove Fog Layer", false, new ConfigDescription("Remove the lower fog layer sometimes present. Doesn't scale with ultra-wide well.", null, new ConfigurationManagerAttributes { Order = 83 }));
        RemoveFogLayer.SettingChanged += (_, _) => { UpdateFogLayer(); };

        RunInBackground = Config.Bind("03. Misc", "Run In Background", true, new ConfigDescription("Allows the game to run even when not in focus.", null, new ConfigurationManagerAttributes { Order = 82 }));
        RunInBackground.SettingChanged += (_, _) => { Application.runInBackground = RunInBackground.Value; };

        MuteInBackground = Config.Bind("03. Misc", "Mute In Background", false, new ConfigDescription("Mutes the game's audio when it is not in focus.", null, new ConfigurationManagerAttributes { Order = 81 }));

        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;

        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;

        Logger.LogInfo($"BepInEx_Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
#endif

#if MELONLOADER
    private static MelonPreferences_Category PerformanceCategory { get; set; }
    private static MelonPreferences_Entry<bool> CorrectFixedUpdateRate { get; set; }
    private static MelonPreferences_Entry<bool> UseRefreshRateForFixedUpdateRate { get; set; }

    private static MelonPreferences_Category UICategory { get; set; }
    internal static MelonPreferences_Entry<bool> ConstrainMainMenu { get; private set; }
    internal static MelonPreferences_Entry<float> UIScale { get; private set; }
    private static MelonPreferences_Entry<bool> MainMenuSocials { get; set; }
    private static MelonPreferences_Entry<bool> FeedbackInfo { get; set; }

    private static MelonPreferences_Category MiscCategory { get; set; }
    internal static MelonPreferences_Entry<bool> RemoveFogLayer { get; private set; }

    private static MelonPreferences_Entry<bool> RunInBackground { get; set; }
    private static MelonPreferences_Entry<bool> MuteInBackground { get; set; }

    public override void OnInitializeMelon()
    {
        Melon<DrovaMelon>.Logger.Msg("Initializing Ultra-Wide Mod...");
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceFloat>();
        ClassInjector.RegisterTypeInIl2Cpp<WriteOnceVector2>();
        
        // Create preferences categories and entries
        PerformanceCategory = MelonPreferences.CreateCategory("Drova Ultra-Wide -> Performance");
        CorrectFixedUpdateRate = PerformanceCategory.CreateEntry("ModifyPhysicsRate", true, "Modify Physics Rate","Adjusts the fixed update rate to minimum amount to reduce camera judder based on your refresh rate. This is a generic Unity fix, may not be applicable to this particular game.");
        CorrectFixedUpdateRate.OnEntryValueChanged.Subscribe((_, _) => { UpdateFixedDeltaTime(); });
       
        UseRefreshRateForFixedUpdateRate = PerformanceCategory.CreateEntry("UseRefreshRateForPhysicsRate", false, "Use Refresh Rate For Physics Rate","Sets the fixed update rate based on the monitor's refresh rate for smoother gameplay. Just the top option should be sufficient to reduce camera judder, but you can experiment.");
        UseRefreshRateForFixedUpdateRate.OnEntryValueChanged.Subscribe((_, _) => { UpdateFixedDeltaTime(); });
        
        UICategory = MelonPreferences.CreateCategory("Drova Ultra-Wide -> UI");
        ConstrainMainMenu = UICategory.CreateEntry("ConstrainMainMenu", true, "Constrain Main Menu", "Keeps the main menu in the 16:9 view.");
        ConstrainMainMenu.OnEntryValueChanged.Subscribe((_, _) => { UpdateMainMenu(); });
        
        UIScale = UICategory.CreateEntry("UIScale", 4f, "UI Scale", "Set the UI scale.");
        UIScale.OnEntryValueChanged.Subscribe((_, _) =>
        {
            UIScale.Value = Mathf.Round(UIScale.Value * 4f) / 4f;
            UpdateScalers();
        });
        
        MainMenuSocials = UICategory.CreateEntry("MainMenuSocials", false, "Main Menu Socials","Toggle the socials from the main menu.");
        MainMenuSocials.OnEntryValueChanged.Subscribe((_, _) => { UpdateSocial(); });
        
        FeedbackInfo = UICategory.CreateEntry("FeedbackInfo", false, "Feedback Info","Toggle the feedback info from the main menu.");
        FeedbackInfo.OnEntryValueChanged.Subscribe((_, _) => { UpdateFeedback(); });
       
        MiscCategory = MelonPreferences.CreateCategory("Drova Ultra-Wide -> Misc");
        RemoveFogLayer = MiscCategory.CreateEntry("RemoveFogLayer", false, "Remove Fog Layer","Remove the lower fog layer sometimes present.");
        RemoveFogLayer.OnEntryValueChanged.Subscribe((_, _) => { UpdateFogLayer(); });
        
        RunInBackground = MiscCategory.CreateEntry("RunInBackground", true, "Run In Background","Allows the game to run even when not in focus.");
        RunInBackground.OnEntryValueChanged.Subscribe((_, _) => { Application.runInBackground = RunInBackground.Value; });
        
        MuteInBackground = MiscCategory.CreateEntry("MuteInBackground", false, "Mute In Background","Mutes the game's audio when it is not in focus.");
      
        MelonPreferences.Save();
        
        Application.focusChanged += (Il2CppSystem.Action<bool>)FocusChanged;
        SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)OnSceneLoaded;
        
        Melon<DrovaMelon>.Logger.Msg("Ultra-Wide Mod Initialized Successfully!");
    }

#endif

    private static void FocusChanged(bool focus)
    {
        Application.runInBackground = RunInBackground.Value;
        var audioSources = Resources.FindObjectsOfTypeAll<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioSource.mute = !focus && MuteInBackground.Value;
        }
    }

    private static void UpdateFogLayer()
    {
        if (!Patches.Patches.FloorFogInstance)
        {
            Patches.Patches.FloorFogInstance = Utils.FindIl2CppType<FloorFogBhvr>().FirstOrDefault();
        }

        if (Patches.Patches.FloorFogInstance)
        {
            if (RemoveFogLayer.Value)
            {
                Patches.Patches.FloorFogInstance.ClearAll();
            }
        }
    }

    private static void UpdateSocial()
    {
        Sp = Utils.FindIl2CppType<ActivateByPlatform>().FirstOrDefault(a => a.name == "SocialPanel");
        if (Sp)
        {
            Sp.gameObject.SetActive(MainMenuSocials.Value);
        }
    }

    private static void UpdateFeedback()
    {
        var f1 = Utils.FindIl2CppType<GUI_UserReportBhvr>();
        foreach (var f in f1)
        {
            f.gameObject.SetActive(FeedbackInfo.Value);
        }

        var f2 = Utils.FindIl2CppType<TMP_GameVersionString>();
        foreach (var f in f2)
        {
            f.gameObject.SetActive(FeedbackInfo.Value);
        }
    }

    private static void UpdateMainMenu()
    {
        if (!Patches.Patches.MainMenuCamera) return;

        Patches.Patches.MainMenuCamera.cropFrame = ConstrainMainMenu.Value ? PixelPerfectCamera.CropFrame.Pillarbox : PixelPerfectCamera.CropFrame.None;
    }

    private static void UpdateScalers()
    {
        foreach (var scaler in Patches.Patches.HudScalers.Where(scaler => scaler))
        {
            scaler.scaleFactor = UIScale.Value;
        }
    }

    internal static void UpdateFixedDeltaTime()
    {
        OriginalFixedDeltaTime.Value = Mathf.RoundToInt(1f / Time.fixedDeltaTime);

        var targetRefresh = Screen.currentResolution.refreshRate;
        if (targetRefresh <= 0)
        {
#if MELONLOADER
            Melon<DrovaMelon>.Logger.Warning("Custom refresh rate is set to 0 or less. Skipping update.");
#endif
#if BEPINEX
            Logger.LogWarning("Custom refresh rate is set to 0 or less. Skipping update.");
#endif
            return;
        }

        if (Mathf.Approximately(targetRefresh, OriginalFixedDeltaTime.Value) || OriginalFixedDeltaTime.Value > targetRefresh)
        {
#if MELONLOADER
            Melon<DrovaMelon>.Logger.Msg("Game's physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
#endif
#if BEPINEX
            Logger.LogInfo("Game's physics update rate is already equal to (or greater than) your chosen refresh. Skipping update.");
#endif
            return;
        }

        if (CorrectFixedUpdateRate.Value)
        {
            if (UseRefreshRateForFixedUpdateRate.Value)
            {
                Time.fixedDeltaTime = 1f / targetRefresh;
            }
            else
            {
                Time.fixedDeltaTime = 1f / Utils.FindLowestFrameRateMultipleAboveFifty(targetRefresh);
            }
        }
        else
        {
            Time.fixedDeltaTime = 1f / OriginalFixedDeltaTime.Value;
        }


        var currentFixedDelta = 1f / Time.fixedDeltaTime;
        if (Mathf.Approximately(currentFixedDelta, OriginalFixedDeltaTime.Value)) return;
#if MELONLOADER
        Melon<DrovaMelon>.Logger.Warning($"Physics update rate set to {currentFixedDelta}Hz");
#endif
#if BEPINEX
        Logger.LogInfo($"Physics update rate set to {currentFixedDelta}Hz");
#endif
    }


    private static void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (mode != LoadSceneMode.Single) return;
        if (scene.name != "Scene_MainMenu") return;

        UpdateMainMenu();
        UpdateFeedback();
        UpdateSocial();
    }
}