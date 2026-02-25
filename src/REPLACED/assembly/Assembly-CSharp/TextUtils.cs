// Decompiled with JetBrains decompiler
// Type: TextUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public static class TextUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_attributeRegexPattern;
  private static readonly System.IntPtr NativeFieldInfoPtr_delayBetweenChars;
  private static readonly System.IntPtr NativeFieldInfoPtr_delayAfterPunctuation;
  private static readonly System.IntPtr NativeFieldInfoPtr_charPunctuation;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCharPunctuation_Public_Static_Boolean_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CleanText_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TextTiming_Public_Static_Void_String_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TextTiming_Public_Static_Void_String_byref_Single_byref_List_1_ValueTuple_2_Int32_Single_0;

  static TextUtils()
  {
    Il2CppClassPointerStore<TextUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TextUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextUtils>.NativeClassPtr);
    TextUtils.NativeFieldInfoPtr_attributeRegexPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, nameof (attributeRegexPattern));
    TextUtils.NativeFieldInfoPtr_delayBetweenChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, nameof (delayBetweenChars));
    TextUtils.NativeFieldInfoPtr_delayAfterPunctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, nameof (delayAfterPunctuation));
    TextUtils.NativeFieldInfoPtr_charPunctuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, nameof (charPunctuation));
    TextUtils.NativeMethodInfoPtr_IsCharPunctuation_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, 100663741);
    TextUtils.NativeMethodInfoPtr_CleanText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, 100663742);
    TextUtils.NativeMethodInfoPtr_TextTiming_Public_Static_Void_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, 100663743);
    TextUtils.NativeMethodInfoPtr_TextTiming_Public_Static_Void_String_byref_Single_byref_List_1_ValueTuple_2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtils>.NativeClassPtr, 100663744 /*0x060001C0*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22461, RefRangeEnd = 22463, XrefRangeStart = 22453, XrefRangeEnd = 22461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCharPunctuation(char c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextUtils.NativeMethodInfoPtr_IsCharPunctuation_Public_Static_Boolean_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22472, RefRangeEnd = 22474, XrefRangeStart = 22463, XrefRangeEnd = 22472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string CleanText(string text)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextUtils.NativeMethodInfoPtr_CleanText_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22487, RefRangeEnd = 22489, XrefRangeStart = 22474, XrefRangeEnd = 22487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TextTiming(string cleanText, out float totalTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(cleanText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextUtils.NativeMethodInfoPtr_TextTiming_Public_Static_Void_String_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22489, XrefRangeEnd = 22509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TextTiming(
    string cleanText,
    out float totalTime,
    ref List<Il2CppSystem.ValueTuple<int, float>> textTiming)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(cleanText);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref totalTime;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) textTiming);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(TextUtils.NativeMethodInfoPtr_TextTiming_Public_Static_Void_String_byref_Single_byref_List_1_ValueTuple_2_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref List<Il2CppSystem.ValueTuple<int, float>> local = ref textTiming;
    System.IntPtr pointer = ptr;
    List<Il2CppSystem.ValueTuple<int, float>> list = pointer == System.IntPtr.Zero ? (List<Il2CppSystem.ValueTuple<int, float>>) null : new List<Il2CppSystem.ValueTuple<int, float>>(pointer);
    local = list;
  }

  public TextUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string attributeRegexPattern
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(TextUtils.NativeFieldInfoPtr_attributeRegexPattern, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TextUtils.NativeFieldInfoPtr_attributeRegexPattern, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe float delayBetweenChars
  {
    get
    {
      float delayBetweenChars;
      IL2CPP.il2cpp_field_static_get_value(TextUtils.NativeFieldInfoPtr_delayBetweenChars, (void*) &delayBetweenChars);
      return delayBetweenChars;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TextUtils.NativeFieldInfoPtr_delayBetweenChars, (void*) &value);
    }
  }

  public static unsafe float delayAfterPunctuation
  {
    get
    {
      float afterPunctuation;
      IL2CPP.il2cpp_field_static_get_value(TextUtils.NativeFieldInfoPtr_delayAfterPunctuation, (void*) &afterPunctuation);
      return afterPunctuation;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TextUtils.NativeFieldInfoPtr_delayAfterPunctuation, (void*) &value);
    }
  }

  public static unsafe List<char> charPunctuation
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(TextUtils.NativeFieldInfoPtr_charPunctuation, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<char>) null : Il2CppObjectPool.Get<List<char>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TextUtils.NativeFieldInfoPtr_charPunctuation, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
