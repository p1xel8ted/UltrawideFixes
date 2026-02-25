// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.StateObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Animation;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM;

public class StateObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_stateNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_controller;
  private static readonly System.IntPtr NativeFieldInfoPtr_actions;
  private static readonly System.IntPtr NativeFieldInfoPtr_decisions;
  private static readonly System.IntPtr NativeFieldInfoPtr_process;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StateNode_Public_get_StateNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StateNode_Public_set_Void_StateNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnter_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Enter_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayClip_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopClip_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessActions_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDecisions_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StateObject()
  {
    Il2CppClassPointerStore<StateObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (StateObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateObject>.NativeClassPtr);
    StateObject.NativeFieldInfoPtr_stateNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateObject>.NativeClassPtr, nameof (stateNode));
    StateObject.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateObject>.NativeClassPtr, nameof (controller));
    StateObject.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateObject>.NativeClassPtr, nameof (actions));
    StateObject.NativeFieldInfoPtr_decisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateObject>.NativeClassPtr, nameof (decisions));
    StateObject.NativeFieldInfoPtr_process = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateObject>.NativeClassPtr, nameof (process));
    StateObject.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673276);
    StateObject.NativeMethodInfoPtr_get_StateNode_Public_get_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673277);
    StateObject.NativeMethodInfoPtr_set_StateNode_Public_set_Void_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673278);
    StateObject.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673279);
    StateObject.NativeMethodInfoPtr_OnEnter_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673280 /*0x06002700*/);
    StateObject.NativeMethodInfoPtr_Enter_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673281);
    StateObject.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673282);
    StateObject.NativeMethodInfoPtr_PlayClip_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673283);
    StateObject.NativeMethodInfoPtr_StopClip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673284);
    StateObject.NativeMethodInfoPtr_ProcessActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673285);
    StateObject.NativeMethodInfoPtr_ProcessDecisions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673286);
    StateObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateObject>.NativeClassPtr, 100673287);
  }

  public unsafe MeshClip MeshClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe StateNode StateNode
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_get_StateNode_Public_get_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (StateNode) null : Il2CppObjectPool.Get<StateNode>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_set_StateNode_Public_set_Void_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 109233, RefRangeEnd = 109235, XrefRangeStart = 109186, XrefRangeEnd = 109233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Init(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109235, XrefRangeEnd = 109240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_OnEnter_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 109276, RefRangeEnd = 109286, XrefRangeStart = 109240, XrefRangeEnd = 109276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enter(bool continueClip = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &continueClip
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_Enter_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 109300, RefRangeEnd = 109313, XrefRangeStart = 109286, XrefRangeEnd = 109300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Exit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109313, XrefRangeEnd = 109320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayClip(bool continueClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &continueClip
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_PlayClip_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109320, XrefRangeEnd = 109322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_StopClip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 109336, RefRangeEnd = 109339, XrefRangeStart = 109322, XrefRangeEnd = 109336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessActions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_ProcessActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 109353, RefRangeEnd = 109356, XrefRangeStart = 109339, XrefRangeEnd = 109353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessDecisions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr_ProcessDecisions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109356, XrefRangeEnd = 109369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StateObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateNode stateNode
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_stateNode));
      return num == System.IntPtr.Zero ? (StateNode) null : Il2CppObjectPool.Get<StateNode>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_stateNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController controller
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_controller));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ActionObject> actions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_actions));
      return num == System.IntPtr.Zero ? (List<ActionObject>) null : Il2CppObjectPool.Get<List<ActionObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<DecisionObject> decisions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_decisions));
      return num == System.IntPtr.Zero ? (List<DecisionObject>) null : Il2CppObjectPool.Get<List<DecisionObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_decisions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool process
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_process));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateObject.NativeFieldInfoPtr_process)) = value;
    }
  }
}
