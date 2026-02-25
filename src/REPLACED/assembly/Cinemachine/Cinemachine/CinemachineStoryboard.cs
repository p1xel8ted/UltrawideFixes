// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineStoryboard
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Cinemachine;

public class CinemachineStoryboard(System.IntPtr pointer) : CinemachineExtension(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_StoryboardGlobalMute;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShowImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Image;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Aspect;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Alpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Rotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Scale;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SyncScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MuteCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitView;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SortingOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlaneDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCanvasInfo;
  private static readonly System.IntPtr NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRenderCanvas_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectToVcam_Protected_Virtual_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CanvasName_Private_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CameraUpdatedCallback_Private_Void_CinemachineBrain_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocateMyCanvas_Private_CanvasInfo_CinemachineBrain_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCanvas_Private_Void_CanvasInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyCanvas_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlaceImage_Private_Void_CanvasInfo_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StaticBlendingHandler_Private_Static_Void_CinemachineBrain_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineStoryboard()
  {
    Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineStoryboard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr);
    CinemachineStoryboard.NativeFieldInfoPtr_s_StoryboardGlobalMute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (s_StoryboardGlobalMute));
    CinemachineStoryboard.NativeFieldInfoPtr_m_ShowImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_ShowImage));
    CinemachineStoryboard.NativeFieldInfoPtr_m_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_Image));
    CinemachineStoryboard.NativeFieldInfoPtr_m_Aspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_Aspect));
    CinemachineStoryboard.NativeFieldInfoPtr_m_Alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_Alpha));
    CinemachineStoryboard.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_Center));
    CinemachineStoryboard.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_Rotation));
    CinemachineStoryboard.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_Scale));
    CinemachineStoryboard.NativeFieldInfoPtr_m_SyncScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_SyncScale));
    CinemachineStoryboard.NativeFieldInfoPtr_m_MuteCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_MuteCamera));
    CinemachineStoryboard.NativeFieldInfoPtr_m_SplitView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_SplitView));
    CinemachineStoryboard.NativeFieldInfoPtr_m_RenderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_RenderMode));
    CinemachineStoryboard.NativeFieldInfoPtr_m_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_SortingOrder));
    CinemachineStoryboard.NativeFieldInfoPtr_m_PlaneDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (m_PlaneDistance));
    CinemachineStoryboard.NativeFieldInfoPtr_mCanvasInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (mCanvasInfo));
    CinemachineStoryboard.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663631);
    CinemachineStoryboard.NativeMethodInfoPtr_UpdateRenderCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663632 /*0x06000150*/);
    CinemachineStoryboard.NativeMethodInfoPtr_ConnectToVcam_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663633);
    CinemachineStoryboard.NativeMethodInfoPtr_get_CanvasName_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663634);
    CinemachineStoryboard.NativeMethodInfoPtr_CameraUpdatedCallback_Private_Void_CinemachineBrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663635);
    CinemachineStoryboard.NativeMethodInfoPtr_LocateMyCanvas_Private_CanvasInfo_CinemachineBrain_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663636);
    CinemachineStoryboard.NativeMethodInfoPtr_CreateCanvas_Private_Void_CanvasInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663637);
    CinemachineStoryboard.NativeMethodInfoPtr_DestroyCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663638);
    CinemachineStoryboard.NativeMethodInfoPtr_PlaceImage_Private_Void_CanvasInfo_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663639);
    CinemachineStoryboard.NativeMethodInfoPtr_StaticBlendingHandler_Private_Static_Void_CinemachineBrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663640);
    CinemachineStoryboard.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663641);
    CinemachineStoryboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, 100663642);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939935, XrefRangeEnd = 939946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStoryboard.NativeMethodInfoPtr_PostPipelineStageCallback_Protected_Virtual_Void_CinemachineVirtualCameraBase_Stage_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 939970, RefRangeEnd = 939971, XrefRangeStart = 939946, XrefRangeEnd = 939970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateRenderCanvas()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_UpdateRenderCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939971, XrefRangeEnd = 939987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ConnectToVcam(bool connect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &connect
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineStoryboard.NativeMethodInfoPtr_ConnectToVcam_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string CanvasName
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 939993, RefRangeEnd = 939995, XrefRangeStart = 939987, XrefRangeEnd = 939993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_get_CanvasName_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 939995, XrefRangeEnd = 940019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CameraUpdatedCallback(CinemachineBrain brain)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brain)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_CameraUpdatedCallback_Private_Void_CinemachineBrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 940079, RefRangeEnd = 940081, XrefRangeStart = 940019, XrefRangeEnd = 940079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineStoryboard.CanvasInfo LocateMyCanvas(
    CinemachineBrain parent,
    bool createIfNotFound)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &createIfNotFound;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_LocateMyCanvas_Private_CanvasInfo_CinemachineBrain_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineStoryboard.CanvasInfo) null : Il2CppObjectPool.Get<CinemachineStoryboard.CanvasInfo>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940152, RefRangeEnd = 940153, XrefRangeStart = 940081, XrefRangeEnd = 940152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateCanvas(CinemachineStoryboard.CanvasInfo ci)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ci)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_CreateCanvas_Private_Void_CanvasInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940182, RefRangeEnd = 940183, XrefRangeStart = 940153, XrefRangeEnd = 940182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DestroyCanvas()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_DestroyCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 940230, RefRangeEnd = 940231, XrefRangeStart = 940183, XrefRangeEnd = 940230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlaceImage(CinemachineStoryboard.CanvasInfo ci, float alpha)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ci);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alpha;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_PlaceImage_Private_Void_CanvasInfo_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940231, XrefRangeEnd = 940257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void StaticBlendingHandler(CinemachineBrain brain)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brain)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_StaticBlendingHandler_Private_Static_Void_CinemachineBrain_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940257, XrefRangeEnd = 940279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeModule()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940279, XrefRangeEnd = 940292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineStoryboard()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool s_StoryboardGlobalMute
  {
    get
    {
      bool storyboardGlobalMute;
      IL2CPP.il2cpp_field_static_get_value(CinemachineStoryboard.NativeFieldInfoPtr_s_StoryboardGlobalMute, (void*) &storyboardGlobalMute);
      return storyboardGlobalMute;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineStoryboard.NativeFieldInfoPtr_s_StoryboardGlobalMute, (void*) &value);
    }
  }

  public unsafe bool m_ShowImage
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_ShowImage));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_ShowImage)) = value;
    }
  }

  public unsafe Texture m_Image
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Image));
      return num == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineStoryboard.FillStrategy m_Aspect
  {
    get
    {
      return *(CinemachineStoryboard.FillStrategy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Aspect));
    }
    [param: In] set
    {
      *(CinemachineStoryboard.FillStrategy*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Aspect)) = value;
    }
  }

  public unsafe float m_Alpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Alpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Alpha)) = value;
    }
  }

  public unsafe Vector2 m_Center
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Center));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Center)) = value;
    }
  }

  public unsafe Vector3 m_Rotation
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Rotation));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Rotation)) = value;
    }
  }

  public unsafe Vector2 m_Scale
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Scale));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_Scale)) = value;
    }
  }

  public unsafe bool m_SyncScale
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_SyncScale));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_SyncScale)) = value;
    }
  }

  public unsafe bool m_MuteCamera
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_MuteCamera));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_MuteCamera)) = value;
    }
  }

  public unsafe float m_SplitView
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_SplitView));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_SplitView)) = value;
    }
  }

  public unsafe CinemachineStoryboard.StoryboardRenderMode m_RenderMode
  {
    get
    {
      return *(CinemachineStoryboard.StoryboardRenderMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_RenderMode));
    }
    [param: In] set
    {
      *(CinemachineStoryboard.StoryboardRenderMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_RenderMode)) = value;
    }
  }

  public unsafe int m_SortingOrder
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_SortingOrder));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_SortingOrder)) = value;
    }
  }

  public unsafe float m_PlaneDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_PlaneDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_m_PlaneDistance)) = value;
    }
  }

  public unsafe List<CinemachineStoryboard.CanvasInfo> mCanvasInfo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_mCanvasInfo));
      return num == System.IntPtr.Zero ? (List<CinemachineStoryboard.CanvasInfo>) null : Il2CppObjectPool.Get<List<CinemachineStoryboard.CanvasInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.NativeFieldInfoPtr_mCanvasInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum FillStrategy
  {
    BestFit,
    CropImageToFit,
    StretchToFit,
  }

  public class CanvasInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_mCanvas;
    private static readonly System.IntPtr NativeFieldInfoPtr_mCanvasComponent;
    private static readonly System.IntPtr NativeFieldInfoPtr_mCanvasParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_mViewport;
    private static readonly System.IntPtr NativeFieldInfoPtr_mRawImage;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static CanvasInfo()
    {
      Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineStoryboard>.NativeClassPtr, nameof (CanvasInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr);
      CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr, nameof (mCanvas));
      CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvasComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr, nameof (mCanvasComponent));
      CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvasParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr, nameof (mCanvasParent));
      CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mViewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr, nameof (mViewport));
      CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mRawImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr, nameof (mRawImage));
      CinemachineStoryboard.CanvasInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr, 100663643);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CanvasInfo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineStoryboard.CanvasInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineStoryboard.CanvasInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject mCanvas
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvas));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Canvas mCanvasComponent
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvasComponent));
        return num == System.IntPtr.Zero ? (Canvas) null : Il2CppObjectPool.Get<Canvas>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvasComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CinemachineBrain mCanvasParent
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvasParent));
        return num == System.IntPtr.Zero ? (CinemachineBrain) null : Il2CppObjectPool.Get<CinemachineBrain>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mCanvasParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform mViewport
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mViewport));
        return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mViewport), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RawImage mRawImage
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mRawImage));
        return num == System.IntPtr.Zero ? (RawImage) null : Il2CppObjectPool.Get<RawImage>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineStoryboard.CanvasInfo.NativeFieldInfoPtr_mRawImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public enum StoryboardRenderMode
  {
    ScreenSpaceOverlay,
    ScreenSpaceCamera,
  }
}
