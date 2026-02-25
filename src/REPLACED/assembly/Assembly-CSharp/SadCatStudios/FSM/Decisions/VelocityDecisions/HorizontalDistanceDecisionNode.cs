// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Decisions.VelocityDecisions.HorizontalDistanceDecisionNode
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
namespace SadCatStudios.FSM.Decisions.VelocityDecisions;

public class HorizontalDistanceDecisionNode(IntPtr pointer) : ForkDecisionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_distance;
  private static readonly IntPtr NativeFieldInfoPtr_maxDistance;
  private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxDistance_Public_get_FloatReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static HorizontalDistanceDecisionNode()
  {
    Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Decisions.VelocityDecisions", nameof (HorizontalDistanceDecisionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr);
    HorizontalDistanceDecisionNode.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr, nameof (distance));
    HorizontalDistanceDecisionNode.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr, nameof (maxDistance));
    HorizontalDistanceDecisionNode.NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr, 100673342);
    HorizontalDistanceDecisionNode.NativeMethodInfoPtr_get_MaxDistance_Public_get_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr, 100673343);
    HorizontalDistanceDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr, 100673344);
    HorizontalDistanceDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr, 100673345);
  }

  public unsafe FloatReference Distance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HorizontalDistanceDecisionNode.NativeMethodInfoPtr_get_Distance_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  public unsafe FloatReference MaxDistance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HorizontalDistanceDecisionNode.NativeMethodInfoPtr_get_MaxDistance_Public_get_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109485, XrefRangeEnd = 109489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HorizontalDistanceDecisionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HorizontalDistanceDecisionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalDistanceDecisionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HorizontalDistanceDecisionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference distance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecisionNode.NativeFieldInfoPtr_distance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecisionNode.NativeFieldInfoPtr_distance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference maxDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecisionNode.NativeFieldInfoPtr_maxDistance));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HorizontalDistanceDecisionNode.NativeFieldInfoPtr_maxDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
