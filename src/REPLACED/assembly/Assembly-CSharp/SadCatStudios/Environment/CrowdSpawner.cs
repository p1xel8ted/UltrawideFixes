// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.CrowdSpawner
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
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Jobs;

#nullable disable
namespace SadCatStudios.Environment;

public class CrowdSpawner(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_crowdData;
  private static readonly System.IntPtr NativeFieldInfoPtr_spawnRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_despawnDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_crowdDirection;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorsPalettes;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorsData;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorsSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_speed;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorsGeneratedRandom;
  private static readonly System.IntPtr NativeFieldInfoPtr_generatedRandom;
  private static readonly System.IntPtr NativeFieldInfoPtr_randomOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorsDirection;
  private static readonly System.IntPtr NativeFieldInfoPtr_generatedDirection;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorTransforms;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorAnimators;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorSpriteRenderers;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorTransformAccessArray;
  private static readonly System.IntPtr NativeFieldInfoPtr_jobHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_noPaletteMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_paletteMaterials;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorInitialPositions;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShouldPause;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedActors;
  private static readonly System.IntPtr NativeFieldInfoPtr_shuffleActors;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorAnimationStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_actorAnimationFrames;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_PausedActorsNChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActorTransforms_Public_get_Il2CppReferenceArray_1_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NPausedActors_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CrowdDir_Public_get_CrowdDirection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPalette_Private_Void_SpriteRenderer_Texture2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CrowdSpawner()
  {
    Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (CrowdSpawner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr);
    CrowdSpawner.NativeFieldInfoPtr_crowdData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (crowdData));
    CrowdSpawner.NativeFieldInfoPtr_spawnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (spawnRange));
    CrowdSpawner.NativeFieldInfoPtr_despawnDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (despawnDistance));
    CrowdSpawner.NativeFieldInfoPtr_pauseDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (pauseDistance));
    CrowdSpawner.NativeFieldInfoPtr_speedRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (speedRange));
    CrowdSpawner.NativeFieldInfoPtr_crowdDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (crowdDirection));
    CrowdSpawner.NativeFieldInfoPtr_actorsPalettes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorsPalettes));
    CrowdSpawner.NativeFieldInfoPtr_actorsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorsData));
    CrowdSpawner.NativeFieldInfoPtr_actorsSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorsSpeed));
    CrowdSpawner.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (speed));
    CrowdSpawner.NativeFieldInfoPtr_actorsGeneratedRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorsGeneratedRandom));
    CrowdSpawner.NativeFieldInfoPtr_generatedRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (generatedRandom));
    CrowdSpawner.NativeFieldInfoPtr_randomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (randomOffset));
    CrowdSpawner.NativeFieldInfoPtr_actorsDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorsDirection));
    CrowdSpawner.NativeFieldInfoPtr_generatedDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (generatedDirection));
    CrowdSpawner.NativeFieldInfoPtr_actorTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorTransforms));
    CrowdSpawner.NativeFieldInfoPtr_actorAnimators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorAnimators));
    CrowdSpawner.NativeFieldInfoPtr_actorSpriteRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorSpriteRenderers));
    CrowdSpawner.NativeFieldInfoPtr_actorTransformAccessArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorTransformAccessArray));
    CrowdSpawner.NativeFieldInfoPtr_jobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (jobHandle));
    CrowdSpawner.NativeFieldInfoPtr_noPaletteMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (noPaletteMaterial));
    CrowdSpawner.NativeFieldInfoPtr_paletteMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (paletteMaterials));
    CrowdSpawner.NativeFieldInfoPtr_actorInitialPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorInitialPositions));
    CrowdSpawner.NativeFieldInfoPtr_ShouldPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (ShouldPause));
    CrowdSpawner.NativeFieldInfoPtr_pausedActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (pausedActors));
    CrowdSpawner.NativeFieldInfoPtr_shuffleActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (shuffleActors));
    CrowdSpawner.NativeFieldInfoPtr_actorAnimationStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorAnimationStates));
    CrowdSpawner.NativeFieldInfoPtr_actorAnimationFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (actorAnimationFrames));
    CrowdSpawner.NativeFieldInfoPtr_pausedChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (pausedChanged));
    CrowdSpawner.NativeFieldInfoPtr_PausedActorsNChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (PausedActorsNChanged));
    CrowdSpawner.NativeMethodInfoPtr_get_ActorTransforms_Public_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675957);
    CrowdSpawner.NativeMethodInfoPtr_get_NPausedActors_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675958);
    CrowdSpawner.NativeMethodInfoPtr_get_CrowdDir_Public_get_CrowdDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675959);
    CrowdSpawner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675960);
    CrowdSpawner.NativeMethodInfoPtr_SetPalette_Private_Void_SpriteRenderer_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675961);
    CrowdSpawner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675962);
    CrowdSpawner.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675963);
    CrowdSpawner.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675964);
    CrowdSpawner.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675965);
    CrowdSpawner.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675966);
    CrowdSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, 100675967);
  }

  public unsafe Il2CppReferenceArray<Transform> ActorTransforms
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 72966, RefRangeEnd = 72967, XrefRangeStart = 72966, XrefRangeEnd = 72967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_get_ActorTransforms_Public_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num3);
    }
  }

  public unsafe int NPausedActors
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120448, XrefRangeEnd = 120467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_get_NPausedActors_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe CrowdSpawner.CrowdDirection CrowdDir
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_get_CrowdDir_Public_get_CrowdDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CrowdSpawner.CrowdDirection*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120467, XrefRangeEnd = 120503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 120538, RefRangeEnd = 120540, XrefRangeStart = 120503, XrefRangeEnd = 120538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPalette(SpriteRenderer spriteRenderer, Texture2D palette)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) spriteRenderer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) palette);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_SetPalette_Private_Void_SpriteRenderer_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120540, XrefRangeEnd = 120551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120551, XrefRangeEnd = 120604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120604, XrefRangeEnd = 120624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120624, XrefRangeEnd = 120640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120640, XrefRangeEnd = 120643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120643, XrefRangeEnd = 120656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CrowdSpawner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CrowdData crowdData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_crowdData));
      return num == System.IntPtr.Zero ? (CrowdData) null : Il2CppObjectPool.Get<CrowdData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_crowdData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float spawnRange
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_spawnRange));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_spawnRange)) = value;
    }
  }

  public unsafe float despawnDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_despawnDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_despawnDistance)) = value;
    }
  }

  public unsafe float pauseDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_pauseDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_pauseDistance)) = value;
    }
  }

  public unsafe Vector2 speedRange
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_speedRange));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_speedRange)) = value;
    }
  }

  public unsafe CrowdSpawner.CrowdDirection crowdDirection
  {
    get
    {
      return *(CrowdSpawner.CrowdDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_crowdDirection));
    }
    [param: In] set
    {
      *(CrowdSpawner.CrowdDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_crowdDirection)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Texture2D> actorsPalettes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsPalettes));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Texture2D>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsPalettes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<CrowdData.CrowdActor> actorsData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsData));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CrowdData.CrowdActor>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CrowdData.CrowdActor>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> actorsSpeed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsSpeed));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public NativeArray<float> speed
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_speed);
      return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_speed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppStructArray<float> actorsGeneratedRandom
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsGeneratedRandom));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsGeneratedRandom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public NativeArray<float> generatedRandom
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_generatedRandom);
      return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_generatedRandom), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe int randomOffset
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_randomOffset));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_randomOffset)) = value;
    }
  }

  public unsafe Il2CppStructArray<bool> actorsDirection
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsDirection));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<bool>) null : Il2CppObjectPool.Get<Il2CppStructArray<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorsDirection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public NativeArray<bool> generatedDirection
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_generatedDirection);
      return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_generatedDirection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> actorTransforms
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorTransforms));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorTransforms), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<SpriteAnimator> actorAnimators
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorAnimators));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SpriteAnimator>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteAnimator>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorAnimators), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<SpriteRenderer> actorSpriteRenderers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorSpriteRenderers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SpriteRenderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorSpriteRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TransformAccessArray actorTransformAccessArray
  {
    get
    {
      return *(TransformAccessArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorTransformAccessArray));
    }
    [param: In] set
    {
      *(TransformAccessArray*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorTransformAccessArray)) = value;
    }
  }

  public unsafe JobHandle jobHandle
  {
    get
    {
      return *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_jobHandle));
    }
    [param: In] set
    {
      *(JobHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_jobHandle)) = value;
    }
  }

  public unsafe Dictionary<SpriteRenderer, Material> noPaletteMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_noPaletteMaterial));
      return num == System.IntPtr.Zero ? (Dictionary<SpriteRenderer, Material>) null : Il2CppObjectPool.Get<Dictionary<SpriteRenderer, Material>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_noPaletteMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Texture2D, Material> paletteMaterials
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_paletteMaterials));
      return num == System.IntPtr.Zero ? (Dictionary<Texture2D, Material>) null : Il2CppObjectPool.Get<Dictionary<Texture2D, Material>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_paletteMaterials), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> actorInitialPositions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorInitialPositions));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorInitialPositions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool ShouldPause
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_ShouldPause));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_ShouldPause)) = value;
    }
  }

  public NativeArray<bool> pausedActors
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_pausedActors);
      return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_pausedActors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<bool> shuffleActors
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_shuffleActors);
      return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_shuffleActors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<CrowdSpawner.PedestrianAnimation> actorAnimationStates
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorAnimationStates);
      return new NativeArray<CrowdSpawner.PedestrianAnimation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<CrowdSpawner.PedestrianAnimation>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorAnimationStates), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CrowdSpawner.PedestrianAnimation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Il2CppSystem.ValueTuple<int, int>> actorAnimationFrames
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorAnimationFrames);
      return new NativeArray<Il2CppSystem.ValueTuple<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Il2CppSystem.ValueTuple<int, int>>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_actorAnimationFrames), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Il2CppSystem.ValueTuple<int, int>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeReference<bool> pausedChanged
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_pausedChanged);
      return new NativeReference<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_pausedChanged), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Il2CppSystem.Action<int> PausedActorsNChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_PausedActorsNChanged));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.NativeFieldInfoPtr_PausedActorsNChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum CrowdDirection
  {
    LeftToRight,
    RightToLeft,
    Both,
  }

  public enum PedestrianAnimation
  {
    Walk,
    WalkToIdle,
    Idle,
    IdleToWalk,
  }

  public sealed class CrowdMoveJob : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_GeneratedDirection;
    private static readonly System.IntPtr NativeFieldInfoPtr_PausedActors;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShuffleActors;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActorAnimationFrames;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActorAnimationStates;
    private static readonly System.IntPtr NativeFieldInfoPtr_PausedChanged;
    private static readonly System.IntPtr NativeFieldInfoPtr_DeltaTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnerPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_DespawnDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_PauseDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShouldPause;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0;

    static CrowdMoveJob()
    {
      Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, nameof (CrowdMoveJob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr);
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (Speed));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_GeneratedRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (GeneratedRandom));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_GeneratedDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (GeneratedDirection));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PausedActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (PausedActors));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ShuffleActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (ShuffleActors));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ActorAnimationFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (ActorAnimationFrames));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ActorAnimationStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (ActorAnimationStates));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PausedChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (PausedChanged));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (DeltaTime));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_SpawnerPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (SpawnerPos));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_DespawnDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (DespawnDistance));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_RandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (RandomOffset));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PauseDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (PauseDistance));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_SpawnRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (SpawnRange));
      CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ShouldPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, nameof (ShouldPause));
      CrowdSpawner.CrowdMoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr, 100675968);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120418, XrefRangeEnd = 120448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(int index, TransformAccess transform)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transform;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.CrowdMoveJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_TransformAccess_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public CrowdMoveJob(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CrowdMoveJob()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdSpawner.CrowdMoveJob>.NativeClassPtr))
    {
    }

    public NativeArray<float> Speed
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_Speed);
        return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_Speed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeArray<float> GeneratedRandom
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_GeneratedRandom);
        return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_GeneratedRandom), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeArray<bool> GeneratedDirection
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_GeneratedDirection);
        return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_GeneratedDirection), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeArray<bool> PausedActors
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PausedActors);
        return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PausedActors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeArray<bool> ShuffleActors
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ShuffleActors);
        return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ShuffleActors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeArray<Il2CppSystem.ValueTuple<int, int>> ActorAnimationFrames
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ActorAnimationFrames);
        return new NativeArray<Il2CppSystem.ValueTuple<int, int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Il2CppSystem.ValueTuple<int, int>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ActorAnimationFrames), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Il2CppSystem.ValueTuple<int, int>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeArray<CrowdSpawner.PedestrianAnimation> ActorAnimationStates
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ActorAnimationStates);
        return new NativeArray<CrowdSpawner.PedestrianAnimation>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<CrowdSpawner.PedestrianAnimation>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ActorAnimationStates), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<CrowdSpawner.PedestrianAnimation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public NativeReference<bool> PausedChanged
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PausedChanged);
        return new NativeReference<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PausedChanged), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float DeltaTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_DeltaTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_DeltaTime)) = value;
      }
    }

    public unsafe Vector3 SpawnerPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_SpawnerPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_SpawnerPos)) = value;
      }
    }

    public unsafe float DespawnDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_DespawnDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_DespawnDistance)) = value;
      }
    }

    public unsafe int RandomOffset
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_RandomOffset));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_RandomOffset)) = value;
      }
    }

    public unsafe float PauseDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PauseDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_PauseDistance)) = value;
      }
    }

    public unsafe float SpawnRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_SpawnRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_SpawnRange)) = value;
      }
    }

    public unsafe bool ShouldPause
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ShouldPause));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdSpawner.CrowdMoveJob.NativeFieldInfoPtr_ShouldPause)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Environment.CrowdSpawner+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__33_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_NPausedActors_b__33_0_Internal_Boolean_Boolean_0;

    static __c()
    {
      Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CrowdSpawner>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr);
      CrowdSpawner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr, "<>9");
      CrowdSpawner.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr, "<>9__33_0");
      CrowdSpawner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr, 100675970);
      CrowdSpawner.__c.NativeMethodInfoPtr__get_NPausedActors_b__33_0_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr, 100675971);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdSpawner.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _get_NPausedActors_b__33_0(bool paused)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &paused
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CrowdSpawner.__c.NativeMethodInfoPtr__get_NPausedActors_b__33_0_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CrowdSpawner.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CrowdSpawner.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CrowdSpawner.__c) null : Il2CppObjectPool.Get<CrowdSpawner.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CrowdSpawner.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<bool, bool> __9__33_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CrowdSpawner.__c.NativeFieldInfoPtr___9__33_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<bool, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CrowdSpawner.__c.NativeFieldInfoPtr___9__33_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
