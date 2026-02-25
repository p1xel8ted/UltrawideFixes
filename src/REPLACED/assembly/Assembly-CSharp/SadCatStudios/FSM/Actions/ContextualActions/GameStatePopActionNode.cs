// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.ContextualActions.GameStatePopActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.ContextualActions;

public class GameStatePopActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_expectedState;
  private static readonly IntPtr NativeFieldInfoPtr_onExit;
  private static readonly IntPtr NativeMethodInfoPtr_get_ExpectedState_Public_get_GameState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_OnExit_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GameStatePopActionNode()
  {
    Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.ContextualActions", nameof (GameStatePopActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr);
    GameStatePopActionNode.NativeFieldInfoPtr_expectedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr, nameof (expectedState));
    GameStatePopActionNode.NativeFieldInfoPtr_onExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr, nameof (onExit));
    GameStatePopActionNode.NativeMethodInfoPtr_get_ExpectedState_Public_get_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr, 100674043);
    GameStatePopActionNode.NativeMethodInfoPtr_get_OnExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr, 100674044);
    GameStatePopActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr, 100674045);
    GameStatePopActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr, 100674046);
  }

  public unsafe GameStateManager.GameState ExpectedState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameStatePopActionNode.NativeMethodInfoPtr_get_ExpectedState_Public_get_GameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GameStateManager.GameState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool OnExit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameStatePopActionNode.NativeMethodInfoPtr_get_OnExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111214, XrefRangeEnd = 111218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameStatePopActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 111108, RefRangeEnd = 111111, XrefRangeStart = 111108, XrefRangeEnd = 111111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameStatePopActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStatePopActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameStatePopActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameStateManager.GameState expectedState
  {
    get
    {
      return *(GameStateManager.GameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatePopActionNode.NativeFieldInfoPtr_expectedState));
    }
    [param: In] set
    {
      *(GameStateManager.GameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatePopActionNode.NativeFieldInfoPtr_expectedState)) = value;
    }
  }

  public unsafe bool onExit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatePopActionNode.NativeFieldInfoPtr_onExit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameStatePopActionNode.NativeFieldInfoPtr_onExit)) = value;
    }
  }
}
