namespace ScarletMaiden.UI.Utils;

/// <summary>
/// Utility methods for loading sprites from embedded resources and managing background image containers.
/// </summary>
public static class SpriteUtils
{
    /// <summary>
    /// Loads a sprite from embedded resources and creates a new sprite with the same properties as the existing one.
    /// </summary>
    /// <param name="imageName">The name of the embedded image resource.</param>
    /// <param name="existingSprite">The existing sprite to copy properties from.</param>
    /// <returns>The newly created sprite or null if loading failed.</returns>
    public static Sprite LoadSpriteFromResources(string imageName, Sprite existingSprite)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = $"ScarletMaiden.Images.{imageName}";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            Plugin.Log.LogError($"Failed to load embedded resource: {resourceName}");
            return null;
        }

        var buffer = new byte[stream.Length];
        _ = stream.Read(buffer, 0, buffer.Length);

        var texture = new Texture2D(2, 2);
        texture.LoadImage(buffer);
        texture.filterMode = FilterMode.Point;

        var pivot = existingSprite ? existingSprite.pivot / new Vector2(existingSprite.texture.width, existingSprite.texture.height) : Vector2.one * 0.5f;
        var pixelsPerUnit = existingSprite ? existingSprite.pixelsPerUnit : 100f;
        var border = existingSprite ? existingSprite.border : Vector4.zero;

        var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), pivot, pixelsPerUnit, 0, SpriteMeshType.FullRect, border);

        return sprite;
    }

    /// <summary>
    /// Creates an ultrawide container for background images to handle aspect ratio scaling.
    /// </summary>
    /// <param name="parent">The parent transform containing the image.</param>
    /// <param name="imageName">The name of the image GameObject to move.</param>
    /// <param name="imageAspectRatio">Optional aspect ratio to apply to the container.</param>
    public static void MoveImageToUltraWideContainer(Transform parent, string imageName, float? imageAspectRatio = null)
    {
        var existingImage = parent.name == imageName ? parent.GetComponent<Image>() : parent.Find(imageName)?.GetComponent<Image>();
        if (!existingImage)
            return;

        var existingContainer = existingImage.transform.Find("BackgroundImageContainer");
        if (existingContainer)
            return;

        var newImageParent = new GameObject("BackgroundImageContainer");
        var newImage = newImageParent.AddComponent<Image>();

        if (imageAspectRatio.HasValue)
        {
            var arf = newImageParent.AddComponent<AspectRatioFitter>();
            arf.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            arf.aspectRatio = imageAspectRatio.Value;
            arf.enabled = true;
        }

        newImageParent.transform.SetParent(existingImage.transform, false);

        newImage.rectTransform.anchorMin = Vector2.zero;
        newImage.rectTransform.anchorMax = Vector2.one;
        newImage.rectTransform.offsetMin = Vector2.zero;
        newImage.rectTransform.offsetMax = Vector2.zero;

        newImage.sprite = existingImage.sprite;
        newImage.color = existingImage.color;
        newImage.raycastTarget = existingImage.raycastTarget;
        newImage.preserveAspect = false;
        newImage.type = Image.Type.Simple;

        newImageParent.transform.SetAsFirstSibling();
        newImageParent.transform.localPosition = Vector3.zero;
        existingImage.enabled = false;
    }
}
