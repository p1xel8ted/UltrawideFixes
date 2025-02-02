namespace Nunholy.Helpers;

public static class Volumes
{
    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    internal static int StartOrder = 80;

    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    internal static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();
    
    
    /// <summary>
    /// Updates all volume components to reflect the current state of their associated configuration entries.
    /// </summary>
    public static void UpdateVolumes()
    {
        var volumes = Resources.FindObjectsOfTypeAll<Volume>();
        foreach (var vol in volumes)
        {
            foreach (var volComp in vol.profile.components)
            {
                var name = volComp.name.Replace("(Clone)", "");
                if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
                {
                    volComp.active = configEntryGlobal.Value;
                }
            }
        }
    }
}