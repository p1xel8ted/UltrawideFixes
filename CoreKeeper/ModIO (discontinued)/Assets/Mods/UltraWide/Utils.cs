using UnityEngine;

namespace Mods.UltraWide
{
    public static class Utils
    {
        internal static int CalculateMaxWidth()
        {
            var aspect = Display.main.systemWidth / (float) Display.main.systemHeight;

            // Define your reference points (16:9 and 3440x1440)
            const float minAspect = 16f / 9f;  
            const float refAspect = 3440f / 1440f; // Actual aspect ratio for 3440x1440

            const float minWidth = 480;
            const float refWidth = 648; // Corresponding width value for the reference aspect

            float maxWidth;

            // If the aspect is less than or equal to the reference aspect (3440x1440)
            if (aspect <= refAspect)
            {
                // Interpolate between minWidth (480) and refWidth (648) based on the aspect ratio
                var t = (aspect - minAspect) / (refAspect - minAspect);
                maxWidth = minWidth + (refWidth - minWidth) * t;
            }
            else
            {
                // If the aspect is larger than the reference aspect, scale proportionally
                maxWidth = refWidth * (aspect / refAspect);
            }

            // Increase by 2% and round
            var roundedMaxWidth = Mathf.RoundToInt(maxWidth * 1.02f);

            return roundedMaxWidth;
        } 
    }
}