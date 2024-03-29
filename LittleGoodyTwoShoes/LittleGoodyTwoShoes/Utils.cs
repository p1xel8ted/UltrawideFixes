﻿namespace LittleGoodyTwoShoes;

public static class Utils
{

    public static float GetBaseOrthographicSize(ProCamera2D instance)
    {
        if (instance == null) return 4f;
        return instance.ScreenSizeInWorldCoordinates.y * 0.5f;

    }

    public static string GetGameObjectPath(this GameObject obj)
    {
        var path = "/" + obj.name;
        while (obj.transform.parent != null)
        {
            obj = obj.transform.parent.gameObject;
            path = "/" + obj.name + path;
        }
        return path;
    }
    

    internal static void UpdateScaler(CanvasScaler scaler)
    {
        if (scaler == null) return;
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }
}