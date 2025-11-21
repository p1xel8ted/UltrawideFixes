namespace WinterBurrow.Utils;

/// <summary>
/// Singleton component for displaying temporary on-screen messages at different corner positions.
/// Creates a persistent canvas with layout groups for organizing messages by screen position.
/// </summary>
public class MessageDisplayer : MonoBehaviour
{
    private static MessageDisplayer _instance;
    private Canvas _canvas;
    private RectTransform _container;
    private Dictionary<Corner, VerticalLayoutGroup> _layoutGroups;

    /// <summary>
    /// Ensures a single instance of the MessageDisplayer is available in the scene.
    /// </summary>
    public static MessageDisplayer Instance
    {
        get
        {
            if (_instance) return _instance;
            
            var obj = new GameObject("MessageDisplayer");
            _instance = obj.AddComponent<MessageDisplayer>();
            _instance.Initialize();
            DontDestroyOnLoad(obj);
            return _instance;
        }
    }

    /// <summary>
    /// Initializes the canvas, container, and layout groups for displaying messages.
    /// </summary>
    private void Initialize()
    {
        // Create a Canvas
        _canvas = new GameObject("MessageCanvas").AddComponent<Canvas>();
        _canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        DontDestroyOnLoad(_canvas.gameObject);

        // Add CanvasScaler for scaling UI
        var scaler = _canvas.gameObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        // Add GraphicRaycaster for UI interactions
        _canvas.gameObject.AddComponent<GraphicRaycaster>();

        // Create a container for layout groups
        _container = new GameObject("MessageContainer").AddComponent<RectTransform>();
        _container.SetParent(_canvas.transform);
        _container.anchorMin = Vector2.zero;
        _container.anchorMax = Vector2.one;
        _container.offsetMin = Vector2.zero;
        _container.offsetMax = Vector2.zero;

        // Initialize the layout groups dictionary
        _layoutGroups = new Dictionary<Corner, VerticalLayoutGroup>();
        foreach (Corner corner in Enum.GetValues(typeof(Corner)))
        {
            var groupObject = new GameObject($"{corner}Group");
            var groupRect = groupObject.AddComponent<RectTransform>();
            groupRect.SetParent(_container);
            groupRect.localScale = Vector3.one;

            // Configure anchoring and pivot for each corner
            switch (corner)
            {
                case Corner.TopLeft:
                    ConfigureGroupLayout(groupRect, TextAnchor.UpperLeft, new Vector2(0, 1), new Vector2(10, -10));
                    break;
                case Corner.TopRight:
                    ConfigureGroupLayout(groupRect, TextAnchor.UpperRight, new Vector2(1, 1), new Vector2(-10, -10));
                    break;
                case Corner.BottomLeft:
                    ConfigureGroupLayout(groupRect, TextAnchor.LowerLeft, new Vector2(0, 0), new Vector2(10, 10));
                    break;
                case Corner.BottomRight:
                    ConfigureGroupLayout(groupRect, TextAnchor.LowerRight, new Vector2(1, 0), new Vector2(-10, 10));
                    break;
                default:
                    ConfigureGroupLayout(groupRect, TextAnchor.UpperLeft, new Vector2(0, 1), new Vector2(10, -10));
                    break;
            }

            // Ensure the layout group exists before adding to the dictionary
            if (!groupObject.TryGetComponent(out VerticalLayoutGroup layoutGroup))
            {
                layoutGroup = groupObject.AddComponent<VerticalLayoutGroup>();
            }
            _layoutGroups[corner] = layoutGroup;
        }
    }

    /// <summary>
    /// Configures the layout group for a specific corner, setting up anchoring, positioning, and layout properties.
    /// </summary>
    /// <param name="groupRect">The RectTransform to configure.</param>
    /// <param name="alignment">Text alignment for messages in this corner.</param>
    /// <param name="anchor">Anchor point (0-1 normalized coordinates).</param>
    /// <param name="position">Position offset from the anchor point.</param>
    private static void ConfigureGroupLayout(RectTransform groupRect, TextAnchor alignment, Vector2 anchor, Vector2 position)
    {
        groupRect.anchorMin = anchor;
        groupRect.anchorMax = anchor;
        groupRect.pivot = anchor;
        groupRect.anchoredPosition = position;

        var layoutGroup = groupRect.gameObject.GetComponent<VerticalLayoutGroup>();
        if (!layoutGroup)
        {
            layoutGroup = groupRect.gameObject.AddComponent<VerticalLayoutGroup>();
        }

        layoutGroup.spacing = 4f;
        layoutGroup.childAlignment = alignment;
        layoutGroup.childForceExpandWidth = false;
        layoutGroup.childForceExpandHeight = false;
    }

    /// <summary>
    /// Displays a message on the screen.
    /// </summary>
    /// <param name="message">The text of the message.</param>
    /// <param name="duration">How long the message should be displayed (in seconds).</param>
    /// <param name="corner">The corner where the message will appear (top-left, top-right, bottom-left, bottom-right).</param>
    /// <param name="fontSize">The font size of the message text.</param>
    /// <param name="color">The color of the text.</param>
    public void ShowMessage(string message, float duration = 2f, Corner corner = Corner.TopRight, int fontSize = 24, Color? color = null)
    {
        if (!_layoutGroups.TryGetValue(corner, out var layoutGroup) || layoutGroup == null)
        {
            Debug.LogError($"LayoutGroup for corner {corner} is not initialized.");
            return;
        }

        // Create the message text
        var messageObject = new GameObject("Message");
        var text = messageObject.AddComponent<Text>();
        text.text = message;
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        text.fontSize = fontSize;
        text.color = color ?? Color.white;
        text.horizontalOverflow = HorizontalWrapMode.Overflow; // Single line, no wrapping
        text.verticalOverflow = VerticalWrapMode.Overflow;

        // Set alignment based on the corner
        text.alignment = corner switch
        {
            Corner.TopLeft or Corner.BottomLeft => TextAnchor.MiddleLeft // Align left for left corners
            ,
            Corner.TopRight or Corner.BottomRight => TextAnchor.MiddleRight // Align right for right corners
            ,
            _ => text.alignment
        };

        // Add a ContentSizeFitter to auto-resize the message box width
        var contentSizeFitter = messageObject.AddComponent<ContentSizeFitter>();
        contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        // Set as a child of the correct layout group
        var rectTransform = messageObject.GetComponent<RectTransform>();
        rectTransform.SetParent(layoutGroup.transform);
        rectTransform.localScale = Vector3.one;

        // Constrain the width to fit within a maximum size
        var maxWidth = Screen.width * 0.4f; // Maximum width as 40% of screen width
        rectTransform.sizeDelta = new Vector2(maxWidth, rectTransform.sizeDelta.y);

        // Destroy the message after the specified duration
        Destroy(messageObject, duration);
    }

    /// <summary>
    /// Specifies the corners of the screen where a message can be displayed.
    /// </summary>
    public enum Corner
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }
}