// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.ForkDecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class ForkDecisionNode(IntPtr pointer) : DecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_failState;
  private static readonly IntPtr NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static ForkDecisionNode()
  {
    Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (ForkDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr);
    ForkDecisionNode.NativeFieldInfoPtr_failState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr, nameof (failState));
    ForkDecisionNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr, 100673234);
    ForkDecisionNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr, 100673235);
    ForkDecisionNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr, 100673236);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108930, XrefRangeEnd = 108940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateConnection(NodePort from, NodePort to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ForkDecisionNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108940, XrefRangeEnd = 108950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnRemoveConnection(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ForkDecisionNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ForkDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ForkDecisionNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Node failState
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ForkDecisionNode.NativeFieldInfoPtr_failState));
      return num == IntPtr.Zero ? (Node) null : Il2CppObjectPool.Get<Node>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ForkDecisionNode.NativeFieldInfoPtr_failState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
