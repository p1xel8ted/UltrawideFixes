// using System.Reflection.Emit;
// using MapMinimap;
//
// namespace RuffyAndTheRiverside.Patches;
//
// [Harmony]
// public static class Transpilers
// {
//     public static float GetCurrentAspect()
//     {
//         return Screen.width / (float)Screen.height;
//     }
//
//
//     [HarmonyTranspiler]
//     [HarmonyPatch(typeof(MapViewer), nameof(MapViewer.ClampToMap))]
//     [HarmonyPatch(typeof(MapViewer), nameof(MapViewer.MoveMap))]
//     public static IEnumerable<CodeInstruction> MapViewer_ClampToMap(IEnumerable<CodeInstruction> instructions)
//     {
//         var codes = instructions.ToList();
//         //find all instances of 1.7777778 and replace with GetCurrentAspect()
//         foreach (var t in codes.Where(t => t.opcode == OpCodes.Ldc_R4 && Mathf.Approximately((float)t.operand, 1.7777778f)))
//         {
//             t.opcode = OpCodes.Call;
//             t.operand = typeof(Transpilers).GetMethod(nameof(GetCurrentAspect));
//         }
//
//         return codes.AsEnumerable();
//     }
// }