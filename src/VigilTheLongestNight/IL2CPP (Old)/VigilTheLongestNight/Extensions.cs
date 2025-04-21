namespace VigilTheLongestNight;

public static class Extensions
{
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        if (!gameObject)
        {
            throw new ArgumentNullException(nameof(gameObject));
        }
        
        var component = gameObject.GetComponent<T>();
        
        return gameObject.GetComponent<T>() ? component :
            gameObject.AddComponent<T>();
    }
    
    public static string GetPath(this Transform transform)
    {
        if (!transform)
        {
            throw new ArgumentNullException(nameof(transform));
        }
        
        var path = transform.name;
        while (transform.parent)
        {
            transform = transform.parent;
            path = $"{transform.name}/{path}";
        }

        return path;
    }
}