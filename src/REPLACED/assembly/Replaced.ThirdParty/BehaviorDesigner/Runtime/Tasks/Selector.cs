// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Selector
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

public class Selector(IntPtr pointer) : Composite(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_currentChildIndex;
  private static readonly IntPtr NativeFieldInfoPtr_executionStatus;
  private static readonly IntPtr NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Selector()
  {
    Il2CppClassPointerStore<Selector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks", nameof (Selector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Selector>.NativeClassPtr);
    Selector.NativeFieldInfoPtr_currentChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selector>.NativeClassPtr, nameof (currentChildIndex));
    Selector.NativeFieldInfoPtr_executionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Selector>.NativeClassPtr, nameof (executionStatus));
    Selector.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100673843);
    Selector.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100673844);
    Selector.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100673845);
    Selector.NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100673846);
    Selector.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100673847);
    Selector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Selector>.NativeClassPtr, 100673848);
  }

  [CallerCount(0)]
  public override unsafe int CurrentChildIndex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Selector.NativeMethodInfoPtr_CurrentChildIndex_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404685, XrefRangeEnd = 404686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool CanExecute()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Selector.NativeMethodInfoPtr_CanExecute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Selector.NativeMethodInfoPtr_OnChildExecuted_Public_Virtual_Void_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Selector.NativeMethodInfoPtr_OnConditionalAbort_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void OnEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Selector.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Selector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Selector>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Selector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int currentChildIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_currentChildIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_currentChildIndex)) = value;
    }
  }

  public unsafe TaskStatus executionStatus
  {
    get
    {
      return *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_executionStatus));
    }
    [param: In] set
    {
      *(TaskStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Selector.NativeFieldInfoPtr_executionStatus)) = value;
    }
  }
}
