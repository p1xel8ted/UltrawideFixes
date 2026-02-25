// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyDetails
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public sealed class LobbyDetails(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_LobbydetailsInfoApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyAttributeByIndex_Public_Result_LobbyDetailsCopyAttributeByIndexOptions_byref_Attribute_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyAttributeByKey_Public_Result_LobbyDetailsCopyAttributeByKeyOptions_byref_Attribute_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyInfo_Public_Result_LobbyDetailsCopyInfoOptions_byref_LobbyDetailsInfo_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyMemberAttributeByIndex_Public_Result_LobbyDetailsCopyMemberAttributeByIndexOptions_byref_Attribute_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyMemberAttributeByKey_Public_Result_LobbyDetailsCopyMemberAttributeByKeyOptions_byref_Attribute_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAttributeCount_Public_UInt32_LobbyDetailsGetAttributeCountOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetLobbyOwner_Public_ProductUserId_LobbyDetailsGetLobbyOwnerOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMemberAttributeCount_Public_UInt32_LobbyDetailsGetMemberAttributeCountOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMemberByIndex_Public_ProductUserId_LobbyDetailsGetMemberByIndexOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetMemberCount_Public_UInt32_LobbyDetailsGetMemberCountOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static LobbyDetails()
  {
    Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyDetails));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr);
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopyattributebyindexApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopyattributebykeyApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopyinfoApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopymemberattributebyindexApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsCopymemberattributebykeyApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetattributecountApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetlobbyownerApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetmemberattributecountApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetmemberbyindexApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsGetmembercountApiLatest));
    LobbyDetails.NativeFieldInfoPtr_LobbydetailsInfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, nameof (LobbydetailsInfoApiLatest));
    LobbyDetails.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669163);
    LobbyDetails.NativeMethodInfoPtr_CopyAttributeByIndex_Public_Result_LobbyDetailsCopyAttributeByIndexOptions_byref_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669165);
    LobbyDetails.NativeMethodInfoPtr_CopyAttributeByKey_Public_Result_LobbyDetailsCopyAttributeByKeyOptions_byref_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669166);
    LobbyDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_LobbyDetailsCopyInfoOptions_byref_LobbyDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669167);
    LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByIndex_Public_Result_LobbyDetailsCopyMemberAttributeByIndexOptions_byref_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669168);
    LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByKey_Public_Result_LobbyDetailsCopyMemberAttributeByKeyOptions_byref_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669169);
    LobbyDetails.NativeMethodInfoPtr_GetAttributeCount_Public_UInt32_LobbyDetailsGetAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669170);
    LobbyDetails.NativeMethodInfoPtr_GetLobbyOwner_Public_ProductUserId_LobbyDetailsGetLobbyOwnerOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669171);
    LobbyDetails.NativeMethodInfoPtr_GetMemberAttributeCount_Public_UInt32_LobbyDetailsGetMemberAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669172);
    LobbyDetails.NativeMethodInfoPtr_GetMemberByIndex_Public_ProductUserId_LobbyDetailsGetMemberByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669173);
    LobbyDetails.NativeMethodInfoPtr_GetMemberCount_Public_UInt32_LobbyDetailsGetMemberCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669174);
    LobbyDetails.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr, 100669175);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LobbyDetails()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyDetails>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389409, XrefRangeEnd = 389421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyAttributeByIndex(
    LobbyDetailsCopyAttributeByIndexOptions options,
    out Attribute outAttribute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyAttributeByIndex_Public_Result_LobbyDetailsCopyAttributeByIndexOptions_byref_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Attribute local = ref outAttribute;
    IntPtr pointer = zero;
    Attribute attribute = pointer == IntPtr.Zero ? (Attribute) null : new Attribute(pointer);
    local = attribute;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389421, XrefRangeEnd = 389433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyAttributeByKey(
    LobbyDetailsCopyAttributeByKeyOptions options,
    out Attribute outAttribute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyAttributeByKey_Public_Result_LobbyDetailsCopyAttributeByKeyOptions_byref_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Attribute local = ref outAttribute;
    IntPtr pointer = zero;
    Attribute attribute = pointer == IntPtr.Zero ? (Attribute) null : new Attribute(pointer);
    local = attribute;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389433, XrefRangeEnd = 389445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyInfo(
    LobbyDetailsCopyInfoOptions options,
    out LobbyDetailsInfo outLobbyDetailsInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyInfo_Public_Result_LobbyDetailsCopyInfoOptions_byref_LobbyDetailsInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref LobbyDetailsInfo local = ref outLobbyDetailsInfo;
    IntPtr pointer = zero;
    LobbyDetailsInfo lobbyDetailsInfo = pointer == IntPtr.Zero ? (LobbyDetailsInfo) null : new LobbyDetailsInfo(pointer);
    local = lobbyDetailsInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389445, XrefRangeEnd = 389457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyMemberAttributeByIndex(
    LobbyDetailsCopyMemberAttributeByIndexOptions options,
    out Attribute outAttribute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByIndex_Public_Result_LobbyDetailsCopyMemberAttributeByIndexOptions_byref_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Attribute local = ref outAttribute;
    IntPtr pointer = zero;
    Attribute attribute = pointer == IntPtr.Zero ? (Attribute) null : new Attribute(pointer);
    local = attribute;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389457, XrefRangeEnd = 389469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyMemberAttributeByKey(
    LobbyDetailsCopyMemberAttributeByKeyOptions options,
    out Attribute outAttribute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_CopyMemberAttributeByKey_Public_Result_LobbyDetailsCopyMemberAttributeByKeyOptions_byref_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Attribute local = ref outAttribute;
    IntPtr pointer = zero;
    Attribute attribute = pointer == IntPtr.Zero ? (Attribute) null : new Attribute(pointer);
    local = attribute;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389469, XrefRangeEnd = 389477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetAttributeCount(LobbyDetailsGetAttributeCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetAttributeCount_Public_UInt32_LobbyDetailsGetAttributeCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389477, XrefRangeEnd = 389488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProductUserId GetLobbyOwner(LobbyDetailsGetLobbyOwnerOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetLobbyOwner_Public_ProductUserId_LobbyDetailsGetLobbyOwnerOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389488, XrefRangeEnd = 389496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetMemberAttributeCount(LobbyDetailsGetMemberAttributeCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetMemberAttributeCount_Public_UInt32_LobbyDetailsGetMemberAttributeCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389496, XrefRangeEnd = 389507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProductUserId GetMemberByIndex(LobbyDetailsGetMemberByIndexOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetMemberByIndex_Public_ProductUserId_LobbyDetailsGetMemberByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389507, XrefRangeEnd = 389515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetMemberCount(LobbyDetailsGetMemberCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_GetMemberCount_Public_UInt32_LobbyDetailsGetMemberCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389515, XrefRangeEnd = 389516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetails.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int LobbydetailsCopyattributebyindexApiLatest
  {
    get
    {
      int copyattributebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest, (void*) &copyattributebyindexApiLatest);
      return copyattributebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsCopyattributebykeyApiLatest
  {
    get
    {
      int copyattributebykeyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest, (void*) &copyattributebykeyApiLatest);
      return copyattributebykeyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyattributebykeyApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsCopyinfoApiLatest
  {
    get
    {
      int copyinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest, (void*) &copyinfoApiLatest);
      return copyinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopyinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsCopymemberattributebyindexApiLatest
  {
    get
    {
      int copymemberattributebyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest, (void*) &copymemberattributebyindexApiLatest);
      return copymemberattributebyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsCopymemberattributebykeyApiLatest
  {
    get
    {
      int copymemberattributebykeyApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest, (void*) &copymemberattributebykeyApiLatest);
      return copymemberattributebykeyApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsCopymemberattributebykeyApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsGetattributecountApiLatest
  {
    get
    {
      int getattributecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest, (void*) &getattributecountApiLatest);
      return getattributecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetattributecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsGetlobbyownerApiLatest
  {
    get
    {
      int getlobbyownerApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest, (void*) &getlobbyownerApiLatest);
      return getlobbyownerApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetlobbyownerApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsGetmemberattributecountApiLatest
  {
    get
    {
      int getmemberattributecountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest, (void*) &getmemberattributecountApiLatest);
      return getmemberattributecountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberattributecountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsGetmemberbyindexApiLatest
  {
    get
    {
      int getmemberbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest, (void*) &getmemberbyindexApiLatest);
      return getmemberbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmemberbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsGetmembercountApiLatest
  {
    get
    {
      int getmembercountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest, (void*) &getmembercountApiLatest);
      return getmembercountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsGetmembercountApiLatest, (void*) &value);
    }
  }

  public static unsafe int LobbydetailsInfoApiLatest
  {
    get
    {
      int lobbydetailsInfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsInfoApiLatest, (void*) &lobbydetailsInfoApiLatest);
      return lobbydetailsInfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LobbyDetails.NativeFieldInfoPtr_LobbydetailsInfoApiLatest, (void*) &value);
    }
  }
}
