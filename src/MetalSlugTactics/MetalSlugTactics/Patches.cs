using Leikir.MetalSlug.TacticMap.Cameras;
using Leikir.Rendering;
using Leikir.Tools.GUI;
using Leikir.Tools.References;
using UnityEngine.U2D;

namespace MetalSlugTactics;

[Harmony]
public static class Patches
{
    private const string Sinai = "sinai";

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.ToLower().Contains(Sinai, StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }

        if (__instance.name == "Narration Introduction Canvas")
        {
            // Add black image to background
            var black = new GameObject("Black");
            black.transform.SetParent(__instance.transform, false); // 'false' keeps its local scale and position unaffected
            var image = black.AddComponent<UnityEngine.UI.Image>();
            image.color = UnityEngine.Color.black;

            // Set anchors to cover entire screen
            var rectTransform = image.rectTransform;
            rectTransform.anchorMin = new UnityEngine.Vector2(0f, 0f);
            rectTransform.anchorMax = new UnityEngine.Vector2(1f, 1f);
            rectTransform.offsetMin = Vector2.zero; // Ensures no offset from anchors
            rectTransform.offsetMax = Vector2.zero; // Ensures no offset from anchors

            // Move this GameObject to the back of the sibling order to make it the background
            black.transform.SetAsFirstSibling();

            var all = __instance.transform.Find("Narration Introduction CanvasFade");
            if (all)
            {
                all.localScale = new Vector3(Plugin.NegScaleFactor, 1f, 1f);

                var text = all.Find("Container");
                if (text)
                {
                    text.localScale = new Vector3(Plugin.PosScaleFactor, 1f, 1f);
                }
            }
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(CameraTargetCamera), nameof(CameraTargetCamera.CopyCamera))]
    public static void CameraTargetCamera_CopyCamera(CameraTargetCamera __instance)
    {
        if (__instance.name.Contains("Tactic"))
        {
            __instance._camera.aspect = Plugin.NativeAspect;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void CameraProcessor_OnEnable(PixelPerfectCamera __instance)
    {
        if (__instance.name == "DepthMapCamera")
        {
            Plugin.Log.LogWarning("DepthMapCamera enabled");
            __instance.m_Camera.enabled = true;
            __instance.m_Camera.aspect = Plugin.MainAspect;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TacticMapSkybox), nameof(TacticMapSkybox.OnEnable))]
    public static void TacticMapSkybox_OnEnable(TacticMapSkybox __instance)
    {
        __instance.transform.localScale = new Vector3(1.1f, 1.1f, 1f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(OptionResolutionSelector), nameof(OptionResolutionSelector.FillValidResolutions))]
    public static void OptionResolutionSelector_FillResolutions(OptionResolutionSelector __instance, ref List<SResolution> resolutions)
    {
        var myRes = new SResolution
        {
            Width = Plugin.MainWidth,
            Height = Plugin.MainHeight
        };
        var myList = new List<SResolution> { myRes };
        resolutions.Clear();
        resolutions.AddRange(myList);
        __instance._validResolutions.Clear();
        __instance._validResolutions.AddRange(myList);
        __instance._default = myRes;
    }
}