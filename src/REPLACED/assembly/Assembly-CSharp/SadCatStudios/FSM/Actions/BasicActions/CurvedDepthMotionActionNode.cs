// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.CurvedDepthMotionActionNode
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

public class CurvedDepthMotionActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_curve;
  private static readonly IntPtr NativeFieldInfoPtr_distance;
  private static readonly IntPtr NativeFieldInfoPtr_frameState;
  private static readonly IntPtr NativeFieldInfoPtr_meshClip;
  private static readonly IntPtr NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CurvedDepthMotionActionNode()
  {
    Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions", nameof (CurvedDepthMotionActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr);
    CurvedDepthMotionActionNode.NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, nameof (curve));
    CurvedDepthMotionActionNode.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, nameof (distance));
    CurvedDepthMotionActionNode.NativeFieldInfoPtr_frameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, nameof (frameState));
    CurvedDepthMotionActionNode.NativeFieldInfoPtr_meshClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, nameof (meshClip));
    CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674422);
    CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674423);
    CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674424);
    CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674425);
    CurvedDepthMotionActionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674426);
    CurvedDepthMotionActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674427);
    CurvedDepthMotionActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr, 100674428);
  }

  public unsafe AnimationCurve Curve
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_Curve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_FrameState_Public_get_FrameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrameState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MeshClip MeshClip
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedDepthMotionActionNode.NativeMethodInfoPtr_get_MeshClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112019, XrefRangeEnd = 112030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedDepthMotionActionNode.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112030, XrefRangeEnd = 112034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedDepthMotionActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 111108, RefRangeEnd = 111111, XrefRangeStart = 111108, XrefRangeEnd = 111111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedDepthMotionActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedDepthMotionActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CurvedDepthMotionActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve curve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_curve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference distance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_distance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_distance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FrameState frameState
  {
    get
    {
      return *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_frameState));
    }
    [param: In] set
    {
      *(FrameState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_frameState)) = value;
    }
  }

  public unsafe MeshClip meshClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_meshClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedDepthMotionActionNode.NativeFieldInfoPtr_meshClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
