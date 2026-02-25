// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineDollyCart
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineDollyCart(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_Path;
  private static readonly IntPtr NativeFieldInfoPtr_m_UpdateMethod;
  private static readonly IntPtr NativeFieldInfoPtr_m_PositionUnits;
  private static readonly IntPtr NativeFieldInfoPtr_m_Speed;
  private static readonly IntPtr NativeFieldInfoPtr_m_Position;
  private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetCartPosition_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineDollyCart()
  {
    Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineDollyCart));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr);
    CinemachineDollyCart.NativeFieldInfoPtr_m_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, nameof (m_Path));
    CinemachineDollyCart.NativeFieldInfoPtr_m_UpdateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, nameof (m_UpdateMethod));
    CinemachineDollyCart.NativeFieldInfoPtr_m_PositionUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, nameof (m_PositionUnits));
    CinemachineDollyCart.NativeFieldInfoPtr_m_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, nameof (m_Speed));
    CinemachineDollyCart.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, nameof (m_Position));
    CinemachineDollyCart.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, 100663485 /*0x060000BD*/);
    CinemachineDollyCart.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, 100663486 /*0x060000BE*/);
    CinemachineDollyCart.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, 100663487 /*0x060000BF*/);
    CinemachineDollyCart.NativeMethodInfoPtr_SetCartPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, 100663488 /*0x060000C0*/);
    CinemachineDollyCart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr, 100663489 /*0x060000C1*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938757, XrefRangeEnd = 938759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDollyCart.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938759, XrefRangeEnd = 938766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDollyCart.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938766, XrefRangeEnd = 938773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDollyCart.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 938781, RefRangeEnd = 938785, XrefRangeStart = 938773, XrefRangeEnd = 938781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCartPosition(float distanceAlongPath)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &distanceAlongPath
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDollyCart.NativeMethodInfoPtr_SetCartPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938785, XrefRangeEnd = 938786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineDollyCart()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineDollyCart>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDollyCart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachinePathBase m_Path
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_Path));
      return num == IntPtr.Zero ? (CinemachinePathBase) null : Il2CppObjectPool.Get<CinemachinePathBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_Path), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineDollyCart.UpdateMethod m_UpdateMethod
  {
    get
    {
      return *(CinemachineDollyCart.UpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_UpdateMethod));
    }
    [param: In] set
    {
      *(CinemachineDollyCart.UpdateMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_UpdateMethod)) = value;
    }
  }

  public unsafe CinemachinePathBase.PositionUnits m_PositionUnits
  {
    get
    {
      return *(CinemachinePathBase.PositionUnits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_PositionUnits));
    }
    [param: In] set
    {
      *(CinemachinePathBase.PositionUnits*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_PositionUnits)) = value;
    }
  }

  public unsafe float m_Speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_Speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_Speed)) = value;
    }
  }

  public unsafe float m_Position
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_Position));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyCart.NativeFieldInfoPtr_m_Position)) = value;
    }
  }

  public enum UpdateMethod
  {
    Update,
    FixedUpdate,
    LateUpdate,
  }
}
