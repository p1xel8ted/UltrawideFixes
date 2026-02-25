// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.CrowdData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class CrowdData(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Actors;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CrowdData()
  {
    Il2CppClassPointerStore<CrowdData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (CrowdData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdData>.NativeClassPtr);
    CrowdData.NativeFieldInfoPtr_Actors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData>.NativeClassPtr, nameof (Actors));
    CrowdData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdData>.NativeClassPtr, 100675955);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CrowdData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CrowdData.CrowdActor> Actors
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.NativeFieldInfoPtr_Actors));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CrowdData.CrowdActor>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CrowdData.CrowdActor>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.NativeFieldInfoPtr_Actors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class CrowdActor(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_WalkAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr_WalkToIdleAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdleAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdleToWalkAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr_Palettes;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static CrowdActor()
    {
      Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrowdData>.NativeClassPtr, nameof (CrowdActor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr);
      CrowdData.CrowdActor.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, nameof (Prefab));
      CrowdData.CrowdActor.NativeFieldInfoPtr_WalkAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, nameof (WalkAnimation));
      CrowdData.CrowdActor.NativeFieldInfoPtr_WalkToIdleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, nameof (WalkToIdleAnimation));
      CrowdData.CrowdActor.NativeFieldInfoPtr_IdleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, nameof (IdleAnimation));
      CrowdData.CrowdActor.NativeFieldInfoPtr_IdleToWalkAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, nameof (IdleToWalkAnimation));
      CrowdData.CrowdActor.NativeFieldInfoPtr_Palettes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, nameof (Palettes));
      CrowdData.CrowdActor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr, 100675956);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CrowdActor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdData.CrowdActor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CrowdData.CrowdActor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject Prefab
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_Prefab));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_Prefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip WalkAnimation
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_WalkAnimation));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_WalkAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip WalkToIdleAnimation
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_WalkToIdleAnimation));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_WalkToIdleAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip IdleAnimation
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_IdleAnimation));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_IdleAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip IdleToWalkAnimation
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_IdleToWalkAnimation));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_IdleToWalkAnimation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Texture2D> Palettes
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_Palettes));
        return num == System.IntPtr.Zero ? (List<Texture2D>) null : Il2CppObjectPool.Get<List<Texture2D>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdData.CrowdActor.NativeFieldInfoPtr_Palettes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
