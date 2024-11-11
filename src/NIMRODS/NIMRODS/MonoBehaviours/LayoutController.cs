namespace NIMRODS.MonoBehaviours;

public class LayoutController : MonoBehaviour
{
    public LayoutElement LayoutElement { get; set; }
    public ContentSizeFitter ContentSizeFitter { get; set; }
    
    private void OnEnable()
    {
        LayoutElement = gameObject.TryAddComponent<LayoutElement>();
        ContentSizeFitter = gameObject.TryAddComponent<ContentSizeFitter>();

        var width = GetPreferredWidth();

        LayoutElement.preferredWidth = width;

        ContentSizeFitter.horizontalFit = width == -99 ? ContentSizeFitter.FitMode.Unconstrained : ContentSizeFitter.FitMode.PreferredSize;

        LayoutElement.SetDirty();
        ContentSizeFitter.SetDirty();
        Canvas.ForceUpdateCanvases();
    }
    
    internal static int GetPreferredWidth()
    {
        var width = Plugin.HUDAspect.Value switch
        {
            "16:9" => 1080 * (16f / 9f),
            "21:9" => 1080 * (21f / 9f),
            "21.5:9" => 1080 * (21.5f / 9f),
            "24:10" => 1080 * (24f / 10f),
            "32:9" => 1080 * (32f / 9f),
            "32:10" => 1080 * (32f / 10f),
            "48:9" => 1080 * (48f / 9f),
            "Auto" => -99,
            _ => -99
        };
        return Mathf.RoundToInt(width);
    }

}