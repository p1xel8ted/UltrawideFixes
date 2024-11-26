namespace RuinedKingLoL.MonoBehaviours;

public sealed class ScaleForcer : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.localScale = transform.localScale with { x = Plugin.PositiveScaleFactor };
    }
}