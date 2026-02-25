// Decompiled with JetBrains decompiler
// Type: ObjectPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ObjectPool(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_root;
  private static readonly System.IntPtr NativeFieldInfoPtr_layer;
  private static readonly System.IntPtr NativeFieldInfoPtr_objLifetime;
  private static readonly System.IntPtr NativeFieldInfoPtr_prefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_pool;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_IPoolable_Int32_Transform_Int32_String_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Virtual_New_IPoolable_Vector3_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasFreeObject_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeObject_Public_Void_IPoolable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeAll_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateObject_Private_IPoolable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Init_b__6_0_Private_Void_ResetToCheckpointEvent_0;

  static ObjectPool()
  {
    Il2CppClassPointerStore<ObjectPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ObjectPool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr);
    ObjectPool.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, nameof (root));
    ObjectPool.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, nameof (layer));
    ObjectPool.NativeFieldInfoPtr_objLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, nameof (objLifetime));
    ObjectPool.NativeFieldInfoPtr_prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, nameof (prefab));
    ObjectPool.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, nameof (eventDisposable));
    ObjectPool.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, nameof (pool));
    ObjectPool.NativeMethodInfoPtr_Init_Public_Void_IPoolable_Int32_Transform_Int32_String_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663619);
    ObjectPool.NativeMethodInfoPtr_GetObject_Public_Virtual_New_IPoolable_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663620);
    ObjectPool.NativeMethodInfoPtr_HasFreeObject_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663621);
    ObjectPool.NativeMethodInfoPtr_FreeObject_Public_Void_IPoolable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663622);
    ObjectPool.NativeMethodInfoPtr_FreeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663623);
    ObjectPool.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663624);
    ObjectPool.NativeMethodInfoPtr_CreateObject_Private_IPoolable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663625);
    ObjectPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663626);
    ObjectPool.NativeMethodInfoPtr__Init_b__6_0_Private_Void_ResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr, 100663627);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 21823, RefRangeEnd = 21835, XrefRangeStart = 21798, XrefRangeEnd = 21823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(
    IPoolable prefab,
    int initialPool,
    Transform root,
    int layer,
    string defaultName = "pooled_object",
    FloatReference objLifetime = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &initialPool;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) root);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(defaultName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objLifetime);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_Init_Public_Void_IPoolable_Int32_Transform_Int32_String_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21835, XrefRangeEnd = 21865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IPoolable GetObject(Vector3 pos, Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ObjectPool.NativeMethodInfoPtr_GetObject_Public_Virtual_New_IPoolable_Vector3_Quaternion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21865, XrefRangeEnd = 21879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasFreeObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_HasFreeObject_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 21887, RefRangeEnd = 21896, XrefRangeStart = 21879, XrefRangeEnd = 21887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeObject(IPoolable obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_FreeObject_Public_Void_IPoolable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 21940, RefRangeEnd = 21955, XrefRangeStart = 21896, XrefRangeEnd = 21940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_FreeAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21955, XrefRangeEnd = 21958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ObjectPool.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 21985, RefRangeEnd = 21986, XrefRangeStart = 21958, XrefRangeEnd = 21985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPoolable CreateObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr_CreateObject_Private_IPoolable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectPool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21986, XrefRangeEnd = 21987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Init_b__6_0(ResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool.NativeMethodInfoPtr__Init_b__6_0_Private_Void_ResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform root
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_root));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int layer
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_layer));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_layer)) = value;
    }
  }

  public unsafe FloatReference objLifetime
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_objLifetime));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_objLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPoolable prefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_prefab));
      return num == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<IPoolable> pool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_pool));
      return num == System.IntPtr.Zero ? (List<IPoolable>) null : Il2CppObjectPool.Get<List<IPoolable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
