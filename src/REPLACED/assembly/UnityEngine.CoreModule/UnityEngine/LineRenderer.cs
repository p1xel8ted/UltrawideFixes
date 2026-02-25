// Decompiled with JetBrains decompiler
// Type: UnityEngine.LineRenderer
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

public sealed class LineRenderer(IntPtr pointer) : Renderer(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SetWidth_Public_Void_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColors_Public_Void_Color_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetVertexCount_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numPositions_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numPositions_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startWidth_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endWidth_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_widthMultiplier_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_widthMultiplier_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCornerVertices_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCornerVertices_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCapVertices_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCapVertices_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_useWorldSpace_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_useWorldSpace_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endColor_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0;
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
  private static readonly IntPtr NativeMethodInfoPtr_Simplify_Public_Void_Single_0;
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
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_NativeArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Void_NativeSlice_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Public_Int32_NativeArray_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Public_Int32_NativeSlice_1_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_widthMultiplier_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_widthMultiplier_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCornerVertices_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCornerVertices_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_numCapVertices_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_numCapVertices_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_useWorldSpace_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_useWorldSpace_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_positionCount_Injected_Private_Static_Void_IntPtr_Int32_0;
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
  private static readonly IntPtr NativeMethodInfoPtr_Simplify_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetWidthCurveCopy_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetWidthCurve_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetColorGradientCopy_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetColorGradient_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0;

  static LineRenderer()
  {
    Il2CppClassPointerStore<LineRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LineRenderer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr);
    LineRenderer.NativeMethodInfoPtr_SetWidth_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664936);
    LineRenderer.NativeMethodInfoPtr_SetColors_Public_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664937);
    LineRenderer.NativeMethodInfoPtr_SetVertexCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664938);
    LineRenderer.NativeMethodInfoPtr_get_numPositions_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664939);
    LineRenderer.NativeMethodInfoPtr_set_numPositions_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664940);
    LineRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664941);
    LineRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664942);
    LineRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664943);
    LineRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664944 /*0x06000670*/);
    LineRenderer.NativeMethodInfoPtr_get_widthMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664945);
    LineRenderer.NativeMethodInfoPtr_set_widthMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664946);
    LineRenderer.NativeMethodInfoPtr_get_numCornerVertices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664947);
    LineRenderer.NativeMethodInfoPtr_set_numCornerVertices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664948);
    LineRenderer.NativeMethodInfoPtr_get_numCapVertices_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664949);
    LineRenderer.NativeMethodInfoPtr_set_numCapVertices_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664950);
    LineRenderer.NativeMethodInfoPtr_get_useWorldSpace_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664951);
    LineRenderer.NativeMethodInfoPtr_set_useWorldSpace_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664952);
    LineRenderer.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664953);
    LineRenderer.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664954);
    LineRenderer.NativeMethodInfoPtr_get_startColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664955);
    LineRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664956);
    LineRenderer.NativeMethodInfoPtr_get_endColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664957);
    LineRenderer.NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664958);
    LineRenderer.NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664959);
    LineRenderer.NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664960 /*0x06000680*/);
    LineRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664961);
    LineRenderer.NativeMethodInfoPtr_GetPosition_Public_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664962);
    LineRenderer.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664963);
    LineRenderer.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664964);
    LineRenderer.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664965);
    LineRenderer.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664966);
    LineRenderer.NativeMethodInfoPtr_get_generateLightingData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664967);
    LineRenderer.NativeMethodInfoPtr_set_generateLightingData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664968);
    LineRenderer.NativeMethodInfoPtr_get_textureMode_Public_get_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664969);
    LineRenderer.NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664970);
    LineRenderer.NativeMethodInfoPtr_get_alignment_Public_get_LineAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664971);
    LineRenderer.NativeMethodInfoPtr_set_alignment_Public_set_Void_LineAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664972);
    LineRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664973);
    LineRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664974);
    LineRenderer.NativeMethodInfoPtr_Simplify_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664975);
    LineRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664976 /*0x06000690*/);
    LineRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664977);
    LineRenderer.NativeMethodInfoPtr_get_widthCurve_Public_get_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664978);
    LineRenderer.NativeMethodInfoPtr_set_widthCurve_Public_set_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664979);
    LineRenderer.NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664980);
    LineRenderer.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664981);
    LineRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Private_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664982);
    LineRenderer.NativeMethodInfoPtr_SetWidthCurve_Private_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664983);
    LineRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Private_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664984);
    LineRenderer.NativeMethodInfoPtr_SetColorGradient_Private_Void_Gradient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664985);
    LineRenderer.NativeMethodInfoPtr_GetPositions_Public_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664986);
    LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664987);
    LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664988);
    LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeSlice_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664989);
    LineRenderer.NativeMethodInfoPtr_GetPositions_Public_Int32_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664990);
    LineRenderer.NativeMethodInfoPtr_GetPositions_Public_Int32_NativeSlice_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664991);
    LineRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664992 /*0x060006A0*/);
    LineRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664993);
    LineRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664994);
    LineRenderer.NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664995);
    LineRenderer.NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664996);
    LineRenderer.NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664997);
    LineRenderer.NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664998);
    LineRenderer.NativeMethodInfoPtr_get_widthMultiplier_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664999);
    LineRenderer.NativeMethodInfoPtr_set_widthMultiplier_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665000);
    LineRenderer.NativeMethodInfoPtr_get_numCornerVertices_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665001);
    LineRenderer.NativeMethodInfoPtr_set_numCornerVertices_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665002);
    LineRenderer.NativeMethodInfoPtr_get_numCapVertices_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665003);
    LineRenderer.NativeMethodInfoPtr_set_numCapVertices_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665004);
    LineRenderer.NativeMethodInfoPtr_get_useWorldSpace_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665005);
    LineRenderer.NativeMethodInfoPtr_set_useWorldSpace_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665006);
    LineRenderer.NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665007);
    LineRenderer.NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665008 /*0x060006B0*/);
    LineRenderer.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665009);
    LineRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665010);
    LineRenderer.NativeMethodInfoPtr_get_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665011);
    LineRenderer.NativeMethodInfoPtr_set_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665012);
    LineRenderer.NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665013);
    LineRenderer.NativeMethodInfoPtr_set_positionCount_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665014);
    LineRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665015);
    LineRenderer.NativeMethodInfoPtr_GetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665016);
    LineRenderer.NativeMethodInfoPtr_get_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665017);
    LineRenderer.NativeMethodInfoPtr_set_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665018);
    LineRenderer.NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665019);
    LineRenderer.NativeMethodInfoPtr_set_shadowBias_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665020);
    LineRenderer.NativeMethodInfoPtr_get_generateLightingData_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665021);
    LineRenderer.NativeMethodInfoPtr_set_generateLightingData_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665022);
    LineRenderer.NativeMethodInfoPtr_get_textureMode_Injected_Private_Static_LineTextureMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665023);
    LineRenderer.NativeMethodInfoPtr_set_textureMode_Injected_Private_Static_Void_IntPtr_LineTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665024 /*0x060006C0*/);
    LineRenderer.NativeMethodInfoPtr_get_alignment_Injected_Private_Static_LineAlignment_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665025);
    LineRenderer.NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_LineAlignment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665026);
    LineRenderer.NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665027);
    LineRenderer.NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665028);
    LineRenderer.NativeMethodInfoPtr_Simplify_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665029);
    LineRenderer.NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665030);
    LineRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665031);
    LineRenderer.NativeMethodInfoPtr_SetWidthCurve_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665032);
    LineRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665033);
    LineRenderer.NativeMethodInfoPtr_SetColorGradient_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665034);
    LineRenderer.NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665035);
    LineRenderer.NativeMethodInfoPtr_SetPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665036);
    LineRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665037);
    LineRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100665038);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424417, XrefRangeEnd = 424426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetWidth(float start, float end)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &start;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &end;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetWidth_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424426, XrefRangeEnd = 424434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColors(Color start, Color end)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &start;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &end;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetColors_Public_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424434, XrefRangeEnd = 424439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVertexCount(int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &count
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetVertexCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int numPositions
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424439, XrefRangeEnd = 424444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_numPositions_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_numPositions_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float startWidth
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424444, XrefRangeEnd = 424449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_startWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424449, XrefRangeEnd = 424454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float endWidth
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424454, XrefRangeEnd = 424459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_endWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424459, XrefRangeEnd = 424464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float widthMultiplier
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424464, XrefRangeEnd = 424469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_widthMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424469, XrefRangeEnd = 424474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_widthMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int numCornerVertices
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424474, XrefRangeEnd = 424479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_numCornerVertices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424479, XrefRangeEnd = 424484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_numCornerVertices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int numCapVertices
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424484, XrefRangeEnd = 424489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_numCapVertices_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424489, XrefRangeEnd = 424494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_numCapVertices_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool useWorldSpace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424494, XrefRangeEnd = 424499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_useWorldSpace_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424499, XrefRangeEnd = 424504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_useWorldSpace_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool loop
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424504, XrefRangeEnd = 424509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424509, XrefRangeEnd = 424514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color startColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424514, XrefRangeEnd = 424518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_startColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 424522, RefRangeEnd = 424523, XrefRangeStart = 424518, XrefRangeEnd = 424522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_startColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color endColor
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424523, XrefRangeEnd = 424527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_endColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 424531, RefRangeEnd = 424532, XrefRangeStart = 424527, XrefRangeEnd = 424531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_endColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int positionCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424532, XrefRangeEnd = 424536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPosition(int index, Vector3 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &position;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424536, XrefRangeEnd = 424540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPosition(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetPosition_Public_Vector3_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector2 textureScale
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424540, XrefRangeEnd = 424544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_textureScale_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424544, XrefRangeEnd = 424548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_textureScale_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float shadowBias
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424548, XrefRangeEnd = 424553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_shadowBias_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424553, XrefRangeEnd = 424558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_shadowBias_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool generateLightingData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424558, XrefRangeEnd = 424563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_generateLightingData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424563, XrefRangeEnd = 424568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_generateLightingData_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LineTextureMode textureMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424568, XrefRangeEnd = 424573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_textureMode_Public_get_LineTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LineTextureMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424573, XrefRangeEnd = 424578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_textureMode_Public_set_Void_LineTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LineAlignment alignment
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424578, XrefRangeEnd = 424583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_alignment_Public_get_LineAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LineAlignment*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424583, XrefRangeEnd = 424588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_alignment_Public_set_Void_LineAlignment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SpriteMaskInteraction maskInteraction
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424588, XrefRangeEnd = 424593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpriteMaskInteraction*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424593, XrefRangeEnd = 424598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424598, XrefRangeEnd = 424603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Simplify(float tolerance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &tolerance
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_Simplify_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424603, XrefRangeEnd = 424621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeMesh(Mesh mesh, bool useTransform = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &useTransform;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424621, XrefRangeEnd = 424638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &useTransform;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_BakeMesh_Public_Void_Mesh_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve widthCurve
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424638, XrefRangeEnd = 424643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_widthCurve_Public_get_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424643, XrefRangeEnd = 424653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_widthCurve_Public_set_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Gradient colorGradient
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424653, XrefRangeEnd = 424658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_colorGradient_Public_get_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Gradient) null : Il2CppObjectPool.Get<Gradient>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424658, XrefRangeEnd = 424668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_colorGradient_Public_set_Void_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Private_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetWidthCurve_Private_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Gradient GetColorGradientCopy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Private_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetColorGradient_Private_Void_Gradient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424668, XrefRangeEnd = 424681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424695, RefRangeEnd = 424696, XrefRangeStart = 424681, XrefRangeEnd = 424695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions(Il2CppStructArray<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positions)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424696, XrefRangeEnd = 424705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions(NativeArray<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) positions))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424705, XrefRangeEnd = 424716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositions(NativeSlice<Vector3> positions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) positions))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositions_Public_Void_NativeSlice_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424716, XrefRangeEnd = 424725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetPositions([Out] NativeArray<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424725, XrefRangeEnd = 424736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public int GetPositions([Out] NativeSlice<Vector3> positions)
  {
    // ISSUE: unable to decompile the method.
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424736, XrefRangeEnd = 424741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetPositionsWithNativeContainer(IntPtr positions, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &count;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Private_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424741, XrefRangeEnd = 424746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPositionsWithNativeContainer(IntPtr positions, int length)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &positions;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &length;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Private_Int32_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LineRenderer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424746, XrefRangeEnd = 424748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_startWidth_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424748, XrefRangeEnd = 424750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_startWidth_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424750, XrefRangeEnd = 424752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_endWidth_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424752, XrefRangeEnd = 424754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_endWidth_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424754, XrefRangeEnd = 424756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_widthMultiplier_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_widthMultiplier_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424756, XrefRangeEnd = 424758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_widthMultiplier_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_widthMultiplier_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424758, XrefRangeEnd = 424760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_numCornerVertices_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_numCornerVertices_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424760, XrefRangeEnd = 424762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_numCornerVertices_Injected(IntPtr _unity_self, int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_numCornerVertices_Injected_Private_Static_Void_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424762, XrefRangeEnd = 424764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_numCapVertices_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_numCapVertices_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424764, XrefRangeEnd = 424766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_numCapVertices_Injected(IntPtr _unity_self, int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_numCapVertices_Injected_Private_Static_Void_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424766, XrefRangeEnd = 424768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_useWorldSpace_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_useWorldSpace_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424768, XrefRangeEnd = 424770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_useWorldSpace_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_useWorldSpace_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424770, XrefRangeEnd = 424772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_loop_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_loop_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424772, XrefRangeEnd = 424774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_loop_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_loop_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424774, XrefRangeEnd = 424776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_startColor_Injected(IntPtr _unity_self, out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424776, XrefRangeEnd = 424778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_startColor_Injected(IntPtr _unity_self, [In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_startColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424778, XrefRangeEnd = 424780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_endColor_Injected(IntPtr _unity_self, out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424780, XrefRangeEnd = 424782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_endColor_Injected(IntPtr _unity_self, [In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_endColor_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424782, XrefRangeEnd = 424784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_positionCount_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424784, XrefRangeEnd = 424786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_positionCount_Injected(IntPtr _unity_self, int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_positionCount_Injected_Private_Static_Void_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424786, XrefRangeEnd = 424788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424788, XrefRangeEnd = 424790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPosition_Injected(IntPtr _unity_self, int index, out Vector3 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424790, XrefRangeEnd = 424792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_textureScale_Injected(IntPtr _unity_self, out Vector2 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424792, XrefRangeEnd = 424794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_textureScale_Injected(IntPtr _unity_self, [In] ref Vector2 value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_textureScale_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424794, XrefRangeEnd = 424796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_shadowBias_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_shadowBias_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424796, XrefRangeEnd = 424798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_shadowBias_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_shadowBias_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424798, XrefRangeEnd = 424800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_generateLightingData_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_generateLightingData_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424800, XrefRangeEnd = 424802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_generateLightingData_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_generateLightingData_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424802, XrefRangeEnd = 424804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LineTextureMode get_textureMode_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_textureMode_Injected_Private_Static_LineTextureMode_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LineTextureMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424804, XrefRangeEnd = 424806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_textureMode_Injected(IntPtr _unity_self, LineTextureMode value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_textureMode_Injected_Private_Static_Void_IntPtr_LineTextureMode_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424806, XrefRangeEnd = 424808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LineAlignment get_alignment_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_alignment_Injected_Private_Static_LineAlignment_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LineAlignment*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424808, XrefRangeEnd = 424810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_alignment_Injected(IntPtr _unity_self, LineAlignment value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_LineAlignment_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424810, XrefRangeEnd = 424812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SpriteMaskInteraction*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424812, XrefRangeEnd = 424814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_maskInteraction_Injected(
    IntPtr _unity_self,
    SpriteMaskInteraction value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424814, XrefRangeEnd = 424816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Simplify_Injected(IntPtr _unity_self, float tolerance)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &tolerance;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_Simplify_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424816, XrefRangeEnd = 424818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_BakeMesh_Injected_Private_Static_Void_IntPtr_IntPtr_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424818, XrefRangeEnd = 424820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetWidthCurveCopy_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetWidthCurveCopy_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424820, XrefRangeEnd = 424822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetWidthCurve_Injected(IntPtr _unity_self, IntPtr curve)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &curve;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetWidthCurve_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424822, XrefRangeEnd = 424824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetColorGradientCopy_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetColorGradientCopy_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424824, XrefRangeEnd = 424826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetColorGradient_Injected(IntPtr _unity_self, IntPtr curve)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &curve;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetColorGradient_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424826, XrefRangeEnd = 424828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPositions_Injected(
    IntPtr _unity_self,
    out BlittableArrayWrapper positions)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref positions;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424828, XrefRangeEnd = 424830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPositions_Injected(
    IntPtr _unity_self,
    ref ManagedSpanWrapper positions)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref positions;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositions_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424830, XrefRangeEnd = 424832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_SetPositionsWithNativeContainer_Injected_Private_Static_Void_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424832, XrefRangeEnd = 424834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineRenderer.NativeMethodInfoPtr_GetPositionsWithNativeContainer_Injected_Private_Static_Int32_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
