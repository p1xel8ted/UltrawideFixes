// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pool.ObjectPool`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Pool;

public class ObjectPool<T>(System.IntPtr pointer) : Il2CppSystem.Object(pointer) where T : class
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_List;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CreateFunc;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionOnGet;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionOnRelease;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionOnDestroy;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CollectionCheck;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FreshlyReleased;
  private static readonly System.IntPtr NativeFieldInfoPtr__CountAll_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

  static ObjectPool()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "ObjectPool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr);
    ObjectPool<T>.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_List));
    ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_CreateFunc));
    ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_ActionOnGet));
    ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_ActionOnRelease));
    ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_ActionOnDestroy));
    ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_MaxSize));
    ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_CollectionCheck));
    ObjectPool<T>.NativeFieldInfoPtr_m_FreshlyReleased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, nameof (m_FreshlyReleased));
    ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, "<CountAll>k__BackingField");
    ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669298);
    ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669299);
    ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669300);
    ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669301);
    ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669302);
    ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669303);
    ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669304);
    ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669305);
    ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr, 100669306);
  }

  public unsafe int CountAll
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountAll_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 138917, RefRangeEnd = 138918, XrefRangeStart = 138917, XrefRangeEnd = 138918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_set_CountAll_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe int CountInactive
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 479330, RefRangeEnd = 479334, XrefRangeStart = 479330, XrefRangeEnd = 479330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_get_CountInactive_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 479353, RefRangeEnd = 479357, XrefRangeStart = 479334, XrefRangeEnd = 479353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectPool(
    Il2CppSystem.Func<T> createFunc,
    Il2CppSystem.Action<T> actionOnGet = null,
    Il2CppSystem.Action<T> actionOnRelease = null,
    Il2CppSystem.Action<T> actionOnDestroy = null,
    bool collectionCheck = true,
    int defaultCapacity = 10,
    int maxSize = 10000)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectPool<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) createFunc);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionOnGet);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionOnRelease);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionOnDestroy);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &collectionCheck;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &defaultCapacity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr__ctor_Public_Void_Func_1_T_Action_1_T_Action_1_T_Action_1_T_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 479361, RefRangeEnd = 479371, XrefRangeStart = 479357, XrefRangeEnd = 479361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe T Get()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 479375, RefRangeEnd = 479377, XrefRangeStart = 479371, XrefRangeEnd = 479375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PooledObject<T> Get(out T v)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(T*) &zero);
    }
    else
      local1 = ref v;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_PooledObject_1_T_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    if (!typeof (T).IsValueType)
    {
      ref T local2 = ref v;
      System.IntPtr num2 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
      local2 = (T) valueGeneric;
    }
    return new PooledObject<T>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479377, XrefRangeEnd = 479378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Release(T element)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) element;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref element;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 479385, RefRangeEnd = 479388, XrefRangeStart = 479378, XrefRangeEnd = 479385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479388, XrefRangeEnd = 479389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectPool<T>.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<T> m_List
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_List));
      return num == System.IntPtr.Zero ? (List<T>) null : Il2CppObjectPool.Get<List<T>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Func<T> m_CreateFunc
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<T>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<T>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CreateFunc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<T> m_ActionOnGet
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<T>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<T>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnGet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<T> m_ActionOnRelease
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<T>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<T>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnRelease), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<T> m_ActionOnDestroy
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<T>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<T>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_ActionOnDestroy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_MaxSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_MaxSize)) = value;
    }
  }

  public unsafe bool m_CollectionCheck
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_CollectionCheck)) = value;
    }
  }

  public unsafe T m_FreshlyReleased
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_FreshlyReleased), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr_m_FreshlyReleased);
      System.Type type = typeof (T);
      if (!type.IsValueType)
      {
        if (!string.Equals(type.FullName, "System.String"))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
          if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
          {
            System.IntPtr num2 = ptr;
            System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
            int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
            __memcpy(num1, num3, num4);
          }
          else
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
        }
        else
        {
          System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
        }
      }
      else
      {
        T obj = value;
        *(T*) num1 = obj;
      }
    }
  }

  public unsafe int _CountAll_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectPool<T>.NativeFieldInfoPtr__CountAll_k__BackingField)) = value;
    }
  }

  public int CountActive => this.CountAll - this.CountInactive;

  public bool HasElement(T element)
  {
    return (object) ((ObjectPool<>) this).m_FreshlyReleased == (object) element || ((ObjectPool<>) this).m_List.Contains(element);
  }
}
