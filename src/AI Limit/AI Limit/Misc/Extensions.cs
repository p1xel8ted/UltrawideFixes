namespace AI_Limit.Misc;

public static class TransformExtensions
{
    public static string GetPath(this Transform transform)
    {
        var path = transform.name;
        while (transform.parent != null)
        {
            transform = transform.parent;
            path = transform.name + "/" + path;
        }

        return path;
    }
    
    public static Camera.GateFitMode ToGateFitMode(this Plugin.ViewScalingMode scalingMode)
    {
        return scalingMode switch
        {
            Plugin.ViewScalingMode.None => Camera.GateFitMode.None,
            Plugin.ViewScalingMode.Vertical => Camera.GateFitMode.Vertical,
            Plugin.ViewScalingMode.Horizontal => Camera.GateFitMode.Horizontal,
            Plugin.ViewScalingMode.Fill => Camera.GateFitMode.Overscan // Fill would be overscan
            ,
            _ => Camera.GateFitMode.None
        };
    }

    // Extension method to find a child by name recursively
    public static Transform FindChildRecursive(this Transform parent, string childName)
    {
        // First, check if the parent is the child we are looking for
        if (parent.name == childName)
        {
            return parent;
        }

        // Loop through all children of the current parent
        foreach (var o in parent)
        {
            var child = o.TryCast<Transform>();
            if (!child) continue;
            // Recursively call this method for each child
            var result = child.FindChildRecursive(childName);
            if (result)
            {
                return result; // If the child is found, return it
            }
        }

        // If no child with the given name is found, return null
        return null;
    }
}