using System;
using UnityEngine;
using UnityEngine.UI;
using World.Battle.UI;
using World.UI;

namespace LastCloudia;

[Harmony]
[HarmonyWrapSafe]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UICanvasScalerSimulator), nameof(UICanvasScalerSimulator.Start))]
    public static void UICanvasScalerSimulator_Start(ref UICanvasScalerSimulator __instance)
    {
        if (__instance.name.Equals("mask", StringComparison.OrdinalIgnoreCase))
        {
            var newVector = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f);
            __instance.transform.localScale = newVector;
        }

        if (__instance.name.Equals("curtain"))
        {
            __instance.gameObject.SetActive(false);
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(HeaderRenderer), nameof(HeaderRenderer.Start))]
    [HarmonyPatch(typeof(HeaderRenderer), nameof(HeaderRenderer.UpdateUI))]
    public static void HeaderRenderer_UpdateUI(ref HeaderRenderer __instance)
    {
        var transform = __instance.transform.Find("shadow_effect");
        if (transform)
        {
           var rectTransform = transform.GetComponent<RectTransform>();
           rectTransform.sizeDelta =  rectTransform.sizeDelta with {x = Plugin.MainWidth};
        }

    }
    
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(BattleUiPanelMain), nameof(BattleUiPanelMain.UpdateMe))]
    [HarmonyPatch(typeof(BattleUiPanelMain), nameof(BattleUiPanelMain.UpdateLoad))]
    [HarmonyPatch(typeof(BattleUiPanelMain), nameof(BattleUiPanelMain.UpdateFrame))]
    [HarmonyPatch(typeof(BattleUiPanelMain), nameof(BattleUiPanelMain.ShowPanel))]
    public static void BattleUiPanelMain_ShowPanel(ref BattleUiPanelMain __instance)
    {
        var bg = __instance.transform.Find("Interactable/Bottom/bg");
        if (bg)
        {
            bg.gameObject.SetActive(false);
        }
    }
    

    [HarmonyPostfix]
    [HarmonyPatch(typeof(TiledBg), nameof(TiledBg.ChangeBg))]
    public static void TiledBg_OnEnable(ref TiledBg __instance)
    {
        var newVector = new Vector3(Plugin.PositiveScaleFactor, Plugin.PositiveScaleFactor, 1f); 
        __instance.transform.localScale = newVector;
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(ref CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        
        
        var mainPageShadowFooter = __instance.transform.FindDeepChild("shadow_effect");
        if (mainPageShadowFooter)
        {
            var rectTransform = mainPageShadowFooter.GetComponent<RectTransform>();
            rectTransform.sizeDelta = rectTransform.sizeDelta with {x = Plugin.MainWidth};
        }

        
        var resultBottomBg = __instance.transform.FindDeepChild("btm_eff");
        if (resultBottomBg)
        {
            resultBottomBg.localPosition = resultBottomBg.localPosition with {x = -(Plugin.MainWidth / 2f)};
            resultBottomBg.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }

        var resultTopBg = __instance.transform.FindDeepChild("top_eff");
        if (resultTopBg)
        {
            resultTopBg.localPosition = resultTopBg.localPosition with {x = -(Plugin.MainWidth / 2f)};
            resultTopBg.GetComponent<RectTransform>().sizeDelta = new Vector2(400f, Plugin.MainWidth); //this is not a mistake, window is rotated?
        }

        var titleOne = __instance.transform.Find("TitlePanel/TitleName");
        if (titleOne)
        {
            titleOne.gameObject.SetActive(false);
        }
        
        var titleTwo = __instance.transform.Find("TitlePanel/TitleName_part2");
        if (titleTwo)
        {
            titleTwo.gameObject.SetActive(false);
        }
        
        var menuBackground = __instance.transform.Find("BgGroup/Bg");
        if (menuBackground)
        {

            var image = menuBackground.GetComponent<Image>();
            image.rectTransform.sizeDelta = new Vector2(Plugin.MainWidth, Plugin.MainHeight);
            var pivot = image.rectTransform.pivot;

            var resourceName = Plugin.MainAspectRatio switch
            {
                >= Plugin.SuperWideAspectRatio => "LastCloudia.assets.32-9.jpg",
                > Plugin.BaseAspectRatio => "LastCloudia.assets.21-9.jpg",
                _ => "LastCloudia.assets.21-9.jpg"
            };

            var assembly = Assembly.GetExecutingAssembly();
            var texture = new Texture2D(Plugin.MainWidth, Plugin.MainHeight);

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    Plugin.Logger.LogError($"Embedded image resource not found: {resourceName}");
                    return;
                }

                var imageData = new byte[stream.Length];
                _ = stream.Read(imageData, 0, imageData.Length);
                texture.LoadImage(imageData);
            }

            image.sprite = Sprite.Create(texture, new Rect(0, 0, Plugin.MainWidth, Plugin.MainHeight), pivot);
            image.transform.localScale = Vector3.one;
        }
    }
}