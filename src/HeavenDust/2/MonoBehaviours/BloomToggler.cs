namespace HeavenDustTwo.MonoBehaviours;

public class BloomToggler : MonoBehaviour
{
    private BloomOptimized _bloom;
    private void Start()
    {
        _bloom = GetComponent<BloomOptimized>();
    }
        
    private void OnEnable()
    {
        _bloom = GetComponent<BloomOptimized>();
    }
    
    private void LateUpdate()
    {
        if (_bloom)
        {
            _bloom.enabled = Plugin.Bloom.Value;  
        }
    }
}