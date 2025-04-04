namespace Haste;

public static class Volumes
{
    /// <summary>
    /// The starting order for configuration entries in the settings window so that post-processing effects are listed last.
    /// </summary>
    private static int _startOrder = 80;

    /// <summary>
    /// A dictionary storing configuration entries for enabling or disabling individual post-processing effects.
    /// </summary>
    private static readonly Dictionary<string, ConfigEntry<bool>> ConfigEntriesGlobal = new();

    private static readonly string[] AllowedScenesFullName = ["FullHub", "RunScene", "DemoHub", "ShopScene"];
    private static readonly string[] AllowedScenesPartialName = ["Hub", "TutorialScene", "Cutscene", "Challenge"];

    internal static void ProcessVolumeRegistration(PostProcessVolume volume)
    {
        if (!ValidateVolume(volume)) return;
        
        foreach (var vol in volume.profile.settings)
        {
            if (vol is TerrainHeightFadePPSSettings or EdgeDetection || vol.GetType().Namespace == "UnityEngine.Rendering.PostProcessing")
            {
                var name = vol.name.Replace("(Clone)", "");
                var configEntryGlobal = Plugin.ConfigFile.Bind("03. Post-Processing", name, vol.active, new ConfigDescription("Enable or disable this post-processing effect on a global level. The default value may not be accurate. Enabling it may not have an effect (in the current scene).", null, new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }));
                configEntryGlobal.SettingChanged += (_, _) =>
                {
                    UpdatePostProcessingSetting(vol, configEntryGlobal.Value);
                };
                if (ConfigEntriesGlobal.TryAdd(name, configEntryGlobal))
                {
                    if (!Plugin.Notifications.Value) return;

                    MessageDisplayer.Instance.ShowMessage($"Registered '{name}' configuration entry...", 5, MessageDisplayer.Corner.TopRight, 7, Color.white);
                }
            }
        }
    }

    internal static void UpdateVolume(PostProcessVolume volume)
    {
        if (!ValidateVolume(volume)) return;
        
        foreach (var setting in volume.profile.settings)
        {
            var name = setting.name.Replace("(Clone)", "");
            if (ConfigEntriesGlobal.TryGetValue(name, out var state))
            {
                UpdatePostProcessingSetting(setting, state.Value);
            }    
        }
     
    }

    private static void UpdatePostProcessingSetting(PostProcessEffectSettings setting, bool value)
    {
        var volumes = Resources.FindObjectsOfTypeAll<PostProcessVolume>().ToList();
        foreach (var volComp in volumes.Where(ValidateVolume).SelectMany(volume => volume.profile.settings.Where(volComp => volComp.GetType() == setting.GetType())))
        {
            volComp.active = value;
        }
    }

    internal static bool ValidateVolume(PostProcessVolume volume)
    {
        if (volume && volume.gameObject)
        {
            var sceneName = volume.gameObject.scene.name;

            if (string.IsNullOrEmpty(sceneName))
            {
                return false;
            }

            return AllowedScenesFullName.Any(scene => sceneName.Equals(scene, StringComparison.OrdinalIgnoreCase)) ||
                   AllowedScenesPartialName.Any(scene => sceneName.Contains(scene, StringComparison.OrdinalIgnoreCase));
        }

        return false;
    }


    // public static void UpdateVolumes(PostProcessEffectSettings ppes = null)
    // {
    //     var volumes = Resources.FindObjectsOfTypeAll<PostProcessVolume>().ToList();
    //     foreach (var vol in volumes)
    //     {
    //         if (ValidateVolume(vol))
    //         {
    //             foreach (var volComp in vol.profile.settings)
    //             {
    //                 if (ppes != null)
    //                 {
    //                     if (volComp.GetType() == ppes.GetType())
    //                     {
    //                         volComp.active = ppes.active;
    //                         Plugin.Log.LogInfo($"Setting '{volComp.name}' in scene '{vol.gameObject.scene.name}' to '{ppes.active}'");
    //                     }
    //                 }
    //                 if (volComp is TerrainHeightFadePPSSettings or EdgeDetection || vol.GetType().Namespace == "UnityEngine.Rendering.PostProcessing")
    //                 {
    //                     var name = volComp.name.Replace("(Clone)", "");
    //                     if (ConfigEntriesGlobal.TryGetValue(name, out var configEntryGlobal))
    //                     {
    //                         volComp.active = configEntryGlobal.Value;
    //                         Plugin.Log.LogInfo($"Setting '{name}' in scene '{vol.gameObject.scene.name}' to '{configEntryGlobal.Value}'");
    //                     }
    //                 }
    //             }
    //         }
    //     }
    // }
}