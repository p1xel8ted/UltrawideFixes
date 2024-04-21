using Steamworks;
using UnityEngine;

namespace KazeUW;

public class UnityEvents : MonoBehaviour
{
    public void OnDestroy()
    {
        Plugin.Hi?.UnpatchSelf();
    }

    public void LateUpdate()
    {
        var sky = GameObject.Find("Menu(Clone)/MenuBackground/Sky");
        if (sky != null)
        {
            sky.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var loadingScreen = GameObject.Find("LoadingScreen(Clone)/Canvas");
        if (loadingScreen != null)
        {
            loadingScreen.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var leaderBoardBackground = GameObject.Find("MapLevels(Clone)/View/Canvas/LeaderboardScreen/BG (2)");
        if (leaderBoardBackground != null)
        {
            leaderBoardBackground.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var slotScreenBackground = GameObject.Find("Menu(Clone)/Canvas/SlotScreen/ScreenLayout/BG");
        if (slotScreenBackground != null)
        {
            slotScreenBackground.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var optionsBackground = GameObject.Find("Menu(Clone)/Canvas/AnimatedMenuBKG/Root/Bkg/BG");
        if (optionsBackground != null)
        {
            optionsBackground.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var gamePauseBackground = GameObject.Find("Game(Clone)/GameHUDManager/HighResolutionCanvas/PausedHud/AnimatedMenuBKG/Root/Bkg/BG");
        if (gamePauseBackground != null)
        {
            gamePauseBackground.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var mapMenuPauseBackground = GameObject.Find("MapLevels(Clone)/View/Canvas/MapMenu/AnimatedMenuBKG/Root/Bkg/BG");
        if (mapMenuPauseBackground != null)
        {
            mapMenuPauseBackground.transform.localScale = new Vector3(2000f, 1f, 1f);
        }

        var fogLeft = GameObject.Find("Fog Left");
        if (fogLeft != null)
        {
            fogLeft.SetActive(false);
        }

        var fogRight = GameObject.Find("Fog Right");
        if (fogRight != null)
        {
            fogRight.SetActive(false);
        }

        var fogLeft1 = GameObject.Find("Fog Left (1)");
        if (fogLeft1 != null)
        {
            fogLeft1.SetActive(false);
        }

        var fogRight1 = GameObject.Find("Fog Right (1)");
        if (fogRight1 != null)
        {
            fogRight1.SetActive(false);
        }
        
        
    }
}