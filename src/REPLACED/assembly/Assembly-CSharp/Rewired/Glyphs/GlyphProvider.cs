// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

public class GlyphProvider(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__prefetch;
  private static readonly System.IntPtr NativeFieldInfoPtr__glyphSetCollections;
  private static readonly System.IntPtr NativeFieldInfoPtr__glyphs;
  private static readonly System.IntPtr NativeFieldInfoPtr__initialized;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_prefetch_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_prefetch_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphSetCollections_Public_get_List_1_GlyphSetCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphSetCollections_Public_set_Void_List_1_GlyphSetCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphs_Protected_get_Dictionary_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySetGlyphProvider_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reload_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_Interfaces_IGlyphProvider_TryGetGlyph_Private_Virtual_Final_New_Boolean_String_byref_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GlyphProvider()
  {
    Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (GlyphProvider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr);
    GlyphProvider.NativeFieldInfoPtr__prefetch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, nameof (_prefetch));
    GlyphProvider.NativeFieldInfoPtr__glyphSetCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, nameof (_glyphSetCollections));
    GlyphProvider.NativeFieldInfoPtr__glyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, nameof (_glyphs));
    GlyphProvider.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, nameof (_initialized));
    GlyphProvider.NativeMethodInfoPtr_get_prefetch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668578);
    GlyphProvider.NativeMethodInfoPtr_set_prefetch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668579);
    GlyphProvider.NativeMethodInfoPtr_get_glyphSetCollections_Public_get_List_1_GlyphSetCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668580);
    GlyphProvider.NativeMethodInfoPtr_set_glyphSetCollections_Public_set_Void_List_1_GlyphSetCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668581);
    GlyphProvider.NativeMethodInfoPtr_get_glyphs_Protected_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668582);
    GlyphProvider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668583);
    GlyphProvider.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668584);
    GlyphProvider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668585);
    GlyphProvider.NativeMethodInfoPtr_TrySetGlyphProvider_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668586);
    GlyphProvider.NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668587);
    GlyphProvider.NativeMethodInfoPtr_Reload_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668588);
    GlyphProvider.NativeMethodInfoPtr_Rewired_Interfaces_IGlyphProvider_TryGetGlyph_Private_Virtual_Final_New_Boolean_String_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668589);
    GlyphProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr, 100668590);
  }

  public unsafe bool prefetch
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_get_prefetch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69261, XrefRangeEnd = 69277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_set_prefetch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<GlyphSetCollection> glyphSetCollections
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_get_glyphSetCollections_Public_get_List_1_GlyphSetCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<GlyphSetCollection>) null : Il2CppObjectPool.Get<List<GlyphSetCollection>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69277, XrefRangeEnd = 69293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_set_glyphSetCollections_Public_set_Void_List_1_GlyphSetCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> glyphs
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_get_glyphs_Protected_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num3);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphProvider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69293, XrefRangeEnd = 69316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphProvider.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphProvider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69316, XrefRangeEnd = 69349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void TrySetGlyphProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphProvider.NativeMethodInfoPtr_TrySetGlyphProvider_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69349, XrefRangeEnd = 69405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphProvider.NativeMethodInfoPtr_Initialize_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69405, XrefRangeEnd = 69421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reload()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_Reload_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69421, XrefRangeEnd = 69424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Rewired_Interfaces_IGlyphProvider_TryGetGlyph(
    string key,
    out Il2CppSystem.Object result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr_Rewired_Interfaces_IGlyphProvider_TryGetGlyph_Private_Virtual_Final_New_Boolean_String_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppSystem.Object local = ref result;
    System.IntPtr pointer = zero;
    Il2CppSystem.Object @object = pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    local = @object;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69424, XrefRangeEnd = 69431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlyphProvider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphProvider>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _prefetch
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__prefetch));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__prefetch)) = value;
    }
  }

  public unsafe List<GlyphSetCollection> _glyphSetCollections
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__glyphSetCollections));
      return num == System.IntPtr.Zero ? (List<GlyphSetCollection>) null : Il2CppObjectPool.Get<List<GlyphSetCollection>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__glyphSetCollections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> _glyphs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__glyphs));
      return num == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__glyphs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphProvider.NativeFieldInfoPtr__initialized)) = value;
    }
  }
}
