using System.Reflection;
using Il2CppCom.LuisPedroFonseca.ProCamera2D;

[assembly: MelonInfo(typeof(VampireSurvivors.VampireSurvivors), "Vampire Survivors UltraWide Fixes", "0.0.5", "p1xel8ted")]

namespace VampireSurvivors;

public class VampireSurvivors : MelonMod
{
    private List<ViewportCrop> ViewportCrops { get; set; } = [];
    private List<AspectMask> AspectMasks { get; set; } = [];
    private static float UltraWidth => Display.main.systemWidth;
    private static float Height => Display.main.systemHeight;
    private static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();
        RefreshResources();
        MelonLogger.Msg("Vampire Survivors UltraWide Fixes Loaded");
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        UpdateViewportAndAspectMasks();
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);
        RefreshResources();
        UpdateResolution();
        UpdateViewportAndAspectMasks();
        UpdateBackgroundScaling();
    }
    private static void UpdateResolution()
    {
        Screen.SetResolution((int) UltraWidth, (int) Height, FullScreenMode.FullScreenWindow, MaxRefresh);
        Application.targetFrameRate = MaxRefresh;
        Time.fixedDeltaTime = 1f / MaxRefresh;
    }

    private void RefreshResources()
    {
        ViewportCrops = Utils.FindIl2CppType<ViewportCrop>();
        AspectMasks = Utils.FindIl2CppType<AspectMask>();
    }

    private void UpdateViewportAndAspectMasks()
    {
        
        var systemResolution = new Vector2(UltraWidth, Height);
        
        foreach (var aspectMask in AspectMasks.Where(a => a != null))
        {
            aspectMask.gameObject.SetActive(false);
        }

        foreach (var viewportCrop in ViewportCrops.Where(a => a != null))
        {
            viewportCrop._currentAspectRatio = UltraWidth / Height;
            viewportCrop._referenceResolution = systemResolution;
            viewportCrop.ScreenRes = systemResolution;
        }
    }
    
    private static void UpdateBackgroundScaling()
    {
        ScaleGameObject("GAME UI/Canvas - Game UI/Safe Area/View - Paused/Fade", 10f);
        ScaleGameObject("GAME UI/Canvas - Game UI/Safe Area/View - ArcanaMainSelection/BlackFader", 10f);
    }

    private static void ScaleGameObject(string path, float scaleX)
    {
        var gameObject = GameObject.Find(path);
        if (gameObject != null)
        {
            gameObject.transform.localScale = new Vector3(scaleX, 1, 1);
        }
    }
}