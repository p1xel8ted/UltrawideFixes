﻿namespace LastCloudia.MonoBehaviours;

public class MonoBehaviours : MonoBehaviour
{
    private bool _customTimeScale;
    private float _timeScale;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            Plugin.ConfigInstance.Reload();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _customTimeScale = false;
            _timeScale = 1f;
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _customTimeScale = true;
            _timeScale = 5f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            _customTimeScale = true;
            _timeScale = 10f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            _customTimeScale = true;
            _timeScale = 15f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            _customTimeScale = true;
            _timeScale = 20f;
        }

        if (_customTimeScale)
        {
            Time.timeScale = _timeScale;
        }
        
        // Application.runInBackground = Plugin.RunInBackground.Value;
        // AudioListener.pause = !Application.isFocused && Plugin.MuteInBackground.Value;
    }
}