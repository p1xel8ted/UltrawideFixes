// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineCollisionImpulseSource
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

public class CinemachineCollisionImpulseSource(IntPtr pointer) : CinemachineImpulseSource(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_LayerMask;
  private static readonly IntPtr NativeFieldInfoPtr_m_IgnoreTag;
  private static readonly IntPtr NativeFieldInfoPtr_m_UseImpactDirection;
  private static readonly IntPtr NativeFieldInfoPtr_m_ScaleImpactWithMass;
  private static readonly IntPtr NativeFieldInfoPtr_m_ScaleImpactWithSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_mRigidBody;
  private static readonly IntPtr NativeFieldInfoPtr_mRigidBody2D;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMassAndVelocity_Private_Single_Collider_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpactEvent_Private_Void_Collider_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMassAndVelocity2D_Private_Single_Collider2D_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpactEvent2D_Private_Void_Collider2D_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineCollisionImpulseSource()
  {
    Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineCollisionImpulseSource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr);
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (m_LayerMask));
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_IgnoreTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (m_IgnoreTag));
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_UseImpactDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (m_UseImpactDirection));
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_ScaleImpactWithMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (m_ScaleImpactWithMass));
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_ScaleImpactWithSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (m_ScaleImpactWithSpeed));
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_mRigidBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (mRigidBody));
    CinemachineCollisionImpulseSource.NativeFieldInfoPtr_mRigidBody2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, nameof (mRigidBody2D));
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664235);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664236);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664237);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664238);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GetMassAndVelocity_Private_Single_Collider_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664239);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GenerateImpactEvent_Private_Void_Collider_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664240 /*0x060003B0*/);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664241);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664242);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GetMassAndVelocity2D_Private_Single_Collider2D_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664243);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GenerateImpactEvent2D_Private_Void_Collider2D_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664244);
    CinemachineCollisionImpulseSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr, 100664245);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945269, XrefRangeEnd = 945275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945275, XrefRangeEnd = 945278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter(Collision c)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945278, XrefRangeEnd = 945281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider c)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945299, RefRangeEnd = 945300, XrefRangeStart = 945281, XrefRangeEnd = 945299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetMassAndVelocity(Collider other, ref Vector3 vel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref vel;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GetMassAndVelocity_Private_Single_Collider_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945317, RefRangeEnd = 945319, XrefRangeStart = 945300, XrefRangeEnd = 945317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpactEvent(Collider other, Vector3 vel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &vel;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GenerateImpactEvent_Private_Void_Collider_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945319, XrefRangeEnd = 945322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D c)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945322, XrefRangeEnd = 945325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter2D(Collider2D c)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945343, RefRangeEnd = 945344, XrefRangeStart = 945325, XrefRangeEnd = 945343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other2d);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref vel;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GetMassAndVelocity2D_Private_Single_Collider2D_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945361, RefRangeEnd = 945363, XrefRangeStart = 945344, XrefRangeEnd = 945361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other2d);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &vel;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr_GenerateImpactEvent2D_Private_Void_Collider2D_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945363, XrefRangeEnd = 945366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineCollisionImpulseSource()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCollisionImpulseSource>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCollisionImpulseSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask m_LayerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_LayerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_LayerMask)) = value;
    }
  }

  public unsafe string m_IgnoreTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_IgnoreTag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_IgnoreTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool m_UseImpactDirection
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_UseImpactDirection));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_UseImpactDirection)) = value;
    }
  }

  public unsafe bool m_ScaleImpactWithMass
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_ScaleImpactWithMass));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_ScaleImpactWithMass)) = value;
    }
  }

  public unsafe bool m_ScaleImpactWithSpeed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_ScaleImpactWithSpeed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_m_ScaleImpactWithSpeed)) = value;
    }
  }

  public unsafe Rigidbody mRigidBody
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_mRigidBody));
      return num == IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_mRigidBody), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody2D mRigidBody2D
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_mRigidBody2D));
      return num == IntPtr.Zero ? (Rigidbody2D) null : Il2CppObjectPool.Get<Rigidbody2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCollisionImpulseSource.NativeFieldInfoPtr_mRigidBody2D), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
