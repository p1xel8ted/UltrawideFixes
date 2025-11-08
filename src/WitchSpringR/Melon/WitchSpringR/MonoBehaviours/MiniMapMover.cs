namespace WitchSpringR.MonoBehaviours;

public class MiniMapMover : MonoBehaviour
{
    // Minimap size constants - these correspond to different zoom levels
    private const float MINIMAP_SIZE_SMALL = 380f;
    private const float MINIMAP_SIZE_MEDIUM = 570f;
    private const float MINIMAP_SIZE_LARGE = 760f;
    private const float MINIMAP_SIZE_XLARGE = 950f;

    private const float BASE_Y_POSITION = 30f;
    private const float KEY_Y_POSITION = 75f;

    private RectTransform _rectTransform;
    private Transform _parent;
    private Transform _key;

    // Cache preference value to avoid repeated property access
    private bool _cachedSpanHud;

    private void Start()
    {
        MelonLogger.Msg($"Mini Map Mover started on {gameObject.name}");
        _rectTransform = GetComponent<RectTransform>();
        _parent = transform.parent;
        _key = _parent?.Find("Key"); // Null-safe Find

        // Cache initial preference value
        _cachedSpanHud = Mod.SpanHud.Value;

        // Subscribe to preference changes
        Mod.SpanHud.OnEntryValueChanged.Subscribe((_, newValue) => { _cachedSpanHud = newValue; });
    }

    private void LateUpdate()
    {
        if (_parent == null) return;

        var newX = _rectTransform.sizeDelta.x;
        float newY = BASE_Y_POSITION;

        if (!HandlePositionAdjustment(ref newX, ref newY)) return;

        // Early exit if SpanHud hasn't changed and position is already correct
        var xPosition = _cachedSpanHud ? newX : Mod.NativeDisplayWidth - Mod.BlackBarSize;

        UpdatePosition(xPosition, newY, KEY_Y_POSITION);
    }

    private static bool HandlePositionAdjustment(ref float newX, ref float newY)
    {
        switch (newX)
        {
            case MINIMAP_SIZE_SMALL:
                newX = Mod.NativeDisplayWidth;
                return true;
            case MINIMAP_SIZE_MEDIUM:
                newX = Mod.NativeDisplayWidth - 100;
                newY += 95;
                return true;
            case MINIMAP_SIZE_LARGE:
                newX = Mod.NativeDisplayWidth - 200;
                newY += 190;
                return true;
            case MINIMAP_SIZE_XLARGE:
                newX = Mod.NativeDisplayWidth - 300;
                newY += 285;
                return true;
            default:
                return false;
        }
    }

    private void UpdatePosition(float x, float y, float keyY)
    {
        if (!Mathf.Approximately(_parent.position.x, x) || !Mathf.Approximately(_parent.position.y, y))
        {
            _parent.position = new Vector3(x, y, _parent.position.z);
        }

        // Null check for _key before using it
        if (_key != null && !Mathf.Approximately(_key.position.y, keyY))
        {
            _key.position = new Vector3(_key.position.x, keyY, _key.position.z);
        }
    }
}