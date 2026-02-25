// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.JoinLobbyOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class JoinLobbyOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PresenceEnabled_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalRTCOptions_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyDetailsHandle_Public_get_LobbyDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_LocalRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JoinLobbyOptions()
  {
    Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (JoinLobbyOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr);
    JoinLobbyOptions.NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<LobbyDetailsHandle>k__BackingField");
    JoinLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
    JoinLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<PresenceEnabled>k__BackingField");
    JoinLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, "<LocalRTCOptions>k__BackingField");
    JoinLobbyOptions.NativeMethodInfoPtr_get_LobbyDetailsHandle_Public_get_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669096);
    JoinLobbyOptions.NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669097);
    JoinLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669098);
    JoinLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669099);
    JoinLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669100);
    JoinLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669101);
    JoinLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669102);
    JoinLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669103);
    JoinLobbyOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr, 100669104);
  }

  public unsafe LobbyDetails LobbyDetailsHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_LobbyDetailsHandle_Public_get_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (LobbyDetails) null : Il2CppObjectPool.Get<LobbyDetails>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_LobbyDetailsHandle_Public_set_Void_LobbyDetails_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PresenceEnabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_PresenceEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LocalRTCOptions LocalRTCOptions
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_get_LocalRTCOptions_Public_get_LocalRTCOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (LocalRTCOptions) null : Il2CppObjectPool.Get<LocalRTCOptions>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr_set_LocalRTCOptions_Public_set_Void_LocalRTCOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JoinLobbyOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JoinLobbyOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinLobbyOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LobbyDetails _LobbyDetailsHandle_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField));
      return num == System.IntPtr.Zero ? (LobbyDetails) null : Il2CppObjectPool.Get<LobbyDetails>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LobbyDetailsHandle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _PresenceEnabled_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__PresenceEnabled_k__BackingField)) = value;
    }
  }

  public unsafe LocalRTCOptions _LocalRTCOptions_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField));
      return num == System.IntPtr.Zero ? (LocalRTCOptions) null : Il2CppObjectPool.Get<LocalRTCOptions>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JoinLobbyOptions.NativeFieldInfoPtr__LocalRTCOptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
