namespace BAKERU.MonoBehaviours;

internal class LayoutController : MonoBehaviour
{
    private static readonly List<LayoutController> LayoutControllers = [];
    public Patches.Patches.Size Size { get; set; }
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
        LayoutControllers.Add(this);
        UpdateAspect();
    }

    internal static void RefreshLayoutControllers()
    {
        foreach (var lc in LayoutControllers.Where(a => a))
        {
            lc.UpdateAspect();
        }
    }

    internal void UpdateAspect()
    {
        if (LayoutElement)
        {
            var height = Resolutions.SelectedResolution.height;
            var width = Size switch
            {
                Patches.Patches.Size.ConfigBased => Utils.GetHudRes(height),
                Patches.Patches.Size.ForceFullScreen => Mathf.RoundToInt(height * Plugin.CurrentAspect),
                Patches.Patches.Size.ForceSixteenNine => Mathf.RoundToInt(height * Plugin.NativeAspect),
                _ => Utils.GetHudRes(height)
            };

            LayoutElement.preferredWidth = width;
        }

        if (ContentSizeFitter)
        {
            ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
    }
}