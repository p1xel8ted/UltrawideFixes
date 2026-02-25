// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.Controllers.Character.CharacterSecondaryAnimatorController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.Controllers.Character;

public class CharacterSecondaryAnimatorController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_rootAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_secondaryAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_idleAnimation;
  private static readonly IntPtr NativeFieldInfoPtr_secondaryAnimationNames;
  private static readonly IntPtr NativeFieldInfoPtr_latestClip;
  private static readonly IntPtr NativeFieldInfoPtr_idleHash;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnUpdated_Private_Void_MeshClipFrame_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnRootClipStarted_Private_Void_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterSecondaryAnimatorController()
  {
    Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.Controllers.Character", nameof (CharacterSecondaryAnimatorController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr);
    CharacterSecondaryAnimatorController.NativeFieldInfoPtr_rootAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (rootAnimator));
    CharacterSecondaryAnimatorController.NativeFieldInfoPtr_secondaryAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (secondaryAnimator));
    CharacterSecondaryAnimatorController.NativeFieldInfoPtr_idleAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (idleAnimation));
    CharacterSecondaryAnimatorController.NativeFieldInfoPtr_secondaryAnimationNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (secondaryAnimationNames));
    CharacterSecondaryAnimatorController.NativeFieldInfoPtr_latestClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (latestClip));
    CharacterSecondaryAnimatorController.NativeFieldInfoPtr_idleHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (idleHash));
    CharacterSecondaryAnimatorController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, 100670742);
    CharacterSecondaryAnimatorController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, 100670743);
    CharacterSecondaryAnimatorController.NativeMethodInfoPtr_OnUpdated_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, 100670744);
    CharacterSecondaryAnimatorController.NativeMethodInfoPtr_OnRootClipStarted_Private_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, 100670745);
    CharacterSecondaryAnimatorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, 100670746);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87886, XrefRangeEnd = 87907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSecondaryAnimatorController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87907, XrefRangeEnd = 87927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSecondaryAnimatorController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87927, XrefRangeEnd = 87930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnUpdated(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSecondaryAnimatorController.NativeMethodInfoPtr_OnUpdated_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87930, XrefRangeEnd = 87936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnRootClipStarted(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSecondaryAnimatorController.NativeMethodInfoPtr_OnRootClipStarted_Private_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterSecondaryAnimatorController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSecondaryAnimatorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteAnimator rootAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_rootAnimator));
      return num == IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_rootAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Animator secondaryAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_secondaryAnimator));
      return num == IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_secondaryAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string idleAnimation
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_idleAnimation)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_idleAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe CharacterSecondaryAnimatorController.InjectionAnimationDictionary secondaryAnimationNames
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_secondaryAnimationNames));
      return num == IntPtr.Zero ? (CharacterSecondaryAnimatorController.InjectionAnimationDictionary) null : Il2CppObjectPool.Get<CharacterSecondaryAnimatorController.InjectionAnimationDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_secondaryAnimationNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip latestClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_latestClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_latestClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int idleHash
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_idleHash));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSecondaryAnimatorController.NativeFieldInfoPtr_idleHash)) = value;
    }
  }

  [Serializable]
  public class InjectionAnimationDictionary(IntPtr pointer) : 
    UnitySerializedDictionary<MeshClip, string>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static InjectionAnimationDictionary()
    {
      Il2CppClassPointerStore<CharacterSecondaryAnimatorController.InjectionAnimationDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterSecondaryAnimatorController>.NativeClassPtr, nameof (InjectionAnimationDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSecondaryAnimatorController.InjectionAnimationDictionary>.NativeClassPtr);
      CharacterSecondaryAnimatorController.InjectionAnimationDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSecondaryAnimatorController.InjectionAnimationDictionary>.NativeClassPtr, 100670747);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87883, XrefRangeEnd = 87886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InjectionAnimationDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSecondaryAnimatorController.InjectionAnimationDictionary>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterSecondaryAnimatorController.InjectionAnimationDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
