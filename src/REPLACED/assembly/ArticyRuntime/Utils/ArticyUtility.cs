// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Utils.ArticyUtility
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
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity.Utils;

public static class ArticyUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Aliases;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreate_Public_Static_TValue_IDictionary_2_TKey_TValue_TKey_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Union_Public_Static_Rect_Rect_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBounds_Public_Static_Rect_IEnumerable_1_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToSpriteSourceRect_Public_Static_Rect_Texture2D_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToHex_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToHex_Public_Static_String_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToHex_Public_Static_String_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromHex_Public_Static_UInt64_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SplitToLines_Public_Static_IEnumerable_1_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAlias_Internal_Static_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToFilename_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToFilename_Public_Static_String_String_String_String_String_0;

  static ArticyUtility()
  {
    Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Utils", nameof (ArticyUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr);
    ArticyUtility.NativeFieldInfoPtr_Aliases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, nameof (Aliases));
    ArticyUtility.NativeMethodInfoPtr_GetOrCreate_Public_Static_TValue_IDictionary_2_TKey_TValue_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664386);
    ArticyUtility.NativeMethodInfoPtr_Union_Public_Static_Rect_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664387);
    ArticyUtility.NativeMethodInfoPtr_GetBounds_Public_Static_Rect_IEnumerable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664388);
    ArticyUtility.NativeMethodInfoPtr_ConvertToSpriteSourceRect_Public_Static_Rect_Texture2D_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664389);
    ArticyUtility.NativeMethodInfoPtr_ToHex_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664390);
    ArticyUtility.NativeMethodInfoPtr_ToHex_Public_Static_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664391);
    ArticyUtility.NativeMethodInfoPtr_ToHex_Public_Static_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664392);
    ArticyUtility.NativeMethodInfoPtr_FromHex_Public_Static_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664393);
    ArticyUtility.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664394);
    ArticyUtility.NativeMethodInfoPtr_SplitToLines_Public_Static_IEnumerable_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664395);
    ArticyUtility.NativeMethodInfoPtr_GetAlias_Internal_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664396);
    ArticyUtility.NativeMethodInfoPtr_ToFilename_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664397);
    ArticyUtility.NativeMethodInfoPtr_ToFilename_Public_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, 100664398);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 999133, RefRangeEnd = 999134, XrefRangeStart = 999127, XrefRangeEnd = 999133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TValue GetOrCreate<TKey, TValue>(
    this IDictionary<TKey, TValue> dict,
    TKey key)
    where TValue : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dict);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TKey& local1;
    if (!typeof (TKey).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TKey> local2 = (object) key;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref key;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.MethodInfoStoreGeneric_GetOrCreate_Public_Static_TValue_IDictionary_2_TKey_TValue_TKey_0<TKey, TValue>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return IL2CPP.PointerToValueGeneric<TValue>(num3, false, true);
  }

  [CallerCount(0)]
  public static unsafe Rect Union(Rect a, Rect b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_Union_Public_Static_Rect_Rect_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999134, XrefRangeEnd = 999152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Rect GetBounds(IEnumerable<Vector2> aVertices)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVertices)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_GetBounds_Public_Static_Rect_IEnumerable_1_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Rect ConvertToSpriteSourceRect(Texture2D aTexture, Rect aArticyClipRect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTexture);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aArticyClipRect;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_ConvertToSpriteSourceRect_Public_Static_Rect_Texture2D_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999152, XrefRangeEnd = 999157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToHex(this int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_ToHex_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999157, XrefRangeEnd = 999162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToHex(this long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_ToHex_Public_Static_String_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 999167, RefRangeEnd = 999181, XrefRangeStart = 999162, XrefRangeEnd = 999167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToHex(this ulong value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_ToHex_Public_Static_String_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 999183, RefRangeEnd = 999186, XrefRangeStart = 999181, XrefRangeEnd = 999183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ulong FromHex(this string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_FromHex_Public_Static_UInt64_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999186, XrefRangeEnd = 999191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsNullOrWhiteSpace(this string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999191, XrefRangeEnd = 999196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerable<string> SplitToLines(this string input)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(input)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_SplitToLines_Public_Static_IEnumerable_1_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerable<string>) null : Il2CppObjectPool.Get<IEnumerable<string>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999196, XrefRangeEnd = 999203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetAlias(Il2CppSystem.Type aType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aType)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_GetAlias_Internal_Static_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999203, XrefRangeEnd = 999226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToFilename(string pDisplayName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(pDisplayName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_ToFilename_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999226, XrefRangeEnd = 999243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToFilename(
    string aDisplayName,
    string aForbiddenChars,
    string aForbiddenCharReplacement,
    string aSpaceReplacement)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aDisplayName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aForbiddenChars);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aForbiddenCharReplacement);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aSpaceReplacement);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility.NativeMethodInfoPtr_ToFilename_Public_Static_String_String_String_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public ArticyUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<Il2CppSystem.Type, string> Aliases
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyUtility.NativeFieldInfoPtr_Aliases, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, string>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyUtility.NativeFieldInfoPtr_Aliases, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.Utils.ArticyUtility+<SplitToLines>d__9")]
  public sealed class _SplitToLines_d__9(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
    private static readonly System.IntPtr NativeFieldInfoPtr_input;
    private static readonly System.IntPtr NativeFieldInfoPtr___3__input;
    private static readonly System.IntPtr NativeFieldInfoPtr__reader_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

    static _SplitToLines_d__9()
    {
      Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr, "<SplitToLines>d__9");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr);
      ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, "<>1__state");
      ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, "<>2__current");
      ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, "<>l__initialThreadId");
      ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, nameof (input));
      ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___3__input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, "<>3__input");
      ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr__reader_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, "<reader>5__2");
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664400 /*0x06000450*/);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664401);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664402);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664403);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664404);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664405);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664406);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664407);
      ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr, 100664408);
    }

    [CallerCount(81)]
    [CachedScanResults(RefRangeStart = 69433, RefRangeEnd = 69514, XrefRangeStart = 69433, XrefRangeEnd = 69514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SplitToLines_d__9(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyUtility._SplitToLines_d__9>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999095, XrefRangeEnd = 999100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999100, XrefRangeEnd = 999112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999112, XrefRangeEnd = 999115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe string System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EString\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_String__get_Current_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999115, XrefRangeEnd = 999120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999120, XrefRangeEnd = 999127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_String__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator<string>) null : Il2CppObjectPool.Get<IEnumerator<string>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyUtility._SplitToLines_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe string __2__current
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___2__current)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___2__current), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int __l__initialThreadId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___l__initialThreadId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
      }
    }

    public unsafe string input
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr_input)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr_input), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string __3__input
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___3__input)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr___3__input), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe StringReader _reader_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr__reader_5__2));
        return num == System.IntPtr.Zero ? (StringReader) null : Il2CppObjectPool.Get<StringReader>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyUtility._SplitToLines_d__9.NativeFieldInfoPtr__reader_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetOrCreate_Public_Static_TValue_IDictionary_2_TKey_TValue_TKey_0<TKey, TValue>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyUtility.NativeMethodInfoPtr_GetOrCreate_Public_Static_TValue_IDictionary_2_TKey_TValue_TKey_0, Il2CppClassPointerStore<ArticyUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
    }))));
  }
}
