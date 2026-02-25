// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.VFXManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

#nullable disable
namespace SadCatStudios.Effects;

public class VFXManager(System.IntPtr pointer) : GlobalSingletonBehaviour<VFXManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_vfxLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_vfxIntensiveLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultPoolSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_intensivePoolSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_trailSpritePrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_resourceLocator;
  private static readonly System.IntPtr NativeFieldInfoPtr_pools;
  private static readonly System.IntPtr NativeFieldInfoPtr_manuallyFreedObjectPools;
  private static readonly System.IntPtr NativeFieldInfoPtr_trailSpritePool;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetEffect_Public_IPoolable_AssetReference_Vector3_Quaternion_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteTrail_Public_BlinkSpriteTrail_Vector3_Quaternion_Vector3_Sprite_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeEffect_Public_Void_IPoolable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VFXManager()
  {
    Il2CppClassPointerStore<VFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (VFXManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXManager>.NativeClassPtr);
    VFXManager.NativeFieldInfoPtr_vfxLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (vfxLabel));
    VFXManager.NativeFieldInfoPtr_vfxIntensiveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (vfxIntensiveLabel));
    VFXManager.NativeFieldInfoPtr_defaultPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (defaultPoolSize));
    VFXManager.NativeFieldInfoPtr_intensivePoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (intensivePoolSize));
    VFXManager.NativeFieldInfoPtr_trailSpritePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (trailSpritePrefab));
    VFXManager.NativeFieldInfoPtr_resourceLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (resourceLocator));
    VFXManager.NativeFieldInfoPtr_pools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (pools));
    VFXManager.NativeFieldInfoPtr_manuallyFreedObjectPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (manuallyFreedObjectPools));
    VFXManager.NativeFieldInfoPtr_trailSpritePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, nameof (trailSpritePool));
    VFXManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100675793);
    VFXManager.NativeMethodInfoPtr_GetEffect_Public_IPoolable_AssetReference_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100675794);
    VFXManager.NativeMethodInfoPtr_GetSpriteTrail_Public_BlinkSpriteTrail_Vector3_Quaternion_Vector3_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100675795);
    VFXManager.NativeMethodInfoPtr_FreeEffect_Public_Void_IPoolable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100675796);
    VFXManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100675797);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119697, XrefRangeEnd = 119726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VFXManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 119753, RefRangeEnd = 119776, XrefRangeStart = 119726, XrefRangeEnd = 119753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPoolable GetEffect(
    AssetReference effect,
    Vector3 pos,
    Quaternion rot,
    bool willManuallyFree = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &willManuallyFree;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr_GetEffect_Public_IPoolable_AssetReference_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 119782, RefRangeEnd = 119783, XrefRangeStart = 119776, XrefRangeEnd = 119782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlinkSpriteTrail GetSpriteTrail(
    Vector3 position,
    Quaternion rotation,
    Vector3 scale,
    Sprite sprite,
    Color color = default (Color))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr_GetSpriteTrail_Public_BlinkSpriteTrail_Vector3_Quaternion_Vector3_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BlinkSpriteTrail) null : Il2CppObjectPool.Get<BlinkSpriteTrail>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 119791, RefRangeEnd = 119794, XrefRangeStart = 119783, XrefRangeEnd = 119791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeEffect(IPoolable effect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) effect)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr_FreeEffect_Public_Void_IPoolable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119794, XrefRangeEnd = 119809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VFXManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VFXManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AssetLabelReference vfxLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_vfxLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_vfxLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetLabelReference vfxIntensiveLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_vfxIntensiveLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_vfxIntensiveLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int defaultPoolSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_defaultPoolSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_defaultPoolSize)) = value;
    }
  }

  public unsafe int intensivePoolSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_intensivePoolSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_intensivePoolSize)) = value;
    }
  }

  public unsafe BlinkSpriteTrail trailSpritePrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_trailSpritePrefab));
      return num == System.IntPtr.Zero ? (BlinkSpriteTrail) null : Il2CppObjectPool.Get<BlinkSpriteTrail>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_trailSpritePrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IResourceLocator resourceLocator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_resourceLocator));
      return num == System.IntPtr.Zero ? (IResourceLocator) null : Il2CppObjectPool.Get<IResourceLocator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_resourceLocator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, AddressableObjectPool> pools
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_pools));
      return num == System.IntPtr.Zero ? (Dictionary<string, AddressableObjectPool>) null : Il2CppObjectPool.Get<Dictionary<string, AddressableObjectPool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_pools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<IPoolable, AddressableObjectPool> manuallyFreedObjectPools
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_manuallyFreedObjectPools));
      return num == System.IntPtr.Zero ? (Dictionary<IPoolable, AddressableObjectPool>) null : Il2CppObjectPool.Get<Dictionary<IPoolable, AddressableObjectPool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_manuallyFreedObjectPools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool trailSpritePool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_trailSpritePool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.NativeFieldInfoPtr_trailSpritePool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Effects.VFXManager+<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_instantiateHelper;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_AssetLabelReference_Int32_0;

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr);
      VFXManager.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
      VFXManager.__c__DisplayClass9_0.NativeFieldInfoPtr_instantiateHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr, nameof (instantiateHelper));
      VFXManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr, 100675798);
      VFXManager.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_AssetLabelReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr, 100675799);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 119695, RefRangeEnd = 119697, XrefRangeStart = 119691, XrefRangeEnd = 119695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_AssetLabelReference_Int32_0(
      AssetLabelReference label,
      int size)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) label);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_AssetLabelReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe VFXManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (VFXManager) null : Il2CppObjectPool.Get<VFXManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject instantiateHelper
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.NativeFieldInfoPtr_instantiateHelper));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.NativeFieldInfoPtr_instantiateHelper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Effects.VFXManager+<>c__DisplayClass9_0+<<DoAwake>g__DoLoad|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr_label;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_size;
      private static readonly System.IntPtr NativeFieldInfoPtr__effectLocations_5__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique()
      {
        Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0>.NativeClassPtr, "<<DoAwake>g__DoLoad|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr);
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, "<>1__state");
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, "<>2__current");
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, nameof (label));
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, "<>4__this");
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, nameof (size));
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr__effectLocations_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, "<effectLocations>5__2");
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, 100675800);
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, 100675801);
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, 100675802);
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, 100675803);
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, 100675804);
        VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr, 100675805);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119606, XrefRangeEnd = 119686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119686, XrefRangeEnd = 119691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe AssetLabelReference label
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr_label));
          return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe VFXManager.__c__DisplayClass9_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (VFXManager.__c__DisplayClass9_0) null : Il2CppObjectPool.Get<VFXManager.__c__DisplayClass9_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int size
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr_size));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr_size)) = value;
        }
      }

      public AsyncOperationHandle<IList<IResourceLocation>> _effectLocations_5__2
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr__effectLocations_5__2);
          return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VFXManager.__c__DisplayClass9_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAslasiIn1AsILIRUnique.NativeFieldInfoPtr__effectLocations_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
