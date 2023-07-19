using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace IronMeat;

[BepInPlugin("p1xel8ted.IronMeat.IronMeat", "IronMeat", "0.1.0")]
[HarmonyPatch]
public class IronMeat : BaseUnityPlugin
{
    private static Harmony _hi;
    private static ManualLogSource _log;

    public void Awake()
    {
        _hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        _log = new ManualLogSource("Log");
        BepInEx.Logging.Logger.Sources.Add(_log);
        _log.LogInfo($"Plugin IronMeat is loaded!");
    }

    public void OnDestroy()
    {
        _hi?.UnpatchSelf();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CheckResolution), nameof(CheckResolution.Start))]
    public static bool CheckResolution_Start(ref CheckResolution __instance)
    {
        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, 120);
        return false;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(CheckResolution), nameof(CheckResolution.LateUpdate))]
    public static bool CheckResolution_LateUpdate(ref CheckResolution __instance)
    {
        if (!__instance.changed)
        {
            __instance.changed = true;
            Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true, 120);
        }

        return false;
    }

    public void Update()
    {
        var canvas = GameObject.Find("Canvas").GetComponentInChildren<CanvasScaler>();
        if (canvas != null)
        {
            if (SceneManager.GetActiveScene().name == "Start")
            {
                canvas.referenceResolution = new Vector2(Display.main.systemWidth, Display.main.systemHeight);
                canvas.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                canvas.uiScaleMode = CanvasScaler.ScaleMode.ConstantPhysicalSize;

                string[] panels = {"Forest", "FarMeat", "CloseMeat", "MiddleMeat"};
                foreach (var s in panels)
                {
                    var panel = GameObject.Find(s);
                    if (panel != null)
                    {
                        panel.transform.localScale = new Vector3(1.4f, 1, 1);
                    }
                }
            }
        }

        var cams = Camera.allCameras;
        foreach (var cam in cams)
        {
            cam.backgroundColor = Color.black;
            var pixelPerfect = cam.GetComponentInChildren<PixelPerfectCamera>();
            if (pixelPerfect != null)
            {
                pixelPerfect.stretchFill = true;
                pixelPerfect.cropFrameX = false;
                pixelPerfect.upscaleRT = false;
            }
        }

        var borders = GameObject.Find("Borders");

        if (borders != null)
        {
            borders.SetActive(false);
        }

        if (FindObjectsOfType(typeof(ParallaxScroll)) is ParallaxScroll[] parallax)
        {
            foreach (var scroll in parallax)
            {
                if (SceneManager.GetActiveScene().name.Contains("Forest"))
                {
                    scroll.gameObject.SetActive(false);
                }
                // scroll.gameObject.SetActive(false);
            }
        }
    }
}