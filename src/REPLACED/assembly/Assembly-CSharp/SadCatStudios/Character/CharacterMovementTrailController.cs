// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterMovementTrailController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.Effects;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterMovementTrailController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_trailFrequency;
  private static readonly IntPtr NativeFieldInfoPtr_trailColor;
  private static readonly IntPtr NativeFieldInfoPtr_trailCollection;
  private static readonly IntPtr NativeFieldInfoPtr_material;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_lastPos;
  private static readonly IntPtr NativeFieldInfoPtr_currentTrail;
  private static readonly IntPtr NativeFieldInfoPtr_lastTrailPos;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoCollectionTrail_Private_Void_MeshClipFrame_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterMovementTrailController()
  {
    Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterMovementTrailController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr);
    CharacterMovementTrailController.NativeFieldInfoPtr_trailFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (trailFrequency));
    CharacterMovementTrailController.NativeFieldInfoPtr_trailColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (trailColor));
    CharacterMovementTrailController.NativeFieldInfoPtr_trailCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (trailCollection));
    CharacterMovementTrailController.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (material));
    CharacterMovementTrailController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (animationController));
    CharacterMovementTrailController.NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (lastPos));
    CharacterMovementTrailController.NativeFieldInfoPtr_currentTrail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (currentTrail));
    CharacterMovementTrailController.NativeFieldInfoPtr_lastTrailPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, nameof (lastTrailPos));
    CharacterMovementTrailController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, 100675429);
    CharacterMovementTrailController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, 100675430);
    CharacterMovementTrailController.NativeMethodInfoPtr_DoCollectionTrail_Private_Void_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, 100675431);
    CharacterMovementTrailController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, 100675432);
    CharacterMovementTrailController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, 100675433);
    CharacterMovementTrailController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr, 100675434);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117410, XrefRangeEnd = 117425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovementTrailController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117425, XrefRangeEnd = 117427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovementTrailController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117427, XrefRangeEnd = 117444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DoCollectionTrail(MeshClipFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovementTrailController.NativeMethodInfoPtr_DoCollectionTrail_Private_Void_MeshClipFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117444, XrefRangeEnd = 117456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovementTrailController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117456, XrefRangeEnd = 117479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovementTrailController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117479, XrefRangeEnd = 117480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterMovementTrailController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMovementTrailController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovementTrailController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float trailFrequency
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_trailFrequency));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_trailFrequency)) = value;
    }
  }

  public unsafe Color trailColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_trailColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_trailColor)) = value;
    }
  }

  public unsafe VFXSurfaceCollection trailCollection
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_trailCollection));
      return num == IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_trailCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PhysicsMaterial material
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_material));
      return num == IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 lastPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_lastPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_lastPos)) = value;
    }
  }

  public unsafe IPoolable currentTrail
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_currentTrail));
      return num == IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_currentTrail), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 lastTrailPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_lastTrailPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovementTrailController.NativeFieldInfoPtr_lastTrailPos)) = value;
    }
  }
}
