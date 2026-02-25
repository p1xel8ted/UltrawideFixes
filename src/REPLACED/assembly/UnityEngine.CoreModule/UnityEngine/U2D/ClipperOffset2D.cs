// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.ClipperOffset2D
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.U2D;

public struct ClipperOffset2D
{
  private static readonly ClipperOffset2D.Internal_ExecuteDelegate Internal_ExecuteDelegateField = IL2CPP.ResolveICall<ClipperOffset2D.Internal_ExecuteDelegate>("UnityEngine.U2D.ClipperOffset2D::Internal_Execute");
  private static readonly ClipperOffset2D.Internal_Execute_CleanupDelegate Internal_Execute_CleanupDelegateField = IL2CPP.ResolveICall<ClipperOffset2D.Internal_Execute_CleanupDelegate>("UnityEngine.U2D.ClipperOffset2D::Internal_Execute_Cleanup");

  public static void Execute(
    ref ClipperOffset2D.Solution solution,
    NativeArray<Vector2> inPoints,
    NativeArray<int> inPathSizes,
    NativeArray<ClipperOffset2D.PathArguments> inPathArguments,
    Allocator inSolutionAllocator,
    double inDelta = default (double),
    double inMiterLimit = default (double),
    double inRoundPrecision = default (double),
    double inArcTolerance = default (double),
    double inIntScale = default (double),
    bool useRounding = default (bool))
  {
    throw new NotSupportedException("Method unstripping failed");
  }

  public static void Internal_Execute(
    out IntPtr outClippedPoints,
    out int outClippedPointsCount,
    out IntPtr outClippedPathSizes,
    out int outClippedPathCount,
    IntPtr inPoints,
    int inPointCount,
    IntPtr inPathSizes,
    IntPtr inPathArguments,
    int inPathCount,
    double inDelta,
    double inMiterLimit,
    double inRoundPrecision,
    double inArcTolerance,
    double inIntScale,
    bool useRounding)
  {
    ClipperOffset2D.Internal_ExecuteDelegateField((IntPtr) ref outClippedPoints, (IntPtr) ref outClippedPointsCount, (IntPtr) ref outClippedPathSizes, (IntPtr) ref outClippedPathCount, inPoints, inPointCount, inPathSizes, inPathArguments, inPathCount, inDelta, inMiterLimit, inRoundPrecision, inArcTolerance, inIntScale, useRounding);
  }

  public static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes)
  {
    ClipperOffset2D.Internal_Execute_CleanupDelegateField(inPoints, inPathSizes);
  }

  public enum JoinType
  {
    jtSquare,
    jtRound,
    jtMiter,
  }

  public enum EndType
  {
    etClosedPolygon,
    etClosedLine,
    etOpenButt,
    etOpenSquare,
    etOpenRound,
  }

  public struct PathArguments
  {
  }

  public struct Solution
  {
  }

  private delegate void Internal_ExecuteDelegate(
    [Out] IntPtr outClippedPoints,
    [Out] IntPtr outClippedPointsCount,
    [Out] IntPtr outClippedPathSizes,
    [Out] IntPtr outClippedPathCount,
    IntPtr inPoints,
    int inPointCount,
    IntPtr inPathSizes,
    IntPtr inPathArguments,
    int inPathCount,
    double inDelta,
    double inMiterLimit,
    double inRoundPrecision,
    double inArcTolerance,
    double inIntScale,
    bool useRounding);

  private delegate void Internal_Execute_CleanupDelegate(IntPtr inPoints, IntPtr inPathSizes);
}
