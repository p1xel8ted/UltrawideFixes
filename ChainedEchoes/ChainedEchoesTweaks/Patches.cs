using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ChainedEchoesTweaks;

[HarmonyPatch]
public static class Patches
{
    [HarmonyPostfix]
    [HarmonyPatch(typeof(ShopMenu), nameof(ShopMenu.Start))]
    public static void ShopMenu_Start()
    {
        var shopBg = GameObject.Find("__Shop Menu(Clone)/BGCanvas/MenuBGContainer/MenuBG");
        if (shopBg != null)
        {
            shopBg.transform.localScale = new Vector3(2.6f, 2, 1);
        }

        var shopBottomBar = GameObject.Find("__Shop Menu(Clone)/BlackBarCanvas/BlackBarBottom/Image");
        if (shopBottomBar != null)
        {
            shopBottomBar.transform.localScale = new Vector3(1.5f, 1, 1);
        }

        var shopTopBar = GameObject.Find("__Shop Menu(Clone)/BlackBarCanvas/BlackBarTop/Image");
        if (shopTopBar != null)
        {
            shopTopBar.transform.localScale = new Vector3(1.5f, 1, 1);
        }
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(MainMenu), nameof(MainMenu.Start))]
    public static void MainMenu_Start()
    {
        var invBottomBar = GameObject.Find("__Main Menu(Clone)/BlackBarCanvas/BlackBarBottom/Image");
        if (invBottomBar != null)
        {
            invBottomBar.transform.localScale = new Vector3(1.5f, 1, 1);
        }

        var invTopBar = GameObject.Find("__Main Menu(Clone)/BlackBarCanvas/BlackBarTop/Image");
        if (invTopBar != null)
        {
            invTopBar.transform.localScale = new Vector3(1.5f, 1, 1);
        }

        var invBackground = GameObject.Find("__Main Menu(Clone)/BGCanvas/MenuBGContainer/MenuBG");
        if (invBackground != null)
        {
            invBackground.transform.localScale = new Vector3(2.6f, 2, 1);
        }
    }
   
   [HarmonyPostfix]
   [HarmonyPatch(typeof(Map), nameof(Map.OpenMap))]
   public static void Map_OpenMap()
   {
       var currentMap = SceneManager.GetActiveScene().name;
       var map = $"map_{currentMap.Substring(0, 2)}";

       var mapOne = GameObject.Find("map_none/BG");
       if (mapOne != null)
       {
           mapOne.transform.localScale = new Vector3(160, 100, 1);
       }

       var mapTwo = GameObject.Find($"{map}/BG");
       if (mapTwo != null)
       {
           mapTwo.transform.localScale = new Vector3(160, 100, 1);
       }
        
       var mapThree = GameObject.Find("map_none/BG (1)");
       if (mapThree != null)
       {
           mapThree.transform.localScale = new Vector3(160, 100, 1);
       }

       var mapFour = GameObject.Find($"{map}/BG (1)");
       if (mapFour != null)
       {
           mapFour.transform.localScale = new Vector3(160, 100, 1);
       }
   }
}