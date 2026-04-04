namespace SeaOfStars.Components;

public class EventSystemSwitcher : MonoBehaviour
{
    private EventSystem _gameEventSystem;
    private EventSystem _universeLibEventSystem;
    private List<GraphicRaycaster> _cachedRaycasters;
    private PointerEventData _pointerData;
    private readonly Il2CppSystem.Collections.Generic.List<RaycastResult> _raycastResults = new();
    private bool _cached;
    private bool _loggedFailure;

    private void Awake()
    {
        _cachedRaycasters = new List<GraphicRaycaster>();
    }

    private void Update()
    {
        if (!_cached && !CacheEventSystems()) return;

        // Keep both enabled - prevent UniverseLib from disabling game's EventSystem
        if (_gameEventSystem && !_gameEventSystem.enabled)
        {
            _gameEventSystem.enabled = true;
        }

        if (_universeLibEventSystem && !_universeLibEventSystem.enabled)
        {
            _universeLibEventSystem.enabled = true;
        }

        EventSystem.current = IsPointerOverUniverseLibUI() ? _universeLibEventSystem : _gameEventSystem;
    }

    private static bool IsUniverseLibName(string name)
    {
        return name.Contains(Core.Constants.Sinai, StringComparison.OrdinalIgnoreCase) ||
               name.Contains(Core.Constants.UniverseLib, StringComparison.OrdinalIgnoreCase);
    }

    private bool IsPointerOverUniverseLibUI()
    {
        if (_cachedRaycasters.Count == 0) return false;

        _pointerData.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        foreach (var raycaster in _cachedRaycasters)
        {
            if (!raycaster || !raycaster.isActiveAndEnabled) continue;

            _raycastResults.Clear();
            raycaster.Raycast(_pointerData, _raycastResults);
            if (_raycastResults.Count > 0) return true;
        }

        return false;
    }

    private bool CacheEventSystems()
    {
        _gameEventSystem = null;
        _universeLibEventSystem = null;
        _cachedRaycasters.Clear();

        var allEventSystems = Utilities.Utilities.FindIl2CppType<EventSystem>();
        foreach (var es in allEventSystems)
        {
            if (!es) continue;

            if (IsUniverseLibName(es.name))
            {
                _universeLibEventSystem = es;
            }
            else
            {
                _gameEventSystem ??= es;
            }
        }

        if (!_gameEventSystem || !_universeLibEventSystem)
        {
            if (!_loggedFailure)
            {
                _loggedFailure = true;
                var found = string.Join(", ", allEventSystems.Where(es => es).Select(es => $"'{es.name}'"));
                Plugin.Logger.LogWarning($"EventSystemSwitcher: Could not find both EventSystems. Game={_gameEventSystem != null}, UniverseLib={_universeLibEventSystem != null}. Found: [{found}]");
            }

            return false;
        }

        var allRaycasters = Utilities.Utilities.FindIl2CppType<GraphicRaycaster>();
        foreach (var rc in allRaycasters)
        {
            if (!rc) continue;

            if (IsUniverseLibName(rc.name))
            {
                _cachedRaycasters.Add(rc);
            }
        }

        Plugin.Logger.LogInfo($"EventSystemSwitcher: Cached game='{_gameEventSystem.name}', universeLib='{_universeLibEventSystem.name}', {_cachedRaycasters.Count} raycaster(s)");
        _pointerData = new PointerEventData(_universeLibEventSystem);
        _cached = true;
        return true;
    }

    private void OnDisable()
    {
        if (_gameEventSystem)
        {
            EventSystem.current = _gameEventSystem;
        }

        _cached = false;
        _loggedFailure = false;
        _pointerData = null;
    }
}
