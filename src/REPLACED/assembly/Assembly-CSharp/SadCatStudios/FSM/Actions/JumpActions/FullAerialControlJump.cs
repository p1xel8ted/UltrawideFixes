// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.JumpActions.FullAerialControlJump
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.JumpActions;

public class FullAerialControlJump(IntPtr pointer) : ActionObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_jumpNode;
  private static readonly IntPtr NativeFieldInfoPtr_walkController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_grabController;
  private static readonly IntPtr NativeFieldInfoPtr_totalDuration;
  private static readonly IntPtr NativeFieldInfoPtr_originHorizontalPos;
  private static readonly IntPtr NativeFieldInfoPtr_minJumpVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_maxJumpVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_currJumpVelocity;
  private static readonly IntPtr NativeFieldInfoPtr_gravity;
  private static readonly IntPtr NativeFieldInfoPtr_fallStart;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Act_Public_Virtual_Void_0;

  static FullAerialControlJump()
  {
    Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.JumpActions", nameof (FullAerialControlJump));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr);
    FullAerialControlJump.NativeFieldInfoPtr_jumpNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (jumpNode));
    FullAerialControlJump.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (walkController));
    FullAerialControlJump.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (rotationController));
    FullAerialControlJump.NativeFieldInfoPtr_grabController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (grabController));
    FullAerialControlJump.NativeFieldInfoPtr_totalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (totalDuration));
    FullAerialControlJump.NativeFieldInfoPtr_originHorizontalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (originHorizontalPos));
    FullAerialControlJump.NativeFieldInfoPtr_minJumpVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (minJumpVelocity));
    FullAerialControlJump.NativeFieldInfoPtr_maxJumpVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (maxJumpVelocity));
    FullAerialControlJump.NativeFieldInfoPtr_currJumpVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (currJumpVelocity));
    FullAerialControlJump.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (gravity));
    FullAerialControlJump.NativeFieldInfoPtr_fallStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, nameof (fallStart));
    FullAerialControlJump.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, 100673951);
    FullAerialControlJump.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, 100673952);
    FullAerialControlJump.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, 100673953);
    FullAerialControlJump.NativeMethodInfoPtr_Act_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr, 100673954);
  }

  [CallerCount(173)]
  [CachedScanResults(RefRangeStart = 108560, RefRangeEnd = 108733, XrefRangeStart = 108560, XrefRangeEnd = 108733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FullAerialControlJump(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullAerialControlJump>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FullAerialControlJump.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110928, XrefRangeEnd = 110942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullAerialControlJump.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110942, XrefRangeEnd = 110951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullAerialControlJump.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110951, XrefRangeEnd = 110977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Act()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullAerialControlJump.NativeMethodInfoPtr_Act_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FullAerialControlJumpActionNode jumpNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_jumpNode));
      return num == IntPtr.Zero ? (FullAerialControlJumpActionNode) null : Il2CppObjectPool.Get<FullAerialControlJumpActionNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_jumpNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_walkController));
      return num == IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterGrabController grabController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_grabController));
      return num == IntPtr.Zero ? (CharacterGrabController) null : Il2CppObjectPool.Get<CharacterGrabController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_grabController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float totalDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_totalDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_totalDuration)) = value;
    }
  }

  public unsafe float originHorizontalPos
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_originHorizontalPos));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_originHorizontalPos)) = value;
    }
  }

  public unsafe float minJumpVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_minJumpVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_minJumpVelocity)) = value;
    }
  }

  public unsafe float maxJumpVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_maxJumpVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_maxJumpVelocity)) = value;
    }
  }

  public unsafe float currJumpVelocity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_currJumpVelocity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_currJumpVelocity)) = value;
    }
  }

  public unsafe float gravity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_gravity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_gravity)) = value;
    }
  }

  public unsafe bool fallStart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_fallStart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullAerialControlJump.NativeFieldInfoPtr_fallStart)) = value;
    }
  }
}
