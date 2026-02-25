// Decompiled with JetBrains decompiler
// Type: UnityEngine.Snapping
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine;

public static class Snapping
{
  public static bool IsCardinalDirection(Vector3 direction)
  {
    return (double) Mathf.Abs(direction.x) > 0.0 && Mathf.Approximately(direction.y, 0.0f) && Mathf.Approximately(direction.z, 0.0f) || (double) Mathf.Abs(direction.y) > 0.0 && Mathf.Approximately(direction.x, 0.0f) && Mathf.Approximately(direction.z, 0.0f) || (double) Mathf.Abs(direction.z) > 0.0 && Mathf.Approximately(direction.x, 0.0f) && Mathf.Approximately(direction.y, 0.0f);
  }

  public static float Snap(float val, float snap)
  {
    return (double) snap == 0.0 ? val : snap * Mathf.Round(val / snap);
  }

  public static Vector2 Snap(Vector2 val, Vector2 snap)
  {
    return (Vector2) new Vector3((double) Mathf.Abs(snap.x) < (double) Mathf.Epsilon ? val.x : snap.x * Mathf.Round(val.x / snap.x), (double) Mathf.Abs(snap.y) < (double) Mathf.Epsilon ? val.y : snap.y * Mathf.Round(val.y / snap.y));
  }

  public static Vector3 Snap(Vector3 val, Vector3 snap, SnapAxis axis = default (SnapAxis))
  {
    return new Vector3((axis & SnapAxis.X) == SnapAxis.X ? Snapping.Snap(val.x, snap.x) : val.x, (axis & SnapAxis.Y) == SnapAxis.Y ? Snapping.Snap(val.y, snap.y) : val.y, (axis & SnapAxis.Z) == SnapAxis.Z ? Snapping.Snap(val.z, snap.z) : val.z);
  }
}
