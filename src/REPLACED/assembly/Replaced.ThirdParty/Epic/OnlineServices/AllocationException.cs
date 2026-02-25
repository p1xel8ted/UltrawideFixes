// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AllocationException
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices;

public class AllocationException(System.IntPtr pointer) : Il2CppSystem.Exception(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

  static AllocationException()
  {
    Il2CppClassPointerStore<AllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (AllocationException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocationException>.NativeClassPtr);
    AllocationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocationException>.NativeClassPtr, 100663764);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364158, XrefRangeEnd = 364162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AllocationException(string message)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocationException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AllocationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
