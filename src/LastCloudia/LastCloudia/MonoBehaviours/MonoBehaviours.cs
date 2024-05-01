using System.Collections;
using BepInEx.Unity.IL2CPP.Utils.Collections;
using World;
using World.UI.Base;

namespace LastCloudia.MonoBehaviours;

public class MonoBehaviours : MonoBehaviour
{
    private bool _customTimeScale;
    private float _timeScale;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            Plugin.ConfigInstance.Reload();
            Patches.Patches.MoveHud();
        }


        if (Plugin.SpeedIncrease.Value)
        {
            HandleTimeScaleKey(KeyCode.Alpha1, 1f, false);
            HandleTimeScaleKey(KeyCode.Alpha2, 5f, true);
            HandleTimeScaleKey(KeyCode.Alpha3, 10f, true);
            HandleTimeScaleKey(KeyCode.Alpha4, 15f, true);
            HandleTimeScaleKey(KeyCode.Alpha5, 20f, true);

            if (_customTimeScale)
            {
                Time.timeScale = _timeScale;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(PerformEscape().WrapToIl2Cpp());
        }
    }

    private IEnumerator PerformEscape()
    {
        Time.timeScale = 1;
        yield return new WaitForSecondsRealtime(0.25f);

        if (Plugin.RightClickModeOption.Value == Plugin.RightClickMode.Native)
        {
            Plugin.Logger.LogInfo("Pressing ESC key");
            KeyPressSimulator.PressESC();
        }
        else
        {
            var hb = Utils.FindIl2CppType<UIFooterButton>().Find(a => a.name.Equals("HomeButton"));
            if (CommonUIManager.instance.GetBackButtonActive())
            {
                Plugin.Logger.LogInfo("Pressing back button");
                CommonUIManager.instance.OnClickBackButton();
            }
            else if (hb && hb.gameObject.activeSelf)
            {
                Plugin.Logger.LogInfo("Pressing home button");
                CommonUIManager.instance.OnClickHomeButton();
            }
            else
            {
                Plugin.Logger.LogInfo("No back button found.");
                if (Plugin.UseESCBackup.Value)
                {
                    Plugin.Logger.LogInfo("Pressing ESC key as backup");
                }
            }
        }

        yield return new WaitForSecondsRealtime(0.25f);

        if (_customTimeScale)
        {
            Time.timeScale = _timeScale;
        }
    }


    private void HandleTimeScaleKey(KeyCode key, float scale, bool isCustom)
    {
        if (Input.GetKeyDown(key))
        {
            _customTimeScale = isCustom;
            _timeScale = scale;
            if (!isCustom)
            {
                Time.timeScale = scale; // Set immediately if not custom
            }
        }
    }
}