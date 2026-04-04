namespace FutureKnight;

public static class Utils
{
    public static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        if (go.TryGetComponent<T>(out var comp))
        {
            return comp;
        }

        return go.AddComponent<T>();
    }
}
