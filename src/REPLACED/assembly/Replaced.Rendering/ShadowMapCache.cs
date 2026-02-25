// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowMapCache
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ShadowMapCache(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__capacity;
  private static readonly System.IntPtr NativeFieldInfoPtr__texCache;
  private static readonly System.IntPtr NativeFieldInfoPtr__keySlotMap;
  private static readonly System.IntPtr NativeFieldInfoPtr__usedKeysQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr__freelist;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeKey_Public_Static_UInt64_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TexCache_Public_get_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitTexCacheIfNecessary_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSlot_Public_ShadowMapCacheSlot_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvictOldestKey_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ShadowMapCache()
  {
    Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowMapCache));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr);
    ShadowMapCache.NativeFieldInfoPtr__capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, nameof (_capacity));
    ShadowMapCache.NativeFieldInfoPtr__texCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, nameof (_texCache));
    ShadowMapCache.NativeFieldInfoPtr__keySlotMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, nameof (_keySlotMap));
    ShadowMapCache.NativeFieldInfoPtr__usedKeysQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, nameof (_usedKeysQueue));
    ShadowMapCache.NativeFieldInfoPtr__freelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, nameof (_freelist));
    ShadowMapCache.NativeMethodInfoPtr_MakeKey_Public_Static_UInt64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664051);
    ShadowMapCache.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664052);
    ShadowMapCache.NativeMethodInfoPtr_get_TexCache_Public_get_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664053);
    ShadowMapCache.NativeMethodInfoPtr_InitTexCacheIfNecessary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664054);
    ShadowMapCache.NativeMethodInfoPtr_GetSlot_Public_ShadowMapCacheSlot_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664055);
    ShadowMapCache.NativeMethodInfoPtr_EvictOldestKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664056);
    ShadowMapCache.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr, 100664057);
  }

  [CallerCount(0)]
  public static unsafe ulong MakeKey(int instanceId, int cubemapFaceIdx)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &instanceId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapFaceIdx;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr_MakeKey_Public_Static_UInt64_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932169, XrefRangeEnd = 932188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowMapCache(int capacity)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowMapCache>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &capacity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe RenderTextureResource TexCache
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr_get_TexCache_Public_get_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new RenderTextureResource(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932188, XrefRangeEnd = 932202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitTexCacheIfNecessary()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr_InitTexCacheIfNecessary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932256, RefRangeEnd = 932257, XrefRangeStart = 932202, XrefRangeEnd = 932256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowMapCacheSlot GetSlot(ulong key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &key
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr_GetSlot_Public_ShadowMapCacheSlot_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ShadowMapCacheSlot) null : Il2CppObjectPool.Get<ShadowMapCacheSlot>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932257, XrefRangeEnd = 932270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvictOldestKey()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr_EvictOldestKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932270, XrefRangeEnd = 932283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMapCache.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _capacity
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__capacity));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__capacity)) = value;
    }
  }

  public RenderTextureResource _texCache
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__texCache);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__texCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeHashMap<ulong, int> _keySlotMap
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__keySlotMap);
      return new NativeHashMap<ulong, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeHashMap<ulong, int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__keySlotMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<ulong, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeQueue<ulong> _usedKeysQueue
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__usedKeysQueue);
      return new NativeQueue<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeQueue<ulong>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__usedKeysQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeQueue<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeList<int> _freelist
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__freelist);
      return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowMapCache.NativeFieldInfoPtr__freelist), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
