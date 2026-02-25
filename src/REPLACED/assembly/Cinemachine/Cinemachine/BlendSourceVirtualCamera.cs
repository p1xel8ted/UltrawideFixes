// Decompiled with JetBrains decompiler
// Type: Cinemachine.BlendSourceVirtualCamera
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class BlendSourceVirtualCamera(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Blend_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Priority_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LookAt_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Follow_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Blend_Public_get_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Blend_Public_set_Void_CinemachineBlend_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAt_Public_Virtual_Final_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Follow_Public_Virtual_Final_New_get_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_CameraState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VirtualCameraGameObject_Public_Virtual_Final_New_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentCamera_Public_Virtual_Final_New_get_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Final_New_Boolean_ICinemachineCamera_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraState_Public_Virtual_Final_New_Void_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Final_New_Void_ICinemachineCamera_Vector3_Single_0;

  static BlendSourceVirtualCamera()
  {
    Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (BlendSourceVirtualCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr);
    BlendSourceVirtualCamera.NativeFieldInfoPtr__Blend_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, "<Blend>k__BackingField");
    BlendSourceVirtualCamera.NativeFieldInfoPtr__Priority_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, "<Priority>k__BackingField");
    BlendSourceVirtualCamera.NativeFieldInfoPtr__LookAt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, "<LookAt>k__BackingField");
    BlendSourceVirtualCamera.NativeFieldInfoPtr__Follow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, "<Follow>k__BackingField");
    BlendSourceVirtualCamera.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, "<State>k__BackingField");
    BlendSourceVirtualCamera.NativeMethodInfoPtr__ctor_Public_Void_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663922);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Blend_Public_get_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663923);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_set_Blend_Public_set_Void_CinemachineBlend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663924);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663925);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663926);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663927);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663928);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663929);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_set_State_Private_set_Void_CameraState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663930);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_VirtualCameraGameObject_Public_Virtual_Final_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663931);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_IsValid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663932);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_get_ParentCamera_Public_Virtual_Final_New_get_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663933);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Final_New_Boolean_ICinemachineCamera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663934);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_UpdateCameraState_Public_Virtual_Final_New_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663935);
    BlendSourceVirtualCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Final_New_Void_ICinemachineCamera_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr, 100663936 /*0x06000280*/);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlendSourceVirtualCamera(CinemachineBlend blend)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlendSourceVirtualCamera>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blend)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr__ctor_Public_Void_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineBlend Blend
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Blend_Public_get_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_set_Blend_Public_set_Void_CinemachineBlend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string Name
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942771, XrefRangeEnd = 942773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe int Priority
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Priority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Transform LookAt
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_LookAt_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe Transform Follow
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_Follow_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe CameraState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_State_Public_Virtual_Final_New_get_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CameraState(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_set_State_Private_set_Void_CameraState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe GameObject VirtualCameraGameObject
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_VirtualCameraGameObject_Public_Virtual_Final_New_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
  }

  public virtual unsafe bool IsValid
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_IsValid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe ICinemachineCamera ParentCamera
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_get_ParentCamera_Public_Virtual_Final_New_get_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ICinemachineCamera) null : Il2CppObjectPool.Get<ICinemachineCamera>(num3);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dominantChildOnly;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_IsLiveChild_Public_Virtual_Final_New_Boolean_ICinemachineCamera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942773, XrefRangeEnd = 942783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UpdateCameraState(Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_UpdateCameraState_Public_Virtual_Final_New_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnTransitionFromCamera(
    ICinemachineCamera fromCam,
    Vector3 worldUp,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlendSourceVirtualCamera.NativeMethodInfoPtr_OnTransitionFromCamera_Public_Virtual_Final_New_Void_ICinemachineCamera_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineBlend _Blend_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__Blend_k__BackingField));
      return num == System.IntPtr.Zero ? (CinemachineBlend) null : Il2CppObjectPool.Get<CinemachineBlend>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__Blend_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _Priority_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__Priority_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__Priority_k__BackingField)) = value;
    }
  }

  public unsafe Transform _LookAt_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__LookAt_k__BackingField));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__LookAt_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform _Follow_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__Follow_k__BackingField));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__Follow_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CameraState _State_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__State_k__BackingField);
      return new CameraState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraState>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlendSourceVirtualCamera.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraState>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
