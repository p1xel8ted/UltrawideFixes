namespace Snufkin;

public static class Util
{
    
    internal static (int simplifiedWidth, int simplifiedHeight) GetGcd(int width, int height)
    {
        while (height != 0)
        {
            var temp = height;
            height = width % height;
            width = temp;
        }

        var simplifiedWidth = Display.main.systemWidth / width;
        var simplifiedHeight = Display.main.systemHeight / width;
        return (simplifiedWidth, simplifiedHeight);
    }
    
    internal static void SortByPixelCount(this List<Resolution> resolutions)
    {
        resolutions.Sort((a, b) => a.width * a.height - b.width * b.height);
    }

}