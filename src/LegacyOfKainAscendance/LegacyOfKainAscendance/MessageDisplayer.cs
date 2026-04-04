namespace LegacyOfKainAscendance;

/// <summary>
/// Singleton component for displaying temporary on-screen messages at different corner positions.
/// </summary>
public class MessageDisplayer : MonoBehaviour
{
    private static MessageDisplayer _instance;
    private Dictionary<Corner, VerticalLayoutGroup> _layoutGroups;

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

    private void Initialize()
    {
        var canvas = new GameObject("MessageCanvas").AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        DontDestroyOnLoad(canvas.gameObject);

        var scaler = canvas.gameObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        canvas.gameObject.AddComponent<GraphicRaycaster>();

        var container = new GameObject("MessageContainer").AddComponent<RectTransform>();
        container.SetParent(canvas.transform);
        container.anchorMin = Vector2.zero;
        container.anchorMax = Vector2.one;
        container.offsetMin = Vector2.zero;
        container.offsetMax = Vector2.zero;

        _layoutGroups = new Dictionary<Corner, VerticalLayoutGroup>();
        foreach (Corner corner in Enum.GetValues(typeof(Corner)))
        {
            var groupObject = new GameObject($"{corner}Group");
            var groupRect = groupObject.AddComponent<RectTransform>();
            groupRect.SetParent(container);
            groupRect.localScale = Vector3.one;

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

            _layoutGroups[corner] = groupObject.GetComponent<VerticalLayoutGroup>();
        }
    }

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

    public void ShowMessage(string message, float duration = 2f, Corner corner = Corner.TopRight, int fontSize = 24, Color? color = null)
    {
        if (!_layoutGroups.TryGetValue(corner, out var layoutGroup) || layoutGroup == null) return;

        var messageObject = new GameObject("Message");
        var text = messageObject.AddComponent<Text>();
        text.text = message;
        text.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
        text.fontSize = fontSize;
        text.color = color ?? Color.white;
        text.horizontalOverflow = HorizontalWrapMode.Overflow;
        text.verticalOverflow = VerticalWrapMode.Overflow;

        text.alignment = corner switch
        {
            Corner.TopLeft or Corner.BottomLeft => TextAnchor.MiddleLeft,
            Corner.TopRight or Corner.BottomRight => TextAnchor.MiddleRight,
            _ => text.alignment
        };

        var contentSizeFitter = messageObject.AddComponent<ContentSizeFitter>();
        contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
        contentSizeFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        var rectTransform = messageObject.GetComponent<RectTransform>();
        rectTransform.SetParent(layoutGroup.transform);
        rectTransform.localScale = Vector3.one;
        rectTransform.sizeDelta = new Vector2(Screen.width * 0.4f, rectTransform.sizeDelta.y);

        Destroy(messageObject, duration);
    }

    public enum Corner
    {
        TopLeft,
        TopRight,
        BottomLeft,
        BottomRight
    }
}
