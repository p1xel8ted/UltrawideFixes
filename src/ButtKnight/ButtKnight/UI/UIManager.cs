namespace ButtKnight.UI;

internal static class UIManager
{
    private static HashSet<Image> ScanLineImages { get; set; } = [];
    private static HashSet<Image> BonkImages { get; set; } = [];
    private static HashSet<Image> VignetteImages { get; set; } = [];
    private static HashSet<Image> TouchBlockerImages { get; set; } = [];
    private static HashSet<SpriteRenderer> ForestSideSpriteRenderers { get; set; } = [];

    internal static void CacheSceneImages()
    {
        var allImages = Resources.FindObjectsOfTypeAll<Image>().ToList();
        ScanLineImages = new HashSet<Image>(allImages.Where(a => a.activeSprite && a.activeSprite.name == "ScreenFX_A"));
        Plugin.Log.LogInfo($"Found and cached {ScanLineImages.Count} scanline images.");

        VignetteImages = new HashSet<Image>(allImages.Where(a => a.activeSprite && a.activeSprite.name == "ScreenFX_B"));
        Plugin.Log.LogInfo($"Found and cached {VignetteImages.Count} vignette images.");

        BonkImages = new HashSet<Image>(allImages.Where(a => a.activeSprite && a.activeSprite.name == "UnitSquare"));
        Plugin.Log.LogInfo($"Found and cached {BonkImages.Count} bonk images.");
        
        TouchBlockerImages = new HashSet<Image>(allImages.Where(a => a.name == "TouchBlocker"));
        Plugin.Log.LogInfo($"Found and cached {TouchBlockerImages.Count} touch blocker images.");

        var allSprites = Resources.FindObjectsOfTypeAll<SpriteRenderer>().ToList();
        ForestSideSpriteRenderers = new HashSet<SpriteRenderer>(allSprites.Where(a => a.sprite && a.sprite.name == "StageBg_Forest02"));
        Plugin.Log.LogInfo($"Found and cached {ForestSideSpriteRenderers.Count} forest side images.");
    }


    internal static void UpdateWorldMapBackgroundColor()
    {
        if (Patches.Patches.CreatedBackgroundFillers == null) return;

        foreach (var sr in Patches.Patches.CreatedBackgroundFillers.Where(sr => sr))
        {
            sr.color = ConfigManager.AlternateMapColor.Value;
        }
    }

    internal static void UpdateAllImagesScale()
    {
        foreach (var img in ScanLineImages.Where(img => img.transform))
        {
            Patches.Patches.CorrectTransformScale(img.transform);
        }

        foreach (var img in BonkImages.Where(img => img.transform))
        {
            Patches.Patches.CorrectTransformScale(img.transform);
        }

        foreach (var img in VignetteImages.Where(img => img.transform))
        {
            Patches.Patches.CorrectTransformScale(img.transform);
        }

        foreach (var img in TouchBlockerImages.Where(img => img.transform))
        {
            Patches.Patches.CorrectTransformScale(img.transform);
        }
    }

    internal static void ToggleVignetteImages()
    {
        foreach (var img in VignetteImages.Where(img => img.transform))
        {
            img.enabled = ConfigManager.Vignette.Value;
        }
    }

    internal static void ToggleScanLineImages()
    {
        foreach (var img in ScanLineImages.Where(img => img.transform))
        {
            img.enabled = ConfigManager.ScanLines.Value;
        }
    }

    internal static void ToggleForestSides()
    {
        foreach (var img in ForestSideSpriteRenderers.Where(img => img.transform))
        {
            img.enabled = ConfigManager.ForestSides.Value;
        }
    }

    internal static void HandleSceneSpecificUI(Scene scene)
    {
        Patches.Patches.UpdateScalers(Resolutions.CurrentAspect);

        var topBottomBars = GameObject.Find("BlackTopDown");
        if (topBottomBars)
        {
            topBottomBars.SetActive(false);
        }

        if (scene.name == "Intro")
        {
            var overlay = GameObject.Find("Background/Intro_Bg03");
            if (overlay)
            {
                Patches.Patches.CorrectTransformScale(overlay.transform);
            }

            var bg = GameObject.Find("Background/Intro_Bg01");
            if (bg)
            {
                Patches.Patches.CorrectTransformScale(bg.transform);
                bg.transform.position = Vector3.zero;
            }
        }
    }
}