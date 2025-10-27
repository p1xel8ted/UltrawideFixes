using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime.Injection;
using Il2CppSystem.Configuration;
using OnceUponKatamari.Core.Configuration;
using OnceUponKatamari.Resolutions;
using OnceUponKatamari.UI.Components;
using OnceUponKatamari.UI.Patches;
using UnityEngine.Events;

namespace OnceUponKatamari;

/// <summary>
/// Main BepInEx plugin class that coordinates ultra-wide monitor support for Winter Burrows.
/// Manages resolution, UI scaling, and camera viewport settings.
/// </summary>
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.onceuponkatamari.ultrawide";
    private const string PluginName = "Once Upon a Katamari Ultra-Wide";
    private const string PluginVersion = "0.1.0";
    
    public const float NativeAspect = 16f / 9f;
    internal static ManualLogSource Logger { get; private set; }

    public override void Load()
    {
        Logger = Log;

        ClassInjector.RegisterTypeInIl2Cpp<LayoutWidthAspectFitter>();
        ClassInjector.RegisterTypeInIl2Cpp<CanvasScalerPatches.ForceImageOff>();
        
        UIConfig.Initialize(Config);
        GameConfig.Initialize(Config);

        UnityEngine.SceneManagement.SceneManager.sceneLoaded += (UnityAction<UnityEngine.SceneManagement.Scene, LoadSceneMode>)OnSceneLoaded;
        ResolutionChangeHandler.OnResolutionChange += OnResolutionChanged;

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);

        Log.LogInfo($"Plugin {PluginName} is loaded!");
    }



    private static void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, LoadSceneMode mode)
    {
        UpdateAll();
    }


    private static void OnResolutionChanged(Vector2 newRes)
    {
        UpdateAll();
    }


    private static void UpdateAll()
    {
        UpdateDisplay();
        UpdateFitterScalers();
    }

    private static void UpdateFitterScalers()
    {
        CanvasScalerPatches.UpdateScalers(ResolutionManager.CurrentAspect);
        AspectRatioFitterFactory.UpdateFitters();
    }


    private static void UpdateDisplay()
    {

        Screen.SetResolution(
            ResolutionManager.NativeDisplayWidth,
            ResolutionManager.NativeDisplayHeight,
            FullScreenMode.FullScreenWindow,
            ResolutionManager.RefreshRate);
        
        CanvasScalerPatches.UpdateScalers(ResolutionManager.CurrentAspect);
        AspectRatioFitterFactory.UpdateFitters();
    }
}