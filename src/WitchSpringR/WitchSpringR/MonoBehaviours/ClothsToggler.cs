namespace WitchSpringR.MonoBehaviours;

public class ClothsToggler : MonoBehaviour
{
    private Transform _skirt, _hat, _robe, _staff;
    private bool _lastStaffState, _lastSkirtState, _lastHatState, _lastRobeState;

    private void Start()
    {
        Plugin.Logger.LogInfo($"Cloths Toggler started on {gameObject.name}");
        _skirt = transform.Find("body_skirt");
        _hat = transform.Find("hat");
        _robe = transform.Find("robe");
        _staff = transform.Find("Bip001/Bip001 Pelvis/Bip001 Spine");
            
        UpdateClothState(true);
    }
        
    private void LateUpdate()
    {
        UpdateClothState();
    }

    private void UpdateClothState(bool forceUpdate = false)
    {
        SetActiveIfChanged(_staff.gameObject, Plugin.ShowStaff.Value, ref _lastStaffState, forceUpdate);
        SetActiveIfChanged(_skirt.gameObject, Plugin.ShowSkirt.Value, ref _lastSkirtState, forceUpdate);
        SetActiveIfChanged(_hat.gameObject, Plugin.ShowHat.Value, ref _lastHatState, forceUpdate);
        SetActiveIfChanged(_robe.gameObject, Plugin.ShowRobe.Value, ref _lastRobeState, forceUpdate);
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