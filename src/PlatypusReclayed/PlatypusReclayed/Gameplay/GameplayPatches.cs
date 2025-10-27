namespace PlatypusReclayed.Gameplay;

/// <summary>
/// Harmony patches for core gameplay systems including player, entities, and game boundaries.
/// Adjusts playable area and game mechanics for ultrawide displays when enabled.
/// </summary>
[Harmony]
[SuppressMessage("ReSharper", "InconsistentNaming")]
public static class GameplayPatches
{
    /// <summary>
    /// Postfix patch that adjusts player vertical offset based on position in ultrawide mode.
    /// Scales the horizontal offset multiplier to prevent clipping at screen edges.
    /// </summary>
    /// <param name="__instance">The OffsetWithPlayerPos instance applying the offset.</param>
    /// <param name="verticalOffset">The vertical offset to apply.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(OffsetWithPlayerPos), nameof(OffsetWithPlayerPos.ApplyOffset))]
    public static void OffsetWithPlayerPos_ApplyOffset(OffsetWithPlayerPos __instance, float verticalOffset)
    {
        if (GameConfig.ExpandPlayableArea == null || !GameConfig.ExpandPlayableArea.Value) return;
        if (!__instance.enabled) return;

        var num = __instance.m_offsetMultiplier * verticalOffset;
        __instance.transform.position = new Vector3(
            __instance.m_initialPosition.x + (num + GameConstants.PlayerWeaponOffsetAdjustment) * ResolutionManager.PositiveScaleFactor,
            __instance.m_initialPosition.y + num,
            __instance.m_initialPosition.z
        );
    }

    /// <summary>
    /// Postfix patch that expands game boundaries to match ultrawide viewport.
    /// Allows entities to move across the full width of ultrawide displays.
    /// </summary>
    /// <param name="__instance">The EntityManager instance managing game bounds.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(EntityManager), nameof(EntityManager.UpdateGameBounds))]
    public static void EntityManager_UpdateGameBounds(EntityManager __instance)
    {
        if (GameConfig.ExpandPlayableArea == null || !GameConfig.ExpandPlayableArea.Value) return;

        GameUtils.GetCameraBorderWorldSpace(out var left, out var right, out _, out _);
        left *= ResolutionManager.PositiveScaleFactor;
        right *= ResolutionManager.PositiveScaleFactor;
        __instance.LeftBorder = left;
        __instance.RightBorder = right;
    }

    /// <summary>
    /// Postfix patch that adjusts horizontal position calculations for widescreen displays.
    /// Expands X coordinates proportionally based on distance from screen center.
    /// </summary>
    /// <param name="x">The original X coordinate.</param>
    /// <param name="__result">The adjusted X coordinate for ultrawide displays.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GameUtils), nameof(GameUtils.AdjustXToWideScreen))]
    public static void GameUtils_AdjustXToWideScreen(float x, ref float __result)
    {
        if (GameConfig.ExpandPlayableArea == null || !GameConfig.ExpandPlayableArea.Value) return;

        // Expand X position based on distance from screen center
        __result = x + (x - GameConstants.NativeScreenCenterX) * (ResolutionManager.PositiveScaleFactor - 1f);
    }

    /// <summary>
    /// Postfix patch that scales player weapon offset for ultrawide displays.
    /// Ensures weapon positioning matches the expanded horizontal space.
    /// </summary>
    /// <param name="__instance">The Player instance being initialized.</param>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Player), nameof(Player.Initialise))]
    public static void Player_Initialise(Player __instance)
    {
        if (GameConfig.ExpandPlayableArea == null || !GameConfig.ExpandPlayableArea.Value) return;

        __instance.weaponOffset = new Vector2(
            __instance.weaponOffset.x * ResolutionManager.PositiveScaleFactor,
            __instance.weaponOffset.y);
    }

    /// <summary>
    /// Prefix patch that adjusts original position coordinates for widescreen displays.
    /// Calculates horizontal offset based on whether the position is on the left or right side of the screen.
    /// </summary>
    /// <param name="originalPos">The original 2D position.</param>
    /// <param name="__result">The adjusted position for ultrawide displays.</param>
    /// <returns>False to skip original method when expand playable area is enabled.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(GameUtils), nameof(GameUtils.AdjustOriginalPosToWideScreen))]
    public static bool GameUtils_AdjustOriginalPosToWideScreen(Vector2 originalPos, ref Vector2 __result)
    {
        if (GameConfig.ExpandPlayableArea == null || !GameConfig.ExpandPlayableArea.Value) return true;

        var scaleFactor = ResolutionManager.PositiveScaleFactor;

        // Calculate offset based on which side of screen the position is on
        float xOffset;
        if (originalPos.x < GameConstants.NativeScreenCenterX)
        {
            // Left side - offset left
            xOffset = -(scaleFactor - 1f) * GameConstants.NativeScreenWidth;
        }
        else
        {
            // Right side - offset right
            xOffset = (scaleFactor - 1f) * GameConstants.NativeScreenWidth;
        }

        __result = originalPos + Vector2.right * xOffset;

        return false;
    }
}
