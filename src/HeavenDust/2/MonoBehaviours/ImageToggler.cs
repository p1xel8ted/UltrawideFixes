namespace HeavenDustTwo.MonoBehaviours;

public class ImageToggler : MonoBehaviour
{
    private Image _image;
    private void Start()
    {
        _image = GetComponent<Image>();
    }
        
    private void OnEnable()
    {
        _image = GetComponent<Image>();
    }
    
    private void LateUpdate()
    {
        if (_image)
        {
            _image.enabled = Plugin.CameraOverlay.Value;  
        }
    }
}