// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FrameStatsReport
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class FrameStatsReport(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LightingStageStats_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DecalStageStats_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AverageDeltaTimeMs_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LightingStageStats_Public_get_Nullable_1_LightingStageFrameStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LightingStageStats_Public_set_Void_Nullable_1_LightingStageFrameStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DecalStageStats_Public_get_Nullable_1_DecalStageFrameStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DecalStageStats_Public_set_Void_Nullable_1_DecalStageFrameStats_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartFrame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FrameStatsReport()
  {
    Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FrameStatsReport));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr);
    FrameStatsReport.NativeFieldInfoPtr__LightingStageStats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, "<LightingStageStats>k__BackingField");
    FrameStatsReport.NativeFieldInfoPtr__DecalStageStats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, "<DecalStageStats>k__BackingField");
    FrameStatsReport.NativeMethodInfoPtr_get_AverageDeltaTimeMs_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663469 /*0x060000AD*/);
    FrameStatsReport.NativeMethodInfoPtr_get_LightingStageStats_Public_get_Nullable_1_LightingStageFrameStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663470 /*0x060000AE*/);
    FrameStatsReport.NativeMethodInfoPtr_set_LightingStageStats_Public_set_Void_Nullable_1_LightingStageFrameStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663471 /*0x060000AF*/);
    FrameStatsReport.NativeMethodInfoPtr_get_DecalStageStats_Public_get_Nullable_1_DecalStageFrameStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663472 /*0x060000B0*/);
    FrameStatsReport.NativeMethodInfoPtr_set_DecalStageStats_Public_set_Void_Nullable_1_DecalStageFrameStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663473 /*0x060000B1*/);
    FrameStatsReport.NativeMethodInfoPtr_StartFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663474 /*0x060000B2*/);
    FrameStatsReport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr, 100663475 /*0x060000B3*/);
  }

  public unsafe float AverageDeltaTimeMs
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr_get_AverageDeltaTimeMs_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Nullable<LightingStageFrameStats> LightingStageStats
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr_get_LightingStageStats_Public_get_Nullable_1_LightingStageFrameStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<LightingStageFrameStats>(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr_set_LightingStageStats_Public_set_Void_Nullable_1_LightingStageFrameStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<DecalStageFrameStats> DecalStageStats
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr_get_DecalStageStats_Public_get_Nullable_1_DecalStageFrameStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<DecalStageFrameStats>(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr_set_DecalStageStats_Public_set_Void_Nullable_1_DecalStageFrameStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr_StartFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FrameStatsReport()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrameStatsReport>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameStatsReport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Nullable<LightingStageFrameStats> _LightingStageStats_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameStatsReport.NativeFieldInfoPtr__LightingStageStats_k__BackingField);
      return new Il2CppSystem.Nullable<LightingStageFrameStats>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<LightingStageFrameStats>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameStatsReport.NativeFieldInfoPtr__LightingStageStats_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<LightingStageFrameStats>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<DecalStageFrameStats> _DecalStageStats_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameStatsReport.NativeFieldInfoPtr__DecalStageStats_k__BackingField);
      return new Il2CppSystem.Nullable<DecalStageFrameStats>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<DecalStageFrameStats>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FrameStatsReport.NativeFieldInfoPtr__DecalStageStats_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<DecalStageFrameStats>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
