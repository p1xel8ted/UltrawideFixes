// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineImpulseManager
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class CinemachineImpulseManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiredEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreTimeScale;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CinemachineImpulseManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateDissipationScale_Internal_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetImpulseAt_Public_Boolean_Vector3_Boolean_Int32_byref_Vector3_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NewImpulseEvent_Public_ImpulseEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddImpulseEvent_Public_Void_ImpulseEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

  static CinemachineImpulseManager()
  {
    Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineImpulseManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr);
    CinemachineImpulseManager.NativeFieldInfoPtr_sInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, nameof (sInstance));
    CinemachineImpulseManager.NativeFieldInfoPtr_m_ExpiredEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, nameof (m_ExpiredEvents));
    CinemachineImpulseManager.NativeFieldInfoPtr_m_ActiveEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, nameof (m_ActiveEvents));
    CinemachineImpulseManager.NativeFieldInfoPtr_IgnoreTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, nameof (IgnoreTimeScale));
    CinemachineImpulseManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664272 /*0x060003D0*/);
    CinemachineImpulseManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_CinemachineImpulseManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664273);
    CinemachineImpulseManager.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664274);
    CinemachineImpulseManager.NativeMethodInfoPtr_EvaluateDissipationScale_Internal_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664275);
    CinemachineImpulseManager.NativeMethodInfoPtr_GetImpulseAt_Public_Boolean_Vector3_Boolean_Int32_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664276);
    CinemachineImpulseManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664277);
    CinemachineImpulseManager.NativeMethodInfoPtr_NewImpulseEvent_Public_ImpulseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664278);
    CinemachineImpulseManager.NativeMethodInfoPtr_AddImpulseEvent_Public_Void_ImpulseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664279);
    CinemachineImpulseManager.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, 100664280);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe CinemachineImpulseManager Instance
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 945708, RefRangeEnd = 945719, XrefRangeStart = 945702, XrefRangeEnd = 945708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_CinemachineImpulseManager_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineImpulseManager) null : Il2CppObjectPool.Get<CinemachineImpulseManager>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945719, XrefRangeEnd = 945730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeModule()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945730, XrefRangeEnd = 945734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float EvaluateDissipationScale(float spread, float normalizedDistance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &spread;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &normalizedDistance;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_EvaluateDissipationScale_Internal_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945762, RefRangeEnd = 945764, XrefRangeStart = 945734, XrefRangeEnd = 945762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetImpulseAt(
    Vector3 listenerLocation,
    bool distance2D,
    int channelMask,
    out Vector3 pos,
    out Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &listenerLocation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distance2D;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &channelMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref rot;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_GetImpulseAt_Public_Boolean_Vector3_Boolean_Int32_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float CurrentTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945764, XrefRangeEnd = 945769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 945777, RefRangeEnd = 945780, XrefRangeStart = 945769, XrefRangeEnd = 945777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseManager.ImpulseEvent NewImpulseEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_NewImpulseEvent_Public_ImpulseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineImpulseManager.ImpulseEvent) null : Il2CppObjectPool.Get<CinemachineImpulseManager.ImpulseEvent>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 945795, RefRangeEnd = 945798, XrefRangeStart = 945780, XrefRangeEnd = 945795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddImpulseEvent(CinemachineImpulseManager.ImpulseEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_AddImpulseEvent_Public_Void_ImpulseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945807, RefRangeEnd = 945808, XrefRangeStart = 945798, XrefRangeEnd = 945807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe CinemachineImpulseManager sInstance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineImpulseManager.NativeFieldInfoPtr_sInstance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineImpulseManager) null : Il2CppObjectPool.Get<CinemachineImpulseManager>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineImpulseManager.NativeFieldInfoPtr_sInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.NativeFieldInfoPtr_m_ExpiredEvents));
      return num == System.IntPtr.Zero ? (List<CinemachineImpulseManager.ImpulseEvent>) null : Il2CppObjectPool.Get<List<CinemachineImpulseManager.ImpulseEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.NativeFieldInfoPtr_m_ExpiredEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.NativeFieldInfoPtr_m_ActiveEvents));
      return num == System.IntPtr.Zero ? (List<CinemachineImpulseManager.ImpulseEvent>) null : Il2CppObjectPool.Get<List<CinemachineImpulseManager.ImpulseEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.NativeFieldInfoPtr_m_ActiveEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool IgnoreTimeScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.NativeFieldInfoPtr_IgnoreTimeScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.NativeFieldInfoPtr_IgnoreTimeScale)) = value;
    }
  }

  [Serializable]
  public sealed class EnvelopeDefinition : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackShape;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DecayShape;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AttackTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SustainTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DecayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ScaleWithImpact;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HoldForever;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_EnvelopeDefinition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Duration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValueAt_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_Void_0;

    static EnvelopeDefinition()
    {
      Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, nameof (EnvelopeDefinition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr);
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_AttackShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_AttackShape));
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_DecayShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_DecayShape));
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_AttackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_AttackTime));
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_SustainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_SustainTime));
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_DecayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_DecayTime));
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_ScaleWithImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_ScaleWithImpact));
      CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_HoldForever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, nameof (m_HoldForever));
      CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_Default_Public_Static_EnvelopeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, 100664281);
      CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_get_Duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, 100664282);
      CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_GetValueAt_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, 100664283);
      CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, 100664284);
      CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_Validate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, 100664285);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945632, RefRangeEnd = 945633, XrefRangeStart = 945632, XrefRangeEnd = 945632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CinemachineImpulseManager.EnvelopeDefinition Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_Default_Public_Static_EnvelopeDefinition_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CinemachineImpulseManager.EnvelopeDefinition(pointer);
    }

    public unsafe float Duration
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 945633, RefRangeEnd = 945635, XrefRangeStart = 945633, XrefRangeEnd = 945633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_get_Duration_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945641, RefRangeEnd = 945642, XrefRangeStart = 945635, XrefRangeEnd = 945641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetValueAt(float offset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &offset
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_GetValueAt_Public_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945642, RefRangeEnd = 945643, XrefRangeStart = 945642, XrefRangeEnd = 945642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Validate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.EnvelopeDefinition.NativeMethodInfoPtr_Validate_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public EnvelopeDefinition(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public EnvelopeDefinition()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr))
    {
    }

    public unsafe AnimationCurve m_AttackShape
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_AttackShape));
        return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_AttackShape), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve m_DecayShape
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_DecayShape));
        return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_DecayShape), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float m_AttackTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_AttackTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_AttackTime)) = value;
      }
    }

    public unsafe float m_SustainTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_SustainTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_SustainTime)) = value;
      }
    }

    public unsafe float m_DecayTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_DecayTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_DecayTime)) = value;
      }
    }

    public unsafe bool m_ScaleWithImpact
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_ScaleWithImpact));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_ScaleWithImpact)) = value;
      }
    }

    public unsafe bool m_HoldForever
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_HoldForever));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.EnvelopeDefinition.NativeFieldInfoPtr_m_HoldForever)) = value;
      }
    }
  }

  public class ImpulseEvent(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Envelope;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SignalSource;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DirectionMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Channel;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DissipationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DissipationDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomDissipation;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PropagationSpeed;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DistanceDecay_Public_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDecayedSignal_Public_Boolean_Vector3_Boolean_byref_Vector3_byref_Quaternion_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

    static ImpulseEvent()
    {
      Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineImpulseManager>.NativeClassPtr, nameof (ImpulseEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr);
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_StartTime));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Envelope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_Envelope));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_SignalSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_SignalSource));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_Position));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_Radius));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DirectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_DirectionMode));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_Channel));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DissipationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_DissipationMode));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DissipationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_DissipationDistance));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_CustomDissipation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_CustomDissipation));
      CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_PropagationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, nameof (m_PropagationSpeed));
      CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, 100664286);
      CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_DistanceDecay_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, 100664287);
      CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_GetDecayedSignal_Public_Boolean_Vector3_Boolean_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, 100664288 /*0x060003E0*/);
      CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, 100664289);
      CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr, 100664290);
    }

    public unsafe bool Expired
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 945651, RefRangeEnd = 945652, XrefRangeStart = 945643, XrefRangeEnd = 945651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945653, RefRangeEnd = 945654, XrefRangeStart = 945652, XrefRangeEnd = 945653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float DistanceDecay(float distance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &distance
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_DistanceDecay_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945698, RefRangeEnd = 945699, XrefRangeStart = 945654, XrefRangeEnd = 945698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetDecayedSignal(
      Vector3 listenerPosition,
      bool use2D,
      out Vector3 pos,
      out Quaternion rot)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &listenerPosition;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &use2D;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref pos;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref rot;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_GetDecayedSignal_Public_Boolean_Vector3_Boolean_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945701, RefRangeEnd = 945702, XrefRangeStart = 945699, XrefRangeEnd = 945701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ImpulseEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseManager.ImpulseEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseManager.ImpulseEvent.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float m_StartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_StartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_StartTime)) = value;
      }
    }

    public CinemachineImpulseManager.EnvelopeDefinition m_Envelope
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Envelope);
        return new CinemachineImpulseManager.EnvelopeDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Envelope), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineImpulseManager.EnvelopeDefinition>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ISignalSource6D m_SignalSource
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_SignalSource));
        return num == System.IntPtr.Zero ? (ISignalSource6D) null : Il2CppObjectPool.Get<ISignalSource6D>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_SignalSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 m_Position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Position)) = value;
      }
    }

    public unsafe float m_Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Radius)) = value;
      }
    }

    public unsafe CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode
    {
      get
      {
        return *(CinemachineImpulseManager.ImpulseEvent.DirectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DirectionMode));
      }
      [param: In] set
      {
        *(CinemachineImpulseManager.ImpulseEvent.DirectionMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DirectionMode)) = value;
      }
    }

    public unsafe int m_Channel
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Channel));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_Channel)) = value;
      }
    }

    public unsafe CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode
    {
      get
      {
        return *(CinemachineImpulseManager.ImpulseEvent.DissipationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DissipationMode));
      }
      [param: In] set
      {
        *(CinemachineImpulseManager.ImpulseEvent.DissipationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DissipationMode)) = value;
      }
    }

    public unsafe float m_DissipationDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DissipationDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_DissipationDistance)) = value;
      }
    }

    public unsafe float m_CustomDissipation
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_CustomDissipation));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_CustomDissipation)) = value;
      }
    }

    public unsafe float m_PropagationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_PropagationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineImpulseManager.ImpulseEvent.NativeFieldInfoPtr_m_PropagationSpeed)) = value;
      }
    }

    public enum DirectionMode
    {
      Fixed,
      RotateTowardSource,
    }

    public enum DissipationMode
    {
      LinearDecay,
      SoftDecay,
      ExponentialDecay,
    }
  }
}
