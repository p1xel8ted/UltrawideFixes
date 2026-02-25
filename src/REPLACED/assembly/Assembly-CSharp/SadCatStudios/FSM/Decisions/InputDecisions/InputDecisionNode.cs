// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.InputDecisions.InputDecisionNode
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

public class InputDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_delayInput;
  private static readonly IntPtr NativeFieldInfoPtr_cancelAxis;
  private static readonly IntPtr NativeFieldInfoPtr_resetThisButtonCache;
  private static readonly IntPtr NativeFieldInfoPtr_inputType;
  private static readonly IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly IntPtr NativeFieldInfoPtr_cacheResult;
  private static readonly IntPtr NativeMethodInfoPtr_get_DelayInput_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CancelAxis_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ResetThisButtonCache_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_InputType_Public_get_InputType_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CacheResult_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputDecisionNode()
  {
    Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.InputDecisions", nameof (InputDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr);
    InputDecisionNode.NativeFieldInfoPtr_delayInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, nameof (delayInput));
    InputDecisionNode.NativeFieldInfoPtr_cancelAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, nameof (cancelAxis));
    InputDecisionNode.NativeFieldInfoPtr_resetThisButtonCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, nameof (resetThisButtonCache));
    InputDecisionNode.NativeFieldInfoPtr_inputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, nameof (inputType));
    InputDecisionNode.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, nameof (inputAction));
    InputDecisionNode.NativeFieldInfoPtr_cacheResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, nameof (cacheResult));
    InputDecisionNode.NativeMethodInfoPtr_get_DelayInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673498);
    InputDecisionNode.NativeMethodInfoPtr_get_CancelAxis_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673499);
    InputDecisionNode.NativeMethodInfoPtr_get_ResetThisButtonCache_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673500);
    InputDecisionNode.NativeMethodInfoPtr_get_InputType_Public_get_InputType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673501);
    InputDecisionNode.NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673502);
    InputDecisionNode.NativeMethodInfoPtr_get_CacheResult_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673503);
    InputDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673504);
    InputDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr, 100673505);
  }

  public unsafe bool DelayInput
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr_get_DelayInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool CancelAxis
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr_get_CancelAxis_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ResetThisButtonCache
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr_get_ResetThisButtonCache_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe InputType InputType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr_get_InputType_Public_get_InputType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InputType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe InputAction InputAction
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InputAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool CacheResult
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr_get_CacheResult_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109817, XrefRangeEnd = 109821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool delayInput
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_delayInput));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_delayInput)) = value;
    }
  }

  public unsafe bool cancelAxis
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_cancelAxis));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_cancelAxis)) = value;
    }
  }

  public unsafe bool resetThisButtonCache
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_resetThisButtonCache));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_resetThisButtonCache)) = value;
    }
  }

  public unsafe InputType inputType
  {
    get
    {
      return *(InputType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_inputType));
    }
    [param: In] set
    {
      *(InputType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_inputType)) = value;
    }
  }

  public unsafe InputAction inputAction
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_inputAction));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_inputAction)) = value;
    }
  }

  public unsafe bool cacheResult
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_cacheResult));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputDecisionNode.NativeFieldInfoPtr_cacheResult)) = value;
    }
  }
}
