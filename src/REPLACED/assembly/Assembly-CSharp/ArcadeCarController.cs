// Decompiled with JetBrains decompiler
// Type: ArcadeCarController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ArcadeCarController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_autorotateCheckDistance;
  private static readonly IntPtr NativeFieldInfoPtr_rotateCheckDistance;
  private static readonly IntPtr NativeFieldInfoPtr_carSound;
  private static readonly IntPtr NativeFieldInfoPtr_soundInstance;
  private static readonly IntPtr NativeFieldInfoPtr_moveDirection;
  private static readonly IntPtr NativeFieldInfoPtr_col;
  private static readonly IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly IntPtr NativeMethodInfoPtr_get_colSize_Private_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveAndRotate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckFrontalCollisionAndAutorotate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeCarController()
  {
    Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ArcadeCarController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr);
    ArcadeCarController.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (speed));
    ArcadeCarController.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (rotationSpeed));
    ArcadeCarController.NativeFieldInfoPtr_autorotateCheckDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (autorotateCheckDistance));
    ArcadeCarController.NativeFieldInfoPtr_rotateCheckDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (rotateCheckDistance));
    ArcadeCarController.NativeFieldInfoPtr_carSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (carSound));
    ArcadeCarController.NativeFieldInfoPtr_soundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (soundInstance));
    ArcadeCarController.NativeFieldInfoPtr_moveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (moveDirection));
    ArcadeCarController.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (col));
    ArcadeCarController.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, nameof (layerMask));
    ArcadeCarController.NativeMethodInfoPtr_get_colSize_Private_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663398 /*0x06000066*/);
    ArcadeCarController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663399 /*0x06000067*/);
    ArcadeCarController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663400 /*0x06000068*/);
    ArcadeCarController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663401 /*0x06000069*/);
    ArcadeCarController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663402 /*0x0600006A*/);
    ArcadeCarController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663403 /*0x0600006B*/);
    ArcadeCarController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663404 /*0x0600006C*/);
    ArcadeCarController.NativeMethodInfoPtr_MoveAndRotate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663405 /*0x0600006D*/);
    ArcadeCarController.NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663406 /*0x0600006E*/);
    ArcadeCarController.NativeMethodInfoPtr_CheckFrontalCollisionAndAutorotate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663407 /*0x0600006F*/);
    ArcadeCarController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr, 100663408 /*0x06000070*/);
  }

  public unsafe Vector2 colSize
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16305, XrefRangeEnd = 16308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_get_colSize_Private_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16308, XrefRangeEnd = 16322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16322, XrefRangeEnd = 16323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16323, XrefRangeEnd = 16324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16324, XrefRangeEnd = 16325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16325, XrefRangeEnd = 16328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16341, RefRangeEnd = 16342, XrefRangeStart = 16328, XrefRangeEnd = 16341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveAndRotate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_MoveAndRotate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16371, RefRangeEnd = 16372, XrefRangeStart = 16342, XrefRangeEnd = 16371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16414, RefRangeEnd = 16415, XrefRangeStart = 16372, XrefRangeEnd = 16414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckFrontalCollisionAndAutorotate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr_CheckFrontalCollisionAndAutorotate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16415, XrefRangeEnd = 16416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeCarController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeCarController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCarController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe float rotationSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_rotationSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_rotationSpeed)) = value;
    }
  }

  public unsafe float autorotateCheckDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_autorotateCheckDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_autorotateCheckDistance)) = value;
    }
  }

  public unsafe float rotateCheckDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_rotateCheckDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_rotateCheckDistance)) = value;
    }
  }

  public unsafe EventReference carSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_carSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_carSound)) = value;
    }
  }

  public unsafe EventInstance soundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_soundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_soundInstance)) = value;
    }
  }

  public unsafe Vector3 moveDirection
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_moveDirection));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_moveDirection)) = value;
    }
  }

  public unsafe BoxCollider2D col
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_col));
      return num == IntPtr.Zero ? (BoxCollider2D) null : Il2CppObjectPool.Get<BoxCollider2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCarController.NativeFieldInfoPtr_layerMask)) = value;
    }
  }
}
