using System;
using System.Collections.Generic;
using UnityEngine;

namespace AgathaChristieMOE;

public static class GateFitEnumMappings
{
    // public readonly static Dictionary<Camera.GateFitMode, string> EnumToString = new()
    // {
    //     {Camera.GateFitMode.None, "Vert-"},
    //     {Camera.GateFitMode.Horizontal, "Vert+"},
    //     {Camera.GateFitMode.Vertical, "Hor+"},
    //     {Camera.GateFitMode.Overscan, "Hor-"}
    // };

    public readonly static Dictionary<string, Camera.GateFitMode> StringToEnum = new(StringComparer.OrdinalIgnoreCase)
    {
        {"Vert-", Camera.GateFitMode.None},
        {"Vert+", Camera.GateFitMode.Horizontal},
        {"Hor+", Camera.GateFitMode.Vertical},
        {"Hor-", Camera.GateFitMode.Overscan}
    };
}