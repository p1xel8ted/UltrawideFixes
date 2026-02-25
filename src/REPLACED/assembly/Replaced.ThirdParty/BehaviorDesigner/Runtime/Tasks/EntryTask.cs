// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.EntryTask
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks;

public class EntryTask(IntPtr pointer) : ParentTask(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_MaxChildren_Public_Virtual_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EntryTask()
  {
    Il2CppClassPointerStore<EntryTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks", nameof (EntryTask));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntryTask>.NativeClassPtr);
    EntryTask.NativeMethodInfoPtr_MaxChildren_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryTask>.NativeClassPtr, 100674018);
    EntryTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntryTask>.NativeClassPtr, 100674019);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int MaxChildren()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntryTask.NativeMethodInfoPtr_MaxChildren_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EntryTask()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntryTask>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EntryTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
