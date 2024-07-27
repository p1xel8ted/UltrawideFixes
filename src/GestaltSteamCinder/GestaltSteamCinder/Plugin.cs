using System;
using BepInEx.Logging;
using I2.Loc;
using Il2CppInterop.Runtime;
using JetBrains.Annotations;
using PixelCrushers.DialogueSystem;
using Object = UnityEngine.Object;

namespace GestaltSteamCinder;

[HarmonyPatch]
[HarmonyWrapSafe]
[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.gestaltsteamcinder.ultrawide";
    private const string PluginName = "Gestalt: Steam & Cinder Ultra-Wide";
    private const string PluginVersion = "0.1.1";
    private const string LogosAndControllerWarningScene = "Logos and controller warning scene";
    private const string StartingScene = "starting_scene";
    private const string LeftPillarBox = "PillarBoxMask/RootPanel/Left";
    private const string RightPillarBox = "PillarBoxMask/RootPanel/Right";
    private const float NativeAspect = 16f / 9f;
    private const string Vignette = "ProCamera2DShakeContainer/MainCamera (ProCamera2D)/GradientBlackBars";
    private const string HeatShimmer = "ProCamera2DShakeContainer/MainCamera (ProCamera2D)/Heat Shimmer";

    private readonly static int MainWidth = Display.main.systemWidth;
    private readonly static int MainHeight = Display.main.systemHeight;
    private readonly static int NativeWidth = Mathf.RoundToInt(MainHeight * NativeAspect);
    private readonly static int BlackBarSize = (MainWidth - NativeWidth) / 2;
    private readonly static float AspectRatio = MainWidth / (float) MainHeight;
    private readonly static float ScaleFactor = AspectRatio / NativeAspect;
    private readonly static int MaxRefreshRate = Screen.resolutions.Max(res => res.refreshRate);
    private readonly static float MiddlePosition = MainWidth / 2f;
    private readonly static float LeftLocation = MiddlePosition - BlackBarSize;
    private readonly static float RightLocation = MiddlePosition + BlackBarSize;

    private static float x;
    private static float y;

    public override void Load()
    {
        Log.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }


    [HarmonyPostfix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(SceneManager), nameof(SceneManager.Internal_SceneLoaded))]
    public static void SceneManager_Internal_SceneLoaded(Scene scene)
    {
        SkipControllerMessage(scene);

        DisablePillarbox();

        DisplayStuff();

        FixVignette();

        FixHeatShimmer();


        DisableAnimators();
    }

    private static void DisableAnimators()
    {
        var animators = Resources.FindObjectsOfTypeAll<Animator>().ToList();
        var moreAnimators = Resources.FindObjectsOfTypeAll(Il2CppType.Of<Animator>());
        animators.AddRange(moreAnimators.Select(ani => ani.TryCast<Animator>()).Where(a => a));


        foreach (var ani in animators.Where(ani => ani.name.Contains("Portrait", StringComparison.OrdinalIgnoreCase)))
        {
            Debug.Log($"Disabling {ani.name} in {ani.gameObject.name}");
            ani.enabled = false;
        }
    }

    private static void SkipControllerMessage(Scene scene)
    {
        if (scene.name.Equals(LogosAndControllerWarningScene))
        {
            SceneManager.LoadScene(StartingScene);
        }
    }

    private static void DisplayStuff()
    {
        Time.fixedDeltaTime = 1f / MaxRefreshRate;

        Screen.SetResolution(MainWidth, MainHeight, FullScreenMode.FullScreenWindow, MaxRefreshRate);

        Application.runInBackground = true;
        Application.targetFrameRate = MaxRefreshRate;
    }

    private static void DisablePillarbox()
    {
        var left = GameObject.Find(LeftPillarBox);
        if (left)
        {
            left.gameObject.SetActive(false);
        }

        var right = GameObject.Find(RightPillarBox);
        if (right)
        {
            right.gameObject.SetActive(false);
        }
    }

    private static void FixVignette()
    {
        var vignette = GameObject.Find(Vignette);
        if (vignette)
        {
            vignette.transform.localScale = new Vector3(ScaleFactor, 1, 1);
        }
    }

    private static void FixHeatShimmer()
    {
        var heatShimmer = GameObject.Find(HeatShimmer);
        if (heatShimmer)
        {
            var y1 = heatShimmer.transform.localScale.y;
            var x1 = y * AspectRatio;
            heatShimmer.transform.localScale = new Vector3(x1, y1, 1);
        }
    }

    // public static bool IsDecimal(double number)
    // {
    //     return number % 1 != 0;
    // }
    //
    // private static void PrintSceneHierarchy()
    // {
    //     var sceneObjects = SceneManager.GetActiveScene().GetRootGameObjects();
    //     foreach (var sceneObject in sceneObjects)
    //     {
    //         PrintObjectHierarchy(sceneObject.transform, sceneObject.name);
    //     }
    // }
    //
    // private static void PrintObjectHierarchy(Transform transform, string path)
    // {
    //     Debug.Log(path);
    //     foreach (var o in transform)
    //     {
    //         var child = o.TryCast<Transform>();
    //         if (child)
    //         {
    //             PrintObjectHierarchy(child, path + "/" + child.name);
    //         }
    //     }
    // }

    [HarmonyPostfix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(ProCamera2D), nameof(ProCamera2D.LateUpdate))]
    public static void ProCamera2D_FixedUpdate(ProCamera2D __instance)
    {
        __instance.Rect = new Rect(0, 0, MainWidth, MainHeight);

        if (x <= 0)
        {
            x = __instance.ScreenSizeInWorldCoordinates.x;
        }

        if (y <= 0)
        {
            y = __instance.ScreenSizeInWorldCoordinates.y;
        }

        __instance.ScreenSizeInWorldCoordinates = new Vector2(y * AspectRatio, y);
    }


    [HarmonyPostfix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        DisableAnimators();

        // if (!__instance.name.Equals("DialogueCanvas")) return;
        //
        // var animators = __instance.GetComponentsInChildren<Animator>(true).ToList();
        // animators.AddRange(__instance.GetComponents<Animator>());
        //
        // foreach (var ani in animators)
        // {
        //     if (ani.gameObject.name.Contains("Portrait", StringComparison.OrdinalIgnoreCase))
        //     {
        //         Debug.Log($"CanvasScaler: Disabling {ani.name} in {ani.gameObject.name}");
        //         ani.enabled = false;
        //     }
        // }
    }
    //
    // [HarmonyPrefix]
    // [HarmonyWrapSafe]
    // [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.Handle))]
    // public static void CanvasScaler_Handle(CanvasScaler __instance)
    // {
    //     if (!__instance.name.Equals("DialogueCanvas")) return;
    //
    //     if (LeftPortraitsPanel)
    //     {
    //         var x1 = LeftPortraitsPanel.position.x;
    //         if (!Mathf.Approximately(x1, LeftLocation))
    //         {
    //             LeftPortraitsPanel.position = LeftPortraitsPanel.position with {x = LeftLocation};
    //         }
    //     }
    //
    //     if (RightPortraitsPanel)
    //     {
    //         var x2 = RightPortraitsPanel.position.x;
    //         if (!Mathf.Approximately(x2, RightLocation))
    //         {
    //             RightPortraitsPanel.position = RightPortraitsPanel.position with {x = RightLocation};
    //         }
    //     }
    // }
    //
    // private static RectTransform LeftPortraitsPanel;
    // private static RectTransform RightPortraitsPanel;

    // [HarmonyPostfix]
    // [HarmonyWrapSafe]
    // [HarmonyPatch(typeof(GestaltVanguardStandardDialogueUI), nameof(GestaltVanguardStandardDialogueUI.OnConversationStart))]
    // public static void GestaltVanguardStandardDialogueUI_OnConversationStart(GestaltVanguardStandardDialogueUI __instance)
    // {
    //     LeftPortraitsPanel = __instance.leftPortraitsPanel;
    //     RightPortraitsPanel = __instance.rightPortraitsPanel;
    //     var animators = __instance.GetComponentsInChildren<Animator>(true).ToList();
    //     animators.AddRange(__instance.GetComponents<Animator>());
    //
    //     foreach (var ani in animators)
    //     {
    //         if (ani.gameObject.name.Contains("Portrait", StringComparison.OrdinalIgnoreCase))
    //         {
    //             ani.get_targetPosition_Injected(out var target);
    //             {
    //                 Debug.Log($"GestaltVanguardStandardDialogueUI: {ani.name} - {target}");
    //             }
    //
    //             Debug.Log($"GestaltVanguardStandardDialogueUI: Disabling {ani.name} in {ani.gameObject.name}");
    //             ani.enabled = false;
    //         }
    //     }
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Animator), nameof(Animator.SetTarget))]
    public static void Animator_SetTarget(Animator __instance, AvatarTarget targetIndex, float targetNormalizedTime)
    {
        Debug.Log($"Animator: {__instance.name} - {targetIndex} - {targetNormalizedTime}");
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Animator), nameof(Animator.Update))]
    public static void Animator_Update(Animator __instance)
    {
        Debug.Log($"Animator: {__instance.name}");
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool), typeof(int))]
    public static void Screen_SetResolution_One(ref int width, ref int height, ref bool fullscreen, ref int preferredRefreshRate)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreen = true;
        preferredRefreshRate = MaxRefreshRate;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(bool))]
    public static void Screen_SetResolution_Two(ref int width, ref int height, ref bool fullscreen)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreen = true;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode))]
    public static void Screen_SetResolution_Three(ref int width, ref int height, ref FullScreenMode fullscreenMode)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
    }

    [HarmonyPrefix]
    [HarmonyWrapSafe]
    [HarmonyPatch(typeof(Screen), nameof(Screen.SetResolution), typeof(int), typeof(int), typeof(FullScreenMode), typeof(int))]
    public static void Screen_SetResolution_Four(ref int width, ref int height, ref FullScreenMode fullscreenMode, ref int preferredRefreshRate)
    {
        width = MainWidth;
        height = MainHeight;
        fullscreenMode = FullScreenMode.FullScreenWindow;
        preferredRefreshRate = MaxRefreshRate;
    }
}