// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.FSMGraphObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM;

public class FSMGraphObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_graph;
  private static readonly System.IntPtr NativeFieldInfoPtr_rootNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_currNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_nodesDict;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentNode_Public_get_StateObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Graph_Public_get_FSMGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_FSMGraph_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterState_Public_Void_StateNode_StateObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRegisteredState_Public_StateObject_StateNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessActions_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDecisions_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransitTo_Public_Void_StateObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransitTo_Public_Void_StateNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FSMGraphObject()
  {
    Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (FSMGraphObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr);
    FSMGraphObject.NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, nameof (graph));
    FSMGraphObject.NativeFieldInfoPtr_rootNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, nameof (rootNode));
    FSMGraphObject.NativeFieldInfoPtr_currNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, nameof (currNode));
    FSMGraphObject.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, nameof (stateController));
    FSMGraphObject.NativeFieldInfoPtr_nodesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, nameof (nodesDict));
    FSMGraphObject.NativeMethodInfoPtr_get_CurrentNode_Public_get_StateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673248);
    FSMGraphObject.NativeMethodInfoPtr_get_State_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673249);
    FSMGraphObject.NativeMethodInfoPtr_get_Graph_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673250);
    FSMGraphObject.NativeMethodInfoPtr_Init_Public_Void_FSMGraph_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673251);
    FSMGraphObject.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673252);
    FSMGraphObject.NativeMethodInfoPtr_RegisterState_Public_Void_StateNode_StateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673253);
    FSMGraphObject.NativeMethodInfoPtr_GetRegisteredState_Public_StateObject_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673254);
    FSMGraphObject.NativeMethodInfoPtr_ProcessActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673255);
    FSMGraphObject.NativeMethodInfoPtr_ProcessDecisions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673256);
    FSMGraphObject.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673257);
    FSMGraphObject.NativeMethodInfoPtr_TransitTo_Public_Void_StateObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673258);
    FSMGraphObject.NativeMethodInfoPtr_TransitTo_Public_Void_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673259);
    FSMGraphObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr, 100673260);
  }

  public unsafe StateObject CurrentNode
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_get_CurrentNode_Public_get_StateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (StateObject) null : Il2CppObjectPool.Get<StateObject>(num3);
    }
  }

  public unsafe State State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_get_State_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (State) null : Il2CppObjectPool.Get<State>(num3);
    }
  }

  public unsafe FSMGraph Graph
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_get_Graph_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 109068, RefRangeEnd = 109069, XrefRangeStart = 109030, XrefRangeEnd = 109068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(FSMGraph graphPrototype, StateController controller)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphPrototype);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) controller);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_Init_Public_Void_FSMGraph_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109069, XrefRangeEnd = 109071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109071, XrefRangeEnd = 109077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterState(StateNode node, StateObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_RegisterState_Public_Void_StateNode_StateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109077, XrefRangeEnd = 109081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StateObject GetRegisteredState(StateNode node)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_GetRegisteredState_Public_StateObject_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (StateObject) null : Il2CppObjectPool.Get<StateObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109081, XrefRangeEnd = 109083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessActions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_ProcessActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109083, XrefRangeEnd = 109085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessDecisions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_ProcessDecisions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109085, XrefRangeEnd = 109087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109087, XrefRangeEnd = 109092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransitTo(StateObject stateObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_TransitTo_Public_Void_StateObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109092, XrefRangeEnd = 109100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransitTo(StateNode stateNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateNode)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr_TransitTo_Public_Void_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 109107, RefRangeEnd = 109111, XrefRangeStart = 109100, XrefRangeEnd = 109107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FSMGraphObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSMGraphObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraphObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FSMGraph graph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_graph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_graph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateObject rootNode
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_rootNode));
      return num == System.IntPtr.Zero ? (StateObject) null : Il2CppObjectPool.Get<StateObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_rootNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateObject currNode
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_currNode));
      return num == System.IntPtr.Zero ? (StateObject) null : Il2CppObjectPool.Get<StateObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_currNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<StateNode, StateObject> nodesDict
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_nodesDict));
      return num == System.IntPtr.Zero ? (Dictionary<StateNode, StateObject>) null : Il2CppObjectPool.Get<Dictionary<StateNode, StateObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraphObject.NativeFieldInfoPtr_nodesDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
