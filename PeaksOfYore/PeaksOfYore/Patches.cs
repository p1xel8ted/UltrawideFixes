using SCPE;
using UnityEngine.Rendering.PostProcessing;
using Dithering = UnityEngine.Rendering.PostProcessing.Dithering;

namespace PeaksOfYore;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(LevelLoader), nameof(LevelLoader.Start))]
    public static void LevelLoader_Start(LevelLoader __instance)
    {
        var rect = __instance.blackScreen.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessVolume), nameof(PostProcessVolume.Update))]
    public static void PostProcessVolume_Update(ref PostProcessVolume __instance)
    {
        var ap = __instance.profile;
        ap.TryGetSettings(out ScreenSpaceReflections ssr);
        if (ssr)
        {
            ssr.resolution.value = ScreenSpaceReflectionResolution.FullSize;
            ssr.preset.value = ScreenSpaceReflectionPreset.Ultra;
        }

        ap.TryGetSettings(out Sharpen sharpen);
        if (sharpen)
        {
            sharpen.active = true;
            sharpen.amount.value = Plugin.SharpenAmount.Value;
        }

        ap.TryGetSettings(out Vignette vignette);
        if (vignette)
        {
            vignette.active = Plugin.Vignette.Value;
        }

        ap.TryGetSettings(out SCPE.Dithering dithering);
        if (dithering)
        {
            dithering.active = Plugin.Dithering.Value;
        }
    }
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.UpdateVolumeSystem))]
    public static void PostProcessLayer_UpdateVolumeSystem(ref PostProcessLayer __instance)
    {
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(PostProcessLayer), nameof(PostProcessLayer.Init))]
    public static void PostProcessLayer_Init(ref PostProcessLayer __instance)
    {
        __instance.gameObject.TryGetComponent(out PostProcessVolume volume);
        if (!volume)
        {
            volume = __instance.gameObject.AddComponent<PostProcessVolume>();
        }
        __instance.antialiasingMode = Plugin.AntiAliasing.Value;

        var ap = volume.profile;
        ap.TryGetSettings(out ScreenSpaceReflections ssr);
        if (!ssr)
        {
            ssr = ScriptableObject.CreateInstance<ScreenSpaceReflections>();
            ap.AddSettings(ssr);
            ssr.active = true;
        }
            
        ssr.resolution.value = ScreenSpaceReflectionResolution.FullSize;
        ssr.preset.value = ScreenSpaceReflectionPreset.Ultra;

        ap.TryGetSettings(out Sharpen sharpen);
        if (sharpen is not null)
        {
            sharpen.active = true;
            sharpen.amount.value = Plugin.SharpenAmount.Value;
        }

        ap.TryGetSettings(out Vignette vignette);
        if (vignette is not null)
        {
            vignette.active = Plugin.Vignette.Value;
        }

        ap.TryGetSettings(out SCPE.Dithering dithering);
        if (dithering is not null)
        {
            dithering.active = Plugin.Dithering.Value;
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(NPC_ParcelDeliverySystem), nameof(NPC_ParcelDeliverySystem.Start))]
    public static void NPC_ParcelDeliverySystem_Start(ref NPC_ParcelDeliverySystem __instance)
    {
        var parent = __instance.dialogueBackground;
        var newBackground = new GameObject("DialogueBackground");
        newBackground.transform.SetParent(parent.gameObject.transform);
        newBackground.AddComponent<Canvas>();
        newBackground.AddComponent<CanvasRenderer>();
        // newBackground.AddComponent<RectTransform>();
        var originalImage = parent.GetComponent<Image>();
        
        var copiedComponent = ComponentExtension.CopyComponent(originalImage, newBackground);
        copiedComponent.color = new Color(0, 0, 0, 0.9f);
        var rect = newBackground.GetComponent<RectTransform>();
        rect.localScale = new Vector3(1f, 1, 1f);
        rect.position = new Vector3(Plugin.MainWidth / 2f, 0f, 0f);
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        newBackground.transform.SetAsFirstSibling();
        
        Object.Destroy(originalImage);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(NPCSystem), nameof(NPCSystem.Start))]
    public static void NPCSystem_Start(ref NPCSystem __instance)
    {
        var parent = __instance.dialogueBackground;
        var newBackground = new GameObject("DialogueBackground");
        newBackground.transform.SetParent(parent.gameObject.transform);
        newBackground.AddComponent<Canvas>();
        newBackground.AddComponent<CanvasRenderer>();
        // newBackground.AddComponent<RectTransform>();
        var originalImage = parent.GetComponent<Image>();
        
        var copiedComponent = ComponentExtension.CopyComponent(originalImage, newBackground);
        copiedComponent.color = new Color(0, 0, 0, 0.9f);
        var rect = newBackground.GetComponent<RectTransform>();
        rect.localScale = new Vector3(1f, 1, 1f);
        rect.position = new Vector3(Plugin.MainWidth / 2f, 0f, 0f);
        rect.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
        newBackground.transform.SetAsFirstSibling();
        
        Object.Destroy(originalImage);
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuCursor), nameof(MenuCursor.Start))]
    public static void MenuCursor_Start()
    {
        Plugin.UpdateMainMenu();
        Plugin.UpdateResolutionText();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    public static void AspectRatioFitter_OnEnable(ref AspectRatioFitter __instance)
    {
        __instance.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        __instance.aspectRatio = Plugin.MainAspectRatio;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Dropdown), nameof(Dropdown.Start))]
    public static void Dropdown_Start(Dropdown __instance)
    {
        if (__instance.name.Equals("ScreenResolutionDropdownCustom"))
        {
            __instance.value = __instance.options.Count - 1;
            __instance.interactable = false;
        }
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Button), nameof(Button.ToggleFullScreen))]
    [HarmonyPatch(typeof(Button), nameof(Button.ToggleBorderlessWindowed))]
    public static bool Button_Toggles(Button __instance)
    {
        SetButtonOptions(__instance);
        return false;
    }

    private static void SetButtonOptions(Button __instance)
    {
        Button.fullScreenCheck = true;
        Button.borderlessCheck = true;

        ActivateAndDisableButton(__instance.buttonOn);
        ActivateAndDisableButton(__instance.buttonOff);
        ActivateAndDisableButton(__instance.borderlessButtonOn);
        ActivateAndDisableButton(__instance.borderlessButtonOff);
    }


    private static void ActivateAndDisableButton(GameObject buttonObj)
    {
        if (!buttonObj) return;
        buttonObj.SetActive(true);
        var button = buttonObj.GetComponent<UnityEngine.UI.Button>();
        if (button)
        {
            button.interactable = false;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(Button), nameof(Button.LoadSavedOptions))]
    public static void Button_LoadSavedOptions(Button __instance)
    {
        SetButtonOptions(__instance);
    }

}