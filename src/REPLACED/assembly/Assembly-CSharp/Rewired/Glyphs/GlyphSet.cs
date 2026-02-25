// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

[Serializable]
public class GlyphSet(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__baseKeys;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_baseKeys_Public_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_baseKeys_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphCount_Public_Abstract_Virtual_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Public_Abstract_Virtual_New_EntryBase_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static GlyphSet()
  {
    Il2CppClassPointerStore<GlyphSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (GlyphSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr);
    GlyphSet.NativeFieldInfoPtr__baseKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, nameof (_baseKeys));
    GlyphSet.NativeMethodInfoPtr_get_baseKeys_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, 100668591);
    GlyphSet.NativeMethodInfoPtr_set_baseKeys_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, 100668592);
    GlyphSet.NativeMethodInfoPtr_get_glyphCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, 100668593);
    GlyphSet.NativeMethodInfoPtr_GetEntry_Public_Abstract_Virtual_New_EntryBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, 100668594);
    GlyphSet.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, 100668595);
  }

  public unsafe Il2CppStringArray baseKeys
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSet.NativeMethodInfoPtr_get_baseKeys_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSet.NativeMethodInfoPtr_set_baseKeys_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe int glyphCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphSet.NativeMethodInfoPtr_get_glyphCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe GlyphSet.EntryBase GetEntry(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphSet.NativeMethodInfoPtr_GetEntry_Public_Abstract_Virtual_New_EntryBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GlyphSet.EntryBase) null : Il2CppObjectPool.Get<GlyphSet.EntryBase>(num3);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlyphSet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphSet.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStringArray _baseKeys
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSet.NativeFieldInfoPtr__baseKeys));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSet.NativeFieldInfoPtr__baseKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class EntryBase(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__key;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_key_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_key_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    static EntryBase()
    {
      Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, nameof (EntryBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr);
      GlyphSet.EntryBase.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr, nameof (_key));
      GlyphSet.EntryBase.NativeMethodInfoPtr_get_key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr, 100668596);
      GlyphSet.EntryBase.NativeMethodInfoPtr_set_key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr, 100668597);
      GlyphSet.EntryBase.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr, 100668598);
      GlyphSet.EntryBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr, 100668599);
    }

    public unsafe string key
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSet.EntryBase.NativeMethodInfoPtr_get_key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GlyphSet.EntryBase.NativeMethodInfoPtr_set_key_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe Il2CppSystem.Object GetValue()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphSet.EntryBase.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntryBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphSet.EntryBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSet.EntryBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe string _key
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSet.EntryBase.NativeFieldInfoPtr__key)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSet.EntryBase.NativeFieldInfoPtr__key), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [Serializable]
  public class EntryBase<TValue>(System.IntPtr pointer) : GlyphSet.EntryBase(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_TValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    static EntryBase()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlyphSet>.NativeClassPtr, "EntryBase`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr);
      GlyphSet.EntryBase<TValue>.NativeFieldInfoPtr__value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr, nameof (_value));
      GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr_get_value_Public_get_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr, 100668600);
      GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr_set_value_Public_set_Void_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr, 100668601);
      GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr, 100668602);
      GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr, 100668603);
    }

    public unsafe TValue value
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr_get_value_Public_get_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.PointerToValueGeneric<TValue>(num2, false, true);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        TValue& local1;
        if (!typeof (TValue).IsValueType)
        {
          __Boxed<TValue> local2 = (object) value;
          local1 = local2 is string ? (TValue&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TValue&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        }
        else
          local1 = ref value;
        *numPtr2 = (System.IntPtr) ref local1;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr_set_value_Public_set_Void_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(28)]
    [CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Object GetValue()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(291)]
    [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntryBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphSet.EntryBase<TValue>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSet.EntryBase<TValue>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe TValue _value
    {
      get
      {
        return IL2CPP.PointerToValueGeneric<TValue>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSet.EntryBase<TValue>.NativeFieldInfoPtr__value), true, false);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSet.EntryBase<TValue>.NativeFieldInfoPtr__value);
        System.Type type = typeof (TValue);
        if (!type.IsValueType)
        {
          if (!string.Equals(type.FullName, "System.String"))
          {
            System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
            if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
            {
              System.IntPtr num2 = ptr;
              System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
              int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
              __memcpy(num1, num3, num4);
            }
            else
              IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
          }
          else
          {
            System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
          }
        }
        else
        {
          TValue obj = value;
          *(TValue*) num1 = obj;
        }
      }
    }
  }
}
