// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.HelperExtensions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace Epic.OnlineServices;

public static class HelperExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0;

  static HelperExtensions()
  {
    Il2CppClassPointerStore<HelperExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (HelperExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelperExtensions>.NativeClassPtr);
    HelperExtensions.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelperExtensions>.NativeClassPtr, 100663887);
    HelperExtensions.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelperExtensions>.NativeClassPtr, 100663888 /*0x06000250*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369655, XrefRangeEnd = 369663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsOperationComplete(this Result result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &result
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HelperExtensions.NativeMethodInfoPtr_IsOperationComplete_Public_Static_Boolean_Result_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 369663, XrefRangeEnd = 369664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToHexString(this Il2CppStructArray<byte> byteArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) byteArray)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HelperExtensions.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public HelperExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
