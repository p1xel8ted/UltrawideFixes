// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CachedTypeAllocationException
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices;

public class CachedTypeAllocationException(System.IntPtr pointer) : AllocationException(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_Type_0;

  static CachedTypeAllocationException()
  {
    Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (CachedTypeAllocationException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr);
    CachedTypeAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr, 100663766);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364172, XrefRangeEnd = 364182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CachedTypeAllocationException(System.IntPtr address, Il2CppSystem.Type foundType, Il2CppSystem.Type expectedType)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedTypeAllocationException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &address;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) foundType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) expectedType);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CachedTypeAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
