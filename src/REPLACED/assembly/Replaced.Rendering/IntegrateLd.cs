// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.IntegrateLd
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class IntegrateLd(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kIntegrateDiffuseLdPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCopySpecularLdPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kIntegrateSpecularLdPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDiffuseLd;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSpecularLd;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexEnvironmentMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDiffuseLdDimSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSpecularLdDimSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSpecularLdMipmapLevelCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexDiffuseLdDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexSpecularLdDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr__integrateLdMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__texDiffuseLd;
  private static readonly System.IntPtr NativeFieldInfoPtr__texSpecularLd;
  private static readonly System.IntPtr NativeFieldInfoPtr__texSourceEnvmapName;
  private static readonly System.IntPtr NativeFieldInfoPtr__envmapRotationOyDegrees;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSpecularLdSampleCount_Private_Static_UInt32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexDiffuseLd_Private_Static_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexSpecularLd_Private_Static_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_Cubemap_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeFillWithColor_Private_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeIntegration_Private_Void_CommandBuffer_Cubemap_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Single_Int32_UInt32_byref_Vector2_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static IntegrateLd()
  {
    Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (IntegrateLd));
    IntegrateLd.NativeFieldInfoPtr_kIntegrateDiffuseLdPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kIntegrateDiffuseLdPass));
    IntegrateLd.NativeFieldInfoPtr_kCopySpecularLdPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kCopySpecularLdPass));
    IntegrateLd.NativeFieldInfoPtr_kIntegrateSpecularLdPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kIntegrateSpecularLdPass));
    IntegrateLd.NativeFieldInfoPtr_kSidTexDiffuseLd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kSidTexDiffuseLd));
    IntegrateLd.NativeFieldInfoPtr_kSidTexSpecularLd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kSidTexSpecularLd));
    IntegrateLd.NativeFieldInfoPtr_kSidTexEnvironmentMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kSidTexEnvironmentMap));
    IntegrateLd.NativeFieldInfoPtr_kDiffuseLdDimSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kDiffuseLdDimSize));
    IntegrateLd.NativeFieldInfoPtr_kSpecularLdDimSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kSpecularLdDimSize));
    IntegrateLd.NativeFieldInfoPtr_kSpecularLdMipmapLevelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kSpecularLdMipmapLevelCount));
    IntegrateLd.NativeFieldInfoPtr_kTexDiffuseLdDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kTexDiffuseLdDesc));
    IntegrateLd.NativeFieldInfoPtr_kTexSpecularLdDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (kTexSpecularLdDesc));
    IntegrateLd.NativeFieldInfoPtr__integrateLdMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (_integrateLdMaterial));
    IntegrateLd.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (_cbuffer));
    IntegrateLd.NativeFieldInfoPtr__texDiffuseLd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (_texDiffuseLd));
    IntegrateLd.NativeFieldInfoPtr__texSpecularLd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (_texSpecularLd));
    IntegrateLd.NativeFieldInfoPtr__texSourceEnvmapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (_texSourceEnvmapName));
    IntegrateLd.NativeFieldInfoPtr__envmapRotationOyDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (_envmapRotationOyDegrees));
    IntegrateLd.NativeMethodInfoPtr_GetSpecularLdSampleCount_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663924);
    IntegrateLd.NativeMethodInfoPtr_MakeTexDiffuseLd_Private_Static_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663925);
    IntegrateLd.NativeMethodInfoPtr_MakeTexSpecularLd_Private_Static_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663926);
    IntegrateLd.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663927);
    IntegrateLd.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_Cubemap_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663928);
    IntegrateLd.NativeMethodInfoPtr_EncodeFillWithColor_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663929);
    IntegrateLd.NativeMethodInfoPtr_EncodeIntegration_Private_Void_CommandBuffer_Cubemap_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663930);
    IntegrateLd.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Single_Int32_UInt32_byref_Vector2_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663931);
    IntegrateLd.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, 100663932);
  }

  [CallerCount(0)]
  public static unsafe uint GetSpecularLdSampleCount(int mipmapLevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mipmapLevel
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_GetSpecularLdSampleCount_Private_Static_UInt32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930924, XrefRangeEnd = 930935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexDiffuseLd()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_MakeTexDiffuseLd_Private_Static_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930935, XrefRangeEnd = 930946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexSpecularLd()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_MakeTexSpecularLd_Private_Static_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930946, XrefRangeEnd = 930959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IntegrateLd(Shader integrateSpecularLdShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) integrateSpecularLdShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930959, XrefRangeEnd = 930981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(CommandBuffer cmd, Cubemap texEnvironmentMap, float rotationOyDegrees)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texEnvironmentMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationOyDegrees;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_Cubemap_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930981, XrefRangeEnd = 931005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeFillWithColor(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_EncodeFillWithColor_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931005, XrefRangeEnd = 931053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeIntegration(
    CommandBuffer cmd,
    Cubemap texEnvironmentMap,
    float rotationOyDegrees)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texEnvironmentMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationOyDegrees;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_EncodeIntegration_Private_Void_CommandBuffer_Cubemap_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 931122, RefRangeEnd = 931125, XrefRangeStart = 931053, XrefRangeEnd = 931122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    float omegaPRcp,
    int mipmapLevel,
    uint sampleCount,
    [In] ref Vector2 cubemapSizeRcp,
    int cubemapFaceIndex,
    float rotationOyDegrees)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &omegaPRcp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &mipmapLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sampleCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref cubemapSizeRcp;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &cubemapFaceIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &rotationOyDegrees;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_Single_Int32_UInt32_byref_Vector2_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931125, XrefRangeEnd = 931129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateLd.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kIntegrateDiffuseLdPass
  {
    get
    {
      int integrateDiffuseLdPass;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kIntegrateDiffuseLdPass, (void*) &integrateDiffuseLdPass);
      return integrateDiffuseLdPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kIntegrateDiffuseLdPass, (void*) &value);
    }
  }

  public static unsafe int kCopySpecularLdPass
  {
    get
    {
      int copySpecularLdPass;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kCopySpecularLdPass, (void*) &copySpecularLdPass);
      return copySpecularLdPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kCopySpecularLdPass, (void*) &value);
    }
  }

  public static unsafe int kIntegrateSpecularLdPass
  {
    get
    {
      int integrateSpecularLdPass;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kIntegrateSpecularLdPass, (void*) &integrateSpecularLdPass);
      return integrateSpecularLdPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kIntegrateSpecularLdPass, (void*) &value);
    }
  }

  public static unsafe int kSidTexDiffuseLd
  {
    get
    {
      int kSidTexDiffuseLd;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kSidTexDiffuseLd, (void*) &kSidTexDiffuseLd);
      return kSidTexDiffuseLd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kSidTexDiffuseLd, (void*) &value);
    }
  }

  public static unsafe int kSidTexSpecularLd
  {
    get
    {
      int sidTexSpecularLd;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kSidTexSpecularLd, (void*) &sidTexSpecularLd);
      return sidTexSpecularLd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kSidTexSpecularLd, (void*) &value);
    }
  }

  public static unsafe int kSidTexEnvironmentMap
  {
    get
    {
      int texEnvironmentMap;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kSidTexEnvironmentMap, (void*) &texEnvironmentMap);
      return texEnvironmentMap;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kSidTexEnvironmentMap, (void*) &value);
    }
  }

  public static unsafe int kDiffuseLdDimSize
  {
    get
    {
      int diffuseLdDimSize;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kDiffuseLdDimSize, (void*) &diffuseLdDimSize);
      return diffuseLdDimSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kDiffuseLdDimSize, (void*) &value);
    }
  }

  public static unsafe int kSpecularLdDimSize
  {
    get
    {
      int specularLdDimSize;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kSpecularLdDimSize, (void*) &specularLdDimSize);
      return specularLdDimSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kSpecularLdDimSize, (void*) &value);
    }
  }

  public static unsafe int kSpecularLdMipmapLevelCount
  {
    get
    {
      int mipmapLevelCount;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kSpecularLdMipmapLevelCount, (void*) &mipmapLevelCount);
      return mipmapLevelCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kSpecularLdMipmapLevelCount, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexDiffuseLdDesc
  {
    get
    {
      RenderTextureDescriptor texDiffuseLdDesc;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kTexDiffuseLdDesc, (void*) &texDiffuseLdDesc);
      return texDiffuseLdDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kTexDiffuseLdDesc, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexSpecularLdDesc
  {
    get
    {
      RenderTextureDescriptor texSpecularLdDesc;
      IL2CPP.il2cpp_field_static_get_value(IntegrateLd.NativeFieldInfoPtr_kTexSpecularLdDesc, (void*) &texSpecularLdDesc);
      return texSpecularLdDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateLd.NativeFieldInfoPtr_kTexSpecularLdDesc, (void*) &value);
    }
  }

  public unsafe Material _integrateLdMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__integrateLdMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__integrateLdMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<IntegrateLd.IntegrateLdCBuffer> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<IntegrateLd.IntegrateLdCBuffer>) null : Il2CppObjectPool.Get<CBuffer<IntegrateLd.IntegrateLdCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public RenderTextureResource _texDiffuseLd
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__texDiffuseLd);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__texDiffuseLd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public RenderTextureResource _texSpecularLd
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__texSpecularLd);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__texSpecularLd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe string _texSourceEnvmapName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__texSourceEnvmapName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__texSourceEnvmapName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float _envmapRotationOyDegrees
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__envmapRotationOyDegrees));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateLd.NativeFieldInfoPtr__envmapRotationOyDegrees)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct IntegrateLdCBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_fragPosition2CubemapDirWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_omegaPRcp;
    private static readonly System.IntPtr NativeFieldInfoPtr_mipmapLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_sampleCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_sampleCountRcp;
    [FieldOffset(0)]
    public Matrix4x4 fragPosition2CubemapDirWs;
    [FieldOffset(64 /*0x40*/)]
    public float omegaPRcp;
    [FieldOffset(68)]
    public float mipmapLevel;
    [FieldOffset(72)]
    public uint sampleCount;
    [FieldOffset(76)]
    public float sampleCountRcp;

    static IntegrateLdCBuffer()
    {
      Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntegrateLd>.NativeClassPtr, nameof (IntegrateLdCBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr);
      IntegrateLd.IntegrateLdCBuffer.NativeFieldInfoPtr_fragPosition2CubemapDirWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr, nameof (fragPosition2CubemapDirWs));
      IntegrateLd.IntegrateLdCBuffer.NativeFieldInfoPtr_omegaPRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr, nameof (omegaPRcp));
      IntegrateLd.IntegrateLdCBuffer.NativeFieldInfoPtr_mipmapLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr, nameof (mipmapLevel));
      IntegrateLd.IntegrateLdCBuffer.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr, nameof (sampleCount));
      IntegrateLd.IntegrateLdCBuffer.NativeFieldInfoPtr_sampleCountRcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr, nameof (sampleCountRcp));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IntegrateLd.IntegrateLdCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
