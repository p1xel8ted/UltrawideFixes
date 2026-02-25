// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineImpulseDefinition
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

[Serializable]
public class CinemachineImpulseDefinition(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ImpulseChannel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ImpulseShape;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomImpulseShape;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ImpulseDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ImpulseType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DissipationRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RawSignal;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AmplitudeGain;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FrequencyGain;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RepeatMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Randomize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeEnvelope;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ImpactRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DirectionMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DissipationMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DissipationDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PropagationSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_sStandardShapes;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateStandardShapes_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStandardCurve_Internal_Static_AnimationCurve_ImpulseShapes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpulseCurve_Internal_get_AnimationCurve_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateAndReturnEvent_Public_ImpulseEvent_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LegacyCreateAndReturnEvent_Private_ImpulseEvent_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineImpulseDefinition()
  {
    Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineImpulseDefinition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr);
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_ImpulseChannel));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_ImpulseShape));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_CustomImpulseShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_CustomImpulseShape));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_ImpulseDuration));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_ImpulseType));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_DissipationRate));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_RawSignal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_RawSignal));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_AmplitudeGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_AmplitudeGain));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_FrequencyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_FrequencyGain));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_RepeatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_RepeatMode));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_Randomize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_Randomize));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_TimeEnvelope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_TimeEnvelope));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpactRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_ImpactRadius));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DirectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_DirectionMode));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_DissipationMode));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_DissipationDistance));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_m_PropagationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (m_PropagationSpeed));
    CinemachineImpulseDefinition.NativeFieldInfoPtr_sStandardShapes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (sStandardShapes));
    CinemachineImpulseDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664252);
    CinemachineImpulseDefinition.NativeMethodInfoPtr_CreateStandardShapes_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664253);
    CinemachineImpulseDefinition.NativeMethodInfoPtr_GetStandardCurve_Internal_Static_AnimationCurve_ImpulseShapes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664254);
    CinemachineImpulseDefinition.NativeMethodInfoPtr_get_ImpulseCurve_Internal_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664255);
    CinemachineImpulseDefinition.NativeMethodInfoPtr_CreateEvent_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664256 /*0x060003C0*/);
    CinemachineImpulseDefinition.NativeMethodInfoPtr_CreateAndReturnEvent_Public_ImpulseEvent_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664257);
    CinemachineImpulseDefinition.NativeMethodInfoPtr_LegacyCreateAndReturnEvent_Private_ImpulseEvent_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664258);
    CinemachineImpulseDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, 100664259);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945428, RefRangeEnd = 945429, XrefRangeStart = 945422, XrefRangeEnd = 945428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945509, RefRangeEnd = 945511, XrefRangeStart = 945429, XrefRangeEnd = 945509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateStandardShapes()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_CreateStandardShapes_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945511, XrefRangeEnd = 945515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AnimationCurve GetStandardCurve(
    CinemachineImpulseDefinition.ImpulseShapes shape)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &shape
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_GetStandardCurve_Internal_Static_AnimationCurve_ImpulseShapes_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
  }

  public unsafe AnimationCurve ImpulseCurve
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 945519, RefRangeEnd = 945520, XrefRangeStart = 945515, XrefRangeEnd = 945519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_get_ImpulseCurve_Internal_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 945521, RefRangeEnd = 945530, XrefRangeStart = 945520, XrefRangeEnd = 945521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateEvent(Vector3 position, Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_CreateEvent_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945558, RefRangeEnd = 945559, XrefRangeStart = 945530, XrefRangeEnd = 945558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(
    Vector3 position,
    Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_CreateAndReturnEvent_Public_ImpulseEvent_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineImpulseManager.ImpulseEvent) null : Il2CppObjectPool.Get<CinemachineImpulseManager.ImpulseEvent>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945559, XrefRangeEnd = 945575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseManager.ImpulseEvent LegacyCreateAndReturnEvent(
    Vector3 position,
    Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr_LegacyCreateAndReturnEvent_Private_ImpulseEvent_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineImpulseManager.ImpulseEvent) null : Il2CppObjectPool.Get<CinemachineImpulseManager.ImpulseEvent>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945581, RefRangeEnd = 945583, XrefRangeStart = 945575, XrefRangeEnd = 945581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseDefinition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int m_ImpulseChannel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseChannel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseChannel)) = value;
    }
  }

  public unsafe CinemachineImpulseDefinition.ImpulseShapes m_ImpulseShape
  {
    get
    {
      return *(CinemachineImpulseDefinition.ImpulseShapes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseShape));
    }
    [param: In] set
    {
      *(CinemachineImpulseDefinition.ImpulseShapes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseShape)) = value;
    }
  }

  public unsafe AnimationCurve m_CustomImpulseShape
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_CustomImpulseShape));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_CustomImpulseShape), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_ImpulseDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseDuration)) = value;
    }
  }

  public unsafe CinemachineImpulseDefinition.ImpulseTypes m_ImpulseType
  {
    get
    {
      return *(CinemachineImpulseDefinition.ImpulseTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseType));
    }
    [param: In] set
    {
      *(CinemachineImpulseDefinition.ImpulseTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpulseType)) = value;
    }
  }

  public unsafe float m_DissipationRate
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationRate));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationRate)) = value;
    }
  }

  public unsafe SignalSourceAsset m_RawSignal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_RawSignal));
      return num == System.IntPtr.Zero ? (SignalSourceAsset) null : Il2CppObjectPool.Get<SignalSourceAsset>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_RawSignal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_AmplitudeGain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_AmplitudeGain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_AmplitudeGain)) = value;
    }
  }

  public unsafe float m_FrequencyGain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_FrequencyGain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_FrequencyGain)) = value;
    }
  }

  public unsafe CinemachineImpulseDefinition.RepeatMode m_RepeatMode
  {
    get
    {
      return *(CinemachineImpulseDefinition.RepeatMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_RepeatMode));
    }
    [param: In] set
    {
      *(CinemachineImpulseDefinition.RepeatMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_RepeatMode)) = value;
    }
  }

  public unsafe bool m_Randomize
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_Randomize));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_Randomize)) = value;
    }
  }

  public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_TimeEnvelope);
      return new CinemachineImpulseManager.EnvelopeDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_TimeEnvelope), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float m_ImpactRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpactRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_ImpactRadius)) = value;
    }
  }

  public unsafe CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode
  {
    get
    {
      return *(CinemachineImpulseManager.ImpulseEvent.DirectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DirectionMode));
    }
    [param: In] set
    {
      *(CinemachineImpulseManager.ImpulseEvent.DirectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DirectionMode)) = value;
    }
  }

  public unsafe CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode
  {
    get
    {
      return *(CinemachineImpulseManager.ImpulseEvent.DissipationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationMode));
    }
    [param: In] set
    {
      *(CinemachineImpulseManager.ImpulseEvent.DissipationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationMode)) = value;
    }
  }

  public unsafe float m_DissipationDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_DissipationDistance)) = value;
    }
  }

  public unsafe float m_PropagationSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_PropagationSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.NativeFieldInfoPtr_m_PropagationSpeed)) = value;
    }
  }

  public static unsafe Il2CppReferenceArray<AnimationCurve> sStandardShapes
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineImpulseDefinition.NativeFieldInfoPtr_sStandardShapes, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<AnimationCurve>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationCurve>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineImpulseDefinition.NativeFieldInfoPtr_sStandardShapes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum ImpulseShapes
  {
    Custom,
    Recoil,
    Bump,
    Explosion,
    Rumble,
  }

  public enum ImpulseTypes
  {
    Uniform,
    Dissipating,
    Propagating,
    Legacy,
  }

  public enum RepeatMode
  {
    Stretch,
    Loop,
  }

  public class SignalSource(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Def;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Velocity;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CinemachineImpulseDefinition_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSignal_Public_Virtual_Final_New_Void_Single_byref_Vector3_byref_Quaternion_0;

    static SignalSource()
    {
      Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (SignalSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr);
      CinemachineImpulseDefinition.SignalSource.NativeFieldInfoPtr_m_Def = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr, nameof (m_Def));
      CinemachineImpulseDefinition.SignalSource.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr, nameof (m_Velocity));
      CinemachineImpulseDefinition.SignalSource.NativeMethodInfoPtr__ctor_Public_Void_CinemachineImpulseDefinition_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr, 100664260);
      CinemachineImpulseDefinition.SignalSource.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr, 100664261);
      CinemachineImpulseDefinition.SignalSource.NativeMethodInfoPtr_GetSignal_Public_Virtual_Final_New_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr, 100664262);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945391, RefRangeEnd = 945392, XrefRangeStart = 945390, XrefRangeEnd = 945391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SignalSource(CinemachineImpulseDefinition def, Vector3 velocity)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseDefinition.SignalSource>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) def);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.SignalSource.NativeMethodInfoPtr__ctor_Public_Void_CinemachineImpulseDefinition_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe float SignalDuration
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.SignalSource.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945392, XrefRangeEnd = 945396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetSignal(
      float timeSinceSignalStart,
      out Vector3 pos,
      out Quaternion rot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &timeSinceSignalStart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rot;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.SignalSource.NativeMethodInfoPtr_GetSignal_Public_Virtual_Final_New_Void_Single_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CinemachineImpulseDefinition m_Def
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.SignalSource.NativeFieldInfoPtr_m_Def));
        return num == System.IntPtr.Zero ? (CinemachineImpulseDefinition) null : Il2CppObjectPool.Get<CinemachineImpulseDefinition>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.SignalSource.NativeFieldInfoPtr_m_Def), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 m_Velocity
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.SignalSource.NativeFieldInfoPtr_m_Velocity));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.SignalSource.NativeFieldInfoPtr_m_Velocity)) = value;
      }
    }
  }

  public class LegacySignalSource(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Def;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTimeOffset;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CinemachineImpulseDefinition_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSignal_Public_Virtual_Final_New_Void_Single_byref_Vector3_byref_Quaternion_0;

    static LegacySignalSource()
    {
      Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineImpulseDefinition>.NativeClassPtr, nameof (LegacySignalSource));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr);
      CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_Def = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr, nameof (m_Def));
      CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr, nameof (m_Velocity));
      CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_StartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr, nameof (m_StartTimeOffset));
      CinemachineImpulseDefinition.LegacySignalSource.NativeMethodInfoPtr__ctor_Public_Void_CinemachineImpulseDefinition_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr, 100664263);
      CinemachineImpulseDefinition.LegacySignalSource.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr, 100664264);
      CinemachineImpulseDefinition.LegacySignalSource.NativeMethodInfoPtr_GetSignal_Public_Virtual_Final_New_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr, 100664265);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 945398, RefRangeEnd = 945400, XrefRangeStart = 945396, XrefRangeEnd = 945398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LegacySignalSource(CinemachineImpulseDefinition def, Vector3 velocity)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseDefinition.LegacySignalSource>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) def);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &velocity;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.LegacySignalSource.NativeMethodInfoPtr__ctor_Public_Void_CinemachineImpulseDefinition_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe float SignalDuration
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945400, XrefRangeEnd = 945401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.LegacySignalSource.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945401, XrefRangeEnd = 945422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void GetSignal(
      float timeSinceSignalStart,
      out Vector3 pos,
      out Quaternion rot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &timeSinceSignalStart;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rot;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseDefinition.LegacySignalSource.NativeMethodInfoPtr_GetSignal_Public_Virtual_Final_New_Void_Single_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CinemachineImpulseDefinition m_Def
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_Def));
        return num == System.IntPtr.Zero ? (CinemachineImpulseDefinition) null : Il2CppObjectPool.Get<CinemachineImpulseDefinition>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_Def), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 m_Velocity
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_Velocity));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_Velocity)) = value;
      }
    }

    public unsafe float m_StartTimeOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_StartTimeOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseDefinition.LegacySignalSource.NativeFieldInfoPtr_m_StartTimeOffset)) = value;
      }
    }
  }
}
