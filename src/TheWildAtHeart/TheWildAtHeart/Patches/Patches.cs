using System.Reflection.Emit;
using TheWildAtHeart.Misc;

namespace TheWildAtHeart.Patches;

[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, CanvasScaler.ScreenMatchMode> OriginalScaleModes = new();
    internal static readonly List<CanvasScaler> Scalers = [];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BHUDManager), nameof(BHUDManager.OnEnable))]
    public static void BHUDManager_OnEnable(BHUDManager __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "Main HUD Group", LayoutController.LayoutSize.ConfigBased, 0f, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "Main HUD Group/ShinyRockEffects/heavy-vignette", LayoutController.LayoutSize.ForceFullScreen, 0f, false);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(BTitleOverlay), nameof(BTitleOverlay.OnEnable))]
    public static void BTitleOverlay_OnEnable(BTitleOverlay __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "container", LayoutController.LayoutSize.ConfigBased, 0f, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BMapOverlay), nameof(BMapOverlay.OnEnable))]
    public static void BMapOverlay_OnEnable(BMapOverlay __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ForceSixteenNine, 0f, true);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(BTitleSettingsOverlay), nameof(BTitleSettingsOverlay.onOpen))]
    public static void BTitleSettingsOverlay_OnEnable(BTitleSettingsOverlay __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "content", LayoutController.LayoutSize.ConfigBased, 0f, true);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BInventoryOverlay), nameof(BInventoryOverlay.OnEnable))]
    public static void BInventoryOverlay_OnEnable(BInventoryOverlay __instance)
    {
        LayoutController.AddLayoutControllerPath(__instance.transform, "container", LayoutController.LayoutSize.ConfigBased, 0f, true);
        LayoutController.AddLayoutControllerPath(__instance.transform, "container/mid-section/backing", LayoutController.LayoutSize.Custom, 10f, true);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MessageBoxHud), nameof(MessageBoxHud.Show))]
    public static void MessageBoxHud_Show(MessageBoxHud __instance)
    {
        LayoutController.AddLayoutControllerRoot(__instance.transform, LayoutController.LayoutSize.ConfigBased, 0f, false);
        LayoutController.AddLayoutControllerPath(__instance.transform, "backing", LayoutController.LayoutSize.Custom, 100f, true);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(BHUDManager), nameof(BHUDManager.ToggleVignetteActive))]
    [HarmonyPatch(typeof(BHUDManager), nameof(BHUDManager.OnEnable))]
    [HarmonyPatch(typeof(BHUDManager), nameof(BHUDManager.ToggleHUDActive))]
    public static void BHUDManager_ToggleVignetteActive(BHUDManager __instance)
    {
        if (__instance.mainVignette)
        {
            __instance.mainVignette.SetActive(Plugin.Vignette.Value);
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name == "MapOverlay") return;
        ProcessScaler(__instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Resolution), nameof(Resolution.IsRightAspect), MethodType.Getter)]
    public static void Resolution_IsRightAspect(Resolution __instance, ref bool __result)
    {
        if (Mathf.Approximately(Plugin.NativeDisplayAspectRatio, __instance.ratio))
        {
            __result = true;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(BMapOverlay), nameof(BMapOverlay.OnEnable))]
    public static void BMapOverlay_FixDimensions_Prefix(BMapOverlay __instance)
    {
        __instance.rt = new RenderTexture(2560, 1440, 0);
        float width = __instance.mask.rectTransform.rect.width;
        Vector2 sizeDelta = __instance.mainView.rectTransform.sizeDelta;
        sizeDelta.x = width;
        sizeDelta.y = 1440f * width / 2560;
        __instance.mainView.rectTransform.sizeDelta = sizeDelta;
        __instance.mapCam.targetTexture = __instance.rt;
        __instance.mainView.texture = __instance.rt;
    }
    //
    // [HarmonyPrefix]
    // [HarmonyPatch(typeof(BMapOverlay), nameof(BMapOverlay.OnEnable))]
    // public static void BMapOverlay_OnEnable2(BMapOverlay __instance)
    // {
    //     if (!__instance.rt)
    //     {
    //         var width = Screen.width;
    //         var height = Screen.height;
    //         __instance.rt = new RenderTexture(width, height, 0);
    //
    //         var maskWidth = __instance.mask.rectTransform.rect.width;
    //         var sizeDelta = __instance.mainView.rectTransform.sizeDelta;
    //         sizeDelta.x = maskWidth;
    //         sizeDelta.y = (float)height * maskWidth / (float)width;
    //         __instance.mainView.rectTransform.sizeDelta = sizeDelta;
    //     }
    // }
    //
    //
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BMapOverlay), nameof(BMapOverlay.clampOrthosizeAndUpdatePips))]
    public static void ClampOrthosize_Postfix(BMapOverlay __instance)
    {
        var aspectRatio = (float)Screen.width / Screen.height;
        const float baseAspectRatio = 16f / 9f;
    
        if (Math.Abs(aspectRatio - baseAspectRatio) > 0.01f)
        {
            var aspectCompensation = Mathf.Sqrt(aspectRatio / baseAspectRatio);
            __instance.mapCam.orthographicSize = __instance.orthoSize * aspectCompensation;
        }
    }
    
    // Patch cursor movement speed for ultra-wide
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(BMapOverlay), nameof(BMapOverlay.Update))]
    public static IEnumerable<CodeInstruction> Update_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);
    
        for (var i = 0; i < codes.Count - 2; i++)
        {
            // Look for the Mathf.Lerp(40f, 400f, num2) call
            if (codes[i].opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float)codes[i].operand, 40f) &&
                codes[i + 1].opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float)codes[i + 1].operand, 400f))
            {
                // Insert aspect ratio scaling after the lerp
                codes.InsertRange(i + 4, [
                    new CodeInstruction(OpCodes.Ldc_R4, (float)Screen.width),
                    new CodeInstruction(OpCodes.Ldc_R4, (float)Screen.height),
                    new CodeInstruction(OpCodes.Div),
                    new CodeInstruction(OpCodes.Ldc_R4, 16f / 9f),
                    new CodeInstruction(OpCodes.Div),
                    new CodeInstruction(OpCodes.Call, typeof(Mathf).GetMethod("Sqrt")),
                    new CodeInstruction(OpCodes.Mul)
                ]);
                Plugin.Log.LogWarning("Patched BMapOverlay.Update cursor speed for ultra-wide aspect ratio.");
                break;
            }
        }
    
        return codes;
    }
    
    
     [HarmonyTranspiler]
     [HarmonyPatch(typeof(BMapOverlay), nameof(BMapOverlay.drawOffScreenMarkers))]
     public static IEnumerable<CodeInstruction> DrawOffScreenMarkers_Transpiler(IEnumerable<CodeInstruction> instructions)
     {
         var codes = new List<CodeInstruction>(instructions);
         var aspectRatio = (float)Screen.width / Screen.height;
         var horizontalMargin = 0.1f * (16f / 9f) / aspectRatio;
    
         for (var i = 0; i < codes.Count; i++)
         {
             // Replace the 0.1f and 0.9f horizontal clamp values
             if (codes[i].opcode == OpCodes.Ldc_R4)
             {
                 if (Mathf.Approximately((float)codes[i].operand, 0.1f) && i + 1 < codes.Count)
                 {
                     codes[i].operand = horizontalMargin;
                     Plugin.Log.LogWarning(" Patched BMapOverlay.drawOffScreenMarkers horizontal margin 1 for ultra-wide aspect ratio.");
                 }
                 else if (Mathf.Approximately((float)codes[i].operand, 0.9f) && i > 0 && Mathf.Approximately((float)codes[i - 1].operand, horizontalMargin))
                 {
                     codes[i].operand = 1f - horizontalMargin;
                     Plugin.Log.LogWarning(" Patched BMapOverlay.drawOffScreenMarkers horizontal margin 2 for ultra-wide aspect ratio.");
                 }
             }
         }
    
         return codes;
     }

    internal static void ProcessScaler(CanvasScaler scaler)
    {
        var instanceID = scaler.GetInstanceID();
        if (!OriginalScaleModes.TryGetValue(instanceID, out var mode))
        {
            OriginalScaleModes.Add(instanceID, scaler.screenMatchMode);
            mode = scaler.screenMatchMode;
            Scalers.Add(scaler);
        }

        scaler.screenMatchMode = Plugin.CurrentAspectRatio > Const.NativeAspectRatio ? CanvasScaler.ScreenMatchMode.Expand : mode;
    }
}