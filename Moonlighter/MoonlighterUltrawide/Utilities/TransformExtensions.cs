using UnityEngine;

namespace MoonlighterUltrawide.Utilities;

/// <summary>
/// Provides extension methods for the <see cref="UnityEngine.Transform"/> class.
/// </summary>
public static class TransformExtensions
{
    /// <summary>
    /// Retrieves the full path of the current transform in the game object hierarchy.
    /// </summary>
    /// <param name="current">The current transform object.</param>
    /// <returns>The full path of the transform, as a string.</returns>
    public static string GetPath(this Transform current)
    {
        return current.parent == null ? current.name : $"{current.parent.GetPath()}/{current.name}";
    }
}