// Decompiled with JetBrains decompiler
// Type: GuidReference
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Serializable]
public class GuidReference(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cachedReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_isCacheSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_serializedGuid;
  private static readonly System.IntPtr NativeFieldInfoPtr_guid;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnGuidAdded;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnGuidRemoved;
  private static readonly System.IntPtr NativeFieldInfoPtr_addDelegate;
  private static readonly System.IntPtr NativeFieldInfoPtr_removeDelegate;
  private static readonly System.IntPtr NativeFieldInfoPtr_cachedComponents;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnGuidAdded_Public_add_Void_Action_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnGuidAdded_Public_rem_Void_Action_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnGuidRemoved_Public_add_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnGuidRemoved_Public_rem_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_gameObject_Private_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuidComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GuidAdded_Private_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GuidRemoved_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromGuid_Public_T_0;

  static GuidReference()
  {
    Il2CppClassPointerStore<GuidReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "", nameof (GuidReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidReference>.NativeClassPtr);
    GuidReference.NativeFieldInfoPtr_cachedReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (cachedReference));
    GuidReference.NativeFieldInfoPtr_isCacheSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (isCacheSet));
    GuidReference.NativeFieldInfoPtr_serializedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (serializedGuid));
    GuidReference.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (guid));
    GuidReference.NativeFieldInfoPtr_OnGuidAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (OnGuidAdded));
    GuidReference.NativeFieldInfoPtr_OnGuidRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (OnGuidRemoved));
    GuidReference.NativeFieldInfoPtr_addDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (addDelegate));
    GuidReference.NativeFieldInfoPtr_removeDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (removeDelegate));
    GuidReference.NativeFieldInfoPtr_cachedComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, nameof (cachedComponents));
    GuidReference.NativeMethodInfoPtr_add_OnGuidAdded_Public_add_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663322 /*0x0600001A*/);
    GuidReference.NativeMethodInfoPtr_remove_OnGuidAdded_Public_rem_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663323 /*0x0600001B*/);
    GuidReference.NativeMethodInfoPtr_add_OnGuidRemoved_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663324 /*0x0600001C*/);
    GuidReference.NativeMethodInfoPtr_remove_OnGuidRemoved_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663325 /*0x0600001D*/);
    GuidReference.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663326 /*0x0600001E*/);
    GuidReference.NativeMethodInfoPtr_set_gameObject_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663327 /*0x0600001F*/);
    GuidReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663328 /*0x06000020*/);
    GuidReference.NativeMethodInfoPtr__ctor_Public_Void_GuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663329 /*0x06000021*/);
    GuidReference.NativeMethodInfoPtr_GuidAdded_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663330 /*0x06000022*/);
    GuidReference.NativeMethodInfoPtr_GuidRemoved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663331 /*0x06000023*/);
    GuidReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663332 /*0x06000024*/);
    GuidReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663333 /*0x06000025*/);
    GuidReference.NativeMethodInfoPtr_GetComponentFromGuid_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, 100663334 /*0x06000026*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360190, XrefRangeEnd = 360195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnGuidAdded(Il2CppSystem.Action<GameObject> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_add_OnGuidAdded_Public_add_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360195, XrefRangeEnd = 360200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnGuidAdded(Il2CppSystem.Action<GameObject> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_remove_OnGuidAdded_Public_rem_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360200, XrefRangeEnd = 360204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnGuidRemoved(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_add_OnGuidRemoved_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360204, XrefRangeEnd = 360208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnGuidRemoved(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_remove_OnGuidRemoved_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject gameObject
  {
    [CallerCount(68), CachedScanResults(RefRangeStart = 360215, RefRangeEnd = 360283, XrefRangeStart = 360208, XrefRangeEnd = 360215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_get_gameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
    [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_set_gameObject_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360283, XrefRangeEnd = 360310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GuidReference()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidReference>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360310, XrefRangeEnd = 360340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GuidReference(GuidComponent target)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidReference>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr__ctor_Public_Void_GuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360340, XrefRangeEnd = 360341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GuidAdded(GameObject go)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_GuidAdded_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360341, XrefRangeEnd = 360342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GuidRemoved()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_GuidRemoved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360342, XrefRangeEnd = 360343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360343, XrefRangeEnd = 360359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidReference.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(102)]
  [CachedScanResults(RefRangeStart = 360379, RefRangeEnd = 360481, XrefRangeStart = 360359, XrefRangeEnd = 360379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetComponentFromGuid<T>() where T : Component
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidReference.MethodInfoStoreGeneric_GetComponentFromGuid_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  public unsafe GameObject cachedReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_cachedReference));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_cachedReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isCacheSet
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_isCacheSet));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_isCacheSet)) = value;
    }
  }

  public unsafe Il2CppStructArray<byte> serializedGuid
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_serializedGuid));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_serializedGuid), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Guid guid
  {
    get
    {
      return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_guid));
    }
    [param: In] set
    {
      *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_guid)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<GameObject> OnGuidAdded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_OnGuidAdded));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_OnGuidAdded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action OnGuidRemoved
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_OnGuidRemoved));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_OnGuidRemoved), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<GameObject> addDelegate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_addDelegate));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_addDelegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action removeDelegate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_removeDelegate));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_removeDelegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, Component> cachedComponents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_cachedComponents));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, Component>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Component>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidReference.NativeFieldInfoPtr_cachedComponents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("GuidReference+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__16_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__16_1_Internal_Void_0;

    static __c()
    {
      Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuidReference>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr);
      GuidReference.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, "<>9");
      GuidReference.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, "<>9__15_0");
      GuidReference.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, "<>9__15_1");
      GuidReference.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, "<>9__16_0");
      GuidReference.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, "<>9__16_1");
      GuidReference.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, 100663336 /*0x06000028*/);
      GuidReference.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, 100663337 /*0x06000029*/);
      GuidReference.__c.NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, 100663338 /*0x0600002A*/);
      GuidReference.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, 100663339 /*0x0600002B*/);
      GuidReference.__c.NativeMethodInfoPtr___ctor_b__16_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr, 100663340 /*0x0600002C*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidReference.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidReference.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __ctor_b__15_0(GameObject go)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidReference.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __ctor_b__15_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidReference.__c.NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __ctor_b__16_0(GameObject go)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidReference.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __ctor_b__16_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidReference.__c.NativeMethodInfoPtr___ctor_b__16_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe GuidReference.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GuidReference.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GuidReference.__c) null : Il2CppObjectPool.Get<GuidReference.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GuidReference.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<GameObject> __9__15_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GuidReference.__c.NativeFieldInfoPtr___9__15_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GuidReference.__c.NativeFieldInfoPtr___9__15_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action __9__15_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GuidReference.__c.NativeFieldInfoPtr___9__15_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GuidReference.__c.NativeFieldInfoPtr___9__15_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<GameObject> __9__16_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GuidReference.__c.NativeFieldInfoPtr___9__16_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GuidReference.__c.NativeFieldInfoPtr___9__16_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action __9__16_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GuidReference.__c.NativeFieldInfoPtr___9__16_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GuidReference.__c.NativeFieldInfoPtr___9__16_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromGuid_Public_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GuidReference.NativeMethodInfoPtr_GetComponentFromGuid_Public_T_0, Il2CppClassPointerStore<GuidReference>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
