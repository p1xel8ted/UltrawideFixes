// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Animation;
using SadCatStudios.Effects;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterAnimationController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_footstepDepthOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly System.IntPtr NativeFieldInfoPtr_body;
  private static readonly System.IntPtr NativeFieldInfoPtr_savedImpactEvents;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpriteAnimator_Public_get_SpriteAnimator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClipStarted_Private_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FramePostUpdated_Private_Void_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayClip_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayClipWithLock_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueClip_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueCurrentClip_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopClip_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearSprite_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetClipStatus_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InPoiseFrames_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InParryWindow_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentClip_Public_Virtual_Final_New_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentFrame_Public_Virtual_Final_New_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNextFrame_Public_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AfterCurrentClip_Public_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForCurrentClip_Private_IEnumerator_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetAnchorPosition_Public_Boolean_SliceType_byref_Vector3_byref_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnchorEffectForCurrentFrame_Public_Void_AssetReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAnchor_Public_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAnimationController()
  {
    Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterAnimationController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr);
    CharacterAnimationController.NativeFieldInfoPtr_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, nameof (spriteAnimator));
    CharacterAnimationController.NativeFieldInfoPtr_footstepDepthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, nameof (footstepDepthOffset));
    CharacterAnimationController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, nameof (rotationController));
    CharacterAnimationController.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, nameof (hitboxController));
    CharacterAnimationController.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, nameof (body));
    CharacterAnimationController.NativeFieldInfoPtr_savedImpactEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, nameof (savedImpactEvents));
    CharacterAnimationController.NativeMethodInfoPtr_get_SpriteAnimator_Public_get_SpriteAnimator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674769);
    CharacterAnimationController.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674770);
    CharacterAnimationController.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674771);
    CharacterAnimationController.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674772);
    CharacterAnimationController.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674773);
    CharacterAnimationController.NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674774);
    CharacterAnimationController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674775);
    CharacterAnimationController.NativeMethodInfoPtr_ClipStarted_Private_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674776);
    CharacterAnimationController.NativeMethodInfoPtr_FramePostUpdated_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674777);
    CharacterAnimationController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674778);
    CharacterAnimationController.NativeMethodInfoPtr_PlayClip_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674779);
    CharacterAnimationController.NativeMethodInfoPtr_PlayClipWithLock_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674780);
    CharacterAnimationController.NativeMethodInfoPtr_ContinueClip_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674781);
    CharacterAnimationController.NativeMethodInfoPtr_ContinueCurrentClip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674782);
    CharacterAnimationController.NativeMethodInfoPtr_StopClip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674783);
    CharacterAnimationController.NativeMethodInfoPtr_ClearSprite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674784);
    CharacterAnimationController.NativeMethodInfoPtr_GetClipStatus_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674785);
    CharacterAnimationController.NativeMethodInfoPtr_InPoiseFrames_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674786);
    CharacterAnimationController.NativeMethodInfoPtr_InParryWindow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674787);
    CharacterAnimationController.NativeMethodInfoPtr_GetCurrentClip_Public_Virtual_Final_New_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674788);
    CharacterAnimationController.NativeMethodInfoPtr_GetCurrentFrame_Public_Virtual_Final_New_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674789);
    CharacterAnimationController.NativeMethodInfoPtr_GetNextFrame_Public_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674790);
    CharacterAnimationController.NativeMethodInfoPtr_AfterCurrentClip_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674791);
    CharacterAnimationController.NativeMethodInfoPtr_WaitForCurrentClip_Private_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674792);
    CharacterAnimationController.NativeMethodInfoPtr_TryGetAnchorPosition_Public_Boolean_SliceType_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674793);
    CharacterAnimationController.NativeMethodInfoPtr_AnchorEffectForCurrentFrame_Public_Void_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674794);
    CharacterAnimationController.NativeMethodInfoPtr_GetAnchor_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674795);
    CharacterAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, 100674796);
  }

  public unsafe SpriteAnimator SpriteAnimator
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_get_SpriteAnimator_Public_get_SpriteAnimator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num3);
    }
  }

  public virtual unsafe Vector3 ImpactPosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113245, XrefRangeEnd = 113249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe int ImpactDirection
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113249, XrefRangeEnd = 113251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Transform ProviderTransform
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe Rigidbody ProviderRigidbody
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num3);
    }
  }

  public unsafe Bounds Bounds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 113252, RefRangeEnd = 113254, XrefRangeStart = 113251, XrefRangeEnd = 113252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_get_Bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113254, XrefRangeEnd = 113287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113287, XrefRangeEnd = 113332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClipStarted(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_ClipStarted_Private_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113332, XrefRangeEnd = 113349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FramePostUpdated(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_FramePostUpdated_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113349, XrefRangeEnd = 113383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 113385, RefRangeEnd = 113392, XrefRangeStart = 113383, XrefRangeEnd = 113385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayClip(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_PlayClip_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113392, XrefRangeEnd = 113394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayClipWithLock(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_PlayClipWithLock_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 113396, RefRangeEnd = 113400, XrefRangeStart = 113394, XrefRangeEnd = 113396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContinueClip(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_ContinueClip_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113400, XrefRangeEnd = 113402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ContinueCurrentClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_ContinueCurrentClip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 113404, RefRangeEnd = 113408, XrefRangeStart = 113402, XrefRangeEnd = 113404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_StopClip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113408, XrefRangeEnd = 113410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_ClearSprite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 113410, RefRangeEnd = 113419, XrefRangeStart = 113410, XrefRangeEnd = 113410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool GetClipStatus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_GetClipStatus_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 113421, RefRangeEnd = 113423, XrefRangeStart = 113419, XrefRangeEnd = 113421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InPoiseFrames()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_InPoiseFrames_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113425, RefRangeEnd = 113426, XrefRangeStart = 113423, XrefRangeEnd = 113425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InParryWindow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_InParryWindow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 113426, RefRangeEnd = 113438, XrefRangeStart = 113426, XrefRangeEnd = 113426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe MeshClip GetCurrentClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_GetCurrentClip_Public_Virtual_Final_New_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 113438, RefRangeEnd = 113465, XrefRangeStart = 113438, XrefRangeEnd = 113438, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe MeshClipFrame GetCurrentFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_GetCurrentFrame_Public_Virtual_Final_New_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 113465, RefRangeEnd = 113467, XrefRangeStart = 113465, XrefRangeEnd = 113465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipFrame GetNextFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_GetNextFrame_Public_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113472, RefRangeEnd = 113473, XrefRangeStart = 113467, XrefRangeEnd = 113472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AfterCurrentClip(Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_AfterCurrentClip_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113473, XrefRangeEnd = 113477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForCurrentClip(Il2CppSystem.Action callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_WaitForCurrentClip_Private_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 113484, RefRangeEnd = 113487, XrefRangeStart = 113477, XrefRangeEnd = 113484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetAnchorPosition(
    MeshClipFrame.SliceType type,
    out Vector3 pos,
    out Quaternion rot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref rot;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_TryGetAnchorPosition_Public_Boolean_SliceType_byref_Vector3_byref_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 113505, RefRangeEnd = 113507, XrefRangeStart = 113487, XrefRangeEnd = 113505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AnchorEffectForCurrentFrame(AssetReference vfx)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vfx)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_AnchorEffectForCurrentFrame_Public_Void_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113507, XrefRangeEnd = 113526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetAnchor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr_GetAnchor_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113526, XrefRangeEnd = 113527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAnimationController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteAnimator spriteAnimator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_spriteAnimator));
      return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float footstepDepthOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_footstepDepthOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_footstepDepthOffset)) = value;
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_hitboxController));
      return num == System.IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody body
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_body));
      return num == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<ImpactEvent> savedImpactEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_savedImpactEvents));
      return num == System.IntPtr.Zero ? (HashSet<ImpactEvent>) null : Il2CppObjectPool.Get<HashSet<ImpactEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController.NativeFieldInfoPtr_savedImpactEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterAnimationController+<WaitForCurrentClip>d__35")]
  public sealed class _WaitForCurrentClip_d__35(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForCurrentClip_d__35()
    {
      Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAnimationController>.NativeClassPtr, "<WaitForCurrentClip>d__35");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr);
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, "<>1__state");
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, "<>2__current");
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, "<>4__this");
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, nameof (callback));
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, 100674797);
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, 100674798);
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, 100674799);
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, 100674800);
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, 100674801);
      CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr, 100674802);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForCurrentClip_d__35(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAnimationController._WaitForCurrentClip_d__35>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113240, XrefRangeEnd = 113245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAnimationController._WaitForCurrentClip_d__35.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAnimationController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAnimationController._WaitForCurrentClip_d__35.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
