namespace MousePiForHire.Infrastructure;

// Shared extension helpers.
public static class Utils
{
    // Returns the existing component if there is one, otherwise adds a new one. Safer than
    // AddComponent in code that runs more than once - AddComponent will silently stack duplicates.
    internal static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        return go.TryGetComponent<T>(out var existing) ? existing : go.AddComponent<T>();
    }
}