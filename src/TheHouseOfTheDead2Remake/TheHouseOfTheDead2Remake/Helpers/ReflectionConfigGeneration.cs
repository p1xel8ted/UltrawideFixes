namespace TheHouseOfTheDead2Remake.Helpers;

public static class ReflectionConfigGeneration
{
    /// <summary>
    /// Tracks created configuration entries to prevent duplicates.
    /// </summary>
    private static readonly HashSet<string> CreatedEntries = []; 

    /// <summary>
    /// Section name for internal game settings.
    /// </summary>
    private const string InternalGameSettings = "06. Modify At Own Risk - May or may not work, Descriptions are a best guess.";

    /// <summary>
    /// Generates configuration entries for all static fields in the HD_Data class using reflection.
    /// Supports various data types and binds them to the configuration file.
    /// </summary>
    public static void GenerateHdDataConfig()
    {
        var fields = AccessTools.GetDeclaredFields(typeof(CR_Data));

        foreach (var field in fields)
        {
            try
            {
                var type = field.FieldType;
                var value = field.GetValue(null); // Retrieve value of static field

                // Skip constant fields and already-created entries
                if (field.IsLiteral && !field.IsInitOnly) continue;
                if (CreatedEntries.Contains(field.Name)) continue;

                // Helper method to bind a field to a configuration entry and handle setting changes
                void BindAndWatch<T>(string section, string key, T defaultValue, ConfigDescription description)
                {
                    var configEntry = Plugin.ConfigFile.Bind(section, key, defaultValue, description);
                   // Plugin.Log.LogWarning($"Binding '{field.Name}' of type '{type}' with default value '{defaultValue}'");
                    configEntry.SettingChanged += (_, _) =>
                    {
                        try
                        {
                            field.SetValue(null, configEntry.Value); // Update field value on setting change
                            Plugin.Log.LogInfo($"{field.Name} updated to {configEntry.Value}");
                        }
                        catch (Exception e)
                        {
                            Plugin.Log.LogError($"Failed to update field {field.Name} on setting change: {e}");
                        }
                    };
                    CreatedEntries.Add(field.Name); // Mark entry as created
                }

                // Handle supported data types
                if (type == typeof(float))
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        value == null ? 0f : (float)value,
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            null,
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
                else if (type == typeof(bool))
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        value != null && (bool)value,
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            null,
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
                else if (type == typeof(string))
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        value == null ? string.Empty : (string)value,
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            null,
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
                else if (type == typeof(Color))
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        value == null ? Color.white : (Color)value,
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            null,
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
                else if (type == typeof(int))
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        value == null ? 0 : (int)value,
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            null,
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
                else if (type.IsEnum)
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        value == null ? Enum.GetValues(type).GetValue(0).ToString() : value.ToString(),
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            new AcceptableValueList<string>(Enum.GetNames(type)),
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
                else if (type == typeof(WaitForSeconds))
                {
                    BindAndWatch(
                        InternalGameSettings,
                        field.Name,
                        ((WaitForSeconds)value)?.m_Seconds ?? 0f,
                        new ConfigDescription(Descriptions.GetDescription(field.Name),
                            null,
                            new ConfigurationManagerAttributes { Order = Volumes._startOrder-- }
                        )
                    );
                }
            }
            catch (Exception e)
            {
                Plugin.Log.LogError($"Failed to bind {field.Name} to config file: {e}");
            }
        }
    }
}