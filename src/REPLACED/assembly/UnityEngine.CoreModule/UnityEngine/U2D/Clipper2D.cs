// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.Clipper2D
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;

#nullable disable
namespace UnityEngine.U2D;

public struct Clipper2D
{
  private static readonly Clipper2D.Internal_Execute_CleanupDelegate Internal_Execute_CleanupDelegateField = IL2CPP.ResolveICall<Clipper2D.Internal_Execute_CleanupDelegate>("UnityEngine.U2D.Clipper2D::Internal_Execute_Cleanup");

  public static void Internal_Execute_Cleanup(IntPtr inPoints, IntPtr inPathSizes)
  {
    Clipper2D.Internal_Execute_CleanupDelegateField(inPoints, inPathSizes);
  }

  public enum ClipType
  {
    ctIntersection,
    ctUnion,
    ctDifference,
    ctXor,
  }

  public enum PolyType
  {
    ptSubject,
    ptClip,
  }

  public enum PolyFillType
  {
    pftEvenOdd,
    pftNonZero,
    pftPositive,
    pftNegative,
  }

  public enum InitOptions
  {
    ioDefault = 0,
    oReverseSolution = 1,
    ioStrictlySimple = 2,
    ioPreserveCollinear = 4,
  }

  public struct Solution
  {
  }

  private delegate void Internal_Execute_CleanupDelegate(IntPtr inPoints, IntPtr inPathSizes);
}
