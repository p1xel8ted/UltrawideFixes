// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.DecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class DecisionNode(System.IntPtr pointer) : Node(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_currState;
  private static readonly System.IntPtr NativeFieldInfoPtr_nextState;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Abstract_Virtual_New_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static DecisionNode()
  {
    Il2CppClassPointerStore<DecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (DecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr);
    DecisionNode.NativeFieldInfoPtr_currState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, nameof (currState));
    DecisionNode.NativeFieldInfoPtr_nextState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, nameof (nextState));
    DecisionNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, 100673223);
    DecisionNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, 100673224);
    DecisionNode.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, 100673225);
    DecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Abstract_Virtual_New_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, 100673226);
    DecisionNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr, 100673227);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108884, XrefRangeEnd = 108890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateConnection(NodePort from, NodePort to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DecisionNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108890, XrefRangeEnd = 108896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnRemoveConnection(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DecisionNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108896, XrefRangeEnd = 108897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object GetValue(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DecisionNode.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Abstract_Virtual_New_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecisionNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecisionNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateNode currState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecisionNode.NativeFieldInfoPtr_currState));
      return num == System.IntPtr.Zero ? (StateNode) null : Il2CppObjectPool.Get<StateNode>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecisionNode.NativeFieldInfoPtr_currState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Node nextState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecisionNode.NativeFieldInfoPtr_nextState));
      return num == System.IntPtr.Zero ? (Node) null : Il2CppObjectPool.Get<Node>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecisionNode.NativeFieldInfoPtr_nextState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
