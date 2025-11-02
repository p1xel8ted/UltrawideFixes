using Patches = Shared.Patches;
using DisplayMetrics = Shared.DisplayMetrics;

[assembly: MelonInfo(typeof(Plugin), Plugin.PluginName, Plugin.PluginVersion, "p1xel8ted")]

namespace VampireSurvivors;

public class Plugin : MelonMod
{
    internal const string PluginName = "Vampire Survivors Ultra-Wide (Melon)";
    internal const string PluginVersion = "0.2.2";

    public static MelonPreferences_Entry<bool> ExpandSpawnZone { get; private set; }
    internal static MelonPreferences_Entry<KeyCode> ExpandSpawnZoneToggle { get; set; }
    private static MelonPreferences_Category ConfigCategory { get; set; }

    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();

        ConfigCategory = MelonPreferences.CreateCategory("UW", "Ultra-Wide Settings");
        ExpandSpawnZone = ConfigCategory.CreateEntry("ExpandSpawnZone", true, "Expands the spawn zone to fit the new resolution.");
        ExpandSpawnZone.OnEntryValueChanged.Subscribe((_, _) => Patches.UpdateStageRects());

        ExpandSpawnZoneToggle = ConfigCategory.CreateEntry("ExpandSpawnZoneToggle", KeyCode.F9, "Key to toggle expanding the spawn zone.");

        ConfigCategory.SaveToFile(false);

        // Log initialization details and validate scale factor
        DisplayMetrics.LogInitialization();
        DisplayMetrics.ValidateScaleFactor();
    }

    public override void OnLateUpdate()
    {
        base.OnLateUpdate();
        Patches.UpdateMethod();
    }
}