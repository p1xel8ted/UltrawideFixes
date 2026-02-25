// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeArrayDispose
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Collections;

[StructLayout(LayoutKind.Explicit)]
public struct NativeArrayDispose
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocatorLabel;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
  [FieldOffset(0)]
  public System.IntPtr m_Buffer;
  [FieldOffset(8)]
  public Allocator m_AllocatorLabel;

  static NativeArrayDispose()
  {
    Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", nameof (NativeArrayDispose));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr);
    NativeArrayDispose.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, nameof (m_Buffer));
    NativeArrayDispose.NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, nameof (m_AllocatorLabel));
    NativeArrayDispose.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, 100663534 /*0x060000EE*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414573, RefRangeEnd = 414574, XrefRangeStart = 414571, XrefRangeEnd = 414573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeArrayDispose.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
