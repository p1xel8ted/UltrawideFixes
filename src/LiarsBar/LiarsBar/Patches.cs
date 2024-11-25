using TMPro;
using UnityEngine.Localization.Components;

namespace LiarsBar;

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
    }
    
    // [HarmonyPostfix]
    // [HarmonyPatch(typeof(InspectManager), nameof(InspectManager.ActiveInspector))]
    // public static void InspectManager_ActiveInspector(InspectManager __instance)
    // {
    //     if (__instance.name == "selector_resolution")
    //     {
    //         var txt = __instance.transform.Find("txt_title");
    //         if (txt)
    //         {
    //             var text = txt.GetComponent<TextMeshProUGUI>();
    //             if (text)
    //             {
    //                 text.text = "Press F1 to change resolution";
    //             }
    //         }
    //     }
    // }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(ContentSizeFitter), nameof(ContentSizeFitter.OnEnable))]
  
    public static void ContentSizeFitter_OnEnable(ContentSizeFitter __instance)
    {
        var resSelector = __instance.transform.Find("selector_resolution");
        if (resSelector)
        {
            var button = resSelector.GetComponentInChildren<Button>();
            if (button)
            {
                Plugin.Log.LogWarning("Removing button click listeners");
                button.onClick.RemoveAllListeners();
            }
            
            var horizSelector = resSelector.GetComponentInChildren<HorizontalSelector>();
            if (horizSelector)
            {
                Plugin.Log.LogWarning("Disabling horizontal selector");
                horizSelector.gameObject.SetActive(false);
            }
            
            var txtParent = resSelector.Find("txt_title");
            if (txtParent)
            {
                var localizer = txtParent.GetComponentInChildren<LocalizeStringEvent>();
                if (localizer)
                {
                    Plugin.Log.LogWarning("Disabling localizer");
                    localizer.enabled = false;
                }
                var text = txtParent.GetComponentInChildren<TextMeshProUGUI>();
                if (text)
                {
                    Plugin.Log.LogWarning("Changing resolution text");
                    text.enableWordWrapping = false;
                    text.text = "Press F1 to change resolution";
                }
            }
        
        }
    }
}