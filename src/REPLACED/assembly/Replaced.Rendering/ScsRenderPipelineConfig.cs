// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ScsRenderPipelineConfig
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class ScsRenderPipelineConfig(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_clusteredGridSize3D;
  private static readonly IntPtr NativeFieldInfoPtr_msaaMode;
  private static readonly IntPtr NativeMethodInfoPtr_get_ClusteredGridSize3D_Public_get_Vector3Int_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ScsRenderPipelineConfig()
  {
    Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ScsRenderPipelineConfig));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr);
    ScsRenderPipelineConfig.NativeFieldInfoPtr_clusteredGridSize3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr, nameof (clusteredGridSize3D));
    ScsRenderPipelineConfig.NativeFieldInfoPtr_msaaMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr, nameof (msaaMode));
    ScsRenderPipelineConfig.NativeMethodInfoPtr_get_ClusteredGridSize3D_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr, 100664334 /*0x0600040E*/);
    ScsRenderPipelineConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr, 100664335 /*0x0600040F*/);
  }

  public unsafe Vector3Int ClusteredGridSize3D
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineConfig.NativeMethodInfoPtr_get_ClusteredGridSize3D_Public_get_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936498, XrefRangeEnd = 936499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScsRenderPipelineConfig()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScsRenderPipelineConfig>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScsRenderPipelineConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3Int clusteredGridSize3D
  {
    get
    {
      return *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineConfig.NativeFieldInfoPtr_clusteredGridSize3D));
    }
    [param: In] set
    {
      *(Vector3Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineConfig.NativeFieldInfoPtr_clusteredGridSize3D)) = value;
    }
  }

  public unsafe MsaaMode msaaMode
  {
    get
    {
      return *(MsaaMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineConfig.NativeFieldInfoPtr_msaaMode));
    }
    [param: In] set
    {
      *(MsaaMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScsRenderPipelineConfig.NativeFieldInfoPtr_msaaMode)) = value;
    }
  }
}
