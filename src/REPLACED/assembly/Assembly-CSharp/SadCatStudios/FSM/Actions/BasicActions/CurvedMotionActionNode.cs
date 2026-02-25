// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.CurvedMotionActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Actions.BasicActions;

public class CurvedMotionActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_distance;
  private static readonly IntPtr NativeFieldInfoPtr_frameState;
  private static readonly IntPtr NativeFieldInfoPtr_safetyMeasures;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreSlowdown;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreGravity;
  private static readonly IntPtr NativeFieldInfoPtr_ignoreDepth;
  private static readonly IntPtr NativeFieldInfoPtr_stopVelocityAfter;
  private static readonly IntPtr NativeFieldInfoPtr_pushOut;
  private static readonly IntPtr NativeFieldInfoPtr_push;
  private static readonly IntPtr NativeFieldInfoPtr_meshClip;
  private static readonly IntPtr NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SafetyMeasures_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreSlowdown_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreGravity_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreDepth_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_StopVelocityAfter_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PushOut_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Push_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CurvedMotionActionNode()
  {
    Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions", nameof (CurvedMotionActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr);
    CurvedMotionActionNode.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (curve));
    CurvedMotionActionNode.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (distance));
    CurvedMotionActionNode.NativeFieldInfoPtr_frameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (frameState));
    CurvedMotionActionNode.NativeFieldInfoPtr_safetyMeasures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (safetyMeasures));
    CurvedMotionActionNode.NativeFieldInfoPtr_ignoreSlowdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (ignoreSlowdown));
    CurvedMotionActionNode.NativeFieldInfoPtr_ignoreGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (ignoreGravity));
    CurvedMotionActionNode.NativeFieldInfoPtr_ignoreDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (ignoreDepth));
    CurvedMotionActionNode.NativeFieldInfoPtr_stopVelocityAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (stopVelocityAfter));
    CurvedMotionActionNode.NativeFieldInfoPtr_pushOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (pushOut));
    CurvedMotionActionNode.NativeFieldInfoPtr_push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (push));
    CurvedMotionActionNode.NativeFieldInfoPtr_meshClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, nameof (meshClip));
    CurvedMotionActionNode.NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674434);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674435);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674436);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674437);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_SafetyMeasures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674438);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_IgnoreSlowdown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674439);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_IgnoreGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674440);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_IgnoreDepth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674441);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_StopVelocityAfter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674442);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_PushOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674443);
    CurvedMotionActionNode.NativeMethodInfoPtr_get_Push_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674444);
    CurvedMotionActionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674445);
    CurvedMotionActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674446);
    CurvedMotionActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr, 100674447);
  }

  public unsafe AnimationCurve Curve
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
  }

  public unsafe FloatReference Distance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FrameState FrameState
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrameState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MeshClip MeshClip
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe bool SafetyMeasures
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_SafetyMeasures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IgnoreSlowdown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_IgnoreSlowdown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IgnoreGravity
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_IgnoreGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IgnoreDepth
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_IgnoreDepth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool StopVelocityAfter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_StopVelocityAfter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool PushOut
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_PushOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Push
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr_get_Push_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112054, XrefRangeEnd = 112065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedMotionActionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112065, XrefRangeEnd = 112069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedMotionActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112069, XrefRangeEnd = 112070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedMotionActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedMotionActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CurvedMotionActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_curve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference distance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_distance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_distance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FrameState frameState
  {
    get
    {
      return *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_frameState));
    }
    [param: In] set
    {
      *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_frameState)) = value;
    }
  }

  public unsafe bool safetyMeasures
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_safetyMeasures));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_safetyMeasures)) = value;
    }
  }

  public unsafe bool ignoreSlowdown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_ignoreSlowdown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_ignoreSlowdown)) = value;
    }
  }

  public unsafe bool ignoreGravity
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_ignoreGravity));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_ignoreGravity)) = value;
    }
  }

  public unsafe bool ignoreDepth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_ignoreDepth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_ignoreDepth)) = value;
    }
  }

  public unsafe bool stopVelocityAfter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_stopVelocityAfter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_stopVelocityAfter)) = value;
    }
  }

  public unsafe bool pushOut
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_pushOut));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_pushOut)) = value;
    }
  }

  public unsafe bool push
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_push));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_push)) = value;
    }
  }

  public unsafe MeshClip meshClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_meshClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionActionNode.NativeFieldInfoPtr_meshClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
