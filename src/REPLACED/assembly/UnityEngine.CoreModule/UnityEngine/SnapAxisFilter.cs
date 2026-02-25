// Decompiled with JetBrains decompiler
// Type: UnityEngine.SnapAxisFilter
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine;

public struct SnapAxisFilter
{
  public const SnapAxis X = SnapAxis.X;
  public const SnapAxis Y = SnapAxis.Y;
  public const SnapAxis Z = SnapAxis.Z;
  public SnapAxis m_Mask;

  public float x => (this.m_Mask & SnapAxis.X) == SnapAxis.X ? 1f : 0.0f;

  public float y => (this.m_Mask & SnapAxis.Y) == SnapAxis.Y ? 1f : 0.0f;

  public float z => (this.m_Mask & SnapAxis.Z) == SnapAxis.Z ? 1f : 0.0f;

  public override string ToString()
  {
    return Il2CppSystem.String.Format("{{{0}, {1}, {2}}}", (Il2CppSystem.Object) (System.ValueType) this.x, (Il2CppSystem.Object) (System.ValueType) this.y, (Il2CppSystem.Object) (System.ValueType) this.z);
  }

  public int active
  {
    get
    {
      int active = 0;
      if ((this.m_Mask & SnapAxis.X) > SnapAxis.None)
        ++active;
      if ((this.m_Mask & SnapAxis.Y) > SnapAxis.None)
        ++active;
      if ((this.m_Mask & SnapAxis.Z) > SnapAxis.None)
        ++active;
      return active;
    }
  }

  public static implicit operator Vector3(SnapAxisFilter mask)
  {
    return new Vector3(mask.x, mask.y, mask.z);
  }

  public static explicit operator SnapAxisFilter(Vector3 v) => new SnapAxisFilter(v);

  public static explicit operator SnapAxis(SnapAxisFilter mask) => mask.m_Mask;

  public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
  {
    return new SnapAxisFilter(left.m_Mask | right.m_Mask);
  }

  public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
  {
    return new SnapAxisFilter(left.m_Mask & right.m_Mask);
  }

  public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
  {
    return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
  }

  public static SnapAxisFilter operator ~(SnapAxisFilter left) => new SnapAxisFilter(~left.m_Mask);

  public static Vector3 operator *(SnapAxisFilter mask, float value)
  {
    return new Vector3(mask.x * value, mask.y * value, mask.z * value);
  }

  public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
  {
    return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
  }

  public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
  {
    int active = mask.active;
    if (active > 2)
      return (Vector3) mask;
    Vector3 vector3 = rotation * (Vector3) mask;
    vector3 = new Vector3(Mathf.Abs(vector3.x), Mathf.Abs(vector3.y), Mathf.Abs(vector3.z));
    return active > 1 ? new Vector3((double) vector3.x > (double) vector3.y || (double) vector3.x > (double) vector3.z ? 1f : 0.0f, (double) vector3.y > (double) vector3.x || (double) vector3.y > (double) vector3.z ? 1f : 0.0f, (double) vector3.z > (double) vector3.x || (double) vector3.z > (double) vector3.y ? 1f : 0.0f) : new Vector3((double) vector3.x <= (double) vector3.y || (double) vector3.x <= (double) vector3.z ? 0.0f : 1f, (double) vector3.y <= (double) vector3.z || (double) vector3.y <= (double) vector3.x ? 0.0f : 1f, (double) vector3.z <= (double) vector3.x || (double) vector3.z <= (double) vector3.y ? 0.0f : 1f);
  }

  public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
  {
    return left.m_Mask == right.m_Mask;
  }

  public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right) => !(left == right);

  public float get_Item(int i)
  {
    if (i < 0 || i > 2)
      throw new Il2CppSystem.IndexOutOfRangeException();
    return (float) (1 & (int) this.m_Mask >> i) * 1f;
  }

  public void set_Item(int i, float value)
  {
    if (i < 0 || i > 2)
      throw new Il2CppSystem.IndexOutOfRangeException();
    this.m_Mask &= (SnapAxis) ~(1 << i);
    this.m_Mask |= (SnapAxis) (((double) value > 0.0 ? 1 : 0) << i);
  }

  public bool Equals(SnapAxisFilter other) => this.m_Mask == other.m_Mask;

  public virtual bool Equals(Il2CppSystem.Object obj)
  {
    return obj != null && obj is SnapAxisFilter other && this.Equals(other);
  }

  public override int GetHashCode() => this.m_Mask.GetHashCode();
}
