namespace HeavenDustTwo.MonoBehaviours;

public class FogOfWarLegacyController : MonoBehaviour
{
    private FogOfWarLegacy fw;
    private void Start()
    {
        fw = GetComponent<FogOfWarLegacy>();
    }
    
    private void OnEnable()
    {
        fw = GetComponent<FogOfWarLegacy>();
    }

    private void LateUpdate()
    {
        if (!fw) return;
        fw.enabled = Plugin.FogOfWar.Value;
    }
}