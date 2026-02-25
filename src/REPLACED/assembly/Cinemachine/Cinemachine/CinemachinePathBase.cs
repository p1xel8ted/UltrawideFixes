// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachinePathBase
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachinePathBase(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Resolution;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Appearance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DistanceToPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PosToDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CachedSampleSteps;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PathLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedPosStepSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_cachedDistanceStepSize;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinPos_Public_Abstract_Virtual_New_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPos_Public_Abstract_Virtual_New_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Looped_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StandardizePos_Public_Virtual_New_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluatePosition_Public_Virtual_New_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTangent_Public_Virtual_New_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateOrientation_Public_Virtual_New_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalPosition_Public_Abstract_Virtual_New_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalTangent_Public_Abstract_Virtual_New_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Abstract_Virtual_New_Quaternion_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindClosestPoint_Public_Virtual_New_Single_Vector3_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MinUnit_Public_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MaxUnit_Public_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StandardizeUnit_Public_Virtual_New_Single_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluatePositionAtUnit_Public_Vector3_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateTangentAtUnit_Public_Vector3_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateOrientationAtUnit_Public_Quaternion_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Abstract_Virtual_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvalidateDistanceCache_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DistanceCacheIsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PathLength_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StandardizePathDistance_Public_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToNativePathUnits_Public_Single_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromPathNativeUnits_Public_Single_Single_PositionUnits_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResamplePath_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static CinemachinePathBase()
  {
    Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachinePathBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr);
    CinemachinePathBase.NativeFieldInfoPtr_m_Resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_Resolution));
    CinemachinePathBase.NativeFieldInfoPtr_m_Appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_Appearance));
    CinemachinePathBase.NativeFieldInfoPtr_m_DistanceToPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_DistanceToPos));
    CinemachinePathBase.NativeFieldInfoPtr_m_PosToDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_PosToDistance));
    CinemachinePathBase.NativeFieldInfoPtr_m_CachedSampleSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_CachedSampleSteps));
    CinemachinePathBase.NativeFieldInfoPtr_m_PathLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_PathLength));
    CinemachinePathBase.NativeFieldInfoPtr_m_cachedPosStepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_cachedPosStepSize));
    CinemachinePathBase.NativeFieldInfoPtr_m_cachedDistanceStepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (m_cachedDistanceStepSize));
    CinemachinePathBase.NativeMethodInfoPtr_get_MinPos_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664012);
    CinemachinePathBase.NativeMethodInfoPtr_get_MaxPos_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664013);
    CinemachinePathBase.NativeMethodInfoPtr_get_Looped_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664014);
    CinemachinePathBase.NativeMethodInfoPtr_StandardizePos_Public_Virtual_New_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664015);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluatePosition_Public_Virtual_New_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664016 /*0x060002D0*/);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateTangent_Public_Virtual_New_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664017);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateOrientation_Public_Virtual_New_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664018);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateLocalPosition_Public_Abstract_Virtual_New_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664019);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateLocalTangent_Public_Abstract_Virtual_New_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664020);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Abstract_Virtual_New_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664021);
    CinemachinePathBase.NativeMethodInfoPtr_FindClosestPoint_Public_Virtual_New_Single_Vector3_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664022);
    CinemachinePathBase.NativeMethodInfoPtr_MinUnit_Public_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664023);
    CinemachinePathBase.NativeMethodInfoPtr_MaxUnit_Public_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664024);
    CinemachinePathBase.NativeMethodInfoPtr_StandardizeUnit_Public_Virtual_New_Single_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664025);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluatePositionAtUnit_Public_Vector3_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664026);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateTangentAtUnit_Public_Vector3_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664027);
    CinemachinePathBase.NativeMethodInfoPtr_EvaluateOrientationAtUnit_Public_Quaternion_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664028);
    CinemachinePathBase.NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664029);
    CinemachinePathBase.NativeMethodInfoPtr_InvalidateDistanceCache_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664030);
    CinemachinePathBase.NativeMethodInfoPtr_DistanceCacheIsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664031);
    CinemachinePathBase.NativeMethodInfoPtr_get_PathLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664032 /*0x060002E0*/);
    CinemachinePathBase.NativeMethodInfoPtr_StandardizePathDistance_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664033);
    CinemachinePathBase.NativeMethodInfoPtr_ToNativePathUnits_Public_Single_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664034);
    CinemachinePathBase.NativeMethodInfoPtr_FromPathNativeUnits_Public_Single_Single_PositionUnits_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664035);
    CinemachinePathBase.NativeMethodInfoPtr_ResamplePath_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664036);
    CinemachinePathBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, 100664037);
  }

  public virtual unsafe float MinPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_get_MinPos_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe float MaxPos
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_get_MaxPos_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe bool Looped
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_get_Looped_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943666, XrefRangeEnd = 943667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float StandardizePos(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_StandardizePos_Public_Virtual_New_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943667, XrefRangeEnd = 943669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 EvaluatePosition(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_EvaluatePosition_Public_Virtual_New_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943669, XrefRangeEnd = 943671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 EvaluateTangent(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_EvaluateTangent_Public_Virtual_New_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943671, XrefRangeEnd = 943673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Quaternion EvaluateOrientation(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_EvaluateOrientation_Public_Virtual_New_Quaternion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe Vector3 EvaluateLocalPosition(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_EvaluateLocalPosition_Public_Abstract_Virtual_New_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe Vector3 EvaluateLocalTangent(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_EvaluateLocalTangent_Public_Abstract_Virtual_New_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe Quaternion EvaluateLocalOrientation(float pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_EvaluateLocalOrientation_Public_Abstract_Virtual_New_Quaternion_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943673, XrefRangeEnd = 943683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float FindClosestPoint(
    Vector3 p,
    int startSegment,
    int searchRadius,
    int stepsPerSegment)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &p;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startSegment;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &searchRadius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stepsPerSegment;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_FindClosestPoint_Public_Virtual_New_Single_Vector3_Int32_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe float MinUnit(CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &units
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_MinUnit_Public_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943684, RefRangeEnd = 943685, XrefRangeStart = 943683, XrefRangeEnd = 943684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float MaxUnit(CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &units
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_MaxUnit_Public_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943685, XrefRangeEnd = 943687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float StandardizeUnit(float pos, CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &units;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_StandardizeUnit_Public_Virtual_New_Single_Single_PositionUnits_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943688, RefRangeEnd = 943690, XrefRangeStart = 943687, XrefRangeEnd = 943688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 EvaluatePositionAtUnit(float pos, CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &units;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_EvaluatePositionAtUnit_Public_Vector3_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943690, XrefRangeEnd = 943691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 EvaluateTangentAtUnit(float pos, CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &units;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_EvaluateTangentAtUnit_Public_Vector3_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943692, RefRangeEnd = 943694, XrefRangeStart = 943691, XrefRangeEnd = 943692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Quaternion EvaluateOrientationAtUnit(
    float pos,
    CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &units;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_EvaluateOrientationAtUnit_Public_Quaternion_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe int DistanceCacheSampleStepsPerSegment
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_get_DistanceCacheSampleStepsPerSegment_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943694, RefRangeEnd = 943695, XrefRangeStart = 943694, XrefRangeEnd = 943694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void InvalidateDistanceCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachinePathBase.NativeMethodInfoPtr_InvalidateDistanceCache_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe bool DistanceCacheIsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_DistanceCacheIsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float PathLength
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 943696, RefRangeEnd = 943702, XrefRangeStart = 943695, XrefRangeEnd = 943696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_get_PathLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943704, RefRangeEnd = 943706, XrefRangeStart = 943702, XrefRangeEnd = 943704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float StandardizePathDistance(float distance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &distance
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_StandardizePathDistance_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 943711, RefRangeEnd = 943715, XrefRangeStart = 943706, XrefRangeEnd = 943711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float ToNativePathUnits(float pos, CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &units;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_ToNativePathUnits_Public_Single_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943719, RefRangeEnd = 943720, XrefRangeStart = 943715, XrefRangeEnd = 943719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float FromPathNativeUnits(float pos, CinemachinePathBase.PositionUnits units)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &units;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_FromPathNativeUnits_Public_Single_Single_PositionUnits_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943731, RefRangeEnd = 943732, XrefRangeStart = 943720, XrefRangeEnd = 943731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResamplePath(int stepsPerSegment)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &stepsPerSegment
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr_ResamplePath_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943737, RefRangeEnd = 943739, XrefRangeStart = 943732, XrefRangeEnd = 943737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachinePathBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int m_Resolution
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_Resolution));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_Resolution)) = value;
    }
  }

  public unsafe CinemachinePathBase.Appearance m_Appearance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_Appearance));
      return num == System.IntPtr.Zero ? (CinemachinePathBase.Appearance) null : Il2CppObjectPool.Get<CinemachinePathBase.Appearance>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_Appearance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_DistanceToPos
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_DistanceToPos));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_DistanceToPos), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_PosToDistance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_PosToDistance));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_PosToDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_CachedSampleSteps
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_CachedSampleSteps));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_CachedSampleSteps)) = value;
    }
  }

  public unsafe float m_PathLength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_PathLength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_PathLength)) = value;
    }
  }

  public unsafe float m_cachedPosStepSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_cachedPosStepSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_cachedPosStepSize)) = value;
    }
  }

  public unsafe float m_cachedDistanceStepSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_cachedDistanceStepSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.NativeFieldInfoPtr_m_cachedDistanceStepSize)) = value;
    }
  }

  [Serializable]
  public class Appearance(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pathColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_inactivePathColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_width;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Appearance()
    {
      Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachinePathBase>.NativeClassPtr, nameof (Appearance));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr);
      CinemachinePathBase.Appearance.NativeFieldInfoPtr_pathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr, nameof (pathColor));
      CinemachinePathBase.Appearance.NativeFieldInfoPtr_inactivePathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr, nameof (inactivePathColor));
      CinemachinePathBase.Appearance.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr, nameof (width));
      CinemachinePathBase.Appearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr, 100664038);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 943664, RefRangeEnd = 943666, XrefRangeStart = 943663, XrefRangeEnd = 943664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Appearance()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachinePathBase.Appearance>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachinePathBase.Appearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Color pathColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.Appearance.NativeFieldInfoPtr_pathColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.Appearance.NativeFieldInfoPtr_pathColor)) = value;
      }
    }

    public unsafe Color inactivePathColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.Appearance.NativeFieldInfoPtr_inactivePathColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.Appearance.NativeFieldInfoPtr_inactivePathColor)) = value;
      }
    }

    public unsafe float width
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.Appearance.NativeFieldInfoPtr_width));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachinePathBase.Appearance.NativeFieldInfoPtr_width)) = value;
      }
    }
  }

  public enum PositionUnits
  {
    PathUnits,
    Distance,
    Normalized,
  }
}
