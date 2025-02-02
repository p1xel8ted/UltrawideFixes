namespace DarkestDungeon2;

public static class Utils
{
    /// <summary>
    /// Tries to get a component of the specified type from a GameObject. If it doesn't exist, adds it.
    /// </summary>
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }
}