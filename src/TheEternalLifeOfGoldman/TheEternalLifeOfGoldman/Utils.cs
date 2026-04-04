// Utils.cs — Shared helper methods and GameObject extension methods.
// Provides resolution/fullscreen enforcement helpers used by Screen.SetResolution patches.
// Extension methods: GetPath() returns the full transform hierarchy path for logging,
// TryAddComponent<T>() safely adds a component or returns the existing one.

namespace TheEternalLifeOfGoldman;

internal static class Utils
{

    extension(GameObject obj)
    {
        internal string GetPath()
        {
            if (obj == null) return string.Empty;
            var path = obj.name;
            var current = obj.transform.parent;
            while (current != null)
            {
                path = current.name + "/" + path;
                current = current.parent;
            }

            return path;
        }

        internal T TryAddComponent<T>() where T : Component
        {
            if (obj == null) return null;
            var existing = obj.GetComponent<T>();
            return existing != null ? existing : obj.AddComponent<T>();
        }
    }
}