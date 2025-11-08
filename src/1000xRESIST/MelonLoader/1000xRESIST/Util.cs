namespace xRESIST;

public static class Util
{
    public static T TryAddComponent<T>(this GameObject gameObject) where T : Component
    {
        var component = gameObject.GetComponent<T>();
        if (component == null)
        {
            component = gameObject.AddComponent<T>();
        }

        return component;
    }

    // internal static (int simplifiedWidth, int simplifiedHeight) GetGcd(int width, int height)
    // {
    //     while (height != 0)
    //     {
    //         var temp = height;
    //         height = width % height;
    //         width = temp;
    //     }
    //
    //     var simplifiedWidth = Display.main.systemWidth / width;
    //     var simplifiedHeight = Display.main.systemHeight / width;
    //     return (simplifiedWidth, simplifiedHeight);
    // }

    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        // Use long to prevent integer overflow for large resolutions
        resolutions.Sort((a, b) =>
        {
            long pixelsA = (long)a.width * a.height;
            long pixelsB = (long)b.width * b.height;
            return pixelsA.CompareTo(pixelsB);
        });
    }
}