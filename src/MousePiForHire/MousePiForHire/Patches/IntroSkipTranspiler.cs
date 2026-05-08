namespace MousePiForHire.Patches;

// Skips publisher/engine splash screens by zeroing the fade durations and the wait between splashes.
[Harmony]
[HarmonyPriority(Priority.First)]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class IntroSkipTranspiler
{
    private const string MoveNext = "MoveNext";

    [UsedImplicitly]
    [HarmonyTargetMethod]
    public static MethodBase Target() =>
        AccessTools.Method(typeof(SplashScreensController), nameof(SplashScreensController.ShowSplashScreenAsync))
            ?.GetCustomAttribute<AsyncStateMachineAttribute>()?.StateMachineType is { } smType
            ? AccessTools.Method(smType, MoveNext)
            : null;

    // ldc.r4 1.0 -> ldc.r4 0.0 (kills fadeDuration + alpha targets);
    // ldfld SplashScreen.Delay -> pop + ldc.r4 0 (kills inter-splash wait).
    [UsedImplicitly]
    [HarmonyTranspiler]
    public static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = instructions.ToList();
        var delayField = AccessTools.Field(typeof(SplashScreensController.SplashScreen), nameof(SplashScreensController.SplashScreen.Delay));
        int zeroed = 0, popped = 0;

        for (var i = 0; i < codes.Count; i++)
        {
            if (codes[i].opcode == OpCodes.Ldc_R4 && codes[i].operand is float f && Mathf.Approximately(f, 1f))
            {
                codes[i].operand = 0f;
                zeroed++;
                continue;
            }

            if (codes[i].opcode == OpCodes.Ldfld && ReferenceEquals(codes[i].operand, delayField))
            {
                codes[i] = new CodeInstruction(OpCodes.Pop);
                codes.Insert(i + 1, new CodeInstruction(OpCodes.Ldc_R4, 0f));
                popped++;
                i++;
            }
        }
        Plugin.Log.LogInfo($"[IntroSkip] ShowSplashScreenAsync MoveNext patched: zeroed {zeroed} ldc.r4 1.0 (fadeDuration + DOFade alpha targets), popped {popped} ldfld SplashScreen.Delay (replaced with 0).");
        return codes;
    }
}
