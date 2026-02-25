// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipeline
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public class RenderPipeline(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__disposed_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static RenderPipeline()
  {
    Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderPipeline));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr);
    RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, "<disposed>k__BackingField");
    RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670414);
    RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670415);
    RenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670416);
    RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670417);
    RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670418);
    RenderPipeline.NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670419);
    RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670420);
    RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670421);
    RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670422);
    RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670423);
    RenderPipeline.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100670424);
  }

  [CallerCount(0)]
  public virtual unsafe void Render(
    ScriptableRenderContext context,
    Il2CppReferenceArray<Camera> cameras)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &context;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessRenderRequests<RequestData>(
    ScriptableRenderContext context,
    Camera camera,
    RequestData renderRequest)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &context;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    RequestData& local1;
    if (!typeof (RequestData).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<RequestData> local2 = (object) renderRequest;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (RequestData&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (RequestData&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref renderRequest;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipeline.MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(30)]
  [CachedScanResults(RefRangeStart = 274947, RefRangeEnd = 274977, XrefRangeStart = 274947, XrefRangeEnd = 274977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    RequestData& local1;
    if (!typeof (RequestData).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<RequestData> local2 = (object) data;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (RequestData&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (RequestData&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref data;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipeline.MethodInfoStoreGeneric_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0<RequestData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487762, XrefRangeEnd = 487766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Render(ScriptableRenderContext context, List<Camera> cameras)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &context;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487766, XrefRangeEnd = 487773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &context;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487781, RefRangeEnd = 487782, XrefRangeStart = 487773, XrefRangeEnd = 487781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalProcessRenderRequests<RequestData>(
    ScriptableRenderContext context,
    Camera camera,
    RequestData renderRequest)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &context;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    RequestData& local1;
    if (!typeof (RequestData).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<RequestData> local2 = (object) renderRequest;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (RequestData&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (RequestData&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref renderRequest;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(RenderPipeline.MethodInfoStoreGeneric_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  public unsafe bool disposed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487782, XrefRangeEnd = 487786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disposing
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderPipeline()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _disposed_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
    }
  }

  public static void BeginFrameRendering(
    ScriptableRenderContext context,
    Il2CppReferenceArray<Camera> cameras)
  {
    RenderPipelineManager.BeginContextRendering(context, new List<Camera>((IEnumerable<Camera>) cameras));
  }

  public static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
  {
    RenderPipelineManager.BeginContextRendering(context, cameras);
  }

  public static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
  {
    RenderPipelineManager.BeginCameraRendering(context, camera);
  }

  public static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
  {
    RenderPipelineManager.EndContextRendering(context, cameras);
  }

  public static void EndFrameRendering(
    ScriptableRenderContext context,
    Il2CppReferenceArray<Camera> cameras)
  {
    RenderPipelineManager.EndContextRendering(context, new List<Camera>((IEnumerable<Camera>) cameras));
  }

  public static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
  {
    RenderPipelineManager.EndCameraRendering(context, camera);
  }

  public static bool SupportsRenderRequest<RequestData>(Camera camera, RequestData data)
  {
    bool flag = false;
    if ((UnityEngine.Object) GraphicsSettings.currentRenderPipeline != (UnityEngine.Object) null)
    {
      if (RenderPipelineManager.currentPipeline == null)
        Debug.Assert(RenderPipelineManager.TryPrepareRenderPipeline(GraphicsSettings.currentRenderPipeline));
      if (RenderPipelineManager.currentPipeline != null)
        flag = RenderPipelineManager.currentPipeline.IsRenderRequestSupported<RequestData>(camera, data);
    }
    return flag;
  }

  public static void SubmitRenderRequest<RequestData>(Camera camera, RequestData data)
  {
    camera.SubmitRenderRequest<RequestData>(data);
  }

  public virtual RenderPipelineGlobalSettings defaultSettings
  {
    get => (RenderPipelineGlobalSettings) null;
  }

  private sealed class MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0<RequestData>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr))
    }))));
  }

  public class StandardRequest
  {
  }
}
