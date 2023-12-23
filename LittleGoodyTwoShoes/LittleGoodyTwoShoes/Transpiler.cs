using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using HarmonyLib;
using LGTS.LGTS_Utils;
using LGTS.Managers.Scenes;
using UnityEngine;

namespace LittleGoodyTwoShoes;

[Harmony]
public static class Transpiler
{

    [HarmonyTranspiler]
    [HarmonyPatch(typeof(SceneMaster), nameof(SceneMaster.GoToOpeningVideo))]
    private static IEnumerable<CodeInstruction> SceneMaster_GoToOpeningVideo_Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        var codes = new List<CodeInstruction>(instructions);
        var index = codes.FindIndex(c => c.opcode == OpCodes.Ldc_I4_S && (sbyte)c.operand == 14);
        if (index != -1)
        {
            codes[index].operand = (sbyte)13;
        }
        return codes.AsEnumerable();
    }

}