// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.JumpActions.FullAerialControlJumpActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.JumpActions;

public class FullAerialControlJumpActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_minJumpHeight;
  private static readonly IntPtr NativeFieldInfoPtr_maxJumpHeight;
  private static readonly IntPtr NativeFieldInfoPtr_minJumpDistance;
  private static readonly IntPtr NativeFieldInfoPtr_jumpSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_jumpFriction;
  private static readonly IntPtr NativeFieldInfoPtr_jumpAcceleration;
  private static readonly IntPtr NativeFieldInfoPtr_totalDuration;
  private static readonly IntPtr NativeMethodInfoPtr_get_MinJumpHeight_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxJumpHeight_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MinJumpDistance_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpSpeed_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TotalDuration_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpFriction_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpAcceleration_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FullAerialControlJumpActionNode()
  {
    Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.JumpActions", nameof (FullAerialControlJumpActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr);
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_minJumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (minJumpHeight));
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_maxJumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (maxJumpHeight));
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_minJumpDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (minJumpDistance));
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpSpeed));
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpFriction));
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpAcceleration));
    FullAerialControlJumpActionNode.NativeFieldInfoPtr_totalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, nameof (totalDuration));
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_MinJumpHeight_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673942);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_MaxJumpHeight_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673943);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_MinJumpDistance_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673944);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpSpeed_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673945);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_TotalDuration_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673946);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpFriction_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673947);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpAcceleration_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673948);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673949);
    FullAerialControlJumpActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr, 100673950);
  }

  public unsafe FloatReference MinJumpHeight
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_MinJumpHeight_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference MaxJumpHeight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_MaxJumpHeight_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference MinJumpDistance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_MinJumpDistance_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference JumpSpeed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpSpeed_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference TotalDuration
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_TotalDuration_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference JumpFriction
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpFriction_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference JumpAcceleration
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpAcceleration_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110924, XrefRangeEnd = 110928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullAerialControlJumpActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FullAerialControlJumpActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullAerialControlJumpActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FullAerialControlJumpActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference minJumpHeight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_minJumpHeight));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_minJumpHeight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference maxJumpHeight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_maxJumpHeight));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_maxJumpHeight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference minJumpDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_minJumpDistance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_minJumpDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpSpeed
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpSpeed));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpFriction
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpFriction));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpFriction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpAcceleration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpAcceleration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_jumpAcceleration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference totalDuration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_totalDuration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJumpActionNode.NativeFieldInfoPtr_totalDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
