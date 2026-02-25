// Decompiled with JetBrains decompiler
// Type: UnityEngine.SetupCoroutine
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

#nullable disable
namespace UnityEngine;

public class SetupCoroutine(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0;

  static SetupCoroutine()
  {
    Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SetupCoroutine));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr);
    SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100668006);
    SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupCoroutine>.NativeClassPtr, 100668007);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449002, XrefRangeEnd = 449006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeMoveNext(IEnumerator enumerator, System.IntPtr returnValueAddress)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumerator);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &returnValueAddress;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMoveNext_Public_Static_Void_IEnumerator_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449006, XrefRangeEnd = 449011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object InvokeMember(
    Il2CppSystem.Object behaviour,
    string name,
    Il2CppSystem.Object variable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) behaviour);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) variable);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetupCoroutine.NativeMethodInfoPtr_InvokeMember_Public_Static_Object_Object_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  public static Il2CppSystem.Object InvokeStatic(Il2CppSystem.Type klass, string name, Il2CppSystem.Object variable)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
