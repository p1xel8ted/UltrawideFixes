using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using BepInEx;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;

namespace ChainedEchoesTweaks;

[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
public class Plugin : BaseUnityPlugin
{
    private const string PluginGuid = "p1xel8ted.chainedechoes.tweaks";
    private const string PluginName = "ChainedEchoesTweaks";
    private const string PluginVersion = "0.0.1";

    private Harmony _hi;

    private void Awake()
    {
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
        _hi = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), PluginGuid);
    }

    //disable intros
    [HarmonyPatch(typeof(GameStart), nameof(GameStart.Progressing), MethodType.Enumerator)]
    public static class HarmonyTranspiler
    {
        [HarmonyLib.HarmonyTranspiler]
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            return new CodeMatcher(instructions)
                .MatchForward(false,
                    new CodeMatch(OpCodes.Ldc_I4_0),
                    new CodeMatch(OpCodes.Stsfld, AccessTools.Field(typeof(GameStart), nameof(GameStart.animationPlayed))),
                    new CodeMatch(OpCodes.Ldarg_0))
                .SetOpcodeAndAdvance(OpCodes.Ldc_I4_1)
                .InstructionEnumeration();
        }
    }


    private void OnDisable()
    {
        _hi?.UnpatchSelf();
    }
    
    private void LateUpdate()
    {
        // var pp = GameObject.Find("ProCamera2DShakeContainer/Main Camera(Clone)").GetComponent<PixelPerfectCamera>();
        if (Camera.main != null)
        {
            var pp = Camera.main.GetComponent<PixelPerfectCamera>();
            if (pp != null)
            {
                pp.enabled = false;
               
            }
            Camera.main.orthographicSize = 250f;
           
        }

        // var currentMap = SceneManager.GetActiveScene().name;
        // var map = $"map_{currentMap.Substring(0, 2)}";
        //
        // var mapOne = GameObject.Find("map_none/BG");
        // if (mapOne != null)
        // {
        //     mapOne.transform.localScale = new Vector3(160, 100, 1);
        // }
        //
        // var mapTwo = GameObject.Find($"{map}/BG");
        // if (mapTwo != null)
        // {
        //     mapTwo.transform.localScale = new Vector3(160, 100, 1);
        // }
        //
        // var mapThree = GameObject.Find("map_none/BG (1)");
        // if (mapThree != null)
        // {
        //     mapThree.transform.localScale = new Vector3(160, 100, 1);
        // }
        //
        // var mapFour = GameObject.Find($"{map}/BG (1)");
        // if (mapFour != null)
        // {
        //     mapFour.transform.localScale = new Vector3(160, 100, 1);
        // }
        
        

        // var shopBg = GameObject.Find("__Shop Menu(Clone)/BGCanvas/MenuBGContainer/MenuBG");
        // if (shopBg != null)
        // {
        //     shopBg.transform.localScale = new Vector3(2.6f, 2, 1);
        // }
        //
        // var shopBottomBar = GameObject.Find("__Shop Menu(Clone)/BlackBarCanvas/BlackBarBottom/Image");
        // if (shopBottomBar != null)
        // {
        //     shopBottomBar.transform.localScale = new Vector3(1.5f, 1, 1);
        // }
        //
        // var shopTopBar = GameObject.Find("__Shop Menu(Clone)/BlackBarCanvas/BlackBarTop/Image");
        // if (shopTopBar != null)
        // {
        //     shopTopBar.transform.localScale = new Vector3(1.5f, 1, 1);
        // }

        // var invBottomBar = GameObject.Find("__Main Menu(Clone)/BlackBarCanvas/BlackBarBottom/Image");
        // if (invBottomBar != null)
        // {
        //     invBottomBar.transform.localScale = new Vector3(1.5f, 1, 1);
        // }
        //
        // var invTopBar = GameObject.Find("__Main Menu(Clone)/BlackBarCanvas/BlackBarTop/Image");
        // if (invTopBar != null)
        // {
        //     invTopBar.transform.localScale = new Vector3(1.5f, 1, 1);
        // }
        //
        // var invBackground = GameObject.Find("__Main Menu(Clone)/BGCanvas/MenuBGContainer/MenuBG");
        // if (invBackground != null)
        // {
        //     invBackground.transform.localScale = new Vector3(2.6f, 2, 1);
        // }
    }
}