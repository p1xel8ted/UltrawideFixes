using UnityEngine;

namespace TheyAlwaysRun;

public static class Util
{
    public static float GetScaleRatio()
    {
        var aspectRatio = (float) Display.main.systemWidth / Display.main.systemHeight;
        const float targetAspectRatio = 16f / 9f;
        var scaleRatio = aspectRatio / targetAspectRatio;
        return scaleRatio;
    }

    public static string GetFullPath(Transform transform)
    {
        var path = transform.name;
        while (transform.parent != null)
        {
            transform = transform.parent;
            path = transform.name + "/" + path;
        }

        return path;
    }
}