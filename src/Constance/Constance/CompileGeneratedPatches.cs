namespace Constance;

[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class CompileGeneratedPatches
{
    [HarmonyTargetMethods]
    [UsedImplicitly]
    public static IEnumerable<MethodBase> TargetMethods()
    {
        var type = AccessTools.GetDeclaredMethods(typeof(CConSnapshotManager));
        foreach (var method in type.Where(method => method.Name.ContainsCaseInsensitive("TryFindFreeSnapshot")))
        {
            Plugin.Log.LogInfo("Found method to patch: " + method.Name);
            yield return method;
        }
    }
    
    [HarmonyPrefix]
    [UsedImplicitly]
    public static void Prefix(CConSnapshotManager __instance)
    {
        if (!Plugin.UnlimitedPolaroids.Value) return;

        if (__instance._snapshots.All(s => s.IsUsed))
        {
            var index = __instance._snapshots.Count;
            var newSlot = new CConSnapshotManager.SnapshotInfo(index);
            __instance._snapshots.Add(newSlot);
            Plugin.Log.LogInfo("Added new snapshot slot with index: " + index);
        }
    }
}