using System.Collections.Generic;
using UnityEngine;

namespace MoonlighterUltrawide.Utilities;

/// <summary>
/// A utility class providing helper methods for finding game objects.
/// </summary>
public static class Helpers
{
    /// <summary>
    /// Finds all game objects in a given path.
    /// </summary>
    /// <param name="path">The path where to search for game objects.</param>
    /// <returns>An enumerable collection of game objects located at the given path.</returns>
    internal static IEnumerable<GameObject> FindObjectsInPath(string path)
    {
        return Object.FindObjectsOfType<Transform>()
            .Where(t => t.GetPath().Contains(path))
            .Select(t => t.gameObject)
            .ToArray();
    }

    /// <summary>
    /// Finds all game objects with a specified name.
    /// </summary>
    /// <param name="name">The name of the game objects to search for.</param>
    /// <param name="beginsWith">A flag indicating whether to match the start of the game object names. Defaults to false.</param>
    /// <returns>An enumerable collection of game objects with the specified name.</returns>
    internal static IEnumerable<GameObject> FindObjects(string name, bool beginsWith = false)
    {
        if (beginsWith)
        {
            return Object.FindObjectsOfType<Transform>()
                .Where(t => t.name.StartsWith(name))
                .Select(t => t.gameObject)
                .ToArray();
        }

        return Object.FindObjectsOfType<Transform>()
            .Where(t => t.name.Equals(name))
            .Select(t => t.gameObject)
            .ToArray();
    }
}