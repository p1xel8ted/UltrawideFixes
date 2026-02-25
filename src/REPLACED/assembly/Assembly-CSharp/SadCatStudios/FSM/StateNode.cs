// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.StateNode
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
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class StateNode(System.IntPtr pointer) : XNode.Node(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_enter;
  private static readonly System.IntPtr NativeFieldInfoPtr_action;
  private static readonly System.IntPtr NativeFieldInfoPtr_decision;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_actions;
  private static readonly System.IntPtr NativeFieldInfoPtr_decisions;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Actions_Public_get_List_1_ActionNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Decisions_Public_get_List_1_DecisionNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_Final_New_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StateNode()
  {
    Il2CppClassPointerStore<StateNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (StateNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateNode>.NativeClassPtr);
    StateNode.NativeFieldInfoPtr_enter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateNode>.NativeClassPtr, nameof (enter));
    StateNode.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateNode>.NativeClassPtr, nameof (action));
    StateNode.NativeFieldInfoPtr_decision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateNode>.NativeClassPtr, nameof (decision));
    StateNode.NativeFieldInfoPtr_meshClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateNode>.NativeClassPtr, nameof (meshClip));
    StateNode.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateNode>.NativeClassPtr, nameof (actions));
    StateNode.NativeFieldInfoPtr_decisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateNode>.NativeClassPtr, nameof (decisions));
    StateNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673268);
    StateNode.NativeMethodInfoPtr_get_Actions_Public_get_List_1_ActionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673269);
    StateNode.NativeMethodInfoPtr_get_Decisions_Public_get_List_1_DecisionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673270);
    StateNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673271);
    StateNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673272);
    StateNode.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673273);
    StateNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Final_New_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673274);
    StateNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateNode>.NativeClassPtr, 100673275);
  }

  public unsafe MeshClip MeshClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe List<ActionNode> Actions
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateNode.NativeMethodInfoPtr_get_Actions_Public_get_List_1_ActionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ActionNode>) null : Il2CppObjectPool.Get<List<ActionNode>>(num3);
    }
  }

  public unsafe List<DecisionNode> Decisions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateNode.NativeMethodInfoPtr_get_Decisions_Public_get_List_1_DecisionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<DecisionNode>) null : Il2CppObjectPool.Get<List<DecisionNode>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109111, XrefRangeEnd = 109123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateConnection(NodePort from, NodePort to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StateNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109123, XrefRangeEnd = 109150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnRemoveConnection(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StateNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object GetValue(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StateNode.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109150, XrefRangeEnd = 109173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_Final_New_IFSMObject_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109173, XrefRangeEnd = 109186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StateNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Empty enter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_enter));
      return num == System.IntPtr.Zero ? (Empty) null : Il2CppObjectPool.Get<Empty>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_enter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Empty action
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_action));
      return num == System.IntPtr.Zero ? (Empty) null : Il2CppObjectPool.Get<Empty>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Empty decision
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_decision));
      return num == System.IntPtr.Zero ? (Empty) null : Il2CppObjectPool.Get<Empty>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_decision), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip meshClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_meshClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_meshClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ActionNode> actions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_actions));
      return num == System.IntPtr.Zero ? (List<ActionNode>) null : Il2CppObjectPool.Get<List<ActionNode>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<DecisionNode> decisions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_decisions));
      return num == System.IntPtr.Zero ? (List<DecisionNode>) null : Il2CppObjectPool.Get<List<DecisionNode>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateNode.NativeFieldInfoPtr_decisions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
