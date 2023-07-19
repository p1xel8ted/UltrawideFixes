using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HarmonyLib;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;
using Vector3 = System.Numerics.Vector3;
using Vector4 = System.Numerics.Vector4;

namespace GoGoGo;

[HarmonyPatch]
public partial class Plugin
{
    
    //skip intros
    [HarmonyPostfix]
    [HarmonyPatch(typeof(GlobalAccessor), nameof(GlobalAccessor.IsStartingGame), MethodType.Getter)]
    public static void GlobalAccessor_IsStartingGame(ref bool __result)
    {
        __result = false;
        PlayerPrefs.SetInt("IsIntroAlreadyViewed", 1);
        PlayerPrefs.Save();
    }

    [HarmonyPatch]
    public static class TargetedPatches
    {
        [HarmonyTargetMethods]
        public static IEnumerable<MethodBase> TargetMethods()
        {
            //find all methods that have a parameter called duration in the ShortcutExtensions class
            var methods = AccessTools.GetDeclaredMethods(typeof(ShortcutExtensions));
            foreach (var typeMethod in methods.Where(typeMethod => typeMethod.GetParameters().FirstOrDefault(a => a.Name == "duration") != null))
            {
                //we dont want to touch the loading rotation thingy
                if (typeMethod.Name.ToLowerInvariant().Contains("rotate")) continue;
                yield return typeMethod;
            }

            var methodsTwo = AccessTools.GetDeclaredMethods(typeof(DOTween));
            foreach (var typeMethod in methodsTwo.Where(typeMethod => typeMethod.Name == "ToAlpha"))
            {
                //we dont want to touch the loading rotation thingy
                if (typeMethod.Name.ToLowerInvariant().Contains("rotate")) continue;
                yield return typeMethod;
            }
        }


        [HarmonyPrepare]
        public static void Prepare(MethodBase original)
        {
            if (original != null)
            {
                Helpers.Log($"Preparing patch in {original.Name}!");
            }
        }

        [HarmonyPrefix]
        public static void Prefix(ref float duration)
        {
            //if player is in game, and not in menus, dont do anything
            if (MapGameplay.Instance != null) return;
            if (CoreUIManager.Instance != null)
            {
                //if the loading is screen is currently visible, dont do anything
                if (CoreUIManager.Instance._loadScreen.activeSelf) return;
            }


            Helpers.Log($"Player in menus. Setting duration of a tween to 0!");

            duration = 0f;
        }
    }

    [HarmonyPatch]
    public static class TargetedPatchesTwo
    {
        [HarmonyTargetMethods]
        public static IEnumerable<MethodInfo> TargetMethods()
        {
            foreach (var method in typeof(TweenSettingsExtensions).GetMethods())
            {
                if (method.Name is not ("SetLoops" or "SetLoop")) continue;

                yield return method.MakeGenericMethod(typeof(Tween));
                yield return method.MakeGenericMethod(typeof(Tweener));
                yield return method.MakeGenericMethod(typeof(TweenerCore<Vector3, Vector3, VectorOptions>));
                yield return method.MakeGenericMethod(typeof(TweenerCore<Color, Color, ColorOptions>));
                yield return method.MakeGenericMethod(typeof(TweenerCore<Vector4, Vector4, VectorOptions>));
                yield return method.MakeGenericMethod(typeof(TweenerCore<Quaternion, Vector3, QuaternionOptions>));
            }
        }

        [HarmonyPrepare]
        public static void Prepare()
        {
            Helpers.Log($"Preparing patch in SetLoop!");
        }

        [HarmonyPostfix]
        public static void Postfix(ref Tween __result)
        {
            //if player is in game, and not in menus, dont do anything
            if (MapGameplay.Instance != null) return;

            if (__result == null) return;
            if (CoreUIManager.Instance != null)
            {
                //if the loading is screen is currently visible, dont do anything
                if (CoreUIManager.Instance._loadScreen.activeSelf) return;
            }

            Helpers.Log($"Player in menus. Setting duration of a SetLoop to 0!");
            __result.delay = 0f;
            __result.duration = 0f;
            __result.fullDuration = 0f;
        }
    }
}