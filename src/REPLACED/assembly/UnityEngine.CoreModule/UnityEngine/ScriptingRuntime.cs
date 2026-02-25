// Decompiled with JetBrains decompiler
// Type: UnityEngine.ScriptingRuntime
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace UnityEngine;

public class ScriptingRuntime(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0;

  static ScriptingRuntime()
  {
    Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ScriptingRuntime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr);
    ScriptingRuntime.NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingRuntime>.NativeClassPtr, 100668255);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 453169, RefRangeEnd = 453171, XrefRangeStart = 453167, XrefRangeEnd = 453169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray GetAllUserAssemblies()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptingRuntime.NativeMethodInfoPtr_GetAllUserAssemblies_Public_Static_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }
}
