// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PreviewCameraFrameParams
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

public sealed class PreviewCameraFrameParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_camera;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrixInv;
  private static readonly System.IntPtr NativeFieldInfoPtr_depthProjectionParams;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraLightIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraLightTint;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Private_Static_CullingResults_byref_ScriptableRenderContext_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_0;

  static PreviewCameraFrameParams()
  {
    Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PreviewCameraFrameParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr);
    PreviewCameraFrameParams.NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (camera));
    PreviewCameraFrameParams.NativeFieldInfoPtr_cullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (cullingResults));
    PreviewCameraFrameParams.NativeFieldInfoPtr_renderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (renderTargetSize));
    PreviewCameraFrameParams.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (projectionViewMatrix));
    PreviewCameraFrameParams.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (projectionMatrix));
    PreviewCameraFrameParams.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (viewMatrix));
    PreviewCameraFrameParams.NativeFieldInfoPtr_viewMatrixInv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (viewMatrixInv));
    PreviewCameraFrameParams.NativeFieldInfoPtr_depthProjectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (depthProjectionParams));
    PreviewCameraFrameParams.NativeFieldInfoPtr_cameraLightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (cameraLightIntensity));
    PreviewCameraFrameParams.NativeFieldInfoPtr_cameraLightTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, nameof (cameraLightTint));
    PreviewCameraFrameParams.NativeMethodInfoPtr_Cull_Private_Static_CullingResults_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, 100663492 /*0x060000C4*/);
    PreviewCameraFrameParams.NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr, 100663493 /*0x060000C5*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925471, XrefRangeEnd = 925481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CullingResults Cull([In] ref ScriptableRenderContext ctx, Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PreviewCameraFrameParams.NativeMethodInfoPtr_Cull_Private_Static_CullingResults_byref_ScriptableRenderContext_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CullingResults*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 925521, RefRangeEnd = 925522, XrefRangeStart = 925481, XrefRangeEnd = 925521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PreviewCameraFrameParams([In] ref ScriptableRenderContext ctx, Camera camera)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewCameraFrameParams.NativeMethodInfoPtr__ctor_Public_Void_byref_ScriptableRenderContext_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PreviewCameraFrameParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PreviewCameraFrameParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewCameraFrameParams>.NativeClassPtr))
  {
  }

  public unsafe Camera camera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_camera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CullingResults cullingResults
  {
    get
    {
      return *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_cullingResults));
    }
    [param: In] set
    {
      *(CullingResults*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_cullingResults)) = value;
    }
  }

  public unsafe Vector2Int renderTargetSize
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_renderTargetSize));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_renderTargetSize)) = value;
    }
  }

  public unsafe Matrix4x4 projectionViewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_projectionViewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_projectionViewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 projectionMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_projectionMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_projectionMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 viewMatrix
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_viewMatrix));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_viewMatrix)) = value;
    }
  }

  public unsafe Matrix4x4 viewMatrixInv
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_viewMatrixInv));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_viewMatrixInv)) = value;
    }
  }

  public unsafe Vector4 depthProjectionParams
  {
    get
    {
      return *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_depthProjectionParams));
    }
    [param: In] set
    {
      *(Vector4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_depthProjectionParams)) = value;
    }
  }

  public unsafe float cameraLightIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_cameraLightIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_cameraLightIntensity)) = value;
    }
  }

  public unsafe Vector3 cameraLightTint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_cameraLightTint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewCameraFrameParams.NativeFieldInfoPtr_cameraLightTint)) = value;
    }
  }
}
