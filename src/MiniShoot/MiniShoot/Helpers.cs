namespace MiniShoot;

/// <summary>
/// Provides utility functions to support the MiniShoot game operations.
/// </summary>
public static class Helpers
{
    /// <summary>
    /// Calculates the greatest common divisor (GCD) of two numbers (width and height), 
    /// and uses it to simplify these dimensions by the display's system width and height.
    /// </summary>
    /// <param name="width">The width to be simplified based on the GCD.</param>
    /// <param name="height">The height to be simplified based on the GCD.</param>
    /// <returns>
    /// A tuple containing two integers: the simplified width and height.
    /// These are calculated by dividing the system's width and height by the GCD of the input dimensions.
    /// </returns>
    internal static (int simplifiedWidth, int simplifiedHeight) GetGcd(int width, int height)
    {
        // Loop to find the GCD of width and height
        while (height != 0)
        {
            var temp = height;
            height = width % height; // Update height to remainder of width divided by height
            width = temp; // Update width to previous height
        }

        // Calculate simplified dimensions by dividing display's dimensions by the GCD
        var simplifiedWidth = Plugin.MainWidth / width;
        var simplifiedHeight = Plugin.MainHeight / width;
        return (simplifiedWidth, simplifiedHeight);
    }
}