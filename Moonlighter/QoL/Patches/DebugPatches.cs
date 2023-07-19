using System.Collections.Generic;
using System.Reflection;
using DG.Tweening.Core;
using HarmonyLib;
using UnityEngine;

namespace QoL.Patches;

/// <summary>
/// Contains Harmony patches for debugging purposes.
/// </summary>
[HarmonyPatch]
public static class DebugPatches
{
    /// <summary>
    /// Harmony prefix patch for <see cref="Debug.LogWarning(object)"/> and <see cref="Debug.LogWarning(object, Object)"/> methods.
    /// This patch filters out warnings containing the keyword "season".
    /// </summary>
    /// <param name="message">The message to be logged.</param>
    /// <returns>False if the message contains "season", otherwise true.</returns>
    [HarmonyPrefix]
    [HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), typeof(object))]
    [HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), typeof(object), typeof(Object))]
    public static bool Debug_LogWarning(ref object message)
    {
        if (message is not string msg) return true;
        return !msg.Contains("season");
    }

    /// <summary>
    /// Contains Harmony patches for <see cref="Debugger"/> class' methods containing "Log" in their names.
    /// The applied patches prevent the execution of these methods.
    /// </summary>
    [HarmonyPatch]
    public static class DgTweenDebugKill
    {
        /// <summary>
        /// Specifies the target methods for the Harmony patch.
        /// </summary>
        /// <returns>Enumerable of <see cref="MethodBase"/> which are the target methods for the patch.</returns>
        [HarmonyTargetMethods]
        public static IEnumerable<MethodBase> TargetMethods()
        {
            return AccessTools.GetDeclaredMethods(typeof(Debugger))
                .Where(a => a.Name.Contains("Log"));
        }

        /// <summary>
        /// Harmony prefix patch for the methods containing "Log" in their names in the <see cref="Debugger"/> class.
        /// This patch prevents the execution of the original methods.
        /// </summary>
        /// <returns>Always false, preventing the execution of the original methods.</returns>
        [HarmonyPrefix]
        public static bool Prefix()
        {
            return false;
        }
    }
}