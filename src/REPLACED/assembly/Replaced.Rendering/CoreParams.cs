// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CoreParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CoreParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kCameraTagScene;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCameraTagUI;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCameraTagUIWithPostProcessing;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCameraEmbeddedLightIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraType;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraLightIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_flipProjectionHorizontally;
  private static readonly System.IntPtr NativeFieldInfoPtr_isPrefabScene;
  private static readonly System.IntPtr NativeFieldInfoPtr_isSceneViewNotPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderOnlyBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_useCameraEmbeddedLight;
  private static readonly System.IntPtr NativeFieldInfoPtr_isPostProcessingOn;
  private static readonly System.IntPtr NativeFieldInfoPtr_performYFlip;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesCameraHaveUITag_Public_Static_Boolean_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesCameraHaveUIWithPostProcessingTag_Public_Static_Boolean_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDevdbgRenderingMode_Private_Static_DevdbgRenderingMode_CameraType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraRenderingPath_Public_Static_CameraRenderingPath_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Camera_0;
  [FieldOffset(0)]
  public readonly CameraType cameraType;
  [FieldOffset(4)]
  public readonly RenderTargetInfo renderTargetInfo;
  [FieldOffset(36)]
  public readonly DevdbgRenderingMode renderingMode;
  [FieldOffset(40)]
  public readonly Vector3 cameraLightIntensity;
  [FieldOffset(52)]
  public readonly bool flipProjectionHorizontally;
  [FieldOffset(53)]
  public readonly bool isPrefabScene;
  [FieldOffset(54)]
  public readonly bool isSceneViewNotPrefab;
  [FieldOffset(55)]
  public readonly bool renderOnlyBaseColor;
  [FieldOffset(56)]
  public readonly bool useCameraEmbeddedLight;
  [FieldOffset(57)]
  public readonly bool isPostProcessingOn;
  [FieldOffset(58)]
  public readonly bool performYFlip;

  static CoreParams()
  {
    Il2CppClassPointerStore<CoreParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CoreParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreParams>.NativeClassPtr);
    CoreParams.NativeFieldInfoPtr_kCameraTagScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (kCameraTagScene));
    CoreParams.NativeFieldInfoPtr_kCameraTagUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (kCameraTagUI));
    CoreParams.NativeFieldInfoPtr_kCameraTagUIWithPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (kCameraTagUIWithPostProcessing));
    CoreParams.NativeFieldInfoPtr_kCameraEmbeddedLightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (kCameraEmbeddedLightIntensity));
    CoreParams.NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (cameraType));
    CoreParams.NativeFieldInfoPtr_renderTargetInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (renderTargetInfo));
    CoreParams.NativeFieldInfoPtr_renderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (renderingMode));
    CoreParams.NativeFieldInfoPtr_cameraLightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (cameraLightIntensity));
    CoreParams.NativeFieldInfoPtr_flipProjectionHorizontally = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (flipProjectionHorizontally));
    CoreParams.NativeFieldInfoPtr_isPrefabScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (isPrefabScene));
    CoreParams.NativeFieldInfoPtr_isSceneViewNotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (isSceneViewNotPrefab));
    CoreParams.NativeFieldInfoPtr_renderOnlyBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (renderOnlyBaseColor));
    CoreParams.NativeFieldInfoPtr_useCameraEmbeddedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (useCameraEmbeddedLight));
    CoreParams.NativeFieldInfoPtr_isPostProcessingOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (isPostProcessingOn));
    CoreParams.NativeFieldInfoPtr_performYFlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, nameof (performYFlip));
    CoreParams.NativeMethodInfoPtr_DoesCameraHaveUITag_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, 100663582);
    CoreParams.NativeMethodInfoPtr_DoesCameraHaveUIWithPostProcessingTag_Public_Static_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, 100663583);
    CoreParams.NativeMethodInfoPtr_GetDevdbgRenderingMode_Private_Static_DevdbgRenderingMode_CameraType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, 100663584 /*0x06000120*/);
    CoreParams.NativeMethodInfoPtr_GetCameraRenderingPath_Public_Static_CameraRenderingPath_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, 100663585);
    CoreParams.NativeMethodInfoPtr__ctor_Public_Void_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, 100663586);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926485, XrefRangeEnd = 926489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoesCameraHaveUITag(Camera cam)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreParams.NativeMethodInfoPtr_DoesCameraHaveUITag_Public_Static_Boolean_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 926493, RefRangeEnd = 926496, XrefRangeStart = 926489, XrefRangeEnd = 926493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoesCameraHaveUIWithPostProcessingTag(Camera cam)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreParams.NativeMethodInfoPtr_DoesCameraHaveUIWithPostProcessingTag_Public_Static_Boolean_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DevdbgRenderingMode GetDevdbgRenderingMode(CameraType cameraType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &cameraType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreParams.NativeMethodInfoPtr_GetDevdbgRenderingMode_Private_Static_DevdbgRenderingMode_CameraType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DevdbgRenderingMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 926510, RefRangeEnd = 926514, XrefRangeStart = 926496, XrefRangeEnd = 926510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CameraRenderingPath GetCameraRenderingPath(Camera cam)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreParams.NativeMethodInfoPtr_GetCameraRenderingPath_Public_Static_CameraRenderingPath_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CameraRenderingPath*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926526, RefRangeEnd = 926527, XrefRangeStart = 926514, XrefRangeEnd = 926526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CoreParams(List<Camera> cameras)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameras)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CoreParams.NativeMethodInfoPtr__ctor_Public_Void_List_1_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CoreParams>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe string kCameraTagScene
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CoreParams.NativeFieldInfoPtr_kCameraTagScene, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CoreParams.NativeFieldInfoPtr_kCameraTagScene, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kCameraTagUI
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CoreParams.NativeFieldInfoPtr_kCameraTagUI, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CoreParams.NativeFieldInfoPtr_kCameraTagUI, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string kCameraTagUIWithPostProcessing
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CoreParams.NativeFieldInfoPtr_kCameraTagUIWithPostProcessing, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CoreParams.NativeFieldInfoPtr_kCameraTagUIWithPostProcessing, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe float kCameraEmbeddedLightIntensity
  {
    get
    {
      float embeddedLightIntensity;
      IL2CPP.il2cpp_field_static_get_value(CoreParams.NativeFieldInfoPtr_kCameraEmbeddedLightIntensity, (void*) &embeddedLightIntensity);
      return embeddedLightIntensity;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CoreParams.NativeFieldInfoPtr_kCameraEmbeddedLightIntensity, (void*) &value);
    }
  }
}
