// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIRenderingParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class UIRenderingParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_camera;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_postProcessingIsRequired;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_nonJitteredProjectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_nonJitteredProjectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Private_Static_Boolean_byref_ScriptableRenderContext_Camera_byref_CullingResults_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_CoreParams_0;

  static UIRenderingParams()
  {
    Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIRenderingParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr);
    UIRenderingParams.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (camera));
    UIRenderingParams.NativeFieldInfoPtr_renderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (renderTargetSize));
    UIRenderingParams.NativeFieldInfoPtr_renderCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (renderCamera));
    UIRenderingParams.NativeFieldInfoPtr_cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (cullingResults));
    UIRenderingParams.NativeFieldInfoPtr_postProcessingIsRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (postProcessingIsRequired));
    UIRenderingParams.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (viewMatrix));
    UIRenderingParams.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (projectionMatrix));
    UIRenderingParams.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (projectionViewMatrix));
    UIRenderingParams.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (invProjectionViewMatrix));
    UIRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (nonJitteredProjectionMatrix));
    UIRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (nonJitteredProjectionViewMatrix));
    UIRenderingParams.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, nameof (depthProjectionParams));
    UIRenderingParams.NativeMethodInfoPtr_Cull_Private_Static_Boolean_byref_ScriptableRenderContext_Camera_byref_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, 100663659);
    UIRenderingParams.NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_CoreParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr, 100663660);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927324, XrefRangeEnd = 927335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Cull(
    [In] ref ScriptableRenderContext ctx,
    Camera camera,
    out CullingResults cullingResults)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIRenderingParams.NativeMethodInfoPtr_Cull_Private_Static_Boolean_byref_ScriptableRenderContext_Camera_byref_CullingResults_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 927363, RefRangeEnd = 927366, XrefRangeStart = 927335, XrefRangeEnd = 927363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIRenderingParams(
    [In] ref ScriptableRenderContext ctx,
    Camera camera,
    CoreParams coreParams)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &coreParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderingParams.NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_CoreParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public UIRenderingParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public UIRenderingParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderingParams>.NativeClassPtr))
  {
  }

  public unsafe Camera camera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_camera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2Int renderTargetSize
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_renderTargetSize));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_renderTargetSize)) = value;
    }
  }

  public unsafe bool renderCamera
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_renderCamera));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_renderCamera)) = value;
    }
  }

  public unsafe CullingResults cullingResults
  {
    get
    {
      return *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_cullingResults));
    }
    [param: In] set
    {
      *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_cullingResults)) = value;
    }
  }

  public unsafe bool postProcessingIsRequired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_postProcessingIsRequired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_postProcessingIsRequired)) = value;
    }
  }

  public unsafe Matrix4x4 viewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_viewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_viewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 projectionMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_projectionMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_projectionMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 projectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_projectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_projectionViewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 invProjectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_invProjectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_invProjectionViewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 nonJitteredProjectionMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 nonJitteredProjectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix)) = value;
    }
  }

  public unsafe Vector4 depthProjectionParams
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_depthProjectionParams));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIRenderingParams.NativeFieldInfoPtr_depthProjectionParams)) = value;
    }
  }
}
