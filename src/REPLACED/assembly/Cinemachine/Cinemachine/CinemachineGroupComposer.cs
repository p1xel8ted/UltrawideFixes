// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineGroupComposer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineGroupComposer(IntPtr pointer) : CinemachineComposer(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_GroupFramingSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_FramingMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_FrameDamping;
  private static readonly IntPtr NativeFieldInfoPtr_m_AdjustmentMode;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaxDollyIn;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaxDollyOut;
  private static readonly IntPtr NativeFieldInfoPtr_m_MinimumDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaximumDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_MinimumFOV;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaximumFOV;
  private static readonly IntPtr NativeFieldInfoPtr_m_MinimumOrthoSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_MaximumOrthoSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_prevFramingDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_prevFOV;
  private static readonly IntPtr NativeFieldInfoPtr__LastBounds_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastBounds_Public_get_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LastBounds_Private_set_Void_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastBoundsMatrix_Public_get_Matrix4x4_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LastBoundsMatrix_Private_set_Void_Matrix4x4_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTargetHeight_Private_Single_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScreenSpaceGroupBoundingBox_Private_Static_Bounds_ICinemachineTargetGroup_Matrix4x4_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineGroupComposer()
  {
    Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineGroupComposer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr);
    CinemachineGroupComposer.NativeFieldInfoPtr_m_GroupFramingSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_GroupFramingSize));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_FramingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_FramingMode));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_FrameDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_FrameDamping));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_AdjustmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_AdjustmentMode));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MaxDollyIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MaxDollyIn));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MaxDollyOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MaxDollyOut));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MinimumDistance));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MaximumDistance));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MinimumFOV));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MaximumFOV));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumOrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MinimumOrthoSize));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumOrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_MaximumOrthoSize));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_prevFramingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_prevFramingDistance));
    CinemachineGroupComposer.NativeFieldInfoPtr_m_prevFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, nameof (m_prevFOV));
    CinemachineGroupComposer.NativeFieldInfoPtr__LastBounds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, "<LastBounds>k__BackingField");
    CinemachineGroupComposer.NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, "<LastBoundsMatrix>k__BackingField");
    CinemachineGroupComposer.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663778);
    CinemachineGroupComposer.NativeMethodInfoPtr_get_LastBounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663779);
    CinemachineGroupComposer.NativeMethodInfoPtr_set_LastBounds_Private_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663780);
    CinemachineGroupComposer.NativeMethodInfoPtr_get_LastBoundsMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663781);
    CinemachineGroupComposer.NativeMethodInfoPtr_set_LastBoundsMatrix_Private_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663782);
    CinemachineGroupComposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663783);
    CinemachineGroupComposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663784);
    CinemachineGroupComposer.NativeMethodInfoPtr_GetTargetHeight_Private_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663785);
    CinemachineGroupComposer.NativeMethodInfoPtr_GetScreenSpaceGroupBoundingBox_Private_Static_Bounds_ICinemachineTargetGroup_Matrix4x4_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663786);
    CinemachineGroupComposer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr, 100663787);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941469, XrefRangeEnd = 941470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Bounds LastBounds
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_get_LastBounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_set_LastBounds_Private_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Matrix4x4 LastBoundsMatrix
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_get_LastBoundsMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_set_LastBoundsMatrix_Private_set_Void_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineGroupComposer.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941470, XrefRangeEnd = 941536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineGroupComposer.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941536, XrefRangeEnd = 941543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetTargetHeight(Vector2 boundsSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &boundsSize
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_GetTargetHeight_Private_Single_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 941557, RefRangeEnd = 941558, XrefRangeStart = 941543, XrefRangeEnd = 941557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Bounds GetScreenSpaceGroupBoundingBox(
    ICinemachineTargetGroup group,
    Matrix4x4 observer,
    out Vector3 newFwd)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) group);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &observer;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref newFwd;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr_GetScreenSpaceGroupBoundingBox_Private_Static_Bounds_ICinemachineTargetGroup_Matrix4x4_byref_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941558, XrefRangeEnd = 941573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineGroupComposer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineGroupComposer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineGroupComposer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float m_GroupFramingSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_GroupFramingSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_GroupFramingSize)) = value;
    }
  }

  public unsafe CinemachineGroupComposer.FramingMode m_FramingMode
  {
    get
    {
      return *(CinemachineGroupComposer.FramingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_FramingMode));
    }
    [param: In] set
    {
      *(CinemachineGroupComposer.FramingMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_FramingMode)) = value;
    }
  }

  public unsafe float m_FrameDamping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_FrameDamping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_FrameDamping)) = value;
    }
  }

  public unsafe CinemachineGroupComposer.AdjustmentMode m_AdjustmentMode
  {
    get
    {
      return *(CinemachineGroupComposer.AdjustmentMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_AdjustmentMode));
    }
    [param: In] set
    {
      *(CinemachineGroupComposer.AdjustmentMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_AdjustmentMode)) = value;
    }
  }

  public unsafe float m_MaxDollyIn
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaxDollyIn));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaxDollyIn)) = value;
    }
  }

  public unsafe float m_MaxDollyOut
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaxDollyOut));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaxDollyOut)) = value;
    }
  }

  public unsafe float m_MinimumDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumDistance)) = value;
    }
  }

  public unsafe float m_MaximumDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumDistance)) = value;
    }
  }

  public unsafe float m_MinimumFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumFOV)) = value;
    }
  }

  public unsafe float m_MaximumFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumFOV)) = value;
    }
  }

  public unsafe float m_MinimumOrthoSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumOrthoSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MinimumOrthoSize)) = value;
    }
  }

  public unsafe float m_MaximumOrthoSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumOrthoSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_MaximumOrthoSize)) = value;
    }
  }

  public unsafe float m_prevFramingDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_prevFramingDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_prevFramingDistance)) = value;
    }
  }

  public unsafe float m_prevFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_prevFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr_m_prevFOV)) = value;
    }
  }

  public unsafe Bounds _LastBounds_k__BackingField
  {
    get
    {
      return *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr__LastBounds_k__BackingField));
    }
    [param: In] set
    {
      *(Bounds*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr__LastBounds_k__BackingField)) = value;
    }
  }

  public unsafe Matrix4x4 _LastBoundsMatrix_k__BackingField
  {
    get
    {
      return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField));
    }
    [param: In] set
    {
      *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineGroupComposer.NativeFieldInfoPtr__LastBoundsMatrix_k__BackingField)) = value;
    }
  }

  public enum FramingMode
  {
    Horizontal,
    Vertical,
    HorizontalAndVertical,
  }

  public enum AdjustmentMode
  {
    ZoomOnly,
    DollyOnly,
    DollyThenZoom,
  }
}
