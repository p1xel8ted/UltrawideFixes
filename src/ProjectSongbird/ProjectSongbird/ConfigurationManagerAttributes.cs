namespace ProjectSongbird;

/// <summary>
/// Specifies how a setting should be displayed inside the BepInEx ConfigurationManager window.
/// Copy this class template into the plugin project and pass instances as config description tags.
/// Only fields that are assigned (non-null) will override default behavior.
/// </summary>
/// <remarks>
/// See https://github.com/BepInEx/BepInEx.ConfigurationManager for full documentation.
/// </remarks>
#pragma warning disable 0169, 0414, 0649
internal sealed class ConfigurationManagerAttributes
{
    /// <summary>Order of the setting on the list relative to others in the same category. Higher = higher on list.</summary>
    public int? Order;

    /// <summary>Display name override for the setting.</summary>
    public string DispName;

    /// <summary>If true, don't show the setting by default (user must enable advanced settings).</summary>
    public bool? IsAdvanced;

    /// <summary>Show this setting in the settings screen at all? If false, don't show.</summary>
    public bool? Browsable;
}
