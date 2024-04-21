using System;

namespace MagentaHorizon;

[Harmony]
public static class Patches
{

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        __instance.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

        if (!__instance.name.Equals("Canvas")) return;
        if (SceneManager.GetActiveScene().name.Contains("MainMenu", StringComparison.OrdinalIgnoreCase)) return;
        if (SceneManager.GetActiveScene().name.Contains("Cutscene", StringComparison.OrdinalIgnoreCase)) return;

        PrepareUI(__instance.transform);
    }

    private static void PrepareUI(Transform tf)
    {
        LeftSideObject ??= new GameObject("LeftSide");
        RightSideObject ??= new GameObject("RightSide");
        
        foreach (var item in LeftSide)
        {
            var obj = tf.Find(item);
            if (obj)
            {
                obj.SetParent(LeftSideObject.transform);
            }
        }
        
        foreach (var item in RightSide)
        {
            var obj = tf.Find(item);
            if (obj)
            {
                obj.SetParent(RightSideObject.transform);
            }
        }
        
        LeftSideObject.transform.SetParent(tf);
        RightSideObject.transform.SetParent(tf);

        LeftSideObject.TryAddComponent<LeftHudMover>();
        RightSideObject.TryAddComponent<RightHudMover>();
    }

    private static GameObject LeftSideObject;
    private static GameObject RightSideObject;

    private readonly static string[] LeftSide =
    [
        "SkillGroupCircle",
        "Cross",
        "CharacterFace",
        "Skill01Slot",
        "Skill02Slot",
        "Skill03Slot",
        "Skill04Slot",
        "Skill01Slider",
        "Skill02Slider",
        "Skill03Slider",
        "Skill04Slider",
        "PlayerStatSlider",
        "healslot",
        "healslot (1)",
        "healslot (2)",
        "healChance01",
        "healChance02",
        "healChance03",
        "Image_1",
        "Image_2",
        "Image_3",
        "Image_4",
        "StyleMeter"
    ];

    private readonly static string[] RightSide =
    [
        "KeySlot (1)",
        "KeySlot (2)",
        "KeySlot (3)",
        "HornMoney",
        "HornMoneyValue"
    ];

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuFunctions), nameof(MainMenuFunctions.ResolutionChanged))]
    public static void MainMenuFunctions_ResolutionChanged(MainMenuFunctions __instance)
    {
        switch (__instance.resolution.value)
        {
            case 9:
                SetRes(__instance);
                break;
            default:
                return;
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenuFunctions), nameof(MainMenuFunctions.Start))]
    public static void MainMenuFunctions_Start(MainMenuFunctions __instance)
    {
        var optionData = new Dropdown.OptionData
        {
            text = $"{Plugin.MainWidth}x{Plugin.MainHeight}"
        };
        __instance.resolution.options.Add(optionData);
        MainMenuFunctions.sizeNumber = __instance.sceneData.screenResolution;
        switch (MainMenuFunctions.sizeNumber)
        {
            case 10:
                SetRes(__instance);
                break;
        }
    }

    private static void SetRes(MainMenuFunctions ctx)
    {
        MainMenuFunctions.sizeNumber = 10;
        ctx.sceneData.screenResolution = MainMenuFunctions.sizeNumber;
        Screen.SetResolution(Plugin.MainWidth, Plugin.MainHeight, MainMenuFunctions.fullScreen, Plugin.MaxRefresh);
    }
}