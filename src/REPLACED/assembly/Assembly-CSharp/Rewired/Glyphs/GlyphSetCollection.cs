// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphSetCollection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

[Serializable]
public class GlyphSetCollection(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__sets;
  private static readonly System.IntPtr NativeFieldInfoPtr__collections;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sets_Public_get_List_1_GlyphSet_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_sets_Public_set_Void_List_1_GlyphSet_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_collections_Public_get_List_1_GlyphSetCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_collections_Public_set_Void_List_1_GlyphSetCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IterateSetsRecursively_Public_Virtual_New_IEnumerable_1_GlyphSet_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IterateSetsRecursively_Protected_Virtual_New_IEnumerable_1_GlyphSet_List_1_GlyphSetCollection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogCircularDependency_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GlyphSetCollection()
  {
    Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (GlyphSetCollection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr);
    GlyphSetCollection.NativeFieldInfoPtr__sets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, nameof (_sets));
    GlyphSetCollection.NativeFieldInfoPtr__collections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, nameof (_collections));
    GlyphSetCollection.NativeMethodInfoPtr_get_sets_Public_get_List_1_GlyphSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668604);
    GlyphSetCollection.NativeMethodInfoPtr_set_sets_Public_set_Void_List_1_GlyphSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668605);
    GlyphSetCollection.NativeMethodInfoPtr_get_collections_Public_get_List_1_GlyphSetCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668606);
    GlyphSetCollection.NativeMethodInfoPtr_set_collections_Public_set_Void_List_1_GlyphSetCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668607);
    GlyphSetCollection.NativeMethodInfoPtr_IterateSetsRecursively_Public_Virtual_New_IEnumerable_1_GlyphSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668608);
    GlyphSetCollection.NativeMethodInfoPtr_IterateSetsRecursively_Protected_Virtual_New_IEnumerable_1_GlyphSet_List_1_GlyphSetCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668609);
    GlyphSetCollection.NativeMethodInfoPtr_LogCircularDependency_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668610);
    GlyphSetCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, 100668611);
  }

  public unsafe List<GlyphSet> sets
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection.NativeMethodInfoPtr_get_sets_Public_get_List_1_GlyphSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<GlyphSet>) null : Il2CppObjectPool.Get<List<GlyphSet>>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection.NativeMethodInfoPtr_set_sets_Public_set_Void_List_1_GlyphSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<GlyphSetCollection> collections
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection.NativeMethodInfoPtr_get_collections_Public_get_List_1_GlyphSetCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<GlyphSetCollection>) null : Il2CppObjectPool.Get<List<GlyphSetCollection>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69585, XrefRangeEnd = 69595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection.NativeMethodInfoPtr_set_collections_Public_set_Void_List_1_GlyphSetCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69595, XrefRangeEnd = 69607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerable<GlyphSet> IterateSetsRecursively()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphSetCollection.NativeMethodInfoPtr_IterateSetsRecursively_Public_Virtual_New_IEnumerable_1_GlyphSet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerable<GlyphSet>) null : Il2CppObjectPool.Get<IEnumerable<GlyphSet>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69607, XrefRangeEnd = 69612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe IEnumerable<GlyphSet> IterateSetsRecursively(
    List<GlyphSetCollection> processedCollections)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) processedCollections)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphSetCollection.NativeMethodInfoPtr_IterateSetsRecursively_Protected_Virtual_New_IEnumerable_1_GlyphSet_List_1_GlyphSetCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerable<GlyphSet>) null : Il2CppObjectPool.Get<IEnumerable<GlyphSet>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69618, RefRangeEnd = 69620, XrefRangeStart = 69612, XrefRangeEnd = 69618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogCircularDependency()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection.NativeMethodInfoPtr_LogCircularDependency_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlyphSetCollection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<GlyphSet> _sets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection.NativeFieldInfoPtr__sets));
      return num == System.IntPtr.Zero ? (List<GlyphSet>) null : Il2CppObjectPool.Get<List<GlyphSet>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection.NativeFieldInfoPtr__sets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GlyphSetCollection> _collections
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection.NativeFieldInfoPtr__collections));
      return num == System.IntPtr.Zero ? (List<GlyphSetCollection>) null : Il2CppObjectPool.Get<List<GlyphSetCollection>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection.NativeFieldInfoPtr__collections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Rewired.Glyphs.GlyphSetCollection+<IterateSetsRecursively>d__9")]
  public sealed class _IterateSetsRecursively_d__9(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___l__initialThreadId;
    private static readonly System.IntPtr NativeFieldInfoPtr_processedCollections;
    private static readonly System.IntPtr NativeFieldInfoPtr___3__processedCollections;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__setCount_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__collectionCount_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Glyphs_GlyphSet__get_Current_Private_Virtual_Final_New_get_GlyphSet_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Glyphs_GlyphSet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_GlyphSet_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

    static _IterateSetsRecursively_d__9()
    {
      Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlyphSetCollection>.NativeClassPtr, "<IterateSetsRecursively>d__9");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<>1__state");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<>2__current");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<>l__initialThreadId");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr_processedCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, nameof (processedCollections));
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___3__processedCollections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<>3__processedCollections");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<>4__this");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__setCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<setCount>5__2");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__collectionCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<collectionCount>5__3");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<i>5__4");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, "<>7__wrap4");
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668612);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668613);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668614);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668615);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Glyphs_GlyphSet__get_Current_Private_Virtual_Final_New_get_GlyphSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668616);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668617);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668618);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Glyphs_GlyphSet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_GlyphSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668619);
      GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr, 100668620);
    }

    [CallerCount(81)]
    [CachedScanResults(RefRangeStart = 69433, RefRangeEnd = 69514, XrefRangeStart = 69431, XrefRangeEnd = 69433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _IterateSetsRecursively_d__9(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphSetCollection._IterateSetsRecursively_d__9>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69514, XrefRangeEnd = 69519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69519, XrefRangeEnd = 69570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69570, XrefRangeEnd = 69573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe GlyphSet System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CRewired\u002EGlyphs\u002EGlyphSet\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Rewired_Glyphs_GlyphSet__get_Current_Private_Virtual_Final_New_get_GlyphSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (GlyphSet) null : Il2CppObjectPool.Get<GlyphSet>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69573, XrefRangeEnd = 69578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69578, XrefRangeEnd = 69585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator<GlyphSet> System_Collections_Generic_IEnumerable_Rewired_Glyphs_GlyphSet__GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Rewired_Glyphs_GlyphSet__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_GlyphSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator<GlyphSet>) null : Il2CppObjectPool.Get<IEnumerator<GlyphSet>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphSetCollection._IterateSetsRecursively_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe GlyphSet __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (GlyphSet) null : Il2CppObjectPool.Get<GlyphSet>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __l__initialThreadId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___l__initialThreadId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
      }
    }

    public unsafe List<GlyphSetCollection> processedCollections
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr_processedCollections));
        return num == System.IntPtr.Zero ? (List<GlyphSetCollection>) null : Il2CppObjectPool.Get<List<GlyphSetCollection>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr_processedCollections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<GlyphSetCollection> __3__processedCollections
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___3__processedCollections));
        return num == System.IntPtr.Zero ? (List<GlyphSetCollection>) null : Il2CppObjectPool.Get<List<GlyphSetCollection>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___3__processedCollections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GlyphSetCollection __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GlyphSetCollection) null : Il2CppObjectPool.Get<GlyphSetCollection>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _setCount_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__setCount_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__setCount_5__2)) = value;
      }
    }

    public unsafe int _collectionCount_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__collectionCount_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__collectionCount_5__3)) = value;
      }
    }

    public unsafe int _i_5__4
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__i_5__4));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr__i_5__4)) = value;
      }
    }

    public unsafe IEnumerator<GlyphSet> __7__wrap4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___7__wrap4));
        return num == System.IntPtr.Zero ? (IEnumerator<GlyphSet>) null : Il2CppObjectPool.Get<IEnumerator<GlyphSet>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphSetCollection._IterateSetsRecursively_d__9.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
