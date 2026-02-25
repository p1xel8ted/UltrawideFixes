// Decompiled with JetBrains decompiler
// Type: JohnGambleCreations.DevPalette
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace JohnGambleCreations;

public class DevPalette(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_entries;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_DevPaletteEntry_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_DevPaletteEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_Object_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_DevPaletteEntry_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_IEnumerable_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_Object_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNulls_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoesContainObject_Public_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_DevPaletteEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Public_Int32_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Public_DevPaletteEntry_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DevPalette()
  {
    Il2CppClassPointerStore<DevPalette>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "JohnGambleCreations", nameof (DevPalette));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DevPalette>.NativeClassPtr);
    DevPalette.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, nameof (entries));
    DevPalette.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673638);
    DevPalette.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673639);
    DevPalette.NativeMethodInfoPtr_get_Item_Public_get_DevPaletteEntry_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673640);
    DevPalette.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_DevPaletteEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673641);
    DevPalette.NativeMethodInfoPtr_Add_Public_Void_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673642);
    DevPalette.NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673643);
    DevPalette.NativeMethodInfoPtr_Remove_Public_Void_DevPaletteEntry_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673644);
    DevPalette.NativeMethodInfoPtr_Remove_Public_Void_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673645);
    DevPalette.NativeMethodInfoPtr_Remove_Public_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673646);
    DevPalette.NativeMethodInfoPtr_RemoveNulls_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673647);
    DevPalette.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673648);
    DevPalette.NativeMethodInfoPtr_DoesContainObject_Public_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673649);
    DevPalette.NativeMethodInfoPtr_GetIndex_Public_Int32_DevPaletteEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673650);
    DevPalette.NativeMethodInfoPtr_GetIndex_Public_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673651);
    DevPalette.NativeMethodInfoPtr_GetEntry_Public_DevPaletteEntry_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673652);
    DevPalette.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, 100673653);
  }

  public unsafe int Count
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403064, XrefRangeEnd = 403065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsReadOnly
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe DevPaletteEntry this[int index]
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403065, XrefRangeEnd = 403069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_get_Item_Public_get_DevPaletteEntry_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DevPaletteEntry) null : Il2CppObjectPool.Get<DevPaletteEntry>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403069, XrefRangeEnd = 403073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_DevPaletteEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 403083, RefRangeEnd = 403084, XrefRangeStart = 403073, XrefRangeEnd = 403083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(UnityEngine.Object obj, int index = -1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_Add_Public_Void_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403084, XrefRangeEnd = 403102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(IEnumerable<UnityEngine.Object> objects, int startIndex = -1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objects);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_Add_Public_Void_IEnumerable_1_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403102, XrefRangeEnd = 403105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Remove(DevPaletteEntry entry, bool forceRemove = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceRemove;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_Remove_Public_Void_DevPaletteEntry_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403105, XrefRangeEnd = 403126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Remove(IEnumerable<UnityEngine.Object> objects)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objects)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_Remove_Public_Void_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403126, XrefRangeEnd = 403130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Remove(UnityEngine.Object obj, bool forceRemove = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceRemove;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_Remove_Public_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403130, XrefRangeEnd = 403163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RemoveNulls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_RemoveNulls_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403163, XrefRangeEnd = 403182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 403196, RefRangeEnd = 403197, XrefRangeStart = 403182, XrefRangeEnd = 403196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool DoesContainObject(UnityEngine.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_DoesContainObject_Public_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403197, XrefRangeEnd = 403202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetIndex(DevPaletteEntry entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_GetIndex_Public_Int32_DevPaletteEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403202, XrefRangeEnd = 403208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetIndex(UnityEngine.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_GetIndex_Public_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 403222, RefRangeEnd = 403225, XrefRangeStart = 403208, XrefRangeEnd = 403222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DevPaletteEntry GetEntry(UnityEngine.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr_GetEntry_Public_DevPaletteEntry_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (DevPaletteEntry) null : Il2CppObjectPool.Get<DevPaletteEntry>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403225, XrefRangeEnd = 403232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DevPalette()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DevPalette>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPalette.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<DevPaletteEntry> entries
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DevPalette.NativeFieldInfoPtr_entries));
      return num == System.IntPtr.Zero ? (List<DevPaletteEntry>) null : Il2CppObjectPool.Get<List<DevPaletteEntry>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DevPalette.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("JohnGambleCreations.DevPalette+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RemoveNulls_b__13_0_Internal_Boolean_DevPaletteEntry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Clear_b__14_0_Internal_Boolean_DevPaletteEntry_0;

    static __c()
    {
      Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DevPalette>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr);
      DevPalette.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr, "<>9");
      DevPalette.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr, "<>9__13_0");
      DevPalette.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr, "<>9__14_0");
      DevPalette.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr, 100673655);
      DevPalette.__c.NativeMethodInfoPtr__RemoveNulls_b__13_0_Internal_Boolean_DevPaletteEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr, 100673656);
      DevPalette.__c.NativeMethodInfoPtr__Clear_b__14_0_Internal_Boolean_DevPaletteEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr, 100673657);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DevPalette.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DevPalette.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403055, XrefRangeEnd = 403064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _RemoveNulls_b__13_0(DevPaletteEntry x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.__c.NativeMethodInfoPtr__RemoveNulls_b__13_0_Internal_Boolean_DevPaletteEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool _Clear_b__14_0(DevPaletteEntry x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DevPalette.__c.NativeMethodInfoPtr__Clear_b__14_0_Internal_Boolean_DevPaletteEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe DevPalette.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(DevPalette.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (DevPalette.__c) null : Il2CppObjectPool.Get<DevPalette.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DevPalette.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<DevPaletteEntry, bool> __9__13_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(DevPalette.__c.NativeFieldInfoPtr___9__13_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<DevPaletteEntry, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<DevPaletteEntry, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DevPalette.__c.NativeFieldInfoPtr___9__13_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<DevPaletteEntry, bool> __9__14_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(DevPalette.__c.NativeFieldInfoPtr___9__14_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<DevPaletteEntry, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<DevPaletteEntry, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DevPalette.__c.NativeFieldInfoPtr___9__14_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
