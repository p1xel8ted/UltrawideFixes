// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterEmissionDistanceController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterEmissionDistanceController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_easingCurve;
  private static readonly IntPtr NativeFieldInfoPtr_emissionMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_saturationDistance;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly IntPtr NativeFieldInfoPtr_EmissionIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_mat;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateEmissionIntensity_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterEmissionDistanceController()
  {
    Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterEmissionDistanceController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr);
    CharacterEmissionDistanceController.NativeFieldInfoPtr_easingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (easingCurve));
    CharacterEmissionDistanceController.NativeFieldInfoPtr_emissionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (emissionMultiplier));
    CharacterEmissionDistanceController.NativeFieldInfoPtr_saturationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (saturationDistance));
    CharacterEmissionDistanceController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (animationController));
    CharacterEmissionDistanceController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (sensorController));
    CharacterEmissionDistanceController.NativeFieldInfoPtr_EmissionIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (EmissionIntensity));
    CharacterEmissionDistanceController.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, nameof (mat));
    CharacterEmissionDistanceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, 100674988);
    CharacterEmissionDistanceController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, 100674989);
    CharacterEmissionDistanceController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, 100674990);
    CharacterEmissionDistanceController.NativeMethodInfoPtr_UpdateEmissionIntensity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, 100674991);
    CharacterEmissionDistanceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr, 100674992);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114515, XrefRangeEnd = 114525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterEmissionDistanceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114525, XrefRangeEnd = 114526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterEmissionDistanceController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114526, XrefRangeEnd = 114536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterEmissionDistanceController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 114542, RefRangeEnd = 114544, XrefRangeStart = 114536, XrefRangeEnd = 114542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateEmissionIntensity(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterEmissionDistanceController.NativeMethodInfoPtr_UpdateEmissionIntensity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114544, XrefRangeEnd = 114546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterEmissionDistanceController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterEmissionDistanceController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterEmissionDistanceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve easingCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_easingCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_easingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float emissionMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_emissionMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_emissionMultiplier)) = value;
    }
  }

  public unsafe float saturationDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_saturationDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_saturationDistance)) = value;
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_sensorController));
      return num == IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int EmissionIntensity
  {
    get
    {
      int emissionIntensity;
      IL2CPP.il2cpp_field_static_get_value(CharacterEmissionDistanceController.NativeFieldInfoPtr_EmissionIntensity, (void*) &emissionIntensity);
      return emissionIntensity;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterEmissionDistanceController.NativeFieldInfoPtr_EmissionIntensity, (void*) &value);
    }
  }

  public unsafe Material mat
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_mat));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterEmissionDistanceController.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
