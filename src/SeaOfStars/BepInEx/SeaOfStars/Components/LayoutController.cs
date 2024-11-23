namespace SeaOfStars.Components;

public class LayoutController : MonoBehaviour
{
    internal LayoutElement LayoutElement;
    internal ContentSizeFitter ContentSizeFitter;
    internal float OriginalPreferredWidth;
    public bool Ignore { get; set; }
}