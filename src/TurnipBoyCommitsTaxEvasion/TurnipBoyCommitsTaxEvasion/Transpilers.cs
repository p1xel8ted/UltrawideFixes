namespace TurnipBoyCommitsTaxEvasion;

[Harmony]
public static class Transpilers
{
    public static Vector3 GetScale()
    {
        return new Vector3(Plugin.NpcChatDialogScale.Value, Plugin.NpcChatDialogScale.Value, 1f);
    }
    
    [UsedImplicitly]
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(DialoguePopupController), nameof(DialoguePopupController.Disappear))]
    private static IEnumerable<CodeInstruction> Disappear_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var code = instructions.ToList();
        var vector3One = AccessTools.Property(typeof(Vector3), nameof(Vector3.one)).GetGetMethod();
        var vector3Zero = AccessTools.Property(typeof(Vector3), nameof(Vector3.zero)).GetGetMethod();
        var setAlpha = AccessTools.Property(typeof(CanvasGroup), nameof(CanvasGroup.alpha)).GetSetMethod();

        for (var i = 0; i < code.Count; i++)
        {
            if(code[i].Calls(vector3One))
            {
                code[i].operand = vector3Zero;
            }
            
            if(code[i].Calls(setAlpha) && code[i - 1].operand is 1f)
            {
                code[i - 1].operand = 0f;
            }
                
        }
        return code.AsEnumerable();
    }
    
    
    [UsedImplicitly]
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(DialoguePopupController), nameof(DialoguePopupController.Appear))]
    private static IEnumerable<CodeInstruction> Appear_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var originalInstructions = instructions.ToList();
        var vector3One = AccessTools.Property(typeof(Vector3), nameof(Vector3.one)).GetGetMethod();
        var myScale = AccessTools.Method(typeof(Transpilers), nameof(GetScale));

        foreach (var instruction in originalInstructions)
        {
            if (instruction.Calls(vector3One))
            {
                instruction.operand = myScale;
            }
            yield return instruction;
        }
    }

}