namespace BingWonderland;

public static class Helpers
{
    internal static (int simplifiedWidth, int simplifiedHeight) GetGcd(int width, int height)
    {
        while (height != 0)
        {
            var temp = height;
            height = width % height;
            width = temp;
        }

        var simplifiedWidth = Plugin.MainWidth / width;
        var simplifiedHeight = Plugin.MainHeight / width;
        return (simplifiedWidth, simplifiedHeight);
    }

}