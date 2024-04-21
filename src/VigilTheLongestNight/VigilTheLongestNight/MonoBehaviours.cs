namespace VigilTheLongestNight;


public class MonoBehaviours : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(Plugin.ReloadConfigKeybind.Value))
        {
            Plugin.ConfigInstance.Reload();
            return;
        }
        
        if (Input.GetKeyDown(Plugin.ToggleHudSpanning.Value))
        {
            Plugin.SpannedHUD.Value = !Plugin.SpannedHUD.Value;
            Plugin.ConfigInstance.Reload();
            return;
        }
    }
}