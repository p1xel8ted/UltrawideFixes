// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pose
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;

#nullable disable
namespace UnityEngine;

[Serializable]
public struct Pose
{
  public Vector3 position;
  public Quaternion rotation;

  public override string ToString() => throw new System.NotSupportedException("Method unstripping failed");

  public string ToString(string format)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public Pose GetTransformedBy(Pose lhs)
  {
    return new Pose()
    {
      position = lhs.position + lhs.rotation * this.position,
      rotation = lhs.rotation * this.rotation
    };
  }

  public Pose GetTransformedBy(Transform lhs)
  {
    return new Pose()
    {
      position = lhs.TransformPoint(this.position),
      rotation = lhs.rotation * this.rotation
    };
  }

  public Vector3 forward => this.rotation * Vector3.forward;

  public Vector3 right => this.rotation * Vector3.right;

  public Vector3 up => this.rotation * Vector3.up;

  public static Pose identity => throw new System.NotSupportedException("Method unstripping failed");

  public virtual bool Equals(Il2CppSystem.Object obj) => obj is Pose other && this.Equals(other);

  public bool Equals(Pose other)
  {
    return this.position.Equals(other.position) && this.rotation.Equals(other.rotation);
  }

  public override int GetHashCode()
  {
    return this.position.GetHashCode() ^ this.rotation.GetHashCode() << 1;
  }

  public static bool operator ==(Pose a, Pose b)
  {
    return a.position == b.position && a.rotation.Equals(b.rotation);
  }

  public static bool operator !=(Pose a, Pose b) => !(a == b);
}
