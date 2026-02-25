// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModificationSetInvitesAllowedOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class LobbyModificationSetInvitesAllowedOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__InvitesAllowed_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LobbyModificationSetInvitesAllowedOptions()
  {
    Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModificationSetInvitesAllowedOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr);
    LobbyModificationSetInvitesAllowedOptions.NativeFieldInfoPtr__InvitesAllowed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, "<InvitesAllowed>k__BackingField");
    LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, 100669454);
    LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, 100669455);
    LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr, 100669456);
  }

  public unsafe bool InvitesAllowed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_get_InvitesAllowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbyModificationSetInvitesAllowedOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyModificationSetInvitesAllowedOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationSetInvitesAllowedOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _InvitesAllowed_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyModificationSetInvitesAllowedOptions.NativeFieldInfoPtr__InvitesAllowed_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LobbyModificationSetInvitesAllowedOptions.NativeFieldInfoPtr__InvitesAllowed_k__BackingField)) = value;
    }
  }
}
