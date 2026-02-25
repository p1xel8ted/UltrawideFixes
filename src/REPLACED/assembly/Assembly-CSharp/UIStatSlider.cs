// Decompiled with JetBrains decompiler
// Type: UIStatSlider
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
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class UIStatSlider(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_statReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_statMaxValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_slider;
  private static readonly System.IntPtr NativeFieldInfoPtr_anim;
  private static readonly System.IntPtr NativeFieldInfoPtr_addAnimationTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_drainAnimationTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr_statFillingImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_statFillingMoveCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_effectOnFillFinish;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipParticleOverValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveParticleBelowValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveParticleTo;
  private static readonly System.IntPtr NativeFieldInfoPtr_prompt;
  private static readonly System.IntPtr NativeFieldInfoPtr_disabledAlpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_fourCorners;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastSliderValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationRunning;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FillStatAnim_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAnimation_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrainAnimation_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIStatSlider()
  {
    Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UIStatSlider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr);
    UIStatSlider.NativeFieldInfoPtr_statReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (statReference));
    UIStatSlider.NativeFieldInfoPtr_statMaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (statMaxValue));
    UIStatSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (slider));
    UIStatSlider.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (anim));
    UIStatSlider.NativeFieldInfoPtr_addAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (addAnimationTrigger));
    UIStatSlider.NativeFieldInfoPtr_drainAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (drainAnimationTrigger));
    UIStatSlider.NativeFieldInfoPtr_statFillingImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (statFillingImage));
    UIStatSlider.NativeFieldInfoPtr_statFillingMoveCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (statFillingMoveCurve));
    UIStatSlider.NativeFieldInfoPtr_effectOnFillFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (effectOnFillFinish));
    UIStatSlider.NativeFieldInfoPtr_skipParticleOverValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (skipParticleOverValue));
    UIStatSlider.NativeFieldInfoPtr_moveParticleBelowValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (moveParticleBelowValue));
    UIStatSlider.NativeFieldInfoPtr_moveParticleTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (moveParticleTo));
    UIStatSlider.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (prompt));
    UIStatSlider.NativeFieldInfoPtr_disabledAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (disabledAlpha));
    UIStatSlider.NativeFieldInfoPtr_fourCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (fourCorners));
    UIStatSlider.NativeFieldInfoPtr_lastSliderValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (lastSliderValue));
    UIStatSlider.NativeFieldInfoPtr_initialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (initialPosition));
    UIStatSlider.NativeFieldInfoPtr_animationRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, nameof (animationRunning));
    UIStatSlider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, 100663503 /*0x060000CF*/);
    UIStatSlider.NativeMethodInfoPtr_FillStatAnim_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, 100663504 /*0x060000D0*/);
    UIStatSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, 100663505 /*0x060000D1*/);
    UIStatSlider.NativeMethodInfoPtr_AddAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, 100663506 /*0x060000D2*/);
    UIStatSlider.NativeMethodInfoPtr_DrainAnimation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, 100663507 /*0x060000D3*/);
    UIStatSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, 100663508 /*0x060000D4*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20118, XrefRangeEnd = 20120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIStatSlider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20120, XrefRangeEnd = 20124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FillStatAnim()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIStatSlider.NativeMethodInfoPtr_FillStatAnim_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20124, XrefRangeEnd = 20143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIStatSlider.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20146, XrefRangeStart = 20143, XrefRangeEnd = 20145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIStatSlider.NativeMethodInfoPtr_AddAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 20148, RefRangeEnd = 20149, XrefRangeStart = 20146, XrefRangeEnd = 20148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DrainAnimation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIStatSlider.NativeMethodInfoPtr_DrainAnimation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20149, XrefRangeEnd = 20153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIStatSlider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIStatSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference statReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statReference));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference statMaxValue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statMaxValue));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statMaxValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider slider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_slider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Animator anim
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_anim));
      return num == System.IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string addAnimationTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_addAnimationTrigger)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_addAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string drainAnimationTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_drainAnimationTrigger)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_drainAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Image statFillingImage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statFillingImage));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statFillingImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve statFillingMoveCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statFillingMoveCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_statFillingMoveCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem effectOnFillFinish
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_effectOnFillFinish));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_effectOnFillFinish), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float skipParticleOverValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_skipParticleOverValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_skipParticleOverValue)) = value;
    }
  }

  public unsafe float moveParticleBelowValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_moveParticleBelowValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_moveParticleBelowValue)) = value;
    }
  }

  public unsafe Vector3 moveParticleTo
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_moveParticleTo));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_moveParticleTo)) = value;
    }
  }

  public unsafe TextMeshProUGUI prompt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_prompt));
      return num == System.IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float disabledAlpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_disabledAlpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_disabledAlpha)) = value;
    }
  }

  public unsafe Il2CppStructArray<Vector3> fourCorners
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_fourCorners));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_fourCorners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float lastSliderValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_lastSliderValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_lastSliderValue)) = value;
    }
  }

  public unsafe Vector3 initialPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_initialPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_initialPosition)) = value;
    }
  }

  public unsafe bool animationRunning
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_animationRunning));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider.NativeFieldInfoPtr_animationRunning)) = value;
    }
  }

  [ObfuscatedName("UIStatSlider+<FillStatAnim>d__19")]
  public sealed class _FillStatAnim_d__19(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__statFillFinalPos_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__overTime_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _FillStatAnim_d__19()
    {
      Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIStatSlider>.NativeClassPtr, "<FillStatAnim>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr);
      UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, "<>1__state");
      UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, "<>2__current");
      UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, "<>4__this");
      UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__statFillFinalPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, "<statFillFinalPos>5__2");
      UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, "<timer>5__3");
      UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__overTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, "<overTime>5__4");
      UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, 100663509 /*0x060000D5*/);
      UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, 100663510 /*0x060000D6*/);
      UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, 100663511 /*0x060000D7*/);
      UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, 100663512 /*0x060000D8*/);
      UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, 100663513 /*0x060000D9*/);
      UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr, 100663514 /*0x060000DA*/);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _FillStatAnim_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIStatSlider._FillStatAnim_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20102, XrefRangeEnd = 20113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20113, XrefRangeEnd = 20118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIStatSlider._FillStatAnim_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIStatSlider __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIStatSlider) null : Il2CppObjectPool.Get<UIStatSlider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _statFillFinalPos_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__statFillFinalPos_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__statFillFinalPos_5__2)) = value;
      }
    }

    public unsafe float _timer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__timer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__timer_5__3)) = value;
      }
    }

    public unsafe float _overTime_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__overTime_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIStatSlider._FillStatAnim_d__19.NativeFieldInfoPtr__overTime_5__4)) = value;
      }
    }
  }
}
