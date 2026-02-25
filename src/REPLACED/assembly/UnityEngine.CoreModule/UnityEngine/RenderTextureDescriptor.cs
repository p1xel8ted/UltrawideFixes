// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderTextureDescriptor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderTextureDescriptor
{
  private static readonly System.IntPtr NativeFieldInfoPtr__width_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__height_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__msaaSamples_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__volumeDepth_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__mipCount_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__graphicsFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr__stencilFormat_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__depthStencilFormat_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__dimension_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__shadowSamplingMode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__vrUsage_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__flags;
  private static readonly System.IntPtr NativeFieldInfoPtr__memoryless_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useDynamicScaleExplicit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useDynamicScaleExplicit_Public_set_Void_Boolean_0;
  [FieldOffset(0)]
  public int _width_k__BackingField;
  [FieldOffset(4)]
  public int _height_k__BackingField;
  [FieldOffset(8)]
  public int _msaaSamples_k__BackingField;
  [FieldOffset(12)]
  public int _volumeDepth_k__BackingField;
  [FieldOffset(16 /*0x10*/)]
  public int _mipCount_k__BackingField;
  [FieldOffset(20)]
  public GraphicsFormat _graphicsFormat;
  [FieldOffset(24)]
  public GraphicsFormat _stencilFormat_k__BackingField;
  [FieldOffset(28)]
  public GraphicsFormat _depthStencilFormat_k__BackingField;
  [FieldOffset(32 /*0x20*/)]
  public TextureDimension _dimension_k__BackingField;
  [FieldOffset(36)]
  public ShadowSamplingMode _shadowSamplingMode_k__BackingField;
  [FieldOffset(40)]
  public VRTextureUsage _vrUsage_k__BackingField;
  [FieldOffset(44)]
  public RenderTextureCreationFlags _flags;
  [FieldOffset(48 /*0x30*/)]
  public RenderTextureMemoryless _memoryless_k__BackingField;

  static RenderTextureDescriptor()
  {
    Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RenderTextureDescriptor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr);
    RenderTextureDescriptor.NativeFieldInfoPtr__width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<width>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<height>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__msaaSamples_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<msaaSamples>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__volumeDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<volumeDepth>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__mipCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<mipCount>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__graphicsFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, nameof (_graphicsFormat));
    RenderTextureDescriptor.NativeFieldInfoPtr__stencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<stencilFormat>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__depthStencilFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<depthStencilFormat>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__shadowSamplingMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<shadowSamplingMode>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__vrUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<vrUsage>k__BackingField");
    RenderTextureDescriptor.NativeFieldInfoPtr__flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, nameof (_flags));
    RenderTextureDescriptor.NativeFieldInfoPtr__memoryless_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, "<memoryless>k__BackingField");
    RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667109);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667110);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667111);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667112);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667113);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667114);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667115);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667116);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667117);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667118);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667119);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667120 /*0x06000EF0*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667121);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667122);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667123);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667124);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667125);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667126);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667127);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667128);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667129);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667130);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667131);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667132);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667133);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667134);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667135);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667136 /*0x06000F00*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667137 /*0x06000F01*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667138 /*0x06000F02*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667139 /*0x06000F03*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667140 /*0x06000F04*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667141 /*0x06000F05*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667142 /*0x06000F06*/);
    RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667143 /*0x06000F07*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667144 /*0x06000F08*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667145 /*0x06000F09*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667146 /*0x06000F0A*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667147 /*0x06000F0B*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667148 /*0x06000F0C*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667149 /*0x06000F0D*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667150 /*0x06000F0E*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667151 /*0x06000F0F*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667152 /*0x06000F10*/);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667153);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667154);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667155);
    RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScaleExplicit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667156);
    RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScaleExplicit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, 100667157);
  }

  public unsafe int width
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_width_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int height
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_height_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int msaaSamples
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_msaaSamples_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147413, RefRangeEnd = 147418, XrefRangeStart = 147413, XrefRangeEnd = 147418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_msaaSamples_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int volumeDepth
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_volumeDepth_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147852, RefRangeEnd = 147856, XrefRangeStart = 147852, XrefRangeEnd = 147856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_volumeDepth_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int mipCount
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_mipCount_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._mipCount_k__BackingField;
  }

  public unsafe GraphicsFormat graphicsFormat
  {
    [CallerCount(37), CachedScanResults(RefRangeStart = 327622, RefRangeEnd = 327659, XrefRangeStart = 327622, XrefRangeEnd = 327659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 437493, RefRangeEnd = 437495, XrefRangeStart = 437489, XrefRangeEnd = 437493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_graphicsFormat_Public_set_Void_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GraphicsFormat stencilFormat
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_stencilFormat_Public_set_Void_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._stencilFormat_k__BackingField;
  }

  public unsafe GraphicsFormat depthStencilFormat
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthStencilFormat_Public_get_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthStencilFormat_Public_set_Void_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RenderTextureFormat colorFormat
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437495, XrefRangeEnd = 437496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_colorFormat_Public_get_RenderTextureFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(17), CachedScanResults(RefRangeStart = 437514, RefRangeEnd = 437531, XrefRangeStart = 437496, XrefRangeEnd = 437514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_colorFormat_Public_set_Void_RenderTextureFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool sRGB
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437531, XrefRangeEnd = 437535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_sRGB_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(18), CachedScanResults(RefRangeStart = 437548, RefRangeEnd = 437566, XrefRangeStart = 437535, XrefRangeEnd = 437548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int depthBufferBits
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437566, XrefRangeEnd = 437570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_depthBufferBits_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(18), CachedScanResults(RefRangeStart = 437571, RefRangeEnd = 437589, XrefRangeStart = 437570, XrefRangeEnd = 437571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_depthBufferBits_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe TextureDimension dimension
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_TextureDimension_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TextureDimension*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_TextureDimension_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ShadowSamplingMode shadowSamplingMode
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_shadowSamplingMode_Public_get_ShadowSamplingMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ShadowSamplingMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_shadowSamplingMode_Public_set_Void_ShadowSamplingMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe VRTextureUsage vrUsage
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_vrUsage_Public_get_VRTextureUsage_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(VRTextureUsage*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_vrUsage_Public_set_Void_VRTextureUsage_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RenderTextureMemoryless memoryless
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_memoryless_Public_get_RenderTextureMemoryless_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureMemoryless*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_memoryless_Public_set_Void_RenderTextureMemoryless_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437590, RefRangeEnd = 437591, XrefRangeStart = 437589, XrefRangeEnd = 437590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(int width, int height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437591, XrefRangeEnd = 437592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorFormat;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 437597, RefRangeEnd = 437599, XrefRangeStart = 437592, XrefRangeEnd = 437597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(
    int width,
    int height,
    RenderTextureFormat colorFormat,
    int depthBufferBits)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthBufferBits;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437599, XrefRangeEnd = 437600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(
    int width,
    int height,
    RenderTextureFormat colorFormat,
    int depthBufferBits,
    int mipCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthBufferBits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 437607, RefRangeEnd = 437609, XrefRangeStart = 437600, XrefRangeEnd = 437607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(
    int width,
    int height,
    RenderTextureFormat colorFormat,
    int depthBufferBits,
    int mipCount,
    RenderTextureReadWrite readWrite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthBufferBits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &readWrite;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_RenderTextureFormat_Int32_Int32_RenderTextureReadWrite_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437614, RefRangeEnd = 437615, XrefRangeStart = 437609, XrefRangeEnd = 437614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(
    int width,
    int height,
    GraphicsFormat colorFormat,
    GraphicsFormat depthStencilFormat)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthStencilFormat;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437619, RefRangeEnd = 437620, XrefRangeStart = 437615, XrefRangeEnd = 437619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureDescriptor(
    int width,
    int height,
    GraphicsFormat colorFormat,
    GraphicsFormat depthStencilFormat,
    int mipCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthStencilFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &mipCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GraphicsFormat_GraphicsFormat_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetOrClearRenderTextureCreationFlag(
    bool value,
    RenderTextureCreationFlags flag)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &flag;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_SetOrClearRenderTextureCreationFlag_Private_Void_Boolean_RenderTextureCreationFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool useMipMap
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 437620, RefRangeEnd = 437625, XrefRangeStart = 437620, XrefRangeEnd = 437620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useMipMap_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(25), CachedScanResults(RefRangeStart = 437625, RefRangeEnd = 437650, XrefRangeStart = 437625, XrefRangeEnd = 437625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useMipMap_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool autoGenerateMips
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 437650, RefRangeEnd = 437655, XrefRangeStart = 437650, XrefRangeEnd = 437650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_autoGenerateMips_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 437655, RefRangeEnd = 437674, XrefRangeStart = 437655, XrefRangeEnd = 437655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_autoGenerateMips_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool enableRandomWrite
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 437674, RefRangeEnd = 437679, XrefRangeStart = 437674, XrefRangeEnd = 437674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_enableRandomWrite_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(25), CachedScanResults(RefRangeStart = 437679, RefRangeEnd = 437704, XrefRangeStart = 437679, XrefRangeEnd = 437679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_enableRandomWrite_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool bindMS
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 437704, RefRangeEnd = 437709, XrefRangeStart = 437704, XrefRangeEnd = 437704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_bindMS_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(21), CachedScanResults(RefRangeStart = 437709, RefRangeEnd = 437730, XrefRangeStart = 437709, XrefRangeEnd = 437709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_bindMS_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool createdFromScript
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_createdFromScript_Internal_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (this._flags & RenderTextureCreationFlags.CreatedFromScript) != 0;
  }

  public unsafe bool useDynamicScale
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 437730, RefRangeEnd = 437735, XrefRangeStart = 437730, XrefRangeEnd = 437730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScale_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 437735, RefRangeEnd = 437754, XrefRangeStart = 437735, XrefRangeEnd = 437735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScale_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool useDynamicScaleExplicit
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 437754, RefRangeEnd = 437758, XrefRangeStart = 437754, XrefRangeEnd = 437754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_get_useDynamicScaleExplicit_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 437758, RefRangeEnd = 437759, XrefRangeStart = 437758, XrefRangeEnd = 437758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTextureDescriptor.NativeMethodInfoPtr_set_useDynamicScaleExplicit_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureDescriptor>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public RenderTextureCreationFlags flags => this._flags;
}
