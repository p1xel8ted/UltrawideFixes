// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineCore
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public sealed class CinemachineCore(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kStreamingVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_sInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_sShowHiddenObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetInputAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_UniformDeltaTimeOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTimeOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetBlendOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_CameraUpdatedEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_CameraCutEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveBrains;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameDeltaCompensationEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_mActiveCameras;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveCamerasAreSorted;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActivationSequence;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAllCameras;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRoundRobinVcamLastFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_LastUpdateTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_FixedFrameCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_mUpdateStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentUpdateFilter;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CinemachineCore_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeltaTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BrainCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveBrain_Public_CinemachineBrain_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveBrain_Internal_Void_CinemachineBrain_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveBrain_Internal_Void_CinemachineBrain_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VirtualCameraCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVirtualCamera_Public_CinemachineVirtualCameraBase_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddActiveCamera_Internal_Void_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveCamera_Internal_Void_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CameraDestroyed_Internal_Void_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CameraEnabled_Internal_Void_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CameraDisabled_Internal_Void_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAllActiveVirtualCameras_Internal_Void_Int32_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateVirtualCamera_Internal_Void_CinemachineVirtualCameraBase_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetUpdateTarget_Private_Static_Transform_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLive_Public_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLiveInBlend_Public_Boolean_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCameraActivationEvent_Public_Void_ICinemachineCamera_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GenerateCameraCutEvent_Public_Void_ICinemachineCamera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindPotentialTargetBrain_Public_CinemachineBrain_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineCore()
  {
    Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineCore));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr);
    CinemachineCore.NativeFieldInfoPtr_kStreamingVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (kStreamingVersion));
    CinemachineCore.NativeFieldInfoPtr_sInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (sInstance));
    CinemachineCore.NativeFieldInfoPtr_sShowHiddenObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (sShowHiddenObjects));
    CinemachineCore.NativeFieldInfoPtr_GetInputAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (GetInputAxis));
    CinemachineCore.NativeFieldInfoPtr_UniformDeltaTimeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (UniformDeltaTimeOverride));
    CinemachineCore.NativeFieldInfoPtr_CurrentTimeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (CurrentTimeOverride));
    CinemachineCore.NativeFieldInfoPtr_GetBlendOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (GetBlendOverride));
    CinemachineCore.NativeFieldInfoPtr_CameraUpdatedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (CameraUpdatedEvent));
    CinemachineCore.NativeFieldInfoPtr_CameraCutEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (CameraCutEvent));
    CinemachineCore.NativeFieldInfoPtr_mActiveBrains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (mActiveBrains));
    CinemachineCore.NativeFieldInfoPtr_FrameDeltaCompensationEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (FrameDeltaCompensationEnabled));
    CinemachineCore.NativeFieldInfoPtr_mActiveCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (mActiveCameras));
    CinemachineCore.NativeFieldInfoPtr_m_ActiveCamerasAreSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (m_ActiveCamerasAreSorted));
    CinemachineCore.NativeFieldInfoPtr_m_ActivationSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (m_ActivationSequence));
    CinemachineCore.NativeFieldInfoPtr_mAllCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (mAllCameras));
    CinemachineCore.NativeFieldInfoPtr_mRoundRobinVcamLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (mRoundRobinVcamLastFrame));
    CinemachineCore.NativeFieldInfoPtr_s_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (s_LastUpdateTime));
    CinemachineCore.NativeFieldInfoPtr_s_FixedFrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (s_FixedFrameCount));
    CinemachineCore.NativeFieldInfoPtr_mUpdateStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (mUpdateStatus));
    CinemachineCore.NativeFieldInfoPtr_m_CurrentUpdateFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (m_CurrentUpdateFilter));
    CinemachineCore.NativeMethodInfoPtr_get_Instance_Public_Static_get_CinemachineCore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663962);
    CinemachineCore.NativeMethodInfoPtr_get_DeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663963);
    CinemachineCore.NativeMethodInfoPtr_get_CurrentTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663964);
    CinemachineCore.NativeMethodInfoPtr_get_BrainCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663965);
    CinemachineCore.NativeMethodInfoPtr_GetActiveBrain_Public_CinemachineBrain_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663966);
    CinemachineCore.NativeMethodInfoPtr_AddActiveBrain_Internal_Void_CinemachineBrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663967);
    CinemachineCore.NativeMethodInfoPtr_RemoveActiveBrain_Internal_Void_CinemachineBrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663968 /*0x060002A0*/);
    CinemachineCore.NativeMethodInfoPtr_get_VirtualCameraCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663969);
    CinemachineCore.NativeMethodInfoPtr_GetVirtualCamera_Public_CinemachineVirtualCameraBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663970);
    CinemachineCore.NativeMethodInfoPtr_AddActiveCamera_Internal_Void_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663971);
    CinemachineCore.NativeMethodInfoPtr_RemoveActiveCamera_Internal_Void_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663972);
    CinemachineCore.NativeMethodInfoPtr_CameraDestroyed_Internal_Void_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663973);
    CinemachineCore.NativeMethodInfoPtr_CameraEnabled_Internal_Void_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663974);
    CinemachineCore.NativeMethodInfoPtr_CameraDisabled_Internal_Void_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663975);
    CinemachineCore.NativeMethodInfoPtr_UpdateAllActiveVirtualCameras_Internal_Void_Int32_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663976);
    CinemachineCore.NativeMethodInfoPtr_UpdateVirtualCamera_Internal_Void_CinemachineVirtualCameraBase_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663977);
    CinemachineCore.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663978);
    CinemachineCore.NativeMethodInfoPtr_GetUpdateTarget_Private_Static_Transform_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663979);
    CinemachineCore.NativeMethodInfoPtr_IsLive_Public_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663980);
    CinemachineCore.NativeMethodInfoPtr_IsLiveInBlend_Public_Boolean_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663981);
    CinemachineCore.NativeMethodInfoPtr_GenerateCameraActivationEvent_Public_Void_ICinemachineCamera_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663982);
    CinemachineCore.NativeMethodInfoPtr_GenerateCameraCutEvent_Public_Void_ICinemachineCamera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663983);
    CinemachineCore.NativeMethodInfoPtr_FindPotentialTargetBrain_Public_CinemachineBrain_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663984 /*0x060002B0*/);
    CinemachineCore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, 100663985);
  }

  public static unsafe CinemachineCore Instance
  {
    [CallerCount(39), CachedScanResults(RefRangeStart = 943096, RefRangeEnd = 943135, XrefRangeStart = 943066, XrefRangeEnd = 943096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_get_Instance_Public_Static_get_CinemachineCore_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CinemachineCore) null : Il2CppObjectPool.Get<CinemachineCore>(num3);
    }
  }

  public static unsafe float DeltaTime
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 943141, RefRangeEnd = 943142, XrefRangeStart = 943135, XrefRangeEnd = 943141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_get_DeltaTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float CurrentTime
  {
    [CallerCount(23), CachedScanResults(RefRangeStart = 943148, RefRangeEnd = 943171, XrefRangeStart = 943142, XrefRangeEnd = 943148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_get_CurrentTime_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BrainCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 943172, RefRangeEnd = 943173, XrefRangeStart = 943171, XrefRangeEnd = 943172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_get_BrainCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943177, RefRangeEnd = 943179, XrefRangeStart = 943173, XrefRangeEnd = 943177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBrain GetActiveBrain(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_GetActiveBrain_Public_CinemachineBrain_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineBrain) null : Il2CppObjectPool.Get<CinemachineBrain>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943186, RefRangeEnd = 943187, XrefRangeStart = 943179, XrefRangeEnd = 943186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddActiveBrain(CinemachineBrain brain)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brain)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_AddActiveBrain_Internal_Void_CinemachineBrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943191, RefRangeEnd = 943192, XrefRangeStart = 943187, XrefRangeEnd = 943191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveActiveBrain(CinemachineBrain brain)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) brain)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_RemoveActiveBrain_Internal_Void_CinemachineBrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int VirtualCameraCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 943193, RefRangeEnd = 943194, XrefRangeStart = 943192, XrefRangeEnd = 943193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_get_VirtualCameraCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943215, RefRangeEnd = 943216, XrefRangeStart = 943194, XrefRangeEnd = 943215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineVirtualCameraBase GetVirtualCamera(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_GetVirtualCamera_Public_CinemachineVirtualCameraBase_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943216, XrefRangeEnd = 943219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddActiveCamera(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_AddActiveCamera_Internal_Void_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943219, XrefRangeEnd = 943225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveActiveCamera(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_RemoveActiveCamera_Internal_Void_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943225, XrefRangeEnd = 943237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CameraDestroyed(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_CameraDestroyed_Internal_Void_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943264, RefRangeEnd = 943266, XrefRangeStart = 943237, XrefRangeEnd = 943264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CameraEnabled(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_CameraEnabled_Internal_Void_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943278, RefRangeEnd = 943280, XrefRangeStart = 943266, XrefRangeEnd = 943278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CameraDisabled(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_CameraDisabled_Internal_Void_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 943326, RefRangeEnd = 943327, XrefRangeStart = 943280, XrefRangeEnd = 943326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &layerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_UpdateAllActiveVirtualCameras_Internal_Void_Int32_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 943417, RefRangeEnd = 943420, XrefRangeStart = 943327, XrefRangeEnd = 943417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateVirtualCamera(
    CinemachineVirtualCameraBase vcam,
    Vector3 worldUp,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_UpdateVirtualCamera_Internal_Void_CinemachineVirtualCameraBase_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943420, XrefRangeEnd = 943430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeModule()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943430, XrefRangeEnd = 943445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_GetUpdateTarget_Private_Static_Transform_CinemachineVirtualCameraBase_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 943456, RefRangeEnd = 943464, XrefRangeStart = 943445, XrefRangeEnd = 943456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsLive(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_IsLive_Public_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 943475, RefRangeEnd = 943480, XrefRangeStart = 943464, XrefRangeEnd = 943475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsLiveInBlend(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_IsLiveInBlend_Public_Boolean_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 943493, RefRangeEnd = 943496, XrefRangeStart = 943480, XrefRangeEnd = 943493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateCameraActivationEvent(
    ICinemachineCamera vcam,
    ICinemachineCamera vcamFrom)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcamFrom);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_GenerateCameraActivationEvent_Public_Void_ICinemachineCamera_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 943517, RefRangeEnd = 943520, XrefRangeStart = 943496, XrefRangeEnd = 943517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateCameraCutEvent(ICinemachineCamera vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_GenerateCameraCutEvent_Public_Void_ICinemachineCamera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 943550, RefRangeEnd = 943552, XrefRangeStart = 943520, XrefRangeEnd = 943550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vcam)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr_FindPotentialTargetBrain_Public_CinemachineBrain_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CinemachineBrain) null : Il2CppObjectPool.Get<CinemachineBrain>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943552, XrefRangeEnd = 943571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineCore()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineCore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kStreamingVersion
  {
    get
    {
      int streamingVersion;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_kStreamingVersion, (void*) &streamingVersion);
      return streamingVersion;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_kStreamingVersion, (void*) &value);
    }
  }

  public static unsafe CinemachineCore sInstance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_sInstance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineCore) null : Il2CppObjectPool.Get<CinemachineCore>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_sInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool sShowHiddenObjects
  {
    get
    {
      bool showHiddenObjects;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_sShowHiddenObjects, (void*) &showHiddenObjects);
      return showHiddenObjects;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_sShowHiddenObjects, (void*) &value);
    }
  }

  public static unsafe CinemachineCore.AxisInputDelegate GetInputAxis
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_GetInputAxis, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineCore.AxisInputDelegate) null : Il2CppObjectPool.Get<CinemachineCore.AxisInputDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_GetInputAxis, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float UniformDeltaTimeOverride
  {
    get
    {
      float deltaTimeOverride;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_UniformDeltaTimeOverride, (void*) &deltaTimeOverride);
      return deltaTimeOverride;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_UniformDeltaTimeOverride, (void*) &value);
    }
  }

  public static unsafe float CurrentTimeOverride
  {
    get
    {
      float currentTimeOverride;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_CurrentTimeOverride, (void*) &currentTimeOverride);
      return currentTimeOverride;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_CurrentTimeOverride, (void*) &value);
    }
  }

  public static unsafe CinemachineCore.GetBlendOverrideDelegate GetBlendOverride
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_GetBlendOverride, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineCore.GetBlendOverrideDelegate) null : Il2CppObjectPool.Get<CinemachineCore.GetBlendOverrideDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_GetBlendOverride, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemachineBrain.BrainEvent CameraUpdatedEvent
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_CameraUpdatedEvent, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineBrain.BrainEvent) null : Il2CppObjectPool.Get<CinemachineBrain.BrainEvent>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_CameraUpdatedEvent, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemachineBrain.BrainEvent CameraCutEvent
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_CameraCutEvent, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineBrain.BrainEvent) null : Il2CppObjectPool.Get<CinemachineBrain.BrainEvent>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_CameraCutEvent, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CinemachineBrain> mActiveBrains
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mActiveBrains));
      return num == System.IntPtr.Zero ? (List<CinemachineBrain>) null : Il2CppObjectPool.Get<List<CinemachineBrain>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mActiveBrains), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool FrameDeltaCompensationEnabled
  {
    get
    {
      bool compensationEnabled;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_FrameDeltaCompensationEnabled, (void*) &compensationEnabled);
      return compensationEnabled;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_FrameDeltaCompensationEnabled, (void*) &value);
    }
  }

  public unsafe List<CinemachineVirtualCameraBase> mActiveCameras
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mActiveCameras));
      return num == System.IntPtr.Zero ? (List<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<List<CinemachineVirtualCameraBase>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mActiveCameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_ActiveCamerasAreSorted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_m_ActiveCamerasAreSorted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_m_ActiveCamerasAreSorted)) = value;
    }
  }

  public unsafe int m_ActivationSequence
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_m_ActivationSequence));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_m_ActivationSequence)) = value;
    }
  }

  public unsafe List<List<CinemachineVirtualCameraBase>> mAllCameras
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mAllCameras));
      return num == System.IntPtr.Zero ? (List<List<CinemachineVirtualCameraBase>>) null : Il2CppObjectPool.Get<List<List<CinemachineVirtualCameraBase>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mAllCameras), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase mRoundRobinVcamLastFrame
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mRoundRobinVcamLastFrame));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mRoundRobinVcamLastFrame), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float s_LastUpdateTime
  {
    get
    {
      float sLastUpdateTime;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_s_LastUpdateTime, (void*) &sLastUpdateTime);
      return sLastUpdateTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_s_LastUpdateTime, (void*) &value);
    }
  }

  public static unsafe int s_FixedFrameCount
  {
    get
    {
      int sFixedFrameCount;
      IL2CPP.il2cpp_field_static_get_value(CinemachineCore.NativeFieldInfoPtr_s_FixedFrameCount, (void*) &sFixedFrameCount);
      return sFixedFrameCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineCore.NativeFieldInfoPtr_s_FixedFrameCount, (void*) &value);
    }
  }

  public unsafe Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus> mUpdateStatus
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mUpdateStatus));
      return num == System.IntPtr.Zero ? (Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>) null : Il2CppObjectPool.Get<Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_mUpdateStatus), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineCore.UpdateFilter m_CurrentUpdateFilter
  {
    get
    {
      return *(CinemachineCore.UpdateFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_m_CurrentUpdateFilter));
    }
    [param: In] set
    {
      *(CinemachineCore.UpdateFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.NativeFieldInfoPtr_m_CurrentUpdateFilter)) = value;
    }
  }

  public enum Stage
  {
    Body,
    Aim,
    Noise,
    Finalize,
  }

  public sealed class AxisInputDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_String_0;

    static AxisInputDelegate()
    {
      Il2CppClassPointerStore<CinemachineCore.AxisInputDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (AxisInputDelegate));
      CinemachineCore.AxisInputDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.AxisInputDelegate>.NativeClassPtr, 100663987);
      CinemachineCore.AxisInputDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.AxisInputDelegate>.NativeClassPtr, 100663988);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 943049, RefRangeEnd = 943056, XrefRangeStart = 943046, XrefRangeEnd = 943049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AxisInputDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCore.AxisInputDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCore.AxisInputDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe float Invoke(string axisName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(axisName)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.AxisInputDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static implicit operator CinemachineCore.AxisInputDelegate([In] System.Func<string, float> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineCore.AxisInputDelegate>((System.Delegate) obj0);
    }

    public static CinemachineCore.AxisInputDelegate operator +(
      [In] CinemachineCore.AxisInputDelegate obj0,
      [In] CinemachineCore.AxisInputDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineCore.AxisInputDelegate>();
    }

    public static CinemachineCore.AxisInputDelegate operator -(
      [In] CinemachineCore.AxisInputDelegate obj0,
      [In] CinemachineCore.AxisInputDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineCore.AxisInputDelegate) @delegate : @delegate.Cast<CinemachineCore.AxisInputDelegate>();
    }
  }

  public sealed class GetBlendOverrideDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_CinemachineBlendDefinition_MonoBehaviour_0;

    static GetBlendOverrideDelegate()
    {
      Il2CppClassPointerStore<CinemachineCore.GetBlendOverrideDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (GetBlendOverrideDelegate));
      CinemachineCore.GetBlendOverrideDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.GetBlendOverrideDelegate>.NativeClassPtr, 100663989);
      CinemachineCore.GetBlendOverrideDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_CinemachineBlendDefinition_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.GetBlendOverrideDelegate>.NativeClassPtr, 100663990);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943056, XrefRangeEnd = 943065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetBlendOverrideDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCore.GetBlendOverrideDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCore.GetBlendOverrideDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe CinemachineBlendDefinition Invoke(
      ICinemachineCamera fromVcam,
      ICinemachineCamera toVcam,
      CinemachineBlendDefinition defaultBlend,
      MonoBehaviour owner)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromVcam);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toVcam);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) defaultBlend));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.GetBlendOverrideDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_CinemachineBlendDefinition_ICinemachineCamera_ICinemachineCamera_CinemachineBlendDefinition_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new CinemachineBlendDefinition(pointer);
    }

    public static implicit operator CinemachineCore.GetBlendOverrideDelegate(
      [In] System.Func<ICinemachineCamera, ICinemachineCamera, CinemachineBlendDefinition, MonoBehaviour, CinemachineBlendDefinition> obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineCore.GetBlendOverrideDelegate>((System.Delegate) obj0);
    }

    public static CinemachineCore.GetBlendOverrideDelegate operator +(
      [In] CinemachineCore.GetBlendOverrideDelegate obj0,
      [In] CinemachineCore.GetBlendOverrideDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineCore.GetBlendOverrideDelegate>();
    }

    public static CinemachineCore.GetBlendOverrideDelegate operator -(
      [In] CinemachineCore.GetBlendOverrideDelegate obj0,
      [In] CinemachineCore.GetBlendOverrideDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineCore.GetBlendOverrideDelegate) @delegate : @delegate.Cast<CinemachineCore.GetBlendOverrideDelegate>();
    }
  }

  public class UpdateStatus(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateFixedFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastUpdateDeltaTime;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static UpdateStatus()
    {
      Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, nameof (UpdateStatus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr);
      CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr, nameof (lastUpdateFrame));
      CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateFixedFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr, nameof (lastUpdateFixedFrame));
      CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr, nameof (lastUpdateMode));
      CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr, nameof (lastUpdateDeltaTime));
      CinemachineCore.UpdateStatus.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr, 100663991);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateStatus()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCore.UpdateStatus>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCore.UpdateStatus.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int lastUpdateFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateFrame)) = value;
      }
    }

    public unsafe int lastUpdateFixedFrame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateFixedFrame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateFixedFrame)) = value;
      }
    }

    public unsafe UpdateTracker.UpdateClock lastUpdateMode
    {
      get
      {
        return *(UpdateTracker.UpdateClock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateMode));
      }
      [param: In] set
      {
        *(UpdateTracker.UpdateClock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateMode)) = value;
      }
    }

    public unsafe float lastUpdateDeltaTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateDeltaTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineCore.UpdateStatus.NativeFieldInfoPtr_lastUpdateDeltaTime)) = value;
      }
    }
  }

  public enum UpdateFilter
  {
    Fixed = 0,
    Late = 1,
    Smart = 8,
    SmartFixed = 8,
    SmartLate = 9,
  }

  [ObfuscatedName("Cinemachine.CinemachineCore+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__30_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetVirtualCamera_b__30_0_Internal_Int32_CinemachineVirtualCameraBase_CinemachineVirtualCameraBase_0;

    static __c()
    {
      Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineCore>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr);
      CinemachineCore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr, "<>9");
      CinemachineCore.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr, "<>9__30_0");
      CinemachineCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr, 100663993);
      CinemachineCore.__c.NativeMethodInfoPtr__GetVirtualCamera_b__30_0_Internal_Int32_CinemachineVirtualCameraBase_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr, 100663994);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineCore.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943065, XrefRangeEnd = 943066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _GetVirtualCamera_b__30_0(
      CinemachineVirtualCameraBase x,
      CinemachineVirtualCameraBase y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineCore.__c.NativeMethodInfoPtr__GetVirtualCamera_b__30_0_Internal_Int32_CinemachineVirtualCameraBase_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CinemachineCore.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineCore.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CinemachineCore.__c) null : Il2CppObjectPool.Get<CinemachineCore.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineCore.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<CinemachineVirtualCameraBase> __9__30_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CinemachineCore.__c.NativeFieldInfoPtr___9__30_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<CinemachineVirtualCameraBase>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<CinemachineVirtualCameraBase>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CinemachineCore.__c.NativeFieldInfoPtr___9__30_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
