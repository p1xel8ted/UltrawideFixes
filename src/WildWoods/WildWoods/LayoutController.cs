namespace WildWoods;

internal class LayoutController : MonoBehaviour
{
    public Patches.Size Size { get; set; }
    private LayoutElement LayoutElement { get; set; }
    private ContentSizeFitter ContentSizeFitter { get; set; }

    private void Awake()
    {
        AddUpdateFitters();
    }

    private void Start()
    {
        AddUpdateFitters();
    }

    private void OnEnable()
    {
        AddUpdateFitters();
    }

    private void AddUpdateFitters()
    {
        LayoutElement = gameObject.TryAddComponent<LayoutElement>();
        ContentSizeFitter = gameObject.TryAddComponent<ContentSizeFitter>();

        UpdateAspect();
    }

    internal void UpdateAspect()
    {
        if (LayoutElement)
        {
            var width = Size switch
            {
                Patches.Size.ConfigBased => Utils.GetHudRes(1080),
                Patches.Size.ForceFullScreen => Mathf.RoundToInt(1080 * Plugin.MainAspect),
                Patches.Size.ForceSixteenNine => Mathf.RoundToInt(1080 * Plugin.NativeAspect),
                _ => Utils.GetHudRes(1080)
            };

            LayoutElement.preferredWidth = width;
        }

        if (ContentSizeFitter)
        {
            ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
    }
}