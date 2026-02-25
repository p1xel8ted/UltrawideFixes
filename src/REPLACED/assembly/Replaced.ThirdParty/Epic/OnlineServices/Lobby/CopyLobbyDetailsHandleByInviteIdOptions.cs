// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.CopyLobbyDetailsHandleByInviteIdOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class CopyLobbyDetailsHandleByInviteIdOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__InviteId_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InviteId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InviteId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CopyLobbyDetailsHandleByInviteIdOptions()
  {
    Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (CopyLobbyDetailsHandleByInviteIdOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr);
    CopyLobbyDetailsHandleByInviteIdOptions.NativeFieldInfoPtr__InviteId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr, "<InviteId>k__BackingField");
    CopyLobbyDetailsHandleByInviteIdOptions.NativeMethodInfoPtr_get_InviteId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr, 100668928 /*0x06001600*/);
    CopyLobbyDetailsHandleByInviteIdOptions.NativeMethodInfoPtr_set_InviteId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr, 100668929);
    CopyLobbyDetailsHandleByInviteIdOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr, 100668930);
  }

  public unsafe string InviteId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptions.NativeMethodInfoPtr_get_InviteId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptions.NativeMethodInfoPtr_set_InviteId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CopyLobbyDetailsHandleByInviteIdOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _InviteId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLobbyDetailsHandleByInviteIdOptions.NativeFieldInfoPtr__InviteId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CopyLobbyDetailsHandleByInviteIdOptions.NativeFieldInfoPtr__InviteId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
