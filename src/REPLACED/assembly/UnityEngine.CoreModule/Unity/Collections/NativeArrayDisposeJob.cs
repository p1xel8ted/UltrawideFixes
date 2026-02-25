// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeArrayDisposeJob
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Collections;

[StructLayout(LayoutKind.Explicit)]
public struct NativeArrayDisposeJob
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Data;
  private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0;
  [FieldOffset(0)]
  public NativeArrayDispose Data;

  static NativeArrayDisposeJob()
  {
    Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", nameof (NativeArrayDisposeJob));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr);
    NativeArrayDisposeJob.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, nameof (Data));
    NativeArrayDisposeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, 100663535 /*0x060000EF*/);
    NativeArrayDisposeJob.NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, 100663536 /*0x060000F0*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414573, RefRangeEnd = 414574, XrefRangeStart = 414573, XrefRangeEnd = 414574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Execute()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayDisposeJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414574, XrefRangeEnd = 414577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RegisterNativeArrayDisposeJobReflectionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayDisposeJob.NativeMethodInfoPtr_RegisterNativeArrayDisposeJobReflectionData_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDisposeJob>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
