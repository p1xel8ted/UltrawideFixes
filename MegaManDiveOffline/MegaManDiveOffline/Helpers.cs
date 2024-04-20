namespace MegaManDiveOffline;

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

        var simplifiedWidth = Plugin.SelectedWidth / width;
        var simplifiedHeight = Plugin.SelectedHeight / width;
        return (simplifiedWidth, simplifiedHeight);
    }
}