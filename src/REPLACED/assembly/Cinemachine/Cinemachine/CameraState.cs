// Decompiled with JetBrains decompiler
// Type: Cinemachine.CameraState
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

public sealed class CameraState : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Lens;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReferenceUp;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReferenceLookAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_kNoPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_RawPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_RawOrientation;
  private static readonly System.IntPtr NativeFieldInfoPtr_PositionDampingBypass;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShotQuality;
  private static readonly System.IntPtr NativeFieldInfoPtr_PositionCorrection;
  private static readonly System.IntPtr NativeFieldInfoPtr_OrientationCorrection;
  private static readonly System.IntPtr NativeFieldInfoPtr_BlendHint;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCustom0;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCustom1;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCustom2;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCustom3;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomOverflow;
  private static readonly System.IntPtr NativeFieldInfoPtr__NumCustomBlendables_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLookAt_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CorrectedPosition_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CorrectedOrientation_Public_get_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FinalPosition_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FinalOrientation_Public_get_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NumCustomBlendables_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NumCustomBlendables_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomBlendable_Public_CustomBlendable_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindCustomBlendable_Private_Int32_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCustomBlendable_Public_Void_CustomBlendable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_CameraState_CameraState_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InterpolateFOV_Private_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyPosBlendHint_Private_Static_Vector3_Vector3_BlendHintValue_Vector3_BlendHintValue_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRotBlendHint_Private_Static_Quaternion_Quaternion_BlendHintValue_Quaternion_BlendHintValue_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InterpolatePosition_Private_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0;

  static CameraState()
  {
    Il2CppClassPointerStore<CameraState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CameraState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraState>.NativeClassPtr);
    CameraState.NativeFieldInfoPtr_Lens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (Lens));
    CameraState.NativeFieldInfoPtr_ReferenceUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (ReferenceUp));
    CameraState.NativeFieldInfoPtr_ReferenceLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (ReferenceLookAt));
    CameraState.NativeFieldInfoPtr_kNoPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (kNoPoint));
    CameraState.NativeFieldInfoPtr_RawPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (RawPosition));
    CameraState.NativeFieldInfoPtr_RawOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (RawOrientation));
    CameraState.NativeFieldInfoPtr_PositionDampingBypass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (PositionDampingBypass));
    CameraState.NativeFieldInfoPtr_ShotQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (ShotQuality));
    CameraState.NativeFieldInfoPtr_PositionCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (PositionCorrection));
    CameraState.NativeFieldInfoPtr_OrientationCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (OrientationCorrection));
    CameraState.NativeFieldInfoPtr_BlendHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (BlendHint));
    CameraState.NativeFieldInfoPtr_mCustom0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (mCustom0));
    CameraState.NativeFieldInfoPtr_mCustom1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (mCustom1));
    CameraState.NativeFieldInfoPtr_mCustom2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (mCustom2));
    CameraState.NativeFieldInfoPtr_mCustom3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (mCustom3));
    CameraState.NativeFieldInfoPtr_m_CustomOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (m_CustomOverflow));
    CameraState.NativeFieldInfoPtr__NumCustomBlendables_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "<NumCustomBlendables>k__BackingField");
    CameraState.NativeMethodInfoPtr_get_HasLookAt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663878);
    CameraState.NativeMethodInfoPtr_get_CorrectedPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663879);
    CameraState.NativeMethodInfoPtr_get_CorrectedOrientation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663880);
    CameraState.NativeMethodInfoPtr_get_FinalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663881);
    CameraState.NativeMethodInfoPtr_get_FinalOrientation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663882);
    CameraState.NativeMethodInfoPtr_get_Default_Public_Static_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663883);
    CameraState.NativeMethodInfoPtr_get_NumCustomBlendables_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663884);
    CameraState.NativeMethodInfoPtr_set_NumCustomBlendables_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663885);
    CameraState.NativeMethodInfoPtr_GetCustomBlendable_Public_CustomBlendable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663886);
    CameraState.NativeMethodInfoPtr_FindCustomBlendable_Private_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663887);
    CameraState.NativeMethodInfoPtr_AddCustomBlendable_Public_Void_CustomBlendable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663888 /*0x06000250*/);
    CameraState.NativeMethodInfoPtr_Lerp_Public_Static_CameraState_CameraState_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663889);
    CameraState.NativeMethodInfoPtr_InterpolateFOV_Private_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663890);
    CameraState.NativeMethodInfoPtr_ApplyPosBlendHint_Private_Static_Vector3_Vector3_BlendHintValue_Vector3_BlendHintValue_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663891);
    CameraState.NativeMethodInfoPtr_ApplyRotBlendHint_Private_Static_Quaternion_Quaternion_BlendHintValue_Quaternion_BlendHintValue_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663892);
    CameraState.NativeMethodInfoPtr_InterpolatePosition_Private_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100663893);
  }

  public unsafe bool HasLookAt
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 942315, RefRangeEnd = 942327, XrefRangeStart = 942315, XrefRangeEnd = 942315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_HasLookAt_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 CorrectedPosition
  {
    [CallerCount(22), CachedScanResults(RefRangeStart = 942327, RefRangeEnd = 942349, XrefRangeStart = 942327, XrefRangeEnd = 942327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_CorrectedPosition_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Quaternion CorrectedOrientation
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 942349, RefRangeEnd = 942357, XrefRangeStart = 942349, XrefRangeEnd = 942349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_CorrectedOrientation_Public_get_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 FinalPosition
  {
    [CallerCount(22), CachedScanResults(RefRangeStart = 942327, RefRangeEnd = 942349, XrefRangeStart = 942327, XrefRangeEnd = 942349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_FinalPosition_Public_get_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Quaternion FinalOrientation
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 942367, RefRangeEnd = 942371, XrefRangeStart = 942357, XrefRangeEnd = 942367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_FinalOrientation_Public_get_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe CameraState Default
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 942392, RefRangeEnd = 942403, XrefRangeStart = 942371, XrefRangeEnd = 942392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_Default_Public_Static_get_CameraState_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
  }

  public unsafe int NumCustomBlendables
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_get_NumCustomBlendables_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_set_NumCustomBlendables_Private_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 942408, RefRangeEnd = 942412, XrefRangeStart = 942403, XrefRangeEnd = 942408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraState.CustomBlendable GetCustomBlendable(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_GetCustomBlendable_Public_CustomBlendable_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CameraState.CustomBlendable(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942433, RefRangeEnd = 942434, XrefRangeStart = 942412, XrefRangeEnd = 942433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int FindCustomBlendable(UnityEngine.Object custom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) custom)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_FindCustomBlendable_Private_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 942454, RefRangeEnd = 942457, XrefRangeStart = 942434, XrefRangeEnd = 942454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCustomBlendable(CameraState.CustomBlendable b)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_AddCustomBlendable_Public_Void_CustomBlendable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 942564, RefRangeEnd = 942566, XrefRangeStart = 942457, XrefRangeEnd = 942564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CameraState Lerp(CameraState stateA, CameraState stateB, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) stateA));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) stateB));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_Lerp_Public_Static_CameraState_CameraState_CameraState_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CameraState(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942566, XrefRangeEnd = 942572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &fovA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fovB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &dB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_InterpolateFOV_Private_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3 ApplyPosBlendHint(
    Vector3 posA,
    CameraState.BlendHintValue hintA,
    Vector3 posB,
    CameraState.BlendHintValue hintB,
    Vector3 original,
    Vector3 blended)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &posA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hintA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &posB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hintB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &original;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &blended;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_ApplyPosBlendHint_Private_Static_Vector3_Vector3_BlendHintValue_Vector3_BlendHintValue_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Quaternion ApplyRotBlendHint(
    Quaternion rotA,
    CameraState.BlendHintValue hintA,
    Quaternion rotB,
    CameraState.BlendHintValue hintB,
    Quaternion original,
    Quaternion blended)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &rotA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hintA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &hintB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &original;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &blended;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_ApplyRotBlendHint_Private_Static_Quaternion_Quaternion_BlendHintValue_Quaternion_BlendHintValue_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942578, RefRangeEnd = 942579, XrefRangeStart = 942572, XrefRangeEnd = 942578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 InterpolatePosition(
    Vector3 posA,
    Vector3 pivotA,
    Vector3 posB,
    Vector3 pivotB,
    float t)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &posA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &posB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pivotB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraState.NativeMethodInfoPtr_InterpolatePosition_Private_Vector3_Vector3_Vector3_Vector3_Vector3_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public CameraState(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CameraState()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraState>.NativeClassPtr))
  {
  }

  public unsafe LensSettings Lens
  {
    get
    {
      return *(LensSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_Lens));
    }
    [param: In] set
    {
      *(LensSettings*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_Lens)) = value;
    }
  }

  public unsafe Vector3 ReferenceUp
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_ReferenceUp));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_ReferenceUp)) = value;
    }
  }

  public unsafe Vector3 ReferenceLookAt
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_ReferenceLookAt));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_ReferenceLookAt)) = value;
    }
  }

  public static unsafe Vector3 kNoPoint
  {
    get
    {
      Vector3 kNoPoint;
      IL2CPP.il2cpp_field_static_get_value(CameraState.NativeFieldInfoPtr_kNoPoint, (void*) &kNoPoint);
      return kNoPoint;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraState.NativeFieldInfoPtr_kNoPoint, (void*) &value);
    }
  }

  public unsafe Vector3 RawPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_RawPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_RawPosition)) = value;
    }
  }

  public unsafe Quaternion RawOrientation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_RawOrientation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_RawOrientation)) = value;
    }
  }

  public unsafe Vector3 PositionDampingBypass
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_PositionDampingBypass));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_PositionDampingBypass)) = value;
    }
  }

  public unsafe float ShotQuality
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_ShotQuality));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_ShotQuality)) = value;
    }
  }

  public unsafe Vector3 PositionCorrection
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_PositionCorrection));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_PositionCorrection)) = value;
    }
  }

  public unsafe Quaternion OrientationCorrection
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_OrientationCorrection));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_OrientationCorrection)) = value;
    }
  }

  public unsafe CameraState.BlendHintValue BlendHint
  {
    get
    {
      return *(CameraState.BlendHintValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_BlendHint));
    }
    [param: In] set
    {
      *(CameraState.BlendHintValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_BlendHint)) = value;
    }
  }

  public CameraState.CustomBlendable mCustom0
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom0);
      return new CameraState.CustomBlendable(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CameraState.CustomBlendable mCustom1
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom1);
      return new CameraState.CustomBlendable(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CameraState.CustomBlendable mCustom2
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom2);
      return new CameraState.CustomBlendable(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CameraState.CustomBlendable mCustom3
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom3);
      return new CameraState.CustomBlendable(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_mCustom3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe List<CameraState.CustomBlendable> m_CustomOverflow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_m_CustomOverflow));
      return num == System.IntPtr.Zero ? (List<CameraState.CustomBlendable>) null : Il2CppObjectPool.Get<List<CameraState.CustomBlendable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr_m_CustomOverflow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _NumCustomBlendables_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr__NumCustomBlendables_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.NativeFieldInfoPtr__NumCustomBlendables_k__BackingField)) = value;
    }
  }

  public enum BlendHintValue
  {
    Nothing = 0,
    NoPosition = 1,
    NoOrientation = 2,
    NoTransform = 3,
    SphericalPositionBlend = 4,
    CylindricalPositionBlend = 8,
    RadialAimBlend = 16, // 0x00000010
    IgnoreLookAtTarget = 32, // 0x00000020
    NoLens = 64, // 0x00000040
  }

  public sealed class CustomBlendable : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Custom;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Single_0;

    static CustomBlendable()
    {
      Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraState>.NativeClassPtr, nameof (CustomBlendable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr);
      CameraState.CustomBlendable.NativeFieldInfoPtr_m_Custom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, nameof (m_Custom));
      CameraState.CustomBlendable.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, nameof (m_Weight));
      CameraState.CustomBlendable.NativeMethodInfoPtr__ctor_Public_Void_Object_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr, 100663895);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942314, RefRangeEnd = 942315, XrefRangeStart = 942314, XrefRangeEnd = 942314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CustomBlendable(UnityEngine.Object custom, float weight)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) custom);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &weight;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CameraState.CustomBlendable.NativeMethodInfoPtr__ctor_Public_Void_Object_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public CustomBlendable(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CustomBlendable()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraState.CustomBlendable>.NativeClassPtr))
    {
    }

    public unsafe UnityEngine.Object m_Custom
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.CustomBlendable.NativeFieldInfoPtr_m_Custom));
        return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraState.CustomBlendable.NativeFieldInfoPtr_m_Custom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float m_Weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.CustomBlendable.NativeFieldInfoPtr_m_Weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraState.CustomBlendable.NativeFieldInfoPtr_m_Weight)) = value;
      }
    }
  }
}
