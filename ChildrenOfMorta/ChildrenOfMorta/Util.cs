using System;
using System.Collections.Generic;
using UnityEngine;

namespace ChildrenOfMorta;

public static class Util
{
    public static bool TryAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (dictionary == null)
        {
            throw new ArgumentNullException(nameof(dictionary));
        }

        if (dictionary.ContainsKey(key)) return false;
        
        Plugin.Log.LogWarning($"Adding {key} to dictionary with value {value}");
        dictionary.Add(key, value);
        return true;

    }
    // private static Dictionary<int, float> OriginalXPositions { get; } = new();
    //
    // internal static float AdjustXPosition(float originalX, bool moveRight, bool saveIndicator = false)
    // {
    //     const float standardAspectRatio = 16f / 9f;
    //     const float wideAspectRatio = 21f / 9f; // aspect ratio at which we have the known final position
    //     var desiredAspectRatio = GetAspectRatio();
    //
    //     float slope;
    //     if (saveIndicator)
    //     {
    //         // position at 16:9 is 565, position at 21:9 is 780
    //         slope = (780f - 565f) / (wideAspectRatio - standardAspectRatio);
    //     }
    //     else
    //     {
    //         slope = moveRight ? 350f / (desiredAspectRatio - standardAspectRatio) : -220f / (desiredAspectRatio - standardAspectRatio);
    //     }
    //
    //     var adjustment = slope * (desiredAspectRatio - standardAspectRatio);
    //
    //     return originalX + adjustment;
    // }
    //
    // private static float GetAspectRatio()
    // {
    //     var aspectRatio = Display.main.systemWidth / (float) Display.main.systemHeight;
    //     return aspectRatio;
    // }
    //
    //
    // private static Dictionary<string, GameObject> GameObjectCache { get; } = new();
    //
    // internal static void UpdateObjectPosition(string objectPath, bool moveRight, bool saveIndicator = false)
    // {
    //     if (!GameObjectCache.ContainsKey(objectPath) || GameObjectCache[objectPath] == null || GameObjectCache[objectPath].Equals(null))
    //     {
    //         var targetObject = GameObject.Find(objectPath);
    //         if (targetObject != null)
    //         {
    //             GameObjectCache[objectPath] = targetObject;
    //             var id = targetObject.GetInstanceID();
    //             OriginalXPositions[id] = targetObject.transform.localPosition.x;
    //         }
    //     }
    //
    //
    //     if (GameObjectCache.TryGetValue(objectPath, out var cachedObject))
    //     {
    //         var newX = AdjustXPosition(OriginalXPositions[cachedObject.GetInstanceID()], moveRight, saveIndicator);
    //         if (!Mathf.Approximately(cachedObject.transform.localPosition.x, newX))
    //         {
    //             var localPosition = cachedObject.transform.localPosition;
    //             localPosition = new Vector3(newX, localPosition.y, localPosition.z);
    //             cachedObject.transform.localPosition = localPosition;
    //         }
    //     }
    // }
    //
    //
    // public static string GetFullPath(Transform transform)
    // {
    //     string path = transform.name;
    //     while (transform.parent != null)
    //     {
    //         transform = transform.parent;
    //         path = transform.name + "/" + path;
    //     }
    //
    //     return path;
    // }
    //
    // public static List<Transform> FindAllMainTransforms()
    // {
    //     var allTransforms = new List<Transform>();
    //     foreach (var o in Object.FindObjectsOfType(typeof(GameObject)))
    //     {
    //         var obj = (GameObject) o;
    //         if (obj.transform.name == "Main")
    //         {
    //             allTransforms.Add(obj.transform);
    //         }
    //     }
    //
    //     return allTransforms;
    // }
}