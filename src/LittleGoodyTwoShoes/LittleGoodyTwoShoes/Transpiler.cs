namespace LittleGoodyTwoShoes;

[Harmony]
public static class Transpiler
{
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(SceneMaster), nameof(SceneMaster.GoToOpeningVideo))]
    private static IEnumerable<CodeInstruction> SceneMaster_GoToOpeningVideo_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);
        foreach (var t in codes.Where(t => t.opcode == OpCodes.Ldc_I4_S && (sbyte) t.operand == 14))
        {
            t.operand = (sbyte) 13;
            break;
        }
        return codes;
    }
}