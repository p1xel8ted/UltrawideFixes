// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineBasicMultiChannelPerlin
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineBasicMultiChannelPerlin(IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_NoiseProfile;
  private static readonly IntPtr NativeFieldInfoPtr_m_PivotOffset;
  private static readonly IntPtr NativeFieldInfoPtr_m_AmplitudeGain;
  private static readonly IntPtr NativeFieldInfoPtr_m_FrequencyGain;
  private static readonly IntPtr NativeFieldInfoPtr_mInitialized;
  private static readonly IntPtr NativeFieldInfoPtr_mNoiseTime;
  private static readonly IntPtr NativeFieldInfoPtr_mNoiseOffsets;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReSeed_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineBasicMultiChannelPerlin()
  {
    Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineBasicMultiChannelPerlin));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr);
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_NoiseProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (m_NoiseProfile));
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_PivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (m_PivotOffset));
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_AmplitudeGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (m_AmplitudeGain));
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_FrequencyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (m_FrequencyGain));
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (mInitialized));
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mNoiseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (mNoiseTime));
    CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mNoiseOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, nameof (mNoiseOffsets));
    CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, 100663728 /*0x060001B0*/);
    CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, 100663729);
    CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, 100663730);
    CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_ReSeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, 100663731);
    CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, 100663732);
    CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr, 100663733);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941059, XrefRangeEnd = 941061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941061, XrefRangeEnd = 941098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941098, XrefRangeEnd = 941101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReSeed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_ReSeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941101, XrefRangeEnd = 941110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941110, XrefRangeEnd = 941115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBasicMultiChannelPerlin()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBasicMultiChannelPerlin>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBasicMultiChannelPerlin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe NoiseSettings m_NoiseProfile
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_NoiseProfile));
      return num == IntPtr.Zero ? (NoiseSettings) null : Il2CppObjectPool.Get<NoiseSettings>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_NoiseProfile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 m_PivotOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_PivotOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_PivotOffset)) = value;
    }
  }

  public unsafe float m_AmplitudeGain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_AmplitudeGain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_AmplitudeGain)) = value;
    }
  }

  public unsafe float m_FrequencyGain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_FrequencyGain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_m_FrequencyGain)) = value;
    }
  }

  public unsafe bool mInitialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mInitialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mInitialized)) = value;
    }
  }

  public unsafe float mNoiseTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mNoiseTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mNoiseTime)) = value;
    }
  }

  public unsafe Vector3 mNoiseOffsets
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mNoiseOffsets));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBasicMultiChannelPerlin.NativeFieldInfoPtr_mNoiseOffsets)) = value;
    }
  }
}
