// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetails
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

public sealed class SessionDetails(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsAttributeApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsInfoApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_SessiondetailsSettingsApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyInfo_Public_Result_SessionDetailsCopyInfoOptions_byref_SessionDetailsInfo_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopySessionAttributeByIndex_Public_Result_SessionDetailsCopySessionAttributeByIndexOptions_byref_SessionDetailsAttribute_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopySessionAttributeByKey_Public_Result_SessionDetailsCopySessionAttributeByKeyOptions_byref_SessionDetailsAttribute_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSessionAttributeCount_Public_UInt32_SessionDetailsGetSessionAttributeCountOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static SessionDetails()
  {
    Il2CppClassPointerStore<SessionDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetails));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr);
    SessionDetails.NativeFieldInfoPtr_SessiondetailsAttributeApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsAttributeApiLatest));
    SessionDetails.NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsCopyinfoApiLatest));
    SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsCopysessionattributebyindexApiLatest));
    SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsCopysessionattributebykeyApiLatest));
    SessionDetails.NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsGetsessionattributecountApiLatest));
    SessionDetails.NativeFieldInfoPtr_SessiondetailsInfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsInfoApiLatest));
    SessionDetails.NativeFieldInfoPtr_SessiondetailsSettingsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, nameof (SessiondetailsSettingsApiLatest));
    SessionDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100665730);
    SessionDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_SessionDetailsCopyInfoOptions_byref_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100665732);
    SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByIndex_Public_Result_SessionDetailsCopySessionAttributeByIndexOptions_byref_SessionDetailsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100665733);
    SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByKey_Public_Result_SessionDetailsCopySessionAttributeByKeyOptions_byref_SessionDetailsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100665734);
    SessionDetails.NativeMethodInfoPtr_GetSessionAttributeCount_Public_UInt32_SessionDetailsGetSessionAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100665735);
    SessionDetails.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr, 100665736);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SessionDetails()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionDetails>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378262, XrefRangeEnd = 378274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyInfo(
    SessionDetailsCopyInfoOptions options,
    out SessionDetailsInfo outSessionInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_SessionDetailsCopyInfoOptions_byref_SessionDetailsInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetailsInfo local = ref outSessionInfo;
    IntPtr pointer = zero;
    SessionDetailsInfo sessionDetailsInfo = pointer == IntPtr.Zero ? (SessionDetailsInfo) null : new SessionDetailsInfo(pointer);
    local = sessionDetailsInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378274, XrefRangeEnd = 378286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySessionAttributeByIndex(
    SessionDetailsCopySessionAttributeByIndexOptions options,
    out SessionDetailsAttribute outSessionAttribute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByIndex_Public_Result_SessionDetailsCopySessionAttributeByIndexOptions_byref_SessionDetailsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetailsAttribute local = ref outSessionAttribute;
    IntPtr pointer = zero;
    SessionDetailsAttribute detailsAttribute = pointer == IntPtr.Zero ? (SessionDetailsAttribute) null : new SessionDetailsAttribute(pointer);
    local = detailsAttribute;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378286, XrefRangeEnd = 378298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopySessionAttributeByKey(
    SessionDetailsCopySessionAttributeByKeyOptions options,
    out SessionDetailsAttribute outSessionAttribute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_CopySessionAttributeByKey_Public_Result_SessionDetailsCopySessionAttributeByKeyOptions_byref_SessionDetailsAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref SessionDetailsAttribute local = ref outSessionAttribute;
    IntPtr pointer = zero;
    SessionDetailsAttribute detailsAttribute = pointer == IntPtr.Zero ? (SessionDetailsAttribute) null : new SessionDetailsAttribute(pointer);
    local = detailsAttribute;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378298, XrefRangeEnd = 378306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetSessionAttributeCount(
    SessionDetailsGetSessionAttributeCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_GetSessionAttributeCount_Public_UInt32_SessionDetailsGetSessionAttributeCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378306, XrefRangeEnd = 378307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetails.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int SessiondetailsAttributeApiLatest
  {
    get
    {
      int attributeApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsAttributeApiLatest, (void*) &attributeApiLatest);
      return attributeApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsAttributeApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessiondetailsCopyinfoApiLatest
  {
    get
    {
      int copyinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest, (void*) &copyinfoApiLatest);
      return copyinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopyinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessiondetailsCopysessionattributebyindexApiLatest
  {
    get
    {
      int copysessionattributebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest, (void*) &copysessionattributebyindexApiLatest);
      return copysessionattributebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessiondetailsCopysessionattributebykeyApiLatest
  {
    get
    {
      int copysessionattributebykeyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest, (void*) &copysessionattributebykeyApiLatest);
      return copysessionattributebykeyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsCopysessionattributebykeyApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessiondetailsGetsessionattributecountApiLatest
  {
    get
    {
      int getsessionattributecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest, (void*) &getsessionattributecountApiLatest);
      return getsessionattributecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsGetsessionattributecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessiondetailsInfoApiLatest
  {
    get
    {
      int sessiondetailsInfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsInfoApiLatest, (void*) &sessiondetailsInfoApiLatest);
      return sessiondetailsInfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsInfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int SessiondetailsSettingsApiLatest
  {
    get
    {
      int settingsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsSettingsApiLatest, (void*) &settingsApiLatest);
      return settingsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SessionDetails.NativeFieldInfoPtr_SessiondetailsSettingsApiLatest, (void*) &value);
    }
  }
}
