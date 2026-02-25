// Decompiled with JetBrains decompiler
// Type: Unity.IntegerTime.DiscreteTimeTimeExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppSystem;

#nullable disable
namespace Unity.IntegerTime;

public static class DiscreteTimeTimeExtensions
{
  public static DiscreteTime Abs(DiscreteTime lhs) => DiscreteTime.FromTicks(Math.Abs(lhs.Value));

  public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs)
  {
    return DiscreteTime.FromTicks(Math.Min(lhs.Value, rhs.Value));
  }

  public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs)
  {
    return DiscreteTime.FromTicks(Math.Max(lhs.Value, rhs.Value));
  }

  public static DiscreteTime Clamp(DiscreteTime x, DiscreteTime a, DiscreteTime b)
  {
    return DiscreteTimeTimeExtensions.Max(a, DiscreteTimeTimeExtensions.Min(b, x));
  }

  public static DiscreteTime Floor(DiscreteTime x) => (DiscreteTime) Math.Floor((double) x);

  public static DiscreteTime Select(DiscreteTime a, DiscreteTime b, bool c)
  {
    return DiscreteTime.FromTicks(c ? b.Value : a.Value);
  }
}
