// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.ArmorLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

[Serializable]
public class ArmorLayer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_armorClipsDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorDestroyVariants;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallbackDestroyVariant;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentArmorPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_localPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_backPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_isActive;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArmorAnimator_Public_get_SpriteAnimator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArmorPoints_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsArmorDestroyClipFinished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArmorDestroyVariant_Public_get_ArmorBreakVariant_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FallbackDestroyVariant_Public_get_ArmorBreakVariant_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitLayer_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ActivateLayer_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLayer_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLayer_Public_Void_Vector3_Int32_ArmorBreakVariant_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFrameUpdated_Private_Void_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArmorLayer()
  {
    Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (ArmorLayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr);
    ArmorLayer.NativeFieldInfoPtr_armorClipsDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (armorClipsDictionary));
    ArmorLayer.NativeFieldInfoPtr_armorAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (armorAnimator));
    ArmorLayer.NativeFieldInfoPtr_armorPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (armorPoints));
    ArmorLayer.NativeFieldInfoPtr_armorDestroyVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (armorDestroyVariants));
    ArmorLayer.NativeFieldInfoPtr_fallbackDestroyVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (fallbackDestroyVariant));
    ArmorLayer.NativeFieldInfoPtr_CurrentArmorPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (CurrentArmorPoints));
    ArmorLayer.NativeFieldInfoPtr_localPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (localPos));
    ArmorLayer.NativeFieldInfoPtr_backPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (backPos));
    ArmorLayer.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, nameof (isActive));
    ArmorLayer.NativeMethodInfoPtr_get_ArmorAnimator_Public_get_SpriteAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674809);
    ArmorLayer.NativeMethodInfoPtr_get_ArmorPoints_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674810);
    ArmorLayer.NativeMethodInfoPtr_get_IsArmorDestroyClipFinished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674811);
    ArmorLayer.NativeMethodInfoPtr_get_ArmorDestroyVariant_Public_get_ArmorBreakVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674812);
    ArmorLayer.NativeMethodInfoPtr_get_FallbackDestroyVariant_Public_get_ArmorBreakVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674813);
    ArmorLayer.NativeMethodInfoPtr_InitLayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674814);
    ArmorLayer.NativeMethodInfoPtr_ActivateLayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674815);
    ArmorLayer.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674816 /*0x06002D00*/);
    ArmorLayer.NativeMethodInfoPtr_UpdateLayer_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674817);
    ArmorLayer.NativeMethodInfoPtr_RemoveLayer_Public_Void_Vector3_Int32_ArmorBreakVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674818);
    ArmorLayer.NativeMethodInfoPtr_OnFrameUpdated_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674819);
    ArmorLayer.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674820);
    ArmorLayer.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674821);
    ArmorLayer.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674822);
    ArmorLayer.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674823);
    ArmorLayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr, 100674824);
  }

  public unsafe SpriteAnimator ArmorAnimator
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ArmorAnimator_Public_get_SpriteAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num3);
    }
  }

  public unsafe float ArmorPoints
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ArmorPoints_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsArmorDestroyClipFinished
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_IsArmorDestroyClipFinished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ArmorBreakVariant ArmorDestroyVariant
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113556, XrefRangeEnd = 113557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ArmorDestroyVariant_Public_get_ArmorBreakVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new ArmorBreakVariant(pointer);
    }
  }

  public unsafe ArmorBreakVariant FallbackDestroyVariant
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_FallbackDestroyVariant_Public_get_ArmorBreakVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new ArmorBreakVariant(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113557, XrefRangeEnd = 113567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_InitLayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113567, XrefRangeEnd = 113569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActivateLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_ActivateLayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113569, XrefRangeEnd = 113577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113581, RefRangeEnd = 113582, XrefRangeStart = 113577, XrefRangeEnd = 113581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateLayer(MeshClip rootClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootClip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_UpdateLayer_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113591, RefRangeEnd = 113592, XrefRangeStart = 113582, XrefRangeEnd = 113591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveLayer(Vector3 center, int rotation, ArmorBreakVariant breakVariant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) breakVariant));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_RemoveLayer_Public_Void_Vector3_Int32_ArmorBreakVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113592, XrefRangeEnd = 113616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnFrameUpdated(MeshClipFrame currentFrame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentFrame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_OnFrameUpdated_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe Transform ProviderTransform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113616, XrefRangeEnd = 113618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe Rigidbody ProviderRigidbody
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num3);
    }
  }

  public virtual unsafe Vector3 ImpactPosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113618, XrefRangeEnd = 113620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe int ImpactDirection
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113620, XrefRangeEnd = 113622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113622, XrefRangeEnd = 113623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArmorLayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArmorLayer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorLayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InjectionClipsDictionary armorClipsDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorClipsDictionary));
      return num == System.IntPtr.Zero ? (InjectionClipsDictionary) null : Il2CppObjectPool.Get<InjectionClipsDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorClipsDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteAnimator armorAnimator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorAnimator));
      return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float armorPoints
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorPoints));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorPoints)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<ArmorBreakVariant> armorDestroyVariants
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorDestroyVariants));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArmorBreakVariant>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArmorBreakVariant>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_armorDestroyVariants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public ArmorBreakVariant fallbackDestroyVariant
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_fallbackDestroyVariant);
      return new ArmorBreakVariant(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_fallbackDestroyVariant), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe float CurrentArmorPoints
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_CurrentArmorPoints));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_CurrentArmorPoints)) = value;
    }
  }

  public unsafe Vector3 localPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_localPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_localPos)) = value;
    }
  }

  public unsafe Vector3 backPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_backPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_backPos)) = value;
    }
  }

  public unsafe bool isActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_isActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorLayer.NativeFieldInfoPtr_isActive)) = value;
    }
  }
}
