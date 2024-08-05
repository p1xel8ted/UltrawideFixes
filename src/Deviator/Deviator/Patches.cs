namespace Deviator;

[Harmony]
public static class Patches
{

    public static float GetAspectRatio()
    {
        return Plugin.ConfineArea.Value ? Plugin.MainAspectRatio : Plugin.NativeAspectRatio;
    }

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(GameCamera), nameof(GameCamera.BuildCollider))]
    public static IEnumerable<CodeInstruction> GameCamera_BuildCollider(IEnumerable<CodeInstruction> instructions)
    {
        if (!(Plugin.MainAspectRatio > Plugin.NativeAspectRatio)) return instructions.AsEnumerable();

        var codes = instructions.ToList();
        foreach (var t in codes.Where(t => t.opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float) t.operand, 1.7777778f)))
        {
            t.opcode = OpCodes.Call;
            t.operand = AccessTools.Method(typeof(Patches), nameof(GetAspectRatio));
            Plugin.Log.LogInfo("Replaced aspect ratio constant in collider generator");
        }
        return codes.AsEnumerable();
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(UpdateUVRectangle), nameof(UpdateUVRectangle.Update))]
    public static void UpdateUVRectangle_Update(UpdateUVRectangle __instance)
    {
        if (Plugin.MainAspectRatio > Plugin.NativeAspectRatio)
        {
            var rect = new Rect((1 - Plugin.NegativeScaleFactor) / 2f, 0, Plugin.NegativeScaleFactor, 1);
            __instance.GetComponent<RawImage>().uvRect = rect;
        }
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(LockResolution), nameof(LockResolution.UpdateViewRect))]
    public static void LockResolution_UpdateViewRect(LockResolution __instance)
    {
        if (Plugin.MainAspectRatio > Plugin.NativeAspectRatio)
        {
            __instance._viewRect = new Rect(0, 0, 1, 1);
        }
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(StartPanel), nameof(StartPanel.OnCreate))]
    [HarmonyPatch(typeof(StartPanel), nameof(StartPanel.OnShow))]
    public static void StartPanel_OnCreate(StartPanel __instance)
    {
        var social = __instance.transform.Find("SocialMedia");
        if (social)
        {
            social.gameObject.SetActive(!Plugin.CleanMenu.Value);
        }

        var team = __instance.transform.Find("FirstPanel/OptionsSquare/Team");
        if (team)
        {
            team.gameObject.SetActive(!Plugin.CleanMenu.Value);
        }
    }
}