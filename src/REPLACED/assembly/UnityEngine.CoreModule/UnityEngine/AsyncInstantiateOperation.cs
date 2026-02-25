// Decompiled with JetBrains decompiler
// Type: UnityEngine.AsyncInstantiateOperation
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class AsyncInstantiateOperation(System.IntPtr pointer) : AsyncOperation(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_GlobalCancellation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Result;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CancellationToken;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Result_Public_get_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCancellationRequested_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_New_Il2CppReferenceArray_1_Object_Int32_0;
  private static readonly AsyncInstantiateOperation.get_IntegrationTimeMSDelegate get_IntegrationTimeMSDelegateField;
  private static readonly AsyncInstantiateOperation.set_IntegrationTimeMSDelegate set_IntegrationTimeMSDelegateField;
  private static readonly AsyncInstantiateOperation.IsWaitingForSceneActivation_InjectedDelegate IsWaitingForSceneActivation_InjectedDelegateField;
  private static readonly AsyncInstantiateOperation.WaitForCompletion_InjectedDelegate WaitForCompletion_InjectedDelegateField;
  private static readonly AsyncInstantiateOperation.Cancel_InjectedDelegate Cancel_InjectedDelegateField;

  static AsyncInstantiateOperation()
  {
    Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AsyncInstantiateOperation));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr);
    AsyncInstantiateOperation.NativeFieldInfoPtr_s_GlobalCancellation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, nameof (s_GlobalCancellation));
    AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, nameof (m_Result));
    AsyncInstantiateOperation.NativeFieldInfoPtr_m_CancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, nameof (m_CancellationToken));
    AsyncInstantiateOperation.NativeMethodInfoPtr_get_Result_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100667816);
    AsyncInstantiateOperation.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100667817);
    AsyncInstantiateOperation.NativeMethodInfoPtr_IsCancellationRequested_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100667818);
    AsyncInstantiateOperation.NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_New_Il2CppReferenceArray_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr, 100667819);
    AsyncInstantiateOperation.get_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.get_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::get_IntegrationTimeMS");
    AsyncInstantiateOperation.set_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.set_IntegrationTimeMSDelegate>("UnityEngine.AsyncInstantiateOperation::set_IntegrationTimeMS");
    AsyncInstantiateOperation.IsWaitingForSceneActivation_InjectedDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.IsWaitingForSceneActivation_InjectedDelegate>("UnityEngine.AsyncInstantiateOperation::IsWaitingForSceneActivation_Injected");
    AsyncInstantiateOperation.WaitForCompletion_InjectedDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.WaitForCompletion_InjectedDelegate>("UnityEngine.AsyncInstantiateOperation::WaitForCompletion_Injected");
    AsyncInstantiateOperation.Cancel_InjectedDelegateField = IL2CPP.ResolveICall<AsyncInstantiateOperation.Cancel_InjectedDelegate>("UnityEngine.AsyncInstantiateOperation::Cancel_Injected");
  }

  public unsafe Il2CppReferenceArray<Object> Result
  {
    [CallerCount(86), CachedScanResults(RefRangeStart = 331337, RefRangeEnd = 331423, XrefRangeStart = 331337, XrefRangeEnd = 331423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation.NativeMethodInfoPtr_get_Result_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442410, RefRangeEnd = 442411, XrefRangeStart = 442397, XrefRangeEnd = 442410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AsyncInstantiateOperation(System.IntPtr ptr, CancellationToken cancellationToken)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncInstantiateOperation>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ptr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation.NativeMethodInfoPtr__ctor_Protected_Void_IntPtr_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442411, XrefRangeEnd = 442421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsCancellationRequested()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncInstantiateOperation.NativeMethodInfoPtr_IsCancellationRequested_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442421, XrefRangeEnd = 442424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<Object> CreateResultArray(int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &size
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AsyncInstantiateOperation.NativeMethodInfoPtr_CreateResultArray_Internal_Virtual_New_Il2CppReferenceArray_1_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  public static unsafe CancellationTokenSource s_GlobalCancellation
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(AsyncInstantiateOperation.NativeFieldInfoPtr_s_GlobalCancellation, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AsyncInstantiateOperation.NativeFieldInfoPtr_s_GlobalCancellation, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Object> m_Result
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_Result), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CancellationToken m_CancellationToken
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_CancellationToken);
      return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncInstantiateOperation.NativeFieldInfoPtr_m_CancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public bool IsWaitingForSceneActivation()
  {
    System.IntPtr native = AsyncInstantiateOperation.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return AsyncInstantiateOperation.IsWaitingForSceneActivation_Injected(native);
  }

  public void WaitForCompletion()
  {
    System.IntPtr native = AsyncInstantiateOperation.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    AsyncInstantiateOperation.WaitForCompletion_Injected(native);
  }

  public void Cancel()
  {
    System.IntPtr native = AsyncInstantiateOperation.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    AsyncInstantiateOperation.Cancel_Injected(native);
  }

  public static float IntegrationTimeMS
  {
    get => AsyncInstantiateOperation.get_IntegrationTimeMSDelegateField();
    set => AsyncInstantiateOperation.set_IntegrationTimeMSDelegateField(value);
  }

  public static float GetIntegrationTimeMS() => AsyncInstantiateOperation.IntegrationTimeMS;

  public static void SetIntegrationTimeMS(float integrationTimeMS)
  {
    AsyncInstantiateOperation.IntegrationTimeMS = (double) integrationTimeMS > 0.0 ? integrationTimeMS : throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (integrationTimeMS), "integrationTimeMS was out of range. Must be greater than zero.");
  }

  public static bool IsWaitingForSceneActivation_Injected(System.IntPtr _unity_self)
  {
    return AsyncInstantiateOperation.IsWaitingForSceneActivation_InjectedDelegateField(_unity_self);
  }

  public static void WaitForCompletion_Injected(System.IntPtr _unity_self)
  {
    AsyncInstantiateOperation.WaitForCompletion_InjectedDelegateField(_unity_self);
  }

  public static void Cancel_Injected(System.IntPtr _unity_self)
  {
    AsyncInstantiateOperation.Cancel_InjectedDelegateField(_unity_self);
  }

  public new static class BindingsMarshaller
  {
  }

  private delegate float get_IntegrationTimeMSDelegate();

  private delegate void set_IntegrationTimeMSDelegate(float value);

  private delegate bool IsWaitingForSceneActivation_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void WaitForCompletion_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void Cancel_InjectedDelegate(System.IntPtr _unity_self);
}
