namespace Astronomics.Helpers;

public class ResolutionEqualityComparer : IEqualityComparer<Resolution>
{
    public bool Equals(Resolution x, Resolution y)
    {
        return Mathf.Approximately(x.width, y.width) &&
               Mathf.Approximately(x.height,y.height);
    }

    public int GetHashCode(Resolution obj)
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + obj.width.GetHashCode();
            hash = hash * 23 + obj.height.GetHashCode();
            return hash;
        }
    }
}