namespace LaikaAgedThroughBlood;

[Harmony]
public static class WalkieTranspiler
{
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(WalkieTalkieDisplay), nameof(WalkieTalkieDisplay.Hide))]
    public static IEnumerable<CodeInstruction> WalkieTalkieDisplay_Hide(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);
        foreach (var code in codes.Where(code => code.opcode == OpCodes.Ldc_R4))
        {
            if ((float) code.operand != 0f) continue;
            
            code.opcode = OpCodes.Ldc_R4;
            code.operand = -350f;
        }
        return codes.AsEnumerable();
    }
}