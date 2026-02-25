// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.MonoPInvokeCallbackAttribute
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices;

public sealed class MonoPInvokeCallbackAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

  static MonoPInvokeCallbackAttribute()
  {
    Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (MonoPInvokeCallbackAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr);
    MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr, 100663893);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MonoPInvokeCallbackAttribute(Il2CppSystem.Type type)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoPInvokeCallbackAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MonoPInvokeCallbackAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
