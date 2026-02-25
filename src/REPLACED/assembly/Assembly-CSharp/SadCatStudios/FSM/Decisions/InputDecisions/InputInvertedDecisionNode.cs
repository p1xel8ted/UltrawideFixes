// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.InputDecisions.InputInvertedDecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.PlayerInput;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Decisions.InputDecisions;

public class InputInvertedDecisionNode(IntPtr pointer) : DecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_axis;
  private static readonly IntPtr NativeMethodInfoPtr_get_Axis_Public_get_InputAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputInvertedDecisionNode()
  {
    Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.InputDecisions", nameof (InputInvertedDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr);
    InputInvertedDecisionNode.NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr, nameof (axis));
    InputInvertedDecisionNode.NativeMethodInfoPtr_get_Axis_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr, 100673513);
    InputInvertedDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr, 100673514);
    InputInvertedDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr, 100673515);
  }

  public unsafe InputAction Axis
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputInvertedDecisionNode.NativeMethodInfoPtr_get_Axis_Public_get_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InputAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109890, XrefRangeEnd = 109894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputInvertedDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputInvertedDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputInvertedDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputInvertedDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InputAction axis
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputInvertedDecisionNode.NativeFieldInfoPtr_axis));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputInvertedDecisionNode.NativeFieldInfoPtr_axis)) = value;
    }
  }
}
