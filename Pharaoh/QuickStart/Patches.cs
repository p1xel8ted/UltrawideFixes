using System.IO;
using System.Linq;
using HarmonyLib;
using SFB;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace QuickStart;

[HarmonyPatch]
public static class Patches
{
    private static GameObject _quickLoadButton;

    private static GameObject _customLoadButton;

    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuMenuPanel), nameof(MenuMenuPanel.StartShowAnimation))]
    private static void MenuMenuPanel_Init_Appear(ref MenuMenuPanel __instance)
    {
        //find the text and set the font size
        var nbText = _quickLoadButton.GetComponentInChildren<TextMeshProUGUI>();
        nbText.text = "Quick Load";
        nbText.fontSize = 25f;
        nbText.fontSizeMax = 25f;
        nbText.fontSizeMin = 18f;

        var cbText = _customLoadButton.GetComponentInChildren<TextMeshProUGUI>();
        cbText.text = "Custom Load";
        cbText.fontSize = 25f;
        cbText.fontSizeMax = 25f;
        cbText.fontSizeMin = 18f;

        var color1 = nbText.color;
        color1.a = 1f;
        nbText.color = color1;

        var color2 = cbText.color;
        color2.a = 1f;
        cbText.color = color2;
    }


    [HarmonyPostfix]
    [HarmonyPatch(typeof(MenuMenuPanel), nameof(MenuMenuPanel.Init))]
    private static void MenuMenuPanel_Init_Patch(ref MenuMenuPanel __instance)
    {
        var playButton = __instance._menuPlayBtn;

        var parent = playButton.transform.parent;
        _quickLoadButton = Object.Instantiate(playButton, parent);
        _quickLoadButton.name = "quickload_button";

        _quickLoadButton.GetComponent<Button>().onClick.RemoveAllListeners();
        _quickLoadButton.GetComponent<Button>().onClick.AddListener(() =>
        {
            GlobalAccessor.IsLevelFromResources = false;
            var save = FileManager.ScanForSaves().Last();
            var savePath = Path.Combine(SerializationSettings.CurrentFamilySavePath, save + ".psav");
            GlobalAccessor.LevelPathToLoad = Plugin.LoadLastModified.Value ? savePath : FileManager.GetMostRecentCampaignSavePath();
            CoreUIManager.Instance.SetLoadPanelActive(false);
            CoreSceneManager.Instance.TransitionToScene("MapGameplay");
        });


        _customLoadButton = Object.Instantiate(playButton, parent);
        _customLoadButton.name = "custom_button";

        _customLoadButton.GetComponent<Button>().onClick.RemoveAllListeners();
        _customLoadButton.GetComponent<Button>().onClick.AddListener(() =>
        {
            const string title = "Load a Pharaoh Save";
            var loadDir = Directory.Exists(SerializationSettings.FamilyFolder) ? SerializationSettings.FamilyFolder : Path.Combine(Application.persistentDataPath, SteamClient.SteamId.Value.ToString());
            var array = new[]
            {
                new ExtensionFilter("Pharaoh Save Game", SerializationSettings.SaveExtension)
            };
            var file = StandaloneFileBrowser.OpenFilePanel(title, loadDir, array, false);
            if (file.Length == 0)
            {
                return;
            }

            MainMenuManager.Instance.GetPanel<MenuTitlePanel>().StopMusic();
            GlobalAccessor.LevelPathToLoad = file[0];
            GlobalAccessor.IsLevelFromResources = false;
            CoreSceneManager.Instance.TransitionToScene("MapGameplay");
        });
    }
}