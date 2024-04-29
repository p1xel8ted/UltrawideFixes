using System;
using System.Reflection;
using UnityEngine;

namespace xMysticSurvivor;


public static class Copy
{
    public static T CopyComponent<T>(T original, GameObject destination) where T : Component
    {
        Type type = original.GetType();
        T copy = destination.AddComponent(type) as T;

        // Binding flags to include both public and non-public instance fields/properties
        BindingFlags flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;

        foreach (FieldInfo field in type.GetFields(flags))
        {
            if (field.IsStatic) continue; // Skip static fields
            try
            {
                field.SetValue(copy, field.GetValue(original));
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error copying the field {field.Name}: {ex.Message}");
            }
        }

        foreach (PropertyInfo prop in type.GetProperties(flags))
        {
            if (!prop.CanWrite || prop.GetSetMethod(true) == null || prop.GetGetMethod(true) == null) continue; // Skip properties that cannot be written to or are without getters/setters

            try
            {
                object value = prop.GetValue(original, null);
                prop.SetValue(copy, value, null);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error copying the property {prop.Name}: {ex.Message}");
            }
        }

        return copy;
    }

}