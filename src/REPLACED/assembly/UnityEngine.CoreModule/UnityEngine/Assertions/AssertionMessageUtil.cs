// Decompiled with JetBrains decompiler
// Type: UnityEngine.Assertions.AssertionMessageUtil
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Assertions;

public class AssertionMessageUtil(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0;
  public const string k_Expected = "Expected:";
  public const string k_AssertionFailed = "Assertion failure.";

  static AssertionMessageUtil()
  {
    Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", nameof (AssertionMessageUtil));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr);
    AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100669592);
    AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100669593);
    AssertionMessageUtil.NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100669594);
    AssertionMessageUtil.NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100669595);
    AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionMessageUtil>.NativeClassPtr, 100669596);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481688, XrefRangeEnd = 481705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetMessage(string failureMessage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(failureMessage)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 481744, RefRangeEnd = 481751, XrefRangeStart = 481705, XrefRangeEnd = 481744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetMessage(string failureMessage, string expected)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(failureMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(expected);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetMessage_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481785, RefRangeEnd = 481787, XrefRangeStart = 481751, XrefRangeEnd = 481785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetEqualityMessage(Il2CppSystem.Object actual, Il2CppSystem.Object expected, bool expectEqual)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actual);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) expected);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &expectEqual;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_GetEqualityMessage_Public_Static_String_Object_Object_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 481812, RefRangeEnd = 481818, XrefRangeStart = 481787, XrefRangeEnd = 481812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NullFailureMessage(Il2CppSystem.Object value, bool expectNull)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &expectNull;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_NullFailureMessage_Public_Static_String_Object_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481818, XrefRangeEnd = 481826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string BooleanFailureMessage(bool expected)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &expected
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssertionMessageUtil.NativeMethodInfoPtr_BooleanFailureMessage_Public_Static_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }
}
