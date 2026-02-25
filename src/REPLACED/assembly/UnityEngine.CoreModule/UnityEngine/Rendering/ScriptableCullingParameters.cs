// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ScriptableCullingParameters
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
public struct ScriptableCullingParameters
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LODParameters;
  private static readonly System.IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SceneMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewID;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerFarCullDistances;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerCull;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Origin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowNearPlaneOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraProperties;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccurateOcclusionThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaximumPortalCullingJobs;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StereoViewMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StereoProjectionMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StereoSeparationDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_maximumVisibleLights;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ConservativeEnclosingSphere;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NumIterationsEnclosingSphere;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public LODParameters m_LODParameters;
  [FieldOffset(28)]
  public ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer m_CullingPlanes;
  [FieldOffset(188)]
  public int m_CullingPlaneCount;
  [FieldOffset(192 /*0xC0*/)]
  public uint m_CullingMask;
  [FieldOffset(200)]
  public ulong m_SceneMask;
  [FieldOffset(208 /*0xD0*/)]
  public ulong m_ViewID;
  [FieldOffset(216)]
  public ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer m_LayerFarCullDistances;
  [FieldOffset(344)]
  public int m_LayerCull;
  [FieldOffset(348)]
  public Matrix4x4 m_CullingMatrix;
  [FieldOffset(412)]
  public Vector3 m_Origin;
  [FieldOffset(424)]
  public float m_ShadowDistance;
  [FieldOffset(428)]
  public float m_ShadowNearPlaneOffset;
  [FieldOffset(432)]
  public CullingOptions m_CullingOptions;
  [FieldOffset(436)]
  public ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;
  [FieldOffset(440)]
  public CameraProperties m_CameraProperties;
  [FieldOffset(1436)]
  public float m_AccurateOcclusionThreshold;
  [FieldOffset(1440)]
  public int m_MaximumPortalCullingJobs;
  [FieldOffset(1444)]
  public Matrix4x4 m_StereoViewMatrix;
  [FieldOffset(1508)]
  public Matrix4x4 m_StereoProjectionMatrix;
  [FieldOffset(1572)]
  public float m_StereoSeparationDistance;
  [FieldOffset(1576)]
  public int m_maximumVisibleLights;
  [FieldOffset(1580)]
  public bool m_ConservativeEnclosingSphere;
  [FieldOffset(1584)]
  public int m_NumIterationsEnclosingSphere;
  public const int k_MaximumCullingPlaneCount = 10;
  public const int k_LayerCount = 32 /*0x20*/;
  public const int k_CullingJobCountLowerLimit = 1;
  public const int k_CullingJobCountUpperLimit = 16 /*0x10*/;

  static ScriptableCullingParameters()
  {
    Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ScriptableCullingParameters));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr);
    ScriptableCullingParameters.NativeFieldInfoPtr_m_LODParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_LODParameters));
    ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (maximumCullingPlaneCount));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_CullingPlanes));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_CullingPlaneCount));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_CullingMask));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_SceneMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_SceneMask));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_ViewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_ViewID));
    ScriptableCullingParameters.NativeFieldInfoPtr_layerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (layerCount));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_LayerFarCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_LayerFarCullDistances));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_LayerCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_LayerCull));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_CullingMatrix));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_Origin));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_ShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_ShadowDistance));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_ShadowNearPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_ShadowNearPlaneOffset));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_CullingOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_CullingOptions));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_ReflectionProbeSortingCriteria));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_CameraProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_CameraProperties));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_AccurateOcclusionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_AccurateOcclusionThreshold));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_MaximumPortalCullingJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_MaximumPortalCullingJobs));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_StereoViewMatrix));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_StereoProjectionMatrix));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_StereoSeparationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_StereoSeparationDistance));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_maximumVisibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_maximumVisibleLights));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_ConservativeEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_ConservativeEnclosingSphere));
    ScriptableCullingParameters.NativeFieldInfoPtr_m_NumIterationsEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, nameof (m_NumIterationsEnclosingSphere));
    ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670343);
    ScriptableCullingParameters.NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670344);
    ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670345);
    ScriptableCullingParameters.NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670346);
    ScriptableCullingParameters.NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670347);
    ScriptableCullingParameters.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670348);
    ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670349);
    ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670350);
    ScriptableCullingParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100670351);
  }

  public unsafe int cullingPlaneCount
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      this.m_CullingPlaneCount = value >= 0 && value <= 10 ? value : throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("{0} was {1}, but must be at least 0 and less than {2}", (Il2CppSystem.Object) nameof (value), (Il2CppSystem.Object) (System.ValueType) value, (Il2CppSystem.Object) (System.ValueType) 10));
    }
  }

  public unsafe float shadowDistance
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 487450, RefRangeEnd = 487451, XrefRangeStart = 487450, XrefRangeEnd = 487450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ShadowDistance;
  }

  public unsafe CullingOptions cullingOptions
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 487451, RefRangeEnd = 487457, XrefRangeStart = 487451, XrefRangeEnd = 487451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CullingOptions*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 487457, RefRangeEnd = 487463, XrefRangeStart = 487457, XrefRangeEnd = 487457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487463, RefRangeEnd = 487465, XrefRangeStart = 487463, XrefRangeEnd = 487463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetLayerCullingDistance(int layerIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &layerIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487468, RefRangeEnd = 487470, XrefRangeStart = 487465, XrefRangeEnd = 487468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Plane GetCullingPlane(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487488, RefRangeEnd = 487489, XrefRangeStart = 487470, XrefRangeEnd = 487488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(ScriptableCullingParameters other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487489, XrefRangeEnd = 487496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487496, XrefRangeEnd = 487515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableCullingParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int maximumCullingPlaneCount
  {
    get
    {
      int cullingPlaneCount;
      IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*) &cullingPlaneCount);
      return cullingPlaneCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*) &value);
    }
  }

  public static unsafe int layerCount
  {
    get
    {
      int layerCount;
      IL2CPP.il2cpp_field_static_get_value(ScriptableCullingParameters.NativeFieldInfoPtr_layerCount, (void*) &layerCount);
      return layerCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScriptableCullingParameters.NativeFieldInfoPtr_layerCount, (void*) &value);
    }
  }

  public int maximumVisibleLights
  {
    get => this.m_maximumVisibleLights;
    set => this.m_maximumVisibleLights = value;
  }

  public bool conservativeEnclosingSphere
  {
    get => this.m_ConservativeEnclosingSphere;
    set => this.m_ConservativeEnclosingSphere = value;
  }

  public int numIterationsEnclosingSphere
  {
    get => this.m_NumIterationsEnclosingSphere;
    set => this.m_NumIterationsEnclosingSphere = value;
  }

  public bool isOrthographic
  {
    get => this.m_LODParameters.isOrthographic;
    set => this.m_LODParameters.isOrthographic = value;
  }

  public LODParameters lodParameters
  {
    get => this.m_LODParameters;
    set => this.m_LODParameters = value;
  }

  public uint cullingMask
  {
    get => this.m_CullingMask;
    set => this.m_CullingMask = value;
  }

  public Matrix4x4 cullingMatrix
  {
    get => this.m_CullingMatrix;
    set => this.m_CullingMatrix = value;
  }

  public Vector3 origin
  {
    get => this.m_Origin;
    set => this.m_Origin = value;
  }

  public float shadowNearPlaneOffset
  {
    get => this.m_ShadowNearPlaneOffset;
    set => this.m_ShadowNearPlaneOffset = value;
  }

  public ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
  {
    get => this.m_ReflectionProbeSortingCriteria;
    set => this.m_ReflectionProbeSortingCriteria = value;
  }

  public CameraProperties cameraProperties
  {
    get => this.m_CameraProperties;
    set => this.m_CameraProperties = value;
  }

  public Matrix4x4 stereoViewMatrix
  {
    get => this.m_StereoViewMatrix;
    set => this.m_StereoViewMatrix = value;
  }

  public Matrix4x4 stereoProjectionMatrix
  {
    get => this.m_StereoProjectionMatrix;
    set => this.m_StereoProjectionMatrix = value;
  }

  public float stereoSeparationDistance
  {
    get => this.m_StereoSeparationDistance;
    set => this.m_StereoSeparationDistance = value;
  }

  public float accurateOcclusionThreshold
  {
    get => this.m_AccurateOcclusionThreshold;
    set => this.m_AccurateOcclusionThreshold = Mathf.Max(-1f, value);
  }

  public int maximumPortalCullingJobs
  {
    get => this.m_MaximumPortalCullingJobs;
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static int cullingJobsLowerLimit => 1;

  public static int cullingJobsUpperLimit => 16 /*0x10*/;

  public void SetLayerCullingDistance(int layerIndex, float distance)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetCullingPlane(int index, Plane plane)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool operator ==(
    ScriptableCullingParameters left,
    ScriptableCullingParameters right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(
    ScriptableCullingParameters left,
    ScriptableCullingParameters right)
  {
    return !left.Equals(right);
  }

  [ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_CullingPlanes>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _m_CullingPlanes_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public byte FixedElementField;

    static _m_CullingPlanes_e__FixedBuffer()
    {
      Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
      ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_LayerFarCullDistances>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _m_LayerFarCullDistances_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public float FixedElementField;

    static _m_LayerFarCullDistances_e__FixedBuffer()
    {
      Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_LayerFarCullDistances>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr);
      ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters._m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
