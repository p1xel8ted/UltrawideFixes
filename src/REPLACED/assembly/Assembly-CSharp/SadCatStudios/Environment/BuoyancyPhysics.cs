// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.BuoyancyPhysics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class BuoyancyPhysics(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_floaters;
  private static readonly IntPtr NativeFieldInfoPtr_underWaterDrag;
  private static readonly IntPtr NativeFieldInfoPtr_underWaterAngularDrag;
  private static readonly IntPtr NativeFieldInfoPtr_airDrag;
  private static readonly IntPtr NativeFieldInfoPtr_airAngularDrag;
  private static readonly IntPtr NativeFieldInfoPtr_floatingPower;
  private static readonly IntPtr NativeFieldInfoPtr_drowningForce;
  private static readonly IntPtr NativeFieldInfoPtr_drowningSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_waterHeightOffset;
  private static readonly IntPtr NativeFieldInfoPtr_forceMode;
  private static readonly IntPtr NativeFieldInfoPtr_forceOffset;
  private static readonly IntPtr NativeFieldInfoPtr_body;
  private static readonly IntPtr NativeFieldInfoPtr_originalMass;
  private static readonly IntPtr NativeFieldInfoPtr_originalPos;
  private static readonly IntPtr NativeFieldInfoPtr_isSteppedOn;
  private static readonly IntPtr NativeFieldInfoPtr_forcePosition;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BuoyancyPhysics()
  {
    Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (BuoyancyPhysics));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr);
    BuoyancyPhysics.NativeFieldInfoPtr_floaters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (floaters));
    BuoyancyPhysics.NativeFieldInfoPtr_underWaterDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (underWaterDrag));
    BuoyancyPhysics.NativeFieldInfoPtr_underWaterAngularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (underWaterAngularDrag));
    BuoyancyPhysics.NativeFieldInfoPtr_airDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (airDrag));
    BuoyancyPhysics.NativeFieldInfoPtr_airAngularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (airAngularDrag));
    BuoyancyPhysics.NativeFieldInfoPtr_floatingPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (floatingPower));
    BuoyancyPhysics.NativeFieldInfoPtr_drowningForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (drowningForce));
    BuoyancyPhysics.NativeFieldInfoPtr_drowningSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (drowningSpeed));
    BuoyancyPhysics.NativeFieldInfoPtr_waterHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (waterHeightOffset));
    BuoyancyPhysics.NativeFieldInfoPtr_forceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (forceMode));
    BuoyancyPhysics.NativeFieldInfoPtr_forceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (forceOffset));
    BuoyancyPhysics.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (body));
    BuoyancyPhysics.NativeFieldInfoPtr_originalMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (originalMass));
    BuoyancyPhysics.NativeFieldInfoPtr_originalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (originalPos));
    BuoyancyPhysics.NativeFieldInfoPtr_isSteppedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (isSteppedOn));
    BuoyancyPhysics.NativeFieldInfoPtr_forcePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, nameof (forcePosition));
    BuoyancyPhysics.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675878);
    BuoyancyPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675879);
    BuoyancyPhysics.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675880);
    BuoyancyPhysics.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675881);
    BuoyancyPhysics.NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675882);
    BuoyancyPhysics.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675883);
    BuoyancyPhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr, 100675884);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120125, XrefRangeEnd = 120131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120131, XrefRangeEnd = 120153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120153, XrefRangeEnd = 120159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionStay(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120159, XrefRangeEnd = 120165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120165, XrefRangeEnd = 120169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionExit(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120169, XrefRangeEnd = 120177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120177, XrefRangeEnd = 120178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuoyancyPhysics()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuoyancyPhysics>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuoyancyPhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Transform> floaters
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_floaters));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_floaters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float underWaterDrag
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_underWaterDrag));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_underWaterDrag)) = value;
    }
  }

  public unsafe float underWaterAngularDrag
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_underWaterAngularDrag));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_underWaterAngularDrag)) = value;
    }
  }

  public unsafe float airDrag
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_airDrag));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_airDrag)) = value;
    }
  }

  public unsafe float airAngularDrag
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_airAngularDrag));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_airAngularDrag)) = value;
    }
  }

  public unsafe float floatingPower
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_floatingPower));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_floatingPower)) = value;
    }
  }

  public unsafe float drowningForce
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_drowningForce));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_drowningForce)) = value;
    }
  }

  public unsafe float drowningSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_drowningSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_drowningSpeed)) = value;
    }
  }

  public unsafe float waterHeightOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_waterHeightOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_waterHeightOffset)) = value;
    }
  }

  public unsafe ForceMode forceMode
  {
    get
    {
      return *(ForceMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_forceMode));
    }
    [param: In] set
    {
      *(ForceMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_forceMode)) = value;
    }
  }

  public unsafe Vector3 forceOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_forceOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_forceOffset)) = value;
    }
  }

  public unsafe Rigidbody body
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_body));
      return num == IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float originalMass
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_originalMass));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_originalMass)) = value;
    }
  }

  public unsafe float originalPos
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_originalPos));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_originalPos)) = value;
    }
  }

  public unsafe bool isSteppedOn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_isSteppedOn));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_isSteppedOn)) = value;
    }
  }

  public unsafe Vector3 forcePosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_forcePosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BuoyancyPhysics.NativeFieldInfoPtr_forcePosition)) = value;
    }
  }
}
