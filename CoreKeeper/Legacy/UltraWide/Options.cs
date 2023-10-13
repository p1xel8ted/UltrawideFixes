using UnityEngine;

namespace UltraWide;

public class Options : MonoBehaviour
{
    private bool _showGUI; // initial GUI state
    private bool ShowGUI
    {
        get => _showGUI;
        set
        {
            if (_showGUI == value) return;
            _showGUI = value;


            if (_showGUI)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = false;
            }
        }
    }

    public float SliderValue { get; set; }
    public float SliderValueMax { get; set; }

    public bool ToggleState { get; set; }

    public delegate void SliderValueChangeDelegate(float value);

    public delegate void ToggleValueChangeDelegate(bool value);

    public SliderValueChangeDelegate OnSliderValueChanged { get; set; }
    public ToggleValueChangeDelegate OnToggleValueChanged { get; set; }

    private static void SetUnlockCursor(int lockState, bool cursorVisible)
    {
        Cursor.lockState = (CursorLockMode) lockState;
        Cursor.visible = cursorVisible;
    }

    void OnGUI()
    {
        if (!ShowGUI) return;

        SetUnlockCursor(0, true);

        // Define dimensions
        const float boxWidth = 500;
        const float boxHeight = 350;
        const float borderWidth = 10;

        // Calculate positions
        var xPos = (Screen.width - boxWidth) / 2;
        var yPos = (Screen.height - boxHeight) / 2;

        var texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, new Color(0.8f, 0.8f, 0.8f));
        texture.Apply();

        var style = new GUIStyle
        {
            fontStyle = FontStyle.Bold,
            normal =
            {
                background = texture
            }
        };

        // Border (pseudo-window)
        GUI.Box(new Rect(xPos - borderWidth, yPos - borderWidth, boxWidth + 2 * borderWidth, boxHeight + 2 * borderWidth), "", style);

        // Box (pseudo-window)
        GUI.Box(new Rect(xPos, yPos, boxWidth, boxHeight), "Core Keeper Ultra-Wide", style);

        const float buttonSize = 30f;
        if (GUI.Button(new Rect(xPos + boxWidth - buttonSize, yPos, buttonSize, buttonSize), "X"))
        {
            ShowGUI = false;
        }
        
        GUI.color = Color.black;

        
  

        var desFontStyle = new GUIStyle()
        {
            fontStyle = FontStyle.Italic,
            wordWrap = true
        };

        var headerFontStyle = new GUIStyle()
        {
            wordWrap = true,
            fontStyle = FontStyle.Bold
        };

        var valueStyle = new GUIStyle()
        {
            alignment = TextAnchor.MiddleCenter
        };
        GUI.Label(new Rect(xPos + 10, yPos + 30, 150, 20), "Custom Max Width", headerFontStyle);
        var newToggleState = GUI.Toggle(new Rect(xPos + 10, yPos + 60, 100, 30), ToggleState, "Enabled");
        GUI.Label(new Rect(xPos + 10, yPos + 90, boxWidth - 20, 120), "Enable to allow the slider below to function. This will allow you to set a custom max width for the viewport. Not needed by default.", desFontStyle);


        GUI.Label(new Rect(xPos + 10, yPos + 140, boxWidth - 20, 20), "Custom Max Width", headerFontStyle);
        var newSliderValue = GUI.HorizontalSlider(new Rect(xPos + 30, yPos + 170, boxWidth - 70, 30), SliderValue, 480f, SliderValueMax);
        GUI.Label(new Rect(xPos + 10, yPos + 180, boxWidth - 20, 20), $"{SliderValue}", valueStyle);
        GUI.Label(new Rect(xPos + 10, yPos + 210, boxWidth - 20, 120), "New viewport width. This is not the width in screen pixels. For example at 3440x1440 (21:9), a value of 630 expands the viewport entirely.", desFontStyle);

        GUI.Label(new Rect(xPos + 10, yPos + 250, boxWidth - 20, 120), "The mouse catching in this window can be tricky. Borderless/Pausing firs And right clicking. *shrug*", headerFontStyle);
        GUI.Label(new Rect(xPos + 10, yPos + 290, boxWidth - 20, 120), "Finally, some values will make the text unreadable, move the value left or a right a touch to correct.", headerFontStyle);

        if (newSliderValue != SliderValue)
        {
            SliderValue = newSliderValue;
            OnSliderValueChanged?.Invoke(SliderValue);
        }

        if (newToggleState != ToggleState)
        {
            ToggleState = newToggleState;
            OnToggleValueChanged?.Invoke(ToggleState);
        }
    }

    private void LateUpdate()
    {
        if (ShowGUI) SetUnlockCursor(0, true);
    }

    private void Update()
    {
        if (ShowGUI) SetUnlockCursor(0, true);
        if (Input.GetKeyDown(KeyCode.F1))
        {
            ShowGUI = !ShowGUI;
        }
    }
}