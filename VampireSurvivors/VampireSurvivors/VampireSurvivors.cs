using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppVampireSurvivors.Data;
using Il2CppVampireSurvivors.UI;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;

[assembly:
    MelonInfo(typeof(VampireSurvivors.VampireSurvivors), "Vampire Survivors UltraWide Fixes", "0.0.3", "p1xel8ted")]
[assembly: MelonGame("poncle", "VampireSurvivors")]

namespace VampireSurvivors;

public partial class VampireSurvivors : MelonMod
{
    private MelonPreferences_Category _modCategory;
    private static MelonPreferences_Entry<bool> _expandUI;
    private static MelonPreferences_Entry<bool> _blackChallenge;
    private GameObject _map;
    private GameObject _left;
    private Il2CppArrayBase<AspectMask> _aspectMasks;
    private Il2CppArrayBase<Camera> _cameras;
    private Il2CppArrayBase<AspectRatioFitter> _aspectRatioFitters;
    private static StageType CurrentType { get; set; } = StageType.TEST;

    public override void OnInitializeMelon()
    {
        _modCategory = MelonPreferences.CreateCategory("Vampire Survivors UltraWide Fixes");
        _expandUI = _modCategory.CreateEntry("Expand UI", false, description:"Expand the UI to fill the screen. May/probably will break some UI elements (minor).");
        _blackChallenge = _modCategory.CreateEntry("Leave Black Bars In-Place For Challenge Levels", true, description:"The challenge levels ground tile-set stops rendering outside of 16:9. This option will leave the black bars in place for those levels.");
        MelonLogger.Msg("Vampire Survivors UltraWide Fixes Loaded");
        MelonPreferences.Save();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();

        if (_expandUI.Value && _map != null && _left != null)
        {
            _map.transform.SetParent(_left.transform);
            _map.transform.localPosition = new Vector3(0, -1138, 0);
            
        }
        foreach (var a in _aspectRatioFitters)
        {
            if (_blackChallenge.Value && CurrentType is StageType.MOLISE or StageType.GREENACRES)
            {
                a.aspectRatio = 1.6f;
            }
            else
            {
                a.aspectRatio = Display.main.systemWidth / (float) Display.main.systemHeight;
            }
        }

        foreach (var aspectMask in _aspectMasks.Where(a=>a!=null))
        {
            if (_blackChallenge.Value)
            {
                if (CurrentType is StageType.MOLISE or StageType.GREENACRES)
                {
                    aspectMask.gameObject.SetActive(true);
                    return;
                }
            }

            if (aspectMask.gameObject.activeSelf)
            {
                aspectMask.gameObject.SetActive(false);
            }
        }
        
        
    }

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        base.OnSceneWasLoaded(buildIndex, sceneName);
        
        _cameras = Resources.FindObjectsOfTypeAll<Camera>();
        _aspectMasks = Resources.FindObjectsOfTypeAll<AspectMask>();
        
        foreach (var aspectMask in _aspectMasks.Where(a=>a!=null))
        {   
            if (_blackChallenge.Value)
            {
                if (CurrentType is StageType.MOLISE or StageType.GREENACRES)
                {
                    aspectMask.gameObject.SetActive(true);
                    return;
                }
            }

            if (aspectMask.gameObject.activeSelf)
            {
                aspectMask.gameObject.SetActive(false);
            }
        }
        
        if (_expandUI.Value )
        {
            _aspectRatioFitters = Resources.FindObjectsOfTypeAll<AspectRatioFitter>();
            foreach (var a in _aspectRatioFitters)
            {
                if (_blackChallenge.Value && CurrentType is StageType.MOLISE or StageType.GREENACRES)
                {
                    a.aspectRatio = 1.6f;
                }
                else
                {
                    a.aspectRatio = Display.main.systemWidth / (float) Display.main.systemHeight;
                }
            }
        
            _left = GameObject.Find("GAME UI/Canvas - Game UI/Safe Area/View - Paused/Left");
            _map = GameObject.Find("GAME UI/Canvas - Game UI/Safe Area/View - Paused/MapGroup");
        
            var charSelection = GameObject.Find("UI/Canvas - App/Safe Area/View - CharacterSelection/Panel");
            if (charSelection != null)
            {
                var confirmButton =
                    GameObject.Find("UI/Canvas - App/Safe Area/View - CharacterSelection/ConfirmButton");
                var buyButton = GameObject.Find("UI/Canvas - App/Safe Area/View - CharacterSelection/BuyButton");
                var startButton =
                    GameObject.Find("UI/Canvas - App/Safe Area/View - CharacterSelection/StartButton");
                GameObject[] buttons = {confirmButton, buyButton, startButton};

                foreach (var button in buttons.Where(a=>a!=null))
                {
                    button.transform.SetParent(charSelection.transform);
                    button.transform.localPosition = new Vector3(693.5758f, 81.4038f, 0);
                }
            }
        
            var selectPanel = GameObject.Find("UI/Canvas - App/Safe Area/View - StageSelection/Panel");
            if (selectPanel != null)
            {
                var stageSelectButton =
                    GameObject.Find("UI/Canvas - App/Safe Area/View - StageSelection/SelectButton");
                var stageConfirmButton =
                    GameObject.Find("UI/Canvas - App/Safe Area/View - StageSelection/ConfirmButton");
                var stageStartButton =
                    GameObject.Find("UI/Canvas - App/Safe Area/View - StageSelection/StartButton");
                GameObject[] stageButtons = {stageSelectButton, stageConfirmButton, stageStartButton};
                
                foreach (var button in stageButtons.Where(a=>a!=null))
                {
                    button.transform.SetParent(selectPanel.transform);
                    button.transform.localPosition = new Vector3(693.5758f, 81.4038f, 0);
                }
                
                var musicPanel = GameObject.Find("UI/Canvas - App/Safe Area/View - StageSelection/Music Selection");
                if (musicPanel != null)
                {
                    musicPanel.transform.SetParent(selectPanel.transform);
                    musicPanel.transform.localPosition = new Vector3(693.5758f, 375.1111f, 0);
                }
               
            }
        }
    }
    
}