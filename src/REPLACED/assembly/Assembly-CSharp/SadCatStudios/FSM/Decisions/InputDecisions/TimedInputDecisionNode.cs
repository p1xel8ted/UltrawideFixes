// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.InputDecisions.TimedInputDecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.PlayerInput;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM.Decisions.InputDecisions;

public class TimedInputDecisionNode(IntPtr pointer) : DecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_inputWindowTime;
  private static readonly IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly IntPtr NativeFieldInfoPtr_sector;
  private static readonly IntPtr NativeFieldInfoPtr_needsBackRay;
  private static readonly IntPtr NativeFieldInfoPtr_backRayHorizontalOffset;
  private static readonly IntPtr NativeFieldInfoPtr_backRayVerticalOffset;
  private static readonly IntPtr NativeFieldInfoPtr_backRayMask;
  private static readonly IntPtr NativeFieldInfoPtr_debugRay;
  private static readonly IntPtr NativeMethodInfoPtr_get_InputWindowTime_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BackRayHorizontalOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BackRayVerticalOffset_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Sector_Public_get_Sector_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BackRayMask_Public_get_LayerMask_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DebugRay_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_NeedsBackRay_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TimedInputDecisionNode()
  {
    Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.InputDecisions", nameof (TimedInputDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr);
    TimedInputDecisionNode.NativeFieldInfoPtr_inputWindowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (inputWindowTime));
    TimedInputDecisionNode.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (inputAction));
    TimedInputDecisionNode.NativeFieldInfoPtr_sector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (sector));
    TimedInputDecisionNode.NativeFieldInfoPtr_needsBackRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (needsBackRay));
    TimedInputDecisionNode.NativeFieldInfoPtr_backRayHorizontalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (backRayHorizontalOffset));
    TimedInputDecisionNode.NativeFieldInfoPtr_backRayVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (backRayVerticalOffset));
    TimedInputDecisionNode.NativeFieldInfoPtr_backRayMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (backRayMask));
    TimedInputDecisionNode.NativeFieldInfoPtr_debugRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, nameof (debugRay));
    TimedInputDecisionNode.NativeMethodInfoPtr_get_InputWindowTime_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673520);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_BackRayHorizontalOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673521);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_BackRayVerticalOffset_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673522);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673523);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_Sector_Public_get_Sector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673524);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_BackRayMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673525);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_DebugRay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673526);
    TimedInputDecisionNode.NativeMethodInfoPtr_get_NeedsBackRay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673527);
    TimedInputDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673528);
    TimedInputDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr, 100673529);
  }

  public unsafe FloatReference InputWindowTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_InputWindowTime_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference BackRayHorizontalOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_BackRayHorizontalOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference BackRayVerticalOffset
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_BackRayVerticalOffset_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe InputAction InputAction
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_InputAction_Public_get_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InputAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Sector Sector
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_Sector_Public_get_Sector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Sector*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe LayerMask BackRayMask
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_BackRayMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool DebugRay
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_DebugRay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool NeedsBackRay
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr_get_NeedsBackRay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109901, XrefRangeEnd = 109905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TimedInputDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TimedInputDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimedInputDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimedInputDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference inputWindowTime
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_inputWindowTime));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_inputWindowTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputAction inputAction
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_inputAction));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_inputAction)) = value;
    }
  }

  public unsafe Sector sector
  {
    get
    {
      return *(Sector*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_sector));
    }
    [param: In] set
    {
      *(Sector*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_sector)) = value;
    }
  }

  public unsafe bool needsBackRay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_needsBackRay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_needsBackRay)) = value;
    }
  }

  public unsafe FloatReference backRayHorizontalOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_backRayHorizontalOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_backRayHorizontalOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference backRayVerticalOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_backRayVerticalOffset));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_backRayVerticalOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask backRayMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_backRayMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_backRayMask)) = value;
    }
  }

  public unsafe bool debugRay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_debugRay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimedInputDecisionNode.NativeFieldInfoPtr_debugRay)) = value;
    }
  }
}
