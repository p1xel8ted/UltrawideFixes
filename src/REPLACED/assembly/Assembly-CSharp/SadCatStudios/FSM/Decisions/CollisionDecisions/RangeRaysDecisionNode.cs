// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.CollisionDecisions.RangeRaysDecisionNode
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
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Decisions.CollisionDecisions;

public class RangeRaysDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_rayLength;
  private static readonly IntPtr NativeFieldInfoPtr_rayCount;
  private static readonly IntPtr NativeFieldInfoPtr_raySpacing;
  private static readonly IntPtr NativeFieldInfoPtr_rangeDirection;
  private static readonly IntPtr NativeFieldInfoPtr_rayOrientation;
  private static readonly IntPtr NativeFieldInfoPtr_rayOrigin;
  private static readonly IntPtr NativeFieldInfoPtr_xOffset;
  private static readonly IntPtr NativeFieldInfoPtr_yOffset;
  private static readonly IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly IntPtr NativeFieldInfoPtr_shouldHit;
  private static readonly IntPtr NativeFieldInfoPtr_checkOverlap;
  private static readonly IntPtr NativeFieldInfoPtr_debug;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayCount_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RaySpacing_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RangeDirection_Public_get_RayOrientation_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayOrientation_Public_get_RayOrientation_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayOrigin_Public_get_RayOrigin_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_XOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_YOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ShouldHit_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CheckOverlap_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RangeRaysDecisionNode()
  {
    Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.CollisionDecisions", nameof (RangeRaysDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr);
    RangeRaysDecisionNode.NativeFieldInfoPtr_rayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (rayLength));
    RangeRaysDecisionNode.NativeFieldInfoPtr_rayCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (rayCount));
    RangeRaysDecisionNode.NativeFieldInfoPtr_raySpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (raySpacing));
    RangeRaysDecisionNode.NativeFieldInfoPtr_rangeDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (rangeDirection));
    RangeRaysDecisionNode.NativeFieldInfoPtr_rayOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (rayOrientation));
    RangeRaysDecisionNode.NativeFieldInfoPtr_rayOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (rayOrigin));
    RangeRaysDecisionNode.NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (xOffset));
    RangeRaysDecisionNode.NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (yOffset));
    RangeRaysDecisionNode.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (layerMask));
    RangeRaysDecisionNode.NativeFieldInfoPtr_shouldHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (shouldHit));
    RangeRaysDecisionNode.NativeFieldInfoPtr_checkOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (checkOverlap));
    RangeRaysDecisionNode.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, nameof (debug));
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673714);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayCount_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673715);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_RaySpacing_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673716);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_RangeDirection_Public_get_RayOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673717);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayOrientation_Public_get_RayOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673718);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayOrigin_Public_get_RayOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673719);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_XOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673720);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_YOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673721);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673722);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_ShouldHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673723);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_CheckOverlap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673724);
    RangeRaysDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673725);
    RangeRaysDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673726);
    RangeRaysDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr, 100673727);
  }

  public unsafe FloatReference RayLength
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference RayCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayCount_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference RaySpacing
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_RaySpacing_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe RayOrientation RangeDirection
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_RangeDirection_Public_get_RayOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RayOrientation*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe RayOrientation RayOrientation
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayOrientation_Public_get_RayOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RayOrientation*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe RayOrigin RayOrigin
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_RayOrigin_Public_get_RayOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RayOrigin*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FloatReference XOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_XOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference YOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_YOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe LayerMask LayerMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ShouldHit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_ShouldHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool CheckOverlap
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_CheckOverlap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Debug
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110274, XrefRangeEnd = 110278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RangeRaysDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110278, XrefRangeEnd = 110280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RangeRaysDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeRaysDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RangeRaysDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference rayLength
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayLength));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayLength), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference rayCount
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayCount));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayCount), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference raySpacing
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_raySpacing));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_raySpacing), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RayOrientation rangeDirection
  {
    get
    {
      return *(RayOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rangeDirection));
    }
    [param: In] set
    {
      *(RayOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rangeDirection)) = value;
    }
  }

  public unsafe RayOrientation rayOrientation
  {
    get
    {
      return *(RayOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayOrientation));
    }
    [param: In] set
    {
      *(RayOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayOrientation)) = value;
    }
  }

  public unsafe RayOrigin rayOrigin
  {
    get
    {
      return *(RayOrigin*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayOrigin));
    }
    [param: In] set
    {
      *(RayOrigin*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_rayOrigin)) = value;
    }
  }

  public unsafe FloatReference xOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_xOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_xOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference yOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_yOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_yOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe bool shouldHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_shouldHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_shouldHit)) = value;
    }
  }

  public unsafe bool checkOverlap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_checkOverlap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_checkOverlap)) = value;
    }
  }

  public unsafe bool debug
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_debug));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeRaysDecisionNode.NativeFieldInfoPtr_debug)) = value;
    }
  }
}
