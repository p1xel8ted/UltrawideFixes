// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Ram.G_RamMonitor
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy.Ram;

public class G_RamMonitor(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_allocatedRam;
  private static readonly IntPtr NativeFieldInfoPtr_m_reservedRam;
  private static readonly IntPtr NativeFieldInfoPtr_m_monoRam;
  private static readonly IntPtr NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_RamMonitor()
  {
    Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Ram", nameof (G_RamMonitor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr);
    G_RamMonitor.NativeFieldInfoPtr_m_allocatedRam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, nameof (m_allocatedRam));
    G_RamMonitor.NativeFieldInfoPtr_m_reservedRam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, nameof (m_reservedRam));
    G_RamMonitor.NativeFieldInfoPtr_m_monoRam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, nameof (m_monoRam));
    G_RamMonitor.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100663568 /*0x06000110*/);
    G_RamMonitor.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100663569);
    G_RamMonitor.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100663570);
    G_RamMonitor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100663571);
    G_RamMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr, 100663572);
  }

  public unsafe float AllocatedRam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_get_AllocatedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float ReservedRam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_get_ReservedRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float MonoRam
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_get_MonoRam_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362288, XrefRangeEnd = 362291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_RamMonitor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_RamMonitor>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_RamMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float m_allocatedRam
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_allocatedRam));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_allocatedRam)) = value;
    }
  }

  public unsafe float m_reservedRam
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_reservedRam));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_reservedRam)) = value;
    }
  }

  public unsafe float m_monoRam
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_monoRam));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_RamMonitor.NativeFieldInfoPtr_m_monoRam)) = value;
    }
  }
}
