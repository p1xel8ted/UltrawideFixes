// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineConfiner
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

public class CinemachineConfiner(System.IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ConfineMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingVolume;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingShape2D;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingShape2DCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ConfineScreenEdges;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Damping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_pathCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_pathTotalPointCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_CameraWasDisplaced_Public_Boolean_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraDisplacementDistance_Public_Single_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectToVcam_Protected_Virtual_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidatePathCache_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ValidatePathCache_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConfinePoint_Private_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConfineScreenEdges_Private_Vector3_byref_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineConfiner()
  {
    Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineConfiner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr);
    CinemachineConfiner.NativeFieldInfoPtr_m_ConfineMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_ConfineMode));
    CinemachineConfiner.NativeFieldInfoPtr_m_BoundingVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_BoundingVolume));
    CinemachineConfiner.NativeFieldInfoPtr_m_BoundingShape2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_BoundingShape2D));
    CinemachineConfiner.NativeFieldInfoPtr_m_BoundingShape2DCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_BoundingShape2DCache));
    CinemachineConfiner.NativeFieldInfoPtr_m_ConfineScreenEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_ConfineScreenEdges));
    CinemachineConfiner.NativeFieldInfoPtr_m_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_Damping));
    CinemachineConfiner.NativeFieldInfoPtr_m_pathCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_pathCache));
    CinemachineConfiner.NativeFieldInfoPtr_m_pathTotalPointCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (m_pathTotalPointCount));
    CinemachineConfiner.NativeMethodInfoPtr_CameraWasDisplaced_Public_Boolean_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663460 /*0x060000A4*/);
    CinemachineConfiner.NativeMethodInfoPtr_GetCameraDisplacementDistance_Public_Single_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663461 /*0x060000A5*/);
    CinemachineConfiner.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663462 /*0x060000A6*/);
    CinemachineConfiner.NativeMethodInfoPtr_ConnectToVcam_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663463 /*0x060000A7*/);
    CinemachineConfiner.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663464 /*0x060000A8*/);
    CinemachineConfiner.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663465 /*0x060000A9*/);
    CinemachineConfiner.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663466 /*0x060000AA*/);
    CinemachineConfiner.NativeMethodInfoPtr_InvalidatePathCache_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663467 /*0x060000AB*/);
    CinemachineConfiner.NativeMethodInfoPtr_ValidatePathCache_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663468 /*0x060000AC*/);
    CinemachineConfiner.NativeMethodInfoPtr_ConfinePoint_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663469 /*0x060000AD*/);
    CinemachineConfiner.NativeMethodInfoPtr_ConfineScreenEdges_Private_Vector3_byref_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663470 /*0x060000AE*/);
    CinemachineConfiner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, 100663471 /*0x060000AF*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938508, XrefRangeEnd = 938511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_CameraWasDisplaced_Public_Boolean_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938511, XrefRangeEnd = 938514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_GetCameraDisplacementDistance_Public_Single_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938514, XrefRangeEnd = 938515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ConnectToVcam(bool connect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &connect
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineConfiner.NativeMethodInfoPtr_ConnectToVcam_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938515, XrefRangeEnd = 938522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineConfiner.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938522, XrefRangeEnd = 938553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineConfiner.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void InvalidatePathCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_InvalidatePathCache_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938584, RefRangeEnd = 938585, XrefRangeStart = 938553, XrefRangeEnd = 938584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ValidatePathCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_ValidatePathCache_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 938610, RefRangeEnd = 938615, XrefRangeStart = 938585, XrefRangeEnd = 938610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ConfinePoint(Vector3 camPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &camPos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_ConfinePoint_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 938644, RefRangeEnd = 938645, XrefRangeStart = 938615, XrefRangeEnd = 938644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ConfineScreenEdges(ref CameraState state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr_ConfineScreenEdges_Private_Vector3_byref_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938645, XrefRangeEnd = 938646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineConfiner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineConfiner.Mode m_ConfineMode
  {
    get
    {
      return *(CinemachineConfiner.Mode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_ConfineMode));
    }
    [param: In] set
    {
      *(CinemachineConfiner.Mode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_ConfineMode)) = value;
    }
  }

  public unsafe Collider m_BoundingVolume
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_BoundingVolume));
      return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_BoundingVolume), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider2D m_BoundingShape2D
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_BoundingShape2D));
      return num == System.IntPtr.Zero ? (Collider2D) null : Il2CppObjectPool.Get<Collider2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_BoundingShape2D), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider2D m_BoundingShape2DCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_BoundingShape2DCache));
      return num == System.IntPtr.Zero ? (Collider2D) null : Il2CppObjectPool.Get<Collider2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_BoundingShape2DCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_ConfineScreenEdges
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_ConfineScreenEdges));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_ConfineScreenEdges)) = value;
    }
  }

  public unsafe float m_Damping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_Damping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_Damping)) = value;
    }
  }

  public unsafe List<List<Vector2>> m_pathCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_pathCache));
      return num == System.IntPtr.Zero ? (List<List<Vector2>>) null : Il2CppObjectPool.Get<List<List<Vector2>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_pathCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_pathTotalPointCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_pathTotalPointCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.NativeFieldInfoPtr_m_pathTotalPointCount)) = value;
    }
  }

  public enum Mode
  {
    Confine2D,
    Confine3D,
  }

  public class VcamExtraState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_previousDisplacement;
    private static readonly System.IntPtr NativeFieldInfoPtr_confinerDisplacement;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VcamExtraState()
    {
      Il2CppClassPointerStore<CinemachineConfiner.VcamExtraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineConfiner>.NativeClassPtr, nameof (VcamExtraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineConfiner.VcamExtraState>.NativeClassPtr);
      CinemachineConfiner.VcamExtraState.NativeFieldInfoPtr_m_previousDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner.VcamExtraState>.NativeClassPtr, nameof (m_previousDisplacement));
      CinemachineConfiner.VcamExtraState.NativeFieldInfoPtr_confinerDisplacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineConfiner.VcamExtraState>.NativeClassPtr, nameof (confinerDisplacement));
      CinemachineConfiner.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineConfiner.VcamExtraState>.NativeClassPtr, 100663472 /*0x060000B0*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VcamExtraState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineConfiner.VcamExtraState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineConfiner.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 m_previousDisplacement
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.VcamExtraState.NativeFieldInfoPtr_m_previousDisplacement));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.VcamExtraState.NativeFieldInfoPtr_m_previousDisplacement)) = value;
      }
    }

    public unsafe float confinerDisplacement
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.VcamExtraState.NativeFieldInfoPtr_confinerDisplacement));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineConfiner.VcamExtraState.NativeFieldInfoPtr_confinerDisplacement)) = value;
      }
    }
  }
}
