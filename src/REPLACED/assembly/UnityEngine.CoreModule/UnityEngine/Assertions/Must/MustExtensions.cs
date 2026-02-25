// Decompiled with JetBrains decompiler
// Type: UnityEngine.Assertions.Must.MustExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Assertions.Must;

public static class MustExtensions
{
  public static void MustBeTrue(bool value) => Assert.IsTrue(value);

  public static void MustBeTrue(bool value, string message) => Assert.IsTrue(value, message);

  public static void MustBeFalse(bool value) => Assert.IsFalse(value);

  public static void MustBeFalse(bool value, string message) => Assert.IsFalse(value, message);

  public static void MustBeApproximatelyEqual(float actual, float expected)
  {
    Assert.AreApproximatelyEqual(actual, expected);
  }

  public static void MustBeApproximatelyEqual(float actual, float expected, string message)
  {
    Assert.AreApproximatelyEqual(actual, expected, message);
  }

  public static void MustBeApproximatelyEqual(float actual, float expected, float tolerance)
  {
    Assert.AreApproximatelyEqual(actual, expected, tolerance);
  }

  public static void MustBeApproximatelyEqual(
    float actual,
    float expected,
    float tolerance,
    string message)
  {
    Assert.AreApproximatelyEqual(expected, actual, tolerance, message);
  }

  public static void MustNotBeApproximatelyEqual(float actual, float expected)
  {
    Assert.AreNotApproximatelyEqual(expected, actual);
  }

  public static void MustNotBeApproximatelyEqual(float actual, float expected, string message)
  {
    Assert.AreNotApproximatelyEqual(expected, actual, message);
  }

  public static void MustNotBeApproximatelyEqual(float actual, float expected, float tolerance)
  {
    Assert.AreNotApproximatelyEqual(expected, actual, tolerance);
  }

  public static void MustNotBeApproximatelyEqual(
    float actual,
    float expected,
    float tolerance,
    string message)
  {
    Assert.AreNotApproximatelyEqual(expected, actual, tolerance, message);
  }

  public static void MustBeEqual<T>(T actual, T expected) => Assert.AreEqual<T>(actual, expected);

  public static void MustBeEqual<T>(T actual, T expected, string message)
  {
    Assert.AreEqual<T>(expected, actual, message);
  }

  public static void MustNotBeEqual<T>(T actual, T expected)
  {
    Assert.AreNotEqual<T>(actual, expected);
  }

  public static void MustNotBeEqual<T>(T actual, T expected, string message)
  {
    Assert.AreNotEqual<T>(expected, actual, message);
  }

  public static void MustBeNull<T>(T expected) where T : class => Assert.IsNull<T>(expected);

  public static void MustBeNull<T>(T expected, string message) where T : class
  {
    Assert.IsNull<T>(expected, message);
  }

  public static void MustNotBeNull<T>(T expected) where T : class => Assert.IsNotNull<T>(expected);

  public static void MustNotBeNull<T>(T expected, string message) where T : class
  {
    Assert.IsNotNull<T>(expected, message);
  }
}
