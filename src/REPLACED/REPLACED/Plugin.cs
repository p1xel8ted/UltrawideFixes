namespace REPLACED;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.replaced.ultrawide";
    private const string PluginName = "REPLACED Ultra-Wide";

    private const string PluginVersion = "0.1.0";

    internal static readonly int MainWidth = Display.main.systemWidth;
    internal static readonly int MainHeight = Display.main.systemHeight;

    internal static readonly float TargetWidthAspect = MainWidth / (float)MainHeight * 9f;
    internal const float NativeMaxAspect = 21.6f / 9f; //intentional
    private const float SuperUltraWideThreshold = 2.388889f;
    internal static readonly float CurrentAspect = MainWidth / (float)MainHeight;

    internal static ConfigEntry<bool> ConstrainHud;

    public override void Load()
    {
        ConstrainHud = Config.Bind("01. UI", "Constrain HUD to 16:9", CurrentAspect >= SuperUltraWideThreshold,
            new ConfigDescription("Constrains the in-game HUD to 16:9. Only relevant at aspects wider than 21:9."));

        Console.WriteLine($"[{PluginName}] Plugin loaded! Aspect={CurrentAspect:F2}, ConstrainHud={ConstrainHud.Value}");

        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }
}