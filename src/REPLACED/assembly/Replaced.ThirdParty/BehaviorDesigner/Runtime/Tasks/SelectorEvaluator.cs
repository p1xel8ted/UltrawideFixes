// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.SelectorEvaluator
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks;

public class SelectorEvaluator(IntPtr pointer) : Composite(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_currentChildIndex;
  private static readonly IntPtr NativeFieldInfoPtr_executionStatus;
  private static readonly IntPtr NativeFieldInfoPtr_storedCurrentChildIndex;
  private static readonly IntPtr NativeFieldInfoPtr_storedExecutionStatus;
  private static readonly IntPtr NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnChildStarted_Public_Virtual_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_Int32_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanRunParallelChildren_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanReevaluate_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReevaluationStarted_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReevaluationEnded_Public_Virtual_Void_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SelectorEvaluator()
  {
    Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks", nameof (SelectorEvaluator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr);
    SelectorEvaluator.NativeFieldInfoPtr_currentChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, nameof (currentChildIndex));
    SelectorEvaluator.NativeFieldInfoPtr_executionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, nameof (executionStatus));
    SelectorEvaluator.NativeFieldInfoPtr_storedCurrentChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, nameof (storedCurrentChildIndex));
    SelectorEvaluator.NativeFieldInfoPtr_storedExecutionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, nameof (storedExecutionStatus));
    SelectorEvaluator.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673849);
    SelectorEvaluator.NativeMethodInfoPtr_OnChildStarted_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673850);
    SelectorEvaluator.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673851);
    SelectorEvaluator.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_Int32_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673852);
    SelectorEvaluator.NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673853);
    SelectorEvaluator.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673854);
    SelectorEvaluator.NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673855);
    SelectorEvaluator.NativeMethodInfoPtr_CanRunParallelChildren_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673856);
    SelectorEvaluator.NativeMethodInfoPtr_CanReevaluate_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673857);
    SelectorEvaluator.NativeMethodInfoPtr_OnReevaluationStarted_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673858);
    SelectorEvaluator.NativeMethodInfoPtr_OnReevaluationEnded_Public_Virtual_Void_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673859);
    SelectorEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr, 100673860);
  }

  [CallerCount(0)]
  public override unsafe int CurrentChildIndex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe void OnChildStarted(int childIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &childIndex
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OnChildStarted_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404686, XrefRangeEnd = 404687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanExecute()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404687, XrefRangeEnd = 404690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnChildExecuted(int childIndex, TaskStatus childStatus)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &childIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &childStatus;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_Int32_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void OnEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe TaskStatus OverrideStatus(TaskStatus status)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &status
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OverrideStatus_Public_Virtual_TaskStatus_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanRunParallelChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_CanRunParallelChildren_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanReevaluate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_CanReevaluate_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe bool OnReevaluationStarted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OnReevaluationStarted_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404690, XrefRangeEnd = 404699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReevaluationEnded(TaskStatus status)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &status
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SelectorEvaluator.NativeMethodInfoPtr_OnReevaluationEnded_Public_Virtual_Void_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404699, XrefRangeEnd = 404700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SelectorEvaluator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorEvaluator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SelectorEvaluator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int currentChildIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_currentChildIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_currentChildIndex)) = value;
    }
  }

  public unsafe TaskStatus executionStatus
  {
    get
    {
      return *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_executionStatus));
    }
    [param: In] set
    {
      *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_executionStatus)) = value;
    }
  }

  public unsafe int storedCurrentChildIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_storedCurrentChildIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_storedCurrentChildIndex)) = value;
    }
  }

  public unsafe TaskStatus storedExecutionStatus
  {
    get
    {
      return *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_storedExecutionStatus));
    }
    [param: In] set
    {
      *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SelectorEvaluator.NativeFieldInfoPtr_storedExecutionStatus)) = value;
    }
  }
}
