[assembly: MelonInfo(typeof(VampireSurvivors.Plugin), "Vampire Survivors Ultra-Wide (Melon)", "0.2.1", "p1xel8ted")]

namespace VampireSurvivors;

public class Plugin : MelonMod
{
    private const float NativeAspectRatio = 1.6f;
    internal static readonly int MainWidth = Display.main.systemWidth;
    internal static readonly int MainHeight = Display.main.systemHeight; //1440
    internal static readonly float MainAspect = MainWidth / (float)MainHeight; //2.388888888888889
    internal static readonly float PositiveScaleFactor = MainAspect / NativeAspectRatio; //1.493827160493827
    public static MelonPreferences_Entry<bool> ExpandSpawnZone { get; private set; }
    private static MelonPreferences_Category ConfigCategory { get; set; }
    
    public override void OnInitializeMelon()
    {
        base.OnInitializeMelon();

        ConfigCategory = MelonPreferences.CreateCategory("UW", "Ultra-Wide Settings");
        ExpandSpawnZone = ConfigCategory.CreateEntry("ExpandSpawnZone", true, "Expands the spawn zone to fit the new resolution.");
        ExpandSpawnZone.OnEntryValueChanged.Subscribe(UpdateStageRects);
        
        if (ExpandSpawnZone == null)
        {
            MelonLogger.Error("Failed to initialize ExpandSpawnZone setting.");
            return;
        }

        ConfigCategory.SaveToFile(false);

        MelonLogger.Msg("Vampire Survivors Ultra-Wide (Melon) has been initialized.");
    }
 
    private static void UpdateStageRects(bool b, bool b1)
    {
        var stage = Resources.FindObjectsOfTypeAll<Stage>().FirstOrDefault();
        if (stage)
        {
            MelonLogger.Msg($"Updating stage {stage.name} spawn zone.");
            stage.InitRects();
        }
    }
}