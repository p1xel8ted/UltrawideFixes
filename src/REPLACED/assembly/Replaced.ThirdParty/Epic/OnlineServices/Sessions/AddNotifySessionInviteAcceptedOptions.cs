// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.AddNotifySessionInviteAcceptedOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public class AddNotifySessionInviteAcceptedOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AddNotifySessionInviteAcceptedOptions()
  {
    Il2CppClassPointerStore<AddNotifySessionInviteAcceptedOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (AddNotifySessionInviteAcceptedOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNotifySessionInviteAcceptedOptions>.NativeClassPtr);
    AddNotifySessionInviteAcceptedOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifySessionInviteAcceptedOptions>.NativeClassPtr, 100665312 /*0x060007E0*/);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddNotifySessionInviteAcceptedOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddNotifySessionInviteAcceptedOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifySessionInviteAcceptedOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
