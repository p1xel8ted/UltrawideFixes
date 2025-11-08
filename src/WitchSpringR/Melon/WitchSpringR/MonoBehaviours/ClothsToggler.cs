namespace WitchSpringR.MonoBehaviours;

public class ClothsToggler : MonoBehaviour
{
    private Transform _skirt, _hat, _robe, _staff;
    private bool _lastStaffState, _lastSkirtState, _lastHatState, _lastRobeState;

    // Cache preference values to avoid repeated property access
    private bool _cachedShowStaff, _cachedShowSkirt, _cachedShowHat, _cachedShowRobe;

    private void Start()
    {
        MelonLogger.Msg($"Cloths Toggler started on {gameObject.name}");
        _skirt = transform.Find("body_skirt");
        _hat = transform.Find("hat");
        _robe = transform.Find("robe");
        _staff = transform.Find("Bip001/Bip001 Pelvis/Bip001 Spine");

        // Cache initial preference values
        UpdateCachedPreferences();

        // Subscribe to preference changes for reactive updates
        Mod.ShowStaff.OnEntryValueChanged.Subscribe((_, newValue) => { _cachedShowStaff = newValue; });
        Mod.ShowSkirt.OnEntryValueChanged.Subscribe((_, newValue) => { _cachedShowSkirt = newValue; });
        Mod.ShowHat.OnEntryValueChanged.Subscribe((_, newValue) => { _cachedShowHat = newValue; });
        Mod.ShowRobe.OnEntryValueChanged.Subscribe((_, newValue) => { _cachedShowRobe = newValue; });

        UpdateClothState(true);
    }

    private void UpdateCachedPreferences()
    {
        _cachedShowStaff = Mod.ShowStaff.Value;
        _cachedShowSkirt = Mod.ShowSkirt.Value;
        _cachedShowHat = Mod.ShowHat.Value;
        _cachedShowRobe = Mod.ShowRobe.Value;
    }

    private void LateUpdate()
    {
        UpdateClothState();
    }

    private void UpdateClothState(bool forceUpdate = false)
    {
        // Use cached values and add null checks
        if (_staff != null)
            SetActiveIfChanged(_staff.gameObject, _cachedShowStaff, ref _lastStaffState, forceUpdate);
        if (_skirt != null)
            SetActiveIfChanged(_skirt.gameObject, _cachedShowSkirt, ref _lastSkirtState, forceUpdate);
        if (_hat != null)
            SetActiveIfChanged(_hat.gameObject, _cachedShowHat, ref _lastHatState, forceUpdate);
        if (_robe != null)
            SetActiveIfChanged(_robe.gameObject, _cachedShowRobe, ref _lastRobeState, forceUpdate);
    }

    private static void SetActiveIfChanged(GameObject obj, bool currentState, ref bool lastState, bool forceUpdate = false)
    {
        if (currentState != lastState || forceUpdate)
        {
            obj.SetActive(currentState);
            lastState = currentState;
        }
    }
}