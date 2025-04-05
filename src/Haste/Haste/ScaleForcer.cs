namespace Haste;

//hacky solution to override animator scale
internal class ScaleForcer : MonoBehaviour
{
    
    private static readonly WriteOnce<float> OriginalScaleMain = new();
    private static readonly WriteOnce<float> OriginalScaleBox = new();
    private static readonly WriteOnce<float> OriginalScaleTeir = new();

    private Transform _box;
    private Transform _tier;

    private void OnEnable()
    {
        _box = transform.Find("Anim/Box");
        _tier = transform.Find("Anim/TeirDisplay");
    }

    private void LateUpdate()
    {
        if (Plugin.CurrentAspect <= 3f) return;
        
        OriginalScaleMain.Value = transform.localScale.x;

        transform.localScale = Plugin.CurrentAspect switch
        {
            >= 5.3f => new Vector3(2.1f, 1f, 1f),
            >= 3.5f => new Vector3(1.5f, 1f, 1f),
            _ => new Vector3(OriginalScaleMain.Value, 1f, 1f)
        };

        if (_box)
        {
            OriginalScaleBox.Value = _box.localScale.x;

            _box.localScale = Plugin.CurrentAspect switch
            {
                >= 5.3f => new Vector3(0.5f, 1f, 1f),
                >= 3.5f => new Vector3(0.7f, 1f, 1f),
                _ => new Vector3(OriginalScaleBox.Value, 1f, 1f)
            };
        }

        if (_tier)
        {
            OriginalScaleTeir.Value = _tier.localScale.x;
            _tier.localScale = Plugin.CurrentAspect switch
            {
                >= 5.3f => new Vector3(0.5f, 1f, 1f),
                >= 3.5f => new Vector3(0.7f, 1f, 1f),
                _ => new Vector3(OriginalScaleTeir.Value, 1f, 1f)
            };
        }
    }
}