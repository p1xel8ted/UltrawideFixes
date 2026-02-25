// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ImpactFootstepManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Effects;

public class ImpactFootstepManager(System.IntPtr pointer) : 
  GlobalSingletonBehaviour<ImpactFootstepManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_footstepMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_priorityMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_untaggedGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_loopingBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayFootstepEffect_Public_Void_EventReference_VFXSurfaceCollection_Vector3_Quaternion_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayLoopingFootstep_Public_Void_LoopingEvent_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopAllLoopingEffects_Public_Void_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLoopingBuffer_Public_Void_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopLoopingFootstep_Public_Void_IImpactPositionProvider_StopLoopingEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectionMaterialAtPoint_Public_PhysicsMaterial_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateConnectionMaterial_Private_Void_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayFootstepEffect_Private_Void_PhysicsMaterial_VFXSurfaceCollection_Vector3_Quaternion_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayFootstepSound_Private_Void_EventReference_PhysicsMaterial_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ImpactFootstepManager()
  {
    Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ImpactFootstepManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr);
    ImpactFootstepManager.NativeFieldInfoPtr_footstepMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (footstepMask));
    ImpactFootstepManager.NativeFieldInfoPtr_priorityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (priorityMask));
    ImpactFootstepManager.NativeFieldInfoPtr_untaggedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (untaggedGroup));
    ImpactFootstepManager.NativeFieldInfoPtr_loopingBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (loopingBuffer));
    ImpactFootstepManager.NativeFieldInfoPtr_overlapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (overlapBuffer));
    ImpactFootstepManager.NativeFieldInfoPtr_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (currentMaterial));
    ImpactFootstepManager.NativeMethodInfoPtr_PlayFootstepEffect_Public_Void_EventReference_VFXSurfaceCollection_Vector3_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675695);
    ImpactFootstepManager.NativeMethodInfoPtr_PlayLoopingFootstep_Public_Void_LoopingEvent_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675696 /*0x06003070*/);
    ImpactFootstepManager.NativeMethodInfoPtr_StopAllLoopingEffects_Public_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675697);
    ImpactFootstepManager.NativeMethodInfoPtr_RemoveLoopingBuffer_Public_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675698);
    ImpactFootstepManager.NativeMethodInfoPtr_StopLoopingFootstep_Public_Void_IImpactPositionProvider_StopLoopingEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675699);
    ImpactFootstepManager.NativeMethodInfoPtr_ConnectionMaterialAtPoint_Public_PhysicsMaterial_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675700);
    ImpactFootstepManager.NativeMethodInfoPtr_UpdateConnectionMaterial_Private_Void_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675701);
    ImpactFootstepManager.NativeMethodInfoPtr_PlayFootstepEffect_Private_Void_PhysicsMaterial_VFXSurfaceCollection_Vector3_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675702);
    ImpactFootstepManager.NativeMethodInfoPtr_PlayFootstepSound_Private_Void_EventReference_PhysicsMaterial_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675703);
    ImpactFootstepManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, 100675704);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118874, XrefRangeEnd = 118892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayFootstepEffect(
    EventReference soundEvent,
    VFXSurfaceCollection surfaceCollection,
    Vector3 pos,
    Quaternion rot,
    int direction = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &soundEvent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) surfaceCollection);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_PlayFootstepEffect_Public_Void_EventReference_VFXSurfaceCollection_Vector3_Quaternion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 118917, RefRangeEnd = 118918, XrefRangeStart = 118892, XrefRangeEnd = 118917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayLoopingFootstep(LoopingEvent e, IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_PlayLoopingFootstep_Public_Void_LoopingEvent_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 118956, RefRangeEnd = 118957, XrefRangeStart = 118918, XrefRangeEnd = 118956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopAllLoopingEffects(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_StopAllLoopingEffects_Public_Void_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 118965, RefRangeEnd = 118966, XrefRangeStart = 118957, XrefRangeEnd = 118965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveLoopingBuffer(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_RemoveLoopingBuffer_Public_Void_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 118989, RefRangeEnd = 118990, XrefRangeStart = 118966, XrefRangeEnd = 118989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopLoopingFootstep(
    IImpactPositionProvider positionProvider,
    StopLoopingEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_StopLoopingFootstep_Public_Void_IImpactPositionProvider_StopLoopingEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118990, XrefRangeEnd = 118991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PhysicsMaterial ConnectionMaterialAtPoint(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_ConnectionMaterialAtPoint_Public_PhysicsMaterial_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 119030, RefRangeEnd = 119033, XrefRangeStart = 118991, XrefRangeEnd = 119030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateConnectionMaterial(ref Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_UpdateConnectionMaterial_Private_Void_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119033, XrefRangeEnd = 119045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayFootstepEffect(
    PhysicsMaterial physicMaterial,
    VFXSurfaceCollection surfaceCollection,
    Vector3 pos,
    Quaternion rot,
    int direction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicMaterial);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) surfaceCollection);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_PlayFootstepEffect_Private_Void_PhysicsMaterial_VFXSurfaceCollection_Vector3_Quaternion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119045, XrefRangeEnd = 119050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayFootstepSound(
    EventReference soundEvent,
    PhysicsMaterial physicMaterial,
    Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &soundEvent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicMaterial);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr_PlayFootstepSound_Private_Void_EventReference_PhysicsMaterial_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119050, XrefRangeEnd = 119062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImpactFootstepManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask footstepMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_footstepMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_footstepMask)) = value;
    }
  }

  public unsafe LayerMask priorityMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_priorityMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_priorityMask)) = value;
    }
  }

  public unsafe PhysicsMaterial untaggedGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_untaggedGroup));
      return num == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_untaggedGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Transform, Dictionary<string, ImpactFootstepManager.LoopEffect>> loopingBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_loopingBuffer));
      return num == System.IntPtr.Zero ? (Dictionary<Transform, Dictionary<string, ImpactFootstepManager.LoopEffect>>) null : Il2CppObjectPool.Get<Dictionary<Transform, Dictionary<string, ImpactFootstepManager.LoopEffect>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_loopingBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_overlapBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_overlapBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PhysicsMaterial currentMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_currentMaterial));
      return num == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.NativeFieldInfoPtr_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class LoopEffectArguments : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AttachedEventInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionProvider;
    private static readonly System.IntPtr NativeFieldInfoPtr_SurfaceCollection;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr_Detach;
    private static readonly System.IntPtr NativeFieldInfoPtr_DetachedLifetime;

    static LoopEffectArguments()
    {
      Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (LoopEffectArguments));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr);
      ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_AttachedEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr, nameof (AttachedEventInstance));
      ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_PositionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr, nameof (PositionProvider));
      ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_SurfaceCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr, nameof (SurfaceCollection));
      ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_CurrentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr, nameof (CurrentMaterial));
      ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_Detach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr, nameof (Detach));
      ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_DetachedLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr, nameof (DetachedLifetime));
    }

    public LoopEffectArguments(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LoopEffectArguments()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffectArguments>.NativeClassPtr))
    {
    }

    public unsafe EventInstance AttachedEventInstance
    {
      get
      {
        return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_AttachedEventInstance));
      }
      [param: In] set
      {
        *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_AttachedEventInstance)) = value;
      }
    }

    public unsafe IImpactPositionProvider PositionProvider
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_PositionProvider));
        return num == System.IntPtr.Zero ? (IImpactPositionProvider) null : Il2CppObjectPool.Get<IImpactPositionProvider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_PositionProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VFXSurfaceCollection SurfaceCollection
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_SurfaceCollection));
        return num == System.IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_SurfaceCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PhysicsMaterial CurrentMaterial
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_CurrentMaterial));
        return num == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_CurrentMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool Detach
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_Detach));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_Detach)) = value;
      }
    }

    public unsafe float DetachedLifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_DetachedLifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffectArguments.NativeFieldInfoPtr_DetachedLifetime)) = value;
      }
    }
  }

  public class LoopEffect(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pooledEffect;
    private static readonly System.IntPtr NativeFieldInfoPtr_attachedEventInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr_anchorTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr_stop;
    private static readonly System.IntPtr NativeFieldInfoPtr_detach;
    private static readonly System.IntPtr NativeFieldInfoPtr_detachedLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetReference;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_LoopEffectArguments_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EffectPosition_Protected_Abstract_Virtual_New_get_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackPosition_Public_IEnumerator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AttachedEventInstance_Public_get_EventInstance_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Effect_Public_get_IPoolable_0;

    static LoopEffect()
    {
      Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (LoopEffect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr);
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_pooledEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (pooledEffect));
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_attachedEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (attachedEventInstance));
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_anchorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (anchorTransform));
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (stop));
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_detach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (detach));
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_detachedLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (detachedLifetime));
      ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_AssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, nameof (AssetReference));
      ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr__ctor_Protected_Void_LoopEffectArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, 100675705);
      ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_get_EffectPosition_Protected_Abstract_Virtual_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, 100675706);
      ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_TrackPosition_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, 100675707);
      ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, 100675708);
      ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_get_AttachedEventInstance_Public_get_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, 100675709);
      ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_get_Effect_Public_get_IPoolable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, 100675710);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 118862, RefRangeEnd = 118864, XrefRangeStart = 118840, XrefRangeEnd = 118862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LoopEffect(ImpactFootstepManager.LoopEffectArguments args)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) args))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr__ctor_Protected_Void_LoopEffectArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Vector3 EffectPosition
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_get_EffectPosition_Protected_Abstract_Virtual_New_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118864, XrefRangeEnd = 118868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator TrackPosition()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_TrackPosition_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 16652, RefRangeEnd = 16658, XrefRangeStart = 16652, XrefRangeEnd = 16658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Stop()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe EventInstance AttachedEventInstance
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_get_AttachedEventInstance_Public_get_EventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(EventInstance*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe IPoolable Effect
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect.NativeMethodInfoPtr_get_Effect_Public_get_IPoolable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num3);
      }
    }

    public unsafe IPoolable pooledEffect
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_pooledEffect));
        return num == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_pooledEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EventInstance attachedEventInstance
    {
      get
      {
        return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_attachedEventInstance));
      }
      [param: In] set
      {
        *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_attachedEventInstance)) = value;
      }
    }

    public unsafe Transform anchorTransform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_anchorTransform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_anchorTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool stop
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_stop));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_stop)) = value;
      }
    }

    public unsafe bool detach
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_detach));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_detach)) = value;
      }
    }

    public unsafe float detachedLifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_detachedLifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_detachedLifetime)) = value;
      }
    }

    public unsafe AssetReferenceGameObject AssetReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_AssetReference));
        return num == System.IntPtr.Zero ? (AssetReferenceGameObject) null : Il2CppObjectPool.Get<AssetReferenceGameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect.NativeFieldInfoPtr_AssetReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Effects.ImpactFootstepManager+LoopEffect+<TrackPosition>d__10")]
    public sealed class _TrackPosition_d__10(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static _TrackPosition_d__10()
      {
        Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect>.NativeClassPtr, "<TrackPosition>d__10");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr);
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, "<>1__state");
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, "<>2__current");
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, "<>4__this");
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, 100675711);
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, 100675712 /*0x06003080*/);
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, 100675713);
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, 100675714);
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, 100675715);
        ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr, 100675716);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe _TrackPosition_d__10(int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepManager.LoopEffect._TrackPosition_d__10>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118812, XrefRangeEnd = 118835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118835, XrefRangeEnd = 118840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ImpactFootstepManager.LoopEffect __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (ImpactFootstepManager.LoopEffect) null : Il2CppObjectPool.Get<ImpactFootstepManager.LoopEffect>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.LoopEffect._TrackPosition_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class AnchorTransformLoopEffect(System.IntPtr pointer) : ImpactFootstepManager.LoopEffect(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoopEffectArguments_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EffectPosition_Protected_Virtual_get_Vector3_0;

    static AnchorTransformLoopEffect()
    {
      Il2CppClassPointerStore<ImpactFootstepManager.AnchorTransformLoopEffect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (AnchorTransformLoopEffect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepManager.AnchorTransformLoopEffect>.NativeClassPtr);
      ImpactFootstepManager.AnchorTransformLoopEffect.NativeMethodInfoPtr__ctor_Public_Void_LoopEffectArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.AnchorTransformLoopEffect>.NativeClassPtr, 100675717);
      ImpactFootstepManager.AnchorTransformLoopEffect.NativeMethodInfoPtr_get_EffectPosition_Protected_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.AnchorTransformLoopEffect>.NativeClassPtr, 100675718);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118868, XrefRangeEnd = 118869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnchorTransformLoopEffect(ImpactFootstepManager.LoopEffectArguments args)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepManager.AnchorTransformLoopEffect>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) args))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.AnchorTransformLoopEffect.NativeMethodInfoPtr__ctor_Public_Void_LoopEffectArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public override unsafe Vector3 EffectPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118869, XrefRangeEnd = 118870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactFootstepManager.AnchorTransformLoopEffect.NativeMethodInfoPtr_get_EffectPosition_Protected_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }
  }

  public class PositionLoopEffect(System.IntPtr pointer) : ImpactFootstepManager.LoopEffect(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoopEffectArguments_CharacterAnimationController_Vector3_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EffectPosition_Protected_Virtual_get_Vector3_0;

    static PositionLoopEffect()
    {
      Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImpactFootstepManager>.NativeClassPtr, nameof (PositionLoopEffect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr);
      ImpactFootstepManager.PositionLoopEffect.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr, nameof (offset));
      ImpactFootstepManager.PositionLoopEffect.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr, nameof (animationController));
      ImpactFootstepManager.PositionLoopEffect.NativeMethodInfoPtr__ctor_Public_Void_LoopEffectArguments_CharacterAnimationController_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr, 100675719);
      ImpactFootstepManager.PositionLoopEffect.NativeMethodInfoPtr_get_EffectPosition_Protected_Virtual_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr, 100675720);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118870, XrefRangeEnd = 118872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PositionLoopEffect(
      ImpactFootstepManager.LoopEffectArguments args,
      CharacterAnimationController animationController,
      Vector3 offset)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepManager.PositionLoopEffect>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) args));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animationController);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ImpactFootstepManager.PositionLoopEffect.NativeMethodInfoPtr__ctor_Public_Void_LoopEffectArguments_CharacterAnimationController_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public override unsafe Vector3 EffectPosition
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118872, XrefRangeEnd = 118874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactFootstepManager.PositionLoopEffect.NativeMethodInfoPtr_get_EffectPosition_Protected_Virtual_get_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Vector3 offset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.PositionLoopEffect.NativeFieldInfoPtr_offset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.PositionLoopEffect.NativeFieldInfoPtr_offset)) = value;
      }
    }

    public unsafe CharacterAnimationController animationController
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.PositionLoopEffect.NativeFieldInfoPtr_animationController));
        return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepManager.PositionLoopEffect.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
