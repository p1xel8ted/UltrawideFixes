// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.CollisionDecisions.SingleRayDecisionNode
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

public class SingleRayDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_rayLength;
  private static readonly IntPtr NativeFieldInfoPtr_rayOrigin;
  private static readonly IntPtr NativeFieldInfoPtr_rayOrientation;
  private static readonly IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_yOffset;
  private static readonly IntPtr NativeFieldInfoPtr_zOffset;
  private static readonly IntPtr NativeFieldInfoPtr_shouldHit;
  private static readonly IntPtr NativeFieldInfoPtr_checkOverlap;
  private static readonly IntPtr NativeFieldInfoPtr_cacheResult;
  private static readonly IntPtr NativeFieldInfoPtr_debug;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayOrigin_Public_get_RayOrigin_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayOrientation_Public_get_RayOrientation_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_XOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_YOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ZOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ShouldHit_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CheckOverlap_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CacheResult_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SingleRayDecisionNode()
  {
    Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.CollisionDecisions", nameof (SingleRayDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr);
    SingleRayDecisionNode.NativeFieldInfoPtr_rayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (rayLength));
    SingleRayDecisionNode.NativeFieldInfoPtr_rayOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (rayOrigin));
    SingleRayDecisionNode.NativeFieldInfoPtr_rayOrientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (rayOrientation));
    SingleRayDecisionNode.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (layerMask));
    SingleRayDecisionNode.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (offset));
    SingleRayDecisionNode.NativeFieldInfoPtr_yOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (yOffset));
    SingleRayDecisionNode.NativeFieldInfoPtr_zOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (zOffset));
    SingleRayDecisionNode.NativeFieldInfoPtr_shouldHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (shouldHit));
    SingleRayDecisionNode.NativeFieldInfoPtr_checkOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (checkOverlap));
    SingleRayDecisionNode.NativeFieldInfoPtr_cacheResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (cacheResult));
    SingleRayDecisionNode.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, nameof (debug));
    SingleRayDecisionNode.NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673732);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_RayOrigin_Public_get_RayOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673733);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_RayOrientation_Public_get_RayOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673734);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673735);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_XOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673736);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_YOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673737);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_ZOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673738);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_ShouldHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673739);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_CheckOverlap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673740);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_CacheResult_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673741);
    SingleRayDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673742);
    SingleRayDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673743);
    SingleRayDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr, 100673744);
  }

  public unsafe FloatReference RayLength
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe RayOrigin RayOrigin
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_RayOrigin_Public_get_RayOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RayOrigin*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe RayOrientation RayOrientation
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_RayOrientation_Public_get_RayOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RayOrientation*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe LayerMask LayerMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FloatReference XOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_XOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference YOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_YOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference ZOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_ZOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe bool ShouldHit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_ShouldHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_CheckOverlap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool CacheResult
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_CacheResult_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110346, XrefRangeEnd = 110350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SingleRayDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110350, XrefRangeEnd = 110351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SingleRayDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleRayDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SingleRayDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference rayLength
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_rayLength));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_rayLength), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RayOrigin rayOrigin
  {
    get
    {
      return *(RayOrigin*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_rayOrigin));
    }
    [param: In] set
    {
      *(RayOrigin*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_rayOrigin)) = value;
    }
  }

  public unsafe RayOrientation rayOrientation
  {
    get
    {
      return *(RayOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_rayOrientation));
    }
    [param: In] set
    {
      *(RayOrientation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_rayOrientation)) = value;
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe FloatReference offset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_offset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_offset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference yOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_yOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_yOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference zOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_zOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_zOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool shouldHit
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_shouldHit));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_shouldHit)) = value;
    }
  }

  public unsafe bool checkOverlap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_checkOverlap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_checkOverlap)) = value;
    }
  }

  public unsafe bool cacheResult
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_cacheResult));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_cacheResult)) = value;
    }
  }

  public unsafe bool debug
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_debug));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SingleRayDecisionNode.NativeFieldInfoPtr_debug)) = value;
    }
  }
}
