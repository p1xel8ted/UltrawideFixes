// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.LedgeDecisions.VaultDecisionNode
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
namespace SadCatStudios.FSM.Decisions.LedgeDecisions;

public class VaultDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_originHeight;
  private static readonly IntPtr NativeFieldInfoPtr_rayLength;
  private static readonly IntPtr NativeFieldInfoPtr_ledgeMask;
  private static readonly IntPtr NativeFieldInfoPtr_pivotOffset;
  private static readonly IntPtr NativeFieldInfoPtr_landingOffset;
  private static readonly IntPtr NativeFieldInfoPtr_debug;
  private static readonly IntPtr NativeMethodInfoPtr_get_OriginHeight_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LedgeMask_Public_get_LayerMask_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PivotOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LandingOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VaultDecisionNode()
  {
    Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.LedgeDecisions", nameof (VaultDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr);
    VaultDecisionNode.NativeFieldInfoPtr_originHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, nameof (originHeight));
    VaultDecisionNode.NativeFieldInfoPtr_rayLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, nameof (rayLength));
    VaultDecisionNode.NativeFieldInfoPtr_ledgeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, nameof (ledgeMask));
    VaultDecisionNode.NativeFieldInfoPtr_pivotOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, nameof (pivotOffset));
    VaultDecisionNode.NativeFieldInfoPtr_landingOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, nameof (landingOffset));
    VaultDecisionNode.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, nameof (debug));
    VaultDecisionNode.NativeMethodInfoPtr_get_OriginHeight_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673460);
    VaultDecisionNode.NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673461);
    VaultDecisionNode.NativeMethodInfoPtr_get_LedgeMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673462);
    VaultDecisionNode.NativeMethodInfoPtr_get_PivotOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673463);
    VaultDecisionNode.NativeMethodInfoPtr_get_LandingOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673464);
    VaultDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673465);
    VaultDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673466);
    VaultDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr, 100673467);
  }

  public unsafe FloatReference OriginHeight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr_get_OriginHeight_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference RayLength
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr_get_RayLength_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe LayerMask LedgeMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr_get_LedgeMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FloatReference PivotOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr_get_PivotOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference LandingOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr_get_LandingOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe bool Debug
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109722, XrefRangeEnd = 109726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VaultDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109726, XrefRangeEnd = 109727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VaultDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VaultDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VaultDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference originHeight
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_originHeight));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_originHeight), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference rayLength
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_rayLength));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_rayLength), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask ledgeMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_ledgeMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_ledgeMask)) = value;
    }
  }

  public unsafe FloatReference pivotOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_pivotOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_pivotOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference landingOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_landingOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_landingOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool debug
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_debug));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VaultDecisionNode.NativeFieldInfoPtr_debug)) = value;
    }
  }
}
