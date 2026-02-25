// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CameraProperties
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CameraProperties
{
  private static readonly System.IntPtr NativeFieldInfoPtr_screenRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewDir;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionNear;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionFar;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraNear;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraFar;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraAspect;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraToWorld;
  private static readonly System.IntPtr NativeFieldInfoPtr_actualWorldToClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraClipToWorld;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraWorldToClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_implicitProjection;
  private static readonly System.IntPtr NativeFieldInfoPtr_stereoWorldToClipLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr_stereoWorldToClipRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_worldToCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_up;
  private static readonly System.IntPtr NativeFieldInfoPtr_right;
  private static readonly System.IntPtr NativeFieldInfoPtr_transformDirection;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraEuler;
  private static readonly System.IntPtr NativeFieldInfoPtr_velocity;
  private static readonly System.IntPtr NativeFieldInfoPtr_farPlaneWorldSpaceLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowCullPlanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraCullPlanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseFarDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowCullCenter;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerCullDistances;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerCullSpherical;
  private static readonly System.IntPtr NativeFieldInfoPtr_coreCameraValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraType;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionIsOblique;
  private static readonly System.IntPtr NativeFieldInfoPtr_isImplicitProjectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_useInteractiveLightBakingData;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public Rect screenRect;
  [FieldOffset(16 /*0x10*/)]
  public Vector3 viewDir;
  [FieldOffset(28)]
  public float projectionNear;
  [FieldOffset(32 /*0x20*/)]
  public float projectionFar;
  [FieldOffset(36)]
  public float cameraNear;
  [FieldOffset(40)]
  public float cameraFar;
  [FieldOffset(44)]
  public float cameraAspect;
  [FieldOffset(48 /*0x30*/)]
  public Matrix4x4 cameraToWorld;
  [FieldOffset(112 /*0x70*/)]
  public Matrix4x4 actualWorldToClip;
  [FieldOffset(176 /*0xB0*/)]
  public Matrix4x4 cameraClipToWorld;
  [FieldOffset(240 /*0xF0*/)]
  public Matrix4x4 cameraWorldToClip;
  [FieldOffset(304)]
  public Matrix4x4 implicitProjection;
  [FieldOffset(368)]
  public Matrix4x4 stereoWorldToClipLeft;
  [FieldOffset(432)]
  public Matrix4x4 stereoWorldToClipRight;
  [FieldOffset(496)]
  public Matrix4x4 worldToCamera;
  [FieldOffset(560)]
  public Vector3 up;
  [FieldOffset(572)]
  public Vector3 right;
  [FieldOffset(584)]
  public Vector3 transformDirection;
  [FieldOffset(596)]
  public Vector3 cameraEuler;
  [FieldOffset(608)]
  public Vector3 velocity;
  [FieldOffset(620)]
  public float farPlaneWorldSpaceLength;
  [FieldOffset(624)]
  public uint rendererCount;
  [FieldOffset(628)]
  public CameraProperties._m_ShadowCullPlanes_e__FixedBuffer m_ShadowCullPlanes;
  [FieldOffset(724)]
  public CameraProperties._m_CameraCullPlanes_e__FixedBuffer m_CameraCullPlanes;
  [FieldOffset(820)]
  public float baseFarDistance;
  [FieldOffset(824)]
  public Vector3 shadowCullCenter;
  [FieldOffset(836)]
  public CameraProperties._layerCullDistances_e__FixedBuffer layerCullDistances;
  [FieldOffset(964)]
  public int layerCullSpherical;
  [FieldOffset(968)]
  public CoreCameraValues coreCameraValues;
  [FieldOffset(980)]
  public uint cameraType;
  [FieldOffset(984)]
  public int projectionIsOblique;
  [FieldOffset(988)]
  public int isImplicitProjectionMatrix;
  [FieldOffset(992)]
  public bool useInteractiveLightBakingData;
  public const int k_NumLayers = 32 /*0x20*/;
  public const int k_PlaneCount = 6;

  static CameraProperties()
  {
    Il2CppClassPointerStore<CameraProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CameraProperties));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr);
    CameraProperties.NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (screenRect));
    CameraProperties.NativeFieldInfoPtr_viewDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (viewDir));
    CameraProperties.NativeFieldInfoPtr_projectionNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (projectionNear));
    CameraProperties.NativeFieldInfoPtr_projectionFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (projectionFar));
    CameraProperties.NativeFieldInfoPtr_cameraNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraNear));
    CameraProperties.NativeFieldInfoPtr_cameraFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraFar));
    CameraProperties.NativeFieldInfoPtr_cameraAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraAspect));
    CameraProperties.NativeFieldInfoPtr_cameraToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraToWorld));
    CameraProperties.NativeFieldInfoPtr_actualWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (actualWorldToClip));
    CameraProperties.NativeFieldInfoPtr_cameraClipToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraClipToWorld));
    CameraProperties.NativeFieldInfoPtr_cameraWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraWorldToClip));
    CameraProperties.NativeFieldInfoPtr_implicitProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (implicitProjection));
    CameraProperties.NativeFieldInfoPtr_stereoWorldToClipLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (stereoWorldToClipLeft));
    CameraProperties.NativeFieldInfoPtr_stereoWorldToClipRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (stereoWorldToClipRight));
    CameraProperties.NativeFieldInfoPtr_worldToCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (worldToCamera));
    CameraProperties.NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (up));
    CameraProperties.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (right));
    CameraProperties.NativeFieldInfoPtr_transformDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (transformDirection));
    CameraProperties.NativeFieldInfoPtr_cameraEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraEuler));
    CameraProperties.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (velocity));
    CameraProperties.NativeFieldInfoPtr_farPlaneWorldSpaceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (farPlaneWorldSpaceLength));
    CameraProperties.NativeFieldInfoPtr_rendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (rendererCount));
    CameraProperties.NativeFieldInfoPtr_m_ShadowCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (m_ShadowCullPlanes));
    CameraProperties.NativeFieldInfoPtr_m_CameraCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (m_CameraCullPlanes));
    CameraProperties.NativeFieldInfoPtr_baseFarDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (baseFarDistance));
    CameraProperties.NativeFieldInfoPtr_shadowCullCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (shadowCullCenter));
    CameraProperties.NativeFieldInfoPtr_layerCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (layerCullDistances));
    CameraProperties.NativeFieldInfoPtr_layerCullSpherical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (layerCullSpherical));
    CameraProperties.NativeFieldInfoPtr_coreCameraValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (coreCameraValues));
    CameraProperties.NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (cameraType));
    CameraProperties.NativeFieldInfoPtr_projectionIsOblique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (projectionIsOblique));
    CameraProperties.NativeFieldInfoPtr_isImplicitProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (isImplicitProjectionMatrix));
    CameraProperties.NativeFieldInfoPtr_useInteractiveLightBakingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, nameof (useInteractiveLightBakingData));
    CameraProperties.NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100670338);
    CameraProperties.NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100670339);
    CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100670340);
    CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100670341);
    CameraProperties.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100670342);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 487363, RefRangeEnd = 487366, XrefRangeStart = 487363, XrefRangeEnd = 487363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Plane GetShadowCullingPlane(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 487366, RefRangeEnd = 487369, XrefRangeStart = 487366, XrefRangeEnd = 487366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Plane GetCameraCullingPlane(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487399, RefRangeEnd = 487400, XrefRangeStart = 487369, XrefRangeEnd = 487399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(CameraProperties other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487400, XrefRangeEnd = 487404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487449, RefRangeEnd = 487450, XrefRangeStart = 487404, XrefRangeEnd = 487449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraProperties.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void SetShadowCullingPlane(int index, Plane plane)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetCameraCullingPlane(int index, Plane plane)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool operator ==(CameraProperties left, CameraProperties right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(CameraProperties left, CameraProperties right)
  {
    return !left.Equals(right);
  }

  [ObfuscatedName("UnityEngine.Rendering.CameraProperties+<layerCullDistances>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _layerCullDistances_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public float FixedElementField;

    static _layerCullDistances_e__FixedBuffer()
    {
      Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<layerCullDistances>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr);
      CameraProperties._layerCullDistances_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._layerCullDistances_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_CameraCullPlanes>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _m_CameraCullPlanes_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public byte FixedElementField;

    static _m_CameraCullPlanes_e__FixedBuffer()
    {
      Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_CameraCullPlanes>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr);
      CameraProperties._m_CameraCullPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_ShadowCullPlanes>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _m_ShadowCullPlanes_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public byte FixedElementField;

    static _m_ShadowCullPlanes_e__FixedBuffer()
    {
      Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_ShadowCullPlanes>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr);
      CameraProperties._m_ShadowCullPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties._m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
