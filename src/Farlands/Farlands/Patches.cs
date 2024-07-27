namespace Farlands;

[Harmony]
public static class Patches
{
    private const string BaseCanvas = "BaseCanvas";
    private const string Crossfade = "Crossfade";
    private const string Black = "Black";
    private const string DialogueManager = "Dialogue Manager";
    private const string Sinai = "sinai";
    internal static CanvasScaler BaseCanvasCanvasScaler;
    internal static CanvasScaler DialogScaler;

    internal readonly static Dictionary<CinemachineVirtualCamera, WriteOnce<float>> CameraOrthographicSize = new();

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains(Sinai)) return;

        __instance.uiScaleMode = Plugin.ScaleMode.Value;
        __instance.screenMatchMode = Plugin.ScreenMatchMode.Value;
        __instance.scaleFactor = Plugin.ScaleFactor.Value;

        //find and set the base UI canvas (hud/toolbar)
        var baseCanvas = __instance.transform.Find(BaseCanvas);
        if (baseCanvas)
        {
            BaseCanvasCanvasScaler = __instance;
            Plugin.UpdateExtraCanvasScalers();
        }

        //find and set the dialogue canvas
        var dialogueSystemController = __instance.gameObject.GetFullPath().StartsWith(DialogueManager);
        if (dialogueSystemController)
        {
            DialogScaler = __instance;
            Plugin.UpdateExtraCanvasScalers();
        }

        //scale the fade to black screens
        if (__instance.name.Equals(Crossfade))
        {
            var black = __instance.transform.Find(Black);
            if (black)
            {
                black.transform.localScale = new Vector3(100f, 100f, 1);
            }
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.OnEnable))]
    [HarmonyPatch(typeof(AspectRatioFitter), nameof(AspectRatioFitter.Start))]
    public static void AspectRatioFitter_OnEnable(AspectRatioFitter __instance)
    {
        if (__instance.name.Equals(BaseCanvas))
        {
            if (Plugin.ExpandHUD.Value)
            {
                __instance.aspectRatio = Plugin.MainWidth / (float) Plugin.MainHeight;
            }
            else
            {
                __instance.aspectRatio = Plugin.NativeAspectRatio;
            }
        }
        __instance.SetDirty();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(LoadGameAds), nameof(LoadGameAds.OnEnable))]
    public static bool LoadGameAds_OnEnable(LoadGameAds __instance)
    {
        __instance.adsData.show_banner = false;
        __instance.adsData = null;
        return false;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(PixelPerfectCamera), nameof(PixelPerfectCamera.OnEnable))]
    public static void PixelPerfectCamera_OnEnable(PixelPerfectCamera __instance)
    {
        __instance.cropFrame = PixelPerfectCamera.CropFrame.None;
        __instance.m_CinemachineCompatibilityMode = true;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(IntroScript), nameof(IntroScript.Start))]
    public static void IntroScript_Start(IntroScript __instance)
    {
        var videoPlayer = __instance.GetComponent<VideoPlayer>();
        videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(CinemachineVirtualCamera), nameof(CinemachineVirtualCamera.OnEnable))]
    public static void CinemachineVirtualCamera_OnEnable(CinemachineVirtualCamera __instance)
    {
        var orthographicSize = new WriteOnce<float>
        {
            Value = __instance.m_Lens.OrthographicSize
        };

        if (CameraOrthographicSize.TryAdd(__instance, orthographicSize))
        {
            Plugin.UpdateCamera(__instance, orthographicSize.Value);
        }
    }

    internal static float GetMoveSpeed(float current)
    {
        var pctIncrease = Plugin.MoveSpeedMultiplier.Value / 100f;
        return current * (1f + pctIncrease);
    }

    internal static float GetPickupRange(float current)
    {
        var pctIncrease = Plugin.PickupRangeMultiplier.Value / 100f;
        return current * (1f + pctIncrease);
    }

    internal static float GetPickupSpeed(float current)
    {
        var pctIncrease = Plugin.PickupSpeedMultiplier.Value / 100f;
        return current * (1f + pctIncrease);
    }

    internal static float GetEnergyReduction(float current)
    {
        var pctReduction = Plugin.EnergyReductionMultiplier.Value / 100f;
        return current * (1f - pctReduction);
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(BugCatcherScript), nameof(BugCatcherScript.Update))]
    [HarmonyPatch(typeof(BugCatcherScript), nameof(BugCatcherScript.OnDestroy))]
    public static IEnumerable<CodeInstruction> BugCatcherScript_Update(IEnumerable<CodeInstruction> instructions)
    {
        var codes = instructions.ToList();
        var getSpeedMethod = AccessTools.Method(typeof(Patches), nameof(GetMoveSpeed));
        var moveSpeedField = AccessTools.Field(typeof(PlayerController), nameof(PlayerController.m_movementSpeed));
        for (var index = 0; index < codes.Count; index++)
        {
            if (codes[index].opcode == OpCodes.Ldc_R4 && codes[index].OperandIs(40f))
            {
                codes[index] = new CodeInstruction(OpCodes.Ldc_R4, 40f);
                codes.Insert(index + 1, new CodeInstruction(OpCodes.Call, getSpeedMethod));
            }

            if (codes[index].opcode == OpCodes.Ldc_R4 && codes[index].OperandIs(85f))
            {
                codes[index] = new CodeInstruction(OpCodes.Ldc_R4, 85f);
                codes.Insert(index + 1, new CodeInstruction(OpCodes.Call, getSpeedMethod));
            }
        }
        return codes.AsEnumerable();
    }


    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlayerController), nameof(PlayerController.MoveUpdate))]
    public static void PlayerController_MoveUpdate(PlayerController __instance)
    {
        __instance.m_movementSpeed = GetMoveSpeed(85f);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(WorldItem), nameof(WorldItem.Start))]
    [HarmonyPatch(typeof(WorldItem), nameof(WorldItem.Awake))]
    public static void WorldItem_Start(WorldItem __instance)
    {
        __instance.detectionRange = GetPickupRange(50f);
        __instance.pickupRange = GetPickupRange(15f);
        __instance.moveSpeed = GetPickupSpeed(200f);
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(PlayerEnergySystem), nameof(PlayerEnergySystem.ConsumeEnergy))]
    public static void PlayerEnergySystem_ConsumeEnergy(ref float amount)
    {
       var ogAmount = amount;
       var newAmount = GetEnergyReduction(ogAmount);
       amount = newAmount;
    }
}