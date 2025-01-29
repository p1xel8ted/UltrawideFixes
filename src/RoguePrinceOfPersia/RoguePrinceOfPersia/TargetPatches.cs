// namespace RoguePrinceOfPersia;
//
// [Harmony]
// public static class TargetPatches
// {
//   
//     [HarmonyTargetMethods]
//     public static IEnumerable<MethodBase> TargetMethods()
//     {
//         return typeof(NotificationManager).GetMethods().Where(m => m.Name == "ShowNotification");
//     }
//     
//     [HarmonyPostfix]
//     public static void ShowNotificationPostfix(NotificationManager __instance)
//     {
//         LayoutController.AddLayoutControllerPath(__instance.transform, "NotificationBiomeUnlockPrefab(Clone)",LayoutController.LayoutSize.ConfigBased, 0, true);
//         LayoutController.AddLayoutControllerPath(__instance.transform, "NotificationBiomeUnlockPrefab(Clone)/Background",LayoutController.LayoutSize.ForceFullScreen, 0, true);
//     }
//         
// }