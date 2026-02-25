// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ProductUserId
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
namespace Epic.OnlineServices;

public sealed class ProductUserId(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ProductuseridMaxLength;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FromString_Public_Static_ProductUserId_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static ProductUserId()
  {
    Il2CppClassPointerStore<ProductUserId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (ProductUserId));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr);
    ProductUserId.NativeFieldInfoPtr_ProductuseridMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, nameof (ProductuseridMaxLength));
    ProductUserId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664454);
    ProductUserId.NativeMethodInfoPtr_FromString_Public_Static_ProductUserId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664456);
    ProductUserId.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664457);
    ProductUserId.NativeMethodInfoPtr_ToString_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664458);
    ProductUserId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr, 100664459);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProductUserId()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductUserId>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371683, XrefRangeEnd = 371753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProductUserId FromString(string productUserIdString)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(productUserIdString)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_FromString_Public_Static_ProductUserId_String_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371753, XrefRangeEnd = 371761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 371846, RefRangeEnd = 371847, XrefRangeStart = 371761, XrefRangeEnd = 371846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ToString(out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_ToString_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371847, XrefRangeEnd = 371848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProductUserId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static unsafe int ProductuseridMaxLength
  {
    get
    {
      int productuseridMaxLength;
      IL2CPP.il2cpp_field_static_get_value(ProductUserId.NativeFieldInfoPtr_ProductuseridMaxLength, (void*) &productuseridMaxLength);
      return productuseridMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProductUserId.NativeFieldInfoPtr_ProductuseridMaxLength, (void*) &value);
    }
  }
}
