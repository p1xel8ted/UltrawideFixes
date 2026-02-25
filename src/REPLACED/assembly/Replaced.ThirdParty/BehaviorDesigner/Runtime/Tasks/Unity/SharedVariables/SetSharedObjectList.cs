// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables.SetSharedObjectList
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables;

public class SetSharedObjectList(IntPtr pointer) : BehaviorDesigner.Runtime.Tasks.Action(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_targetValue;
  private static readonly IntPtr NativeFieldInfoPtr_targetVariable;
  private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SetSharedObjectList()
  {
    Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks.Unity.SharedVariables", nameof (SetSharedObjectList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr);
    SetSharedObjectList.NativeFieldInfoPtr_targetValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr, nameof (targetValue));
    SetSharedObjectList.NativeFieldInfoPtr_targetVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr, nameof (targetVariable));
    SetSharedObjectList.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr, 100674401);
    SetSharedObjectList.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr, 100674402);
    SetSharedObjectList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr, 100674403);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 407133, XrefRangeEnd = 407139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe TaskStatus OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSharedObjectList.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 406060, RefRangeEnd = 406070, XrefRangeStart = 406060, XrefRangeEnd = 406070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetSharedObjectList.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetSharedObjectList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetSharedObjectList>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetSharedObjectList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedObjectList targetValue
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSharedObjectList.NativeFieldInfoPtr_targetValue));
      return num == IntPtr.Zero ? (SharedObjectList) null : Il2CppObjectPool.Get<SharedObjectList>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetSharedObjectList.NativeFieldInfoPtr_targetValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SharedObjectList targetVariable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetSharedObjectList.NativeFieldInfoPtr_targetVariable));
      return num == IntPtr.Zero ? (SharedObjectList) null : Il2CppObjectPool.Get<SharedObjectList>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SetSharedObjectList.NativeFieldInfoPtr_targetVariable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
