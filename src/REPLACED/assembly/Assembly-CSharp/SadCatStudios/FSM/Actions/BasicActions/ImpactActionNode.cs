// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.ImpactActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Effects;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM.Actions.BasicActions;

public class ImpactActionNode(IntPtr pointer) : ActionNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_enterImpactEvents;
  private static readonly IntPtr NativeFieldInfoPtr_exitImpactEvents;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnterImpactEvents_Public_get_List_1_ImpactEvent_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ExitImpactEvents_Public_get_List_1_ImpactEvent_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ImpactActionNode()
  {
    Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions", nameof (ImpactActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr);
    ImpactActionNode.NativeFieldInfoPtr_enterImpactEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr, nameof (enterImpactEvents));
    ImpactActionNode.NativeFieldInfoPtr_exitImpactEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr, nameof (exitImpactEvents));
    ImpactActionNode.NativeMethodInfoPtr_get_EnterImpactEvents_Public_get_List_1_ImpactEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr, 100674496);
    ImpactActionNode.NativeMethodInfoPtr_get_ExitImpactEvents_Public_get_List_1_ImpactEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr, 100674497);
    ImpactActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr, 100674498);
    ImpactActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr, 100674499);
  }

  public unsafe List<ImpactEvent> EnterImpactEvents
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactActionNode.NativeMethodInfoPtr_get_EnterImpactEvents_Public_get_List_1_ImpactEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num3);
    }
  }

  public unsafe List<ImpactEvent> ExitImpactEvents
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactActionNode.NativeMethodInfoPtr_get_ExitImpactEvents_Public_get_List_1_ImpactEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112217, XrefRangeEnd = 112221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IFSMObject CreateInstance(
    FSMGraphObject graphObject,
    StateController stateController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graphObject);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateController);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactActionNode.NativeMethodInfoPtr_CreateInstance_Public_Virtual_IFSMObject_FSMGraphObject_StateController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IFSMObject) null : Il2CppObjectPool.Get<IFSMObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112221, XrefRangeEnd = 112232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImpactActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<ImpactEvent> enterImpactEvents
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactActionNode.NativeFieldInfoPtr_enterImpactEvents));
      return num == IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactActionNode.NativeFieldInfoPtr_enterImpactEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ImpactEvent> exitImpactEvents
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactActionNode.NativeFieldInfoPtr_exitImpactEvents));
      return num == IntPtr.Zero ? (List<ImpactEvent>) null : Il2CppObjectPool.Get<List<ImpactEvent>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactActionNode.NativeFieldInfoPtr_exitImpactEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
