// Decompiled with JetBrains decompiler
// Type: Cinemachine.LensSettings
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct LensSettings
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Default;
  private static readonly System.IntPtr NativeFieldInfoPtr_FieldOfView;
  private static readonly System.IntPtr NativeFieldInfoPtr_OrthographicSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_NearClipPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_FarClipPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_Dutch;
  private static readonly System.IntPtr NativeFieldInfoPtr_ModeOverride;
  private static readonly System.IntPtr NativeFieldInfoPtr_LensShift;
  private static readonly System.IntPtr NativeFieldInfoPtr_GateFit;
  private static readonly System.IntPtr NativeFieldInfoPtr_FocusDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SensorSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OrthoFromCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PhysicalFromCamera;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SensorSize_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SensorSize_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Aspect_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPhysicalCamera_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromCamera_Public_Static_LensSettings_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SnapshotCameraReadOnlyProperties_Public_Void_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_LensSettings_LensSettings_LensSettings_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Public_Void_0;
  [FieldOffset(0)]
  public float FieldOfView;
  [FieldOffset(4)]
  public float OrthographicSize;
  [FieldOffset(8)]
  public float NearClipPlane;
  [FieldOffset(12)]
  public float FarClipPlane;
  [FieldOffset(16 /*0x10*/)]
  public float Dutch;
  [FieldOffset(20)]
  public LensSettings.OverrideModes ModeOverride;
  [FieldOffset(24)]
  public Vector2 LensShift;
  [FieldOffset(32 /*0x20*/)]
  public Camera.GateFitMode GateFit;
  [FieldOffset(36)]
  public float FocusDistance;
  [FieldOffset(40)]
  public Vector2 m_SensorSize;
  [FieldOffset(48 /*0x30*/)]
  public bool m_OrthoFromCamera;
  [FieldOffset(49)]
  public bool m_PhysicalFromCamera;

  static LensSettings()
  {
    Il2CppClassPointerStore<LensSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (LensSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensSettings>.NativeClassPtr);
    LensSettings.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (Default));
    LensSettings.NativeFieldInfoPtr_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (FieldOfView));
    LensSettings.NativeFieldInfoPtr_OrthographicSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (OrthographicSize));
    LensSettings.NativeFieldInfoPtr_NearClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (NearClipPlane));
    LensSettings.NativeFieldInfoPtr_FarClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (FarClipPlane));
    LensSettings.NativeFieldInfoPtr_Dutch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (Dutch));
    LensSettings.NativeFieldInfoPtr_ModeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (ModeOverride));
    LensSettings.NativeFieldInfoPtr_LensShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (LensShift));
    LensSettings.NativeFieldInfoPtr_GateFit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (GateFit));
    LensSettings.NativeFieldInfoPtr_FocusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (FocusDistance));
    LensSettings.NativeFieldInfoPtr_m_SensorSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (m_SensorSize));
    LensSettings.NativeFieldInfoPtr_m_OrthoFromCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (m_OrthoFromCamera));
    LensSettings.NativeFieldInfoPtr_m_PhysicalFromCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, nameof (m_PhysicalFromCamera));
    LensSettings.NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664161);
    LensSettings.NativeMethodInfoPtr_get_SensorSize_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664162);
    LensSettings.NativeMethodInfoPtr_set_SensorSize_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664163);
    LensSettings.NativeMethodInfoPtr_get_Aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664164);
    LensSettings.NativeMethodInfoPtr_get_IsPhysicalCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664165);
    LensSettings.NativeMethodInfoPtr_FromCamera_Public_Static_LensSettings_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664166);
    LensSettings.NativeMethodInfoPtr_SnapshotCameraReadOnlyProperties_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664167);
    LensSettings.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664168);
    LensSettings.NativeMethodInfoPtr_Lerp_Public_Static_LensSettings_LensSettings_LensSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664169);
    LensSettings.NativeMethodInfoPtr_Validate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, 100664170);
  }

  public unsafe bool Orthographic
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 944531, RefRangeEnd = 944542, XrefRangeStart = 944531, XrefRangeEnd = 944531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 SensorSize
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_get_SensorSize_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_set_SensorSize_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float Aspect
  {
    [CallerCount(17), CachedScanResults(RefRangeStart = 944546, RefRangeEnd = 944563, XrefRangeStart = 944542, XrefRangeEnd = 944546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_get_Aspect_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsPhysicalCamera
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 944563, RefRangeEnd = 944567, XrefRangeStart = 944563, XrefRangeEnd = 944563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_get_IsPhysicalCamera_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944585, RefRangeEnd = 944586, XrefRangeStart = 944567, XrefRangeEnd = 944585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LensSettings FromCamera(Camera fromCamera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fromCamera)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_FromCamera_Public_Static_LensSettings_Camera_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LensSettings*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944603, RefRangeEnd = 944605, XrefRangeStart = 944586, XrefRangeEnd = 944603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapshotCameraReadOnlyProperties(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_SnapshotCameraReadOnlyProperties_Public_Void_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe LensSettings(
    float verticalFOV,
    float orthographicSize,
    float nearClip,
    float farClip,
    float dutch)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &verticalFOV;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &orthographicSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nearClip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &farClip;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &dutch;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944622, RefRangeEnd = 944623, XrefRangeStart = 944605, XrefRangeEnd = 944622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &lensA;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lensB;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_Lerp_Public_Static_LensSettings_LensSettings_LensSettings_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LensSettings*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944624, RefRangeEnd = 944626, XrefRangeStart = 944623, XrefRangeEnd = 944624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Validate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LensSettings.NativeMethodInfoPtr_Validate_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LensSettings>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe LensSettings Default
  {
    get
    {
      LensSettings lensSettings;
      IL2CPP.il2cpp_field_static_get_value(LensSettings.NativeFieldInfoPtr_Default, (void*) &lensSettings);
      return lensSettings;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LensSettings.NativeFieldInfoPtr_Default, (void*) &value);
    }
  }

  public enum OverrideModes
  {
    None,
    Orthographic,
    Perspective,
    Physical,
  }
}
