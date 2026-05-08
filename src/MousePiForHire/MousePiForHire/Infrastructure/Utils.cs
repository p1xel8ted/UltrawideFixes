namespace MousePiForHire;

// Shared extension helpers.
public static class Utils
{
    // GetOrAdd: reuses existing T or adds one. Use over AddComponent<T>() in code paths that may
    // re-fire (OnEnable / postfixes), since AddComponent silently stacks duplicates.
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        return go.TryGetComponent<T>(out var existing) ? existing : go.AddComponent<T>();
    }
}