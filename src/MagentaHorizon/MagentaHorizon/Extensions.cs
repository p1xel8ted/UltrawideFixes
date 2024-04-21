using System;

namespace MagentaHorizon;

public static class Extensions
{

    // Attempts to add a component of type T to the GameObject if it doesn't already have one.
    // Returns true if the component was added, false otherwise.
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        if (!gameObject)
        {
            throw new ArgumentNullException(nameof(gameObject));
        }

        // Check if the GameObject already has the component
        var component = gameObject.GetComponent<T>();
        
        return gameObject.GetComponent<T>() ? component : gameObject.AddComponent<T>();
    }
}