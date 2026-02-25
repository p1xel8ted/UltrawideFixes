// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ExternalAllocationException
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices;

public class ExternalAllocationException(System.IntPtr pointer) : AllocationException(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_0;

  static ExternalAllocationException()
  {
    Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (ExternalAllocationException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr);
    ExternalAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr, 100663765);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364162, XrefRangeEnd = 364172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ExternalAllocationException(System.IntPtr address, Il2CppSystem.Type type)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalAllocationException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &address;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
