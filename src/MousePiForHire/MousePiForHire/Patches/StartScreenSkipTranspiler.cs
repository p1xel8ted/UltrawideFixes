namespace MousePiForHire.Patches;

// Skips the press-any-key screen by rewriting the "StartScreenScene" string in the two methods
// that load it, so the game goes straight from splashes (or the first-launch accessibility setup)
// into the main menu.
[Harmony]
[HarmonyPriority(Priority.First)]
public static class StartScreenSkipTranspiler
{
    private const string StartScreenScene = "StartScreenScene";
    private const string MainMenu = "MainMenu";

    [HarmonyTargetMethods]
    [UsedImplicitly]
    private static IEnumerable<MethodBase> TargetMethods()
    {
        yield return AccessTools.Method(typeof(SplashScreensController), nameof(SplashScreensController.LoadMainMenu));
        yield return AccessTools.Method(typeof(AccessibilitySetupController), nameof(AccessibilitySetupController.NextScreen));
    }

    [HarmonyTranspiler]
    [UsedImplicitly]
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, MethodBase original)
    {
        var rewrites = 0;
        foreach (var instruction in instructions)
        {
            if (instruction.opcode == OpCodes.Ldstr && instruction.operand as string == StartScreenScene)
            {
                instruction.operand = MainMenu;
                rewrites++;
            }
            yield return instruction;
        }
        Plugin.Log.LogInfo($"[StartScreenSkip] Transpiled {original.DeclaringType?.Name}.{original.Name}: rewrote {rewrites} '{StartScreenScene}' literal(s) -> '{MainMenu}'.");
    }
}
