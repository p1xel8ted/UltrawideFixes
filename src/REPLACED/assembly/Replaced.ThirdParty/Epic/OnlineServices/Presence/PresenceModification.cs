// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModification
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

public sealed class PresenceModification(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength;
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetdataApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DeleteData_Public_Result_PresenceModificationDeleteDataOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Result_PresenceModificationSetDataOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetJoinInfo_Public_Result_PresenceModificationSetJoinInfoOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetRawRichText_Public_Result_PresenceModificationSetRawRichTextOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetStatus_Public_Result_PresenceModificationSetStatusOptions_0;

  static PresenceModification()
  {
    Il2CppClassPointerStore<PresenceModification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModification));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr);
    PresenceModification.NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationDatarecordidApiLatest));
    PresenceModification.NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationDeletedataApiLatest));
    PresenceModification.NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationJoininfoMaxLength));
    PresenceModification.NativeFieldInfoPtr_PresencemodificationSetdataApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetdataApiLatest));
    PresenceModification.NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetjoininfoApiLatest));
    PresenceModification.NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetrawrichtextApiLatest));
    PresenceModification.NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, nameof (PresencemodificationSetstatusApiLatest));
    PresenceModification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667404 /*0x0600100C*/);
    PresenceModification.NativeMethodInfoPtr_DeleteData_Public_Result_PresenceModificationDeleteDataOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667406 /*0x0600100E*/);
    PresenceModification.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667407 /*0x0600100F*/);
    PresenceModification.NativeMethodInfoPtr_SetData_Public_Result_PresenceModificationSetDataOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667408 /*0x06001010*/);
    PresenceModification.NativeMethodInfoPtr_SetJoinInfo_Public_Result_PresenceModificationSetJoinInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667409);
    PresenceModification.NativeMethodInfoPtr_SetRawRichText_Public_Result_PresenceModificationSetRawRichTextOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667410);
    PresenceModification.NativeMethodInfoPtr_SetStatus_Public_Result_PresenceModificationSetStatusOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr, 100667411);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresenceModification()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceModification>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383675, XrefRangeEnd = 383683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result DeleteData(PresenceModificationDeleteDataOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_DeleteData_Public_Result_PresenceModificationDeleteDataOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383683, XrefRangeEnd = 383684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383684, XrefRangeEnd = 383692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetData(PresenceModificationSetDataOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetData_Public_Result_PresenceModificationSetDataOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383692, XrefRangeEnd = 383700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetJoinInfo(PresenceModificationSetJoinInfoOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetJoinInfo_Public_Result_PresenceModificationSetJoinInfoOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383700, XrefRangeEnd = 383708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetRawRichText(PresenceModificationSetRawRichTextOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetRawRichText_Public_Result_PresenceModificationSetRawRichTextOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383708, XrefRangeEnd = 383716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetStatus(PresenceModificationSetStatusOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModification.NativeMethodInfoPtr_SetStatus_Public_Result_PresenceModificationSetStatusOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe int PresencemodificationDatarecordidApiLatest
  {
    get
    {
      int datarecordidApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest, (void*) &datarecordidApiLatest);
      return datarecordidApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDatarecordidApiLatest, (void*) &value);
    }
  }

  public static unsafe int PresencemodificationDeletedataApiLatest
  {
    get
    {
      int deletedataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest, (void*) &deletedataApiLatest);
      return deletedataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationDeletedataApiLatest, (void*) &value);
    }
  }

  public static unsafe int PresencemodificationJoininfoMaxLength
  {
    get
    {
      int joininfoMaxLength;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength, (void*) &joininfoMaxLength);
      return joininfoMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationJoininfoMaxLength, (void*) &value);
    }
  }

  public static unsafe int PresencemodificationSetdataApiLatest
  {
    get
    {
      int setdataApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetdataApiLatest, (void*) &setdataApiLatest);
      return setdataApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetdataApiLatest, (void*) &value);
    }
  }

  public static unsafe int PresencemodificationSetjoininfoApiLatest
  {
    get
    {
      int setjoininfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest, (void*) &setjoininfoApiLatest);
      return setjoininfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetjoininfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int PresencemodificationSetrawrichtextApiLatest
  {
    get
    {
      int setrawrichtextApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest, (void*) &setrawrichtextApiLatest);
      return setrawrichtextApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetrawrichtextApiLatest, (void*) &value);
    }
  }

  public static unsafe int PresencemodificationSetstatusApiLatest
  {
    get
    {
      int setstatusApiLatest;
      IL2CPP.il2cpp_field_static_get_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest, (void*) &setstatusApiLatest);
      return setstatusApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresenceModification.NativeFieldInfoPtr_PresencemodificationSetstatusApiLatest, (void*) &value);
    }
  }
}
