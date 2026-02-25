// Decompiled with JetBrains decompiler
// Type: Cinemachine.ConfinerOven
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class ConfinerOven(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MinFrustumHeightWithBones;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPolygon;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MidPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Skeleton;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_FloatToIntScaler;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_IntToFloatScaler;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_MinStepSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PolygonRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AspectStretcher;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxComputationTimeForFullSkeletonBakeInSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_bakeProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Cache;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_List_1_List_1_Vector2_byref_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBakedSolution_Public_BakedSolution_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_BakingState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Private_set_Void_BakingState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_byref_List_1_List_1_Vector2_byref_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BakeConfiner_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Rect_byref_List_1_List_1_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_IntPoint_IntRect_PDM_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_byref_List_1_PolygonSolution_PDM_0;

  static ConfinerOven()
  {
    Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (ConfinerOven));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr);
    ConfinerOven.NativeFieldInfoPtr_m_MinFrustumHeightWithBones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_MinFrustumHeightWithBones));
    ConfinerOven.NativeFieldInfoPtr_m_OriginalPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_OriginalPolygon));
    ConfinerOven.NativeFieldInfoPtr_m_MidPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_MidPoint));
    ConfinerOven.NativeFieldInfoPtr_m_Skeleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_Skeleton));
    ConfinerOven.NativeFieldInfoPtr_k_FloatToIntScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (k_FloatToIntScaler));
    ConfinerOven.NativeFieldInfoPtr_k_IntToFloatScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (k_IntToFloatScaler));
    ConfinerOven.NativeFieldInfoPtr_k_MinStepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (k_MinStepSize));
    ConfinerOven.NativeFieldInfoPtr_m_PolygonRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_PolygonRect));
    ConfinerOven.NativeFieldInfoPtr_m_AspectStretcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_AspectStretcher));
    ConfinerOven.NativeFieldInfoPtr_m_MaxComputationTimeForFullSkeletonBakeInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_MaxComputationTimeForFullSkeletonBakeInSeconds));
    ConfinerOven.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, "<State>k__BackingField");
    ConfinerOven.NativeFieldInfoPtr_bakeProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (bakeProgress));
    ConfinerOven.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (m_Cache));
    ConfinerOven.NativeMethodInfoPtr__ctor_Public_Void_byref_List_1_List_1_Vector2_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664124);
    ConfinerOven.NativeMethodInfoPtr_GetBakedSolution_Public_BakedSolution_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664125);
    ConfinerOven.NativeMethodInfoPtr_get_State_Public_get_BakingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664126);
    ConfinerOven.NativeMethodInfoPtr_set_State_Private_set_Void_BakingState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664127);
    ConfinerOven.NativeMethodInfoPtr_Initialize_Private_Void_byref_List_1_List_1_Vector2_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664128 /*0x06000340*/);
    ConfinerOven.NativeMethodInfoPtr_BakeConfiner_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664129);
    ConfinerOven.NativeMethodInfoPtr_Method_Internal_Static_Rect_byref_List_1_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664130);
    ConfinerOven.NativeMethodInfoPtr_Method_Internal_Static_IntPoint_IntRect_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664131);
    ConfinerOven.NativeMethodInfoPtr_Method_Private_Void_byref_List_1_PolygonSolution_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, 100664132);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944347, XrefRangeEnd = 944355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ConfinerOven(
    [In] ref List<List<Vector2>> inputPath,
    [In] ref float aspectRatio,
    float maxFrustumHeight)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr))
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputPath);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aspectRatio;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFrustumHeight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr__ctor_Public_Void_byref_List_1_List_1_Vector2_byref_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    ref List<List<Vector2>> local = ref inputPath;
    System.IntPtr pointer = ptr;
    List<List<Vector2>> list = pointer == System.IntPtr.Zero ? (List<List<Vector2>>) null : new List<List<Vector2>>(pointer);
    local = list;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944381, RefRangeEnd = 944382, XrefRangeStart = 944355, XrefRangeEnd = 944381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ConfinerOven.BakedSolution GetBakedSolution(float frustumHeight)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &frustumHeight
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_GetBakedSolution_Public_BakedSolution_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ConfinerOven.BakedSolution) null : Il2CppObjectPool.Get<ConfinerOven.BakedSolution>(num3);
  }

  public unsafe ConfinerOven.BakingState State
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_get_State_Public_get_BakingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ConfinerOven.BakingState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_set_State_Private_set_Void_BakingState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944442, RefRangeEnd = 944443, XrefRangeStart = 944382, XrefRangeEnd = 944442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize(
    [In] ref List<List<Vector2>> inputPath,
    [In] ref float aspectRatio,
    float maxFrustumHeight)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputPath);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aspectRatio;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxFrustumHeight;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_Initialize_Private_Void_byref_List_1_List_1_Vector2_byref_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    ref List<List<Vector2>> local = ref inputPath;
    System.IntPtr pointer = ptr;
    List<List<Vector2>> list = pointer == System.IntPtr.Zero ? (List<List<Vector2>>) null : new List<List<Vector2>>(pointer);
    local = list;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944470, RefRangeEnd = 944471, XrefRangeStart = 944443, XrefRangeEnd = 944470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BakeConfiner(float maxComputationTimePerFrameInSeconds)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &maxComputationTimePerFrameInSeconds
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_BakeConfiner_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 944483, RefRangeEnd = 944484, XrefRangeStart = 944471, XrefRangeEnd = 944483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Rect Method_Internal_Static_Rect_byref_List_1_List_1_Vector2_0(
    [In] ref List<List<Vector2>> polygons)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) polygons);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_Method_Internal_Static_Rect_byref_List_1_List_1_Vector2_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref List<List<Vector2>> local = ref polygons;
    System.IntPtr pointer = ptr;
    List<List<Vector2>> list = pointer == System.IntPtr.Zero ? (List<List<Vector2>>) null : new List<List<Vector2>>(pointer);
    local = list;
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944484, XrefRangeEnd = 944485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ClipperLib.IntPoint Method_Internal_Static_IntPoint_IntRect_PDM_0(
    ClipperLib.IntRect bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &bounds
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_Method_Internal_Static_IntPoint_IntRect_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ClipperLib.IntPoint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944485, XrefRangeEnd = 944531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Method_Private_Void_byref_List_1_PolygonSolution_PDM_0(
    [In] ref List<ConfinerOven.PolygonSolution> solutions)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) solutions);
    System.IntPtr* numPtr3 = &ptr;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ConfinerOven.NativeMethodInfoPtr_Method_Private_Void_byref_List_1_PolygonSolution_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    ref List<ConfinerOven.PolygonSolution> local = ref solutions;
    System.IntPtr pointer = ptr;
    List<ConfinerOven.PolygonSolution> list = pointer == System.IntPtr.Zero ? (List<ConfinerOven.PolygonSolution>) null : new List<ConfinerOven.PolygonSolution>(pointer);
    local = list;
  }

  public unsafe float m_MinFrustumHeightWithBones
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_MinFrustumHeightWithBones));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_MinFrustumHeightWithBones)) = value;
    }
  }

  public unsafe List<List<ClipperLib.IntPoint>> m_OriginalPolygon
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_OriginalPolygon));
      return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_OriginalPolygon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClipperLib.IntPoint m_MidPoint
  {
    get
    {
      return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_MidPoint));
    }
    [param: In] set
    {
      *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_MidPoint)) = value;
    }
  }

  public unsafe List<List<ClipperLib.IntPoint>> m_Skeleton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_Skeleton));
      return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_Skeleton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe long k_FloatToIntScaler
  {
    get
    {
      long floatToIntScaler;
      IL2CPP.il2cpp_field_static_get_value(ConfinerOven.NativeFieldInfoPtr_k_FloatToIntScaler, (void*) &floatToIntScaler);
      return floatToIntScaler;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConfinerOven.NativeFieldInfoPtr_k_FloatToIntScaler, (void*) &value);
    }
  }

  public static unsafe float k_IntToFloatScaler
  {
    get
    {
      float intToFloatScaler;
      IL2CPP.il2cpp_field_static_get_value(ConfinerOven.NativeFieldInfoPtr_k_IntToFloatScaler, (void*) &intToFloatScaler);
      return intToFloatScaler;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConfinerOven.NativeFieldInfoPtr_k_IntToFloatScaler, (void*) &value);
    }
  }

  public static unsafe float k_MinStepSize
  {
    get
    {
      float kMinStepSize;
      IL2CPP.il2cpp_field_static_get_value(ConfinerOven.NativeFieldInfoPtr_k_MinStepSize, (void*) &kMinStepSize);
      return kMinStepSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ConfinerOven.NativeFieldInfoPtr_k_MinStepSize, (void*) &value);
    }
  }

  public unsafe Rect m_PolygonRect
  {
    get
    {
      return *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_PolygonRect));
    }
    [param: In] set
    {
      *(Rect*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_PolygonRect)) = value;
    }
  }

  public unsafe ConfinerOven.AspectStretcher m_AspectStretcher
  {
    get
    {
      return *(ConfinerOven.AspectStretcher*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_AspectStretcher));
    }
    [param: In] set
    {
      *(ConfinerOven.AspectStretcher*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_AspectStretcher)) = value;
    }
  }

  public unsafe float m_MaxComputationTimeForFullSkeletonBakeInSeconds
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_MaxComputationTimeForFullSkeletonBakeInSeconds));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_MaxComputationTimeForFullSkeletonBakeInSeconds)) = value;
    }
  }

  public unsafe ConfinerOven.BakingState _State_k__BackingField
  {
    get
    {
      return *(ConfinerOven.BakingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr__State_k__BackingField));
    }
    [param: In] set
    {
      *(ConfinerOven.BakingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr__State_k__BackingField)) = value;
    }
  }

  public unsafe float bakeProgress
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_bakeProgress));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_bakeProgress)) = value;
    }
  }

  public ConfinerOven.BakingStateCache m_Cache
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_Cache);
      return new ConfinerOven.BakingStateCache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.NativeFieldInfoPtr_m_Cache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public class BakedSolution(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_FrustumSizeIntSpace;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AspectStretcher;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HasBones;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SqrPolygonDiagonal;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalPolygon;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Solution;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_Rect_List_1_List_1_IntPoint_List_1_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConfinePoint_Public_Vector2_byref_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindIntersection_Private_Static_Int32_byref_IntPoint_byref_IntPoint_byref_IntPoint_byref_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_IntPoint_IntPoint_IntPoint_Single_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_IntPoint_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_IntPoint_IntPoint_IntPoint_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Boolean_IntPoint_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Double_IntPoint_IntPoint_PDM_0;

    static BakedSolution()
    {
      Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (BakedSolution));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr);
      ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_FrustumSizeIntSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, nameof (m_FrustumSizeIntSpace));
      ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_AspectStretcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, nameof (m_AspectStretcher));
      ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_HasBones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, nameof (m_HasBones));
      ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_SqrPolygonDiagonal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, nameof (m_SqrPolygonDiagonal));
      ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_OriginalPolygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, nameof (m_OriginalPolygon));
      ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_Solution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, nameof (m_Solution));
      ConfinerOven.BakedSolution.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_Rect_List_1_List_1_IntPoint_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664133);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664134);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_ConfinePoint_Public_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664135);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_FindIntersection_Private_Static_Int32_byref_IntPoint_byref_IntPoint_byref_IntPoint_byref_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664136);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Internal_Static_IntPoint_IntPoint_IntPoint_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664137);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Private_Boolean_IntPoint_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664138);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Internal_Static_Single_IntPoint_IntPoint_IntPoint_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664139);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Private_Boolean_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664140);
      ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Internal_Static_Double_IntPoint_IntPoint_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, 100664141);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944260, XrefRangeEnd = 944261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BakedSolution(
      float aspectRatio,
      float frustumHeight,
      bool hasBones,
      Rect polygonBounds,
      List<List<ClipperLib.IntPoint>> originalPolygon,
      List<List<ClipperLib.IntPoint>> solution)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &aspectRatio;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &frustumHeight;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hasBones;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &polygonBounds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) originalPolygon);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) solution);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_Rect_List_1_List_1_IntPoint_List_1_List_1_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944261, RefRangeEnd = 944262, XrefRangeStart = 944261, XrefRangeEnd = 944261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValid()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944301, RefRangeEnd = 944302, XrefRangeStart = 944262, XrefRangeEnd = 944301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Vector2 ConfinePoint([In] ref Vector2 pointToConfine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) ref pointToConfine
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_ConfinePoint_Public_Vector2_byref_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944302, RefRangeEnd = 944303, XrefRangeStart = 944302, XrefRangeEnd = 944302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int FindIntersection(
      [In] ref ClipperLib.IntPoint p1,
      [In] ref ClipperLib.IntPoint p2,
      [In] ref ClipperLib.IntPoint p3,
      [In] ref ClipperLib.IntPoint p4)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref p1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref p2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref p3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref p4;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_FindIntersection_Private_Static_Int32_byref_IntPoint_byref_IntPoint_byref_IntPoint_byref_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944303, XrefRangeEnd = 944305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ClipperLib.IntPoint Method_Internal_Static_IntPoint_IntPoint_IntPoint_Single_PDM_0(
      ClipperLib.IntPoint a,
      ClipperLib.IntPoint b,
      float lerp)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &lerp;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Internal_Static_IntPoint_IntPoint_IntPoint_Single_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipperLib.IntPoint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944305, XrefRangeEnd = 944319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Method_Private_Boolean_IntPoint_PDM_0(ClipperLib.IntPoint point)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &point
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Private_Boolean_IntPoint_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe float Method_Internal_Static_Single_IntPoint_IntPoint_IntPoint_PDM_0(
      ClipperLib.IntPoint point,
      ClipperLib.IntPoint s0,
      ClipperLib.IntPoint s1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &point;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &s0;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &s1;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Internal_Static_Single_IntPoint_IntPoint_IntPoint_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944337, RefRangeEnd = 944338, XrefRangeStart = 944319, XrefRangeEnd = 944337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Method_Private_Boolean_IntPoint_IntPoint_0(
      ClipperLib.IntPoint l1,
      ClipperLib.IntPoint l2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &l1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &l2;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Private_Boolean_IntPoint_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe double Method_Internal_Static_Double_IntPoint_IntPoint_PDM_0(
      ClipperLib.IntPoint point1,
      ClipperLib.IntPoint point2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &point1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &point2;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.NativeMethodInfoPtr_Method_Internal_Static_Double_IntPoint_IntPoint_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe float m_FrustumSizeIntSpace
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_FrustumSizeIntSpace));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_FrustumSizeIntSpace)) = value;
      }
    }

    public unsafe ConfinerOven.AspectStretcher m_AspectStretcher
    {
      get
      {
        return *(ConfinerOven.AspectStretcher*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_AspectStretcher));
      }
      [param: In] set
      {
        *(ConfinerOven.AspectStretcher*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_AspectStretcher)) = value;
      }
    }

    public unsafe bool m_HasBones
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_HasBones));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_HasBones)) = value;
      }
    }

    public unsafe double m_SqrPolygonDiagonal
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_SqrPolygonDiagonal));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_SqrPolygonDiagonal)) = value;
      }
    }

    public unsafe List<List<ClipperLib.IntPoint>> m_OriginalPolygon
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_OriginalPolygon));
        return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_OriginalPolygon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<List<ClipperLib.IntPoint>> m_Solution
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_Solution));
        return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.NativeFieldInfoPtr_m_Solution), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("Cinemachine.ConfinerOven+BakedSolution+<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_point;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ConfinePoint_b__4_Internal_Boolean_List_1_IntPoint_0;

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<ConfinerOven.BakedSolution.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfinerOven.BakedSolution>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfinerOven.BakedSolution.__c__DisplayClass9_0>.NativeClassPtr);
        ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakedSolution.__c__DisplayClass9_0>.NativeClassPtr, nameof (point));
        ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution.__c__DisplayClass9_0>.NativeClassPtr, 100664142);
        ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeMethodInfoPtr__ConfinePoint_b__4_Internal_Boolean_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.BakedSolution.__c__DisplayClass9_0>.NativeClassPtr, 100664143);
      }

      [CallerCount(3004)]
      [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfinerOven.BakedSolution.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944259, XrefRangeEnd = 944260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _ConfinePoint_b__4(List<ClipperLib.IntPoint> t)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) t)
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeMethodInfoPtr__ConfinePoint_b__4_Internal_Boolean_List_1_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public unsafe ClipperLib.IntPoint point
      {
        get
        {
          return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeFieldInfoPtr_point));
        }
        [param: In] set
        {
          *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakedSolution.__c__DisplayClass9_0.NativeFieldInfoPtr_point)) = value;
        }
      }
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct AspectStretcher
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Aspect_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_InverseAspect;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CenterX;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Aspect_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Stretch_Public_Vector2_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unstretch_Public_Vector2_Vector2_0;
    [FieldOffset(0)]
    public readonly float _Aspect_k__BackingField;
    [FieldOffset(4)]
    public readonly float m_InverseAspect;
    [FieldOffset(8)]
    public readonly float m_CenterX;

    static AspectStretcher()
    {
      Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (AspectStretcher));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr);
      ConfinerOven.AspectStretcher.NativeFieldInfoPtr__Aspect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, "<Aspect>k__BackingField");
      ConfinerOven.AspectStretcher.NativeFieldInfoPtr_m_InverseAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, nameof (m_InverseAspect));
      ConfinerOven.AspectStretcher.NativeFieldInfoPtr_m_CenterX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, nameof (m_CenterX));
      ConfinerOven.AspectStretcher.NativeMethodInfoPtr_get_Aspect_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, 100664144 /*0x06000350*/);
      ConfinerOven.AspectStretcher.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, 100664145);
      ConfinerOven.AspectStretcher.NativeMethodInfoPtr_Stretch_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, 100664146);
      ConfinerOven.AspectStretcher.NativeMethodInfoPtr_Unstretch_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, 100664147);
    }

    public unsafe float Aspect
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.AspectStretcher.NativeMethodInfoPtr_get_Aspect_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    public unsafe AspectStretcher(float aspect, float centerX)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &aspect;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &centerX;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ConfinerOven.AspectStretcher.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe Vector2 Stretch(Vector2 p)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &p
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.AspectStretcher.NativeMethodInfoPtr_Stretch_Public_Vector2_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe Vector2 Unstretch(Vector2 p)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &p
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.AspectStretcher.NativeMethodInfoPtr_Unstretch_Public_Vector2_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfinerOven.AspectStretcher>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class PolygonSolution : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_polygons;
    private static readonly System.IntPtr NativeFieldInfoPtr_frustumHeight;
    private static readonly System.IntPtr NativeMethodInfoPtr_StateChanged_Public_Boolean_byref_List_1_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

    static PolygonSolution()
    {
      Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (PolygonSolution));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr);
      ConfinerOven.PolygonSolution.NativeFieldInfoPtr_polygons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, nameof (polygons));
      ConfinerOven.PolygonSolution.NativeFieldInfoPtr_frustumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, nameof (frustumHeight));
      ConfinerOven.PolygonSolution.NativeMethodInfoPtr_StateChanged_Public_Boolean_byref_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, 100664148);
      ConfinerOven.PolygonSolution.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, 100664149);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 944346, RefRangeEnd = 944347, XrefRangeStart = 944338, XrefRangeEnd = 944346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool StateChanged([In] ref List<List<ClipperLib.IntPoint>> paths)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) paths);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.PolygonSolution.NativeMethodInfoPtr_StateChanged_Public_Boolean_byref_List_1_List_1_IntPoint_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      ref List<List<ClipperLib.IntPoint>> local = ref paths;
      System.IntPtr pointer = ptr;
      List<List<ClipperLib.IntPoint>> list = pointer == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : new List<List<ClipperLib.IntPoint>>(pointer);
      local = list;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe bool IsNull
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 442769, RefRangeEnd = 442777, XrefRangeStart = 442769, XrefRangeEnd = 442777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ConfinerOven.PolygonSolution.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public PolygonSolution(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public PolygonSolution()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr))
    {
    }

    public unsafe List<List<ClipperLib.IntPoint>> polygons
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.PolygonSolution.NativeFieldInfoPtr_polygons));
        return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.PolygonSolution.NativeFieldInfoPtr_polygons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float frustumHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.PolygonSolution.NativeFieldInfoPtr_frustumHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.PolygonSolution.NativeFieldInfoPtr_frustumHeight)) = value;
      }
    }
  }

  public enum BakingState
  {
    BAKING,
    BAKED,
    TIMEOUT,
  }

  public sealed class BakingStateCache : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_offsetter;
    private static readonly System.IntPtr NativeFieldInfoPtr_solutions;
    private static readonly System.IntPtr NativeFieldInfoPtr_rightCandidate;
    private static readonly System.IntPtr NativeFieldInfoPtr_leftCandidate;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxCandidate;
    private static readonly System.IntPtr NativeFieldInfoPtr_stepSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxFrustumHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_userSetMaxFrustumHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_theoriticalMaxFrustumHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_currentFrustumHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_bakeTime;

    static BakingStateCache()
    {
      Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfinerOven>.NativeClassPtr, nameof (BakingStateCache));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr);
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_offsetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (offsetter));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_solutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (solutions));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_rightCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (rightCandidate));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_leftCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (leftCandidate));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_maxCandidate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (maxCandidate));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_stepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (stepSize));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_maxFrustumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (maxFrustumHeight));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_userSetMaxFrustumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (userSetMaxFrustumHeight));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_theoriticalMaxFrustumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (theoriticalMaxFrustumHeight));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_currentFrustumHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (currentFrustumHeight));
      ConfinerOven.BakingStateCache.NativeFieldInfoPtr_bakeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr, nameof (bakeTime));
    }

    public BakingStateCache(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BakingStateCache()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfinerOven.BakingStateCache>.NativeClassPtr))
    {
    }

    public unsafe ClipperLib.ClipperOffset offsetter
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_offsetter));
        return num == System.IntPtr.Zero ? (ClipperLib.ClipperOffset) null : Il2CppObjectPool.Get<ClipperLib.ClipperOffset>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_offsetter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ConfinerOven.PolygonSolution> solutions
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_solutions));
        return num == System.IntPtr.Zero ? (List<ConfinerOven.PolygonSolution>) null : Il2CppObjectPool.Get<List<ConfinerOven.PolygonSolution>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_solutions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public ConfinerOven.PolygonSolution rightCandidate
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_rightCandidate);
        return new ConfinerOven.PolygonSolution(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_rightCandidate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public ConfinerOven.PolygonSolution leftCandidate
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_leftCandidate);
        return new ConfinerOven.PolygonSolution(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_leftCandidate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfinerOven.PolygonSolution>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<List<ClipperLib.IntPoint>> maxCandidate
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_maxCandidate));
        return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_maxCandidate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float stepSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_stepSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_stepSize)) = value;
      }
    }

    public unsafe float maxFrustumHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_maxFrustumHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_maxFrustumHeight)) = value;
      }
    }

    public unsafe float userSetMaxFrustumHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_userSetMaxFrustumHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_userSetMaxFrustumHeight)) = value;
      }
    }

    public unsafe float theoriticalMaxFrustumHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_theoriticalMaxFrustumHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_theoriticalMaxFrustumHeight)) = value;
      }
    }

    public unsafe float currentFrustumHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_currentFrustumHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_currentFrustumHeight)) = value;
      }
    }

    public unsafe float bakeTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_bakeTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConfinerOven.BakingStateCache.NativeFieldInfoPtr_bakeTime)) = value;
      }
    }
  }
}
