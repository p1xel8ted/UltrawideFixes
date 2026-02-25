// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.DynamicBindingException
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices;

public class DynamicBindingException(System.IntPtr pointer) : Il2CppSystem.Exception(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

  static DynamicBindingException()
  {
    Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (DynamicBindingException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr);
    DynamicBindingException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr, 100663768);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364196, XrefRangeEnd = 364203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DynamicBindingException(string bindingName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicBindingException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(bindingName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DynamicBindingException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
