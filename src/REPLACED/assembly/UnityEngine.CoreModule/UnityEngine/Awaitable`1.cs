// Decompiled with JetBrains decompiler
// Type: UnityEngine.Awaitable`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Pool;

#nullable disable
namespace UnityEngine;

public class Awaitable<T>(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__pool;
  private static readonly System.IntPtr NativeFieldInfoPtr__awaitable;
  private static readonly System.IntPtr NativeFieldInfoPtr__result;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueWith_Private_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Private_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Awaiter_T_0;

  static Awaitable()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Awaitable`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr);
    Awaitable<T>.NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, nameof (_pool));
    Awaitable<T>.NativeFieldInfoPtr__awaitable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, nameof (_awaitable));
    Awaitable<T>.NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, nameof (_result));
    Awaitable<T>.NativeMethodInfoPtr_ContinueWith_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, 100667937);
    Awaitable<T>.NativeMethodInfoPtr_GetResult_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, 100667938);
    Awaitable<T>.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, 100667939);
    Awaitable<T>.NativeMethodInfoPtr_GetAwaiter_Public_Awaiter_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, 100667940);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443485, XrefRangeEnd = 443488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContinueWith(Il2CppSystem.Action continuation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) continuation)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.NativeMethodInfoPtr_ContinueWith_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443488, XrefRangeEnd = 443501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetResult()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.NativeMethodInfoPtr_GetResult_Private_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Awaitable()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443501, XrefRangeEnd = 443502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Awaitable<T>.Awaiter GetAwaiter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.NativeMethodInfoPtr_GetAwaiter_Public_Awaiter_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Awaitable<T>.Awaiter(pointer);
  }

  public static unsafe ThreadLocal<ObjectPool<Awaitable<T>>> _pool
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Awaitable<T>.NativeFieldInfoPtr__pool, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ThreadLocal<ObjectPool<Awaitable<T>>>) null : Il2CppObjectPool.Get<ThreadLocal<ObjectPool<Awaitable<T>>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable<T>.NativeFieldInfoPtr__pool, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Awaitable _awaitable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable<T>.NativeFieldInfoPtr__awaitable));
      return num == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable<T>.NativeFieldInfoPtr__awaitable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe T _result
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<T>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable<T>.NativeFieldInfoPtr__result), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable<T>.NativeFieldInfoPtr__result);
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

  public void SetResultAndRaiseContinuation(T result)
  {
    ((Awaitable<>) this)._result = result;
    ((Awaitable<>) this)._awaitable.RaiseManagedCompletion();
  }

  public void SetExceptionAndRaiseContinuation(Il2CppSystem.Exception exception)
  {
    ((Awaitable<>) this)._awaitable.RaiseManagedCompletion(exception);
  }

  public Awaitable.AwaiterCompletionThreadAffinity CompletionThreadAffinity
  {
    get => ((Awaitable<>) this)._awaitable.CompletionThreadAffinity;
    set => ((Awaitable<>) this)._awaitable.CompletionThreadAffinity = value;
  }

  public void Cancel() => ((Awaitable<>) this)._awaitable.Cancel();

  public static Awaitable<T> GetManaged()
  {
    Awaitable awaitable = Awaitable.NewManagedAwaitable();
    Awaitable<T> managed = Awaitable<>._pool.Value.Get();
    ((Awaitable<>) managed)._awaitable = awaitable;
    return managed;
  }

  public sealed class Awaiter : Il2CppSystem.ValueType, INotifyCompletion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__coroutine;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Awaitable_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_T_0;

    static Awaiter()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, nameof (Awaiter<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr);
      Awaitable<T>.Awaiter.NativeFieldInfoPtr__coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr, nameof (_coroutine));
      Awaitable<T>.Awaiter.NativeMethodInfoPtr__ctor_Public_Void_Awaitable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr, 100667942);
      Awaitable<T>.Awaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr, 100667943);
      Awaitable<T>.Awaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr, 100667944);
      Awaitable<T>.Awaiter.NativeMethodInfoPtr_GetResult_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr, 100667945);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Awaiter(Awaitable<T> coroutine)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coroutine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.Awaiter.NativeMethodInfoPtr__ctor_Public_Void_Awaitable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443450, XrefRangeEnd = 443460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnCompleted(Il2CppSystem.Action continuation)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) continuation)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.Awaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool IsCompleted
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443460, XrefRangeEnd = 443466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.Awaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443466, XrefRangeEnd = 443471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe T GetResult()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.Awaiter.NativeMethodInfoPtr_GetResult_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }

    public Awaiter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Awaiter()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable<T>.Awaiter>.NativeClassPtr))
    {
    }

    public unsafe Awaitable<T> _coroutine
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable<T>.Awaiter.NativeFieldInfoPtr__coroutine));
        return num == System.IntPtr.Zero ? (Awaitable<T>) null : Il2CppObjectPool.Get<Awaitable<T>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable<T>.Awaiter.NativeFieldInfoPtr__coroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public void OnCompleted(System.Action continuation) => this.OnCompleted((Il2CppSystem.Action) continuation);
  }

  [ObfuscatedName("UnityEngine.Awaitable`1+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__15_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__15_0_Internal_ObjectPool_1_Awaitable_1_T_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__15_1_Internal_Awaitable_1_T_0;

    static __c()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr);
      Awaitable<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr, "<>9");
      Awaitable<T>.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr, "<>9__15_1");
      Awaitable<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr, 100667947);
      Awaitable<T>.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_ObjectPool_1_Awaitable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr, 100667948);
      Awaitable<T>.__c.NativeMethodInfoPtr___cctor_b__15_1_Internal_Awaitable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr, 100667949);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable<T>.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443471, XrefRangeEnd = 443483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectPool<Awaitable<T>> __cctor_b__15_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.__c.NativeMethodInfoPtr___cctor_b__15_0_Internal_ObjectPool_1_Awaitable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ObjectPool<Awaitable<T>>) null : Il2CppObjectPool.Get<ObjectPool<Awaitable<T>>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443483, XrefRangeEnd = 443485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Awaitable<T> __cctor_b__15_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable<T>.__c.NativeMethodInfoPtr___cctor_b__15_1_Internal_Awaitable_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Awaitable<T>) null : Il2CppObjectPool.Get<Awaitable<T>>(num3);
    }

    public static unsafe Awaitable<T>.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Awaitable<T>.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Awaitable<T>.__c) null : Il2CppObjectPool.Get<Awaitable<T>.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable<T>.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Awaitable<T>> __9__15_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Awaitable<T>.__c.NativeFieldInfoPtr___9__15_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Awaitable<T>>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Awaitable<T>>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable<T>.__c.NativeFieldInfoPtr___9__15_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
