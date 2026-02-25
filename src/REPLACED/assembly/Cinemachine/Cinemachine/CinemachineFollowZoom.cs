// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineFollowZoom
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Cinemachine;

public class CinemachineFollowZoom(System.IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Damping;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MinFOV;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxFOV;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineFollowZoom()
  {
    Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineFollowZoom));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr);
    CinemachineFollowZoom.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, nameof (m_Width));
    CinemachineFollowZoom.NativeFieldInfoPtr_m_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, nameof (m_Damping));
    CinemachineFollowZoom.NativeFieldInfoPtr_m_MinFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, nameof (m_MinFOV));
    CinemachineFollowZoom.NativeFieldInfoPtr_m_MaxFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, nameof (m_MaxFOV));
    CinemachineFollowZoom.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, 100663497 /*0x060000C9*/);
    CinemachineFollowZoom.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, 100663498 /*0x060000CA*/);
    CinemachineFollowZoom.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, 100663499 /*0x060000CB*/);
    CinemachineFollowZoom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, 100663500 /*0x060000CC*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938834, XrefRangeEnd = 938835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFollowZoom.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe float GetMaxDampTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFollowZoom.NativeMethodInfoPtr_GetMaxDampTime_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938835, XrefRangeEnd = 938856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void PostPipelineStageCallback(
    CinemachineVirtualCameraBase vcam,
    CinemachineCore.Stage stage,
    ref CameraState state,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stage;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) state);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineFollowZoom.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 938856, XrefRangeEnd = 938857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineFollowZoom()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFollowZoom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float m_Width
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_Width));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_Width)) = value;
    }
  }

  public unsafe float m_Damping
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_Damping));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_Damping)) = value;
    }
  }

  public unsafe float m_MinFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_MinFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_MinFOV)) = value;
    }
  }

  public unsafe float m_MaxFOV
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_MaxFOV));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.NativeFieldInfoPtr_m_MaxFOV)) = value;
    }
  }

  public class VcamExtraState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_previousFrameZoom;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static VcamExtraState()
    {
      Il2CppClassPointerStore<CinemachineFollowZoom.VcamExtraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFollowZoom>.NativeClassPtr, nameof (VcamExtraState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFollowZoom.VcamExtraState>.NativeClassPtr);
      CinemachineFollowZoom.VcamExtraState.NativeFieldInfoPtr_m_previousFrameZoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFollowZoom.VcamExtraState>.NativeClassPtr, nameof (m_previousFrameZoom));
      CinemachineFollowZoom.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFollowZoom.VcamExtraState>.NativeClassPtr, 100663501 /*0x060000CD*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VcamExtraState()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFollowZoom.VcamExtraState>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFollowZoom.VcamExtraState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe float m_previousFrameZoom
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.VcamExtraState.NativeFieldInfoPtr_m_previousFrameZoom));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFollowZoom.VcamExtraState.NativeFieldInfoPtr_m_previousFrameZoom)) = value;
      }
    }
  }
}
