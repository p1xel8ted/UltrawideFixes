using Il2CppInterop.Runtime.Injection;
using Patches = Shared.Patches;
using DisplayMetrics = Shared.DisplayMetrics;

namespace VampireSurvivors;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BasePlugin
{
    private const string PluginGuid = "p1xel8ted.vampiresurvivors.ultrawide";
    private const string PluginName = "Vampire Survivors Ultra-Wide (BepInEx)";
    private const string PluginVersion = "0.2.2";

    internal static ManualLogSource Logger { get; private set; }
    public static ConfigEntry<bool> ExpandSpawnZone { get; private set; }
    internal static ConfigEntry<KeyCode> ExpandSpawnZoneToggle { get; private set; }

    public override void Load()
    {
        Logger = Log;
        ClassInjector.RegisterTypeInIl2Cpp<UnityEvents>();
        AddComponent<UnityEvents>();

        ExpandSpawnZone = Config.Bind("01. Gameplay", "Expand Spawn Zone", true, new ConfigDescription("Expands the spawn zone to fit the new resolution.", null, new ConfigurationManagerAttributes { Order = 92 }));
        ExpandSpawnZone.SettingChanged += Patches.UpdateMethod;

        ExpandSpawnZoneToggle = Config.Bind("01. Gameplay", "Expand Spawn Zone Toggle Key", KeyCode.F9, new ConfigDescription("Key to toggle expanding the spawn zone.", null, new ConfigurationManagerAttributes { Order = 93 }));

        // Log initialization details and validate scale factor
        DisplayMetrics.LogInitialization();
        DisplayMetrics.ValidateScaleFactor();

        Logger.LogInfo($"Plugin {PluginName} is loaded!");
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    public class UnityEvents : MonoBehaviour
    {
        private void LateUpdate()
        {
            Patches.UpdateMethod(this, EventArgs.Empty);
        }
    }
}