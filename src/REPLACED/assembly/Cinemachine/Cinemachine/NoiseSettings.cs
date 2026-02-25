// Decompiled with JetBrains decompiler
// Type: Cinemachine.NoiseSettings
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

public sealed class NoiseSettings(System.IntPtr pointer) : SignalSourceAsset(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_PositionNoise;
  private static readonly System.IntPtr NativeFieldInfoPtr_OrientationNoise;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCombinedFilterResults_Public_Static_Vector3_Il2CppStructArray_1_TransformNoiseParams_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSignal_Public_Virtual_Void_Single_byref_Vector3_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NoiseSettings()
  {
    Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (NoiseSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr);
    NoiseSettings.NativeFieldInfoPtr_PositionNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, nameof (PositionNoise));
    NoiseSettings.NativeFieldInfoPtr_OrientationNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, nameof (OrientationNoise));
    NoiseSettings.NativeMethodInfoPtr_GetCombinedFilterResults_Public_Static_Vector3_Il2CppStructArray_1_TransformNoiseParams_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, 100664172);
    NoiseSettings.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, 100664173);
    NoiseSettings.NativeMethodInfoPtr_GetSignal_Public_Virtual_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, 100664174);
    NoiseSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, 100664175);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944641, RefRangeEnd = 944647, XrefRangeStart = 944637, XrefRangeEnd = 944641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetCombinedFilterResults(
    Il2CppStructArray<NoiseSettings.TransformNoiseParams> noiseParams,
    float time,
    Vector3 timeOffsets)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) noiseParams);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &timeOffsets;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoiseSettings.NativeMethodInfoPtr_GetCombinedFilterResults_Public_Static_Vector3_Il2CppStructArray_1_TransformNoiseParams_Single_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public override unsafe float SignalDuration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoiseSettings.NativeMethodInfoPtr_get_SignalDuration_Public_Virtual_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944647, XrefRangeEnd = 944654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void GetSignal(
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
    IL2CPP.il2cpp_runtime_invoke(NoiseSettings.NativeMethodInfoPtr_GetSignal_Public_Virtual_Void_Single_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944654, XrefRangeEnd = 944660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NoiseSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NoiseSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStructArray<NoiseSettings.TransformNoiseParams> PositionNoise
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoiseSettings.NativeFieldInfoPtr_PositionNoise));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<NoiseSettings.TransformNoiseParams>) null : Il2CppObjectPool.Get<Il2CppStructArray<NoiseSettings.TransformNoiseParams>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoiseSettings.NativeFieldInfoPtr_PositionNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<NoiseSettings.TransformNoiseParams> OrientationNoise
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NoiseSettings.NativeFieldInfoPtr_OrientationNoise));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<NoiseSettings.TransformNoiseParams>) null : Il2CppObjectPool.Get<Il2CppStructArray<NoiseSettings.TransformNoiseParams>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NoiseSettings.NativeFieldInfoPtr_OrientationNoise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct NoiseParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Frequency;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amplitude;
    private static readonly System.IntPtr NativeFieldInfoPtr_Constant;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValueAt_Public_Single_Single_Single_0;
    [FieldOffset(0)]
    public float Frequency;
    [FieldOffset(4)]
    public float Amplitude;
    [FieldOffset(8)]
    public bool Constant;

    static NoiseParams()
    {
      Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, nameof (NoiseParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr);
      NoiseSettings.NoiseParams.NativeFieldInfoPtr_Frequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr, nameof (Frequency));
      NoiseSettings.NoiseParams.NativeFieldInfoPtr_Amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr, nameof (Amplitude));
      NoiseSettings.NoiseParams.NativeFieldInfoPtr_Constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr, nameof (Constant));
      NoiseSettings.NoiseParams.NativeMethodInfoPtr_GetValueAt_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr, 100664176 /*0x06000370*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944626, XrefRangeEnd = 944627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetValueAt(float time, float timeOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &timeOffset;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoiseSettings.NoiseParams.NativeMethodInfoPtr_GetValueAt_Public_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoiseSettings.NoiseParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TransformNoiseParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Y;
    private static readonly System.IntPtr NativeFieldInfoPtr_Z;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValueAt_Public_Vector3_Single_Vector3_0;
    [FieldOffset(0)]
    public NoiseSettings.NoiseParams X;
    [FieldOffset(12)]
    public NoiseSettings.NoiseParams Y;
    [FieldOffset(24)]
    public NoiseSettings.NoiseParams Z;

    static TransformNoiseParams()
    {
      Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoiseSettings>.NativeClassPtr, nameof (TransformNoiseParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr);
      NoiseSettings.TransformNoiseParams.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr, nameof (X));
      NoiseSettings.TransformNoiseParams.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr, nameof (Y));
      NoiseSettings.TransformNoiseParams.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr, nameof (Z));
      NoiseSettings.TransformNoiseParams.NativeMethodInfoPtr_GetValueAt_Public_Vector3_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr, 100664177);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944636, RefRangeEnd = 944637, XrefRangeStart = 944627, XrefRangeEnd = 944636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector3 GetValueAt(float time, Vector3 timeOffsets)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &timeOffsets;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NoiseSettings.TransformNoiseParams.NativeMethodInfoPtr_GetValueAt_Public_Vector3_Single_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoiseSettings.TransformNoiseParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
