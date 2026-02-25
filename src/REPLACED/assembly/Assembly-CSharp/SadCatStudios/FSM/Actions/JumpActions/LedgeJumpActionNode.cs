// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.JumpActions.LedgeJumpActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Actions.JumpActions;

public class LedgeJumpActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_frameState;
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_perpendicularCurve;
  private static readonly IntPtr NativeFieldInfoPtr_startOffset;
  private static readonly IntPtr NativeFieldInfoPtr_perpendicularDirection;
  private static readonly IntPtr NativeFieldInfoPtr_lerpToTop;
  private static readonly IntPtr NativeFieldInfoPtr_lastHit;
  private static readonly IntPtr NativeFieldInfoPtr_meshClip;
  private static readonly IntPtr NativeMethodInfoPtr_get_JumpClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PerpendicularCurve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_StartOffset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PerpendicularDirection_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LerpToTop_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastHit_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LedgeJumpActionNode()
  {
    Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.JumpActions", nameof (LedgeJumpActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr);
    LedgeJumpActionNode.NativeFieldInfoPtr_frameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (frameState));
    LedgeJumpActionNode.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (curve));
    LedgeJumpActionNode.NativeFieldInfoPtr_perpendicularCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (perpendicularCurve));
    LedgeJumpActionNode.NativeFieldInfoPtr_startOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (startOffset));
    LedgeJumpActionNode.NativeFieldInfoPtr_perpendicularDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (perpendicularDirection));
    LedgeJumpActionNode.NativeFieldInfoPtr_lerpToTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (lerpToTop));
    LedgeJumpActionNode.NativeFieldInfoPtr_lastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (lastHit));
    LedgeJumpActionNode.NativeFieldInfoPtr_meshClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, nameof (meshClip));
    LedgeJumpActionNode.NativeMethodInfoPtr_get_JumpClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673955);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673956);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_PerpendicularCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673957);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_StartOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673958);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_PerpendicularDirection_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673959);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_LerpToTop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673960);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_LastHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673961);
    LedgeJumpActionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673962);
    LedgeJumpActionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673963);
    LedgeJumpActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673964);
    LedgeJumpActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr, 100673965);
  }

  public unsafe MeshClip JumpClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_JumpClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe AnimationCurve Curve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe AnimationCurve PerpendicularCurve
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_PerpendicularCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe Vector3 StartOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 110977, RefRangeEnd = 110978, XrefRangeStart = 110977, XrefRangeEnd = 110977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_StartOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 PerpendicularDirection
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_PerpendicularDirection_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool LerpToTop
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_LerpToTop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool LastHit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_LastHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FrameState FrameState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrameState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110978, XrefRangeEnd = 110989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LedgeJumpActionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110989, XrefRangeEnd = 110993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LedgeJumpActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110993, XrefRangeEnd = 110996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LedgeJumpActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LedgeJumpActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LedgeJumpActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FrameState frameState
  {
    get
    {
      return *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_frameState));
    }
    [param: In] set
    {
      *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_frameState)) = value;
    }
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_curve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve perpendicularCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_perpendicularCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_perpendicularCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 startOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_startOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_startOffset)) = value;
    }
  }

  public unsafe Vector3 perpendicularDirection
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_perpendicularDirection));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_perpendicularDirection)) = value;
    }
  }

  public unsafe bool lerpToTop
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_lerpToTop));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_lerpToTop)) = value;
    }
  }

  public unsafe bool lastHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_lastHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_lastHit)) = value;
    }
  }

  public unsafe MeshClip meshClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_meshClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LedgeJumpActionNode.NativeFieldInfoPtr_meshClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
