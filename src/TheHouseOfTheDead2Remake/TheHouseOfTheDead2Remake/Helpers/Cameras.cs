// namespace TheHouseOfTheDead2Remake.Helpers;
//
// public static class Cameras
// {
//     /// <summary>
//     /// Cached reference to the main camera's HDAdditionalCameraData component.
//     /// </summary>
//     private static HDAdditionalCameraData _hdAdditionalCameraData;
//
//     /// <summary>
//     /// Gets or sets the instance of the HDAdditionalCameraData for the main camera.
//     /// Automatically finds the component if it has not been set.
//     /// </summary>
//     public static HDAdditionalCameraData HdAdditionalCameraDataInstance
//     {
//         get
//         {
//             if (!_hdAdditionalCameraData)
//             {
//                 // Finds the HDAdditionalCameraData for the camera named "cam_MainCamera".
//                 _hdAdditionalCameraData = Resources
//                     .FindObjectsOfTypeAll<HDAdditionalCameraData>()
//                     .FirstOrDefault(a => a.name == "Default HDAdditionalCameraData");
//             }
//
//             return _hdAdditionalCameraData;
//         }
//         set => _hdAdditionalCameraData = value;
//     }
//
//     /// <summary>
//     /// Updates the post-processing anti-aliasing settings for the main camera.
//     /// </summary>
//     public static void UpdatePostProcessingAA()
//     {
//         var data = HdAdditionalCameraDataInstance;
//
//         // Updates the anti-aliasing mode and quality settings.
//         if (!data) return;
//         
//         data.antialiasing = Plugin.PostProcessAntialiasingMode.Value;
//         data.TAAQuality = HDAdditionalCameraData.TAAQualityLevel.High;
//         data.SMAAQuality = HDAdditionalCameraData.SMAAQualityLevel.High;
//
//         // Updates the TAA sharpening strength from plugin settings.
//         data.taaSharpenStrength = Plugin.PostProcessTaaSharpeningStrength.Value;
//     }
// }