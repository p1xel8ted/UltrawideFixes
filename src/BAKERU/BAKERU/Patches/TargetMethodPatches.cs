namespace BAKERU.Patches;

[Harmony]
public class TargetMethodPatches
{

    [HarmonyTargetMethods]
    public static IEnumerable<MethodBase> TargetMethods()
    {
        var methods = AccessTools.GetDeclaredMethods(typeof(ScreenManager)).Where(a => a.Name == "CheckAspectRatio");
        foreach (var method in methods)
        {
            yield return method;
        }
    }
    
    [HarmonyPostfix]
    public static void ScreenManager_CheckAspectRatio(ref bool __result)
    {
        __result = true;
    }
}