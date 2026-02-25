// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.CombatActions.WeaponLayerClipActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.CombatActions;

public class WeaponLayerClipActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_keepOnExit;
  private static readonly IntPtr NativeMethodInfoPtr_get_KeepOnExit_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static WeaponLayerClipActionNode()
  {
    Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.CombatActions", nameof (WeaponLayerClipActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr);
    WeaponLayerClipActionNode.NativeFieldInfoPtr_keepOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr, nameof (keepOnExit));
    WeaponLayerClipActionNode.NativeMethodInfoPtr_get_KeepOnExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr, 100674341);
    WeaponLayerClipActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr, 100674342);
    WeaponLayerClipActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr, 100674343);
  }

  public unsafe bool KeepOnExit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WeaponLayerClipActionNode.NativeMethodInfoPtr_get_KeepOnExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111857, XrefRangeEnd = 111861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WeaponLayerClipActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 111108, RefRangeEnd = 111111, XrefRangeStart = 111108, XrefRangeEnd = 111111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WeaponLayerClipActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeaponLayerClipActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WeaponLayerClipActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool keepOnExit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeaponLayerClipActionNode.NativeFieldInfoPtr_keepOnExit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WeaponLayerClipActionNode.NativeFieldInfoPtr_keepOnExit)) = value;
    }
  }
}
