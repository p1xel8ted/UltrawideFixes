// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.AttackObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class AttackObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sender;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackData;
  private static readonly System.IntPtr NativeFieldInfoPtr_senderGameObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_direction;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitCastResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_PerfectHit;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Sender_Public_get_IHitSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SenderGameObject_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IHitSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttackData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_AttackData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_AttackData_Int32_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Connect_Public_Void_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Parriable_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Ramming_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DelayedDamage_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StunCounter_Public_Boolean_0;

  static AttackObject()
  {
    Il2CppClassPointerStore<AttackObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (AttackObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackObject>.NativeClassPtr);
    AttackObject.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, nameof (sender));
    AttackObject.NativeFieldInfoPtr_attackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, nameof (attackData));
    AttackObject.NativeFieldInfoPtr_senderGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, nameof (senderGameObject));
    AttackObject.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, nameof (direction));
    AttackObject.NativeFieldInfoPtr_hitCastResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, nameof (hitCastResult));
    AttackObject.NativeFieldInfoPtr_PerfectHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, nameof (PerfectHit));
    AttackObject.NativeMethodInfoPtr_get_Sender_Public_get_IHitSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677680);
    AttackObject.NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677681);
    AttackObject.NativeMethodInfoPtr_get_SenderGameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677682);
    AttackObject.NativeMethodInfoPtr_get_Direction_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677683);
    AttackObject.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677684);
    AttackObject.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677685);
    AttackObject.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677686);
    AttackObject.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677687);
    AttackObject.NativeMethodInfoPtr__ctor_Public_Void_IHitSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677688);
    AttackObject.NativeMethodInfoPtr__ctor_Public_Void_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677689);
    AttackObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677690);
    AttackObject.NativeMethodInfoPtr_Init_Public_Void_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677691);
    AttackObject.NativeMethodInfoPtr_Init_Public_Void_AttackData_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677692);
    AttackObject.NativeMethodInfoPtr_Connect_Public_Void_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677693);
    AttackObject.NativeMethodInfoPtr_Parriable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677694);
    AttackObject.NativeMethodInfoPtr_Ramming_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677695);
    AttackObject.NativeMethodInfoPtr_DelayedDamage_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677696);
    AttackObject.NativeMethodInfoPtr_StunCounter_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackObject>.NativeClassPtr, 100677697);
  }

  public unsafe IHitSender Sender
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_Sender_Public_get_IHitSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IHitSender) null : Il2CppObjectPool.Get<IHitSender>(num3);
    }
  }

  public unsafe AttackData AttackData
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num3);
    }
  }

  public unsafe GameObject SenderGameObject
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_SenderGameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
  }

  public unsafe int Direction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_Direction_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Vector3 ImpactPosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe int ImpactDirection
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Transform ProviderTransform
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe Rigidbody ProviderRigidbody
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num3);
    }
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackObject(IHitSender sender)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sender)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr__ctor_Public_Void_IHitSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 130995, RefRangeEnd = 131003, XrefRangeStart = 130994, XrefRangeEnd = 130995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackObject(AttackData attackData)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr__ctor_Public_Void_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(AttackData attackData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_Init_Public_Void_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131003, RefRangeEnd = 131005, XrefRangeStart = 131003, XrefRangeEnd = 131003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(AttackData attackData, int direction, GameObject senderGameObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) senderGameObject);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_Init_Public_Void_AttackData_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Connect(HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_Connect_Public_Void_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131010, RefRangeEnd = 131012, XrefRangeStart = 131005, XrefRangeEnd = 131010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Parriable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_Parriable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 131017, RefRangeEnd = 131019, XrefRangeStart = 131012, XrefRangeEnd = 131017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Ramming()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_Ramming_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131019, XrefRangeEnd = 131024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool DelayedDamage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_DelayedDamage_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131028, RefRangeEnd = 131029, XrefRangeStart = 131024, XrefRangeEnd = 131028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool StunCounter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackObject.NativeMethodInfoPtr_StunCounter_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe IHitSender sender
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_sender));
      return num == System.IntPtr.Zero ? (IHitSender) null : Il2CppObjectPool.Get<IHitSender>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackData attackData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_attackData));
      return num == System.IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_attackData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject senderGameObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_senderGameObject));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_senderGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int direction
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_direction));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_direction)) = value;
    }
  }

  public HitCastResult hitCastResult
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_hitCastResult);
      return new HitCastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_hitCastResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe bool PerfectHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_PerfectHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackObject.NativeFieldInfoPtr_PerfectHit)) = value;
    }
  }
}
