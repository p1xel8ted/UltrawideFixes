namespace Anodyne2UltraWide;

[Harmony]
public static class Transpilers
{
    private const string TwitterString = "https://www.analgesic.productions/twitter.html";
    private const string GitHubString = "https://github.com/p1xel8ted";

    /// <summary>
    /// Replaces the Twitter link with a link to the GitHub repository.
    /// </summary>
    /// <param name="instructions"></param>
    /// <returns></returns>
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(SaveModule), nameof(PauseMenu.Update))]
    private static IEnumerable<CodeInstruction> PauseMenu_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var originalInstructions = instructions.ToList();
        foreach (var instruction in originalInstructions.Where(instruction => instruction.opcode == OpCodes.Ldstr && instruction.operand.ToString().Equals(TwitterString)))
        {
            instruction.operand = GitHubString;
        }
        return originalInstructions;
    }

    /// <summary>
    /// Removes the multiplication by 2f in the SaveModule.Update method to correct the selection spacing on the menu
    /// </summary>
    /// <param name="instructions"></param>
    /// <returns></returns>
    [HarmonyTranspiler]
    [HarmonyPatch(typeof(SaveModule), nameof(SaveModule.Update))]
    private static IEnumerable<CodeInstruction> SaveModule_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var spacingField = AccessTools.Field(typeof(SaveModule), nameof(SaveModule.spacing));
        var yVector3Field = AccessTools.Field(typeof(Vector3), nameof(Vector3.y));
        var codes = instructions.ToList();

        for (var i = 0; i < codes.Count - 1; i++)
        {
            if (codes[i].LoadsField(yVector3Field) && 
                codes[i + 1].opcode == OpCodes.Ldc_R4 && 
                Mathf.Approximately((float)codes[i + 1].operand, 2f))
            {
                // Remove the multiplication by 2f
                codes.RemoveAt(i + 1); // Removes Ldc_R4 2f
                i--; // Adjust index after removal
            }
            else if (codes[i].LoadsField(spacingField) && 
                     codes[i + 1].opcode == OpCodes.Mul)
            {
                // Remove the multiplication operation
                codes.RemoveAt(i + 1); // Removes Mul
                i--; // Adjust index after removal
            }
        }
        return codes;
    }


}