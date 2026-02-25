// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.VelocityDecisions.HorizontalDistanceDecision
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Decisions.VelocityDecisions;

public class HorizontalDistanceDecision(IntPtr pointer) : ForkDecisionObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_distanceNode;
  private static readonly IntPtr NativeFieldInfoPtr_transform;
  private static readonly IntPtr NativeFieldInfoPtr_prevPos;
  private static readonly IntPtr NativeFieldInfoPtr_currDist;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0;

  static HorizontalDistanceDecision()
  {
    Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.VelocityDecisions", nameof (HorizontalDistanceDecision));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr);
    HorizontalDistanceDecision.NativeFieldInfoPtr_distanceNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, nameof (distanceNode));
    HorizontalDistanceDecision.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, nameof (transform));
    HorizontalDistanceDecision.NativeFieldInfoPtr_prevPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, nameof (prevPos));
    HorizontalDistanceDecision.NativeFieldInfoPtr_currDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, nameof (currDist));
    HorizontalDistanceDecision.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, 100673346);
    HorizontalDistanceDecision.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, 100673347);
    HorizontalDistanceDecision.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, 100673348);
    HorizontalDistanceDecision.NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr, 100673349);
  }

  [CallerCount(173)]
  [CachedScanResults(RefRangeStart = 108560, RefRangeEnd = 108733, XrefRangeStart = 108560, XrefRangeEnd = 108733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HorizontalDistanceDecision(
    IFSMNode prototype,
    FSMGraphObject graphObject,
    StateController stateController)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalDistanceDecision>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prototype);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HorizontalDistanceDecision.NativeMethodInfoPtr__ctor_Public_Void_IFSMNode_FSMGraphObject_StateController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109489, XrefRangeEnd = 109493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HorizontalDistanceDecision.NativeMethodInfoPtr_Init_Public_Virtual_Void_IFSMNode_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109493, XrefRangeEnd = 109494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HorizontalDistanceDecision.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109494, XrefRangeEnd = 109496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Reason()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HorizontalDistanceDecision.NativeMethodInfoPtr_Reason_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe HorizontalDistanceDecisionNode distanceNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_distanceNode));
      return num == IntPtr.Zero ? (HorizontalDistanceDecisionNode) null : Il2CppObjectPool.Get<HorizontalDistanceDecisionNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_distanceNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform transform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_transform));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float prevPos
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_prevPos));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_prevPos)) = value;
    }
  }

  public unsafe float currDist
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_currDist));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecision.NativeFieldInfoPtr_currDist)) = value;
    }
  }
}
