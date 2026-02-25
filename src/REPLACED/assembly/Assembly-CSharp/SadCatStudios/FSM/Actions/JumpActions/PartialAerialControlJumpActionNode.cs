// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.JumpActions.PartialAerialControlJumpActionNode
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

public class PartialAerialControlJumpActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_jumpHeight;
  private static readonly IntPtr NativeFieldInfoPtr_jumpDistance;
  private static readonly IntPtr NativeFieldInfoPtr_jumpAcceleration;
  private static readonly IntPtr NativeFieldInfoPtr_jumpFriction;
  private static readonly IntPtr NativeFieldInfoPtr_apexTime;
  private static readonly IntPtr NativeFieldInfoPtr_totalDuration;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpHeight_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpDistance_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpAcceleration_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpFriction_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ApexTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PartialAerialControlJumpActionNode()
  {
    Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.JumpActions", nameof (PartialAerialControlJumpActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr);
    PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpHeight));
    PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpDistance));
    PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpAcceleration));
    PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpFriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, nameof (jumpFriction));
    PartialAerialControlJumpActionNode.NativeFieldInfoPtr_apexTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, nameof (apexTime));
    PartialAerialControlJumpActionNode.NativeFieldInfoPtr_totalDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, nameof (totalDuration));
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpHeight_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673971);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpDistance_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673972);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpAcceleration_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673973);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpFriction_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673974);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673975);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_ApexTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673976);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673977);
    PartialAerialControlJumpActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr, 100673978);
  }

  public unsafe FloatReference JumpHeight
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpHeight_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference JumpDistance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpDistance_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference JumpAcceleration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpAcceleration_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference JumpFriction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_JumpFriction_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe float TotalDuration
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 111065, RefRangeEnd = 111066, XrefRangeStart = 111064, XrefRangeEnd = 111065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float ApexTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr_get_ApexTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111066, XrefRangeEnd = 111070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PartialAerialControlJumpActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PartialAerialControlJumpActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartialAerialControlJumpActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PartialAerialControlJumpActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference jumpHeight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpHeight));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpHeight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpDistance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpAcceleration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpAcceleration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpAcceleration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference jumpFriction
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpFriction));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_jumpFriction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float apexTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_apexTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_apexTime)) = value;
    }
  }

  public unsafe FloatReference totalDuration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_totalDuration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PartialAerialControlJumpActionNode.NativeFieldInfoPtr_totalDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
