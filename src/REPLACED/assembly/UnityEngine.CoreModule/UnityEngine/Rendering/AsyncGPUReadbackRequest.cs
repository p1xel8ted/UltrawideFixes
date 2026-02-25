// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.AsyncGPUReadbackRequest
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AsyncGPUReadbackRequest
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_done_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDone_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasError_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerCount_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Action_1_AsyncGPUReadbackRequest_AsyncGPUReadbackRequest_0;
  [FieldOffset(0)]
  public System.IntPtr m_Ptr;
  [FieldOffset(8)]
  public int m_Version;
  private static readonly AsyncGPUReadbackRequest.UpdateDelegate UpdateDelegateField;
  private static readonly AsyncGPUReadbackRequest.GetWidthDelegate GetWidthDelegateField;
  private static readonly AsyncGPUReadbackRequest.GetHeightDelegate GetHeightDelegateField;
  private static readonly AsyncGPUReadbackRequest.GetDepthDelegate GetDepthDelegateField;
  private static readonly AsyncGPUReadbackRequest.GetForcePlayerLoopUpdateDelegate GetForcePlayerLoopUpdateDelegateField;
  private static readonly AsyncGPUReadbackRequest.SetForcePlayerLoopUpdateDelegate SetForcePlayerLoopUpdateDelegateField;

  static AsyncGPUReadbackRequest()
  {
    Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (AsyncGPUReadbackRequest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr);
    AsyncGPUReadbackRequest.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, nameof (m_Ptr));
    AsyncGPUReadbackRequest.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, nameof (m_Version));
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669611);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669612);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_done_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669613);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669614);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669615);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669616);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669617);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669618);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669619);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669620);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669621);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669622);
    AsyncGPUReadbackRequest.NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Action_1_AsyncGPUReadbackRequest_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, 100669623);
    AsyncGPUReadbackRequest.UpdateDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.UpdateDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::Update");
    AsyncGPUReadbackRequest.GetWidthDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetWidthDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetWidth");
    AsyncGPUReadbackRequest.GetHeightDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetHeightDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetHeight");
    AsyncGPUReadbackRequest.GetDepthDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetDepthDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetDepth");
    AsyncGPUReadbackRequest.GetForcePlayerLoopUpdateDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.GetForcePlayerLoopUpdateDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::GetForcePlayerLoopUpdate");
    AsyncGPUReadbackRequest.SetForcePlayerLoopUpdateDelegateField = IL2CPP.ResolveICall<AsyncGPUReadbackRequest.SetForcePlayerLoopUpdateDelegate>("UnityEngine.Rendering.AsyncGPUReadbackRequest::SetForcePlayerLoopUpdate");
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481965, RefRangeEnd = 481967, XrefRangeStart = 481963, XrefRangeEnd = 481965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void WaitForCompletion()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_WaitForCompletion_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481975, RefRangeEnd = 481976, XrefRangeStart = 481967, XrefRangeEnd = 481975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeArray<T> GetData<T>(int layer = 0) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &layer
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new NativeArray<T>(pointer);
  }

  public unsafe bool done
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 481978, RefRangeEnd = 481982, XrefRangeStart = 481976, XrefRangeEnd = 481978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_done_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool hasError
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 481984, RefRangeEnd = 481987, XrefRangeStart = 481982, XrefRangeEnd = 481984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_hasError_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int layerCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 481989, RefRangeEnd = 481990, XrefRangeStart = 481987, XrefRangeEnd = 481989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int layerDataSize
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 481992, RefRangeEnd = 481993, XrefRangeStart = 481990, XrefRangeEnd = 481992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_get_layerDataSize_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 481978, RefRangeEnd = 481982, XrefRangeStart = 481978, XrefRangeEnd = 481982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsDone()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_IsDone_Private_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 481984, RefRangeEnd = 481987, XrefRangeStart = 481984, XrefRangeEnd = 481987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasError()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_HasError_Private_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481989, RefRangeEnd = 481990, XrefRangeStart = 481989, XrefRangeEnd = 481990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetLayerCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerCount_Private_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481992, RefRangeEnd = 481993, XrefRangeStart = 481992, XrefRangeEnd = 481993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetLayerDataSize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetLayerDataSize_Private_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481993, XrefRangeEnd = 481995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetScriptingCallback(Il2CppSystem.Action<AsyncGPUReadbackRequest> callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_SetScriptingCallback_Internal_Void_Action_1_AsyncGPUReadbackRequest_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481997, RefRangeEnd = 481998, XrefRangeStart = 481995, XrefRangeEnd = 481997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe System.IntPtr GetDataRaw(int layer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &layer
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetDataRaw_Private_IntPtr_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe void InvokeCallback(
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback,
    AsyncGPUReadbackRequest obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &obj;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadbackRequest.NativeMethodInfoPtr_InvokeCallback_Private_Static_Void_Action_1_AsyncGPUReadbackRequest_AsyncGPUReadbackRequest_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void Update()
  {
    AsyncGPUReadbackRequest.UpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public int width => this.GetWidth();

  public int height => this.GetHeight();

  public int depth => this.GetDepth();

  public bool forcePlayerLoopUpdate
  {
    get => this.GetForcePlayerLoopUpdate();
    set => this.SetForcePlayerLoopUpdate(value);
  }

  public int GetWidth()
  {
    return AsyncGPUReadbackRequest.GetWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public int GetHeight()
  {
    return AsyncGPUReadbackRequest.GetHeightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public int GetDepth()
  {
    return AsyncGPUReadbackRequest.GetDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public bool GetForcePlayerLoopUpdate()
  {
    return AsyncGPUReadbackRequest.GetForcePlayerLoopUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void SetForcePlayerLoopUpdate(bool b)
  {
    AsyncGPUReadbackRequest.SetForcePlayerLoopUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this), b);
  }

  private sealed class MethodInfoStoreGeneric_GetData_Public_NativeArray_1_T_Int32_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncGPUReadbackRequest.NativeMethodInfoPtr_GetData_Public_NativeArray_1_T_Int32_0, Il2CppClassPointerStore<AsyncGPUReadbackRequest>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate void UpdateDelegate(System.IntPtr _param1);

  private delegate int GetWidthDelegate(System.IntPtr _param1);

  private delegate int GetHeightDelegate(System.IntPtr _param1);

  private delegate int GetDepthDelegate(System.IntPtr _param1);

  private delegate bool GetForcePlayerLoopUpdateDelegate(System.IntPtr _param1);

  private delegate void SetForcePlayerLoopUpdateDelegate(System.IntPtr _param1, bool b);
}
