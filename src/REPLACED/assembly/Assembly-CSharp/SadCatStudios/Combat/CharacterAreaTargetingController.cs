// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterAreaTargetingController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterAreaTargetingController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_grenade;
  private static readonly System.IntPtr NativeFieldInfoPtr_grenadeDelayed;
  private static readonly System.IntPtr NativeFieldInfoPtr_centralZonePoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_totalTimeReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_patterns;
  private static readonly System.IntPtr NativeFieldInfoPtr_debug;
  private static readonly System.IntPtr NativeFieldInfoPtr_patternIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxRange_Private_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowGrenade_Public_UniTaskVoid_Vector3_GunData_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disappear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Appear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Announce_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAreaTargetingController()
  {
    Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterAreaTargetingController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr);
    CharacterAreaTargetingController.NativeFieldInfoPtr_grenade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (grenade));
    CharacterAreaTargetingController.NativeFieldInfoPtr_grenadeDelayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (grenadeDelayed));
    CharacterAreaTargetingController.NativeFieldInfoPtr_centralZonePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (centralZonePoint));
    CharacterAreaTargetingController.NativeFieldInfoPtr_totalTimeReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (totalTimeReference));
    CharacterAreaTargetingController.NativeFieldInfoPtr_patterns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (patterns));
    CharacterAreaTargetingController.NativeFieldInfoPtr_debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (debug));
    CharacterAreaTargetingController.NativeFieldInfoPtr_patternIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (patternIndex));
    CharacterAreaTargetingController.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (hitboxController));
    CharacterAreaTargetingController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (animationController));
    CharacterAreaTargetingController.NativeMethodInfoPtr_get_MaxRange_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677789);
    CharacterAreaTargetingController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677790);
    CharacterAreaTargetingController.NativeMethodInfoPtr_ThrowGrenade_Public_UniTaskVoid_Vector3_GunData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677791);
    CharacterAreaTargetingController.NativeMethodInfoPtr_Disappear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677792);
    CharacterAreaTargetingController.NativeMethodInfoPtr_Appear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677793);
    CharacterAreaTargetingController.NativeMethodInfoPtr_Announce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677794);
    CharacterAreaTargetingController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, 100677795);
  }

  public unsafe int MaxRange
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131512, XrefRangeEnd = 131513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr_get_MaxRange_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131513, XrefRangeEnd = 131519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131519, XrefRangeEnd = 131522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid ThrowGrenade(Vector3 targetPoint, GunData grenadeData, float delayTime = 0.0f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &targetPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) grenadeData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delayTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr_ThrowGrenade_Public_UniTaskVoid_Vector3_GunData_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131524, RefRangeEnd = 131525, XrefRangeStart = 131522, XrefRangeEnd = 131524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disappear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr_Disappear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131544, RefRangeEnd = 131545, XrefRangeStart = 131525, XrefRangeEnd = 131544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Appear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr_Appear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Announce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr_Announce_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAreaTargetingController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GunData grenade
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_grenade));
      return num == System.IntPtr.Zero ? (GunData) null : Il2CppObjectPool.Get<GunData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_grenade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GunData grenadeDelayed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_grenadeDelayed));
      return num == System.IntPtr.Zero ? (GunData) null : Il2CppObjectPool.Get<GunData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_grenadeDelayed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform centralZonePoint
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_centralZonePoint));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_centralZonePoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference totalTimeReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_totalTimeReference));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_totalTimeReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CharacterAreaTargetingController.Pattern> patterns
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_patterns));
      return num == System.IntPtr.Zero ? (List<CharacterAreaTargetingController.Pattern>) null : Il2CppObjectPool.Get<List<CharacterAreaTargetingController.Pattern>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_patterns), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool debug
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_debug));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_debug)) = value;
    }
  }

  public unsafe int patternIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_patternIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_patternIndex)) = value;
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_hitboxController));
      return num == System.IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class Pattern : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Points;

    static Pattern()
    {
      Il2CppClassPointerStore<CharacterAreaTargetingController.Pattern>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (Pattern));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAreaTargetingController.Pattern>.NativeClassPtr);
      CharacterAreaTargetingController.Pattern.NativeFieldInfoPtr_TotalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController.Pattern>.NativeClassPtr, nameof (TotalTime));
      CharacterAreaTargetingController.Pattern.NativeFieldInfoPtr_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController.Pattern>.NativeClassPtr, nameof (Points));
    }

    public Pattern(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Pattern()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAreaTargetingController.Pattern>.NativeClassPtr))
    {
    }

    public unsafe float TotalTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.Pattern.NativeFieldInfoPtr_TotalTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.Pattern.NativeFieldInfoPtr_TotalTime)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<CharacterAreaTargetingController.TargetPoint> Points
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.Pattern.NativeFieldInfoPtr_Points));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CharacterAreaTargetingController.TargetPoint>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterAreaTargetingController.TargetPoint>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.Pattern.NativeFieldInfoPtr_Points), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class TargetPoint : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Point;
    private static readonly System.IntPtr NativeFieldInfoPtr_Delay;

    static TargetPoint()
    {
      Il2CppClassPointerStore<CharacterAreaTargetingController.TargetPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, nameof (TargetPoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAreaTargetingController.TargetPoint>.NativeClassPtr);
      CharacterAreaTargetingController.TargetPoint.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController.TargetPoint>.NativeClassPtr, nameof (Point));
      CharacterAreaTargetingController.TargetPoint.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController.TargetPoint>.NativeClassPtr, nameof (Delay));
    }

    public TargetPoint(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TargetPoint()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAreaTargetingController.TargetPoint>.NativeClassPtr))
    {
    }

    public unsafe Transform Point
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.TargetPoint.NativeFieldInfoPtr_Point));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.TargetPoint.NativeFieldInfoPtr_Point), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Delay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.TargetPoint.NativeFieldInfoPtr_Delay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController.TargetPoint.NativeFieldInfoPtr_Delay)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterAreaTargetingController+<ThrowGrenade>d__14")]
  public sealed class _ThrowGrenade_d__14 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_delayTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_grenadeData;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _ThrowGrenade_d__14()
    {
      Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAreaTargetingController>.NativeClassPtr, "<ThrowGrenade>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr);
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, "<>1__state");
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, "<>t__builder");
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, "<>4__this");
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_delayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, nameof (delayTime));
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_grenadeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, nameof (grenadeData));
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_targetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, nameof (targetPoint));
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, "<>u__1");
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, "<>u__2");
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, 100677796);
      CharacterAreaTargetingController._ThrowGrenade_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr, 100677797);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131467, XrefRangeEnd = 131512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _ThrowGrenade_d__14(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _ThrowGrenade_d__14()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAreaTargetingController._ThrowGrenade_d__14>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CharacterAreaTargetingController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAreaTargetingController) null : Il2CppObjectPool.Get<CharacterAreaTargetingController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float delayTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_delayTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_delayTime)) = value;
      }
    }

    public unsafe GunData grenadeData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_grenadeData));
        return num == System.IntPtr.Zero ? (GunData) null : Il2CppObjectPool.Get<GunData>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_grenadeData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 targetPoint
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_targetPoint));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr_targetPoint)) = value;
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__1)) = value;
      }
    }

    public UniTask.Awaiter __u__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__2);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAreaTargetingController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
