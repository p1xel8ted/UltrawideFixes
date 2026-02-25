// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.AI.TargetDistanceDecisionNode
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
namespace SadCatStudios.FSM.Decisions.AI;

public class TargetDistanceDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_comparison;
  private static readonly IntPtr NativeFieldInfoPtr_distanceThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_inFront;
  private static readonly IntPtr NativeMethodInfoPtr_get_Comparison_Public_get_LessGreater_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DistanceThreshold_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_InFront_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TargetDistanceDecisionNode()
  {
    Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.AI", nameof (TargetDistanceDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr);
    TargetDistanceDecisionNode.NativeFieldInfoPtr_comparison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, nameof (comparison));
    TargetDistanceDecisionNode.NativeFieldInfoPtr_distanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, nameof (distanceThreshold));
    TargetDistanceDecisionNode.NativeFieldInfoPtr_inFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, nameof (inFront));
    TargetDistanceDecisionNode.NativeMethodInfoPtr_get_Comparison_Public_get_LessGreater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, 100673843);
    TargetDistanceDecisionNode.NativeMethodInfoPtr_get_DistanceThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, 100673844);
    TargetDistanceDecisionNode.NativeMethodInfoPtr_get_InFront_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, 100673845);
    TargetDistanceDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, 100673846);
    TargetDistanceDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr, 100673847);
  }

  public unsafe TargetDistanceDecisionNode.LessGreater Comparison
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetDistanceDecisionNode.NativeMethodInfoPtr_get_Comparison_Public_get_LessGreater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TargetDistanceDecisionNode.LessGreater*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float DistanceThreshold
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110617, XrefRangeEnd = 110619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetDistanceDecisionNode.NativeMethodInfoPtr_get_DistanceThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool InFront
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetDistanceDecisionNode.NativeMethodInfoPtr_get_InFront_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110619, XrefRangeEnd = 110623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetDistanceDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110623, XrefRangeEnd = 110624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TargetDistanceDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetDistanceDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TargetDistanceDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TargetDistanceDecisionNode.LessGreater comparison
  {
    get
    {
      return *(TargetDistanceDecisionNode.LessGreater*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetDistanceDecisionNode.NativeFieldInfoPtr_comparison));
    }
    [param: In] set
    {
      *(TargetDistanceDecisionNode.LessGreater*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetDistanceDecisionNode.NativeFieldInfoPtr_comparison)) = value;
    }
  }

  public unsafe FloatReference distanceThreshold
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetDistanceDecisionNode.NativeFieldInfoPtr_distanceThreshold));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetDistanceDecisionNode.NativeFieldInfoPtr_distanceThreshold), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool inFront
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetDistanceDecisionNode.NativeFieldInfoPtr_inFront));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetDistanceDecisionNode.NativeFieldInfoPtr_inFront)) = value;
    }
  }

  public enum LessGreater
  {
    Less,
    Greater,
  }
}
