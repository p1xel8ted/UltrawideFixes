namespace HeavenDustTwo.Misc;

public static class Extensions
{
    public static Transform FindDeepChild(this Transform parent, string name)
    {
        foreach (Transform child in parent)
        {
            if (child && child.name == name)
                return child;

            var result = child.FindDeepChild(name);
            if (result) return result;
        }
        return null;
    }
}