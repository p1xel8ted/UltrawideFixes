namespace AI_Limit.Misc;

public static class Configuration
{
    public static ConfigEntry<bool> RunInBackground { get; set; }
    public static ConfigEntry<bool> MuteInBackground { get; set; }
    // public static ConfigEntry<bool> UseRefreshRateForFixedUpdateRate { get; set; }
    //
    // public static ConfigEntry<bool> CorrectFixedUpdateRate { get; set; }

#if DEBUG
    internal static ConfigEntry<bool> SixteenTenTesting { get; set; }
    internal static ConfigEntry<bool> ThirtyTwoNineTesting { get; set; }
    internal static ConfigEntry<bool> FourtyEightNineTesting { get; set; }
#endif


    public static ConfigEntry<float> CameraFieldOfView { get; internal set; }

    internal static ConfigEntry<string> Resolution { get; set; }

}