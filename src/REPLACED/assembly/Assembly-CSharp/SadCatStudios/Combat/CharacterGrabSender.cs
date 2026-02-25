// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterGrabSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterGrabSender(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_successGrabbingGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_missedGrabbingGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_pushedGrabbingGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_breakGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialLaunchGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_curve;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaCost;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_grabCaster;
  private static readonly System.IntPtr NativeFieldInfoPtr_connectedGrabReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_statsControllers;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_manaController;
  private static readonly System.IntPtr NativeFieldInfoPtr_attackObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialReceiver;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectGrab_Public_Virtual_Final_New_Void_GrabCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveConnection_Public_Virtual_Final_New_Void_GrabConnectionType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAttack_Public_Void_AttackData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendLaunch_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BreakGrab_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearConnection_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectSpecial_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CastSpecial_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessSpecial_Private_IEnumerator_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterGrabSender()
  {
    Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterGrabSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr);
    CharacterGrabSender.NativeFieldInfoPtr_successGrabbingGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (successGrabbingGraph));
    CharacterGrabSender.NativeFieldInfoPtr_missedGrabbingGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (missedGrabbingGraph));
    CharacterGrabSender.NativeFieldInfoPtr_pushedGrabbingGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (pushedGrabbingGraph));
    CharacterGrabSender.NativeFieldInfoPtr_breakGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (breakGraph));
    CharacterGrabSender.NativeFieldInfoPtr_specialRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (specialRadius));
    CharacterGrabSender.NativeFieldInfoPtr_specialMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (specialMask));
    CharacterGrabSender.NativeFieldInfoPtr_specialLaunchGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (specialLaunchGraph));
    CharacterGrabSender.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (curve));
    CharacterGrabSender.NativeFieldInfoPtr_manaCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (manaCost));
    CharacterGrabSender.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (stateController));
    CharacterGrabSender.NativeFieldInfoPtr_grabCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (grabCaster));
    CharacterGrabSender.NativeFieldInfoPtr_connectedGrabReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (connectedGrabReceiver));
    CharacterGrabSender.NativeFieldInfoPtr_statsControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (statsControllers));
    CharacterGrabSender.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (animationController));
    CharacterGrabSender.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (walkController));
    CharacterGrabSender.NativeFieldInfoPtr_manaController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (manaController));
    CharacterGrabSender.NativeFieldInfoPtr_attackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (attackObject));
    CharacterGrabSender.NativeFieldInfoPtr_specialReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, nameof (specialReceiver));
    CharacterGrabSender.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677314);
    CharacterGrabSender.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677315);
    CharacterGrabSender.NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677316);
    CharacterGrabSender.NativeMethodInfoPtr_ConnectGrab_Public_Virtual_Final_New_Void_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677317);
    CharacterGrabSender.NativeMethodInfoPtr_ResolveConnection_Public_Virtual_Final_New_Void_GrabConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677318);
    CharacterGrabSender.NativeMethodInfoPtr_SendAttack_Public_Void_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677319);
    CharacterGrabSender.NativeMethodInfoPtr_SendLaunch_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677320);
    CharacterGrabSender.NativeMethodInfoPtr_BreakGrab_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677321);
    CharacterGrabSender.NativeMethodInfoPtr_ClearConnection_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677322);
    CharacterGrabSender.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677323);
    CharacterGrabSender.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677324);
    CharacterGrabSender.NativeMethodInfoPtr_ConnectSpecial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677325);
    CharacterGrabSender.NativeMethodInfoPtr_CastSpecial_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677326);
    CharacterGrabSender.NativeMethodInfoPtr_ProcessSpecial_Private_IEnumerator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677327);
    CharacterGrabSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, 100677328);
  }

  public unsafe bool Connected
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 129423, RefRangeEnd = 129425, XrefRangeStart = 129423, XrefRangeEnd = 129423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_get_Connected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129425, XrefRangeEnd = 129447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CastGrab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129447, XrefRangeEnd = 129455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ConnectGrab(GrabCastResult grabCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) grabCastResult))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_ConnectGrab_Public_Virtual_Final_New_Void_GrabCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResolveConnection(GrabConnectionType connectionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &connectionType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_ResolveConnection_Public_Virtual_Final_New_Void_GrabConnectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129466, RefRangeEnd = 129467, XrefRangeStart = 129455, XrefRangeEnd = 129466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendAttack(AttackData attackData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_SendAttack_Public_Void_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129467, XrefRangeEnd = 129470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SendLaunch()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_SendLaunch_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129470, XrefRangeEnd = 129473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void BreakGrab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_BreakGrab_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ClearConnection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_ClearConnection_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 129423, RefRangeEnd = 129425, XrefRangeStart = 129423, XrefRangeEnd = 129425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessConnection(AttackObject attack, HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_ProcessConnection_Public_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129473, XrefRangeEnd = 129474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ConnectSpecial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_ConnectSpecial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129474, XrefRangeEnd = 129495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CastSpecial()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_CastSpecial_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129499, RefRangeEnd = 129500, XrefRangeStart = 129495, XrefRangeEnd = 129499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ProcessSpecial(Transform receiverTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiverTransform)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr_ProcessSpecial_Private_IEnumerator_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129500, XrefRangeEnd = 129501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterGrabSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FSMGraph successGrabbingGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_successGrabbingGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_successGrabbingGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph missedGrabbingGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_missedGrabbingGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_missedGrabbingGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph pushedGrabbingGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_pushedGrabbingGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_pushedGrabbingGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph breakGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_breakGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_breakGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float specialRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialRadius)) = value;
    }
  }

  public unsafe LayerMask specialMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialMask)) = value;
    }
  }

  public unsafe FSMGraph specialLaunchGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialLaunchGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialLaunchGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_curve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float manaCost
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_manaCost));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_manaCost)) = value;
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IGrabCaster grabCaster
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_grabCaster));
      return num == System.IntPtr.Zero ? (IGrabCaster) null : Il2CppObjectPool.Get<IGrabCaster>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_grabCaster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IGrabReceiver connectedGrabReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_connectedGrabReceiver));
      return num == System.IntPtr.Zero ? (IGrabReceiver) null : Il2CppObjectPool.Get<IGrabReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_connectedGrabReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ICombatStatsController> statsControllers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_statsControllers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ICombatStatsController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ICombatStatsController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_statsControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterManaController manaController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_manaController));
      return num == System.IntPtr.Zero ? (CharacterManaController) null : Il2CppObjectPool.Get<CharacterManaController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_manaController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject attackObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_attackObject));
      return num == System.IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_attackObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSpecialReceiver specialReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialReceiver));
      return num == System.IntPtr.Zero ? (CharacterSpecialReceiver) null : Il2CppObjectPool.Get<CharacterSpecialReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender.NativeFieldInfoPtr_specialReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterGrabSender+<ProcessSpecial>d__32")]
  public sealed class _ProcessSpecial_d__32(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_receiverTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr__duration_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__start_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__prev_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__6;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _ProcessSpecial_d__32()
    {
      Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterGrabSender>.NativeClassPtr, "<ProcessSpecial>d__32");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr);
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<>1__state");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<>2__current");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<>4__this");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr_receiverTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, nameof (receiverTransform));
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<duration>5__2");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__start_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<start>5__3");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__target_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<target>5__4");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__prev_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<prev>5__5");
      CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__timer_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, "<timer>5__6");
      CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, 100677329);
      CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, 100677330);
      CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, 100677331);
      CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, 100677332);
      CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, 100677333);
      CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr, 100677334);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ProcessSpecial_d__32(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabSender._ProcessSpecial_d__32>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129397, XrefRangeEnd = 129418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129418, XrefRangeEnd = 129423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabSender._ProcessSpecial_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterGrabSender __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterGrabSender) null : Il2CppObjectPool.Get<CharacterGrabSender>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform receiverTransform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr_receiverTransform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr_receiverTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _duration_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__duration_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__duration_5__2)) = value;
      }
    }

    public unsafe float _start_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__start_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__start_5__3)) = value;
      }
    }

    public unsafe float _target_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__target_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__target_5__4)) = value;
      }
    }

    public unsafe float _prev_5__5
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__prev_5__5));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__prev_5__5)) = value;
      }
    }

    public unsafe float _timer_5__6
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__timer_5__6));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabSender._ProcessSpecial_d__32.NativeFieldInfoPtr__timer_5__6)) = value;
      }
    }
  }
}
