namespace Astronomics.Helpers;

public class ResolutionEqualityComparer : IEqualityComparer<Resolution>
{
    public bool Equals(Resolution x, Resolution y)
    {
        return x.width == y.width &&
               x.height == y.height &&
               Mathf.Approximately((float)x.refreshRateRatio.value,(float)y.refreshRateRatio.value);
    }

    public int GetHashCode(Resolution obj)
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + obj.width.GetHashCode();
            hash = hash * 23 + obj.height.GetHashCode();
            hash = hash * 23 + ((float)obj.refreshRateRatio.value).GetHashCode();
            return hash;
        }
    }
}