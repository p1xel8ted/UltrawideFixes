namespace ProjectSongbird;

/// <summary>
/// Shared helper methods and extension methods for GameObjects, Components, Cameras, VideoPlayers, and Transforms.
/// Provides structured logging, gate fit enforcement, aspect ratio correction, letterbox suppression,
/// and UI scaling utilities used throughout the plugin.
/// </summary>
internal static class Utils
{
    /// <summary>Tracks letterbox GameObjects that have already been logged to prevent per-frame spam.</summary>
    private static readonly HashSet<int> LoggedLetterboxes = [];

    /// <summary>Tracks cameras that have already been logged to prevent per-frame spam.</summary>
    private static readonly HashSet<int> LoggedCameras = [];

    /// <summary>Tracks transforms that have already been scaled to prevent compounding on repeated calls.</summary>
    internal static readonly HashSet<int> ScaledTransforms = [];

    /// <summary>Scenes where letterbox disabling is skipped (game uses letterboxing intentionally).</summary>
    private static readonly string[] ExcludeLetterboxScenes = ["Conner's Apartment"];

    /// <summary>Scenes where video player aspect ratio enforcement is skipped.</summary>
    private static readonly string[] ExcludeVideoPlayerScenes = ["Conner's Apartment"];

    /// <summary>The name of the currently active Unity scene.</summary>
    internal static string CurrentScene => SceneManager.GetActiveScene().name;

    extension(Component component)
    {
        /// <summary>
        /// Logs an informational message with a consistent format:
        /// <c>[IL2CppTypeName, instanceName]: message -> Scene: name -> Path: hierarchy/path -> Caller: method.</c>
        /// </summary>
        /// <param name="message">The log message body.</param>
        /// <param name="pathSource">Optional GameObject to use for the hierarchy path instead of the component's own GameObject.</param>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Pass explicitly to preserve the original caller through utility chains.</param>
        internal void LogInfo(string message, GameObject pathSource = null, [CallerMemberName] string caller = "")
        {
            var path = (pathSource ? pathSource : component.gameObject).GetPath();
            Plugin.Logger.LogInfo($"[{component.GetIl2CppType().Name}, {component.name}]: {message} -> Scene: {CurrentScene} -> Path: {path} -> Caller: {caller}.");
        }

        /// <summary>
        /// Logs a warning message with a consistent format:
        /// <c>[IL2CppTypeName, instanceName]: message -> Scene: name -> Path: hierarchy/path -> Caller: method.</c>
        /// </summary>
        /// <param name="message">The log message body.</param>
        /// <param name="pathSource">Optional GameObject to use for the hierarchy path instead of the component's own GameObject.</param>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Pass explicitly to preserve the original caller through utility chains.</param>
        internal void LogWarning(string message, GameObject pathSource = null, [CallerMemberName] string caller = "")
        {
            var path = (pathSource ? pathSource : component.gameObject).GetPath();
            Plugin.Logger.LogWarning($"[{component.GetIl2CppType().Name}, {component.name}]: {message} -> Scene: {CurrentScene} -> Path: {path} -> Caller: {caller}.");
        }
    }

    extension(VideoPlayer videoPlayer)
    {
        /// <summary>
        /// Sets the video player to <see cref="VideoAspectRatio.FitVertically"/> so videos fill the height
        /// and extend horizontally on ultrawide. For <see cref="VideoRenderMode.RenderTexture"/> players,
        /// also resizes the target texture to the 16:9 baseline resolution.
        /// Skips square textures (likely UI thumbnails, not actual video) and excluded scenes.
        /// </summary>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Threaded through to log helpers.</param>
        internal void EnforceAspectRatio([CallerMemberName] string caller = "")
        {
            if (!videoPlayer) return;
            if (ExcludeVideoPlayerScenes.Contains(CurrentScene))
            {
                videoPlayer.LogInfo($"Skipping aspect ratio enforcement in excluded scene '{CurrentScene}'", caller: caller);
                return;
            }

            var texture = videoPlayer.targetTexture;

            // Skip non-video content (square textures are likely UI elements, thumbnails, etc.)
            if (texture && texture.width == texture.height) return;

            videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
            videoPlayer.LogInfo($"Set FitVertically -> RenderMethod: {videoPlayer.renderMode}", caller: caller);

            if (videoPlayer.renderMode != VideoRenderMode.RenderTexture) return;

            if (!texture)
            {
                videoPlayer.LogWarning("RenderTexture mode but no targetTexture assigned", caller: caller);
                return;
            }

            if (texture.width == DisplayMetrics.BaselineWidth && texture.height == DisplayMetrics.MainHeight) return;

            var originalWidth = texture.width;
            var originalHeight = texture.height;

            texture.Release();
            texture.width = DisplayMetrics.BaselineWidth;
            texture.height = DisplayMetrics.MainHeight;
            texture.Create();
            videoPlayer.LogInfo($"Resized RenderTexture from {originalWidth}x{originalHeight} to {DisplayMetrics.BaselineWidth}x{DisplayMetrics.MainHeight} (16:9)", caller: caller);
        }
    }

    extension(Camera camera)
    {
        /// <summary>
        /// Forces the camera's gate fit to <see cref="Camera.GateFitMode.Vertical"/> (Hor+), which extends
        /// the horizontal FOV on ultrawide instead of cropping vertically. Logs each unique camera once.
        /// </summary>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Threaded through to log helpers.</param>
        internal void EnforceGateFit([CallerMemberName] string caller = "")
        {
            if (!camera)
            {
                Plugin.Logger.LogWarning($"[Camera, null]: Attempted to enforce gate fit on a null camera reference -> Scene: {CurrentScene} -> Caller: {caller}.");
                return;
            }

            camera.gateFit = Camera.GateFitMode.Vertical;

            var id = camera.GetInstanceID();
            if (LoggedCameras.Add(id))
            {
                camera.LogInfo("Set GateFit Vertical", caller: caller);
            }
        }
    }

    extension(Transform parent)
    {
        /// <summary>
        /// Disables letterbox GameObjects in the root hierarchy, under "UI", and under "HUD".
        /// </summary>
        /// <param name="type">The caller's MonoBehaviour instance, used for structured log output.</param>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Threaded through to log helpers.</param>
        internal void DisableAll(MonoBehaviour type, [CallerMemberName] string caller = "")
        {
            parent.DisableLetterBox(type, caller: caller);
            parent.DisableLetterBox(type, "UI", caller);
            parent.DisableLetterBox(type, "HUD", caller);
        }

        /// <summary>
        /// Recursively collects all child transforms in the hierarchy.
        /// </summary>
        private List<Transform> GetAllChildren()
        {
            var children = new List<Transform>();
            if (!parent) return children;
            for (var i = 0; i < parent.childCount; i++)
            {
                var child = parent.GetChild(i);
                if (!child) continue;
                children.Add(child);
                children.AddRange(child.GetAllChildren());
            }

            return children;
        }

        /// <summary>
        /// Scales a named child transform's X axis by the ultrawide-to-native aspect ratio.
        /// Tracked via <see cref="ScaledTransforms"/> to prevent compounding on repeated calls.
        /// </summary>
        /// <param name="type">The caller's MonoBehaviour instance, used for structured log output.</param>
        /// <param name="scaleMe">Name or path of the child transform to find and scale.</param>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Threaded through to log helpers.</param>
        internal void ScaleTransform(MonoBehaviour type, string scaleMe, [CallerMemberName] string caller = "")
        {
            var trToScale = parent.FindChild(scaleMe);
            if (trToScale)
            {
                if (!ScaledTransforms.Add(trToScale.GetInstanceID())) return;
                var newX = trToScale.localScale.x * DisplayMetrics.ScaleFactor;
                trToScale.localScale = new Vector3(newX, trToScale.localScale.y, trToScale.localScale.z);
                type.LogInfo($"Scaled '{scaleMe}'", caller: caller);
            }
            else
            {
                type.LogWarning($"No '{scaleMe}' child found to scale", caller: caller);
            }
        }

        /// <summary>
        /// Finds and disables all GameObjects whose names contain "letterbox" (case-insensitive)
        /// within the hierarchy. Optionally searches from a named child branch.
        /// Skips scenes in <see cref="ExcludeLetterboxScenes"/> where letterboxing is intentional.
        /// </summary>
        /// <param name="type">The caller's MonoBehaviour instance, used for structured log output.</param>
        /// <param name="start">Optional child name to use as the search root instead of the parent.</param>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Threaded through to log helpers.</param>
        private void DisableLetterBox(MonoBehaviour type, string start = "", [CallerMemberName] string caller = "")
        {
            if (!parent) return;
            if (ExcludeLetterboxScenes.Contains(CurrentScene))
            {
                type.LogInfo($"Skipping letterbox disabling in excluded scene '{CurrentScene}'", caller: caller);
                return;
            }

            var searchRoot = parent;
            if (start != "")
            {
                var startChild = parent.FindChild(start);
                if (!startChild) return;
                searchRoot = startChild;
            }

            foreach (var child in searchRoot.GetAllChildren().Where(child => child.name.Contains("letterbox", StringComparison.OrdinalIgnoreCase)))
            {
                if (!child.gameObject.activeSelf) continue;
                child.gameObject.SetActive(false);
                var id = child.GetInstanceID();
                if (LoggedLetterboxes.Add(id))
                {
                    type.LogInfo($"Disabled letterbox '{child.name}'", child.gameObject, caller);
                }
            }
        }
    }

    extension(GameObject obj)
    {
        /// <summary>
        /// Returns the full transform hierarchy path for this GameObject (e.g. "Canvas/Panel/Button").
        /// Used for structured log output.
        /// </summary>
        private string GetPath()
        {
            if (!obj) return string.Empty;
            var path = obj.name;
            var current = obj.transform.parent;
            while (current)
            {
                path = current.name + "/" + path;
                current = current.parent;
            }

            return path;
        }

        /// <summary>
        /// Returns an existing component of type <typeparamref name="T"/>, or adds and returns a new one.
        /// </summary>
        internal T TryAddComponent<T>() where T : Component
        {
            var existing = obj.GetComponent<T>();
            return existing ? existing : obj.AddComponent<T>();
        }

        /// <summary>
        /// Adds an <see cref="AspectRatioFitter"/> in <see cref="AspectRatioFitter.AspectMode.HeightControlsWidth"/>
        /// mode with the native display aspect ratio. Skips if one already exists.
        /// </summary>
        /// <param name="type">The caller's MonoBehaviour instance, used for structured log output.</param>
        /// <param name="caller">Auto-populated by <see cref="CallerMemberNameAttribute"/>. Threaded through to log helpers.</param>
        internal void AddAspectRatioFitter(MonoBehaviour type, [CallerMemberName] string caller = "")
        {
            if (!obj) return;
            var fitter = obj.gameObject.TryAddComponent<AspectRatioFitter>();
            fitter.aspectMode = AspectRatioFitter.AspectMode.HeightControlsWidth;
            fitter.aspectRatio = DisplayMetrics.MainAspect;
            type.LogInfo($"Added AspectRatioFitter to '{obj.name}'", obj, caller);
        }
    }
}