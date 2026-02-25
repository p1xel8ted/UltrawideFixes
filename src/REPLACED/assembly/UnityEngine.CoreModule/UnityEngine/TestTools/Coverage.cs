// Decompiled with JetBrains decompiler
// Type: UnityEngine.TestTools.Coverage
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Reflection;

#nullable disable
namespace UnityEngine.TestTools;

public static class Coverage
{
  private static readonly Coverage.get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<Coverage.get_enabledDelegate>("UnityEngine.TestTools.Coverage::get_enabled");
  private static readonly Coverage.set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<Coverage.set_enabledDelegate>("UnityEngine.TestTools.Coverage::set_enabled");
  private static readonly Coverage.ResetFor_InternalDelegate ResetFor_InternalDelegateField = IL2CPP.ResolveICall<Coverage.ResetFor_InternalDelegate>("UnityEngine.TestTools.Coverage::ResetFor_Internal");
  private static readonly Coverage.ResetAllDelegate ResetAllDelegateField = IL2CPP.ResolveICall<Coverage.ResetAllDelegate>("UnityEngine.TestTools.Coverage::ResetAll");

  public static bool enabled
  {
    get => Coverage.get_enabledDelegateField();
    set => Coverage.set_enabledDelegateField(value);
  }

  public static void ResetFor_Internal(MethodBase method)
  {
    Coverage.ResetFor_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method));
  }

  public static void ResetFor(MethodBase method)
  {
    if (method == (MethodBase) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (method));
    Coverage.ResetFor_Internal(method);
  }

  public static void ResetAll() => Coverage.ResetAllDelegateField();

  private delegate bool get_enabledDelegate();

  private delegate void set_enabledDelegate(bool value);

  private delegate void ResetFor_InternalDelegate(System.IntPtr method);

  private delegate void ResetAllDelegate();
}
