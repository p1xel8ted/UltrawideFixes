// Decompiled with JetBrains decompiler
// Type: UnityEngine.Pool.PooledObject`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Pool;

public sealed class PooledObject<T> : Il2CppSystem.ValueType where T : class
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ToReturn;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Pool;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

  static PooledObject()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "PooledObject`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr);
    PooledObject<T>.NativeFieldInfoPtr_m_ToReturn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, nameof (m_ToReturn));
    PooledObject<T>.NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, nameof (m_Pool));
    PooledObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, 100669307);
    PooledObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr, 100669308);
  }

  [CallerCount(116)]
  [CachedScanResults(RefRangeStart = 261036, RefRangeEnd = 261152, XrefRangeStart = 261036, XrefRangeEnd = 261152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PooledObject(T value, IObjectPool<T> pool)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) value;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref value;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PooledObject<T>.NativeMethodInfoPtr__ctor_Public_Void_T_IObjectPool_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(59)]
  [CachedScanResults(RefRangeStart = 479393, RefRangeEnd = 479452, XrefRangeStart = 479389, XrefRangeEnd = 479393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void System_IDisposable_Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PooledObject<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PooledObject(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PooledObject()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PooledObject<T>>.NativeClassPtr))
  {
  }

  public unsafe T m_ToReturn
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_ToReturn), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_ToReturn);
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

  public unsafe IObjectPool<T> m_Pool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_Pool));
      return num == System.IntPtr.Zero ? (IObjectPool<T>) null : Il2CppObjectPool.Get<IObjectPool<T>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PooledObject<T>.NativeFieldInfoPtr_m_Pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
