// Decompiled with JetBrains decompiler
// Type: UnityEngine.Device.SystemInfo
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.Device;

public static class SystemInfo
{
  public const string unsupportedIdentifier = "n/a";

  public static float batteryLevel => UnityEngine.SystemInfo.batteryLevel;

  public static BatteryStatus batteryStatus => UnityEngine.SystemInfo.batteryStatus;

  public static string operatingSystem => UnityEngine.SystemInfo.operatingSystem;

  public static OperatingSystemFamily operatingSystemFamily => UnityEngine.SystemInfo.operatingSystemFamily;

  public static string processorType => UnityEngine.SystemInfo.processorType;

  public static string ProcessorModel => UnityEngine.SystemInfo.processorModel;

  public static string ProcessorManufacturer => UnityEngine.SystemInfo.processorManufacturer;

  public static int processorFrequency => UnityEngine.SystemInfo.processorFrequency;

  public static int processorCount => UnityEngine.SystemInfo.processorCount;

  public static int systemMemorySize => UnityEngine.SystemInfo.systemMemorySize;

  public static string deviceUniqueIdentifier => UnityEngine.SystemInfo.deviceUniqueIdentifier;

  public static string deviceName => UnityEngine.SystemInfo.deviceName;

  public static string deviceModel => UnityEngine.SystemInfo.deviceModel;

  public static bool supportsAccelerometer => UnityEngine.SystemInfo.supportsAccelerometer;

  public static bool supportsGyroscope => UnityEngine.SystemInfo.supportsGyroscope;

  public static bool supportsLocationService => UnityEngine.SystemInfo.supportsLocationService;

  public static bool supportsVibration => UnityEngine.SystemInfo.supportsVibration;

  public static bool supportsAudio => UnityEngine.SystemInfo.supportsAudio;

  public static DeviceType deviceType => UnityEngine.SystemInfo.deviceType;

  public static int graphicsMemorySize => UnityEngine.SystemInfo.graphicsMemorySize;

  public static string graphicsDeviceName => UnityEngine.SystemInfo.graphicsDeviceName;

  public static string graphicsDeviceVendor => UnityEngine.SystemInfo.graphicsDeviceVendor;

  public static int graphicsDeviceID => UnityEngine.SystemInfo.graphicsDeviceID;

  public static int graphicsDeviceVendorID => UnityEngine.SystemInfo.graphicsDeviceVendorID;

  public static GraphicsDeviceType graphicsDeviceType => UnityEngine.SystemInfo.graphicsDeviceType;

  public static bool graphicsUVStartsAtTop => UnityEngine.SystemInfo.graphicsUVStartsAtTop;

  public static string graphicsDeviceVersion => UnityEngine.SystemInfo.graphicsDeviceVersion;

  public static int graphicsShaderLevel => UnityEngine.SystemInfo.graphicsShaderLevel;

  public static bool graphicsMultiThreaded => UnityEngine.SystemInfo.graphicsMultiThreaded;

  public static RenderingThreadingMode renderingThreadingMode => UnityEngine.SystemInfo.renderingThreadingMode;

  public static FoveatedRenderingCaps foveatedRenderingCaps => UnityEngine.SystemInfo.foveatedRenderingCaps;

  public static int maxTiledPixelStorageSize => UnityEngine.SystemInfo.maxTiledPixelStorageSize;

  public static bool hasHiddenSurfaceRemovalOnGPU => UnityEngine.SystemInfo.hasHiddenSurfaceRemovalOnGPU;

  public static bool hasDynamicUniformArrayIndexingInFragmentShaders
  {
    get => UnityEngine.SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders;
  }

  public static bool supportsShadows => UnityEngine.SystemInfo.supportsShadows;

  public static bool supportsRawShadowDepthSampling => UnityEngine.SystemInfo.supportsRawShadowDepthSampling;

  public static bool supportsMotionVectors => UnityEngine.SystemInfo.supportsMotionVectors;

  public static bool supports3DTextures => UnityEngine.SystemInfo.supports3DTextures;

  public static bool supportsCompressed3DTextures => UnityEngine.SystemInfo.supportsCompressed3DTextures;

  public static bool supports2DArrayTextures => UnityEngine.SystemInfo.supports2DArrayTextures;

  public static bool supports3DRenderTextures => UnityEngine.SystemInfo.supports3DRenderTextures;

  public static bool supportsCubemapArrayTextures => UnityEngine.SystemInfo.supportsCubemapArrayTextures;

  public static bool supportsAnisotropicFilter => UnityEngine.SystemInfo.supportsAnisotropicFilter;

  public static CopyTextureSupport copyTextureSupport => UnityEngine.SystemInfo.copyTextureSupport;

  public static bool supportsComputeShaders => UnityEngine.SystemInfo.supportsComputeShaders;

  public static bool supportsGeometryShaders => UnityEngine.SystemInfo.supportsGeometryShaders;

  public static bool supportsTessellationShaders => UnityEngine.SystemInfo.supportsTessellationShaders;

  public static bool supportsRenderTargetArrayIndexFromVertexShader
  {
    get => UnityEngine.SystemInfo.supportsRenderTargetArrayIndexFromVertexShader;
  }

  public static bool supportsInstancing => UnityEngine.SystemInfo.supportsInstancing;

  public static bool supportsHardwareQuadTopology => UnityEngine.SystemInfo.supportsHardwareQuadTopology;

  public static bool supports32bitsIndexBuffer => UnityEngine.SystemInfo.supports32bitsIndexBuffer;

  public static bool supportsSparseTextures => UnityEngine.SystemInfo.supportsSparseTextures;

  public static int supportedRenderTargetCount => UnityEngine.SystemInfo.supportedRenderTargetCount;

  public static bool supportsSeparatedRenderTargetsBlend
  {
    get => UnityEngine.SystemInfo.supportsSeparatedRenderTargetsBlend;
  }

  public static int supportedRandomWriteTargetCount => UnityEngine.SystemInfo.supportedRandomWriteTargetCount;

  public static int supportsMultisampledTextures => UnityEngine.SystemInfo.supportsMultisampledTextures;

  public static bool supportsMultisampled2DArrayTextures
  {
    get => UnityEngine.SystemInfo.supportsMultisampled2DArrayTextures;
  }

  public static bool supportsMultisampledBackBuffer => UnityEngine.SystemInfo.supportsMultisampledBackBuffer;

  public static bool supportsMultisampleAutoResolve => UnityEngine.SystemInfo.supportsMultisampleAutoResolve;

  public static int supportsTextureWrapMirrorOnce => UnityEngine.SystemInfo.supportsTextureWrapMirrorOnce;

  public static bool usesReversedZBuffer => UnityEngine.SystemInfo.usesReversedZBuffer;

  public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
  {
    return UnityEngine.SystemInfo.SupportsRenderTextureFormat(format);
  }

  public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
  {
    return UnityEngine.SystemInfo.SupportsBlendingOnRenderTextureFormat(format);
  }

  public static bool SupportsTextureFormat(TextureFormat format)
  {
    return UnityEngine.SystemInfo.SupportsTextureFormat(format);
  }

  public static bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension)
  {
    return UnityEngine.SystemInfo.SupportsVertexAttributeFormat(format, dimension);
  }

  public static NPOTSupport npotSupport => UnityEngine.SystemInfo.npotSupport;

  public static int maxTextureSize => UnityEngine.SystemInfo.maxTextureSize;

  public static int maxTexture3DSize => UnityEngine.SystemInfo.maxTexture3DSize;

  public static int maxTextureArraySlices => UnityEngine.SystemInfo.maxTextureArraySlices;

  public static int maxCubemapSize => UnityEngine.SystemInfo.maxCubemapSize;

  public static int maxAnisotropyLevel => UnityEngine.SystemInfo.maxAnisotropyLevel;

  public static int maxComputeBufferInputsVertex => UnityEngine.SystemInfo.maxComputeBufferInputsVertex;

  public static int maxComputeBufferInputsFragment => UnityEngine.SystemInfo.maxComputeBufferInputsFragment;

  public static int maxComputeBufferInputsGeometry => UnityEngine.SystemInfo.maxComputeBufferInputsGeometry;

  public static int maxComputeBufferInputsDomain => UnityEngine.SystemInfo.maxComputeBufferInputsDomain;

  public static int maxComputeBufferInputsHull => UnityEngine.SystemInfo.maxComputeBufferInputsHull;

  public static int maxComputeBufferInputsCompute => UnityEngine.SystemInfo.maxComputeBufferInputsCompute;

  public static int maxComputeWorkGroupSize => UnityEngine.SystemInfo.maxComputeWorkGroupSize;

  public static int maxComputeWorkGroupSizeX => UnityEngine.SystemInfo.maxComputeWorkGroupSizeX;

  public static int maxComputeWorkGroupSizeY => UnityEngine.SystemInfo.maxComputeWorkGroupSizeY;

  public static int maxComputeWorkGroupSizeZ => UnityEngine.SystemInfo.maxComputeWorkGroupSizeZ;

  public static int computeSubGroupSize => UnityEngine.SystemInfo.computeSubGroupSize;

  public static bool supportsAsyncCompute => UnityEngine.SystemInfo.supportsAsyncCompute;

  public static bool supportsGpuRecorder => UnityEngine.SystemInfo.supportsGpuRecorder;

  public static bool supportsGraphicsFence => UnityEngine.SystemInfo.supportsGraphicsFence;

  public static bool supportsAsyncGPUReadback => UnityEngine.SystemInfo.supportsAsyncGPUReadback;

  public static bool supportsParallelPSOCreation => UnityEngine.SystemInfo.supportsParallelPSOCreation;

  public static bool supportsRayTracing => UnityEngine.SystemInfo.supportsRayTracing;

  public static bool supportsRayTracingShaders => UnityEngine.SystemInfo.supportsRayTracingShaders;

  public static bool supportsInlineRayTracing => UnityEngine.SystemInfo.supportsInlineRayTracing;

  public static bool supportsIndirectDispatchRays => UnityEngine.SystemInfo.supportsIndirectDispatchRays;

  public static bool supportsSetConstantBuffer => UnityEngine.SystemInfo.supportsSetConstantBuffer;

  public static int constantBufferOffsetAlignment => UnityEngine.SystemInfo.constantBufferOffsetAlignment;

  public static int maxConstantBufferSize => UnityEngine.SystemInfo.maxConstantBufferSize;

  public static long maxGraphicsBufferSize => UnityEngine.SystemInfo.maxGraphicsBufferSize;

  public static bool hasMipMaxLevel => UnityEngine.SystemInfo.hasMipMaxLevel;

  public static bool supportsMipStreaming => UnityEngine.SystemInfo.supportsMipStreaming;

  public static bool usesLoadStoreActions => UnityEngine.SystemInfo.usesLoadStoreActions;

  public static HDRDisplaySupportFlags hdrDisplaySupportFlags => UnityEngine.SystemInfo.hdrDisplaySupportFlags;

  public static bool supportsConservativeRaster => UnityEngine.SystemInfo.supportsConservativeRaster;

  public static bool supportsMultiview => UnityEngine.SystemInfo.supportsMultiview;

  public static bool supportsStoreAndResolveAction => UnityEngine.SystemInfo.supportsStoreAndResolveAction;

  public static bool supportsMultisampleResolveDepth => UnityEngine.SystemInfo.supportsMultisampleResolveDepth;

  public static bool supportsMultisampleResolveStencil
  {
    get => UnityEngine.SystemInfo.supportsMultisampleResolveStencil;
  }

  public static bool supportsIndirectArgumentsBuffer => UnityEngine.SystemInfo.supportsIndirectArgumentsBuffer;

  public static bool supportsDepthFetchInRenderPass => UnityEngine.SystemInfo.supportsDepthFetchInRenderPass;

  public static bool supportsDynamicResolution => UnityEngine.SystemInfo.supportsDynamicResolution;

  public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
  {
    GraphicsFormatUsage usage1 = (GraphicsFormatUsage) (1 << (int) (usage & (FormatUsage.SetPixels | FormatUsage.SetPixels32 | FormatUsage.StencilSampling)));
    return SystemInfo.IsFormatSupported(format, usage1);
  }

  public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage)
  {
    return UnityEngine.SystemInfo.IsFormatSupported(format, usage);
  }

  public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
  {
    GraphicsFormatUsage usage1 = (GraphicsFormatUsage) (1 << (int) (usage & (FormatUsage.SetPixels | FormatUsage.SetPixels32 | FormatUsage.StencilSampling)));
    return SystemInfo.GetCompatibleFormat(format, usage1);
  }

  public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage)
  {
    return UnityEngine.SystemInfo.GetCompatibleFormat(format, usage);
  }

  public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
  {
    return UnityEngine.SystemInfo.GetGraphicsFormat(format);
  }

  public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
  {
    return UnityEngine.SystemInfo.GetRenderTextureSupportedMSAASampleCount(desc);
  }

  public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
  {
    return UnityEngine.SystemInfo.SupportsRandomWriteOnRenderTextureFormat(format);
  }

  public static int GetTiledRenderTargetStorageSize(GraphicsFormat format, int sampleCount)
  {
    return UnityEngine.SystemInfo.GetTiledRenderTargetStorageSize(format, sampleCount);
  }
}
