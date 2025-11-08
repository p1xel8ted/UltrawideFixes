namespace WitchSpringR.MonoBehaviours;

public class FieldMenuToggler : MonoBehaviour
{
    private Transform _menu;
    private void Start()
    {
        _menu = transform.FindChild("FieldMenu");
    }

    private void LateUpdate()
    {
        if (!_menu) return;
        
        if (Plugin.FieldMenu.Value)
        {
            _menu.gameObject.SetActive(true);
        }
        else
        {
            _menu.gameObject.SetActive(false);
        }
    }
}