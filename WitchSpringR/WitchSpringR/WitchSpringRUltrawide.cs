using MelonLoader;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using WitchSpringR;

[assembly: MelonInfo(typeof(WitchSpringRUltrawide), "WitchSpring R Ultra-Wide", "0.1.0", "p1xel8ted")]

namespace WitchSpringR;

public class WitchSpringRUltrawide : MelonMod
{
    /// <summary>
    /// Calculates the normal width based on the system height and a 16:9 aspect ratio.
    /// Commented numbers are based on UW3440x1440.
    /// </summary>
    private static float NormalWidth => Display.main.systemHeight * 16f / 9f; // 2560

    private static float HalfUltraWidth => UltraWidth / 2f; //1720
    internal static float WidthDifference => UltraWidth - NormalWidth; //880
    internal static float Difference => HalfUltraWidth - (WidthDifference / 2f); //1280

    //private static float Difference => (UltraWidth - NormalWidth) / 2f;

    /// <summary>
    /// Retrieves the system's ultra width.
    /// </summary>
    internal static float UltraWidth => Display.main.systemWidth;

    /// <summary>
    /// Retrieves the system's height.
    /// </summary>
    internal static float Height => Display.main.systemHeight;

    /// <summary>
    /// Retrieves the maximum refresh rate from the available screen resolutions.
    /// </summary>
    internal static int MaxRefresh => Screen.resolutions.Max(a => a.refreshRate);

    
    public override void OnUpdate()
    {
        base.OnUpdate();
        var c4 = GameObject.Find("mainCamera/Body/Box/camera");
        if (c4 != null)
        {
            var camera = c4.GetComponent<Camera>();
            camera.fieldOfView = SceneManager.GetActiveScene().name.Equals("#Title") ? 55 : 35;
        }

        if (Patches.Panel_ItemInfo_Left_Instance != null)
        {
            Patches.Panel_ItemInfo_Left_Instance.transform.position = new Vector3(WidthDifference / 2f,
                Patches.Panel_ItemInfo_Left_Instance.transform.position.y, Patches.Panel_ItemInfo_Left_Instance.transform.position.z);
        }
        
    }

    /// <summary>
    /// Overrides the base OnSceneWasInitialized method to handle specific actions based on the initialized scene.
    /// </summary>
    /// <param name="buildIndex">The build index of the initialized scene.</param>
    /// <param name="sceneName">The name of the initialized scene.</param>
    public override void OnSceneWasInitialized(int buildIndex, string sceneName)
    {
        // Call the base OnSceneWasInitialized method for any inherited behavior
        base.OnSceneWasInitialized(buildIndex, sceneName);
       // Panels = new Il2CppReferenceArray<Il2CppSystem.Object>(Resources.FindObjectsOfTypeAll(Il2CppType.Of<Panel_Basic>()));
        // Set the application's target frame rate to the maximum refresh rate
        Application.targetFrameRate = MaxRefresh;

        // Set the screen resolution based on predefined ultra width and height values
        Screen.SetResolution((int) UltraWidth, (int) Height, FullScreenMode.FullScreenWindow, MaxRefresh);

        var rightBar = GameObject.Find("Canvas(Clone)/Canvas/LetterBox_Right");
        if (rightBar != null)
        {
            rightBar.SetActive(false);
        }

        var leftBar = GameObject.Find("Canvas(Clone)/Canvas/LetterBox_Left");
        if (leftBar != null)
        {
            leftBar.SetActive(false);
        }

        var version = GameObject.Find("Canvas(Clone)/Canvas/Layer_Mid/UI_Title(Clone)/Under");
        if (version != null)
        {
            version.SetActive(false);
        }

        var c1 = GameObject.Find("Canvas(Clone)/Canvas/Layer_Top");
        if (c1 != null)
        {
            c1.transform.position = new Vector3(Difference, c1.transform.position.y, c1.transform.position.z);
        }
        var c2 = GameObject.Find("Canvas(Clone)/Canvas/Layer_Bottom");
        if (c2 != null)
        {
            c2.transform.position = new Vector3(Difference, c2.transform.position.y, c2.transform.position.z);
        }
        var c3 = GameObject.Find("Canvas(Clone)/Canvas/Layer_Base");
        if (c3 != null)
        {
            c3.transform.position = new Vector3(Difference, c3.transform.position.y, c3.transform.position.z);
        }
        var c4 = GameObject.Find("mainCamera/Body/Box/camera");
        if (c4 != null)
        {
            var camera = c4.GetComponent<Camera>();
            camera.fieldOfView = sceneName.Equals("#Title") ? 55 : 35;
        }
        
        var blackImages = Resources.FindObjectsOfTypeAll<Image>();
        foreach (var image in blackImages)
        {
            if (image.name.Equals("blackPanel"))
            {
                image.transform.localScale = new Vector3(UltraWidth, Height, 1f);
            }
        }

        var cameras = Resources.FindObjectsOfTypeAll<Camera>();
        foreach (var cam in cameras)
        {
            if (cam.transform.GetFullPath().Contains("MiniMapCamera"))
            {
                LoggerInstance.Warning($"Skipping {cam.name} | {cam.transform.GetFullPath()}");
                continue;
            }

            cam.pixelRect = new Rect(0, 0, UltraWidth, Height);
            cam.aspect = UltraWidth / Height;
            LoggerInstance.Warning(
                $"Camera: {cam.name} | {cam.transform.GetFullPath()} | {cam.pixelRect} | {cam.rect} | {cam.aspect}");
        }
    }
}