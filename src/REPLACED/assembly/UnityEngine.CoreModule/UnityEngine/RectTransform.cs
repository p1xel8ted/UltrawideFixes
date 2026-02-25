// Decompiled with JetBrains decompiler
// Type: UnityEngine.RectTransform
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class RectTransform(System.IntPtr pointer) : Transform(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_reapplyDrivenProperties;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_drivenByObject_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_drivenByObject_Internal_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_drivenProperties_Internal_get_DrivenTransformProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_drivenProperties_Internal_set_Void_DrivenTransformProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sendChildDimensionsChange_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_sendChildDimensionsChange_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInsetAndSizeFromParentEdge_Public_Void_Edge_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRectInParentSpace_Internal_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_drivenByObject_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_drivenByObject_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_drivenProperties_Injected_Private_Static_DrivenTransformProperties_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_drivenProperties_Injected_Private_Static_Void_IntPtr_DrivenTransformProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sendChildDimensionsChange_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_sendChildDimensionsChange_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateRectTransforms_Injected_Private_Static_Void_IntPtr_0;

  static RectTransform()
  {
    Il2CppClassPointerStore<RectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RectTransform));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransform>.NativeClassPtr);
    RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, nameof (reapplyDrivenProperties));
    RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668653);
    RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668654);
    RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668655);
    RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668656);
    RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668657);
    RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668658);
    RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668659);
    RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668660);
    RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668661);
    RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668662);
    RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668663);
    RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668664);
    RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668665);
    RectTransform.NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668666);
    RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668667);
    RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668668);
    RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668669);
    RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668670);
    RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668671);
    RectTransform.NativeMethodInfoPtr_get_drivenByObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668672 /*0x06001500*/);
    RectTransform.NativeMethodInfoPtr_set_drivenByObject_Internal_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668673);
    RectTransform.NativeMethodInfoPtr_get_drivenProperties_Internal_get_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668674);
    RectTransform.NativeMethodInfoPtr_set_drivenProperties_Internal_set_Void_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668675);
    RectTransform.NativeMethodInfoPtr_get_sendChildDimensionsChange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668676);
    RectTransform.NativeMethodInfoPtr_set_sendChildDimensionsChange_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668677);
    RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668678);
    RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668679);
    RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668680);
    RectTransform.NativeMethodInfoPtr_SetInsetAndSizeFromParentEdge_Public_Void_Edge_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668681);
    RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668682);
    RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668683);
    RectTransform.NativeMethodInfoPtr_GetRectInParentSpace_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668684);
    RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668685);
    RectTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668686);
    RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668687);
    RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668688);
    RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668689);
    RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668690);
    RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668691);
    RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668692);
    RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668693);
    RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668694);
    RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668695);
    RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668696);
    RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668697);
    RectTransform.NativeMethodInfoPtr_get_drivenByObject_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668698);
    RectTransform.NativeMethodInfoPtr_set_drivenByObject_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668699);
    RectTransform.NativeMethodInfoPtr_get_drivenProperties_Injected_Private_Static_DrivenTransformProperties_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668700);
    RectTransform.NativeMethodInfoPtr_set_drivenProperties_Injected_Private_Static_Void_IntPtr_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668701);
    RectTransform.NativeMethodInfoPtr_get_sendChildDimensionsChange_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668702);
    RectTransform.NativeMethodInfoPtr_set_sendChildDimensionsChange_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668703);
    RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100668704);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466363, XrefRangeEnd = 466370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466370, XrefRangeEnd = 466377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void remove_reapplyDrivenProperties(
    RectTransform.ReapplyDrivenProperties value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Rect rect
  {
    [CallerCount(122), CachedScanResults(RefRangeStart = 466381, RefRangeEnd = 466503, XrefRangeStart = 466377, XrefRangeEnd = 466381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 anchorMin
  {
    [CallerCount(21), CachedScanResults(RefRangeStart = 466507, RefRangeEnd = 466528, XrefRangeStart = 466503, XrefRangeEnd = 466507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(77), CachedScanResults(RefRangeStart = 466532, RefRangeEnd = 466609, XrefRangeStart = 466528, XrefRangeEnd = 466532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 anchorMax
  {
    [CallerCount(18), CachedScanResults(RefRangeStart = 466613, RefRangeEnd = 466631, XrefRangeStart = 466609, XrefRangeEnd = 466613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(79), CachedScanResults(RefRangeStart = 466635, RefRangeEnd = 466714, XrefRangeStart = 466631, XrefRangeEnd = 466635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 anchoredPosition
  {
    [CallerCount(90), CachedScanResults(RefRangeStart = 466718, RefRangeEnd = 466808, XrefRangeStart = 466714, XrefRangeEnd = 466718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(77), CachedScanResults(RefRangeStart = 466812, RefRangeEnd = 466889, XrefRangeStart = 466808, XrefRangeEnd = 466812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 sizeDelta
  {
    [CallerCount(56), CachedScanResults(RefRangeStart = 466893, RefRangeEnd = 466949, XrefRangeStart = 466889, XrefRangeEnd = 466893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(81), CachedScanResults(RefRangeStart = 466953, RefRangeEnd = 467034, XrefRangeStart = 466949, XrefRangeEnd = 466953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 pivot
  {
    [CallerCount(46), CachedScanResults(RefRangeStart = 467038, RefRangeEnd = 467084, XrefRangeStart = 467034, XrefRangeEnd = 467038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(29), CachedScanResults(RefRangeStart = 467088, RefRangeEnd = 467117, XrefRangeStart = 467084, XrefRangeEnd = 467088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 anchoredPosition3D
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 467125, RefRangeEnd = 467129, XrefRangeStart = 467117, XrefRangeEnd = 467125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 467141, RefRangeEnd = 467145, XrefRangeStart = 467129, XrefRangeEnd = 467141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 offsetMin
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 467157, RefRangeEnd = 467160, XrefRangeStart = 467145, XrefRangeEnd = 467157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(12), CachedScanResults(RefRangeStart = 467194, RefRangeEnd = 467206, XrefRangeStart = 467160, XrefRangeEnd = 467194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 offsetMax
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 467220, RefRangeEnd = 467222, XrefRangeStart = 467206, XrefRangeEnd = 467220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 467256, RefRangeEnd = 467269, XrefRangeStart = 467222, XrefRangeEnd = 467256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Object drivenByObject
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467269, XrefRangeEnd = 467277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_drivenByObject_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467277, XrefRangeEnd = 467285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_drivenByObject_Internal_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe DrivenTransformProperties drivenProperties
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467285, XrefRangeEnd = 467290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_drivenProperties_Internal_get_DrivenTransformProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(DrivenTransformProperties*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467290, XrefRangeEnd = 467295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_drivenProperties_Internal_set_Void_DrivenTransformProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool sendChildDimensionsChange
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467295, XrefRangeEnd = 467300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sendChildDimensionsChange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 467305, RefRangeEnd = 467307, XrefRangeStart = 467300, XrefRangeEnd = 467305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sendChildDimensionsChange_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 467312, RefRangeEnd = 467314, XrefRangeStart = 467307, XrefRangeEnd = 467312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForceUpdateRectTransforms()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 467320, RefRangeEnd = 467322, XrefRangeStart = 467314, XrefRangeEnd = 467320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetLocalCorners(Il2CppStructArray<Vector3> fourCornersArray)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fourCornersArray)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 467340, RefRangeEnd = 467348, XrefRangeStart = 467322, XrefRangeEnd = 467340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetWorldCorners(Il2CppStructArray<Vector3> fourCornersArray)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fourCornersArray)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 467396, RefRangeEnd = 467398, XrefRangeStart = 467348, XrefRangeEnd = 467396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInsetAndSizeFromParentEdge(
    RectTransform.Edge edge,
    float inset,
    float size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &edge;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SetInsetAndSizeFromParentEdge_Public_Void_Edge_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 467419, RefRangeEnd = 467439, XrefRangeStart = 467398, XrefRangeEnd = 467419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &axis;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467439, XrefRangeEnd = 467441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SendReapplyDrivenProperties(RectTransform driven)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) driven)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467441, XrefRangeEnd = 467492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Rect GetRectInParentSpace()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetRectInParentSpace_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 467514, RefRangeEnd = 467515, XrefRangeStart = 467492, XrefRangeEnd = 467514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2 GetParentSize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(753)]
  [CachedScanResults(RefRangeStart = 443820, RefRangeEnd = 444573, XrefRangeStart = 443820, XrefRangeEnd = 444573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RectTransform()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467515, XrefRangeEnd = 467517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_rect_Injected(System.IntPtr _unity_self, out Rect ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467517, XrefRangeEnd = 467519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_anchorMin_Injected(System.IntPtr _unity_self, out Vector2 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467519, XrefRangeEnd = 467521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_anchorMin_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467521, XrefRangeEnd = 467523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_anchorMax_Injected(System.IntPtr _unity_self, out Vector2 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467523, XrefRangeEnd = 467525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_anchorMax_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467525, XrefRangeEnd = 467527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_anchoredPosition_Injected(System.IntPtr _unity_self, out Vector2 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467527, XrefRangeEnd = 467529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_anchoredPosition_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467529, XrefRangeEnd = 467531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_sizeDelta_Injected(System.IntPtr _unity_self, out Vector2 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467531, XrefRangeEnd = 467533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_sizeDelta_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467533, XrefRangeEnd = 467535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_pivot_Injected(System.IntPtr _unity_self, out Vector2 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467535, XrefRangeEnd = 467537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_pivot_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467537, XrefRangeEnd = 467539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr get_drivenByObject_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_drivenByObject_Injected_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467539, XrefRangeEnd = 467541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_drivenByObject_Injected(System.IntPtr _unity_self, System.IntPtr value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_drivenByObject_Injected_Private_Static_Void_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467541, XrefRangeEnd = 467543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DrivenTransformProperties get_drivenProperties_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_drivenProperties_Injected_Private_Static_DrivenTransformProperties_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DrivenTransformProperties*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467543, XrefRangeEnd = 467545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_drivenProperties_Injected(
    System.IntPtr _unity_self,
    DrivenTransformProperties value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_drivenProperties_Injected_Private_Static_Void_IntPtr_DrivenTransformProperties_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467545, XrefRangeEnd = 467547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_sendChildDimensionsChange_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_get_sendChildDimensionsChange_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467547, XrefRangeEnd = 467549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_sendChildDimensionsChange_Injected(System.IntPtr _unity_self, bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_set_sendChildDimensionsChange_Injected_Private_Static_Void_IntPtr_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 467549, XrefRangeEnd = 467551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ForceUpdateRectTransforms_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectTransform.NativeMethodInfoPtr_ForceUpdateRectTransforms_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe RectTransform.ReapplyDrivenProperties reapplyDrivenProperties
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (RectTransform.ReapplyDrivenProperties) null : Il2CppObjectPool.Get<RectTransform.ReapplyDrivenProperties>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RectTransform.NativeFieldInfoPtr_reapplyDrivenProperties, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum Edge
  {
    Left,
    Right,
    Top,
    Bottom,
  }

  public enum Axis
  {
    Horizontal,
    Vertical,
  }

  public sealed class ReapplyDrivenProperties(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0;

    static ReapplyDrivenProperties()
    {
      Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, nameof (ReapplyDrivenProperties));
      RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100668705);
      RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr, 100668706);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 416874, RefRangeEnd = 416875, XrefRangeStart = 416874, XrefRangeEnd = 416875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReapplyDrivenProperties(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform.ReapplyDrivenProperties>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(RectTransform driven)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) driven)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectTransform.ReapplyDrivenProperties.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator RectTransform.ReapplyDrivenProperties([In] System.Action<RectTransform> obj0)
    {
      return DelegateSupport.ConvertDelegate<RectTransform.ReapplyDrivenProperties>((System.Delegate) obj0);
    }

    public static RectTransform.ReapplyDrivenProperties operator +(
      [In] RectTransform.ReapplyDrivenProperties obj0,
      [In] RectTransform.ReapplyDrivenProperties obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<RectTransform.ReapplyDrivenProperties>();
    }

    public static RectTransform.ReapplyDrivenProperties operator -(
      [In] RectTransform.ReapplyDrivenProperties obj0,
      [In] RectTransform.ReapplyDrivenProperties obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (RectTransform.ReapplyDrivenProperties) @delegate : @delegate.Cast<RectTransform.ReapplyDrivenProperties>();
    }
  }
}
