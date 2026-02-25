// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatDynamicTutorialsController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatDynamicTutorialsController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_deflectPromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickaxePromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_healingPromptRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockedCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_deflectCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_holdTotalTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_abilityStateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_pickaxeCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_deflectCoroutine;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAnnounce_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveShotAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearShotAnnouce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectAnnounce_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PickaxeTutorial_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeflectTutorial_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatDynamicTutorialsController()
  {
    Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatDynamicTutorialsController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr);
    CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectPromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (deflectPromptRef));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_pickaxePromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (pickaxePromptRef));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_healingPromptRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (healingPromptRef));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_blockedCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (blockedCounter));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (deflectCounter));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_holdTotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (holdTotalTime));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_abilityStateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (abilityStateController));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_pickaxeCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (pickaxeCoroutine));
    CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, nameof (deflectCoroutine));
    CombatDynamicTutorialsController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677135);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677136);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677137);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677138);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677139);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_ProcessAnnounce_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677140);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_ReceiveShotAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677141);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_ClearShotAnnouce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677142);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_ConnectAnnounce_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677143);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_ProcessAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677144);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_PickaxeTutorial_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677145);
    CombatDynamicTutorialsController.NativeMethodInfoPtr_DeflectTutorial_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677146);
    CombatDynamicTutorialsController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, 100677147);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128382, XrefRangeEnd = 128388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128388, XrefRangeEnd = 128398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection(
    AttackObject attack,
    HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection(
    AttackObject attack,
    HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SendAnnounce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessAnnounce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_ProcessAnnounce_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128398, XrefRangeEnd = 128408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReceiveShotAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_ReceiveShotAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ClearShotAnnouce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_ClearShotAnnouce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128408, XrefRangeEnd = 128428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ConnectAnnounce(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_ConnectAnnounce_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_ProcessAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128428, XrefRangeEnd = 128432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator PickaxeTutorial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_PickaxeTutorial_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 128436, RefRangeEnd = 128438, XrefRangeStart = 128432, XrefRangeEnd = 128436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator DeflectTutorial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr_DeflectTutorial_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128438, XrefRangeEnd = 128439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatDynamicTutorialsController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef deflectPromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectPromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectPromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef pickaxePromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_pickaxePromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_pickaxePromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef healingPromptRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_healingPromptRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_healingPromptRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference blockedCounter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_blockedCounter));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_blockedCounter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference deflectCounter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectCounter));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectCounter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float holdTotalTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_holdTotalTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_holdTotalTime)) = value;
    }
  }

  public unsafe AbilityStateController abilityStateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_abilityStateController));
      return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_abilityStateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IEnumerator pickaxeCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_pickaxeCoroutine));
      return num == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_pickaxeCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IEnumerator deflectCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectCoroutine));
      return num == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController.NativeFieldInfoPtr_deflectCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CombatDynamicTutorialsController+<DeflectTutorial>d__20")]
  public sealed class _DeflectTutorial_d__20(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _DeflectTutorial_d__20()
    {
      Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, "<DeflectTutorial>d__20");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr);
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, "<>1__state");
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, "<>2__current");
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, "<>4__this");
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, "<timer>5__2");
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, 100677148);
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, 100677149);
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, 100677150);
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, 100677151);
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, 100677152);
      CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr, 100677153);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _DeflectTutorial_d__20(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatDynamicTutorialsController._DeflectTutorial_d__20>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128356, XrefRangeEnd = 128364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128364, XrefRangeEnd = 128369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatDynamicTutorialsController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CombatDynamicTutorialsController) null : Il2CppObjectPool.Get<CombatDynamicTutorialsController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._DeflectTutorial_d__20.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CombatDynamicTutorialsController+<PickaxeTutorial>d__19")]
  public sealed class _PickaxeTutorial_d__19(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _PickaxeTutorial_d__19()
    {
      Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatDynamicTutorialsController>.NativeClassPtr, "<PickaxeTutorial>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr);
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, "<>1__state");
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, "<>2__current");
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, "<>4__this");
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, "<timer>5__2");
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, 100677154);
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, 100677155);
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, 100677156);
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, 100677157);
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, 100677158);
      CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr, 100677159);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _PickaxeTutorial_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatDynamicTutorialsController._PickaxeTutorial_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128369, XrefRangeEnd = 128377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128377, XrefRangeEnd = 128382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatDynamicTutorialsController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CombatDynamicTutorialsController) null : Il2CppObjectPool.Get<CombatDynamicTutorialsController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatDynamicTutorialsController._PickaxeTutorial_d__19.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }
}
