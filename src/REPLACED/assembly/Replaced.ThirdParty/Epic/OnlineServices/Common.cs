// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Common
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices;

public static class Common : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_InvalidNotificationid;
  private static readonly System.IntPtr NativeFieldInfoPtr_PagequeryApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PagequeryMaxcountDefault;
  private static readonly System.IntPtr NativeFieldInfoPtr_PagequeryMaxcountMaximum;
  private static readonly System.IntPtr NativeFieldInfoPtr_PaginationApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_Result_Il2CppStructArray_1_Byte_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0;

  static Common()
  {
    Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (Common));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr);
    Epic.OnlineServices.Common.NativeFieldInfoPtr_InvalidNotificationid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (InvalidNotificationid));
    Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PagequeryApiLatest));
    Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PagequeryMaxcountDefault));
    Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountMaximum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PagequeryMaxcountMaximum));
    Epic.OnlineServices.Common.NativeFieldInfoPtr_PaginationApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, nameof (PaginationApiLatest));
    Epic.OnlineServices.Common.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664408);
    Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_String_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664409);
    Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Result_Il2CppStructArray_1_Byte_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664410);
    Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Epic.OnlineServices.Common>.NativeClassPtr, 100664411);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsOperationComplete(Result result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &result
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371231, XrefRangeEnd = 371237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToString(Result result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &result
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_String_Result_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 371389, RefRangeEnd = 371391, XrefRangeStart = 371237, XrefRangeEnd = 371389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Result ToString(Il2CppStructArray<byte> byteArray, out string outBuffer)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) byteArray);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_Result_Il2CppStructArray_1_Byte_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToString(Il2CppStructArray<byte> byteArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) byteArray)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Epic.OnlineServices.Common.NativeMethodInfoPtr_ToString_Public_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Common(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ulong InvalidNotificationid
  {
    get
    {
      ulong invalidNotificationid;
      IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_InvalidNotificationid, (void*) &invalidNotificationid);
      return invalidNotificationid;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_InvalidNotificationid, (void*) &value);
    }
  }

  public static unsafe int PagequeryApiLatest
  {
    get
    {
      int pagequeryApiLatest;
      IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryApiLatest, (void*) &pagequeryApiLatest);
      return pagequeryApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryApiLatest, (void*) &value);
    }
  }

  public static unsafe int PagequeryMaxcountDefault
  {
    get
    {
      int pagequeryMaxcountDefault;
      IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountDefault, (void*) &pagequeryMaxcountDefault);
      return pagequeryMaxcountDefault;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountDefault, (void*) &value);
    }
  }

  public static unsafe int PagequeryMaxcountMaximum
  {
    get
    {
      int pagequeryMaxcountMaximum;
      IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountMaximum, (void*) &pagequeryMaxcountMaximum);
      return pagequeryMaxcountMaximum;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PagequeryMaxcountMaximum, (void*) &value);
    }
  }

  public static unsafe int PaginationApiLatest
  {
    get
    {
      int paginationApiLatest;
      IL2CPP.il2cpp_field_static_get_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PaginationApiLatest, (void*) &paginationApiLatest);
      return paginationApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Epic.OnlineServices.Common.NativeFieldInfoPtr_PaginationApiLatest, (void*) &value);
    }
  }
}
