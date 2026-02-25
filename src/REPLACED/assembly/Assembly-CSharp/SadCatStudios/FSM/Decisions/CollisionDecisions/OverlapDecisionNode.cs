// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.CollisionDecisions.OverlapDecisionNode
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
namespace SadCatStudios.FSM.Decisions.CollisionDecisions;

public class OverlapDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_centerOffset;
  private static readonly IntPtr NativeFieldInfoPtr_overlapSize;
  private static readonly IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly IntPtr NativeFieldInfoPtr_excludeTag;
  private static readonly IntPtr NativeFieldInfoPtr_tag;
  private static readonly IntPtr NativeFieldInfoPtr_cacheOverlap;
  private static readonly IntPtr NativeFieldInfoPtr_debug;
  private static readonly IntPtr NativeFieldInfoPtr_alsoCheckLedges;
  private static readonly IntPtr NativeFieldInfoPtr_ledgeCheckDistance;
  private static readonly IntPtr NativeMethodInfoPtr_get_CenterOffset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_OverlapSize_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CacheOverlap_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ExclideTag_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AlsoCheckLedges_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LedgeCheckDistance_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OverlapDecisionNode()
  {
    Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.CollisionDecisions", nameof (OverlapDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr);
    OverlapDecisionNode.NativeFieldInfoPtr_centerOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (centerOffset));
    OverlapDecisionNode.NativeFieldInfoPtr_overlapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (overlapSize));
    OverlapDecisionNode.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (layerMask));
    OverlapDecisionNode.NativeFieldInfoPtr_excludeTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (excludeTag));
    OverlapDecisionNode.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (tag));
    OverlapDecisionNode.NativeFieldInfoPtr_cacheOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (cacheOverlap));
    OverlapDecisionNode.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (debug));
    OverlapDecisionNode.NativeFieldInfoPtr_alsoCheckLedges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (alsoCheckLedges));
    OverlapDecisionNode.NativeFieldInfoPtr_ledgeCheckDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, nameof (ledgeCheckDistance));
    OverlapDecisionNode.NativeMethodInfoPtr_get_CenterOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673700);
    OverlapDecisionNode.NativeMethodInfoPtr_get_OverlapSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673701);
    OverlapDecisionNode.NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673702);
    OverlapDecisionNode.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673703);
    OverlapDecisionNode.NativeMethodInfoPtr_get_CacheOverlap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673704);
    OverlapDecisionNode.NativeMethodInfoPtr_get_ExclideTag_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673705);
    OverlapDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673706);
    OverlapDecisionNode.NativeMethodInfoPtr_get_AlsoCheckLedges_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673707);
    OverlapDecisionNode.NativeMethodInfoPtr_get_LedgeCheckDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673708);
    OverlapDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673709);
    OverlapDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr, 100673710);
  }

  public unsafe Vector3 CenterOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_CenterOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 OverlapSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_OverlapSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe LayerMask LayerMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_LayerMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string Tag
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_Tag_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe bool CacheOverlap
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_CacheOverlap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ExclideTag
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_ExclideTag_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_Debug_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool AlsoCheckLedges
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_AlsoCheckLedges_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float LedgeCheckDistance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr_get_LedgeCheckDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110254, XrefRangeEnd = 110258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OverlapDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110258, XrefRangeEnd = 110259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OverlapDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverlapDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OverlapDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 centerOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_centerOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_centerOffset)) = value;
    }
  }

  public unsafe Vector3 overlapSize
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_overlapSize));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_overlapSize)) = value;
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe bool excludeTag
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_excludeTag));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_excludeTag)) = value;
    }
  }

  public unsafe string tag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_tag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool cacheOverlap
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_cacheOverlap));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_cacheOverlap)) = value;
    }
  }

  public unsafe bool debug
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_debug));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_debug)) = value;
    }
  }

  public unsafe bool alsoCheckLedges
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_alsoCheckLedges));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_alsoCheckLedges)) = value;
    }
  }

  public unsafe float ledgeCheckDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_ledgeCheckDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OverlapDecisionNode.NativeFieldInfoPtr_ledgeCheckDistance)) = value;
    }
  }
}
