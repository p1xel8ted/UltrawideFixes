// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LightingStage
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

public sealed class LightingStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kShadowReceiverNdc2Uv;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDfgLut;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightingSystemCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__mainLightShadowReceiverCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__punctualLightShadowReceiverCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__ambientCubeCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__errors;
  private static readonly System.IntPtr NativeFieldInfoPtr__lightingData;
  private static readonly System.IntPtr NativeFieldInfoPtr__shadowCullingDataBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr__texDfgLut;
  private static readonly System.IntPtr NativeFieldInfoPtr__shadowCastingPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__presentSmcPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__clusteredInputList;
  private static readonly System.IntPtr NativeFieldInfoPtr__cllData;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupReceiverCullingSphere_Public_Static_Void_byref_ShadowSplitData_byref_Vector4_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupLightingData_Private_Static_Void_LightingData_ClusteredInputLightList_byref_FrameRenderingParams_ShadowCullingDataBuilder_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SkipLight_Private_Static_Boolean_LightExtraData_LightingData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture2D_Shader_Texture2DArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Errors_Public_get_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginFrame_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_Vector3Int_SceneFrame_byref_ClusteredInputLightList_byref_ClusteredLightListData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_LightingStageFrameStats_byref_ScriptableRenderContext_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_LightingStageFrameStats_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodePresentShadowMapCascades_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupAmbientCubeCBuffer_Private_Void_CommandBuffer_byref_AmbientCubeParams_0;

  static LightingStage()
  {
    Il2CppClassPointerStore<LightingStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LightingStage));
    LightingStage.NativeFieldInfoPtr_kShadowReceiverNdc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (kShadowReceiverNdc2Uv));
    LightingStage.NativeFieldInfoPtr_kSidTexDfgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (kSidTexDfgLut));
    LightingStage.NativeFieldInfoPtr__lightingSystemCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_lightingSystemCBuffer));
    LightingStage.NativeFieldInfoPtr__mainLightShadowReceiverCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_mainLightShadowReceiverCBuffer));
    LightingStage.NativeFieldInfoPtr__punctualLightShadowReceiverCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_punctualLightShadowReceiverCBuffer));
    LightingStage.NativeFieldInfoPtr__ambientCubeCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_ambientCubeCBuffer));
    LightingStage.NativeFieldInfoPtr__errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_errors));
    LightingStage.NativeFieldInfoPtr__lightingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_lightingData));
    LightingStage.NativeFieldInfoPtr__shadowCullingDataBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_shadowCullingDataBuilder));
    LightingStage.NativeFieldInfoPtr__texDfgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_texDfgLut));
    LightingStage.NativeFieldInfoPtr__shadowCastingPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_shadowCastingPass));
    LightingStage.NativeFieldInfoPtr__presentSmcPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_presentSmcPass));
    LightingStage.NativeFieldInfoPtr__clusteredInputList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_clusteredInputList));
    LightingStage.NativeFieldInfoPtr__cllData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (_cllData));
    LightingStage.NativeMethodInfoPtr_SetupReceiverCullingSphere_Public_Static_Void_byref_ShadowSplitData_byref_Vector4_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663977);
    LightingStage.NativeMethodInfoPtr_SetupLightingData_Private_Static_Void_LightingData_ClusteredInputLightList_byref_FrameRenderingParams_ShadowCullingDataBuilder_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663978);
    LightingStage.NativeMethodInfoPtr_SkipLight_Private_Static_Boolean_LightExtraData_LightingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663979);
    LightingStage.NativeMethodInfoPtr__ctor_Public_Void_Texture2D_Shader_Texture2DArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663980);
    LightingStage.NativeMethodInfoPtr_get_Errors_Public_get_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663981);
    LightingStage.NativeMethodInfoPtr_BeginFrame_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_Vector3Int_SceneFrame_byref_ClusteredInputLightList_byref_ClusteredLightListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663982);
    LightingStage.NativeMethodInfoPtr_Encode_Public_LightingStageFrameStats_byref_ScriptableRenderContext_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663983);
    LightingStage.NativeMethodInfoPtr_Encode_Public_LightingStageFrameStats_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663984 /*0x060002B0*/);
    LightingStage.NativeMethodInfoPtr_EncodePresentShadowMapCascades_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663985);
    LightingStage.NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663986);
    LightingStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663987);
    LightingStage.NativeMethodInfoPtr_SetupAmbientCubeCBuffer_Private_Void_CommandBuffer_byref_AmbientCubeParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, 100663988);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 931271, RefRangeEnd = 931275, XrefRangeStart = 931265, XrefRangeEnd = 931271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetupReceiverCullingSphere(
    [In] ref ShadowSplitData splitData,
    out Vector4 cullingSphere,
    out float cullingSphereRadius2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref splitData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingSphere;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingSphereRadius2;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_SetupReceiverCullingSphere_Public_Static_Void_byref_ShadowSplitData_byref_Vector4_byref_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931301, RefRangeEnd = 931302, XrefRangeStart = 931275, XrefRangeEnd = 931301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetupLightingData(
    LightingData lightingData,
    ClusteredInputLightList clusteredInputLightList,
    [In] ref FrameRenderingParams frp,
    ShadowCullingDataBuilder shadowCullingDataBuilder,
    LightingStageErrors errors)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightingData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clusteredInputLightList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) errors);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_SetupLightingData_Private_Static_Void_LightingData_ClusteredInputLightList_byref_FrameRenderingParams_ShadowCullingDataBuilder_LightingStageErrors_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931302, XrefRangeEnd = 931306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SkipLight(LightExtraData led, LightingData lightingData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lightingData);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_SkipLight_Private_Static_Boolean_LightExtraData_LightingData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931418, RefRangeEnd = 931419, XrefRangeStart = 931306, XrefRangeEnd = 931418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightingStage(
    Texture2D texDfgLut,
    Shader presentShadowMapCascadesShader,
    Texture2DArray texWhiteTexture2DArray)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texDfgLut);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentShadowMapCascadesShader);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texWhiteTexture2DArray);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr__ctor_Public_Void_Texture2D_Shader_Texture2DArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LightingStageErrors Errors
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_get_Errors_Public_get_LightingStageErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (LightingStageErrors) null : Il2CppObjectPool.Get<LightingStageErrors>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931496, RefRangeEnd = 931497, XrefRangeStart = 931419, XrefRangeEnd = 931496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginFrame(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp,
    Vector3Int clusteredGridSize3D,
    SceneFrame frame,
    out ClusteredInputLightList clusteredInputList,
    out ClusteredLightListData cllData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &clusteredGridSize3D;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_BeginFrame_Public_Void_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_Vector3Int_SceneFrame_byref_ClusteredInputLightList_byref_ClusteredLightListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref ClusteredInputLightList local1 = ref clusteredInputList;
    System.IntPtr pointer1 = zero1;
    ClusteredInputLightList clusteredInputLightList = pointer1 == System.IntPtr.Zero ? (ClusteredInputLightList) null : new ClusteredInputLightList(pointer1);
    local1 = clusteredInputLightList;
    ref ClusteredLightListData local2 = ref cllData;
    System.IntPtr pointer2 = zero2;
    ClusteredLightListData clusteredLightListData = pointer2 == System.IntPtr.Zero ? (ClusteredLightListData) null : new ClusteredLightListData(pointer2);
    local2 = clusteredLightListData;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931497, XrefRangeEnd = 931506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightingStageFrameStats Encode(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_Encode_Public_LightingStageFrameStats_byref_ScriptableRenderContext_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new LightingStageFrameStats(pointer);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 931531, RefRangeEnd = 931534, XrefRangeStart = 931506, XrefRangeEnd = 931531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightingStageFrameStats Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_Encode_Public_LightingStageFrameStats_byref_ScriptableRenderContext_CommandBuffer_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new LightingStageFrameStats(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931534, XrefRangeEnd = 931535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodePresentShadowMapCascades(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_EncodePresentShadowMapCascades_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931541, RefRangeEnd = 931542, XrefRangeStart = 931535, XrefRangeEnd = 931541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931580, RefRangeEnd = 931581, XrefRangeStart = 931542, XrefRangeEnd = 931580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931585, RefRangeEnd = 931586, XrefRangeStart = 931581, XrefRangeEnd = 931585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupAmbientCubeCBuffer(CommandBuffer cmd, [In] ref AmbientCubeParams ac)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ac;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingStage.NativeMethodInfoPtr_SetupAmbientCubeCBuffer_Private_Void_CommandBuffer_byref_AmbientCubeParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Matrix4x4 kShadowReceiverNdc2Uv
  {
    get
    {
      Matrix4x4 shadowReceiverNdc2Uv;
      IL2CPP.il2cpp_field_static_get_value(LightingStage.NativeFieldInfoPtr_kShadowReceiverNdc2Uv, (void*) &shadowReceiverNdc2Uv);
      return shadowReceiverNdc2Uv;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingStage.NativeFieldInfoPtr_kShadowReceiverNdc2Uv, (void*) &value);
    }
  }

  public static unsafe int kSidTexDfgLut
  {
    get
    {
      int kSidTexDfgLut;
      IL2CPP.il2cpp_field_static_get_value(LightingStage.NativeFieldInfoPtr_kSidTexDfgLut, (void*) &kSidTexDfgLut);
      return kSidTexDfgLut;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingStage.NativeFieldInfoPtr_kSidTexDfgLut, (void*) &value);
    }
  }

  public unsafe CBuffer<LightingStage.LightingSystemCBufferData> _lightingSystemCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__lightingSystemCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<LightingStage.LightingSystemCBufferData>) null : Il2CppObjectPool.Get<CBuffer<LightingStage.LightingSystemCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__lightingSystemCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<LightingStage.MainLightShadowDataCBuffer> _mainLightShadowReceiverCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__mainLightShadowReceiverCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<LightingStage.MainLightShadowDataCBuffer>) null : Il2CppObjectPool.Get<CBuffer<LightingStage.MainLightShadowDataCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__mainLightShadowReceiverCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<LightingStage.PunctualLightShadowReceiverCBuffer> _punctualLightShadowReceiverCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__punctualLightShadowReceiverCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<LightingStage.PunctualLightShadowReceiverCBuffer>) null : Il2CppObjectPool.Get<CBuffer<LightingStage.PunctualLightShadowReceiverCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__punctualLightShadowReceiverCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<LightingStage.AmbientCubeCBufferData> _ambientCubeCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__ambientCubeCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<LightingStage.AmbientCubeCBufferData>) null : Il2CppObjectPool.Get<CBuffer<LightingStage.AmbientCubeCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__ambientCubeCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LightingStageErrors _errors
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__errors));
      return num == System.IntPtr.Zero ? (LightingStageErrors) null : Il2CppObjectPool.Get<LightingStageErrors>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__errors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LightingData _lightingData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__lightingData));
      return num == System.IntPtr.Zero ? (LightingData) null : Il2CppObjectPool.Get<LightingData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__lightingData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ShadowCullingDataBuilder _shadowCullingDataBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__shadowCullingDataBuilder));
      return num == System.IntPtr.Zero ? (ShadowCullingDataBuilder) null : Il2CppObjectPool.Get<ShadowCullingDataBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__shadowCullingDataBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D _texDfgLut
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__texDfgLut));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__texDfgLut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ShadowCastingPass _shadowCastingPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__shadowCastingPass));
      return num == System.IntPtr.Zero ? (ShadowCastingPass) null : Il2CppObjectPool.Get<ShadowCastingPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__shadowCastingPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PresentShadowMapCascadesPass _presentSmcPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__presentSmcPass));
      return num == System.IntPtr.Zero ? (PresentShadowMapCascadesPass) null : Il2CppObjectPool.Get<PresentShadowMapCascadesPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__presentSmcPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClusteredInputLightList _clusteredInputList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__clusteredInputList));
      return num == System.IntPtr.Zero ? (ClusteredInputLightList) null : Il2CppObjectPool.Get<ClusteredInputLightList>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__clusteredInputList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClusteredLightListData _cllData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__cllData));
      return num == System.IntPtr.Zero ? (ClusteredLightListData) null : Il2CppObjectPool.Get<ClusteredLightListData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingStage.NativeFieldInfoPtr__cllData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct LightingSystemCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_directionalLightCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_punctualLightCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_lineLightCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_cloudDirectionalLightCount;
    [FieldOffset(0)]
    public uint directionalLightCount;
    [FieldOffset(4)]
    public uint punctualLightCount;
    [FieldOffset(8)]
    public uint lineLightCount;
    [FieldOffset(12)]
    public uint cloudDirectionalLightCount;

    static LightingSystemCBufferData()
    {
      Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (LightingSystemCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr);
      LightingStage.LightingSystemCBufferData.NativeFieldInfoPtr_directionalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr, nameof (directionalLightCount));
      LightingStage.LightingSystemCBufferData.NativeFieldInfoPtr_punctualLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr, nameof (punctualLightCount));
      LightingStage.LightingSystemCBufferData.NativeFieldInfoPtr_lineLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr, nameof (lineLightCount));
      LightingStage.LightingSystemCBufferData.NativeFieldInfoPtr_cloudDirectionalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr, nameof (cloudDirectionalLightCount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightingStage.LightingSystemCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct MainLightShadowDataCBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewCascade0;
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewCascade1;
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewCascade2;
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewCascade3;
    private static readonly System.IntPtr NativeFieldInfoPtr_cullingSphereCascade0;
    private static readonly System.IntPtr NativeFieldInfoPtr_cullingSphereCascade1;
    private static readonly System.IntPtr NativeFieldInfoPtr_cullingSphereCascade2;
    private static readonly System.IntPtr NativeFieldInfoPtr_cullingSphereCascade3;
    private static readonly System.IntPtr NativeFieldInfoPtr_cullingSphereRadii2;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset0;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset1;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric0;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric1;
    private static readonly System.IntPtr NativeFieldInfoPtr_shadowTint;
    [FieldOffset(0)]
    public Matrix4x4 projectionViewCascade0;
    [FieldOffset(64 /*0x40*/)]
    public Matrix4x4 projectionViewCascade1;
    [FieldOffset(128 /*0x80*/)]
    public Matrix4x4 projectionViewCascade2;
    [FieldOffset(192 /*0xC0*/)]
    public Matrix4x4 projectionViewCascade3;
    [FieldOffset(256 /*0x0100*/)]
    public Vector4 cullingSphereCascade0;
    [FieldOffset(272)]
    public Vector4 cullingSphereCascade1;
    [FieldOffset(288)]
    public Vector4 cullingSphereCascade2;
    [FieldOffset(304)]
    public Vector4 cullingSphereCascade3;
    [FieldOffset(320)]
    public Vector4 cullingSphereRadii2;
    [FieldOffset(336)]
    public Vector4 uvOffset0;
    [FieldOffset(352)]
    public Vector4 uvOffset1;
    [FieldOffset(368)]
    public Vector4 uvOffsetVolumetric0;
    [FieldOffset(384)]
    public Vector4 uvOffsetVolumetric1;
    [FieldOffset(400)]
    public Vector4 shadowTint;

    static MainLightShadowDataCBuffer()
    {
      Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (MainLightShadowDataCBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr);
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_projectionViewCascade0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (projectionViewCascade0));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_projectionViewCascade1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (projectionViewCascade1));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_projectionViewCascade2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (projectionViewCascade2));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_projectionViewCascade3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (projectionViewCascade3));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_cullingSphereCascade0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (cullingSphereCascade0));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_cullingSphereCascade1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (cullingSphereCascade1));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_cullingSphereCascade2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (cullingSphereCascade2));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_cullingSphereCascade3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (cullingSphereCascade3));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_cullingSphereRadii2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (cullingSphereRadii2));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_uvOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (uvOffset0));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_uvOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (uvOffset1));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_uvOffsetVolumetric0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (uvOffsetVolumetric0));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_uvOffsetVolumetric1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (uvOffsetVolumetric1));
      LightingStage.MainLightShadowDataCBuffer.NativeFieldInfoPtr_shadowTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, nameof (shadowTint));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightingStage.MainLightShadowDataCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PunctualLightShadowReceiverCBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset0;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffset1;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric0;
    private static readonly System.IntPtr NativeFieldInfoPtr_uvOffsetVolumetric1;
    [FieldOffset(0)]
    public Vector4 uvOffset0;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 uvOffset1;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 uvOffsetVolumetric0;
    [FieldOffset(48 /*0x30*/)]
    public Vector4 uvOffsetVolumetric1;

    static PunctualLightShadowReceiverCBuffer()
    {
      Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (PunctualLightShadowReceiverCBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr);
      LightingStage.PunctualLightShadowReceiverCBuffer.NativeFieldInfoPtr_uvOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr, nameof (uvOffset0));
      LightingStage.PunctualLightShadowReceiverCBuffer.NativeFieldInfoPtr_uvOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr, nameof (uvOffset1));
      LightingStage.PunctualLightShadowReceiverCBuffer.NativeFieldInfoPtr_uvOffsetVolumetric0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr, nameof (uvOffsetVolumetric0));
      LightingStage.PunctualLightShadowReceiverCBuffer.NativeFieldInfoPtr_uvOffsetVolumetric1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr, nameof (uvOffsetVolumetric1));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightingStage.PunctualLightShadowReceiverCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct AmbientCubeCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_leftColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_rightColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottomColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_topColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_frontColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_backColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricLeftColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricRightColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricBottomColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricTopColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricFrontColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_volumetricBackColor;
    [FieldOffset(0)]
    public Vector4 leftColor;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 rightColor;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 bottomColor;
    [FieldOffset(48 /*0x30*/)]
    public Vector4 topColor;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 frontColor;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 backColor;
    [FieldOffset(96 /*0x60*/)]
    public Vector4 volumetricLeftColor;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 volumetricRightColor;
    [FieldOffset(128 /*0x80*/)]
    public Vector4 volumetricBottomColor;
    [FieldOffset(144 /*0x90*/)]
    public Vector4 volumetricTopColor;
    [FieldOffset(160 /*0xA0*/)]
    public Vector4 volumetricFrontColor;
    [FieldOffset(176 /*0xB0*/)]
    public Vector4 volumetricBackColor;

    static AmbientCubeCBufferData()
    {
      Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightingStage>.NativeClassPtr, nameof (AmbientCubeCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr);
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_leftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (leftColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_rightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (rightColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (bottomColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (topColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_frontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (frontColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_backColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (backColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_volumetricLeftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (volumetricLeftColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_volumetricRightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (volumetricRightColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_volumetricBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (volumetricBottomColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_volumetricTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (volumetricTopColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_volumetricFrontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (volumetricFrontColor));
      LightingStage.AmbientCubeCBufferData.NativeFieldInfoPtr_volumetricBackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, nameof (volumetricBackColor));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightingStage.AmbientCubeCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
