// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyTextExtension
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public static class ArticyTextExtension : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr__LastRandomResults_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_cCharTokenStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_cCharTokenEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_cCharTokenEscape;
  private static readonly System.IntPtr NativeFieldInfoPtr_cCharSuffixStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_cCharSuffixEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_cSuffixRandomIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_cSuffixLastIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_cLocaKeyVariableConstantsBool;
  private static readonly System.IntPtr NativeFieldInfoPtr_cTypeAccessModifier;
  private static readonly System.IntPtr NativeFieldInfoPtr_sUserMethodMap;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastRandomResults_Public_Static_get_List_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LastRandomResults_Private_Static_set_Void_List_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_Static_String_Object_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAdvance_Public_Static_String_Func_2_ArticyTextToken_String_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAdvance_Public_Static_String_Object_Func_2_ArticyTextToken_String_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveToken_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveToken_Public_Static_String_ArticyTextToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddUserMethod_Public_Static_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddUserMethod_Public_Static_Void_String_Func_3_ArticyTextToken_Il2CppStringArray_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUserMethod_Public_Static_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUserMethod_Public_Static_Void_String_Func_3_ArticyTextToken_Il2CppStringArray_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveInternal_Internal_Static_String_Object_Func_2_ArticyTextToken_String_List_1_TextExtensionResolvedToken_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveTokenInternal_Private_Static_TextExtensionResolvedToken_String_ArticyTextToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TokenValueToString_Private_Static_String_String_Object_String_TextExtensionPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveFormatRecursively_Private_Static_Void_byref_String_Il2CppReferenceArray_1_Object_ArticyTextToken_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryExtractSuffix_Private_Static_Boolean_byref_String_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneOrGetFromEditTimeSafe_Private_Static_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneOrGetFromEditTimeSafe_Private_Static_ArticyObject_UInt64_UInt32_0;

  static ArticyTextExtension()
  {
    Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyTextExtension));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr);
    ArticyTextExtension.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (Logger));
    ArticyTextExtension.NativeFieldInfoPtr__LastRandomResults_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, "<LastRandomResults>k__BackingField");
    ArticyTextExtension.NativeFieldInfoPtr_cCharTokenStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cCharTokenStart));
    ArticyTextExtension.NativeFieldInfoPtr_cCharTokenEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cCharTokenEnd));
    ArticyTextExtension.NativeFieldInfoPtr_cCharTokenEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cCharTokenEscape));
    ArticyTextExtension.NativeFieldInfoPtr_cCharSuffixStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cCharSuffixStart));
    ArticyTextExtension.NativeFieldInfoPtr_cCharSuffixEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cCharSuffixEnd));
    ArticyTextExtension.NativeFieldInfoPtr_cSuffixRandomIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cSuffixRandomIndex));
    ArticyTextExtension.NativeFieldInfoPtr_cSuffixLastIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cSuffixLastIndex));
    ArticyTextExtension.NativeFieldInfoPtr_cLocaKeyVariableConstantsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cLocaKeyVariableConstantsBool));
    ArticyTextExtension.NativeFieldInfoPtr_cTypeAccessModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (cTypeAccessModifier));
    ArticyTextExtension.NativeFieldInfoPtr_sUserMethodMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (sUserMethodMap));
    ArticyTextExtension.NativeMethodInfoPtr_get_LastRandomResults_Public_Static_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663913);
    ArticyTextExtension.NativeMethodInfoPtr_set_LastRandomResults_Private_Static_set_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663914);
    ArticyTextExtension.NativeMethodInfoPtr_Resolve_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663915);
    ArticyTextExtension.NativeMethodInfoPtr_Resolve_Public_Static_String_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663916);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveAdvance_Public_Static_String_Func_2_ArticyTextToken_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663917);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveAdvance_Public_Static_String_Object_Func_2_ArticyTextToken_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663918);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveToken_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663919);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveToken_Public_Static_String_ArticyTextToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663920 /*0x06000270*/);
    ArticyTextExtension.NativeMethodInfoPtr_AddUserMethod_Public_Static_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663921);
    ArticyTextExtension.NativeMethodInfoPtr_AddUserMethod_Public_Static_Void_String_Func_3_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663922);
    ArticyTextExtension.NativeMethodInfoPtr_RemoveUserMethod_Public_Static_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663923);
    ArticyTextExtension.NativeMethodInfoPtr_RemoveUserMethod_Public_Static_Void_String_Func_3_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663924);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveInternal_Internal_Static_String_Object_Func_2_ArticyTextToken_String_List_1_TextExtensionResolvedToken_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663925);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveTokenInternal_Private_Static_TextExtensionResolvedToken_String_ArticyTextToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663926);
    ArticyTextExtension.NativeMethodInfoPtr_TokenValueToString_Private_Static_String_String_Object_String_TextExtensionPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663927);
    ArticyTextExtension.NativeMethodInfoPtr_ResolveFormatRecursively_Private_Static_Void_byref_String_Il2CppReferenceArray_1_Object_ArticyTextToken_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663928);
    ArticyTextExtension.NativeMethodInfoPtr_TryExtractSuffix_Private_Static_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663929);
    ArticyTextExtension.NativeMethodInfoPtr_CloneOrGetFromEditTimeSafe_Private_Static_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663930);
    ArticyTextExtension.NativeMethodInfoPtr_CloneOrGetFromEditTimeSafe_Private_Static_ArticyObject_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, 100663931);
  }

  public static unsafe List<int> LastRandomResults
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992068, XrefRangeEnd = 992072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_get_LastRandomResults_Public_Static_get_List_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992072, XrefRangeEnd = 992076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_set_LastRandomResults_Private_Static_set_Void_List_1_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 992083, RefRangeEnd = 992085, XrefRangeStart = 992076, XrefRangeEnd = 992083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Resolve(string aString, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_Resolve_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 992089, RefRangeEnd = 992092, XrefRangeStart = 992085, XrefRangeEnd = 992089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Resolve(
    Il2CppSystem.Object aContextObject,
    string aString,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aContextObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_Resolve_Public_Static_String_Object_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992092, XrefRangeEnd = 992096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ResolveAdvance(
    Il2CppSystem.Func<ArticyTextToken, string> aCallback,
    string aString,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveAdvance_Public_Static_String_Func_2_ArticyTextToken_String_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992096, XrefRangeEnd = 992100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ResolveAdvance(
    Il2CppSystem.Object aContextObject,
    Il2CppSystem.Func<ArticyTextToken, string> aCallback,
    string aString,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aContextObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveAdvance_Public_Static_String_Object_Func_2_ArticyTextToken_String_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992100, XrefRangeEnd = 992107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ResolveToken(string aToken)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aToken)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveToken_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992107, XrefRangeEnd = 992111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ResolveToken(ArticyTextToken aToken)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aToken))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveToken_Public_Static_String_ArticyTextToken_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992111, XrefRangeEnd = 992133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddUserMethod(
    Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> aFunc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_AddUserMethod_Public_Static_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992133, XrefRangeEnd = 992145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddUserMethod(
    string aName,
    Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> aFunc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_AddUserMethod_Public_Static_Void_String_Func_3_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992145, XrefRangeEnd = 992151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveUserMethod(
    Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> aFunc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_RemoveUserMethod_Public_Static_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 992175, RefRangeEnd = 992176, XrefRangeStart = 992151, XrefRangeEnd = 992175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveUserMethod(
    string aName,
    Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> aFunc = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_RemoveUserMethod_Public_Static_Void_String_Func_3_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 992266, RefRangeEnd = 992271, XrefRangeStart = 992176, XrefRangeEnd = 992266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ResolveInternal(
    Il2CppSystem.Object aContextObject,
    Il2CppSystem.Func<ArticyTextToken, string> aCallback,
    List<TextExtensionResolvedToken> aOutResolvedTokens,
    string aString,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aContextObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOutResolvedTokens);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveInternal_Internal_Static_String_Object_Func_2_ArticyTextToken_String_List_1_TextExtensionResolvedToken_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 992850, RefRangeEnd = 992853, XrefRangeStart = 992271, XrefRangeEnd = 992850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TextExtensionResolvedToken ResolveTokenInternal(
    string aToken,
    ArticyTextToken aUser = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aToken);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aUser));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveTokenInternal_Private_Static_TextExtensionResolvedToken_String_ArticyTextToken_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (TextExtensionResolvedToken) null : Il2CppObjectPool.Get<TextExtensionResolvedToken>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 992914, RefRangeEnd = 992917, XrefRangeStart = 992853, XrefRangeEnd = 992914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string TokenValueToString(
    string aToken,
    Il2CppSystem.Object aValue,
    string aFormatSpecifier = null,
    TextExtensionPropertyInfo propInfo = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aToken);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFormatSpecifier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) propInfo);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_TokenValueToString_Private_Static_String_String_Object_String_TextExtensionPropertyInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 992941, RefRangeEnd = 992943, XrefRangeStart = 992917, XrefRangeEnd = 992941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResolveFormatRecursively(
    ref string aString,
    Il2CppReferenceArray<Il2CppSystem.Object> aParams,
    ArticyTextToken aUser,
    string aPreviousString = "",
    int aLoopCounter = 0)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(aString);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aUser));
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPreviousString);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aLoopCounter;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_ResolveFormatRecursively_Private_Static_Void_byref_String_Il2CppReferenceArray_1_Object_ArticyTextToken_String_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    aString = IL2CPP.Il2CppStringToManaged(il2Cpp);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 992952, RefRangeEnd = 992953, XrefRangeStart = 992943, XrefRangeEnd = 992952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryExtractSuffix(ref string aTarget, out string aSuffix)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(aTarget);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr4;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_TryExtractSuffix_Private_Static_Boolean_byref_String_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    aTarget = IL2CPP.Il2CppStringToManaged(il2Cpp);
    aSuffix = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 992984, RefRangeEnd = 992985, XrefRangeStart = 992953, XrefRangeEnd = 992984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneOrGetFromEditTimeSafe(
    string aTechnicalName,
    uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_CloneOrGetFromEditTimeSafe_Private_Static_ArticyObject_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 993018, RefRangeEnd = 993019, XrefRangeStart = 992985, XrefRangeEnd = 993018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneOrGetFromEditTimeSafe(ulong aId, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.NativeMethodInfoPtr_CloneOrGetFromEditTimeSafe_Private_Static_ArticyObject_UInt64_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  public static string Resolve(string aString, params Il2CppSystem.Object[] aParams)
  {
    return ArticyTextExtension.Resolve(aString, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static string Resolve(Il2CppSystem.Object aContextObject, string aString, params Il2CppSystem.Object[] aParams)
  {
    return ArticyTextExtension.Resolve(aContextObject, aString, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static string ResolveAdvance(
    Il2CppSystem.Func<ArticyTextToken, string> aCallback,
    string aString,
    params Il2CppSystem.Object[] aParams)
  {
    return ArticyTextExtension.ResolveAdvance(aCallback, aString, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static string ResolveAdvance(
    Il2CppSystem.Object aContextObject,
    Il2CppSystem.Func<ArticyTextToken, string> aCallback,
    string aString,
    params Il2CppSystem.Object[] aParams)
  {
    return ArticyTextExtension.ResolveAdvance(aContextObject, aCallback, aString, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static string ResolveInternal(
    Il2CppSystem.Object aContextObject,
    Il2CppSystem.Func<ArticyTextToken, string> aCallback,
    List<TextExtensionResolvedToken> aOutResolvedTokens,
    string aString,
    params Il2CppSystem.Object[] aParams)
  {
    return ArticyTextExtension.ResolveInternal(aContextObject, aCallback, aOutResolvedTokens, aString, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public ArticyTextExtension(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<int> _LastRandomResults_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr__LastRandomResults_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr__LastRandomResults_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe char cCharTokenStart
  {
    get
    {
      char cCharTokenStart;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cCharTokenStart, (void*) &cCharTokenStart);
      return cCharTokenStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cCharTokenStart, (void*) &value);
    }
  }

  public static unsafe char cCharTokenEnd
  {
    get
    {
      char cCharTokenEnd;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cCharTokenEnd, (void*) &cCharTokenEnd);
      return cCharTokenEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cCharTokenEnd, (void*) &value);
    }
  }

  public static unsafe char cCharTokenEscape
  {
    get
    {
      char cCharTokenEscape;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cCharTokenEscape, (void*) &cCharTokenEscape);
      return cCharTokenEscape;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cCharTokenEscape, (void*) &value);
    }
  }

  public static unsafe char cCharSuffixStart
  {
    get
    {
      char cCharSuffixStart;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cCharSuffixStart, (void*) &cCharSuffixStart);
      return cCharSuffixStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cCharSuffixStart, (void*) &value);
    }
  }

  public static unsafe char cCharSuffixEnd
  {
    get
    {
      char cCharSuffixEnd;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cCharSuffixEnd, (void*) &cCharSuffixEnd);
      return cCharSuffixEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cCharSuffixEnd, (void*) &value);
    }
  }

  public static unsafe string cSuffixRandomIndex
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cSuffixRandomIndex, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cSuffixRandomIndex, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string cSuffixLastIndex
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cSuffixLastIndex, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cSuffixLastIndex, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string cLocaKeyVariableConstantsBool
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cLocaKeyVariableConstantsBool, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cLocaKeyVariableConstantsBool, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string cTypeAccessModifier
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_cTypeAccessModifier, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_cTypeAccessModifier, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe Dictionary<string, ArticyTextExtension.WeakDelegate> sUserMethodMap
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.NativeFieldInfoPtr_sUserMethodMap, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<string, ArticyTextExtension.WeakDelegate>) null : Il2CppObjectPool.Get<Dictionary<string, ArticyTextExtension.WeakDelegate>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.NativeFieldInfoPtr_sUserMethodMap, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class WeakDelegate(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sGetMethodInfoMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_sCreateDelegateMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_sActionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_sGetMethodInfoFunc;
    private static readonly System.IntPtr NativeFieldInfoPtr_sCreateDelegateFunc;
    private static readonly System.IntPtr NativeFieldInfoPtr_mReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_mMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_mMethodInfo;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Boolean_ArticyTextToken_Il2CppStringArray_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Func_3_ArticyTextToken_Il2CppStringArray_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0;

    static WeakDelegate()
    {
      Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyTextExtension>.NativeClassPtr, nameof (WeakDelegate));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (sGetMethodInfoMethod));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (sCreateDelegateMethod));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (sActionType));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (sGetMethodInfoFunc));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (sCreateDelegateFunc));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (mReference));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (mMethod));
      ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, nameof (mMethodInfo));
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663934);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663935);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663936 /*0x06000280*/);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663937);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Boolean_ArticyTextToken_Il2CppStringArray_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663938);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663939);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Func_3_ArticyTextToken_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663940);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663941);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663942);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663943);
      ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr, 100663944);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991993, XrefRangeEnd = 991995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object aOther)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOther)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 991998, RefRangeEnd = 992001, XrefRangeStart = 991995, XrefRangeEnd = 991998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WeakDelegate(
      Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> aStrongReferenceAction)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTextExtension.WeakDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStrongReferenceAction)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Func_3_ArticyTextToken_Il2CppStringArray_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool IsAlive
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 992019, RefRangeEnd = 992020, XrefRangeStart = 992001, XrefRangeEnd = 992019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Invoke(
      ArticyTextToken aToken,
      Il2CppStringArray aArgs,
      out string aOutResult)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aToken));
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Boolean_ArticyTextToken_Il2CppStringArray_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      aOutResult = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992020, XrefRangeEnd = 992025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> CreateDelegate(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992025, XrefRangeEnd = 992030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfo(
      Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Func_3_ArticyTextToken_Il2CppStringArray_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992030, XrefRangeEnd = 992037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> CreateDelegateNormal(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfoNormal(Il2CppSystem.Delegate aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992037, XrefRangeEnd = 992057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> CreateDelegateUwp(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Func_3_ArticyTextToken_Il2CppStringArray_String_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992057, XrefRangeEnd = 992068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfoUwp(Il2CppSystem.Delegate aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTextExtension.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    public static unsafe MethodInfo sGetMethodInfoMethod
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MethodInfo sCreateDelegateMethod
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Type sActionType
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sActionType, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sActionType, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo> sGetMethodInfoFunc
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>> sCreateDelegateFunc
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.WeakReference mReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mReference));
        return num == System.IntPtr.Zero ? (Il2CppSystem.WeakReference) null : Il2CppObjectPool.Get<Il2CppSystem.WeakReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string> mMethod
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mMethod));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyTextToken, Il2CppStringArray, string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mMethod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MethodInfo mMethodInfo
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mMethodInfo));
        return num == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextExtension.WeakDelegate.NativeFieldInfoPtr_mMethodInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
