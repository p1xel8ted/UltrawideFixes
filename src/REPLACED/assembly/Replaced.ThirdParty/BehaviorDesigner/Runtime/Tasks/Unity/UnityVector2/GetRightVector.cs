// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2.GetRightVector
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
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2;

public class GetRightVector(IntPtr pointer) : BehaviorDesigner.Runtime.Tasks.Action(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_storeResult;
  private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GetRightVector()
  {
    Il2CppClassPointerStore<GetRightVector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks.Unity.UnityVector2", nameof (GetRightVector));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetRightVector>.NativeClassPtr);
    GetRightVector.NativeFieldInfoPtr_storeResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetRightVector>.NativeClassPtr, nameof (storeResult));
    GetRightVector.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRightVector>.NativeClassPtr, 100674089);
    GetRightVector.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRightVector>.NativeClassPtr, 100674090);
    GetRightVector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetRightVector>.NativeClassPtr, 100674091);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405607, XrefRangeEnd = 405612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe TaskStatus OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetRightVector.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 405612, XrefRangeEnd = 405615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetRightVector.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GetRightVector()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetRightVector>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetRightVector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedVector2 storeResult
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetRightVector.NativeFieldInfoPtr_storeResult));
      return num == IntPtr.Zero ? (SharedVector2) null : Il2CppObjectPool.Get<SharedVector2>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GetRightVector.NativeFieldInfoPtr_storeResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
