namespace TheHouseOfTheDeadRemake.Helpers;

public static class FoV
{
    /// <summary>
    /// Calculates a new Field of View (FoV) value based on the plugin's configured percentage adjustment.
    /// </summary>
    /// <returns>The adjusted FoV value.</returns>
    private static float NewFoV()
    {
        // Plugin.FieldOfView.Value ranges from -50f to 50f.
        var pct = Plugin.FieldOfView.Value / 100; // Converts percentage to a multiplier (e.g., 50f -> 0.5).
        var baseFov = GetBaseFieldOfView(); // Retrieves the base FoV value, e.g., 35.
        var fov = baseFov + pct * baseFov; // Adjusts the base FoV by the percentage.
        return fov;
    }

    /// <summary>
    /// Updates the field of view data across relevant systems.
    /// </summary>
    /// <param name="value">The new FoV value to apply.</param>
    public static void UpdateFieldOfViewData(float value)
    {
        if (!OriginalFieldOfViewPerLevel.HasValue) return;

        HD_Data.CAMERA_FOV_PER_LEVEL = OriginalFieldOfViewPerLevel.Value.Select(_ => value).ToArray();
        HD_PlayerCamera.AVERAGE_FOV = HD_PlayerCamera.calcAverageFOV();
        HD_PlayerCamera.instance.startingFOV = value;
    }

    /// <summary>
    /// Retrieves the base Field of View (FoV) for the current gameplay level or defaults to 35.
    /// </summary>
    /// <returns>The base FoV value.</returns>
    private static float GetBaseFieldOfView()
    {
        if (MP_LevelLoader.Instance && OriginalFieldOfViewPerLevel.HasValue)
        {
            if (!MP_LevelLoader.Instance.IsGameplayLevelLoaded(out var fov))
            {
                fov = 0; // Default level if no gameplay level is loaded.
            }

            var baseFov = OriginalFieldOfViewPerLevel.Value[fov];
            return baseFov;
        }

        // Default base FoV value for all levels as of writing.
        return 35f;
    }

    /// <summary>
    /// Stores the original FoV values for each level, ensuring they can only be written once.
    /// </summary>
    public static readonly WriteOnce<float[]> OriginalFieldOfViewPerLevel = new();

    private static Coroutine _changeFov;

    /// <summary>
    /// Updates the Field of View (FoV) smoothly with animation.
    /// </summary>
    internal static void UpdateFieldOfView()
    {
        if (!HD_PlayerCamera.instance) return;
        
        var newFov = NewFoV();

        // Stops any existing FoV change coroutine to avoid overlapping animations.
        if (_changeFov != null)
        {
            HD_PlayerCamera.instance.StopCoroutine(_changeFov);
        }

        // Applies the new FoV value to the relevant systems.
        UpdateFieldOfViewData(newFov);

        // Starts a smooth FoV change coroutine with a duration of 0.25 seconds.

        _changeFov = HD_PlayerCamera.instance.StartCoroutine(
            HD_PlayerCamera.instance.smoothFovChange(newFov, 0.25f, 0f)
        );
    }
}