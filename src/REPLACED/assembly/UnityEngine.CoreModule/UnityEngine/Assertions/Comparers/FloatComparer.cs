// Decompiled with JetBrains decompiler
// Type: UnityEngine.Assertions.Comparers.FloatComparer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Assertions.Comparers;

public class FloatComparer
{
  public const float kEpsilon = 1E-05f;

  public bool Equals(float a, float b)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public int GetHashCode(float obj) => __nonvirtual (((Il2CppSystem.Object) this).GetHashCode());

  public static bool AreEqual(float expected, float actual, float error)
  {
    return (double) Il2CppSystem.Math.Abs(actual - expected) <= (double) error;
  }

  public static bool AreEqualRelative(float expected, float actual, float error)
  {
    if ((double) expected == (double) actual)
      return true;
    float num1 = Il2CppSystem.Math.Abs(expected);
    float num2 = Il2CppSystem.Math.Abs(actual);
    return (double) Il2CppSystem.Math.Abs((float) (((double) actual - (double) expected) / ((double) num1 > (double) num2 ? (double) num1 : (double) num2))) <= (double) error;
  }
}
