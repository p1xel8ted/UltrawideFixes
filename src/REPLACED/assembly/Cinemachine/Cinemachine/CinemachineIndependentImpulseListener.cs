// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineIndependentImpulseListener
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

public class CinemachineIndependentImpulseListener(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_impulsePosLastFrame;
  private static readonly IntPtr NativeFieldInfoPtr_impulseRotLastFrame;
  private static readonly IntPtr NativeFieldInfoPtr_m_ChannelMask;
  private static readonly IntPtr NativeFieldInfoPtr_m_Gain;
  private static readonly IntPtr NativeFieldInfoPtr_m_Use2DDistance;
  private static readonly IntPtr NativeFieldInfoPtr_m_UseLocalSpace;
  private static readonly IntPtr NativeFieldInfoPtr_m_ReactionSettings;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineIndependentImpulseListener()
  {
    Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineIndependentImpulseListener));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr);
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_impulsePosLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (impulsePosLastFrame));
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_impulseRotLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (impulseRotLastFrame));
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_ChannelMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (m_ChannelMask));
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (m_Gain));
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_Use2DDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (m_Use2DDistance));
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_UseLocalSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (m_UseLocalSpace));
    CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_ReactionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, nameof (m_ReactionSettings));
    CinemachineIndependentImpulseListener.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, 100664301);
    CinemachineIndependentImpulseListener.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, 100664302);
    CinemachineIndependentImpulseListener.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, 100664303);
    CinemachineIndependentImpulseListener.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, 100664304 /*0x060003F0*/);
    CinemachineIndependentImpulseListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr, 100664305);
  }

  [CallerCount(0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineIndependentImpulseListener.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945840, XrefRangeEnd = 945844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineIndependentImpulseListener.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945844, XrefRangeEnd = 945852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineIndependentImpulseListener.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945852, XrefRangeEnd = 945871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineIndependentImpulseListener.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineIndependentImpulseListener()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineIndependentImpulseListener>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineIndependentImpulseListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 impulsePosLastFrame
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_impulsePosLastFrame));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_impulsePosLastFrame)) = value;
    }
  }

  public unsafe Quaternion impulseRotLastFrame
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_impulseRotLastFrame));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_impulseRotLastFrame)) = value;
    }
  }

  public unsafe int m_ChannelMask
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_ChannelMask));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_ChannelMask)) = value;
    }
  }

  public unsafe float m_Gain
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_Gain));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_Gain)) = value;
    }
  }

  public unsafe bool m_Use2DDistance
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_Use2DDistance));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_Use2DDistance)) = value;
    }
  }

  public unsafe bool m_UseLocalSpace
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_UseLocalSpace));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_UseLocalSpace)) = value;
    }
  }

  public CinemachineImpulseListener.ImpulseReaction m_ReactionSettings
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_ReactionSettings);
      return new CinemachineImpulseListener.ImpulseReaction(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineIndependentImpulseListener.NativeFieldInfoPtr_m_ReactionSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineImpulseListener.ImpulseReaction>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }
}
