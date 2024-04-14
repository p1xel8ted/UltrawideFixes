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
}