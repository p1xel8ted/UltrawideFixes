// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterLayeredAbilityAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Animation;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterLayeredAbilityAnimationController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rootAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerClips;
  private static readonly System.IntPtr NativeFieldInfoPtr_abilityStateController;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRootClipStarted_Private_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLayer_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LayerOffset_Private_Void_Transform_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLayer_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpOffset_Private_IEnumerator_Transform_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterLayeredAbilityAnimationController()
  {
    Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterLayeredAbilityAnimationController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr);
    CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_rootAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, nameof (rootAnimator));
    CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_layerAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, nameof (layerAnimator));
    CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_layerClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, nameof (layerClips));
    CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_abilityStateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, nameof (abilityStateController));
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675361);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675362);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_OnRootClipStarted_Private_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675363);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_UpdateLayer_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675364);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_LayerOffset_Private_Void_Transform_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675365);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_RemoveLayer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675366);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_LerpOffset_Private_IEnumerator_Transform_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675367);
    CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, 100675368);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117091, XrefRangeEnd = 117102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117102, XrefRangeEnd = 117110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117110, XrefRangeEnd = 117111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnRootClipStarted(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_OnRootClipStarted_Private_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117142, RefRangeEnd = 117143, XrefRangeStart = 117111, XrefRangeEnd = 117142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateLayer(MeshClip rootClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootClip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_UpdateLayer_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 117147, RefRangeEnd = 117150, XrefRangeStart = 117143, XrefRangeEnd = 117147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LayerOffset(Transform rendererTransform, MeshClip meshClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rendererTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshClip);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_LayerOffset_Private_Void_Transform_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117150, XrefRangeEnd = 117154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveLayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_RemoveLayer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117154, XrefRangeEnd = 117158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator LerpOffset(Transform rendererTransform, MeshClip meshClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rendererTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshClip);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr_LerpOffset_Private_IEnumerator_Transform_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterLayeredAbilityAnimationController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteAnimator rootAnimator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_rootAnimator));
      return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_rootAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteAnimator layerAnimator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_layerAnimator));
      return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_layerAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InjectionClipsDictionary layerClips
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_layerClips));
      return num == System.IntPtr.Zero ? (InjectionClipsDictionary) null : Il2CppObjectPool.Get<InjectionClipsDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_layerClips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AbilityStateController abilityStateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_abilityStateController));
      return num == System.IntPtr.Zero ? (AbilityStateController) null : Il2CppObjectPool.Get<AbilityStateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController.NativeFieldInfoPtr_abilityStateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterLayeredAbilityAnimationController+<LerpOffset>d__10")]
  public sealed class _LerpOffset_d__10(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_meshClip;
    private static readonly System.IntPtr NativeFieldInfoPtr_rendererTransform;
    private static readonly System.IntPtr NativeFieldInfoPtr__duration_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _LerpOffset_d__10()
    {
      Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController>.NativeClassPtr, "<LerpOffset>d__10");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr);
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, "<>1__state");
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, "<>2__current");
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr_meshClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, nameof (meshClip));
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr_rendererTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, nameof (rendererTransform));
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, "<duration>5__2");
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, "<timer>5__3");
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, 100675369);
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, 100675370);
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, 100675371);
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, 100675372);
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, 100675373);
      CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr, 100675374);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _LerpOffset_d__10(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterLayeredAbilityAnimationController._LerpOffset_d__10>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117074, XrefRangeEnd = 117086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117086, XrefRangeEnd = 117091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip meshClip
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr_meshClip));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr_meshClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform rendererTransform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr_rendererTransform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr_rendererTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _duration_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr__duration_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr__duration_5__2)) = value;
      }
    }

    public unsafe float _timer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr__timer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterLayeredAbilityAnimationController._LerpOffset_d__10.NativeFieldInfoPtr__timer_5__3)) = value;
      }
    }
  }
}
