// Decompiled with JetBrains decompiler
// Type: Utils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using SadCatStudios.Environment;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public static class Utils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AutoBuildStarted;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogNoTrace_Public_Static_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EaseFromTo_Public_Static_Single_Single_Single_Single_EaseType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EaseCurve_Public_Static_Single_AnimationCurve_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EaseCurve_Public_Static_Vector3_AnimationCurve_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SmoothApproach_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remap_Public_Static_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrowForGizmo_Public_Static_Void_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrowForGizmo_Public_Static_Void_Vector3_Vector3_Color_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrowForDebug_Public_Static_Void_Vector3_Vector3_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrowForDebug_Public_Static_Void_Vector3_Vector3_Color_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DrawArrowEnd_Private_Static_Void_Boolean_Vector3_Vector3_Color_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AreNearlyEqual_Public_Static_Boolean_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenSizeInWorldCoords_Public_Static_Vector2_Camera_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVectorsSum_Public_Static_Vector3_IList_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AlignToGrid_Public_Static_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInFront_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsRight_Public_Static_Boolean_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInsideRectangle_Public_Static_Boolean_Single_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInsideCircle_Public_Static_Boolean_Single_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasFlagUnsafe_Public_Static_Boolean_TEnum_TEnum_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindClosestPlane_Public_Static_LayerPlane_Il2CppReferenceArray_1_LayerPlane_Vector3_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureVisibility_Public_Static_Void_ScrollRect_RectTransform_Single_0;

  static Utils()
  {
    Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (Utils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
    Utils.NativeFieldInfoPtr_AutoBuildStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, nameof (AutoBuildStarted));
    Utils.NativeMethodInfoPtr_LogNoTrace_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663761);
    Utils.NativeMethodInfoPtr_EaseFromTo_Public_Static_Single_Single_Single_Single_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663762);
    Utils.NativeMethodInfoPtr_EaseCurve_Public_Static_Single_AnimationCurve_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663763);
    Utils.NativeMethodInfoPtr_EaseCurve_Public_Static_Vector3_AnimationCurve_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663764);
    Utils.NativeMethodInfoPtr_SmoothApproach_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663765);
    Utils.NativeMethodInfoPtr_Remap_Public_Static_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663766);
    Utils.NativeMethodInfoPtr_DrawArrowForGizmo_Public_Static_Void_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663767);
    Utils.NativeMethodInfoPtr_DrawArrowForGizmo_Public_Static_Void_Vector3_Vector3_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663768);
    Utils.NativeMethodInfoPtr_DrawArrowForDebug_Public_Static_Void_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663769);
    Utils.NativeMethodInfoPtr_DrawArrowForDebug_Public_Static_Void_Vector3_Vector3_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663770);
    Utils.NativeMethodInfoPtr_DrawArrowEnd_Private_Static_Void_Boolean_Vector3_Vector3_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663771);
    Utils.NativeMethodInfoPtr_AreNearlyEqual_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663772);
    Utils.NativeMethodInfoPtr_GetScreenSizeInWorldCoords_Public_Static_Vector2_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663773);
    Utils.NativeMethodInfoPtr_GetVectorsSum_Public_Static_Vector3_IList_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663774);
    Utils.NativeMethodInfoPtr_AlignToGrid_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663775);
    Utils.NativeMethodInfoPtr_IsInFront_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663776 /*0x060001E0*/);
    Utils.NativeMethodInfoPtr_IsRight_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663777);
    Utils.NativeMethodInfoPtr_IsInsideRectangle_Public_Static_Boolean_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663778);
    Utils.NativeMethodInfoPtr_IsInsideCircle_Public_Static_Boolean_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663779);
    Utils.NativeMethodInfoPtr_HasFlagUnsafe_Public_Static_Boolean_TEnum_TEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663780);
    Utils.NativeMethodInfoPtr_FindClosestPlane_Public_Static_LayerPlane_Il2CppReferenceArray_1_LayerPlane_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663781);
    Utils.NativeMethodInfoPtr_EnsureVisibility_Public_Static_Void_ScrollRect_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100663782);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22717, XrefRangeEnd = 22724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogNoTrace(string log, UnityEngine.Object context)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(log);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_LogNoTrace_Public_Static_Void_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22724, XrefRangeEnd = 22733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float EaseFromTo(float start, float end, float value, EaseType type = EaseType.EaseInOut)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_EaseFromTo_Public_Static_Single_Single_Single_Single_EaseType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 22734, RefRangeEnd = 22751, XrefRangeStart = 22733, XrefRangeEnd = 22734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float EaseCurve(AnimationCurve curve, float start, float end, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_EaseCurve_Public_Static_Single_AnimationCurve_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 22752, RefRangeEnd = 22757, XrefRangeStart = 22751, XrefRangeEnd = 22752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 EaseCurve(
    AnimationCurve curve,
    Vector3 start,
    Vector3 end,
    float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) curve);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &end;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_EaseCurve_Public_Static_Vector3_AnimationCurve_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22757, XrefRangeEnd = 22758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float SmoothApproach(
    float pastPosition,
    float pastTargetPosition,
    float targetPosition,
    float speed,
    float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &pastPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pastTargetPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &speed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SmoothApproach_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 22758, RefRangeEnd = 22789, XrefRangeStart = 22758, XrefRangeEnd = 22758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Remap(
    this float value,
    float from1,
    float to1,
    float from2,
    float to2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &from1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &to1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &from2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &to2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Remap_Public_Static_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22792, RefRangeEnd = 22793, XrefRangeStart = 22789, XrefRangeEnd = 22792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrowForGizmo(
    Vector3 pos,
    Vector3 direction,
    float arrowHeadLength = 0.25f,
    float arrowHeadAngle = 20f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadAngle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DrawArrowForGizmo_Public_Static_Void_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22793, XrefRangeEnd = 22795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrowForGizmo(
    Vector3 pos,
    Vector3 direction,
    Color color,
    float arrowHeadLength = 0.25f,
    float arrowHeadAngle = 20f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadAngle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DrawArrowForGizmo_Public_Static_Void_Vector3_Vector3_Color_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22795, XrefRangeEnd = 22801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrowForDebug(
    Vector3 pos,
    Vector3 direction,
    float arrowHeadLength = 0.25f,
    float arrowHeadAngle = 20f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadAngle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DrawArrowForDebug_Public_Static_Void_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22801, XrefRangeEnd = 22806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrowForDebug(
    Vector3 pos,
    Vector3 direction,
    Color color,
    float arrowHeadLength = 0.25f,
    float arrowHeadAngle = 20f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadAngle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DrawArrowForDebug_Public_Static_Void_Vector3_Vector3_Color_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 22841, RefRangeEnd = 22845, XrefRangeStart = 22806, XrefRangeEnd = 22841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DrawArrowEnd(
    bool gizmos,
    Vector3 pos,
    Vector3 direction,
    Color color,
    float arrowHeadLength = 0.25f,
    float arrowHeadAngle = 20f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &gizmos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &arrowHeadAngle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DrawArrowEnd_Private_Static_Void_Boolean_Vector3_Vector3_Color_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22845, RefRangeEnd = 22847, XrefRangeStart = 22845, XrefRangeEnd = 22845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AreNearlyEqual(float a, float b, float tolerance = 0.02f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &tolerance;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_AreNearlyEqual_Public_Static_Boolean_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22847, XrefRangeEnd = 22861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetScreenSizeInWorldCoords(Camera gameCamera, float distance = 10f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameCamera);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &distance;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetScreenSizeInWorldCoords_Public_Static_Vector2_Camera_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22861, XrefRangeEnd = 22872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetVectorsSum(IList<Vector3> input)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) input)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetVectorsSum_Public_Static_Vector3_IList_1_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22872, XrefRangeEnd = 22874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float AlignToGrid(float input, float gridSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &input;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSize;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_AlignToGrid_Public_Static_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 22876, RefRangeEnd = 22883, XrefRangeStart = 22874, XrefRangeEnd = 22876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsInFront(
    Vector3 targetPos,
    Vector3 selfPos,
    Vector3 dirVector,
    float rotation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &targetPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &selfPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dirVector;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsInFront_Public_Static_Boolean_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 22884, RefRangeEnd = 22892, XrefRangeStart = 22883, XrefRangeEnd = 22884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsRight(Vector3 targetPos, Vector3 selfPos, float rotation = -1f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &targetPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &selfPos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rotation;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsRight_Public_Static_Boolean_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsInsideRectangle(
    float x,
    float y,
    float width,
    float height,
    float pointX,
    float pointY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &pointX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &pointY;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsInsideRectangle_Public_Static_Boolean_Single_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsInsideCircle(
    float x,
    float y,
    float radius,
    float pointX,
    float pointY)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &radius;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pointX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &pointY;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsInsideCircle_Public_Static_Boolean_Single_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 22892, RefRangeEnd = 22921, XrefRangeStart = 22892, XrefRangeEnd = 22892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasFlagUnsafe<TEnum>(TEnum lhs, TEnum rhs) where TEnum : System.Enum, new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    TEnum& local1;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local2 = (object) lhs;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref lhs;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TEnum& local3;
    if (!typeof (TEnum).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TEnum> local4 = (object) rhs;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local3 = local4 is string ? (TEnum&) IL2CPP.ManagedStringToIl2Cpp(local4 as string) : (TEnum&) IL2CPP.Il2CppObjectBaseToPtr(local4 as Il2CppObjectBase);
    }
    else
      local3 = ref rhs;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local3;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_HasFlagUnsafe_Public_Static_Boolean_TEnum_TEnum_0<TEnum>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22921, XrefRangeEnd = 22931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe LayerPlane FindClosestPlane(
    Il2CppReferenceArray<LayerPlane> planes,
    Vector3 pos,
    int dir)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) planes);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_FindClosestPlane_Public_Static_LayerPlane_Il2CppReferenceArray_1_LayerPlane_Vector3_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LayerPlane) null : Il2CppObjectPool.Get<LayerPlane>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22939, RefRangeEnd = 22941, XrefRangeStart = 22931, XrefRangeEnd = 22939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EnsureVisibility(
    ScrollRect scrollRect,
    RectTransform child,
    float padding = 0.0f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scrollRect);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) child);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &padding;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_EnsureVisibility_Public_Static_Void_ScrollRect_RectTransform_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Utils(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe bool AutoBuildStarted
  {
    get
    {
      bool autoBuildStarted;
      IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_AutoBuildStarted, (void*) &autoBuildStarted);
      return autoBuildStarted;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_AutoBuildStarted, (void*) &value);
    }
  }

  private sealed class MethodInfoStoreGeneric_HasFlagUnsafe_Public_Static_Boolean_TEnum_TEnum_0<TEnum>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_HasFlagUnsafe_Public_Static_Boolean_TEnum_TEnum_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TEnum>.NativeClassPtr))
    }))));
  }
}
