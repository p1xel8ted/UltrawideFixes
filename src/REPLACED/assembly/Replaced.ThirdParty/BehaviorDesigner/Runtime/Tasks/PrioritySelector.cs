// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.PrioritySelector
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks;

public class PrioritySelector(IntPtr pointer) : Composite(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_currentChildIndex;
  private static readonly IntPtr NativeFieldInfoPtr_executionStatus;
  private static readonly IntPtr NativeFieldInfoPtr_childrenExecutionOrder;
  private static readonly IntPtr NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PrioritySelector()
  {
    Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks", nameof (PrioritySelector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr);
    PrioritySelector.NativeFieldInfoPtr_currentChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, nameof (currentChildIndex));
    PrioritySelector.NativeFieldInfoPtr_executionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, nameof (executionStatus));
    PrioritySelector.NativeFieldInfoPtr_childrenExecutionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, nameof (childrenExecutionOrder));
    PrioritySelector.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673816);
    PrioritySelector.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673817);
    PrioritySelector.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673818);
    PrioritySelector.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673819);
    PrioritySelector.NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673820);
    PrioritySelector.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673821);
    PrioritySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr, 100673822);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404543, XrefRangeEnd = 404559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrioritySelector.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404559, XrefRangeEnd = 404563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int CurrentChildIndex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrioritySelector.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404563, XrefRangeEnd = 404564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanExecute()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrioritySelector.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe void OnChildExecuted(TaskStatus childStatus)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &childStatus
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrioritySelector.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void OnConditionalAbort(int childIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &childIndex
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrioritySelector.NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void OnEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrioritySelector.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404564, XrefRangeEnd = 404571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PrioritySelector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrioritySelector>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PrioritySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int currentChildIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrioritySelector.NativeFieldInfoPtr_currentChildIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrioritySelector.NativeFieldInfoPtr_currentChildIndex)) = value;
    }
  }

  public unsafe TaskStatus executionStatus
  {
    get
    {
      return *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrioritySelector.NativeFieldInfoPtr_executionStatus));
    }
    [param: In] set
    {
      *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrioritySelector.NativeFieldInfoPtr_executionStatus)) = value;
    }
  }

  public unsafe List<int> childrenExecutionOrder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrioritySelector.NativeFieldInfoPtr_childrenExecutionOrder));
      return num == IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrioritySelector.NativeFieldInfoPtr_childrenExecutionOrder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
