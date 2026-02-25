// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowCullingDataBuilder
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ShadowCullingDataBuilder(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__perLightInfoList;
  private static readonly System.IntPtr NativeFieldInfoPtr__splitDataList;
  private static readonly System.IntPtr NativeFieldInfoPtr__totalSplitDataCount;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddSplitData_Public_Void_byref_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPerLightInfo_Public_Void_Int32_LightType_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeShadowCasterCullingInfos_Public_ShadowCastersCullingInfos_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ShadowCullingDataBuilder()
  {
    Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowCullingDataBuilder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr);
    ShadowCullingDataBuilder.NativeFieldInfoPtr__perLightInfoList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, nameof (_perLightInfoList));
    ShadowCullingDataBuilder.NativeFieldInfoPtr__splitDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, nameof (_splitDataList));
    ShadowCullingDataBuilder.NativeFieldInfoPtr__totalSplitDataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, nameof (_totalSplitDataCount));
    ShadowCullingDataBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664044);
    ShadowCullingDataBuilder.NativeMethodInfoPtr_Begin_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664045);
    ShadowCullingDataBuilder.NativeMethodInfoPtr_AddSplitData_Public_Void_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664046);
    ShadowCullingDataBuilder.NativeMethodInfoPtr_AddPerLightInfo_Public_Void_Int32_LightType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664047);
    ShadowCullingDataBuilder.NativeMethodInfoPtr_MakeShadowCasterCullingInfos_Public_ShadowCastersCullingInfos_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664048 /*0x060002F0*/);
    ShadowCullingDataBuilder.NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664049);
    ShadowCullingDataBuilder.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr, 100664050);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowCullingDataBuilder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCullingDataBuilder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932143, XrefRangeEnd = 932150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Begin(int visibleLightCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &visibleLightCount
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr_Begin_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 932150, RefRangeEnd = 932153, XrefRangeStart = 932150, XrefRangeEnd = 932150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddSplitData([In] ref ShadowSplitData splitData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref splitData
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr_AddSplitData_Public_Void_byref_ShadowSplitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 932159, RefRangeEnd = 932160, XrefRangeStart = 932153, XrefRangeEnd = 932159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPerLightInfo(int visibleLightIndex, LightType lightType, int splitCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &visibleLightIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lightType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &splitCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr_AddPerLightInfo_Public_Void_Int32_LightType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932160, XrefRangeEnd = 932163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowCastersCullingInfos MakeShadowCasterCullingInfos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr_MakeShadowCasterCullingInfos_Public_ShadowCastersCullingInfos_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new ShadowCastersCullingInfos(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 932163, XrefRangeEnd = 932169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void End()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowCullingDataBuilder.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public NativeArray<LightShadowCasterCullingInfo> _perLightInfoList
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCullingDataBuilder.NativeFieldInfoPtr__perLightInfoList);
      return new NativeArray<LightShadowCasterCullingInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LightShadowCasterCullingInfo>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCullingDataBuilder.NativeFieldInfoPtr__perLightInfoList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LightShadowCasterCullingInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<ShadowSplitData> _splitDataList
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCullingDataBuilder.NativeFieldInfoPtr__splitDataList);
      return new NativeArray<ShadowSplitData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ShadowSplitData>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCullingDataBuilder.NativeFieldInfoPtr__splitDataList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ShadowSplitData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe int _totalSplitDataCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCullingDataBuilder.NativeFieldInfoPtr__totalSplitDataCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCullingDataBuilder.NativeFieldInfoPtr__totalSplitDataCount)) = value;
    }
  }
}
