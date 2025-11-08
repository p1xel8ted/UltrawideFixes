namespace WitchSpringR.MonoBehaviours;

public class FieldMenuToggler : MonoBehaviour
{
    private Transform _menu;

    // Cache preference value to avoid repeated property access every frame
    private bool _cachedFieldMenuEnabled;
    private bool _lastFieldMenuState;

    private void Start()
    {
        _menu = transform.FindChild("FieldMenu");

        if (!_menu)
        {
            MelonLogger.Warning($"FieldMenu not found on {gameObject.name}");
            return;
        }

        // Cache initial preference value
        _cachedFieldMenuEnabled = Mod.FieldMenu.Value;
        _lastFieldMenuState = _cachedFieldMenuEnabled;

        // Subscribe to preference changes for reactive updates
        Mod.FieldMenu.OnEntryValueChanged.Subscribe((_, newValue) => { _cachedFieldMenuEnabled = newValue; });

        // Set initial state
        _menu.gameObject.SetActive(_cachedFieldMenuEnabled);
    }

    private void LateUpdate()
    {
        if (!_menu) return;

        // Only call SetActive when the value actually changes
        if (_cachedFieldMenuEnabled != _lastFieldMenuState)
        {
            _menu.gameObject.SetActive(_cachedFieldMenuEnabled);
            _lastFieldMenuState = _cachedFieldMenuEnabled;
        }
    }
}