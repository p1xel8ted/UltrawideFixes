// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.ClimbingDecision.ClimbingEdgeDecisionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Decisions.ClimbingDecision;

public class ClimbingEdgeDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_edgeType;
  private static readonly IntPtr NativeFieldInfoPtr_extraSteps;
  private static readonly IntPtr NativeMethodInfoPtr_get_EdgeType_Public_get_EdgeType_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ExtraSteps_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ClimbingEdgeDecisionNode()
  {
    Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.ClimbingDecision", nameof (ClimbingEdgeDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr);
    ClimbingEdgeDecisionNode.NativeFieldInfoPtr_edgeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr, nameof (edgeType));
    ClimbingEdgeDecisionNode.NativeFieldInfoPtr_extraSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr, nameof (extraSteps));
    ClimbingEdgeDecisionNode.NativeMethodInfoPtr_get_EdgeType_Public_get_EdgeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr, 100673768);
    ClimbingEdgeDecisionNode.NativeMethodInfoPtr_get_ExtraSteps_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr, 100673769);
    ClimbingEdgeDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr, 100673770);
    ClimbingEdgeDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr, 100673771);
  }

  public unsafe EdgeType EdgeType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingEdgeDecisionNode.NativeMethodInfoPtr_get_EdgeType_Public_get_EdgeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EdgeType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int ExtraSteps
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClimbingEdgeDecisionNode.NativeMethodInfoPtr_get_ExtraSteps_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110452, XrefRangeEnd = 110456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClimbingEdgeDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClimbingEdgeDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClimbingEdgeDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClimbingEdgeDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EdgeType edgeType
  {
    get
    {
      return *(EdgeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingEdgeDecisionNode.NativeFieldInfoPtr_edgeType));
    }
    [param: In] set
    {
      *(EdgeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingEdgeDecisionNode.NativeFieldInfoPtr_edgeType)) = value;
    }
  }

  public unsafe int extraSteps
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingEdgeDecisionNode.NativeFieldInfoPtr_extraSteps));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClimbingEdgeDecisionNode.NativeFieldInfoPtr_extraSteps)) = value;
    }
  }
}
