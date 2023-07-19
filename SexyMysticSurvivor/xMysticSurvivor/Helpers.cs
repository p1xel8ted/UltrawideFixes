namespace xMysticSurvivor;

public static class Helpers
{
    public static float AdjustVolumeScale(float volumeScale, float adjustmentValue)
    {
        var factor = 1 + adjustmentValue / 100;
        volumeScale *= factor;
        return volumeScale;
    }
}