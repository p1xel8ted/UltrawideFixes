using System;
using System.Collections.Generic;
using UnityEngine;
using CollectionExtensions = System.Collections.Generic.CollectionExtensions;

namespace HerosAdventureRoadToPassionUltraWide;

public static class Extensions
{

    public static void SetAnchoredPosition(this Transform transform, Vector2 position)
    {
        if (!transform) return;
        var rectTransform = transform.GetComponent<RectTransform>();
        if (rectTransform)
        {
            rectTransform.anchoredPosition = position;
        }
        else
        {
            transform.localPosition = new Vector3(position.x, position.y, transform.localPosition.z);
        }
    }

    public static void SetLocalPosition(this Transform transform, Vector2 position)
    {
        transform.localPosition = new Vector3(position.x, position.y, transform.localPosition.z);
    }
    
    public static void SetLocalPosition(this GameObject gameObject, Vector2 position)
    {
        gameObject.transform.localPosition = new Vector3(position.x, position.y, gameObject.transform.localPosition.z);
    }

    public static void SetAnchoredPosition(this GameObject gameObject, Vector2 position)
    {
        var rectTransform = gameObject.GetComponent<RectTransform>();
        if (rectTransform)
        {
            rectTransform.anchoredPosition = position;
        }
        else
        {
            gameObject.transform.localPosition = new Vector3(position.x, position.y, gameObject.transform.localPosition.z);
        }
    }



    public static string GetGameObjectPath(this GameObject obj)
    {
        var path = obj.name;
        var parent = obj.transform.parent;
        while (parent)
        {
            path = parent.name + "/" + path;
            parent = parent.parent;
        }

        return path;
    }
    
    // Extension method to find all child transforms with the given name.
    public static List<Transform> FindChildrenByName(this Transform parent, string name)
    {
        List<Transform> foundChildren = [];
        FindChildrenByNameRecursive(parent, name, ref foundChildren);
        return foundChildren;
    }
    // Extension method to find the first child transform with the given name.
    public static Transform FindFirstChildByName(this Transform parent, string name)
    {
        return FindFirstChildByNameRecursive(parent, name);
    }

    // Recursive helper function to search for the first child with the given name.
    private static Transform FindFirstChildByNameRecursive(Transform current, string name)
    {
        foreach (var o in current)
        {

            var child = o.TryCast<Transform>();

            if (child && child.name == name)
            {
                return child;
            }

            var foundChild = FindFirstChildByNameRecursive(child, name);
            if (foundChild)
            {
                return foundChild;
            }
        }

        // Return null if no child with the given name is found.
        return null;
    }

    // Recursive helper function to search for children with the given name.
    private static void FindChildrenByNameRecursive(Transform current, string name, ref List<Transform> foundChildren)
    {
        foreach (var o in current)
        {

            var child = o.TryCast<Transform>();

            if (child && child.name == name)
            {
                foundChildren.Add(child);
            }
            // Recurse into each child.
            FindChildrenByNameRecursive(child, name, ref foundChildren);
        }
    }
    public static bool TryGetComponentsInChildren<T>(this Transform transform, out List<T> components) where T : Component
    {
        components = [..transform.GetComponentsInChildren<T>()];
        return components != null;
    }


    public static bool TryGetChildren<T>(this Transform transform, out List<T> components) where T : Component
    {
        components = [..transform.GetComponentsInChildren<T>()];
        return components != null;
    }


    public static bool TryGetComponents<T>(this Transform transform, out List<T> components) where T : Component
    {
        components = [..transform.GetComponents<T>()];
        return components != null;
    }

    public static bool TryGetComponentInChildren<T>(this Transform transform, out T component) where T : Component
    {
        component = transform.GetComponentInChildren<T>();
        return component;
    }

    public static bool TryGetComponent<T>(this Transform transform, out T component) where T : Component
    {
        component = transform.GetComponent<T>();
        return component;
    }

    public static bool TryGetComponentsInChildren<T>(this GameObject gameObject, out List<T> components) where T : Component
    {
        components = [..gameObject.GetComponentsInChildren<T>()];
        return components != null;
    }

    public static bool TryGetComponents<T>(this GameObject gameObject, out List<T> components) where T : Component
    {
        components = [..gameObject.GetComponents<T>()];
        return components != null;
    }

    public static bool TryGetComponentInChildren<T>(this GameObject gameObject, out T component) where T : Component
    {
        component = gameObject.GetComponentInChildren<T>();
        return component;
    }

    public static bool TryGetComponent<T>(this GameObject gameObject, out T component) where T : Component
    {
        component = gameObject.GetComponent<T>();
        return component;
    }
    public static bool Contains(this string source, string toCheck, StringComparison comp = StringComparison.InvariantCultureIgnoreCase)
    {
        return source?.IndexOf(toCheck, comp) >= 0;
    }
    
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


        if (gameObject.GetComponent<T>())
        {
            return component;
        }

        // Add the component since it doesn't exist
        return gameObject.AddComponent<T>();
    }
}