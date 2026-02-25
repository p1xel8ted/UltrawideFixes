// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineConfiner2D
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineConfiner2D(System.IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingShape2D;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Damping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxWindowSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxComputationTimePerFrameInSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_cornerAngleTreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_shapeCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateCache_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidateCache_Public_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateHalfFrustumHeight_Private_Single_byref_CameraState_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineConfiner2D()
  {
    Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineConfiner2D));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr);
    CinemachineConfiner2D.NativeFieldInfoPtr_m_BoundingShape2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (m_BoundingShape2D));
    CinemachineConfiner2D.NativeFieldInfoPtr_m_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (m_Damping));
    CinemachineConfiner2D.NativeFieldInfoPtr_m_MaxWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (m_MaxWindowSize));
    CinemachineConfiner2D.NativeFieldInfoPtr_m_MaxComputationTimePerFrameInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (m_MaxComputationTimePerFrameInSeconds));
    CinemachineConfiner2D.NativeFieldInfoPtr_k_cornerAngleTreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (k_cornerAngleTreshold));
    CinemachineConfiner2D.NativeFieldInfoPtr_m_shapeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (m_shapeCache));
    CinemachineConfiner2D.NativeMethodInfoPtr_InvalidateCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663473 /*0x060000B1*/);
    CinemachineConfiner2D.NativeMethodInfoPtr_ValidateCache_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663474 /*0x060000B2*/);
    CinemachineConfiner2D.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663475 /*0x060000B3*/);
    CinemachineConfiner2D.NativeMethodInfoPtr_CalculateHalfFrustumHeight_Private_Single_byref_CameraState_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663476 /*0x060000B4*/);
    CinemachineConfiner2D.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663477 /*0x060000B5*/);
    CinemachineConfiner2D.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663478 /*0x060000B6*/);
    CinemachineConfiner2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, 100663479 /*0x060000B7*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938706, XrefRangeEnd = 938707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvalidateCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.NativeMethodInfoPtr_InvalidateCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938707, XrefRangeEnd = 938708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidateCache(float cameraAspectRatio)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &cameraAspectRatio
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.NativeMethodInfoPtr_ValidateCache_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938708, XrefRangeEnd = 938751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineConfiner2D.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938751, XrefRangeEnd = 938756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float CalculateHalfFrustumHeight([In] ref CameraState state, [In] ref float cameraPosLocalZ)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cameraPosLocalZ;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.NativeMethodInfoPtr_CalculateHalfFrustumHeight_Private_Single_byref_CameraState_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938756, XrefRangeEnd = 938757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineConfiner2D()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Collider2D m_BoundingShape2D
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_BoundingShape2D));
      return num == System.IntPtr.Zero ? (Collider2D) null : Il2CppObjectPool.Get<Collider2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_BoundingShape2D), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_Damping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_Damping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_Damping)) = value;
    }
  }

  public unsafe float m_MaxWindowSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_MaxWindowSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_MaxWindowSize)) = value;
    }
  }

  public unsafe float m_MaxComputationTimePerFrameInSeconds
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_MaxComputationTimePerFrameInSeconds));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_MaxComputationTimePerFrameInSeconds)) = value;
    }
  }

  public static unsafe float k_cornerAngleTreshold
  {
    get
    {
      float cornerAngleTreshold;
      IL2CPP.il2cpp_field_static_get_value(CinemachineConfiner2D.NativeFieldInfoPtr_k_cornerAngleTreshold, (void*) &cornerAngleTreshold);
      return cornerAngleTreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineConfiner2D.NativeFieldInfoPtr_k_cornerAngleTreshold, (void*) &value);
    }
  }

  public CinemachineConfiner2D.ShapeCache m_shapeCache
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_shapeCache);
      return new CinemachineConfiner2D.ShapeCache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.NativeFieldInfoPtr_m_shapeCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public class VcamExtraState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousDisplacement;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DampedDisplacement;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_BakedSolution;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_vcam;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VcamExtraState()
    {
      Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (VcamExtraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr);
      CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_PreviousDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr, nameof (m_PreviousDisplacement));
      CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_DampedDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr, nameof (m_DampedDisplacement));
      CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_BakedSolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr, nameof (m_BakedSolution));
      CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_vcam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr, nameof (m_vcam));
      CinemachineConfiner2D.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr, 100663480 /*0x060000B8*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VcamExtraState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineConfiner2D.VcamExtraState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 m_PreviousDisplacement
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_PreviousDisplacement));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_PreviousDisplacement)) = value;
      }
    }

    public unsafe Vector3 m_DampedDisplacement
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_DampedDisplacement));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_DampedDisplacement)) = value;
      }
    }

    public unsafe ConfinerOven.BakedSolution m_BakedSolution
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_BakedSolution));
        return num == System.IntPtr.Zero ? (ConfinerOven.BakedSolution) null : Il2CppObjectPool.Get<ConfinerOven.BakedSolution>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_BakedSolution), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CinemachineVirtualCameraBase m_vcam
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_vcam));
        return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.VcamExtraState.NativeFieldInfoPtr_m_vcam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public sealed class ShapeCache : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_confinerOven;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPath;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DeltaWorldToBaked;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DeltaBakedToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_aspectRatio;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_maxWindowSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_maxComputationTimePerFrameInSeconds;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_bakedToWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_boundingShape2D;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invalidate_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateCache_Public_Boolean_Collider2D_Single_Single_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Private_Boolean_byref_Collider2D_byref_Single_byref_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDeltaTransformationMatrix_Private_Void_0;

    static ShapeCache()
    {
      Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineConfiner2D>.NativeClassPtr, nameof (ShapeCache));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr);
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_confinerOven = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_confinerOven));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_OriginalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_OriginalPath));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_DeltaWorldToBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_DeltaWorldToBaked));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_DeltaBakedToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_DeltaBakedToWorld));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_aspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_aspectRatio));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_maxWindowSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_maxWindowSize));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_maxComputationTimePerFrameInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_maxComputationTimePerFrameInSeconds));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_bakedToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_bakedToWorld));
      CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_boundingShape2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, nameof (m_boundingShape2D));
      CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_Invalidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, 100663481 /*0x060000B9*/);
      CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_ValidateCache_Public_Boolean_Collider2D_Single_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, 100663482 /*0x060000BA*/);
      CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_IsValid_Private_Boolean_byref_Collider2D_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, 100663483 /*0x060000BB*/);
      CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_CalculateDeltaTransformationMatrix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr, 100663484 /*0x060000BC*/);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 938648, RefRangeEnd = 938650, XrefRangeStart = 938646, XrefRangeEnd = 938648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Invalidate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_Invalidate_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 938684, RefRangeEnd = 938686, XrefRangeStart = 938650, XrefRangeEnd = 938684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidateCache(
      Collider2D boundingShape2D,
      float maxWindowSize,
      float aspectRatio,
      out bool confinerStateChanged)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) boundingShape2D);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxWindowSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aspectRatio;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref confinerStateChanged;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_ValidateCache_Public_Boolean_Collider2D_Single_Single_byref_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 938697, RefRangeEnd = 938698, XrefRangeStart = 938686, XrefRangeEnd = 938697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValid(
      [In] ref Collider2D boundingShape2D,
      [In] ref float aspectRatio,
      [In] ref float maxOrthoSize)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) boundingShape2D);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aspectRatio;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref maxOrthoSize;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_IsValid_Private_Boolean_byref_Collider2D_byref_Single_byref_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      ref Collider2D local = ref boundingShape2D;
      System.IntPtr pointer = ptr;
      Collider2D collider2D = pointer == System.IntPtr.Zero ? (Collider2D) null : new Collider2D(pointer);
      local = collider2D;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 938705, RefRangeEnd = 938706, XrefRangeStart = 938698, XrefRangeEnd = 938705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CalculateDeltaTransformationMatrix()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner2D.ShapeCache.NativeMethodInfoPtr_CalculateDeltaTransformationMatrix_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public ShapeCache(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ShapeCache()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineConfiner2D.ShapeCache>.NativeClassPtr))
    {
    }

    public unsafe ConfinerOven m_confinerOven
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_confinerOven));
        return num == System.IntPtr.Zero ? (ConfinerOven) null : Il2CppObjectPool.Get<ConfinerOven>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_confinerOven), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<List<Vector2>> m_OriginalPath
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_OriginalPath));
        return num == System.IntPtr.Zero ? (List<List<Vector2>>) null : Il2CppObjectPool.Get<List<List<Vector2>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_OriginalPath), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Matrix4x4 m_DeltaWorldToBaked
    {
      get
      {
        return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_DeltaWorldToBaked));
      }
      [param: In] set
      {
        *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_DeltaWorldToBaked)) = value;
      }
    }

    public unsafe Matrix4x4 m_DeltaBakedToWorld
    {
      get
      {
        return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_DeltaBakedToWorld));
      }
      [param: In] set
      {
        *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_DeltaBakedToWorld)) = value;
      }
    }

    public unsafe float m_aspectRatio
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_aspectRatio));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_aspectRatio)) = value;
      }
    }

    public unsafe float m_maxWindowSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_maxWindowSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_maxWindowSize)) = value;
      }
    }

    public unsafe float m_maxComputationTimePerFrameInSeconds
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_maxComputationTimePerFrameInSeconds));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_maxComputationTimePerFrameInSeconds)) = value;
      }
    }

    public unsafe Matrix4x4 m_bakedToWorld
    {
      get
      {
        return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_bakedToWorld));
      }
      [param: In] set
      {
        *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_bakedToWorld)) = value;
      }
    }

    public unsafe Collider2D m_boundingShape2D
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_boundingShape2D));
        return num == System.IntPtr.Zero ? (Collider2D) null : Il2CppObjectPool.Get<Collider2D>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner2D.ShapeCache.NativeFieldInfoPtr_m_boundingShape2D), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
