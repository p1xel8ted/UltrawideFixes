using System;

namespace PeaksOfYore;

public static class ComponentExtension
{
    public static T CopyComponent<T>(T original, GameObject destination) where T : Component
    {
        var type = original.GetType();
        var copy = destination.AddComponent(type);
        
        foreach (var field in type.GetFields(AccessTools.all))
        {
            field.SetValue(copy, field.GetValue(original));
        }

        foreach (var prop in type.GetProperties(AccessTools.all))
        {
            prop.SetValue(copy,prop.GetValue(original));
        }
     
        return copy as T;
    }
}