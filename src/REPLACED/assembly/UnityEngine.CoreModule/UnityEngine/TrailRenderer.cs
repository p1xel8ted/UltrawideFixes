// Decompiled with JetBrains decompiler
// Type: UnityEngine.TrailRenderer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class TrailRenderer(IntPtr pointer) : Renderer(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_numPositions_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startWidth_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endWidth_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_widthMultiplier_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_widthMultiplier_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autodestruct_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autodestruct_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_emitting_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_emitting_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCornerVertices_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCornerVertices_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCapVertices_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCapVertices_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_minVertexDistance_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_minVertexDistance_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_generateLightingData_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_generateLightingData_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textureMode_Public_get_LineTextureMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Public_get_LineAlignment_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_LineAlignment_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_widthCurve_Public_get_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_widthCurve_Public_set_Void_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetWidthCurveCopy_Private_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetWidthCurve_Private_Void_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetColorGradientCopy_Private_Gradient_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColorGradient_Private_Void_Gradient_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Public_Int32_Il2CppStructArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVisiblePositions_Public_Int32_Il2CppStructArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPosition_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPositions_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_NativeArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_NativeSlice_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Public_Int32_NativeArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Public_Int32_NativeSlice_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVisiblePositions_Public_Int32_NativeArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVisiblePositions_Public_Int32_NativeSlice_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPositions_Public_Void_NativeArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPositions_Public_Void_NativeSlice_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVisiblePositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_widthMultiplier_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_widthMultiplier_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autodestruct_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autodestruct_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_emitting_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_emitting_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCornerVertices_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCornerVertices_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCapVertices_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCapVertices_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_minVertexDistance_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_minVertexDistance_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_shadowBias_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_generateLightingData_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_generateLightingData_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textureMode_Injected_Private_Static_LineTextureMode_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_textureMode_Injected_Private_Static_Void_IntPtr_LineTextureMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_alignment_Injected_Private_Static_LineAlignment_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_LineAlignment_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetWidthCurveCopy_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetWidthCurve_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetColorGradientCopy_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColorGradient_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVisiblePositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVisiblePositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0;

  static TrailRenderer()
  {
    Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TrailRenderer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr);
    TrailRenderer.NativeMethodInfoPtr_get_numPositions_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664817);
    TrailRenderer.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664818);
    TrailRenderer.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664819);
    TrailRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664820);
    TrailRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664821);
    TrailRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664822);
    TrailRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664823);
    TrailRenderer.NativeMethodInfoPtr_get_widthMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664824);
    TrailRenderer.NativeMethodInfoPtr_set_widthMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664825);
    TrailRenderer.NativeMethodInfoPtr_get_autodestruct_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664826);
    TrailRenderer.NativeMethodInfoPtr_set_autodestruct_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664827);
    TrailRenderer.NativeMethodInfoPtr_get_emitting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664828);
    TrailRenderer.NativeMethodInfoPtr_set_emitting_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664829);
    TrailRenderer.NativeMethodInfoPtr_get_numCornerVertices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664830);
    TrailRenderer.NativeMethodInfoPtr_set_numCornerVertices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664831);
    TrailRenderer.NativeMethodInfoPtr_get_numCapVertices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664832 /*0x06000600*/);
    TrailRenderer.NativeMethodInfoPtr_set_numCapVertices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664833 /*0x06000601*/);
    TrailRenderer.NativeMethodInfoPtr_get_minVertexDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664834 /*0x06000602*/);
    TrailRenderer.NativeMethodInfoPtr_set_minVertexDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664835 /*0x06000603*/);
    TrailRenderer.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664836 /*0x06000604*/);
    TrailRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664837 /*0x06000605*/);
    TrailRenderer.NativeMethodInfoPtr_get_endColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664838 /*0x06000606*/);
    TrailRenderer.NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664839 /*0x06000607*/);
    TrailRenderer.NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664840 /*0x06000608*/);
    TrailRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664841 /*0x06000609*/);
    TrailRenderer.NativeMethodInfoPtr_GetPosition_Public_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664842 /*0x0600060A*/);
    TrailRenderer.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664843 /*0x0600060B*/);
    TrailRenderer.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664844 /*0x0600060C*/);
    TrailRenderer.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664845 /*0x0600060D*/);
    TrailRenderer.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664846 /*0x0600060E*/);
    TrailRenderer.NativeMethodInfoPtr_get_generateLightingData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664847 /*0x0600060F*/);
    TrailRenderer.NativeMethodInfoPtr_set_generateLightingData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664848 /*0x06000610*/);
    TrailRenderer.NativeMethodInfoPtr_get_textureMode_Public_get_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664849);
    TrailRenderer.NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664850);
    TrailRenderer.NativeMethodInfoPtr_get_alignment_Public_get_LineAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664851);
    TrailRenderer.NativeMethodInfoPtr_set_alignment_Public_set_Void_LineAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664852);
    TrailRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664853);
    TrailRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664854);
    TrailRenderer.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664855);
    TrailRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664856);
    TrailRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664857);
    TrailRenderer.NativeMethodInfoPtr_get_widthCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664858);
    TrailRenderer.NativeMethodInfoPtr_set_widthCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664859);
    TrailRenderer.NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664860);
    TrailRenderer.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664861);
    TrailRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Private_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664862);
    TrailRenderer.NativeMethodInfoPtr_SetWidthCurve_Private_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664863);
    TrailRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Private_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664864 /*0x06000620*/);
    TrailRenderer.NativeMethodInfoPtr_SetColorGradient_Private_Void_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664865);
    TrailRenderer.NativeMethodInfoPtr_GetPositions_Public_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664866);
    TrailRenderer.NativeMethodInfoPtr_GetVisiblePositions_Public_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664867);
    TrailRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664868);
    TrailRenderer.NativeMethodInfoPtr_AddPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664869);
    TrailRenderer.NativeMethodInfoPtr_AddPositions_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664870);
    TrailRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664871);
    TrailRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeSlice_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664872);
    TrailRenderer.NativeMethodInfoPtr_GetPositions_Public_Int32_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664873);
    TrailRenderer.NativeMethodInfoPtr_GetPositions_Public_Int32_NativeSlice_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664874);
    TrailRenderer.NativeMethodInfoPtr_GetVisiblePositions_Public_Int32_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664875);
    TrailRenderer.NativeMethodInfoPtr_GetVisiblePositions_Public_Int32_NativeSlice_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664876);
    TrailRenderer.NativeMethodInfoPtr_AddPositions_Public_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664877);
    TrailRenderer.NativeMethodInfoPtr_AddPositions_Public_Void_NativeSlice_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664878);
    TrailRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664879);
    TrailRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664880 /*0x06000630*/);
    TrailRenderer.NativeMethodInfoPtr_GetVisiblePositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664881);
    TrailRenderer.NativeMethodInfoPtr_AddPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664882);
    TrailRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664883);
    TrailRenderer.NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664884);
    TrailRenderer.NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664885);
    TrailRenderer.NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664886);
    TrailRenderer.NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664887);
    TrailRenderer.NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664888);
    TrailRenderer.NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664889);
    TrailRenderer.NativeMethodInfoPtr_get_widthMultiplier_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664890);
    TrailRenderer.NativeMethodInfoPtr_set_widthMultiplier_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664891);
    TrailRenderer.NativeMethodInfoPtr_get_autodestruct_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664892);
    TrailRenderer.NativeMethodInfoPtr_set_autodestruct_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664893);
    TrailRenderer.NativeMethodInfoPtr_get_emitting_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664894);
    TrailRenderer.NativeMethodInfoPtr_set_emitting_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664895);
    TrailRenderer.NativeMethodInfoPtr_get_numCornerVertices_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664896 /*0x06000640*/);
    TrailRenderer.NativeMethodInfoPtr_set_numCornerVertices_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664897);
    TrailRenderer.NativeMethodInfoPtr_get_numCapVertices_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664898);
    TrailRenderer.NativeMethodInfoPtr_set_numCapVertices_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664899);
    TrailRenderer.NativeMethodInfoPtr_get_minVertexDistance_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664900);
    TrailRenderer.NativeMethodInfoPtr_set_minVertexDistance_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664901);
    TrailRenderer.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664902);
    TrailRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664903);
    TrailRenderer.NativeMethodInfoPtr_get_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664904);
    TrailRenderer.NativeMethodInfoPtr_set_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664905);
    TrailRenderer.NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664906);
    TrailRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664907);
    TrailRenderer.NativeMethodInfoPtr_GetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664908);
    TrailRenderer.NativeMethodInfoPtr_get_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664909);
    TrailRenderer.NativeMethodInfoPtr_set_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664910);
    TrailRenderer.NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664911);
    TrailRenderer.NativeMethodInfoPtr_set_shadowBias_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664912 /*0x06000650*/);
    TrailRenderer.NativeMethodInfoPtr_get_generateLightingData_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664913);
    TrailRenderer.NativeMethodInfoPtr_set_generateLightingData_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664914);
    TrailRenderer.NativeMethodInfoPtr_get_textureMode_Injected_Private_Static_LineTextureMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664915);
    TrailRenderer.NativeMethodInfoPtr_set_textureMode_Injected_Private_Static_Void_IntPtr_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664916);
    TrailRenderer.NativeMethodInfoPtr_get_alignment_Injected_Private_Static_LineAlignment_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664917);
    TrailRenderer.NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_LineAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664918);
    TrailRenderer.NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664919);
    TrailRenderer.NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664920);
    TrailRenderer.NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664921);
    TrailRenderer.NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664922);
    TrailRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664923);
    TrailRenderer.NativeMethodInfoPtr_SetWidthCurve_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664924);
    TrailRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664925);
    TrailRenderer.NativeMethodInfoPtr_SetColorGradient_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664926);
    TrailRenderer.NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664927);
    TrailRenderer.NativeMethodInfoPtr_GetVisiblePositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664928 /*0x06000660*/);
    TrailRenderer.NativeMethodInfoPtr_SetPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664929);
    TrailRenderer.NativeMethodInfoPtr_AddPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664930);
    TrailRenderer.NativeMethodInfoPtr_AddPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664931);
    TrailRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664932);
    TrailRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664933);
    TrailRenderer.NativeMethodInfoPtr_GetVisiblePositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664934);
    TrailRenderer.NativeMethodInfoPtr_AddPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664935);
  }

  public unsafe int numPositions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423888, RefRangeEnd = 423889, XrefRangeStart = 423883, XrefRangeEnd = 423888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_numPositions_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float time
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423894, RefRangeEnd = 423895, XrefRangeStart = 423889, XrefRangeEnd = 423894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 423900, RefRangeEnd = 423901, XrefRangeStart = 423895, XrefRangeEnd = 423900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float startWidth
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423906, RefRangeEnd = 423907, XrefRangeStart = 423901, XrefRangeEnd = 423906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 423912, RefRangeEnd = 423913, XrefRangeStart = 423907, XrefRangeEnd = 423912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float endWidth
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423918, RefRangeEnd = 423919, XrefRangeStart = 423913, XrefRangeEnd = 423918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 423924, RefRangeEnd = 423925, XrefRangeStart = 423919, XrefRangeEnd = 423924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float widthMultiplier
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423925, XrefRangeEnd = 423930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_widthMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423930, XrefRangeEnd = 423947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_widthMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool autodestruct
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423947, XrefRangeEnd = 423952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_autodestruct_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423952, XrefRangeEnd = 423957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_autodestruct_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool emitting
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423957, XrefRangeEnd = 423962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_emitting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423962, XrefRangeEnd = 423967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_emitting_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int numCornerVertices
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423967, XrefRangeEnd = 423972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_numCornerVertices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423972, XrefRangeEnd = 423977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_numCornerVertices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int numCapVertices
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423977, XrefRangeEnd = 423982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_numCapVertices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423982, XrefRangeEnd = 423987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_numCapVertices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float minVertexDistance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423987, XrefRangeEnd = 423992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_minVertexDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423992, XrefRangeEnd = 423997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_minVertexDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color startColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423997, XrefRangeEnd = 424001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424001, XrefRangeEnd = 424005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color endColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424005, XrefRangeEnd = 424009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_endColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424009, XrefRangeEnd = 424013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int positionCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 423888, RefRangeEnd = 423889, XrefRangeStart = 423888, XrefRangeEnd = 423889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424017, RefRangeEnd = 424018, XrefRangeStart = 424013, XrefRangeEnd = 424017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(int index, Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &position;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424022, RefRangeEnd = 424023, XrefRangeStart = 424018, XrefRangeEnd = 424022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPosition(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetPosition_Public_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector2 textureScale
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424023, XrefRangeEnd = 424027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424027, XrefRangeEnd = 424031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float shadowBias
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424031, XrefRangeEnd = 424036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424036, XrefRangeEnd = 424041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool generateLightingData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424041, XrefRangeEnd = 424046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_generateLightingData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424046, XrefRangeEnd = 424051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_generateLightingData_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LineTextureMode textureMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424051, XrefRangeEnd = 424056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_textureMode_Public_get_LineTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LineTextureMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424056, XrefRangeEnd = 424061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LineAlignment alignment
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424061, XrefRangeEnd = 424066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_alignment_Public_get_LineAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LineAlignment*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424066, XrefRangeEnd = 424071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_alignment_Public_set_Void_LineAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SpriteMaskInteraction maskInteraction
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424071, XrefRangeEnd = 424076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpriteMaskInteraction*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424076, XrefRangeEnd = 424081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 424086, RefRangeEnd = 424089, XrefRangeStart = 424081, XrefRangeEnd = 424086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424107, RefRangeEnd = 424108, XrefRangeStart = 424089, XrefRangeEnd = 424107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeMesh(Mesh mesh, bool useTransform = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &useTransform;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424108, XrefRangeEnd = 424125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &useTransform;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve widthCurve
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424125, XrefRangeEnd = 424130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_widthCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424130, XrefRangeEnd = 424140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_widthCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Gradient colorGradient
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424140, XrefRangeEnd = 424145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Gradient) null : Il2CppObjectPool.Get<Gradient>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424145, XrefRangeEnd = 424155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AnimationCurve GetWidthCurveCopy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Private_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWidthCurve(AnimationCurve curve)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetWidthCurve_Private_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Gradient GetColorGradientCopy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Private_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Gradient) null : Il2CppObjectPool.Get<Gradient>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColorGradient(Gradient curve)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetColorGradient_Private_Void_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424155, XrefRangeEnd = 424168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424168, XrefRangeEnd = 424181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetVisiblePositions([Out] Il2CppStructArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424181, XrefRangeEnd = 424195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions(Il2CppStructArray<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positions)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424195, XrefRangeEnd = 424199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPosition(Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &position
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_AddPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424199, XrefRangeEnd = 424213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPositions(Il2CppStructArray<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positions)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_AddPositions_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424213, XrefRangeEnd = 424222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions(NativeArray<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) positions))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424222, XrefRangeEnd = 424233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions(NativeSlice<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) positions))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeSlice_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424233, XrefRangeEnd = 424242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetPositions([Out] NativeArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424242, XrefRangeEnd = 424253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetPositions([Out] NativeSlice<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424253, XrefRangeEnd = 424262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetVisiblePositions([Out] NativeArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424262, XrefRangeEnd = 424273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetVisiblePositions([Out] NativeSlice<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424273, XrefRangeEnd = 424282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public void AddPositions([Out] NativeArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424282, XrefRangeEnd = 424293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public void AddPositions([Out] NativeSlice<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424293, XrefRangeEnd = 424298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositionsWithNativeContainer(IntPtr positions, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &count;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424298, XrefRangeEnd = 424303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPositionsWithNativeContainer(IntPtr positions, int length)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424303, XrefRangeEnd = 424308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetVisiblePositionsWithNativeContainer(IntPtr positions, int length)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetVisiblePositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424308, XrefRangeEnd = 424313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPositionsWithNativeContainer(IntPtr positions, int length)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_AddPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TrailRenderer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424313, XrefRangeEnd = 424315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_time_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424315, XrefRangeEnd = 424317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_time_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_time_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424317, XrefRangeEnd = 424319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_startWidth_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424319, XrefRangeEnd = 424321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_startWidth_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424321, XrefRangeEnd = 424323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_endWidth_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424323, XrefRangeEnd = 424325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_endWidth_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424325, XrefRangeEnd = 424327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_widthMultiplier_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_widthMultiplier_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424327, XrefRangeEnd = 424329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_widthMultiplier_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_widthMultiplier_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424329, XrefRangeEnd = 424331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_autodestruct_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_autodestruct_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424331, XrefRangeEnd = 424333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_autodestruct_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_autodestruct_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424333, XrefRangeEnd = 424335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_emitting_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_emitting_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424335, XrefRangeEnd = 424337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_emitting_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_emitting_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424337, XrefRangeEnd = 424339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_numCornerVertices_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_numCornerVertices_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424339, XrefRangeEnd = 424341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_numCornerVertices_Injected(IntPtr _unity_self, int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_numCornerVertices_Injected_Private_Static_Void_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424341, XrefRangeEnd = 424343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_numCapVertices_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_numCapVertices_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424343, XrefRangeEnd = 424345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_numCapVertices_Injected(IntPtr _unity_self, int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_numCapVertices_Injected_Private_Static_Void_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424345, XrefRangeEnd = 424347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_minVertexDistance_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_minVertexDistance_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424347, XrefRangeEnd = 424349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_minVertexDistance_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_minVertexDistance_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424349, XrefRangeEnd = 424351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_startColor_Injected(IntPtr _unity_self, out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424351, XrefRangeEnd = 424353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_startColor_Injected(IntPtr _unity_self, [In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424353, XrefRangeEnd = 424355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_endColor_Injected(IntPtr _unity_self, out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424355, XrefRangeEnd = 424357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_endColor_Injected(IntPtr _unity_self, [In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424357, XrefRangeEnd = 424359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_positionCount_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424359, XrefRangeEnd = 424361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPosition_Injected(
    IntPtr _unity_self,
    int index,
    [In] ref Vector3 position)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref position;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424361, XrefRangeEnd = 424363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPosition_Injected(IntPtr _unity_self, int index, out Vector3 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424363, XrefRangeEnd = 424365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_textureScale_Injected(IntPtr _unity_self, out Vector2 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424365, XrefRangeEnd = 424367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_textureScale_Injected(IntPtr _unity_self, [In] ref Vector2 value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424367, XrefRangeEnd = 424369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_shadowBias_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424369, XrefRangeEnd = 424371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_shadowBias_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_shadowBias_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424371, XrefRangeEnd = 424373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_generateLightingData_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_generateLightingData_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424373, XrefRangeEnd = 424375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_generateLightingData_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_generateLightingData_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424375, XrefRangeEnd = 424377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LineTextureMode get_textureMode_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_textureMode_Injected_Private_Static_LineTextureMode_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LineTextureMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424377, XrefRangeEnd = 424379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_textureMode_Injected(IntPtr _unity_self, LineTextureMode value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_textureMode_Injected_Private_Static_Void_IntPtr_LineTextureMode_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424379, XrefRangeEnd = 424381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LineAlignment get_alignment_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_alignment_Injected_Private_Static_LineAlignment_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LineAlignment*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424381, XrefRangeEnd = 424383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_alignment_Injected(IntPtr _unity_self, LineAlignment value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_LineAlignment_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424383, XrefRangeEnd = 424385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SpriteMaskInteraction*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424385, XrefRangeEnd = 424387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_maskInteraction_Injected(
    IntPtr _unity_self,
    SpriteMaskInteraction value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424387, XrefRangeEnd = 424389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424389, XrefRangeEnd = 424391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BakeMesh_Injected(
    IntPtr _unity_self,
    IntPtr mesh,
    IntPtr camera,
    bool useTransform)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mesh;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &camera;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &useTransform;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424391, XrefRangeEnd = 424393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetWidthCurveCopy_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424393, XrefRangeEnd = 424395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetWidthCurve_Injected(IntPtr _unity_self, IntPtr curve)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &curve;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetWidthCurve_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424395, XrefRangeEnd = 424397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetColorGradientCopy_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424397, XrefRangeEnd = 424399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetColorGradient_Injected(IntPtr _unity_self, IntPtr curve)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &curve;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetColorGradient_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424399, XrefRangeEnd = 424401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPositions_Injected(
    IntPtr _unity_self,
    out BlittableArrayWrapper positions)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref positions;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424401, XrefRangeEnd = 424403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetVisiblePositions_Injected(
    IntPtr _unity_self,
    out BlittableArrayWrapper positions)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref positions;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetVisiblePositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424403, XrefRangeEnd = 424405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPositions_Injected(
    IntPtr _unity_self,
    ref ManagedSpanWrapper positions)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref positions;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424405, XrefRangeEnd = 424407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddPosition_Injected(IntPtr _unity_self, [In] ref Vector3 position)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref position;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_AddPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424407, XrefRangeEnd = 424409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddPositions_Injected(
    IntPtr _unity_self,
    ref ManagedSpanWrapper positions)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref positions;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_AddPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424409, XrefRangeEnd = 424411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPositionsWithNativeContainer_Injected(
    IntPtr _unity_self,
    IntPtr positions,
    int count)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &count;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424411, XrefRangeEnd = 424413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPositionsWithNativeContainer_Injected(
    IntPtr _unity_self,
    IntPtr positions,
    int length)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424413, XrefRangeEnd = 424415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetVisiblePositionsWithNativeContainer_Injected(
    IntPtr _unity_self,
    IntPtr positions,
    int length)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_GetVisiblePositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424415, XrefRangeEnd = 424417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddPositionsWithNativeContainer_Injected(
    IntPtr _unity_self,
    IntPtr positions,
    int length)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TrailRenderer.NativeMethodInfoPtr_AddPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
