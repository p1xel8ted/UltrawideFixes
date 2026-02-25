// Decompiled with JetBrains decompiler
// Type: UnityEngine.WaitForSeconds
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class WaitForSeconds(IntPtr pointer) : YieldInstruction(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_Seconds;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

  static WaitForSeconds()
  {
    Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (WaitForSeconds));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr);
    WaitForSeconds.NativeFieldInfoPtr_m_Seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, nameof (m_Seconds));
    WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr, 100668442);
  }

  [CallerCount(43)]
  [CachedScanResults(RefRangeStart = 464431, RefRangeEnd = 464474, XrefRangeStart = 464430, XrefRangeEnd = 464431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaitForSeconds(float seconds)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSeconds>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &seconds
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaitForSeconds.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float m_Seconds
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitForSeconds.NativeFieldInfoPtr_m_Seconds)) = value;
    }
  }
}
