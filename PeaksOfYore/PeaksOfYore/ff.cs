using System;

namespace PeaksOfYore;

public static class ComponentExtension
{
    public static T CopyComponent<T>(T original, GameObject destination) where T : Component
    {
        Type type = original.GetType();
        Component copy = destination.AddComponent(type);
        
        // Copy each Field
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            field.SetValue(copy, field.GetValue(original));
        }

        // Optionally, you could also copy properties if necessary.
        return copy as T;
    }
}