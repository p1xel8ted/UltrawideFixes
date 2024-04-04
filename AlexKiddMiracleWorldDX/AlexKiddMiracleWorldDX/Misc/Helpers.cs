using UnityEngine;

namespace AlexKiddMiracleWorldDX.Misc;

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

        var simplifiedWidth = Display.main.systemWidth / width;
        var simplifiedHeight = Display.main.systemHeight / width;
        return (simplifiedWidth, simplifiedHeight);
    }

}