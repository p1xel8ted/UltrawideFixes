namespace xMysticSurvivor;

public static class ExtensionMethods
{
    public static T CopyComponent<T>(this T original, GameObject destination) where T : Component
    {
        var type = original.GetType();
        var copy = destination.AddComponent(type) as T;
        
        var flags = AccessTools.all;

        foreach (var field in type.GetFields(flags))
        {
            if (field.IsStatic) continue;
            try
            {
                field.SetValue(copy, field.GetValue(original));
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error copying the field {field.Name}: {ex.Message}");
            }
        }

        foreach (var prop in type.GetProperties(flags))
        {
            if (!prop.CanWrite || prop.GetSetMethod(true) == null || prop.GetGetMethod(true) == null) continue;

            try
            {
                var value = prop.GetValue(original, null);
                prop.SetValue(copy, value, null);
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error copying the property {prop.Name}: {ex.Message}");
            }
        }

        return copy;
    }
    public static void ResizeRect(this GameObject go)
    {
        var rectTransform = go.GetComponent<RectTransform>();
        if (rectTransform.sizeDelta == Vector2.zero)
        {
            Plugin.LOG.LogWarning($"ResizeRect: {go.name} has a size of 0, skipping.");
            return;
        }

        var y = rectTransform.sizeDelta.y;
        var x = y * Plugin.MainAspect;
        rectTransform.sizeDelta = new Vector2(x, y);
    }
    
    public static T TryAddComponent<T>(this GameObject go) where T : Component
    {
        var component = go.GetComponent<T>();
        if (!component)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }
}