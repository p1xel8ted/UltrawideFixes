// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineControllerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CinemachineControllerBase(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_vcam;
  private static readonly IntPtr NativeFieldInfoPtr_blendingDirection;
  private static readonly IntPtr NativeFieldInfoPtr_cameraTargetReference;
  private static readonly IntPtr NativeFieldInfoPtr_startThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_endThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_cameraTarget;
  private static readonly IntPtr NativeFieldInfoPtr_col;
  private static readonly IntPtr NativeFieldInfoPtr_startPos;
  private static readonly IntPtr NativeFieldInfoPtr_endPos;
  private static readonly IntPtr NativeFieldInfoPtr_maxPos;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MaxPos_Protected_Abstract_Virtual_New_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessCamera_Protected_Abstract_Virtual_New_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static CinemachineControllerBase()
  {
    Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineControllerBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr);
    CinemachineControllerBase.NativeFieldInfoPtr_vcam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (vcam));
    CinemachineControllerBase.NativeFieldInfoPtr_blendingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (blendingDirection));
    CinemachineControllerBase.NativeFieldInfoPtr_cameraTargetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (cameraTargetReference));
    CinemachineControllerBase.NativeFieldInfoPtr_startThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (startThreshold));
    CinemachineControllerBase.NativeFieldInfoPtr_endThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (endThreshold));
    CinemachineControllerBase.NativeFieldInfoPtr_cameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (cameraTarget));
    CinemachineControllerBase.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (col));
    CinemachineControllerBase.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (startPos));
    CinemachineControllerBase.NativeFieldInfoPtr_endPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (endPos));
    CinemachineControllerBase.NativeFieldInfoPtr_maxPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, nameof (maxPos));
    CinemachineControllerBase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676390);
    CinemachineControllerBase.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676391);
    CinemachineControllerBase.NativeMethodInfoPtr_Init_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676392);
    CinemachineControllerBase.NativeMethodInfoPtr_MaxPos_Protected_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676393);
    CinemachineControllerBase.NativeMethodInfoPtr_ProcessCamera_Protected_Abstract_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676394);
    CinemachineControllerBase.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676395);
    CinemachineControllerBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr, 100676396);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123142, XrefRangeEnd = 123151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineControllerBase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123151, XrefRangeEnd = 123169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineControllerBase.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineControllerBase.NativeMethodInfoPtr_Init_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe float MaxPos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineControllerBase.NativeMethodInfoPtr_MaxPos_Protected_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessCamera(float resultPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &resultPos
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineControllerBase.NativeMethodInfoPtr_ProcessCamera_Protected_Abstract_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123169, XrefRangeEnd = 123202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineControllerBase.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 123203, RefRangeEnd = 123205, XrefRangeStart = 123202, XrefRangeEnd = 123203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineControllerBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineControllerBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineControllerBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineVirtualCameraBase vcam
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_vcam));
      return num == IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_vcam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BlendingDir blendingDirection
  {
    get
    {
      return *(BlendingDir*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_blendingDirection));
    }
    [param: In] set
    {
      *(BlendingDir*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_blendingDirection)) = value;
    }
  }

  public unsafe GuidReference cameraTargetReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_cameraTargetReference));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_cameraTargetReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float startThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_startThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_startThreshold)) = value;
    }
  }

  public unsafe float endThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_endThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_endThreshold)) = value;
    }
  }

  public unsafe Transform cameraTarget
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_cameraTarget));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_cameraTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider col
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_col));
      return num == IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float startPos
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_startPos));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_startPos)) = value;
    }
  }

  public unsafe float endPos
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_endPos));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_endPos)) = value;
    }
  }

  public unsafe float maxPos
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_maxPos));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineControllerBase.NativeFieldInfoPtr_maxPos)) = value;
    }
  }
}
