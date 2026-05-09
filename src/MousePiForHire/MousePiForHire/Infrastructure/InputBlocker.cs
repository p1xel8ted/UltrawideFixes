using ConfigurationManager;

namespace MousePiForHire.Infrastructure;

// Disables the game's input action maps while ConfigurationManager's window is open, so mouse,
// keyboard and gamepad don't bleed into the game while the player is changing settings.
internal sealed class InputBlocker
{
    private readonly CMPlugin _cm;
    private readonly List<InputActionMap> _restoreOnClose = [];

    public InputBlocker()
    {
        if (!Chainloader.PluginInfos.TryGetValue(CMPlugin.GUID, out var info)) return;
        _cm = info.Instance as CMPlugin;
        if (!_cm) return;
        _cm.DisplayingWindowChanged += OnDisplayingWindowChanged;
        Plugin.Log.LogInfo("[InputBlocker] Subscribed to ConfigurationManager.DisplayingWindowChanged.");
    }

    private void OnDisplayingWindowChanged(object sender, ValueChangedEventArgs<bool> e)
    {
        if (e.NewValue) Disable();
        else Restore();
    }

    private void Disable()
    {
        var asset = Singleton<InputManager>.Instance?.Controls?.asset;
        if (!asset) return;
        _restoreOnClose.Clear();
        foreach (var map in asset.actionMaps.Where(map => map.enabled))
        {
            _restoreOnClose.Add(map);
            map.Disable();
        }
        Plugin.Log.LogInfo($"[InputBlocker] CM opened: disabled {_restoreOnClose.Count} action map(s).");
    }

    private void Restore()
    {
        foreach (var map in _restoreOnClose) map.Enable();
        Plugin.Log.LogInfo($"[InputBlocker] CM closed: re-enabled {_restoreOnClose.Count} action map(s).");
        _restoreOnClose.Clear();
    }
}
