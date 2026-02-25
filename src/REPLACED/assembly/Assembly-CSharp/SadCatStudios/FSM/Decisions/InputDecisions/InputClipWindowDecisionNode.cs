// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.InputDecisions.InputClipWindowDecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.PlayerInput;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Decisions.InputDecisions;

public class InputClipWindowDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly IntPtr NativeFieldInfoPtr_meshClip;
  private static readonly IntPtr NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputClipWindowDecisionNode()
  {
    Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.InputDecisions", nameof (InputClipWindowDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr);
    InputClipWindowDecisionNode.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, nameof (inputAction));
    InputClipWindowDecisionNode.NativeFieldInfoPtr_meshClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, nameof (meshClip));
    InputClipWindowDecisionNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, 100673489);
    InputClipWindowDecisionNode.NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, 100673490);
    InputClipWindowDecisionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, 100673491);
    InputClipWindowDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, 100673492);
    InputClipWindowDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr, 100673493);
  }

  public unsafe MeshClip MeshClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputClipWindowDecisionNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe InputAction InputAction
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputClipWindowDecisionNode.NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InputAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109789, XrefRangeEnd = 109800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputClipWindowDecisionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109800, XrefRangeEnd = 109804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputClipWindowDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputClipWindowDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputClipWindowDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputClipWindowDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InputAction inputAction
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputClipWindowDecisionNode.NativeFieldInfoPtr_inputAction));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputClipWindowDecisionNode.NativeFieldInfoPtr_inputAction)) = value;
    }
  }

  public unsafe MeshClip meshClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputClipWindowDecisionNode.NativeFieldInfoPtr_meshClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputClipWindowDecisionNode.NativeFieldInfoPtr_meshClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
