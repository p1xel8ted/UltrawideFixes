namespace REPLACED.Utils;

public static class Extensions
{
    public static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        return go.GetComponent<T>() ?? go.AddComponent<T>();
    }
}
