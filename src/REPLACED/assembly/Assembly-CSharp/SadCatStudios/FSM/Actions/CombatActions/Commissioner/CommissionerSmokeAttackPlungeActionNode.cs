// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.CombatActions.Commissioner.CommissionerSmokeAttackPlungeActionNode
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
namespace SadCatStudios.FSM.Actions.CombatActions.Commissioner;

public class CommissionerSmokeAttackPlungeActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_spawnHeigth;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpawnHeigth_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CommissionerSmokeAttackPlungeActionNode()
  {
    Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.CombatActions.Commissioner", nameof (CommissionerSmokeAttackPlungeActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr);
    CommissionerSmokeAttackPlungeActionNode.NativeFieldInfoPtr_spawnHeigth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr, nameof (spawnHeigth));
    CommissionerSmokeAttackPlungeActionNode.NativeMethodInfoPtr_get_SpawnHeigth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr, 100674368);
    CommissionerSmokeAttackPlungeActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr, 100674369);
    CommissionerSmokeAttackPlungeActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr, 100674370);
  }

  public unsafe float SpawnHeigth
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CommissionerSmokeAttackPlungeActionNode.NativeMethodInfoPtr_get_SpawnHeigth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111897, XrefRangeEnd = 111901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CommissionerSmokeAttackPlungeActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111901, XrefRangeEnd = 111902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CommissionerSmokeAttackPlungeActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommissionerSmokeAttackPlungeActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommissionerSmokeAttackPlungeActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float spawnHeigth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommissionerSmokeAttackPlungeActionNode.NativeFieldInfoPtr_spawnHeigth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommissionerSmokeAttackPlungeActionNode.NativeFieldInfoPtr_spawnHeigth)) = value;
    }
  }
}
