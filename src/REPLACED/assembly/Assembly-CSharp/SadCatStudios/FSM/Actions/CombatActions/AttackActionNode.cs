// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.CombatActions.AttackActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.Combat;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.CombatActions;

public class AttackActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_attackData;
  private static readonly IntPtr NativeFieldInfoPtr_trailClip;
  private static readonly IntPtr NativeFieldInfoPtr_stopVibrationOnExit;
  private static readonly IntPtr NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TrailClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_StopVibrationOnExit_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttackActionNode()
  {
    Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.CombatActions", nameof (AttackActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr);
    AttackActionNode.NativeFieldInfoPtr_attackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, nameof (attackData));
    AttackActionNode.NativeFieldInfoPtr_trailClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, nameof (trailClip));
    AttackActionNode.NativeFieldInfoPtr_stopVibrationOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, nameof (stopVibrationOnExit));
    AttackActionNode.NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, 100674164);
    AttackActionNode.NativeMethodInfoPtr_get_TrailClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, 100674165);
    AttackActionNode.NativeMethodInfoPtr_get_StopVibrationOnExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, 100674166);
    AttackActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, 100674167);
    AttackActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr, 100674168);
  }

  public unsafe AttackData AttackData
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackActionNode.NativeMethodInfoPtr_get_AttackData_Public_get_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num3);
    }
  }

  public unsafe MeshClip TrailClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackActionNode.NativeMethodInfoPtr_get_TrailClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe bool StopVibrationOnExit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackActionNode.NativeMethodInfoPtr_get_StopVibrationOnExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111512, XrefRangeEnd = 111516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AttackActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 111108, RefRangeEnd = 111111, XrefRangeStart = 111108, XrefRangeEnd = 111111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AttackData attackData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackActionNode.NativeFieldInfoPtr_attackData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackActionNode.NativeFieldInfoPtr_attackData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip trailClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackActionNode.NativeFieldInfoPtr_trailClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackActionNode.NativeFieldInfoPtr_trailClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool stopVibrationOnExit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackActionNode.NativeFieldInfoPtr_stopVibrationOnExit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackActionNode.NativeFieldInfoPtr_stopVibrationOnExit)) = value;
    }
  }
}
