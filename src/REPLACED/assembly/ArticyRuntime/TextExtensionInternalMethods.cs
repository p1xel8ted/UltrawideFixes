// Decompiled with JetBrains decompiler
// Type: Articy.Unity.TextExtensionInternalMethods
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public static class TextExtensionInternalMethods : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sMethodMap;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryInvokeMethod_Public_Static_Boolean_String_ArticyTextToken_Il2CppStringArray_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_If_Public_Static_String_ArticyTextToken_Il2CppStringArray_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Not_Public_Static_String_ArticyTextToken_Il2CppStringArray_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConditionalText_Private_Static_String_ArticyTextToken_Il2CppStringArray_String_Boolean_0;

  static TextExtensionInternalMethods()
  {
    Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (TextExtensionInternalMethods));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr);
    TextExtensionInternalMethods.NativeFieldInfoPtr_sMethodMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr, nameof (sMethodMap));
    TextExtensionInternalMethods.NativeMethodInfoPtr_TryInvokeMethod_Public_Static_Boolean_String_ArticyTextToken_Il2CppStringArray_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr, 100663954);
    TextExtensionInternalMethods.NativeMethodInfoPtr_If_Public_Static_String_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr, 100663955);
    TextExtensionInternalMethods.NativeMethodInfoPtr_Not_Public_Static_String_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr, 100663956);
    TextExtensionInternalMethods.NativeMethodInfoPtr_ConditionalText_Private_Static_String_ArticyTextToken_Il2CppStringArray_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionInternalMethods>.NativeClassPtr, 100663957);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993021, XrefRangeEnd = 993056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryInvokeMethod(
    string aMethod,
    ArticyTextToken aUser,
    Il2CppStringArray aArgs,
    out string aOutResult)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(aMethod);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aUser));
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(TextExtensionInternalMethods.NativeMethodInfoPtr_TryInvokeMethod_Public_Static_Boolean_String_ArticyTextToken_Il2CppStringArray_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    aOutResult = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993056, XrefRangeEnd = 993057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string If(
    ArticyTextToken aUser,
    Il2CppStringArray aArgs,
    string aMethodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aUser));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aMethodName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionInternalMethods.NativeMethodInfoPtr_If_Public_Static_String_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993057, XrefRangeEnd = 993058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Not(
    ArticyTextToken aUser,
    Il2CppStringArray aArgs,
    string aMethodName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aUser));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aMethodName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionInternalMethods.NativeMethodInfoPtr_Not_Public_Static_String_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 993078, RefRangeEnd = 993080, XrefRangeStart = 993058, XrefRangeEnd = 993078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ConditionalText(
    ArticyTextToken aUser,
    Il2CppStringArray aArgs,
    string aMethodDisplayName,
    bool aTrueFirst)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aUser));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aMethodDisplayName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aTrueFirst;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionInternalMethods.NativeMethodInfoPtr_ConditionalText_Private_Static_String_ArticyTextToken_Il2CppStringArray_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public TextExtensionInternalMethods(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<string, Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string, string>> sMethodMap
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(TextExtensionInternalMethods.NativeFieldInfoPtr_sMethodMap, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string, string>>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string, string>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TextExtensionInternalMethods.NativeFieldInfoPtr_sMethodMap, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
