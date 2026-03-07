using System.Diagnostics.CodeAnalysis;
using static VampireSurvivors.DisplayMetrics;
using static VampireSurvivors.PatchConstants;
using static VampireSurvivors.Logger;

namespace VampireSurvivors;


[SuppressMessage("ReSharper", "InconsistentNaming")]
[Harmony]
public static class Patches
{
    private static readonly Dictionary<int, StageRectsBackup> StageBackups = new();

    /// <summary>
    /// Immutable backup of stage rectangles for restoration when spawn zone expansion is toggled off.
    /// </summary>
    private class StageRectsBackup
    {
        public Rect ContainmentExactRect { get; init; }
        public Rect ContainmentScreenRect { get; init; }
        public Rect SpawnInnerRect { get; init; }
        public Rect SpawnOuterRect { get; init; }
        public Rect TiledInnerRect { get; init; }
        public Rect TiledOuterRect { get; init; }
        public float WidthRect { get; init; }
        // Backed up for restoration but not scaled during expansion
        // because ultrawide only affects horizontal (width) scaling
        public float HeightRect { get; init; }
    }

    /// <summary>Timestamp of last toggle attempt for debounce logic.</summary>
    private static float _lastToggleTime = -999f;

    /// <summary>
    /// Called every frame from LateUpdate to check for spawn zone toggle key press.
    /// Only handles input polling — the actual rect updates are triggered by the
    /// SettingChanged event handler in Plugin.cs.
    /// </summary>
    internal static void CheckToggleKey()
    {
        if (!Input.GetKeyDown(Plugin.ExpandSpawnZoneToggle.Value)) return;

        var currentTime = Time.time;
        if (currentTime - _lastToggleTime >= ToggleDebounceTime)
        {
            _lastToggleTime = currentTime;
            Plugin.ExpandSpawnZone.Value = !Plugin.ExpandSpawnZone.Value;
        }
        else
        {
            Info($"Toggle ignored - please wait {ToggleDebounceTime:F1} seconds between toggles.");
        }
    }

    /// <summary>
    /// Forces all active stages to re-apply or restore spawn zone modifications.
    /// </summary>
    internal static void UpdateStageRects()
    {
        var currentStages = Resources.FindObjectsOfTypeAll<Stage>();

        foreach (var stage in currentStages)
        {
            ModifyStage(stage);
        }
    }

    /// <summary>
    /// Creates a backup of the stage's original rectangles before modification.
    /// </summary>
    /// <param name="stage">The stage to backup.</param>
    private static void BackupStageRects(Stage stage)
    {
        StageBackups[stage.GetInstanceID()] = new StageRectsBackup
        {
            ContainmentExactRect = stage._containmentExactRect,
            ContainmentScreenRect = stage._containmentScreenRect,
            SpawnInnerRect = stage._spawnInnerRect,
            SpawnOuterRect = stage._spawnOuterRect,
            TiledInnerRect = stage._tiledInnerRect,
            TiledOuterRect = stage._tiledOuterRect,
            WidthRect = stage._widthRect,
            HeightRect = stage._heightRect
        };

        Info($"Backed up rects for stage: {stage.name}");
    }

    /// <summary>
    /// Restores a stage's rectangles to their original backed-up values.
    /// </summary>
    /// <param name="stage">The stage to restore.</param>
    private static void RestoreStageRects(Stage stage)
    {
        if (!StageBackups.TryGetValue(stage.GetInstanceID(), out var backup))
        {
            Warning($"No backup found for stage: {stage.name}");
            return;
        }

        stage._containmentExactRect = backup.ContainmentExactRect;
        stage._containmentScreenRect = backup.ContainmentScreenRect;
        stage._spawnInnerRect = backup.SpawnInnerRect;
        stage._spawnOuterRect = backup.SpawnOuterRect;
        stage._tiledInnerRect = backup.TiledInnerRect;
        stage._tiledOuterRect = backup.TiledOuterRect;
        stage._widthRect = backup.WidthRect;
        stage._heightRect = backup.HeightRect;

        Info($"Restored rects for stage: {stage.name}");
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(Stage), nameof(Stage.InitRects))]
    public static void Stage_InitRects(Stage __instance)
    {
        ModifyStage(__instance);
    }

    /// <summary>
    /// Applies or restores ultra-wide adjustments to a stage based on user preferences.
    /// </summary>
    /// <param name="stage">The stage to modify.</param>
    internal static void ModifyStage(Stage stage)
    {
        var id = stage.GetInstanceID();

        if (!StageBackups.ContainsKey(id))
        {
            BackupStageRects(stage);
        }

        if (Plugin.ExpandSpawnZone.Value)
        {
            var backup = StageBackups[id];
            stage._spawnInnerRect = AdjustRect(backup.SpawnInnerRect);
            stage._spawnOuterRect = AdjustRect(backup.SpawnOuterRect);
            stage._containmentExactRect = AdjustRect(backup.ContainmentExactRect);
            stage._containmentScreenRect = AdjustRect(backup.ContainmentScreenRect);
            stage._tiledInnerRect = AdjustRect(backup.TiledInnerRect);
            stage._tiledOuterRect = AdjustRect(backup.TiledOuterRect);
            stage._widthRect = backup.WidthRect * PositiveScaleFactor;
        }
        else
        {
            RestoreStageRects(stage);
        }
    }

    /// <summary>
    /// Adjusts a rectangle's width for ultra-wide displays while maintaining its center position.
    /// Adds padding to prevent edge artifacts.
    /// </summary>
    /// <param name="rect">The rectangle to adjust.</param>
    /// <returns>The adjusted rectangle.</returns>
    private static Rect AdjustRect(Rect rect)
    {
        var originalCenter = rect.center;
        rect.width *= PositiveScaleFactor;
        rect.center = originalCenter;

        var padding = rect.width * PaddingMultiplier / 2f;
        rect.xMin -= padding;
        rect.xMax += padding;

        return rect;
    }

    /// <summary>
    /// Scales background elements to properly fill ultra-wide displays without stretching.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Stage), nameof(Stage.SetupFancyBackground))]
    public static void Stage_SetupFancyBackground(Stage __instance)
    {
        var mainCamera = Camera.main;
        if (!mainCamera) return;

        var cameraTransform = mainCamera.transform;

        foreach (var obj in cameraTransform)
        {
            var child = obj.TryCast<Transform>();
            if (child && child.name.Contains("Background", StringComparison.OrdinalIgnoreCase))
            {
                child.localScale = new Vector3(PositiveScaleFactor, PositiveScaleFactor, 1f);
            }
        }
    }

    /// <summary>
    /// Forces UI canvases to use Expand mode for proper ultra-wide scaling.
    /// Excludes debug/inspector UIs (e.g., UnityExplorer's "sinai" UI).
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(CanvasScaler), nameof(CanvasScaler.OnEnable))]
    public static void CanvasScaler_OnEnable(CanvasScaler __instance)
    {
        if (__instance.name.Contains("sinai", StringComparison.OrdinalIgnoreCase)) return;

        if (__instance.uiScaleMode == CanvasScaler.ScaleMode.ScaleWithScreenSize)
        {
            __instance.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        }
    }

    /// <summary>
    /// Scales specific UI elements horizontally to prevent stretching on ultra-wide displays.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(UIView), nameof(UIView.OnEnable))]
    public static void UIView_OnEnable(UIView __instance)
    {
        var transform = __instance.transform;
        if (!transform) return;

        foreach (var elementName in ScaleTheseUIElements)
        {
            var element = transform.Find(elementName);
            if (element)
            {
                element.localScale = new Vector3(PositiveScaleFactor, 1f, 1f);
            }
        }
    }

    /// <summary>
    /// Adjusts viewport settings to use actual screen resolution instead of game's default.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ViewportCrop), nameof(ViewportCrop.Awake))]
    public static void ViewportCrop_Awake(ViewportCrop __instance)
    {
        __instance._referenceResolution = new Vector2(MainWidth, MainHeight);
        __instance._referenceAspectRatio = MainAspect;
    }

    /// <summary>
    /// Disables aspect ratio masks that would letterbox the game on ultra-wide displays.
    /// </summary>
    [HarmonyPostfix]
    [HarmonyPatch(typeof(AspectMask), nameof(AspectMask.Start))]
    public static void AspectMask_Start(AspectMask __instance)
    {
        __instance.gameObject.SetActive(false);
    }
}
