// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.SignalFlareDimmer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Rendering;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class SignalFlareDimmer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_dimmingCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_dimmingTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_minRadiusTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_flameParticleSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightSourceData;
  private static readonly System.IntPtr NativeFieldInfoPtr_angleTurn;
  private static readonly System.IntPtr NativeFieldInfoPtr_angleTurnSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightFlareAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftFlareAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_characterRotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereCollider;
  private static readonly System.IntPtr NativeFieldInfoPtr_flameMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_startingRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_startingIntensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_angle;
  private static readonly System.IntPtr NativeFieldInfoPtr_angleId;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartDimming_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dimming_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SignalFlareDimmer()
  {
    Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (SignalFlareDimmer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr);
    SignalFlareDimmer.NativeFieldInfoPtr_dimmingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (dimmingCurve));
    SignalFlareDimmer.NativeFieldInfoPtr_dimmingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (dimmingTime));
    SignalFlareDimmer.NativeFieldInfoPtr_minRadiusTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (minRadiusTarget));
    SignalFlareDimmer.NativeFieldInfoPtr_flameParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (flameParticleSystem));
    SignalFlareDimmer.NativeFieldInfoPtr_lightSourceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (lightSourceData));
    SignalFlareDimmer.NativeFieldInfoPtr_angleTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (angleTurn));
    SignalFlareDimmer.NativeFieldInfoPtr_angleTurnSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (angleTurnSpeed));
    SignalFlareDimmer.NativeFieldInfoPtr_rightFlareAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (rightFlareAngle));
    SignalFlareDimmer.NativeFieldInfoPtr_leftFlareAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (leftFlareAngle));
    SignalFlareDimmer.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (animationController));
    SignalFlareDimmer.NativeFieldInfoPtr_characterRotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (characterRotationController));
    SignalFlareDimmer.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (walkController));
    SignalFlareDimmer.NativeFieldInfoPtr_sphereCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (sphereCollider));
    SignalFlareDimmer.NativeFieldInfoPtr_flameMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (flameMaterial));
    SignalFlareDimmer.NativeFieldInfoPtr_startingRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (startingRadius));
    SignalFlareDimmer.NativeFieldInfoPtr_startingIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (startingIntensity));
    SignalFlareDimmer.NativeFieldInfoPtr_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (angle));
    SignalFlareDimmer.NativeFieldInfoPtr_angleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, nameof (angleId));
    SignalFlareDimmer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, 100675618);
    SignalFlareDimmer.NativeMethodInfoPtr_StartDimming_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, 100675619);
    SignalFlareDimmer.NativeMethodInfoPtr_Dimming_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, 100675620);
    SignalFlareDimmer.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, 100675621);
    SignalFlareDimmer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, 100675622);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118456, XrefRangeEnd = 118464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118464, XrefRangeEnd = 118494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartDimming()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer.NativeMethodInfoPtr_StartDimming_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118494, XrefRangeEnd = 118498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Dimming()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer.NativeMethodInfoPtr_Dimming_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118498, XrefRangeEnd = 118503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118503, XrefRangeEnd = 118505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SignalFlareDimmer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve dimmingCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_dimmingCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_dimmingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float dimmingTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_dimmingTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_dimmingTime)) = value;
    }
  }

  public unsafe float minRadiusTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_minRadiusTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_minRadiusTarget)) = value;
    }
  }

  public unsafe ParticleSystem flameParticleSystem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_flameParticleSystem));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_flameParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LightExtraData lightSourceData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_lightSourceData));
      return num == System.IntPtr.Zero ? (LightExtraData) null : Il2CppObjectPool.Get<LightExtraData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_lightSourceData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float angleTurn
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_angleTurn));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_angleTurn)) = value;
    }
  }

  public unsafe float angleTurnSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_angleTurnSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_angleTurnSpeed)) = value;
    }
  }

  public unsafe float rightFlareAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_rightFlareAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_rightFlareAngle)) = value;
    }
  }

  public unsafe float leftFlareAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_leftFlareAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_leftFlareAngle)) = value;
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController characterRotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_characterRotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_characterRotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SphereCollider sphereCollider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_sphereCollider));
      return num == System.IntPtr.Zero ? (SphereCollider) null : Il2CppObjectPool.Get<SphereCollider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_sphereCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material flameMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_flameMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_flameMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float startingRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_startingRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_startingRadius)) = value;
    }
  }

  public unsafe float startingIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_startingIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_startingIntensity)) = value;
    }
  }

  public unsafe float angle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_angle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer.NativeFieldInfoPtr_angle)) = value;
    }
  }

  public static unsafe int angleId
  {
    get
    {
      int angleId;
      IL2CPP.il2cpp_field_static_get_value(SignalFlareDimmer.NativeFieldInfoPtr_angleId, (void*) &angleId);
      return angleId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SignalFlareDimmer.NativeFieldInfoPtr_angleId, (void*) &value);
    }
  }

  [ObfuscatedName("SadCatStudios.Character.SignalFlareDimmer+<Dimming>d__20")]
  public sealed class _Dimming_d__20(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Dimming_d__20()
    {
      Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SignalFlareDimmer>.NativeClassPtr, "<Dimming>d__20");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr);
      SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, "<>1__state");
      SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, "<>2__current");
      SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, "<>4__this");
      SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, "<timer>5__2");
      SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, 100675624);
      SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, 100675625);
      SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, 100675626);
      SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, 100675627);
      SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, 100675628);
      SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr, 100675629);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Dimming_d__20(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SignalFlareDimmer._Dimming_d__20>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118445, XrefRangeEnd = 118451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118451, XrefRangeEnd = 118456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SignalFlareDimmer._Dimming_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SignalFlareDimmer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SignalFlareDimmer) null : Il2CppObjectPool.Get<SignalFlareDimmer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SignalFlareDimmer._Dimming_d__20.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }
}
