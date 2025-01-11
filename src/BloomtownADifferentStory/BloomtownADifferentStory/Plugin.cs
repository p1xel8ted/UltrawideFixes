namespace Doorstop;

class Entrypoint
{
    public static void Start()
    {
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), "Hi");
        Debug.LogWarning("Ultra-Wide Patch Loaded");
    }
}