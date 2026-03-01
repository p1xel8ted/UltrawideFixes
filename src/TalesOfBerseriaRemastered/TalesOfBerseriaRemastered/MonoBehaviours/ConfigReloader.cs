namespace TalesOfBerseriaRemastered.MonoBehaviours;

/// <summary>
/// IL2CPP-injected MonoBehaviour that listens for the config reload keybind (default: F5).
/// When pressed, re-reads the BepInEx config file from disk and immediately applies
/// the updated settings (framerate, VSync, physics rate).
///
/// Registered via ClassInjector.RegisterTypeInIl2Cpp in Plugin.Load() and attached to a
/// persistent GameObject with HideAndDontSave + DontDestroyOnLoad so it survives the
/// game's entire lifetime.
/// </summary>
public class ConfigReloader : MonoBehaviour
{
    private void Update()
    {
        if (!Input.GetKeyDown(Plugin.ReloadConfigKey.Value)) return;

        Plugin.Config.Reload();
        Plugin.ApplySettings();
        Plugin.Logger.LogInfo("Config reloaded via keybind");
    }
}
