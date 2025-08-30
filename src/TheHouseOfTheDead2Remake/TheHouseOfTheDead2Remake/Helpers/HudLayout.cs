using TheHouseOfTheDead2Remake.MonoBehaviours;

namespace TheHouseOfTheDead2Remake.Helpers;

public static class HudLayout
{
    /// <summary>
    /// A list of all HUD layout controllers for managing and updating HUD elements.
    /// </summary>
    public static readonly List<LayoutController> HudControllers = [];

    /// <summary>
    /// A list of blood overlay layout controllers for updating overlays based on user preferences.
    /// </summary>
    public static readonly List<LayoutController> BloodOverlays = [];

    /// <summary>
    /// Updates the blood overlay layouts based on the user's preference for expanded or default sizing.
    /// </summary>
    internal static void UpdateBloodOverlays()
    {
        foreach (var lc in BloodOverlays.Where(lc => lc))
        {
            lc.ChangeSize(
                Plugin.ExpandBloodOverlay.Value 
                    ? LayoutController.LayoutSize.ForceFullScreen 
                    : LayoutController.LayoutSize.ForceSixteenNine, 
                0
            );
        }
    }

    /// <summary>
    /// Updates the aspect ratios of all HUD elements in the list of HUD controllers.
    /// </summary>
    internal static void UpdateHUD()
    {
        foreach (var lc in HudControllers.Where(lc => lc))
        {
            lc.UpdateAspect();
        }
    }
}