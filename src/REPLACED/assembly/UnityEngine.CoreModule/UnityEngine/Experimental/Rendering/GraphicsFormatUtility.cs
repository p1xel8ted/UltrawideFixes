// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.GraphicsFormatUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public class GraphicsFormatUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_tableNoStencil;
  private static readonly System.IntPtr NativeFieldInfoPtr_tableStencil;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDepthFormat_Public_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsStencilFormat_Public_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0;
  private static readonly GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate GetTextureFormat_Native_GraphicsFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsSwizzleFormatDelegate IsSwizzleFormatDelegateField;
  private static readonly GraphicsFormatUtility.GetColorComponentCountDelegate GetColorComponentCountDelegateField;
  private static readonly GraphicsFormatUtility.GetAlphaComponentCountDelegate GetAlphaComponentCountDelegateField;
  private static readonly GraphicsFormatUtility.IsCompressedFormatDelegate IsCompressedFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsPackedFormatDelegate IsPackedFormatDelegateField;
  private static readonly GraphicsFormatUtility.Is16BitPackedFormatDelegate Is16BitPackedFormatDelegateField;
  private static readonly GraphicsFormatUtility.ConvertToAlphaFormatDelegate ConvertToAlphaFormatDelegateField;
  private static readonly GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegate ConvertToAlphaFormat_Native_TextureFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegate IsAlphaOnlyFormat_Native_TextureFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsAlphaTestFormatDelegate IsAlphaTestFormatDelegateField;
  private static readonly GraphicsFormatUtility.HasAlphaChannelDelegate HasAlphaChannelDelegateField;
  private static readonly GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegate HasAlphaChannel_Native_TextureFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsIEEE754FormatDelegate IsIEEE754FormatDelegateField;
  private static readonly GraphicsFormatUtility.IsFloatFormatDelegate IsFloatFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsHalfFormatDelegate IsHalfFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsUnsignedFormatDelegate IsUnsignedFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsSignedFormatDelegate IsSignedFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsNormFormatDelegate IsNormFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsUNormFormatDelegate IsUNormFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsSNormFormatDelegate IsSNormFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsIntegerFormatDelegate IsIntegerFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsUIntFormatDelegate IsUIntFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsSIntFormatDelegate IsSIntFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsXRFormatDelegate IsXRFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsDXTCFormatDelegate IsDXTCFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsRGTCFormatDelegate IsRGTCFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsBPTCFormatDelegate IsBPTCFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsBCFormatDelegate IsBCFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsETCFormatDelegate IsETCFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsEACFormatDelegate IsEACFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsASTCFormatDelegate IsASTCFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsHDRFormatDelegate IsHDRFormatDelegateField;
  private static readonly GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegate IsHDRFormat_Native_TextureFormatDelegateField;
  private static readonly GraphicsFormatUtility.GetBlockWidthDelegate GetBlockWidthDelegateField;
  private static readonly GraphicsFormatUtility.GetBlockHeightDelegate GetBlockHeightDelegateField;
  private static readonly GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegate ComputeMipChainSize_Native_2DDelegateField;
  private static readonly GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegate ComputeMipChainSize_Native_3DDelegateField;
  private static readonly GraphicsFormatUtility.GetFormatString_InjectedDelegate GetFormatString_InjectedDelegateField;
  private static readonly GraphicsFormatUtility.GetFormatString_Native_TextureFormat_InjectedDelegate GetFormatString_Native_TextureFormat_InjectedDelegateField;

  static GraphicsFormatUtility()
  {
    Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", nameof (GraphicsFormatUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr);
    GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, nameof (tableNoStencil));
    GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, nameof (tableStencil));
    GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670750);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670751);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670752);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670753);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670754);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670755);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670756);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670757);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670758);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670759);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670760);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670761);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670762);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670763);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670764);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670765);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670766);
    GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670767);
    GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670768);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670769);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670770);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsStencilFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670771);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670772);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670773);
    GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670774);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670775);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670776);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670777);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670778);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670779);
    GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFormatUtility>.NativeClassPtr, 100670781);
    GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetTextureFormat_Native_GraphicsFormat");
    GraphicsFormatUtility.IsSwizzleFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSwizzleFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSwizzleFormat");
    GraphicsFormatUtility.GetColorComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetColorComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetColorComponentCount");
    GraphicsFormatUtility.GetAlphaComponentCountDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetAlphaComponentCountDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetAlphaComponentCount");
    GraphicsFormatUtility.IsCompressedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsCompressedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsCompressedFormat");
    GraphicsFormatUtility.IsPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsPackedFormat");
    GraphicsFormatUtility.Is16BitPackedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.Is16BitPackedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::Is16BitPackedFormat");
    GraphicsFormatUtility.ConvertToAlphaFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat");
    GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ConvertToAlphaFormat_Native_TextureFormat");
    GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaOnlyFormat_Native_TextureFormat");
    GraphicsFormatUtility.IsAlphaTestFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsAlphaTestFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsAlphaTestFormat");
    GraphicsFormatUtility.HasAlphaChannelDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannelDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel");
    GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::HasAlphaChannel_Native_TextureFormat");
    GraphicsFormatUtility.IsIEEE754FormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIEEE754FormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIEEE754Format");
    GraphicsFormatUtility.IsFloatFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsFloatFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsFloatFormat");
    GraphicsFormatUtility.IsHalfFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHalfFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHalfFormat");
    GraphicsFormatUtility.IsUnsignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUnsignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUnsignedFormat");
    GraphicsFormatUtility.IsSignedFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSignedFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSignedFormat");
    GraphicsFormatUtility.IsNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsNormFormat");
    GraphicsFormatUtility.IsUNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUNormFormat");
    GraphicsFormatUtility.IsSNormFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSNormFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSNormFormat");
    GraphicsFormatUtility.IsIntegerFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsIntegerFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsIntegerFormat");
    GraphicsFormatUtility.IsUIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsUIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsUIntFormat");
    GraphicsFormatUtility.IsSIntFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsSIntFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsSIntFormat");
    GraphicsFormatUtility.IsXRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsXRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsXRFormat");
    GraphicsFormatUtility.IsDXTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsDXTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsDXTCFormat");
    GraphicsFormatUtility.IsRGTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsRGTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsRGTCFormat");
    GraphicsFormatUtility.IsBPTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBPTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBPTCFormat");
    GraphicsFormatUtility.IsBCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsBCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsBCFormat");
    GraphicsFormatUtility.IsETCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsETCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsETCFormat");
    GraphicsFormatUtility.IsEACFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsEACFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsEACFormat");
    GraphicsFormatUtility.IsASTCFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsASTCFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsASTCFormat");
    GraphicsFormatUtility.IsHDRFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHDRFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat");
    GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::IsHDRFormat_Native_TextureFormat");
    GraphicsFormatUtility.GetBlockWidthDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockWidthDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockWidth");
    GraphicsFormatUtility.GetBlockHeightDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetBlockHeightDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetBlockHeight");
    GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_2D");
    GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::ComputeMipChainSize_Native_3D");
    GraphicsFormatUtility.GetFormatString_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatString_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString_Injected");
    GraphicsFormatUtility.GetFormatString_Native_TextureFormat_InjectedDelegateField = IL2CPP.ResolveICall<GraphicsFormatUtility.GetFormatString_Native_TextureFormat_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsFormatUtility::GetFormatString_Native_TextureFormat_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489705, RefRangeEnd = 489706, XrefRangeStart = 489693, XrefRangeEnd = 489705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetFormat(Texture texture)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Internal_Static_GraphicsFormat_Texture_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 489711, RefRangeEnd = 489720, XrefRangeStart = 489706, XrefRangeEnd = 489711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSRGB;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_TextureFormat_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489720, XrefRangeEnd = 489722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetGraphicsFormat_Native_TextureFormat(
    TextureFormat format,
    bool isSRGB)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSRGB;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_TextureFormat_Private_Static_GraphicsFormat_TextureFormat_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489727, RefRangeEnd = 489729, XrefRangeStart = 489722, XrefRangeEnd = 489727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSRGB;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489729, XrefRangeEnd = 489731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(
    RenderTextureFormat format,
    bool isSRGB)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isSRGB;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Native_RenderTextureFormat_Private_Static_GraphicsFormat_RenderTextureFormat_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 489741, RefRangeEnd = 489748, XrefRangeStart = 489731, XrefRangeEnd = 489741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetGraphicsFormat(
    RenderTextureFormat format,
    RenderTextureReadWrite readWrite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &readWrite;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_RenderTextureFormat_RenderTextureReadWrite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489748, XrefRangeEnd = 489750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(
    int minimumDepthBits)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &minimumDepthBits
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormatFromBitsLegacy_Native_Private_Static_GraphicsFormat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 489755, RefRangeEnd = 489765, XrefRangeStart = 489750, XrefRangeEnd = 489755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetDepthStencilFormat(int depthBits)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &depthBits
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 489767, RefRangeEnd = 489771, XrefRangeStart = 489765, XrefRangeEnd = 489767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetDepthBits(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthBits_Public_Static_Int32_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489790, RefRangeEnd = 489792, XrefRangeStart = 489771, XrefRangeEnd = 489790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetDepthStencilFormat(
    int minimumDepthBits,
    int minimumStencilBits)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &minimumDepthBits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minimumStencilBits;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetDepthStencilFormat_Public_Static_GraphicsFormat_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 489794, RefRangeEnd = 489811, XrefRangeStart = 489792, XrefRangeEnd = 489794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsSRGBFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsSRGBFormat_Public_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489813, RefRangeEnd = 489814, XrefRangeStart = 489811, XrefRangeEnd = 489813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetSRGBFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSRGBFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489816, RefRangeEnd = 489817, XrefRangeStart = 489814, XrefRangeEnd = 489816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetLinearFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetLinearFormat_Public_Static_GraphicsFormat_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489819, RefRangeEnd = 489820, XrefRangeStart = 489817, XrefRangeEnd = 489819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetRenderTextureFormat_Public_Static_RenderTextureFormat_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderTextureFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 489822, RefRangeEnd = 489827, XrefRangeStart = 489820, XrefRangeEnd = 489822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetComponentCount(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetComponentCount_Public_Static_UInt32_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489827, XrefRangeEnd = 489829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCompressedFormat_Native_TextureFormat(TextureFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Native_TextureFormat_Private_Static_Boolean_TextureFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489834, RefRangeEnd = 489835, XrefRangeStart = 489829, XrefRangeEnd = 489834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCompressedFormat(TextureFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCompressedFormat_Public_Static_Boolean_TextureFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489835, XrefRangeEnd = 489837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanDecompressFormat(GraphicsFormat format, bool wholeImage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &wholeImage;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Private_Static_Boolean_GraphicsFormat_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489842, RefRangeEnd = 489843, XrefRangeStart = 489837, XrefRangeEnd = 489842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanDecompressFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_CanDecompressFormat_Internal_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489845, RefRangeEnd = 489847, XrefRangeStart = 489843, XrefRangeEnd = 489845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsAlphaOnlyFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsAlphaOnlyFormat_Public_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489849, RefRangeEnd = 489851, XrefRangeStart = 489847, XrefRangeEnd = 489849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDepthFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthFormat_Public_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489867, RefRangeEnd = 489869, XrefRangeStart = 489851, XrefRangeEnd = 489867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsStencilFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsStencilFormat_Public_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 489871, RefRangeEnd = 489877, XrefRangeStart = 489869, XrefRangeEnd = 489871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDepthStencilFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsDepthStencilFormat_Public_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 489879, RefRangeEnd = 489885, XrefRangeStart = 489877, XrefRangeEnd = 489879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsPVRTCFormat(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsPVRTCFormat_Public_Static_Boolean_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 489887, RefRangeEnd = 489896, XrefRangeStart = 489885, XrefRangeEnd = 489887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsCrunchFormat(TextureFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_IsCrunchFormat_Public_Static_Boolean_TextureFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 489898, RefRangeEnd = 489902, XrefRangeStart = 489896, XrefRangeEnd = 489898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FormatSwizzle GetSwizzleR(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleR_Public_Static_FormatSwizzle_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FormatSwizzle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489904, RefRangeEnd = 489906, XrefRangeStart = 489902, XrefRangeEnd = 489904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FormatSwizzle GetSwizzleG(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleG_Public_Static_FormatSwizzle_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FormatSwizzle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489908, RefRangeEnd = 489910, XrefRangeStart = 489906, XrefRangeEnd = 489908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FormatSwizzle GetSwizzleB(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleB_Public_Static_FormatSwizzle_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FormatSwizzle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489912, RefRangeEnd = 489914, XrefRangeStart = 489910, XrefRangeEnd = 489912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FormatSwizzle GetSwizzleA(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetSwizzleA_Public_Static_FormatSwizzle_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FormatSwizzle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489916, RefRangeEnd = 489918, XrefRangeStart = 489914, XrefRangeEnd = 489916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetBlockSize(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetBlockSize_Public_Static_UInt32_GraphicsFormat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489918, XrefRangeEnd = 489920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GraphicsFormat GetFormat_Injected(System.IntPtr texture)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &texture
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFormatUtility.NativeMethodInfoPtr_GetFormat_Injected_Private_Static_GraphicsFormat_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GraphicsFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Il2CppStructArray<GraphicsFormat> tableNoStencil
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<GraphicsFormat>) null : Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableNoStencil, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<GraphicsFormat> tableStencil
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<GraphicsFormat>) null : Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GraphicsFormatUtility.NativeFieldInfoPtr_tableStencil, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static TextureFormat GetTextureFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormat(format);
  }

  public static TextureFormat GetTextureFormat_Native_GraphicsFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.GetTextureFormat_Native_GraphicsFormatDelegateField(format);
  }

  public static bool IsSwizzleFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsSwizzleFormatDelegateField(format);
  }

  public static bool IsSwizzleFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsSwizzleFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint GetColorComponentCount(GraphicsFormat format)
  {
    return GraphicsFormatUtility.GetColorComponentCountDelegateField(format);
  }

  public static uint GetColorComponentCount(TextureFormat format)
  {
    return GraphicsFormatUtility.GetColorComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint GetAlphaComponentCount(GraphicsFormat format)
  {
    return GraphicsFormatUtility.GetAlphaComponentCountDelegateField(format);
  }

  public static uint GetAlphaComponentCount(TextureFormat format)
  {
    return GraphicsFormatUtility.GetAlphaComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint GetComponentCount(TextureFormat format)
  {
    return GraphicsFormatUtility.GetComponentCount(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static string GetFormatString(GraphicsFormat format)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      GraphicsFormatUtility.GetFormatString_Injected(format, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static string GetFormatString_Native_TextureFormat(TextureFormat format)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      GraphicsFormatUtility.GetFormatString_Native_TextureFormat_Injected(format, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static string GetFormatString(TextureFormat format)
  {
    return GraphicsFormatUtility.GetFormatString_Native_TextureFormat(format);
  }

  public static bool IsCompressedFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsCompressedFormatDelegateField(format);
  }

  public static bool IsCompressedTextureFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsCompressedFormat(format);
  }

  public static bool IsPackedFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsPackedFormatDelegateField(format);
  }

  public static bool IsPackedFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsPackedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool Is16BitPackedFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.Is16BitPackedFormatDelegateField(format);
  }

  public static bool Is16BitPackedFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.Is16BitPackedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static GraphicsFormat ConvertToAlphaFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.ConvertToAlphaFormatDelegateField(format);
  }

  public static TextureFormat ConvertToAlphaFormat_Native_TextureFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormatDelegateField(format);
  }

  public static TextureFormat ConvertToAlphaFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.ConvertToAlphaFormat_Native_TextureFormat(format);
  }

  public static bool IsAlphaOnlyFormat_Native_TextureFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormatDelegateField(format);
  }

  public static bool IsAlphaOnlyFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsAlphaOnlyFormat_Native_TextureFormat(format);
  }

  public static bool IsAlphaTestFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsAlphaTestFormatDelegateField(format);
  }

  public static bool IsAlphaTestFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsAlphaTestFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool HasAlphaChannel(GraphicsFormat format)
  {
    return GraphicsFormatUtility.HasAlphaChannelDelegateField(format);
  }

  public static bool HasAlphaChannel_Native_TextureFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormatDelegateField(format);
  }

  public static bool HasAlphaChannel(TextureFormat format)
  {
    return GraphicsFormatUtility.HasAlphaChannel_Native_TextureFormat(format);
  }

  public static bool IsIEEE754Format(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsIEEE754FormatDelegateField(format);
  }

  public static bool IsFloatFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsFloatFormatDelegateField(format);
  }

  public static bool IsHalfFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsHalfFormatDelegateField(format);
  }

  public static bool IsUnsignedFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsUnsignedFormatDelegateField(format);
  }

  public static bool IsUnsignedFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsUnsignedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsSignedFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsSignedFormatDelegateField(format);
  }

  public static bool IsSignedFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsSignedFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsNormFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsNormFormatDelegateField(format);
  }

  public static bool IsUNormFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsUNormFormatDelegateField(format);
  }

  public static bool IsSNormFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsSNormFormatDelegateField(format);
  }

  public static bool IsIntegerFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsIntegerFormatDelegateField(format);
  }

  public static bool IsUIntFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsUIntFormatDelegateField(format);
  }

  public static bool IsSIntFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsSIntFormatDelegateField(format);
  }

  public static bool IsXRFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsXRFormatDelegateField(format);
  }

  public static bool IsDXTCFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsDXTCFormatDelegateField(format);
  }

  public static bool IsDXTCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsDXTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsRGTCFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsRGTCFormatDelegateField(format);
  }

  public static bool IsRGTCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsRGTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsBPTCFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsBPTCFormatDelegateField(format);
  }

  public static bool IsBPTCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsBPTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsBCFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsBCFormatDelegateField(format);
  }

  public static bool IsBCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsBCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsPVRTCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsPVRTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsETCFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsETCFormatDelegateField(format);
  }

  public static bool IsETCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsETCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsEACFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsEACFormatDelegateField(format);
  }

  public static bool IsEACFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsEACFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsASTCFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsASTCFormatDelegateField(format);
  }

  public static bool IsASTCFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsASTCFormat(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static bool IsHDRFormat(GraphicsFormat format)
  {
    return GraphicsFormatUtility.IsHDRFormatDelegateField(format);
  }

  public static bool IsHDRFormat_Native_TextureFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsHDRFormat_Native_TextureFormatDelegateField(format);
  }

  public static bool IsHDRFormat(TextureFormat format)
  {
    return GraphicsFormatUtility.IsHDRFormat_Native_TextureFormat(format);
  }

  public static FormatSwizzle GetSwizzleR(TextureFormat format)
  {
    return GraphicsFormatUtility.GetSwizzleR(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static FormatSwizzle GetSwizzleG(TextureFormat format)
  {
    return GraphicsFormatUtility.GetSwizzleG(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static FormatSwizzle GetSwizzleB(TextureFormat format)
  {
    return GraphicsFormatUtility.GetSwizzleB(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static FormatSwizzle GetSwizzleA(TextureFormat format)
  {
    return GraphicsFormatUtility.GetSwizzleA(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint GetBlockSize(TextureFormat format)
  {
    return GraphicsFormatUtility.GetBlockSize(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint GetBlockWidth(GraphicsFormat format)
  {
    return GraphicsFormatUtility.GetBlockWidthDelegateField(format);
  }

  public static uint GetBlockWidth(TextureFormat format)
  {
    return GraphicsFormatUtility.GetBlockWidth(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint GetBlockHeight(GraphicsFormat format)
  {
    return GraphicsFormatUtility.GetBlockHeightDelegateField(format);
  }

  public static uint GetBlockHeight(TextureFormat format)
  {
    return GraphicsFormatUtility.GetBlockHeight(GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint ComputeMipmapSize(int width, int height, GraphicsFormat format)
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, format, 1);
  }

  public static uint ComputeMipmapSize(int width, int height, TextureFormat format)
  {
    return GraphicsFormatUtility.ComputeMipmapSize(width, height, GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint ComputeMipChainSize_Native_2D(
    int width,
    int height,
    GraphicsFormat format,
    int mipCount)
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_2DDelegateField(width, height, format, mipCount);
  }

  public static uint ComputeMipChainSize(
    int width,
    int height,
    GraphicsFormat format,
    int mipCount = default (int))
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, format, mipCount);
  }

  public static uint ComputeMipChainSize(
    int width,
    int height,
    TextureFormat format,
    int mipCount = default (int))
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_2D(width, height, GraphicsFormatUtility.GetGraphicsFormat(format, false), mipCount);
  }

  public static uint ComputeMipmapSize(int width, int height, int depth, GraphicsFormat format)
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, format, 1);
  }

  public static uint ComputeMipmapSize(int width, int height, int depth, TextureFormat format)
  {
    return GraphicsFormatUtility.ComputeMipmapSize(width, height, depth, GraphicsFormatUtility.GetGraphicsFormat(format, false));
  }

  public static uint ComputeMipChainSize_Native_3D(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    int mipCount)
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_3DDelegateField(width, height, depth, format, mipCount);
  }

  public static uint ComputeMipChainSize(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    int mipCount = default (int))
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, format, mipCount);
  }

  public static uint ComputeMipChainSize(
    int width,
    int height,
    int depth,
    TextureFormat format,
    int mipCount = default (int))
  {
    return GraphicsFormatUtility.ComputeMipChainSize_Native_3D(width, height, depth, GraphicsFormatUtility.GetGraphicsFormat(format, false), mipCount);
  }

  public static void GetFormatString_Injected(GraphicsFormat format, out ManagedSpanWrapper ret)
  {
    GraphicsFormatUtility.GetFormatString_InjectedDelegateField(format, (System.IntPtr) ref ret);
  }

  public static void GetFormatString_Native_TextureFormat_Injected(
    TextureFormat format,
    out ManagedSpanWrapper ret)
  {
    GraphicsFormatUtility.GetFormatString_Native_TextureFormat_InjectedDelegateField(format, (System.IntPtr) ref ret);
  }

  private delegate TextureFormat GetTextureFormat_Native_GraphicsFormatDelegate(
    GraphicsFormat format);

  private delegate bool IsSwizzleFormatDelegate(GraphicsFormat format);

  private delegate uint GetColorComponentCountDelegate(GraphicsFormat format);

  private delegate uint GetAlphaComponentCountDelegate(GraphicsFormat format);

  private delegate bool IsCompressedFormatDelegate(GraphicsFormat format);

  private delegate bool IsPackedFormatDelegate(GraphicsFormat format);

  private delegate bool Is16BitPackedFormatDelegate(GraphicsFormat format);

  private delegate GraphicsFormat ConvertToAlphaFormatDelegate(GraphicsFormat format);

  private delegate TextureFormat ConvertToAlphaFormat_Native_TextureFormatDelegate(
    TextureFormat format);

  private delegate bool IsAlphaOnlyFormat_Native_TextureFormatDelegate(TextureFormat format);

  private delegate bool IsAlphaTestFormatDelegate(GraphicsFormat format);

  private delegate bool HasAlphaChannelDelegate(GraphicsFormat format);

  private delegate bool HasAlphaChannel_Native_TextureFormatDelegate(TextureFormat format);

  private delegate bool IsIEEE754FormatDelegate(GraphicsFormat format);

  private delegate bool IsFloatFormatDelegate(GraphicsFormat format);

  private delegate bool IsHalfFormatDelegate(GraphicsFormat format);

  private delegate bool IsUnsignedFormatDelegate(GraphicsFormat format);

  private delegate bool IsSignedFormatDelegate(GraphicsFormat format);

  private delegate bool IsNormFormatDelegate(GraphicsFormat format);

  private delegate bool IsUNormFormatDelegate(GraphicsFormat format);

  private delegate bool IsSNormFormatDelegate(GraphicsFormat format);

  private delegate bool IsIntegerFormatDelegate(GraphicsFormat format);

  private delegate bool IsUIntFormatDelegate(GraphicsFormat format);

  private delegate bool IsSIntFormatDelegate(GraphicsFormat format);

  private delegate bool IsXRFormatDelegate(GraphicsFormat format);

  private delegate bool IsDXTCFormatDelegate(GraphicsFormat format);

  private delegate bool IsRGTCFormatDelegate(GraphicsFormat format);

  private delegate bool IsBPTCFormatDelegate(GraphicsFormat format);

  private delegate bool IsBCFormatDelegate(GraphicsFormat format);

  private delegate bool IsETCFormatDelegate(GraphicsFormat format);

  private delegate bool IsEACFormatDelegate(GraphicsFormat format);

  private delegate bool IsASTCFormatDelegate(GraphicsFormat format);

  private delegate bool IsHDRFormatDelegate(GraphicsFormat format);

  private delegate bool IsHDRFormat_Native_TextureFormatDelegate(TextureFormat format);

  private delegate uint GetBlockWidthDelegate(GraphicsFormat format);

  private delegate uint GetBlockHeightDelegate(GraphicsFormat format);

  private delegate uint ComputeMipChainSize_Native_2DDelegate(
    int width,
    int height,
    GraphicsFormat format,
    int mipCount);

  private delegate uint ComputeMipChainSize_Native_3DDelegate(
    int width,
    int height,
    int depth,
    GraphicsFormat format,
    int mipCount);

  private delegate void GetFormatString_InjectedDelegate(GraphicsFormat format, [Out] System.IntPtr ret);

  private delegate void GetFormatString_Native_TextureFormat_InjectedDelegate(
    TextureFormat format,
    [Out] System.IntPtr ret);
}
