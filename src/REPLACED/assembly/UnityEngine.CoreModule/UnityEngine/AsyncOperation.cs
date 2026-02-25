// Decompiled with JetBrains decompiler
// Type: UnityEngine.AsyncOperation
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class AsyncOperation(System.IntPtr pointer) : YieldInstruction(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_completeCallback;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetManagedObject_Private_Static_Void_IntPtr_AsyncOperation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_progress_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_allowSceneActivation_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isDone_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_progress_Injected_Private_Static_Single_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_priority_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_allowSceneActivation_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_allowSceneActivation_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly AsyncOperation.get_priority_InjectedDelegate get_priority_InjectedDelegateField;

  static AsyncOperation()
  {
    Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AsyncOperation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr);
    AsyncOperation.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, nameof (m_Ptr));
    AsyncOperation.NativeFieldInfoPtr_m_completeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, nameof (m_completeCallback));
    AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667825);
    AsyncOperation.NativeMethodInfoPtr_InternalSetManagedObject_Private_Static_Void_IntPtr_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667826);
    AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667827);
    AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667829);
    AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667830);
    AsyncOperation.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667831);
    AsyncOperation.NativeMethodInfoPtr_get_allowSceneActivation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667832);
    AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667833);
    AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667834);
    AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667835);
    AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667836);
    AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667837);
    AsyncOperation.NativeMethodInfoPtr_get_isDone_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667838);
    AsyncOperation.NativeMethodInfoPtr_get_progress_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667839);
    AsyncOperation.NativeMethodInfoPtr_set_priority_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667840);
    AsyncOperation.NativeMethodInfoPtr_get_allowSceneActivation_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667841);
    AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, 100667842);
    AsyncOperation.get_priority_InjectedDelegateField = IL2CPP.ResolveICall<AsyncOperation.get_priority_InjectedDelegate>("UnityEngine.AsyncOperation::get_priority_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442446, XrefRangeEnd = 442448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InternalDestroy(System.IntPtr ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ptr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442448, XrefRangeEnd = 442450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InternalSetManagedObject(System.IntPtr ptr, AsyncOperation self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ptr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InternalSetManagedObject_Private_Static_Void_IntPtr_AsyncOperation_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AsyncOperation()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool isDone
  {
    [CallerCount(44), CachedScanResults(RefRangeStart = 442454, RefRangeEnd = 442498, XrefRangeStart = 442450, XrefRangeEnd = 442454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float progress
  {
    [CallerCount(17), CachedScanResults(RefRangeStart = 442502, RefRangeEnd = 442519, XrefRangeStart = 442498, XrefRangeEnd = 442502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_progress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int priority
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 442523, RefRangeEnd = 442524, XrefRangeStart = 442519, XrefRangeEnd = 442523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      System.IntPtr native = AsyncOperation.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return AsyncOperation.get_priority_Injected(native);
    }
  }

  public unsafe bool allowSceneActivation
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 442528, RefRangeEnd = 442530, XrefRangeStart = 442524, XrefRangeEnd = 442528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_allowSceneActivation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 442534, RefRangeEnd = 442539, XrefRangeStart = 442530, XrefRangeEnd = 442534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442539, XrefRangeEnd = 442544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AsyncOperation.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void InvokeCompletionEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_InvokeCompletionEvent_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(33)]
  [CachedScanResults(RefRangeStart = 442550, RefRangeEnd = 442583, XrefRangeStart = 442544, XrefRangeEnd = 442550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_completed(Il2CppSystem.Action<AsyncOperation> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_add_completed_Public_add_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 442586, RefRangeEnd = 442604, XrefRangeStart = 442583, XrefRangeEnd = 442586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_completed(Il2CppSystem.Action<AsyncOperation> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_remove_completed_Public_rem_Void_Action_1_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442604, XrefRangeEnd = 442606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_isDone_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_isDone_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442606, XrefRangeEnd = 442608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_progress_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_progress_Injected_Private_Static_Single_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442608, XrefRangeEnd = 442610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_priority_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_priority_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442610, XrefRangeEnd = 442612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_allowSceneActivation_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_get_allowSceneActivation_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442612, XrefRangeEnd = 442614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_allowSceneActivation_Injected(System.IntPtr _unity_self, bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncOperation.NativeMethodInfoPtr_set_allowSceneActivation_Injected_Private_Static_Void_IntPtr_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<AsyncOperation> m_completeCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<AsyncOperation>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<AsyncOperation>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncOperation.NativeFieldInfoPtr_m_completeCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static int get_priority_Injected(System.IntPtr _unity_self)
  {
    return AsyncOperation.get_priority_InjectedDelegateField(_unity_self);
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_AsyncOperation_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AsyncOperation_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<AsyncOperation.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncOperation>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperation.BindingsMarshaller>.NativeClassPtr);
      AsyncOperation.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_AsyncOperation_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation.BindingsMarshaller>.NativeClassPtr, 100667843);
      AsyncOperation.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperation.BindingsMarshaller>.NativeClassPtr, 100667844);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442440, XrefRangeEnd = 442446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AsyncOperation ConvertToManaged(System.IntPtr ptr)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &ptr
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.BindingsMarshaller.NativeMethodInfoPtr_ConvertToManaged_Public_Static_AsyncOperation_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(AsyncOperation asyncOperation)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asyncOperation)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncOperation.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AsyncOperation_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private delegate int get_priority_InjectedDelegate(System.IntPtr _unity_self);
}
