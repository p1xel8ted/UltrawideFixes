// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.AnimationDecisions.NextFrameRangeDecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Decisions.AnimationDecisions;

public class NextFrameRangeDecisionNode(IntPtr pointer) : DecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_frameState;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NextFrameRangeDecisionNode()
  {
    Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.AnimationDecisions", nameof (NextFrameRangeDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr);
    NextFrameRangeDecisionNode.NativeFieldInfoPtr_frameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr, nameof (frameState));
    NextFrameRangeDecisionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr, 100673824);
    NextFrameRangeDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr, 100673825);
    NextFrameRangeDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr, 100673826);
  }

  public unsafe FrameState FrameState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NextFrameRangeDecisionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrameState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110584, XrefRangeEnd = 110588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), NextFrameRangeDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110588, XrefRangeEnd = 110589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NextFrameRangeDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextFrameRangeDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NextFrameRangeDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FrameState frameState
  {
    get
    {
      return *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NextFrameRangeDecisionNode.NativeFieldInfoPtr_frameState));
    }
    [param: In] set
    {
      *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NextFrameRangeDecisionNode.NativeFieldInfoPtr_frameState)) = value;
    }
  }
}
