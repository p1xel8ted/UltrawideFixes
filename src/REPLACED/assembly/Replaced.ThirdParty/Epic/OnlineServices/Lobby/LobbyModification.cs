// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModification
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public sealed class LobbyModification(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationMaxAttributeLength;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationMaxAttributes;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Result_LobbyModificationAddAttributeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddMemberAttribute_Public_Result_LobbyModificationAddMemberAttributeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Result_LobbyModificationRemoveAttributeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveMemberAttribute_Public_Result_LobbyModificationRemoveMemberAttributeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetBucketId_Public_Result_LobbyModificationSetBucketIdOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_LobbyModificationSetInvitesAllowedOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetMaxMembers_Public_Result_LobbyModificationSetMaxMembersOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPermissionLevel_Public_Result_LobbyModificationSetPermissionLevelOptions_0;

  static LobbyModification()
  {
    Il2CppClassPointerStore<LobbyModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModification));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr);
    LobbyModification.NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationAddattributeApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationAddmemberattributeApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationMaxAttributeLength));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationMaxAttributes));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationRemoveattributeApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationRemovememberattributeApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetbucketidApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetinvitesallowedApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetmaxmembersApiLatest));
    LobbyModification.NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, nameof (LobbymodificationSetpermissionlevelApiLatest));
    LobbyModification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669402);
    LobbyModification.NativeMethodInfoPtr_AddAttribute_Public_Result_LobbyModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669404);
    LobbyModification.NativeMethodInfoPtr_AddMemberAttribute_Public_Result_LobbyModificationAddMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669405);
    LobbyModification.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669406);
    LobbyModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_LobbyModificationRemoveAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669407);
    LobbyModification.NativeMethodInfoPtr_RemoveMemberAttribute_Public_Result_LobbyModificationRemoveMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669408);
    LobbyModification.NativeMethodInfoPtr_SetBucketId_Public_Result_LobbyModificationSetBucketIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669409);
    LobbyModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_LobbyModificationSetInvitesAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669410);
    LobbyModification.NativeMethodInfoPtr_SetMaxMembers_Public_Result_LobbyModificationSetMaxMembersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669411);
    LobbyModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_LobbyModificationSetPermissionLevelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr, 100669412);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbyModification()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyModification>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390582, XrefRangeEnd = 390590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AddAttribute(LobbyModificationAddAttributeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_AddAttribute_Public_Result_LobbyModificationAddAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390590, XrefRangeEnd = 390598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AddMemberAttribute(LobbyModificationAddMemberAttributeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_AddMemberAttribute_Public_Result_LobbyModificationAddMemberAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390598, XrefRangeEnd = 390599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390599, XrefRangeEnd = 390607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RemoveAttribute(LobbyModificationRemoveAttributeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_LobbyModificationRemoveAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390607, XrefRangeEnd = 390615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RemoveMemberAttribute(
    LobbyModificationRemoveMemberAttributeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_RemoveMemberAttribute_Public_Result_LobbyModificationRemoveMemberAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390615, XrefRangeEnd = 390623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetBucketId(LobbyModificationSetBucketIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetBucketId_Public_Result_LobbyModificationSetBucketIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390623, XrefRangeEnd = 390631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetInvitesAllowed(LobbyModificationSetInvitesAllowedOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_LobbyModificationSetInvitesAllowedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390631, XrefRangeEnd = 390639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetMaxMembers(LobbyModificationSetMaxMembersOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetMaxMembers_Public_Result_LobbyModificationSetMaxMembersOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390639, XrefRangeEnd = 390647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetPermissionLevel(LobbyModificationSetPermissionLevelOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_LobbyModificationSetPermissionLevelOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int LobbymodificationAddattributeApiLatest
  {
    get
    {
      int addattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest, (void*) &addattributeApiLatest);
      return addattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationAddmemberattributeApiLatest
  {
    get
    {
      int addmemberattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest, (void*) &addmemberattributeApiLatest);
      return addmemberattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationAddmemberattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationMaxAttributeLength
  {
    get
    {
      int maxAttributeLength;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributeLength, (void*) &maxAttributeLength);
      return maxAttributeLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributeLength, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationMaxAttributes
  {
    get
    {
      int lobbymodificationMaxAttributes;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributes, (void*) &lobbymodificationMaxAttributes);
      return lobbymodificationMaxAttributes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationMaxAttributes, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationRemoveattributeApiLatest
  {
    get
    {
      int removeattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest, (void*) &removeattributeApiLatest);
      return removeattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemoveattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationRemovememberattributeApiLatest
  {
    get
    {
      int removememberattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest, (void*) &removememberattributeApiLatest);
      return removememberattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationRemovememberattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationSetbucketidApiLatest
  {
    get
    {
      int setbucketidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest, (void*) &setbucketidApiLatest);
      return setbucketidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetbucketidApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationSetinvitesallowedApiLatest
  {
    get
    {
      int setinvitesallowedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest, (void*) &setinvitesallowedApiLatest);
      return setinvitesallowedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetinvitesallowedApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationSetmaxmembersApiLatest
  {
    get
    {
      int setmaxmembersApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest, (void*) &setmaxmembersApiLatest);
      return setmaxmembersApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetmaxmembersApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbymodificationSetpermissionlevelApiLatest
  {
    get
    {
      int setpermissionlevelApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest, (void*) &setpermissionlevelApiLatest);
      return setpermissionlevelApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyModification.NativeFieldInfoPtr_LobbymodificationSetpermissionlevelApiLatest, (void*) &value);
    }
  }
}
