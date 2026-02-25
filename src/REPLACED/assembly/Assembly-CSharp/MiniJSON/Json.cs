// Decompiled with JetBrains decompiler
// Type: MiniJSON.Json
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;

#nullable disable
namespace MiniJSON;

public static class Json : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;

  static Json()
  {
    Il2CppClassPointerStore<Json>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MiniJSON", nameof (Json));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json>.NativeClassPtr);
    Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100670582);
    Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json>.NativeClassPtr, 100670583);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86606, XrefRangeEnd = 86607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object Deserialize(string json)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(json)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.NativeMethodInfoPtr_Deserialize_Public_Static_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Serialize(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Json(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public sealed class Parser(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WORD_BREAK;
    private static readonly System.IntPtr NativeFieldInfoPtr_json;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Object_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseValue_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseString_Private_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseNumber_Private_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EatWhitespace_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NextChar_Private_get_Char_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NextWord_Private_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0;

    static Parser()
    {
      Il2CppClassPointerStore<Json.Parser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, nameof (Parser));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr);
      Json.Parser.NativeFieldInfoPtr_WORD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, nameof (WORD_BREAK));
      Json.Parser.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, nameof (json));
      Json.Parser.NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670584);
      Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670585);
      Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670586);
      Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670587);
      Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670588);
      Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670589);
      Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670590);
      Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670591);
      Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670592);
      Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670593);
      Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670594);
      Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670595);
      Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670596);
      Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670597);
      Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr, 100670598);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86271, XrefRangeEnd = 86275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsWordBreak(char c)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &c
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_IsWordBreak_Public_Static_Boolean_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86275, XrefRangeEnd = 86280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Parser(string jsonString)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Parser>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(jsonString)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr__ctor_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 86296, RefRangeEnd = 86297, XrefRangeStart = 86280, XrefRangeEnd = 86296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Object Parse(string jsonString)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(jsonString)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Parse_Public_Static_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86297, XrefRangeEnd = 86298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86298, XrefRangeEnd = 86313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Dictionary<string, Il2CppSystem.Object> ParseObject()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseObject_Private_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86313, XrefRangeEnd = 86325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe List<Il2CppSystem.Object> ParseArray()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseArray_Private_List_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86325, XrefRangeEnd = 86327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object ParseValue()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseValue_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 86342, RefRangeEnd = 86347, XrefRangeStart = 86327, XrefRangeEnd = 86342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object ParseByToken(Json.Parser.TOKEN token)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &token
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseByToken_Private_Object_TOKEN_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 86378, RefRangeEnd = 86380, XrefRangeStart = 86347, XrefRangeEnd = 86378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string ParseString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86380, XrefRangeEnd = 86385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Object ParseNumber()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_ParseNumber_Private_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86385, XrefRangeEnd = 86392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EatWhitespace()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_EatWhitespace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe char PeekChar
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 86397, RefRangeEnd = 86398, XrefRangeStart = 86392, XrefRangeEnd = 86397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_PeekChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(char*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe char NextChar
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 86403, RefRangeEnd = 86406, XrefRangeStart = 86398, XrefRangeEnd = 86403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(char*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe string NextWord
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 86427, RefRangeEnd = 86428, XrefRangeStart = 86406, XrefRangeEnd = 86427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextWord_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
    }

    public unsafe Json.Parser.TOKEN NextToken
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 86439, RefRangeEnd = 86450, XrefRangeStart = 86428, XrefRangeEnd = 86439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Parser.NativeMethodInfoPtr_get_NextToken_Private_get_TOKEN_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Json.Parser.TOKEN*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public static unsafe string WORD_BREAK
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(Json.Parser.NativeFieldInfoPtr_WORD_BREAK, (void*) &num);
        return IL2CPP.Il2CppStringToManaged(num);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Json.Parser.NativeFieldInfoPtr_WORD_BREAK, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe StringReader json
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Json.Parser.NativeFieldInfoPtr_json));
        return num == System.IntPtr.Zero ? (StringReader) null : Il2CppObjectPool.Get<StringReader>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Json.Parser.NativeFieldInfoPtr_json), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum TOKEN
    {
      NONE,
      CURLY_OPEN,
      CURLY_CLOSE,
      SQUARED_OPEN,
      SQUARED_CLOSE,
      COLON,
      COMMA,
      STRING,
      NUMBER,
      TRUE,
      FALSE,
      NULL,
    }
  }

  public sealed class Serializer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_builder;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeString_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0;

    static Serializer()
    {
      Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Json>.NativeClassPtr, nameof (Serializer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr);
      Json.Serializer.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, nameof (builder));
      Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670599);
      Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670600);
      Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670601);
      Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670602);
      Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670603);
      Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670604);
      Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr, 100670605);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86450, XrefRangeEnd = 86455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Serializer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Json.Serializer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86455, XrefRangeEnd = 86465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Serialize(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_Serialize_Public_Static_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 86493, RefRangeEnd = 86497, XrefRangeStart = 86465, XrefRangeEnd = 86493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeValue(Il2CppSystem.Object value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeValue_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 86525, RefRangeEnd = 86526, XrefRangeStart = 86497, XrefRangeEnd = 86525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeObject(IDictionary obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeObject_Private_Void_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 86547, RefRangeEnd = 86548, XrefRangeStart = 86526, XrefRangeEnd = 86547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeArray(IList anArray)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anArray)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeArray_Private_Void_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 86586, RefRangeEnd = 86590, XrefRangeStart = 86548, XrefRangeEnd = 86586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeString(string str)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(str)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 86605, RefRangeEnd = 86606, XrefRangeStart = 86590, XrefRangeEnd = 86605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SerializeOther(Il2CppSystem.Object value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Json.Serializer.NativeMethodInfoPtr_SerializeOther_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe StringBuilder builder
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Json.Serializer.NativeFieldInfoPtr_builder));
        return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Json.Serializer.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
