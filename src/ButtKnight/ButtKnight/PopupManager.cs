namespace ButtKnight;

internal class PopupManager : MonoBehaviour
{
    internal bool ShowPopup;
    private string _popupMessage = "";
    private Rect _popupRect;
    private GUIStyle _messageStyle;
    private GUIStyle _windowStyle;
    private GUIStyle _titleStyle;
    private readonly HashSet<string> _suppressedPopupIds = new();
    private bool _ignoreDontShow;
    private string _currentPopupId;

    private void Awake()
    {
        _titleStyle = new GUIStyle
        {
            alignment = TextAnchor.MiddleCenter,
            wordWrap = true,
            fontSize = 22,
            normal = {textColor = Color.black}
        };

        _messageStyle = new GUIStyle
        {
            alignment = TextAnchor.MiddleCenter,
            wordWrap = true,
            fontSize = 18,
            normal = {textColor = Color.black}
        };

        _windowStyle = new GUIStyle
        {
            normal = {background = Texture2D.whiteTexture, textColor = Color.black},
            richText = true,
            padding = new RectOffset(10, 10, 10, 10),
        };
    }

    private void OnGUI()
    {
        if (ShowPopup)
        {
            _popupRect = new Rect(
                Screen.width / 2f - 250,
                Screen.height / 2f - 150,
                500,
                300
            );
            _popupRect = GUI.ModalWindow(0, _popupRect, DrawPopup, string.Empty, _windowStyle);
        }
    }

    private void DrawPopup(int windowID)
    {
        GUILayout.FlexibleSpace();

        GUI.Label(new Rect(10, 10, _popupRect.width - 20, 30), Plugin.PluginName, _titleStyle);

        GUILayout.FlexibleSpace();

        GUILayout.Label(_popupMessage, _messageStyle);

        GUILayout.FlexibleSpace();

        GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
        if (GUILayout.Button("OK", GUILayout.Width(100), GUILayout.Height(40)))
        {
            ShowPopup = false;
        }
        if (!_ignoreDontShow)
        {
            if (GUILayout.Button("Close & Don't Show Again This Session", GUILayout.Width(250), GUILayout.Height(40)))
            {
                _suppressedPopupIds.Add(_currentPopupId);
                ShowPopup = false;
            }
        }
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.FlexibleSpace();
    }
    
    public void ShowPopupDlg(string message, string popupId, bool showCloseAndDontShowAgain)
    {
        _ignoreDontShow = !showCloseAndDontShowAgain;
        if (_suppressedPopupIds.Contains(popupId) && showCloseAndDontShowAgain) return;
        _popupMessage = message;
        _currentPopupId = popupId;
        ShowPopup = true;
    }
}