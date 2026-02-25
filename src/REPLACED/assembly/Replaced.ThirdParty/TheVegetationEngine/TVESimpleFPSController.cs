// Decompiled with JetBrains decompiler
// Type: TheVegetationEngine.TVESimpleFPSController
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace TheVegetationEngine;

public class TVESimpleFPSController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_walkingSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_lookSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_lookXLimit;
  private static readonly IntPtr NativeFieldInfoPtr_playerCamera;
  private static readonly IntPtr NativeFieldInfoPtr_characterController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationX;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TVESimpleFPSController()
  {
    Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "TheVegetationEngine", nameof (TVESimpleFPSController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr);
    TVESimpleFPSController.NativeFieldInfoPtr_walkingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, nameof (walkingSpeed));
    TVESimpleFPSController.NativeFieldInfoPtr_lookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, nameof (lookSpeed));
    TVESimpleFPSController.NativeFieldInfoPtr_lookXLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, nameof (lookXLimit));
    TVESimpleFPSController.NativeFieldInfoPtr_playerCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, nameof (playerCamera));
    TVESimpleFPSController.NativeFieldInfoPtr_characterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, nameof (characterController));
    TVESimpleFPSController.NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, nameof (rotationX));
    TVESimpleFPSController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, 100673660);
    TVESimpleFPSController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, 100673661);
    TVESimpleFPSController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr, 100673662);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403232, XrefRangeEnd = 403237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleFPSController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403237, XrefRangeEnd = 403267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleFPSController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403267, XrefRangeEnd = 403268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TVESimpleFPSController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVESimpleFPSController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TVESimpleFPSController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float walkingSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_walkingSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_walkingSpeed)) = value;
    }
  }

  public unsafe float lookSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_lookSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_lookSpeed)) = value;
    }
  }

  public unsafe float lookXLimit
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_lookXLimit));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_lookXLimit)) = value;
    }
  }

  public unsafe Camera playerCamera
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_playerCamera));
      return num == IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_playerCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterController characterController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_characterController));
      return num == IntPtr.Zero ? (CharacterController) null : Il2CppObjectPool.Get<CharacterController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_characterController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float rotationX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_rotationX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TVESimpleFPSController.NativeFieldInfoPtr_rotationX)) = value;
    }
  }
}
