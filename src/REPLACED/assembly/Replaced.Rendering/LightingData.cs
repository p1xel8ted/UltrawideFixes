// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LightingData
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

public sealed class LightingData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kPunctualLightCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kLineLightCountLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kMaxShadowSplitCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPunctualLightShadowMapResolution;
  private static readonly System.IntPtr NativeFieldInfoPtr_kPunctualLightsPossibleShadowMapCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__directionalLightsData;
  private static readonly System.IntPtr NativeFieldInfoPtr__punctualLightsData;
  private static readonly System.IntPtr NativeFieldInfoPtr__lineLightsData;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture2DArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DirectionalLightListIsFull_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DirectionalLightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CloudDirectionalLightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MainLightCastsShadows_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MainLightShadowData_Public_get_MainLightShadowData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LineLightListIsFull_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LineLightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PunctualLightListIsFull_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PunctualLightCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PunctualLightTexShadowMapCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PointLightWithShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PointLightWithCacheableShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpotlightWithShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpotlightWithCacheableShadowCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpotlightWithPatternCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PunctualLightsData_Public_get_PunctualLightsV2Data_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PunctualLightShadowMapResolution_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPunctualLightTexShadowMapData_Public_PunctualLightTexShadowMapData_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCameraEmbeddedLight_Public_Void_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddDirectionalLight_Public_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_Single_ShadowCullingDataBuilder_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddLineLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPunctualLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_LightingStageErrors_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginWrite_Public_Void_SceneFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMainLightShadowSettings_Public_Void_byref_ShadowMappingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static LightingData()
  {
    Il2CppClassPointerStore<LightingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LightingData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightingData>.NativeClassPtr);
    LightingData.NativeFieldInfoPtr_kPunctualLightCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (kPunctualLightCountLimit));
    LightingData.NativeFieldInfoPtr_kLineLightCountLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (kLineLightCountLimit));
    LightingData.NativeFieldInfoPtr_kMaxShadowSplitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (kMaxShadowSplitCount));
    LightingData.NativeFieldInfoPtr_kPunctualLightShadowMapResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (kPunctualLightShadowMapResolution));
    LightingData.NativeFieldInfoPtr_kPunctualLightsPossibleShadowMapCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (kPunctualLightsPossibleShadowMapCount));
    LightingData.NativeFieldInfoPtr__directionalLightsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (_directionalLightsData));
    LightingData.NativeFieldInfoPtr__punctualLightsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (_punctualLightsData));
    LightingData.NativeFieldInfoPtr__lineLightsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightingData>.NativeClassPtr, nameof (_lineLightsData));
    LightingData.NativeMethodInfoPtr__ctor_Public_Void_Texture2DArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663934);
    LightingData.NativeMethodInfoPtr_get_DirectionalLightListIsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663935);
    LightingData.NativeMethodInfoPtr_get_DirectionalLightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663936 /*0x06000280*/);
    LightingData.NativeMethodInfoPtr_get_CloudDirectionalLightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663937);
    LightingData.NativeMethodInfoPtr_get_MainLightCastsShadows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663938);
    LightingData.NativeMethodInfoPtr_get_MainLightShadowData_Public_get_MainLightShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663939);
    LightingData.NativeMethodInfoPtr_get_LineLightListIsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663940);
    LightingData.NativeMethodInfoPtr_get_LineLightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663941);
    LightingData.NativeMethodInfoPtr_get_PunctualLightListIsFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663942);
    LightingData.NativeMethodInfoPtr_get_PunctualLightCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663943);
    LightingData.NativeMethodInfoPtr_get_PunctualLightTexShadowMapCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663944);
    LightingData.NativeMethodInfoPtr_get_PointLightWithShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663945);
    LightingData.NativeMethodInfoPtr_get_PointLightWithCacheableShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663946);
    LightingData.NativeMethodInfoPtr_get_SpotlightWithShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663947);
    LightingData.NativeMethodInfoPtr_get_SpotlightWithCacheableShadowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663948);
    LightingData.NativeMethodInfoPtr_get_SpotlightWithPatternCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663949);
    LightingData.NativeMethodInfoPtr_get_PunctualLightsData_Public_get_PunctualLightsV2Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663950);
    LightingData.NativeMethodInfoPtr_get_PunctualLightShadowMapResolution_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663951);
    LightingData.NativeMethodInfoPtr_GetPunctualLightTexShadowMapData_Public_PunctualLightTexShadowMapData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663952 /*0x06000290*/);
    LightingData.NativeMethodInfoPtr_AddCameraEmbeddedLight_Public_Void_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663953);
    LightingData.NativeMethodInfoPtr_AddDirectionalLight_Public_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_Single_ShadowCullingDataBuilder_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663954);
    LightingData.NativeMethodInfoPtr_AddLineLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663955);
    LightingData.NativeMethodInfoPtr_AddPunctualLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_LightingStageErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663956);
    LightingData.NativeMethodInfoPtr_BeginWrite_Public_Void_SceneFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663957);
    LightingData.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663958);
    LightingData.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663959);
    LightingData.NativeMethodInfoPtr_SetMainLightShadowSettings_Public_Void_byref_ShadowMappingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663960);
    LightingData.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightingData>.NativeClassPtr, 100663961);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931130, XrefRangeEnd = 931146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightingData(Texture2DArray texWhiteTexture2DArray)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightingData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texWhiteTexture2DArray)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr__ctor_Public_Void_Texture2DArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool DirectionalLightListIsFull
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_DirectionalLightListIsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int DirectionalLightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_DirectionalLightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int CloudDirectionalLightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_CloudDirectionalLightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool MainLightCastsShadows
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 931146, RefRangeEnd = 931149, XrefRangeStart = 931146, XrefRangeEnd = 931146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_MainLightCastsShadows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MainLightShadowData MainLightShadowData
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_MainLightShadowData_Public_get_MainLightShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new MainLightShadowData(pointer);
    }
  }

  public unsafe bool LineLightListIsFull
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_LineLightListIsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int LineLightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_LineLightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool PunctualLightListIsFull
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PunctualLightListIsFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int PunctualLightCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PunctualLightCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int PunctualLightTexShadowMapCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PunctualLightTexShadowMapCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int PointLightWithShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PointLightWithShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int PointLightWithCacheableShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PointLightWithCacheableShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SpotlightWithShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_SpotlightWithShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SpotlightWithCacheableShadowCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_SpotlightWithCacheableShadowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SpotlightWithPatternCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_SpotlightWithPatternCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe PunctualLightsV2Data PunctualLightsData
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PunctualLightsData_Public_get_PunctualLightsV2Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (PunctualLightsV2Data) null : Il2CppObjectPool.Get<PunctualLightsV2Data>(num3);
    }
  }

  public unsafe int PunctualLightShadowMapResolution
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_get_PunctualLightShadowMapResolution_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe PunctualLightTexShadowMapData GetPunctualLightTexShadowMapData(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_GetPunctualLightTexShadowMapData_Public_PunctualLightTexShadowMapData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new PunctualLightTexShadowMapData(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931149, XrefRangeEnd = 931150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCameraEmbeddedLight(float intensity, Vector3 negForwardWs)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &intensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &negForwardWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_AddCameraEmbeddedLight_Public_Void_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931150, XrefRangeEnd = 931152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddDirectionalLight(
    int vlIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    [In] ref CullingResults cullingResults,
    float shadowNearPlaneDistance,
    ShadowCullingDataBuilder shadowCullingDataBuilder,
    LightingStageErrors errors)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowNearPlaneDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) errors);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_AddDirectionalLight_Public_Void_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_Single_ShadowCullingDataBuilder_LightingStageErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931152, XrefRangeEnd = 931154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddLineLight(int vlIndex, [In] ref VisibleLight vl, LightExtraData led)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_AddLineLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931154, XrefRangeEnd = 931156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int AddPunctualLight(
    int vlIndex,
    [In] ref VisibleLight vl,
    LightExtraData led,
    [In] ref CullingResults cullingResults,
    ShadowCullingDataBuilder shadowCullingDataBuilder,
    LightingStageErrors errors)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &vlIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref vl;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) led);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shadowCullingDataBuilder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) errors);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_AddPunctualLight_Public_Int32_Int32_byref_VisibleLight_LightExtraData_byref_CullingResults_ShadowCullingDataBuilder_LightingStageErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931156, XrefRangeEnd = 931157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginWrite(SceneFrame frame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_BeginWrite_Public_Void_SceneFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 931183, RefRangeEnd = 931184, XrefRangeStart = 931157, XrefRangeEnd = 931183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndWrite(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_EndWrite_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931184, XrefRangeEnd = 931201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bind(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931201, XrefRangeEnd = 931203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetMainLightShadowSettings([In] ref ShadowMappingParams shadowMapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref shadowMapping
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_SetMainLightShadowSettings_Public_Void_byref_ShadowMappingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 931203, XrefRangeEnd = 931204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightingData.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kPunctualLightCountLimit
  {
    get
    {
      int punctualLightCountLimit;
      IL2CPP.il2cpp_field_static_get_value(LightingData.NativeFieldInfoPtr_kPunctualLightCountLimit, (void*) &punctualLightCountLimit);
      return punctualLightCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingData.NativeFieldInfoPtr_kPunctualLightCountLimit, (void*) &value);
    }
  }

  public static unsafe int kLineLightCountLimit
  {
    get
    {
      int lineLightCountLimit;
      IL2CPP.il2cpp_field_static_get_value(LightingData.NativeFieldInfoPtr_kLineLightCountLimit, (void*) &lineLightCountLimit);
      return lineLightCountLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingData.NativeFieldInfoPtr_kLineLightCountLimit, (void*) &value);
    }
  }

  public static unsafe int kMaxShadowSplitCount
  {
    get
    {
      int shadowSplitCount;
      IL2CPP.il2cpp_field_static_get_value(LightingData.NativeFieldInfoPtr_kMaxShadowSplitCount, (void*) &shadowSplitCount);
      return shadowSplitCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingData.NativeFieldInfoPtr_kMaxShadowSplitCount, (void*) &value);
    }
  }

  public static unsafe int kPunctualLightShadowMapResolution
  {
    get
    {
      int shadowMapResolution;
      IL2CPP.il2cpp_field_static_get_value(LightingData.NativeFieldInfoPtr_kPunctualLightShadowMapResolution, (void*) &shadowMapResolution);
      return shadowMapResolution;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingData.NativeFieldInfoPtr_kPunctualLightShadowMapResolution, (void*) &value);
    }
  }

  public static unsafe int kPunctualLightsPossibleShadowMapCount
  {
    get
    {
      int possibleShadowMapCount;
      IL2CPP.il2cpp_field_static_get_value(LightingData.NativeFieldInfoPtr_kPunctualLightsPossibleShadowMapCount, (void*) &possibleShadowMapCount);
      return possibleShadowMapCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LightingData.NativeFieldInfoPtr_kPunctualLightsPossibleShadowMapCount, (void*) &value);
    }
  }

  public unsafe DirectionalLightsV2Data _directionalLightsData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingData.NativeFieldInfoPtr__directionalLightsData));
      return num == System.IntPtr.Zero ? (DirectionalLightsV2Data) null : Il2CppObjectPool.Get<DirectionalLightsV2Data>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingData.NativeFieldInfoPtr__directionalLightsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PunctualLightsV2Data _punctualLightsData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingData.NativeFieldInfoPtr__punctualLightsData));
      return num == System.IntPtr.Zero ? (PunctualLightsV2Data) null : Il2CppObjectPool.Get<PunctualLightsV2Data>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingData.NativeFieldInfoPtr__punctualLightsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LineLightsV2Data _lineLightsData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightingData.NativeFieldInfoPtr__lineLightsData));
      return num == System.IntPtr.Zero ? (LineLightsV2Data) null : Il2CppObjectPool.Get<LineLightsV2Data>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightingData.NativeFieldInfoPtr__lineLightsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
