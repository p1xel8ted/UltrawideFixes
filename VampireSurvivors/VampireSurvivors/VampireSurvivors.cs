using Il2Cpp;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppVampireSurvivors.UI;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

[assembly:
    MelonInfo(typeof(VampireSurvivors.VampireSurvivors), "Vampire Survivors UltraWide Fixes", "0.0.4", "p1xel8ted")]
[assembly: MelonGame("poncle", "Vampire Survivors")]

namespace VampireSurvivors;

public class VampireSurvivors : MelonMod
{
    private Il2CppArrayBase<ViewportCrop> _viewportCrop;
    private Il2CppArrayBase<Camera> _cameras;
    private Il2CppArrayBase<AspectRatioFitter> _aspectRatioFitters;
    private Il2CppArrayBase<AspectMask> _aspectMasks;

    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();

        _cameras = Resources.FindObjectsOfTypeAll<Camera>();
        _viewportCrop = Resources.FindObjectsOfTypeAll<ViewportCrop>();
        _aspectRatioFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
        _aspectMasks = Resources.FindObjectsOfTypeAll<AspectMask>();

        MelonLogger.Warning($"OnInitializeMelon: Found {_cameras.Length} Cameras");
        MelonLogger.Warning($"OnInitializeMelon: Found {_viewportCrop.Length} Viewport Crops");
        MelonLogger.Warning($"OnInitializeMelon: Found {_aspectRatioFitters.Length} Aspect Ratio Fitters");
        MelonLogger.Warning($"OnInitializeMelon: Found {_aspectMasks.Length} Aspect Masks");

        MelonLogger.Msg("Vampire Survivors UltraWide Fixes Loaded");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        foreach (var aspectMask in _aspectMasks.Where(a => a != null))
        {
            if (aspectMask.gameObject.activeSelf)
            {
                aspectMask.gameObject.SetActive(false);
            }
        }

        foreach (var viewportCrop in _viewportCrop.Where(a => a != null))
        {
            viewportCrop._currentAspectRatio = Display.main.systemWidth / (float) Display.main.systemHeight;
            viewportCrop._referenceResolution = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
            viewportCrop.ScreenRes = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
        }

    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);

        _cameras = Resources.FindObjectsOfTypeAll<Camera>();
        _viewportCrop = Resources.FindObjectsOfTypeAll<ViewportCrop>();
        _aspectRatioFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
        _aspectMasks = Resources.FindObjectsOfTypeAll<AspectMask>();
        
        MelonLogger.Warning($"OnSceneWasLoaded: Found {_cameras.Length} Cameras");
        MelonLogger.Warning($"OnSceneWasLoaded: Found {_viewportCrop.Length} Viewport Crop");
        MelonLogger.Warning($"OnSceneWasLoaded: Found {_aspectRatioFitters.Length} Aspect Ratio Fitters");
        MelonLogger.Warning($"OnSceneWasLoaded: Found {_aspectMasks.Length} Aspect Masks");

        foreach (var aspectMask in _aspectMasks.Where(a => a != null))
        {
            if (aspectMask.gameObject.activeSelf)
            {
                aspectMask.gameObject.SetActive(false);
            }
        }

        foreach (var viewportCrop in _viewportCrop.Where(a => a != null))
        {
            viewportCrop._currentAspectRatio = Display.main.systemWidth / (float) Display.main.systemHeight;
            viewportCrop._referenceResolution = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
            viewportCrop.ScreenRes = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
        }

        var backgroundFade = GameObject.Find("GAME UI/Canvas - Game UI/Safe Area/View - Paused/Fade");
        if (backgroundFade != null)
        {
            backgroundFade.transform.localScale = new Vector3(5f, 1, 1);
        }

        var backFade = GameObject.Find("GAME UI/Canvas - Game UI/Safe Area/View - ArcanaMainSelection/BlackFader");
        if (backFade != null)
        {
            backFade.transform.localScale = new Vector3(5f, 1, 1);
        }
    }
}