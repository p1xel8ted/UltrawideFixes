// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterBlinkController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Effects;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterBlinkController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_trailSprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_trailColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_wallBlinkOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_trailCollection;
  private static readonly System.IntPtr NativeFieldInfoPtr_material;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly System.IntPtr NativeFieldInfoPtr_originPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_wallsDetected;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftWall;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightWall;
  private static readonly System.IntPtr NativeFieldInfoPtr_wallsLayerMask;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitBlinkSprites_Public_Void_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlinkToTarget_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlinkBack_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryDetectWalls_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Blink_Private_IEnumerator_Vector3_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterBlinkController()
  {
    Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterBlinkController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr);
    CharacterBlinkController.NativeFieldInfoPtr_trailSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (trailSprites));
    CharacterBlinkController.NativeFieldInfoPtr_trailColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (trailColor));
    CharacterBlinkController.NativeFieldInfoPtr_wallBlinkOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (wallBlinkOffset));
    CharacterBlinkController.NativeFieldInfoPtr_trailCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (trailCollection));
    CharacterBlinkController.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (material));
    CharacterBlinkController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (animationController));
    CharacterBlinkController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (rotationController));
    CharacterBlinkController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (sensorController));
    CharacterBlinkController.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (hitboxController));
    CharacterBlinkController.NativeFieldInfoPtr_originPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (originPos));
    CharacterBlinkController.NativeFieldInfoPtr_wallsDetected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (wallsDetected));
    CharacterBlinkController.NativeFieldInfoPtr_leftWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (leftWall));
    CharacterBlinkController.NativeFieldInfoPtr_rightWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (rightWall));
    CharacterBlinkController.NativeFieldInfoPtr_wallsLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, nameof (wallsLayerMask));
    CharacterBlinkController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674859);
    CharacterBlinkController.NativeMethodInfoPtr_InitBlinkSprites_Public_Void_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674860);
    CharacterBlinkController.NativeMethodInfoPtr_BlinkToTarget_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674861);
    CharacterBlinkController.NativeMethodInfoPtr_BlinkBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674862);
    CharacterBlinkController.NativeMethodInfoPtr_TryDetectWalls_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674863);
    CharacterBlinkController.NativeMethodInfoPtr_Blink_Private_IEnumerator_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674864);
    CharacterBlinkController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, 100674865);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113828, XrefRangeEnd = 113849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void InitBlinkSprites(Il2CppReferenceArray<Sprite> sprites)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprites)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr_InitBlinkSprites_Public_Void_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113873, RefRangeEnd = 113874, XrefRangeStart = 113849, XrefRangeEnd = 113873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BlinkToTarget(float targetOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetOffset
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr_BlinkToTarget_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 113901, RefRangeEnd = 113902, XrefRangeStart = 113874, XrefRangeEnd = 113901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BlinkBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr_BlinkBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 113921, RefRangeEnd = 113923, XrefRangeStart = 113902, XrefRangeEnd = 113921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TryDetectWalls()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr_TryDetectWalls_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113923, XrefRangeEnd = 113927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Blink(Vector3 targetPos, int framesCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &targetPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &framesCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr_Blink_Private_IEnumerator_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113927, XrefRangeEnd = 113928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterBlinkController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Sprite> trailSprites
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_trailSprites));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_trailSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color trailColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_trailColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_trailColor)) = value;
    }
  }

  public unsafe float wallBlinkOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_wallBlinkOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_wallBlinkOffset)) = value;
    }
  }

  public unsafe VFXSurfaceCollection trailCollection
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_trailCollection));
      return num == System.IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_trailCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PhysicsMaterial material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_material));
      return num == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_sensorController));
      return num == System.IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_hitboxController));
      return num == System.IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 originPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_originPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_originPos)) = value;
    }
  }

  public unsafe bool wallsDetected
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_wallsDetected));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_wallsDetected)) = value;
    }
  }

  public unsafe Vector3 leftWall
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_leftWall));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_leftWall)) = value;
    }
  }

  public unsafe Vector3 rightWall
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_rightWall));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_rightWall)) = value;
    }
  }

  public unsafe LayerMask wallsLayerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_wallsLayerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController.NativeFieldInfoPtr_wallsLayerMask)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterBlinkController+<Blink>d__19")]
  public sealed class _Blink_d__19(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_framesCount;
    private static readonly System.IntPtr NativeFieldInfoPtr__step_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__lastTrailPos_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__currentTrail_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Blink_d__19()
    {
      Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterBlinkController>.NativeClassPtr, "<Blink>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr);
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<>1__state");
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<>2__current");
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<>4__this");
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr_targetPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, nameof (targetPos));
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr_framesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, nameof (framesCount));
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__step_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<step>5__2");
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__lastTrailPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<lastTrailPos>5__3");
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__currentTrail_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<currentTrail>5__4");
      CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, "<i>5__5");
      CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, 100674866);
      CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, 100674867);
      CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, 100674868);
      CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, 100674869);
      CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, 100674870);
      CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr, 100674871);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Blink_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBlinkController._Blink_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113769, XrefRangeEnd = 113823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113823, XrefRangeEnd = 113828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBlinkController._Blink_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterBlinkController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterBlinkController) null : Il2CppObjectPool.Get<CharacterBlinkController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 targetPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr_targetPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr_targetPos)) = value;
      }
    }

    public unsafe int framesCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr_framesCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr_framesCount)) = value;
      }
    }

    public unsafe Vector3 _step_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__step_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__step_5__2)) = value;
      }
    }

    public unsafe Vector3 _lastTrailPos_5__3
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__lastTrailPos_5__3));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__lastTrailPos_5__3)) = value;
      }
    }

    public unsafe IPoolable _currentTrail_5__4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__currentTrail_5__4));
        return num == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__currentTrail_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _i_5__5
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__i_5__5));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBlinkController._Blink_d__19.NativeFieldInfoPtr__i_5__5)) = value;
      }
    }
  }
}
