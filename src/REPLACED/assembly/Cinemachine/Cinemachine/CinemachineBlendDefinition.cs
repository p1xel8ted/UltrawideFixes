// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineBlendDefinition
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
public sealed class CinemachineBlendDefinition : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Style;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_sStandardCurves;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BlendTime_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Style_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateStandardCurves_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BlendCurve_Public_get_AnimationCurve_0;

  static CinemachineBlendDefinition()
  {
    Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineBlendDefinition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr);
    CinemachineBlendDefinition.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, nameof (m_Style));
    CinemachineBlendDefinition.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, nameof (m_Time));
    CinemachineBlendDefinition.NativeFieldInfoPtr_m_CustomCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, nameof (m_CustomCurve));
    CinemachineBlendDefinition.NativeFieldInfoPtr_sStandardCurves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, nameof (sStandardCurves));
    CinemachineBlendDefinition.NativeMethodInfoPtr_get_BlendTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, 100663904 /*0x06000260*/);
    CinemachineBlendDefinition.NativeMethodInfoPtr__ctor_Public_Void_Style_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, 100663905);
    CinemachineBlendDefinition.NativeMethodInfoPtr_CreateStandardCurves_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, 100663906);
    CinemachineBlendDefinition.NativeMethodInfoPtr_get_BlendCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, 100663907);
  }

  public unsafe float BlendTime
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 942708, RefRangeEnd = 942710, XrefRangeStart = 942708, XrefRangeEnd = 942708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlendDefinition.NativeMethodInfoPtr_get_BlendTime_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 942710, RefRangeEnd = 942713, XrefRangeStart = 942710, XrefRangeEnd = 942710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlendDefinition(CinemachineBlendDefinition.Style style, float time)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &style;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBlendDefinition.NativeMethodInfoPtr__ctor_Public_Void_Style_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 942761, RefRangeEnd = 942762, XrefRangeStart = 942713, XrefRangeEnd = 942761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateStandardCurves()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBlendDefinition.NativeMethodInfoPtr_CreateStandardCurves_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve BlendCurve
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 942766, RefRangeEnd = 942770, XrefRangeStart = 942762, XrefRangeEnd = 942766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineBlendDefinition.NativeMethodInfoPtr_get_BlendCurve_Public_get_AnimationCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public CinemachineBlendDefinition(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CinemachineBlendDefinition()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr))
  {
  }

  public unsafe CinemachineBlendDefinition.Style m_Style
  {
    get
    {
      return *(CinemachineBlendDefinition.Style*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendDefinition.NativeFieldInfoPtr_m_Style));
    }
    [param: In] set
    {
      *(CinemachineBlendDefinition.Style*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendDefinition.NativeFieldInfoPtr_m_Style)) = value;
    }
  }

  public unsafe float m_Time
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendDefinition.NativeFieldInfoPtr_m_Time));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendDefinition.NativeFieldInfoPtr_m_Time)) = value;
    }
  }

  public unsafe AnimationCurve m_CustomCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendDefinition.NativeFieldInfoPtr_m_CustomCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendDefinition.NativeFieldInfoPtr_m_CustomCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<AnimationCurve> sStandardCurves
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineBlendDefinition.NativeFieldInfoPtr_sStandardCurves, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<AnimationCurve>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AnimationCurve>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineBlendDefinition.NativeFieldInfoPtr_sStandardCurves, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Style
  {
    Cut,
    EaseInOut,
    EaseIn,
    EaseOut,
    HardIn,
    HardOut,
    Linear,
    Custom,
  }
}
