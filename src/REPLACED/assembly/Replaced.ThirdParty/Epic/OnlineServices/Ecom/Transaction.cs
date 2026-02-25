// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.Transaction
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

public sealed class Transaction(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_TransactionCopyEntitlementByIndexOptions_byref_Entitlement_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_TransactionGetEntitlementsCountOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTransactionId_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static Transaction()
  {
    Il2CppClassPointerStore<Transaction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (Transaction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transaction>.NativeClassPtr);
    Transaction.NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, nameof (TransactionCopyentitlementbyindexApiLatest));
    Transaction.NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Transaction>.NativeClassPtr, nameof (TransactionGetentitlementscountApiLatest));
    Transaction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100671277);
    Transaction.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_TransactionCopyEntitlementByIndexOptions_byref_Entitlement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100671279);
    Transaction.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_TransactionGetEntitlementsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100671280);
    Transaction.NativeMethodInfoPtr_GetTransactionId_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100671281);
    Transaction.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transaction>.NativeClassPtr, 100671282);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transaction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transaction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395866, XrefRangeEnd = 395878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyEntitlementByIndex(
    TransactionCopyEntitlementByIndexOptions options,
    out Entitlement outEntitlement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_CopyEntitlementByIndex_Public_Result_TransactionCopyEntitlementByIndexOptions_byref_Entitlement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Entitlement local = ref outEntitlement;
    IntPtr pointer = zero;
    Entitlement entitlement = pointer == IntPtr.Zero ? (Entitlement) null : new Entitlement(pointer);
    local = entitlement;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395878, XrefRangeEnd = 395886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetEntitlementsCount(TransactionGetEntitlementsCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_GetEntitlementsCount_Public_UInt32_TransactionGetEntitlementsCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395886, XrefRangeEnd = 395893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetTransactionId(out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_GetTransactionId_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395893, XrefRangeEnd = 395894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Transaction.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int TransactionCopyentitlementbyindexApiLatest
  {
    get
    {
      int copyentitlementbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(Transaction.NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest, (void*) &copyentitlementbyindexApiLatest);
      return copyentitlementbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Transaction.NativeFieldInfoPtr_TransactionCopyentitlementbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int TransactionGetentitlementscountApiLatest
  {
    get
    {
      int getentitlementscountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(Transaction.NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest, (void*) &getentitlementscountApiLatest);
      return getentitlementscountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Transaction.NativeFieldInfoPtr_TransactionGetentitlementscountApiLatest, (void*) &value);
    }
  }
}
