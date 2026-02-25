// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.EpicAccountId
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

public sealed class EpicAccountId(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_EpicaccountidMaxLength;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FromString_Public_Static_EpicAccountId_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static EpicAccountId()
  {
    Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (EpicAccountId));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr);
    EpicAccountId.NativeFieldInfoPtr_EpicaccountidMaxLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, nameof (EpicaccountidMaxLength));
    EpicAccountId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664416 /*0x06000460*/);
    EpicAccountId.NativeMethodInfoPtr_FromString_Public_Static_EpicAccountId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664418);
    EpicAccountId.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664419);
    EpicAccountId.NativeMethodInfoPtr_ToString_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664420);
    EpicAccountId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr, 100664421);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EpicAccountId()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EpicAccountId>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371478, XrefRangeEnd = 371548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EpicAccountId FromString(string accountIdString)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(accountIdString)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_FromString_Public_Static_EpicAccountId_String_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371548, XrefRangeEnd = 371556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 371641, RefRangeEnd = 371642, XrefRangeStart = 371556, XrefRangeEnd = 371641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ToString(out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_ToString_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371642, XrefRangeEnd = 371643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EpicAccountId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static unsafe int EpicaccountidMaxLength
  {
    get
    {
      int epicaccountidMaxLength;
      IL2CPP.il2cpp_field_static_get_value(EpicAccountId.NativeFieldInfoPtr_EpicaccountidMaxLength, (void*) &epicaccountidMaxLength);
      return epicaccountidMaxLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EpicAccountId.NativeFieldInfoPtr_EpicaccountidMaxLength, (void*) &value);
    }
  }
}
