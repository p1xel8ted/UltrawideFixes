// Decompiled with JetBrains decompiler
// Type: CinemachineCameraOffset
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class CinemachineCameraOffset(IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_Offset;
  private static readonly IntPtr NativeFieldInfoPtr_m_ApplyAfter;
  private static readonly IntPtr NativeFieldInfoPtr_m_PreserveComposition;
  private static readonly IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineCameraOffset()
  {
    Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineCameraOffset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr);
    CinemachineCameraOffset.NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr, nameof (m_Offset));
    CinemachineCameraOffset.NativeFieldInfoPtr_m_ApplyAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr, nameof (m_ApplyAfter));
    CinemachineCameraOffset.NativeFieldInfoPtr_m_PreserveComposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr, nameof (m_PreserveComposition));
    CinemachineCameraOffset.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr, 100663297 /*0x06000001*/);
    CinemachineCameraOffset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr, 100663298 /*0x06000002*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936530, XrefRangeEnd = 936548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stage;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineCameraOffset.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936548, XrefRangeEnd = 936551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineCameraOffset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCameraOffset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCameraOffset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 m_Offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCameraOffset.NativeFieldInfoPtr_m_Offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCameraOffset.NativeFieldInfoPtr_m_Offset)) = value;
    }
  }

  public unsafe CinemachineCore.Stage m_ApplyAfter
  {
    get
    {
      return *(CinemachineCore.Stage*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCameraOffset.NativeFieldInfoPtr_m_ApplyAfter));
    }
    [param: In] set
    {
      *(CinemachineCore.Stage*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCameraOffset.NativeFieldInfoPtr_m_ApplyAfter)) = value;
    }
  }

  public unsafe bool m_PreserveComposition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCameraOffset.NativeFieldInfoPtr_m_PreserveComposition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCameraOffset.NativeFieldInfoPtr_m_PreserveComposition)) = value;
    }
  }
}
