// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterAimingController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Animation;
using SadCatStudios.Combat;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterAimingController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lineRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_lazerColors;
  private static readonly System.IntPtr NativeFieldInfoPtr_startupAimDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_deflectTiming;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimPointIndicator;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimAppearCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimDisappearCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_shotAnnounceReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_linePoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_lineLeftRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_lineAppear;
  private static readonly System.IntPtr NativeFieldInfoPtr_lineTiling;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeAim;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetingAnimating;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableAim_Public_Void_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndAnnounce_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FramePostUpdated_Private_Void_MeshClipFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnimateTargeting_Private_IEnumerator_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForActiveWindow_Private_IEnumerator_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAimingController()
  {
    Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterAimingController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr);
    CharacterAimingController.NativeFieldInfoPtr_lineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (lineRenderer));
    CharacterAimingController.NativeFieldInfoPtr_lazerColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (lazerColors));
    CharacterAimingController.NativeFieldInfoPtr_startupAimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (startupAimDuration));
    CharacterAimingController.NativeFieldInfoPtr_deflectTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (deflectTiming));
    CharacterAimingController.NativeFieldInfoPtr_aimPointIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (aimPointIndicator));
    CharacterAimingController.NativeFieldInfoPtr_aimAppearCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (aimAppearCurve));
    CharacterAimingController.NativeFieldInfoPtr_aimDisappearCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (aimDisappearCurve));
    CharacterAimingController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (animationController));
    CharacterAimingController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (rotationController));
    CharacterAimingController.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (hitboxController));
    CharacterAimingController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (sensorController));
    CharacterAimingController.NativeFieldInfoPtr_shotAnnounceReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (shotAnnounceReceiver));
    CharacterAimingController.NativeFieldInfoPtr_linePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (linePoints));
    CharacterAimingController.NativeFieldInfoPtr_lineLeftRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (lineLeftRight));
    CharacterAimingController.NativeFieldInfoPtr_lineAppear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (lineAppear));
    CharacterAimingController.NativeFieldInfoPtr_lineTiling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (lineTiling));
    CharacterAimingController.NativeFieldInfoPtr_activeAim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (activeAim));
    CharacterAimingController.NativeFieldInfoPtr_targetingAnimating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, nameof (targetingAnimating));
    CharacterAimingController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674743);
    CharacterAimingController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674744);
    CharacterAimingController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674745);
    CharacterAimingController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674746);
    CharacterAimingController.NativeMethodInfoPtr_EnableAim_Public_Void_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674747);
    CharacterAimingController.NativeMethodInfoPtr_EndAnnounce_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674748);
    CharacterAimingController.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674749);
    CharacterAimingController.NativeMethodInfoPtr_FramePostUpdated_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674750);
    CharacterAimingController.NativeMethodInfoPtr_AnimateTargeting_Private_IEnumerator_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674751);
    CharacterAimingController.NativeMethodInfoPtr_WaitForActiveWindow_Private_IEnumerator_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674752);
    CharacterAimingController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674753);
    CharacterAimingController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674754);
    CharacterAimingController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, 100674755);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113115, XrefRangeEnd = 113127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113127, XrefRangeEnd = 113135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113135, XrefRangeEnd = 113143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113143, XrefRangeEnd = 113144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113144, XrefRangeEnd = 113163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableAim(FloatReference totalAimDuration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) totalAimDuration)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_EnableAim_Public_Void_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 113175, RefRangeEnd = 113177, XrefRangeStart = 113163, XrefRangeEnd = 113175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndAnnounce(bool skipAnimation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &skipAnimation
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_EndAnnounce_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113177, XrefRangeEnd = 113178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113178, XrefRangeEnd = 113220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FramePostUpdated(MeshClipFrame currFrame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currFrame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_FramePostUpdated_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 113224, RefRangeEnd = 113226, XrefRangeStart = 113220, XrefRangeEnd = 113224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator AnimateTargeting(bool isOn, bool skipAnimation = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &isOn;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &skipAnimation;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_AnimateTargeting_Private_IEnumerator_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113226, XrefRangeEnd = 113230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForActiveWindow(FloatReference totalAimDuration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) totalAimDuration)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_WaitForActiveWindow_Private_IEnumerator_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnRespawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_OnRespawn_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113230, XrefRangeEnd = 113236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnKill(DeathType deathType = DeathType.Undefined)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deathType
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr_OnKill_Public_Virtual_Final_New_Void_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113236, XrefRangeEnd = 113240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAimingController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAimingController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LineRenderer lineRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_lineRenderer));
      return num == System.IntPtr.Zero ? (LineRenderer) null : Il2CppObjectPool.Get<LineRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_lineRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Gradient> lazerColors
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_lazerColors));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Gradient>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Gradient>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_lazerColors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference startupAimDuration
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_startupAimDuration));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_startupAimDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference deflectTiming
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_deflectTiming));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_deflectTiming), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference aimPointIndicator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_aimPointIndicator));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_aimPointIndicator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve aimAppearCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_aimAppearCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_aimAppearCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve aimDisappearCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_aimDisappearCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_aimDisappearCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_hitboxController));
      return num == System.IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_sensorController));
      return num == System.IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IShotAnnounceReceiver shotAnnounceReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_shotAnnounceReceiver));
      return num == System.IntPtr.Zero ? (IShotAnnounceReceiver) null : Il2CppObjectPool.Get<IShotAnnounceReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_shotAnnounceReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> linePoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_linePoints));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_linePoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int lineLeftRight
  {
    get
    {
      int lineLeftRight;
      IL2CPP.il2cpp_field_static_get_value(CharacterAimingController.NativeFieldInfoPtr_lineLeftRight, (void*) &lineLeftRight);
      return lineLeftRight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterAimingController.NativeFieldInfoPtr_lineLeftRight, (void*) &value);
    }
  }

  public static unsafe int lineAppear
  {
    get
    {
      int lineAppear;
      IL2CPP.il2cpp_field_static_get_value(CharacterAimingController.NativeFieldInfoPtr_lineAppear, (void*) &lineAppear);
      return lineAppear;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterAimingController.NativeFieldInfoPtr_lineAppear, (void*) &value);
    }
  }

  public static unsafe int lineTiling
  {
    get
    {
      int lineTiling;
      IL2CPP.il2cpp_field_static_get_value(CharacterAimingController.NativeFieldInfoPtr_lineTiling, (void*) &lineTiling);
      return lineTiling;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterAimingController.NativeFieldInfoPtr_lineTiling, (void*) &value);
    }
  }

  public unsafe bool activeAim
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_activeAim));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_activeAim)) = value;
    }
  }

  public unsafe bool targetingAnimating
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_targetingAnimating));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController.NativeFieldInfoPtr_targetingAnimating)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterAimingController+<AnimateTargeting>d__26")]
  public sealed class _AnimateTargeting_d__26(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_isOn;
    private static readonly System.IntPtr NativeFieldInfoPtr_skipAnimation;
    private static readonly System.IntPtr NativeFieldInfoPtr__mat_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__curve_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__animationTime_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__t_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _AnimateTargeting_d__26()
    {
      Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, "<AnimateTargeting>d__26");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr);
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<>1__state");
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<>2__current");
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<>4__this");
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, nameof (isOn));
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr_skipAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, nameof (skipAnimation));
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__mat_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<mat>5__2");
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__curve_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<curve>5__3");
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__animationTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<animationTime>5__4");
      CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__t_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, "<t>5__5");
      CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, 100674757);
      CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, 100674758);
      CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, 100674759);
      CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, 100674760);
      CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, 100674761);
      CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr, 100674762);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _AnimateTargeting_d__26(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAimingController._AnimateTargeting_d__26>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113083, XrefRangeEnd = 113103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113103, XrefRangeEnd = 113108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._AnimateTargeting_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAimingController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAimingController) null : Il2CppObjectPool.Get<CharacterAimingController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool isOn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr_isOn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr_isOn)) = value;
      }
    }

    public unsafe bool skipAnimation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr_skipAnimation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr_skipAnimation)) = value;
      }
    }

    public unsafe Material _mat_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__mat_5__2));
        return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__mat_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve _curve_5__3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__curve_5__3));
        return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__curve_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _animationTime_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__animationTime_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__animationTime_5__4)) = value;
      }
    }

    public unsafe float _t_5__5
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__t_5__5));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._AnimateTargeting_d__26.NativeFieldInfoPtr__t_5__5)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterAimingController+<WaitForActiveWindow>d__27")]
  public sealed class _WaitForActiveWindow_d__27(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_totalAimDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForActiveWindow_d__27()
    {
      Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAimingController>.NativeClassPtr, "<WaitForActiveWindow>d__27");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr);
      CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, "<>1__state");
      CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, "<>2__current");
      CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, "<>4__this");
      CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr_totalAimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, nameof (totalAimDuration));
      CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, "<timer>5__2");
      CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, 100674763);
      CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, 100674764);
      CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, 100674765);
      CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, 100674766);
      CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, 100674767);
      CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr, 100674768);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForActiveWindow_d__27(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAimingController._WaitForActiveWindow_d__27>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113108, XrefRangeEnd = 113110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113110, XrefRangeEnd = 113115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAimingController._WaitForActiveWindow_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAimingController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAimingController) null : Il2CppObjectPool.Get<CharacterAimingController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FloatReference totalAimDuration
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr_totalAimDuration));
        return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr_totalAimDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAimingController._WaitForActiveWindow_d__27.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }
}
