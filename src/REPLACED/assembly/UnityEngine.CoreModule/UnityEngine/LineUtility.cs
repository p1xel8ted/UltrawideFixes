// Decompiled with JetBrains decompiler
// Type: UnityEngine.LineUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

#nullable disable
namespace UnityEngine;

public sealed class LineUtility
{
  private static readonly LineUtility.GeneratePointsToKeep3DDelegate GeneratePointsToKeep3DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep3DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep3D");
  private static readonly LineUtility.GeneratePointsToKeep2DDelegate GeneratePointsToKeep2DDelegateField = IL2CPP.ResolveICall<LineUtility.GeneratePointsToKeep2DDelegate>("UnityEngine.LineUtility::GeneratePointsToKeep2D");
  private static readonly LineUtility.GenerateSimplifiedPoints3DDelegate GenerateSimplifiedPoints3DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints3DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints3D");
  private static readonly LineUtility.GenerateSimplifiedPoints2DDelegate GenerateSimplifiedPoints2DDelegateField = IL2CPP.ResolveICall<LineUtility.GenerateSimplifiedPoints2DDelegate>("UnityEngine.LineUtility::GenerateSimplifiedPoints2D");

  public static void Simplify(List<Vector3> points, float tolerance, List<int> pointsToKeep)
  {
    if (points == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (points));
    if (pointsToKeep == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (pointsToKeep));
    LineUtility.GeneratePointsToKeep3D((Il2CppSystem.Object) points, tolerance, (Il2CppSystem.Object) pointsToKeep);
  }

  public static void Simplify(
    List<Vector3> points,
    float tolerance,
    List<Vector3> simplifiedPoints)
  {
    if (points == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (points));
    if (simplifiedPoints == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (simplifiedPoints));
    LineUtility.GenerateSimplifiedPoints3D((Il2CppSystem.Object) points, tolerance, (Il2CppSystem.Object) simplifiedPoints);
  }

  public static void Simplify(List<Vector2> points, float tolerance, List<int> pointsToKeep)
  {
    if (points == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (points));
    if (pointsToKeep == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (pointsToKeep));
    LineUtility.GeneratePointsToKeep2D((Il2CppSystem.Object) points, tolerance, (Il2CppSystem.Object) pointsToKeep);
  }

  public static void Simplify(
    List<Vector2> points,
    float tolerance,
    List<Vector2> simplifiedPoints)
  {
    if (points == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (points));
    if (simplifiedPoints == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (simplifiedPoints));
    LineUtility.GenerateSimplifiedPoints2D((Il2CppSystem.Object) points, tolerance, (Il2CppSystem.Object) simplifiedPoints);
  }

  public static void GeneratePointsToKeep3D(
    Il2CppSystem.Object pointsList,
    float tolerance,
    Il2CppSystem.Object pointsToKeepList)
  {
    LineUtility.GeneratePointsToKeep3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointsToKeepList));
  }

  public static void GeneratePointsToKeep2D(
    Il2CppSystem.Object pointsList,
    float tolerance,
    Il2CppSystem.Object pointsToKeepList)
  {
    LineUtility.GeneratePointsToKeep2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointsToKeepList));
  }

  public static void GenerateSimplifiedPoints3D(
    Il2CppSystem.Object pointsList,
    float tolerance,
    Il2CppSystem.Object simplifiedPoints)
  {
    LineUtility.GenerateSimplifiedPoints3DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simplifiedPoints));
  }

  public static void GenerateSimplifiedPoints2D(
    Il2CppSystem.Object pointsList,
    float tolerance,
    Il2CppSystem.Object simplifiedPoints)
  {
    LineUtility.GenerateSimplifiedPoints2DDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pointsList), tolerance, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) simplifiedPoints));
  }

  private delegate void GeneratePointsToKeep3DDelegate(
    System.IntPtr pointsList,
    float tolerance,
    System.IntPtr pointsToKeepList);

  private delegate void GeneratePointsToKeep2DDelegate(
    System.IntPtr pointsList,
    float tolerance,
    System.IntPtr pointsToKeepList);

  private delegate void GenerateSimplifiedPoints3DDelegate(
    System.IntPtr pointsList,
    float tolerance,
    System.IntPtr simplifiedPoints);

  private delegate void GenerateSimplifiedPoints2DDelegate(
    System.IntPtr pointsList,
    float tolerance,
    System.IntPtr simplifiedPoints);
}
