// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Utils.StringUtils
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using Il2CppSystem.Text.RegularExpressions;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Utils;

public static class StringUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_HEX_VALUES;
  private static readonly System.IntPtr NativeFieldInfoPtr_EMAIL_SEPARATOR;
  private static readonly System.IntPtr NativeFieldInfoPtr_sTokenChars;
  private static readonly System.IntPtr NativeFieldInfoPtr_sPasswordChars;
  private static readonly System.IntPtr NativeFieldInfoPtr_sNumberChars;
  private static readonly System.IntPtr NativeFieldInfoPtr_CRLF;
  private static readonly System.IntPtr NativeFieldInfoPtr_LFCR;
  private static readonly System.IntPtr NativeFieldInfoPtr_sTechnicalName;
  private static readonly System.IntPtr NativeFieldInfoPtr_sHexRegex;
  private static readonly System.IntPtr NativeFieldInfoPtr_sNormalizeWhitespace;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasWhiteSpace_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Truncate_Public_Static_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeWhitespace_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValueOrEmpty_Public_Static_Boolean_String_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AsUtf8Bytes_Public_Static_Il2CppStructArray_1_Byte_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidHexString_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HexStringToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HexStringToByteArray_Public_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToFourCC_Public_Static_UInt32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CountSubstrings_Public_Static_Int32_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FillString_Public_Static_String_Char_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QuotedSqlEscape_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SqlEscape_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QuotedEscape_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QuotedEscape_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLastNamePart_Public_Static_String_String_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNameFromFullClassName_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNamespaceFromFullClassName_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCsvString_Public_Static_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCsvString_Public_Static_String_Char_Char_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_String_Char_Char_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_Char_Char_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DetectCsvSeparator_Public_Static_Char_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAsStream_Public_Static_Stream_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAsStream_Public_Static_Stream_String_Encoding_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_Encoding_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoinList_Public_Static_String_IList_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JoinList_Public_Static_String_IList_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CarmelizeName_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRandomToken_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRandomString_Public_Static_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LimitString_Public_Static_String_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidString_Public_Static_Boolean_String_String_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidManagedClassName_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidManagedFullClassName_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_StringSplitOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_TrimmingType_CleanupType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveQuoteMarks_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToDisplayName_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EscapeString_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnescapeString_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AsBoolean_Public_Static_Boolean_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToHumanReadableSize_Public_Static_String_Double_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NaturalStringCompare_Public_Static_Int32_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NaturalStringCompare_Public_Static_Int32_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareNum_Private_Static_Int32_String_byref_Int32_String_byref_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScanNumEnd_Private_Static_Void_String_Int32_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRegexFromWildcard_Public_Static_Regex_String_RegexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateRegexPatternFromWildcard_Public_Static_String_String_0;

  static StringUtils()
  {
    Il2CppClassPointerStore<StringUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Utils", nameof (StringUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringUtils>.NativeClassPtr);
    StringUtils.NativeFieldInfoPtr_HEX_VALUES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (HEX_VALUES));
    StringUtils.NativeFieldInfoPtr_EMAIL_SEPARATOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (EMAIL_SEPARATOR));
    StringUtils.NativeFieldInfoPtr_sTokenChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (sTokenChars));
    StringUtils.NativeFieldInfoPtr_sPasswordChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (sPasswordChars));
    StringUtils.NativeFieldInfoPtr_sNumberChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (sNumberChars));
    StringUtils.NativeFieldInfoPtr_CRLF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (CRLF));
    StringUtils.NativeFieldInfoPtr_LFCR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (LFCR));
    StringUtils.NativeFieldInfoPtr_sTechnicalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (sTechnicalName));
    StringUtils.NativeFieldInfoPtr_sHexRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (sHexRegex));
    StringUtils.NativeFieldInfoPtr_sNormalizeWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, nameof (sNormalizeWhitespace));
    StringUtils.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664323 /*0x06000403*/);
    StringUtils.NativeMethodInfoPtr_HasWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664324 /*0x06000404*/);
    StringUtils.NativeMethodInfoPtr_Truncate_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664325 /*0x06000405*/);
    StringUtils.NativeMethodInfoPtr_NormalizeWhitespace_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664326 /*0x06000406*/);
    StringUtils.NativeMethodInfoPtr_IsValueOrEmpty_Public_Static_Boolean_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664327 /*0x06000407*/);
    StringUtils.NativeMethodInfoPtr_AsUtf8Bytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664328 /*0x06000408*/);
    StringUtils.NativeMethodInfoPtr_IsValidHexString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664329 /*0x06000409*/);
    StringUtils.NativeMethodInfoPtr_HexStringToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664330 /*0x0600040A*/);
    StringUtils.NativeMethodInfoPtr_HexStringToByteArray_Public_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664331 /*0x0600040B*/);
    StringUtils.NativeMethodInfoPtr_ToFourCC_Public_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664332 /*0x0600040C*/);
    StringUtils.NativeMethodInfoPtr_CountSubstrings_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664333 /*0x0600040D*/);
    StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664334 /*0x0600040E*/);
    StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664335 /*0x0600040F*/);
    StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664336 /*0x06000410*/);
    StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664337);
    StringUtils.NativeMethodInfoPtr_FillString_Public_Static_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664338);
    StringUtils.NativeMethodInfoPtr_QuotedSqlEscape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664339);
    StringUtils.NativeMethodInfoPtr_SqlEscape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664340);
    StringUtils.NativeMethodInfoPtr_QuotedEscape_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664341);
    StringUtils.NativeMethodInfoPtr_QuotedEscape_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664342);
    StringUtils.NativeMethodInfoPtr_GetLastNamePart_Public_Static_String_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664343);
    StringUtils.NativeMethodInfoPtr_GetNameFromFullClassName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664344);
    StringUtils.NativeMethodInfoPtr_GetNamespaceFromFullClassName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664345);
    StringUtils.NativeMethodInfoPtr_MakeCsvString_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664346);
    StringUtils.NativeMethodInfoPtr_MakeCsvString_Public_Static_String_Char_Char_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664347);
    StringUtils.NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664348);
    StringUtils.NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_String_Char_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664349);
    StringUtils.NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_Char_Char_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664350);
    StringUtils.NativeMethodInfoPtr_DetectCsvSeparator_Public_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664351);
    StringUtils.NativeMethodInfoPtr_GetAsStream_Public_Static_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664352 /*0x06000420*/);
    StringUtils.NativeMethodInfoPtr_GetAsStream_Public_Static_Stream_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664353);
    StringUtils.NativeMethodInfoPtr_ToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664354);
    StringUtils.NativeMethodInfoPtr_ToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664355);
    StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664356);
    StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664357);
    StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664358);
    StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664359);
    StringUtils.NativeMethodInfoPtr_JoinList_Public_Static_String_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664360);
    StringUtils.NativeMethodInfoPtr_JoinList_Public_Static_String_IList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664361);
    StringUtils.NativeMethodInfoPtr_CarmelizeName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664362);
    StringUtils.NativeMethodInfoPtr_CreateRandomToken_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664363);
    StringUtils.NativeMethodInfoPtr_CreateRandomString_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664364);
    StringUtils.NativeMethodInfoPtr_LimitString_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664365);
    StringUtils.NativeMethodInfoPtr_IsValidString_Public_Static_Boolean_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664366);
    StringUtils.NativeMethodInfoPtr_IsValidManagedClassName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664367);
    StringUtils.NativeMethodInfoPtr_IsValidManagedFullClassName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664368 /*0x06000430*/);
    StringUtils.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664369);
    StringUtils.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664370);
    StringUtils.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_TrimmingType_CleanupType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664371);
    StringUtils.NativeMethodInfoPtr_RemoveQuoteMarks_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664372);
    StringUtils.NativeMethodInfoPtr_ToDisplayName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664373);
    StringUtils.NativeMethodInfoPtr_EscapeString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664374);
    StringUtils.NativeMethodInfoPtr_UnescapeString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664375);
    StringUtils.NativeMethodInfoPtr_AsBoolean_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664376);
    StringUtils.NativeMethodInfoPtr_ToHumanReadableSize_Public_Static_String_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664377);
    StringUtils.NativeMethodInfoPtr_NaturalStringCompare_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664378);
    StringUtils.NativeMethodInfoPtr_NaturalStringCompare_Public_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664379);
    StringUtils.NativeMethodInfoPtr_CompareNum_Private_Static_Int32_String_byref_Int32_String_byref_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664380);
    StringUtils.NativeMethodInfoPtr_ScanNumEnd_Private_Static_Void_String_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664381);
    StringUtils.NativeMethodInfoPtr_CreateRegexFromWildcard_Public_Static_Regex_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664382);
    StringUtils.NativeMethodInfoPtr_CreateRegexPatternFromWildcard_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664383);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 998424, RefRangeEnd = 998440, XrefRangeStart = 998423, XrefRangeEnd = 998424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsNullOrEmpty(this string aString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998440, XrefRangeEnd = 998455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasWhiteSpace(this string aString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_HasWhiteSpace_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998455, XrefRangeEnd = 998456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Truncate(this string value, int maxChars)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxChars;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_Truncate_Public_Static_String_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998456, XrefRangeEnd = 998463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NormalizeWhitespace(this string aString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NormalizeWhitespace_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998463, XrefRangeEnd = 998467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValueOrEmpty(this string aInput, [Optional] Il2CppStringArray aValues)
  {
    if (aValues == null)
      aValues = new Il2CppStringArray(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aInput);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValues);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsValueOrEmpty_Public_Static_Boolean_String_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998467, XrefRangeEnd = 998468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> AsUtf8Bytes(this string aInput)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aInput)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_AsUtf8Bytes_Public_Static_Il2CppStructArray_1_Byte_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998468, XrefRangeEnd = 998473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidHexString(this string pHexStringToCheck)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pHexStringToCheck)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsValidHexString_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998473, XrefRangeEnd = 998480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> HexStringToByteArray(this string aString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_HexStringToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998486, RefRangeEnd = 998487, XrefRangeStart = 998480, XrefRangeEnd = 998486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void HexStringToByteArray(
    this string aString,
    Il2CppStructArray<byte> aOutputData,
    int aOffset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOutputData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aOffset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_HexStringToByteArray_Public_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998487, XrefRangeEnd = 998488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint ToFourCC(this string pString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToFourCC_Public_Static_UInt32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998488, XrefRangeEnd = 998490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CountSubstrings(this string aString, string aSubstring)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aSubstring);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CountSubstrings_Public_Static_Int32_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998490, XrefRangeEnd = 998495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string BytesToHexString(Il2CppStructArray<byte> aData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aData)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998495, XrefRangeEnd = 998500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string BytesToHexString(Il2CppStructArray<byte> aData, int aOffset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aOffset;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998522, RefRangeEnd = 998524, XrefRangeStart = 998500, XrefRangeEnd = 998522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string BytesToHexString(
    Il2CppStructArray<byte> aData,
    int aOffset,
    int aLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998524, XrefRangeEnd = 998541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string BytesToHexString(
    Il2CppStructArray<byte> aData,
    int aOffset,
    int aLength,
    string aSeparator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aOffset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aSeparator);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_BytesToHexString_Public_Static_String_Il2CppStructArray_1_Byte_Int32_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998541, XrefRangeEnd = 998548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FillString(char pChar, int pCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pChar;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_FillString_Public_Static_String_Char_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998548, XrefRangeEnd = 998561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string QuotedSqlEscape(this string pValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pValue)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_QuotedSqlEscape_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998561, XrefRangeEnd = 998567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string SqlEscape(this string pValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pValue)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_SqlEscape_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998567, XrefRangeEnd = 998573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string QuotedEscape(this string pValue, string pQuoteChar)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pQuoteChar);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_QuotedEscape_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998573, XrefRangeEnd = 998584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string QuotedEscape(this string pValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pValue)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_QuotedEscape_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998584, XrefRangeEnd = 998585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetLastNamePart(this string pName, char pSeparatorChar)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pSeparatorChar;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_GetLastNamePart_Public_Static_String_String_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998585, XrefRangeEnd = 998589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetNameFromFullClassName(this string pFullQualifiedName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pFullQualifiedName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_GetNameFromFullClassName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998589, XrefRangeEnd = 998595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetNamespaceFromFullClassName(this string aFullQualifiedName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aFullQualifiedName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_GetNamespaceFromFullClassName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998595, XrefRangeEnd = 998599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string MakeCsvString([Optional] Il2CppReferenceArray<Il2CppSystem.Object> pFields)
  {
    if (pFields == null)
      pFields = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pFields)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_MakeCsvString_Public_Static_String_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998638, RefRangeEnd = 998639, XrefRangeStart = 998599, XrefRangeEnd = 998638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string MakeCsvString(
    char pSeparator,
    char aStringQuoteChar,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> pFields)
  {
    if (pFields == null)
      pFields = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pSeparator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aStringQuoteChar;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pFields);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_MakeCsvString_Public_Static_String_Char_Char_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998639, XrefRangeEnd = 998643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> ParseCsvString(this string pLine)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pLine)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998647, RefRangeEnd = 998648, XrefRangeStart = 998643, XrefRangeEnd = 998647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> ParseCsvString(
    this string aLine,
    char pSeparator,
    char pStringQuoteChar,
    bool pRemoveWhitespaces = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aLine);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pSeparator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pStringQuoteChar;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pRemoveWhitespaces;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_String_Char_Char_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 998678, RefRangeEnd = 998680, XrefRangeStart = 998648, XrefRangeEnd = 998678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<string> ParseCsvString(
    char pSeparator,
    char pStringQuoteChar,
    string pLine,
    bool pRemoveWhitespaces = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &pSeparator;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pStringQuoteChar;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pLine);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pRemoveWhitespaces;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ParseCsvString_Public_Static_List_1_String_Char_Char_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998680, XrefRangeEnd = 998683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe char DetectCsvSeparator(this string aHeaderLine)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aHeaderLine)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_DetectCsvSeparator_Public_Static_Char_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(char*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998683, XrefRangeEnd = 998688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stream GetAsStream(this string pString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_GetAsStream_Public_Static_Stream_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Stream) null : Il2CppObjectPool.Get<Stream>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998688, XrefRangeEnd = 998689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Stream GetAsStream(this string pString, Encoding pEncoding)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pEncoding);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_GetAsStream_Public_Static_Stream_String_Encoding_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Stream) null : Il2CppObjectPool.Get<Stream>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998689, XrefRangeEnd = 998697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> ToByteArray(this string aString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<byte> ToByteArray(this string aString, Encoding aEncoding)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aEncoding);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToByteArray_Public_Static_Il2CppStructArray_1_Byte_String_Encoding_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998697, XrefRangeEnd = 998703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NormalizeNewLines(this string pText)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pText)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998707, RefRangeEnd = 998708, XrefRangeStart = 998703, XrefRangeEnd = 998707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NormalizeNewLines(this string pText, string pNewLineText)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pNewLineText);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998708, XrefRangeEnd = 998714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NormalizeNewLines(
    this string pText,
    bool pCollapsedConsecutiveMatches)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pCollapsedConsecutiveMatches;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 998741, RefRangeEnd = 998744, XrefRangeStart = 998714, XrefRangeEnd = 998741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string NormalizeNewLines(
    this string pText,
    string pNewLineText,
    bool pCollapsedConsecutiveMatches)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pNewLineText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pCollapsedConsecutiveMatches;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NormalizeNewLines_Public_Static_String_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998744, XrefRangeEnd = 998750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string JoinList(IList pList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pList)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_JoinList_Public_Static_String_IList_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998767, RefRangeEnd = 998768, XrefRangeStart = 998750, XrefRangeEnd = 998767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string JoinList(IList pList, string pDelimiter)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pDelimiter);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_JoinList_Public_Static_String_IList_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998768, XrefRangeEnd = 998783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string CarmelizeName(this string pIdentifier)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pIdentifier)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CarmelizeName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998783, XrefRangeEnd = 998799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string CreateRandomToken(int pLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pLength
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CreateRandomToken_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998799, XrefRangeEnd = 998811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string CreateRandomString(string pCharacters, int pLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pCharacters);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CreateRandomString_Public_Static_String_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998811, XrefRangeEnd = 998813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string LimitString(this string pText, int pMaxLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pMaxLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_LimitString_Public_Static_String_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998813, XrefRangeEnd = 998816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidString(
    this string aText,
    string aCharWhiteList,
    int aMinLength,
    int aMaxLength)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aCharWhiteList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aMinLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aMaxLength;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsValidString_Public_Static_Boolean_String_String_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998816, XrefRangeEnd = 998824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidManagedClassName(this string aName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsValidManagedClassName_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998824, XrefRangeEnd = 998839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidManagedFullClassName(this string aName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_IsValidManagedFullClassName_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998839, XrefRangeEnd = 998846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray SplitAndTrim(this string pText, string pSeparator)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(pText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pSeparator);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998846, XrefRangeEnd = 998850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray SplitAndTrim(
    this string aText,
    string aSeparator,
    Il2CppSystem.StringSplitOptions aSplitOptions)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aSeparator);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aSplitOptions;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_StringSplitOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 998870, RefRangeEnd = 998875, XrefRangeStart = 998850, XrefRangeEnd = 998870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStringArray SplitAndTrim(
    this string aText,
    string aSeparator,
    TrimmingType aTrimming,
    CleanupType aCleanup)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aSeparator);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aTrimming;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aCleanup;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_SplitAndTrim_Public_Static_Il2CppStringArray_String_String_TrimmingType_CleanupType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998882, RefRangeEnd = 998883, XrefRangeStart = 998875, XrefRangeEnd = 998882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string RemoveQuoteMarks(this string aString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_RemoveQuoteMarks_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998883, XrefRangeEnd = 998896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToDisplayName(this string aTechnicalName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToDisplayName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998896, XrefRangeEnd = 998916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string EscapeString(this string aInput)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aInput)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_EscapeString_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998916, XrefRangeEnd = 998938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string UnescapeString(this string aInput)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aInput)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_UnescapeString_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998938, XrefRangeEnd = 998958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AsBoolean(this string aValue, bool aDefault)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aDefault;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_AsBoolean_Public_Static_Boolean_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998958, XrefRangeEnd = 998984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToHumanReadableSize(double size, int unit = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &unit;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ToHumanReadableSize_Public_Static_String_Double_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998984, XrefRangeEnd = 998988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int NaturalStringCompare(string s1, string s2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(s2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NaturalStringCompare_Public_Static_Int32_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 998989, RefRangeEnd = 998990, XrefRangeStart = 998988, XrefRangeEnd = 998989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int NaturalStringCompare(string aText1, string aText2, bool aZeroesFirst)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aText1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aText2);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aZeroesFirst;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_NaturalStringCompare_Public_Static_Int32_String_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998990, XrefRangeEnd = 999016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CompareNum(
    string s1,
    ref int i1,
    string s2,
    ref int i2,
    bool zeroesFirst)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref i1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(s2);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref i2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &zeroesFirst;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CompareNum_Private_Static_Int32_String_byref_Int32_String_byref_Int32_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999016, XrefRangeEnd = 999024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ScanNumEnd(string s, int start, ref int end, ref int nzStart)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref nzStart;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_ScanNumEnd_Private_Static_Void_String_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999032, RefRangeEnd = 999034, XrefRangeStart = 999024, XrefRangeEnd = 999032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Regex CreateRegexFromWildcard(string aWildcardString, RegexOptions aOptions = RegexOptions.IgnoreCase)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aWildcardString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aOptions;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CreateRegexFromWildcard_Public_Static_Regex_String_RegexOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 999061, RefRangeEnd = 999062, XrefRangeStart = 999034, XrefRangeEnd = 999061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string CreateRegexPatternFromWildcard(string aWildcardString)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aWildcardString)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringUtils.NativeMethodInfoPtr_CreateRegexPatternFromWildcard_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static bool IsValueOrEmpty(string aInput, params string[] aValues)
  {
    return aInput.IsValueOrEmpty(new Il2CppStringArray(aValues));
  }

  public static string MakeCsvString(params Il2CppSystem.Object[] pFields)
  {
    return StringUtils.MakeCsvString(new Il2CppReferenceArray<Il2CppSystem.Object>(pFields));
  }

  public static string MakeCsvString(
    char pSeparator,
    char aStringQuoteChar,
    params Il2CppSystem.Object[] pFields)
  {
    return StringUtils.MakeCsvString(pSeparator, aStringQuoteChar, new Il2CppReferenceArray<Il2CppSystem.Object>(pFields));
  }

  public StringUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStructArray<int> HEX_VALUES
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_HEX_VALUES, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : Il2CppObjectPool.Get<Il2CppStructArray<int>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_HEX_VALUES, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<char> EMAIL_SEPARATOR
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_EMAIL_SEPARATOR, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<char>) null : Il2CppObjectPool.Get<Il2CppStructArray<char>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_EMAIL_SEPARATOR, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string sTokenChars
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_sTokenChars, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_sTokenChars, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string sPasswordChars
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_sPasswordChars, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_sPasswordChars, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string sNumberChars
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_sNumberChars, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_sNumberChars, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string CRLF
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_CRLF, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_CRLF, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string LFCR
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_LFCR, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_LFCR, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe Regex sTechnicalName
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_sTechnicalName, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_sTechnicalName, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Regex sHexRegex
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_sHexRegex, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_sHexRegex, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Regex sNormalizeWhitespace
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(StringUtils.NativeFieldInfoPtr_sNormalizeWhitespace, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(StringUtils.NativeFieldInfoPtr_sNormalizeWhitespace, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
