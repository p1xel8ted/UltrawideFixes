// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionModification
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public sealed class SessionModification(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Public_Result_SessionModificationAddAttributeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveAttribute_Public_Result_SessionModificationRemoveAttributeOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetBucketId_Public_Result_SessionModificationSetBucketIdOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetHostAddress_Public_Result_SessionModificationSetHostAddressOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_SessionModificationSetInvitesAllowedOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetJoinInProgressAllowed_Public_Result_SessionModificationSetJoinInProgressAllowedOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetMaxPlayers_Public_Result_SessionModificationSetMaxPlayersOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPermissionLevel_Public_Result_SessionModificationSetPermissionLevelOptions_0;

  static SessionModification()
  {
    Il2CppClassPointerStore<SessionModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionModification));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionModification>.NativeClassPtr);
    SessionModification.NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationAddattributeApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMaxSessionAttributeLength));
    SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMaxSessionAttributes));
    SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMaxSessionidoverrideLength));
    SessionModification.NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationMinSessionidoverrideLength));
    SessionModification.NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationRemoveattributeApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetbucketidApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSethostaddressApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetinvitesallowedApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetjoininprogressallowedApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetmaxplayersApiLatest));
    SessionModification.NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, nameof (SessionmodificationSetpermissionlevelApiLatest));
    SessionModification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665862 /*0x06000A06*/);
    SessionModification.NativeMethodInfoPtr_AddAttribute_Public_Result_SessionModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665864 /*0x06000A08*/);
    SessionModification.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665865 /*0x06000A09*/);
    SessionModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_SessionModificationRemoveAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665866 /*0x06000A0A*/);
    SessionModification.NativeMethodInfoPtr_SetBucketId_Public_Result_SessionModificationSetBucketIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665867 /*0x06000A0B*/);
    SessionModification.NativeMethodInfoPtr_SetHostAddress_Public_Result_SessionModificationSetHostAddressOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665868 /*0x06000A0C*/);
    SessionModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_SessionModificationSetInvitesAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665869 /*0x06000A0D*/);
    SessionModification.NativeMethodInfoPtr_SetJoinInProgressAllowed_Public_Result_SessionModificationSetJoinInProgressAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665870 /*0x06000A0E*/);
    SessionModification.NativeMethodInfoPtr_SetMaxPlayers_Public_Result_SessionModificationSetMaxPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665871 /*0x06000A0F*/);
    SessionModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_SessionModificationSetPermissionLevelOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModification>.NativeClassPtr, 100665872 /*0x06000A10*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SessionModification()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionModification>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378751, XrefRangeEnd = 378759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AddAttribute(SessionModificationAddAttributeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_AddAttribute_Public_Result_SessionModificationAddAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378759, XrefRangeEnd = 378760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378760, XrefRangeEnd = 378768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result RemoveAttribute(SessionModificationRemoveAttributeOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_RemoveAttribute_Public_Result_SessionModificationRemoveAttributeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378768, XrefRangeEnd = 378776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetBucketId(SessionModificationSetBucketIdOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetBucketId_Public_Result_SessionModificationSetBucketIdOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378776, XrefRangeEnd = 378784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetHostAddress(SessionModificationSetHostAddressOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetHostAddress_Public_Result_SessionModificationSetHostAddressOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378784, XrefRangeEnd = 378792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetInvitesAllowed(
    SessionModificationSetInvitesAllowedOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetInvitesAllowed_Public_Result_SessionModificationSetInvitesAllowedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378792, XrefRangeEnd = 378800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetJoinInProgressAllowed(
    SessionModificationSetJoinInProgressAllowedOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetJoinInProgressAllowed_Public_Result_SessionModificationSetJoinInProgressAllowedOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378800, XrefRangeEnd = 378808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetMaxPlayers(SessionModificationSetMaxPlayersOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetMaxPlayers_Public_Result_SessionModificationSetMaxPlayersOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378808, XrefRangeEnd = 378816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetPermissionLevel(
    SessionModificationSetPermissionLevelOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionModification.NativeMethodInfoPtr_SetPermissionLevel_Public_Result_SessionModificationSetPermissionLevelOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int SessionmodificationAddattributeApiLatest
  {
    get
    {
      int addattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest, (void*) &addattributeApiLatest);
      return addattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationAddattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationMaxSessionAttributeLength
  {
    get
    {
      int sessionAttributeLength;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength, (void*) &sessionAttributeLength);
      return sessionAttributeLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributeLength, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationMaxSessionAttributes
  {
    get
    {
      int sessionAttributes;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes, (void*) &sessionAttributes);
      return sessionAttributes;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionAttributes, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationMaxSessionidoverrideLength
  {
    get
    {
      int sessionidoverrideLength;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength, (void*) &sessionidoverrideLength);
      return sessionidoverrideLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMaxSessionidoverrideLength, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationMinSessionidoverrideLength
  {
    get
    {
      int sessionidoverrideLength;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength, (void*) &sessionidoverrideLength);
      return sessionidoverrideLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationMinSessionidoverrideLength, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationRemoveattributeApiLatest
  {
    get
    {
      int removeattributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest, (void*) &removeattributeApiLatest);
      return removeattributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationRemoveattributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationSetbucketidApiLatest
  {
    get
    {
      int setbucketidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest, (void*) &setbucketidApiLatest);
      return setbucketidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetbucketidApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationSethostaddressApiLatest
  {
    get
    {
      int sethostaddressApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest, (void*) &sethostaddressApiLatest);
      return sethostaddressApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSethostaddressApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationSetinvitesallowedApiLatest
  {
    get
    {
      int setinvitesallowedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest, (void*) &setinvitesallowedApiLatest);
      return setinvitesallowedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetinvitesallowedApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationSetjoininprogressallowedApiLatest
  {
    get
    {
      int setjoininprogressallowedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest, (void*) &setjoininprogressallowedApiLatest);
      return setjoininprogressallowedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetjoininprogressallowedApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationSetmaxplayersApiLatest
  {
    get
    {
      int setmaxplayersApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest, (void*) &setmaxplayersApiLatest);
      return setmaxplayersApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetmaxplayersApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessionmodificationSetpermissionlevelApiLatest
  {
    get
    {
      int setpermissionlevelApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest, (void*) &setpermissionlevelApiLatest);
      return setpermissionlevelApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionModification.NativeFieldInfoPtr_SessionmodificationSetpermissionlevelApiLatest, (void*) &value);
    }
  }
}
