// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineImpulseSource
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

public class CinemachineImpulseSource(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_ImpulseDefinition;
  private static readonly IntPtr NativeFieldInfoPtr_m_DefaultVelocity;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulseAtPositionWithVelocity_Public_Void_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulseWithVelocity_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulseWithForce_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulse_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulseAt_Public_Void_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulse_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulse_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineImpulseSource()
  {
    Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineImpulseSource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr);
    CinemachineImpulseSource.NativeFieldInfoPtr_m_ImpulseDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, nameof (m_ImpulseDefinition));
    CinemachineImpulseSource.NativeFieldInfoPtr_m_DefaultVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, nameof (m_DefaultVelocity));
    CinemachineImpulseSource.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664291);
    CinemachineImpulseSource.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664292);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseAtPositionWithVelocity_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664293);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseWithVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664294);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseWithForce_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664295);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664296);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664297);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulse_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664298);
    CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulse_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664299);
    CinemachineImpulseSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr, 100664300);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945808, XrefRangeEnd = 945810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945810, XrefRangeEnd = 945820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945820, XrefRangeEnd = 945821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &position;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &velocity;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseAtPositionWithVelocity_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945824, RefRangeEnd = 945826, XrefRangeStart = 945821, XrefRangeEnd = 945824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulseWithVelocity(Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &velocity
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseWithVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945826, XrefRangeEnd = 945829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulseWithForce(float force)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &force
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseWithForce_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945829, XrefRangeEnd = 945832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulse()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulseAt(Vector3 position, Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &position;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &velocity;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulseAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945824, RefRangeEnd = 945826, XrefRangeStart = 945824, XrefRangeEnd = 945826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulse(Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &velocity
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulse_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulse(float force)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &force
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr_GenerateImpulse_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945839, RefRangeEnd = 945840, XrefRangeStart = 945832, XrefRangeEnd = 945839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseSource()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseSource>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineImpulseDefinition m_ImpulseDefinition
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseSource.NativeFieldInfoPtr_m_ImpulseDefinition));
      return num == IntPtr.Zero ? (CinemachineImpulseDefinition) null : Il2CppObjectPool.Get<CinemachineImpulseDefinition>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseSource.NativeFieldInfoPtr_m_ImpulseDefinition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 m_DefaultVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseSource.NativeFieldInfoPtr_m_DefaultVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseSource.NativeFieldInfoPtr_m_DefaultVelocity)) = value;
    }
  }
}
