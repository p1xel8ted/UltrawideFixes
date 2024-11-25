namespace RuinedKingLoL.Misc;

public static class PlatformHelper
{
    public enum Platform
    {
        Switch,
        Xbox,
        PlayStation
    }

    private static Platform CurrentPlatform => Plugin.ConfigPlatform.Value;

    public static Sprite GetPlatformSprite(string xboxSpriteName)
    {
        // Get the current platform from the config
        var platform = CurrentPlatform;

        // Determine the map based on the platform
        var platformMap = platform switch
        {
            Platform.PlayStation => XboxToPlayStationMap,
            Platform.Switch => XboxToSwitchMap,
            _ => null // Default case for unsupported platforms
        };

        // Ensure the platform has a valid mapping
        if (platformMap == null)
        {
            Debug.LogWarning($"Unsupported platform: {platform}. Defaulting to Xbox sprites.");
            return null; // Return null for unsupported platforms
        }

        // Check if the Xbox sprite has a mapped replacement
        if (platformMap.TryGetValue(xboxSpriteName, out var platformSpriteName))
        {
            // Return the mapped platform sprite
            return GetOrLoadSprite(platformSpriteName);
        }

        return null;
    }


    // Cache for loaded sprites
    private static readonly Dictionary<string, Sprite> CachedSprites = new();

    private static readonly Dictionary<string, string> XboxToPlayStationMap = new()
    {
        { "UI_Input_XboxNeo_A", "PS_Cross" }, // Xbox A -> PS Cross
        { "UI_Input_XboxNeo_B", "PS_Circle" }, // Xbox B -> PS Circle
        { "UI_Input_XboxNeo_X", "PS_Square" }, // Xbox X -> PS Square
        { "UI_Input_XboxNeo_Y", "PS_Triangle" }, // Xbox Y -> PS Triangle
        { "UI_Input_XboxNeo_LB", "PS_L1" }, // Left Bumper -> L1
        { "UI_Input_XboxNeo_RB", "PS_R1" }, // Right Bumper -> R1
        { "UI_Input_XboxNeo_LT", "PS_L2" }, // Left Trigger -> L2
        { "UI_Input_XboxNeo_RT", "PS_R2" }, // Right Trigger -> R2
        { "UI_Input_XboxNeo_Menu", "PS_Options" }, // Menu -> Options
        { "UI_Input_XboxNeo_View", "PS_Share" }, // View -> Share
        { "UI_Input_XboxNeo_XboxButton", "PS_PSButton" }, // Xbox Button -> PS Button
        { "UI_Input_XboxNeo_LAnalog", "PS_L3" }, // Left Analog Stick -> L3
        { "UI_Input_XboxNeo_RAnalog", "PS_R3" }, // Right Analog Stick -> R3
    };
    
    private static readonly Dictionary<string, string> XboxToSwitchMap = new()
    {
        // Face Buttons
        { "UI_Input_XboxNeo_A", "NS_B" },       // Xbox A -> Switch B
        { "UI_Input_XboxNeo_B", "NS_A" },       // Xbox B -> Switch A
        { "UI_Input_XboxNeo_X", "NS_Y" },       // Xbox X -> Switch Y
        { "UI_Input_XboxNeo_Y", "NS_X" },       // Xbox Y -> Switch X

        // // D-Pad
        // { "UI_Input_XboxNeo_DpadUp", "NS_DpadUp" },     // D-Pad Up -> D-Pad Up
        // { "UI_Input_XboxNeo_DpadDown", "NS_DpadDown" }, // D-Pad Down -> D-Pad Down
        // { "UI_Input_XboxNeo_DpadLeft", "NS_DpadLeft" }, // D-Pad Left -> D-Pad Left
        // { "UI_Input_XboxNeo_DpadRight", "NS_DpadRight" }, // D-Pad Right -> D-Pad Right

        // Bumpers and Triggers
        { "UI_Input_XboxNeo_LB", "NS_L" },     // Left Bumper -> Switch L
        { "UI_Input_XboxNeo_RB", "NS_R" },     // Right Bumper -> Switch R
        { "UI_Input_XboxNeo_LT", "NS_ZL" },    // Left Trigger -> Switch ZL
        { "UI_Input_XboxNeo_RT", "NS_ZR" },    // Right Trigger -> Switch ZR

        // // Sticks
        // { "UI_Input_XboxNeo_LAnalog", "NS_LStick" },   // Left Stick -> Switch Left Stick
        // { "UI_Input_XboxNeo_RAnalog", "NS_RStick" },   // Right Stick -> Switch Right Stick

        // System Buttons
        { "UI_Input_XboxNeo_Menu", "NS_Plus" },      // Menu -> Plus
        { "UI_Input_XboxNeo_View", "NS_Minus" },     // View -> Minus
        { "UI_Input_XboxNeo_XboxButton", "NS_Home" } // Xbox Button -> Home
    };

    private static Sprite GetOrLoadSprite(string spriteName)
    {
        // Check if the sprite is already cached
        if (CachedSprites.TryGetValue(spriteName, out var cachedSprite))
        {
            return cachedSprite;
        }

        // Construct the embedded resource path
        var resourcePath = $"RuinedKingLoL.Buttons.{spriteName}.png";

        // Get the assembly containing the resources
        var assembly = typeof(PlatformHelper).Assembly;

        // Load the embedded resource stream
        using var resourceStream = assembly.GetManifestResourceStream(resourcePath);
        if (resourceStream == null)
        {
            Plugin.Logger.LogError($"Embedded resource not found: {resourcePath}");
            return null;
        }

        // Load the image into a Texture2D
        var imageData = new byte[resourceStream.Length];
        _ = resourceStream.Read(imageData, 0, imageData.Length);
        var texture = new Texture2D(2, 2); // Temporary size, resized during LoadImage

        if (ImageConversion.LoadImage(texture, imageData))
        {
            // Enforce a 48x48 rect and pivot
            var fixedRect = new Rect(0, 0, 48, 48);
            var pivot = new Vector2(0.5f, 0.5f); // Centered pivot
            const float pixelsPerUnit = 48; // Fixed size scaling

            // Create a new sprite from the texture
            var sprite = Sprite.Create(
                texture,
                fixedRect, // Use fixed 48x48 rect
                pivot, // Centered pivot
                pixelsPerUnit, // Match fixed size scaling
                0, // No extra padding
                SpriteMeshType.FullRect // Use the full rectangle for the sprite
            );

            // Set the sprite name
            sprite.name = spriteName;
            
            // Cache the sprite for future use
            CachedSprites[spriteName] = sprite;
            return sprite;
        }

        Plugin.Logger.LogError($"Failed to load image data for sprite: {spriteName}");

        return null;
    }
}