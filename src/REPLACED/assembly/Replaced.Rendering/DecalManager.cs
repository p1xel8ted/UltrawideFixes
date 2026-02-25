// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalManager
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class DecalManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDecalCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kVisibleDecalCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kMaskDecalCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kVisibleMaskDecalCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr__visibleMaskDecalComparer;
  private static readonly System.IntPtr NativeFieldInfoPtr__visibleDecalComparer;
  private static readonly System.IntPtr NativeFieldInfoPtr__decals;
  private static readonly System.IntPtr NativeFieldInfoPtr__visibleDecals;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecals;
  private static readonly System.IntPtr NativeFieldInfoPtr__visibleMaskDecals;
  private static readonly System.IntPtr NativeFieldInfoPtr__frustumPlanes;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DecalCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaskDecalCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cull_Public_DecalCullingResult_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CullMaskDecals_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CullDecals_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDecal_Public_Void_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterDecal_Public_Void_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterMaskDecal_Public_Void_MaskDecal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterMaskDecal_Public_Void_MaskDecal_0;

  static DecalManager()
  {
    Il2CppClassPointerStore<DecalManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalManager>.NativeClassPtr);
    DecalManager.NativeFieldInfoPtr_kDecalCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (kDecalCountLimit));
    DecalManager.NativeFieldInfoPtr_kVisibleDecalCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (kVisibleDecalCountLimit));
    DecalManager.NativeFieldInfoPtr_kMaskDecalCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (kMaskDecalCountLimit));
    DecalManager.NativeFieldInfoPtr_kVisibleMaskDecalCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (kVisibleMaskDecalCountLimit));
    DecalManager.NativeFieldInfoPtr__visibleMaskDecalComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_visibleMaskDecalComparer));
    DecalManager.NativeFieldInfoPtr__visibleDecalComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_visibleDecalComparer));
    DecalManager.NativeFieldInfoPtr__decals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_decals));
    DecalManager.NativeFieldInfoPtr__visibleDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_visibleDecals));
    DecalManager.NativeFieldInfoPtr__maskDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_maskDecals));
    DecalManager.NativeFieldInfoPtr__visibleMaskDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_visibleMaskDecals));
    DecalManager.NativeFieldInfoPtr__frustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (_frustumPlanes));
    DecalManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663707);
    DecalManager.NativeMethodInfoPtr_get_DecalCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663708);
    DecalManager.NativeMethodInfoPtr_get_MaskDecalCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663709);
    DecalManager.NativeMethodInfoPtr_Cull_Public_DecalCullingResult_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663710);
    DecalManager.NativeMethodInfoPtr_CullMaskDecals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663711);
    DecalManager.NativeMethodInfoPtr_CullDecals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663712 /*0x060001A0*/);
    DecalManager.NativeMethodInfoPtr_RegisterDecal_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663713);
    DecalManager.NativeMethodInfoPtr_UnregisterDecal_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663714);
    DecalManager.NativeMethodInfoPtr_RegisterMaskDecal_Public_Void_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663715);
    DecalManager.NativeMethodInfoPtr_UnregisterMaskDecal_Public_Void_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, 100663716);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927923, RefRangeEnd = 927924, XrefRangeStart = 927887, XrefRangeEnd = 927923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int DecalCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927924, XrefRangeEnd = 927925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_get_DecalCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int MaskDecalCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927925, XrefRangeEnd = 927926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_get_MaskDecalCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927926, XrefRangeEnd = 927933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalCullingResult Cull(Camera camera)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_Cull_Public_DecalCullingResult_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new DecalCullingResult(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 927965, RefRangeEnd = 927967, XrefRangeStart = 927933, XrefRangeEnd = 927965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CullMaskDecals()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_CullMaskDecals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 927999, RefRangeEnd = 928001, XrefRangeStart = 927967, XrefRangeEnd = 927999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CullDecals()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_CullDecals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928011, RefRangeEnd = 928012, XrefRangeStart = 928001, XrefRangeEnd = 928011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterDecal(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_RegisterDecal_Public_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928016, RefRangeEnd = 928017, XrefRangeStart = 928012, XrefRangeEnd = 928016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterDecal(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_UnregisterDecal_Public_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928027, RefRangeEnd = 928028, XrefRangeStart = 928017, XrefRangeEnd = 928027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterMaskDecal(MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_RegisterMaskDecal_Public_Void_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928032, RefRangeEnd = 928033, XrefRangeStart = 928028, XrefRangeEnd = 928032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterMaskDecal(MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalManager.NativeMethodInfoPtr_UnregisterMaskDecal_Public_Void_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kDecalCountLimit
  {
    get
    {
      int kDecalCountLimit;
      IL2CPP.il2cpp_field_static_get_value(DecalManager.NativeFieldInfoPtr_kDecalCountLimit, (void*) &kDecalCountLimit);
      return kDecalCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalManager.NativeFieldInfoPtr_kDecalCountLimit, (void*) &value);
    }
  }

  public static unsafe int kVisibleDecalCountLimit
  {
    get
    {
      int visibleDecalCountLimit;
      IL2CPP.il2cpp_field_static_get_value(DecalManager.NativeFieldInfoPtr_kVisibleDecalCountLimit, (void*) &visibleDecalCountLimit);
      return visibleDecalCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalManager.NativeFieldInfoPtr_kVisibleDecalCountLimit, (void*) &value);
    }
  }

  public static unsafe int kMaskDecalCountLimit
  {
    get
    {
      int maskDecalCountLimit;
      IL2CPP.il2cpp_field_static_get_value(DecalManager.NativeFieldInfoPtr_kMaskDecalCountLimit, (void*) &maskDecalCountLimit);
      return maskDecalCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalManager.NativeFieldInfoPtr_kMaskDecalCountLimit, (void*) &value);
    }
  }

  public static unsafe int kVisibleMaskDecalCountLimit
  {
    get
    {
      int maskDecalCountLimit;
      IL2CPP.il2cpp_field_static_get_value(DecalManager.NativeFieldInfoPtr_kVisibleMaskDecalCountLimit, (void*) &maskDecalCountLimit);
      return maskDecalCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalManager.NativeFieldInfoPtr_kVisibleMaskDecalCountLimit, (void*) &value);
    }
  }

  public unsafe DecalManager.VisibleMaskDecalComparer _visibleMaskDecalComparer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleMaskDecalComparer));
      return num == System.IntPtr.Zero ? (DecalManager.VisibleMaskDecalComparer) null : Il2CppObjectPool.Get<DecalManager.VisibleMaskDecalComparer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleMaskDecalComparer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DecalManager.VisibleDecalComparer _visibleDecalComparer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleDecalComparer));
      return num == System.IntPtr.Zero ? (DecalManager.VisibleDecalComparer) null : Il2CppObjectPool.Get<DecalManager.VisibleDecalComparer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleDecalComparer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Decal> _decals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__decals));
      return num == System.IntPtr.Zero ? (List<Decal>) null : Il2CppObjectPool.Get<List<Decal>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__decals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<VisibleDecal> _visibleDecals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleDecals));
      return num == System.IntPtr.Zero ? (List<VisibleDecal>) null : Il2CppObjectPool.Get<List<VisibleDecal>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleDecals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<MaskDecal> _maskDecals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__maskDecals));
      return num == System.IntPtr.Zero ? (List<MaskDecal>) null : Il2CppObjectPool.Get<List<MaskDecal>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__maskDecals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<VisibleMaskDecal> _visibleMaskDecals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleMaskDecals));
      return num == System.IntPtr.Zero ? (List<VisibleMaskDecal>) null : Il2CppObjectPool.Get<List<VisibleMaskDecal>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__visibleMaskDecals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<UnityEngine.Plane> _frustumPlanes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__frustumPlanes));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<UnityEngine.Plane>) null : Il2CppObjectPool.Get<Il2CppStructArray<UnityEngine.Plane>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalManager.NativeFieldInfoPtr__frustumPlanes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class VisibleMaskDecalComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_VisibleMaskDecal_VisibleMaskDecal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VisibleMaskDecalComparer()
    {
      Il2CppClassPointerStore<DecalManager.VisibleMaskDecalComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (VisibleMaskDecalComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalManager.VisibleMaskDecalComparer>.NativeClassPtr);
      DecalManager.VisibleMaskDecalComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_VisibleMaskDecal_VisibleMaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager.VisibleMaskDecalComparer>.NativeClassPtr, 100663717);
      DecalManager.VisibleMaskDecalComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager.VisibleMaskDecalComparer>.NativeClassPtr, 100663718);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927886, XrefRangeEnd = 927887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(VisibleMaskDecal left, VisibleMaskDecal right)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) left));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) right));
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalManager.VisibleMaskDecalComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_VisibleMaskDecal_VisibleMaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VisibleMaskDecalComparer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalManager.VisibleMaskDecalComparer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DecalManager.VisibleMaskDecalComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public sealed class VisibleDecalComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_VisibleDecal_VisibleDecal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VisibleDecalComparer()
    {
      Il2CppClassPointerStore<DecalManager.VisibleDecalComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalManager>.NativeClassPtr, nameof (VisibleDecalComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalManager.VisibleDecalComparer>.NativeClassPtr);
      DecalManager.VisibleDecalComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_VisibleDecal_VisibleDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager.VisibleDecalComparer>.NativeClassPtr, 100663719);
      DecalManager.VisibleDecalComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalManager.VisibleDecalComparer>.NativeClassPtr, 100663720);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(VisibleDecal left, VisibleDecal right)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) left));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) right));
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalManager.VisibleDecalComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_VisibleDecal_VisibleDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VisibleDecalComparer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalManager.VisibleDecalComparer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DecalManager.VisibleDecalComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
