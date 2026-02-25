// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumetricParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VolumetricParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kExtinctionMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_distGlobalScale;
  private static readonly System.IntPtr NativeFieldInfoPtr_farDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_horizonHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_isGlobalFog0On;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogStartDistanceSqr0Ws;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogHeight0Ws;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAlbedo0;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogExtinction0;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAnisotropy0;
  private static readonly System.IntPtr NativeFieldInfoPtr_isGlobalFog1On;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogStartDistanceSqr1Ws;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogHeight1Ws;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAlbedo1;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogExtinction1;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalFogAnisotropy1;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_0;
  [FieldOffset(0)]
  public readonly bool on;
  [FieldOffset(4)]
  public readonly float distGlobalScale;
  [FieldOffset(8)]
  public readonly float farDistance;
  [FieldOffset(12)]
  public readonly float horizonHeight;
  [FieldOffset(16 /*0x10*/)]
  public readonly bool isGlobalFog0On;
  [FieldOffset(20)]
  public readonly float globalFogStartDistanceSqr0Ws;
  [FieldOffset(24)]
  public readonly float globalFogHeight0Ws;
  [FieldOffset(28)]
  public readonly Vector3 globalFogAlbedo0;
  [FieldOffset(40)]
  public readonly float globalFogExtinction0;
  [FieldOffset(44)]
  public readonly float globalFogAnisotropy0;
  [FieldOffset(48 /*0x30*/)]
  public readonly bool isGlobalFog1On;
  [FieldOffset(52)]
  public readonly float globalFogStartDistanceSqr1Ws;
  [FieldOffset(56)]
  public readonly float globalFogHeight1Ws;
  [FieldOffset(60)]
  public readonly Vector3 globalFogAlbedo1;
  [FieldOffset(72)]
  public readonly float globalFogExtinction1;
  [FieldOffset(76)]
  public readonly float globalFogAnisotropy1;

  static VolumetricParams()
  {
    Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumetricParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr);
    VolumetricParams.NativeFieldInfoPtr_kExtinctionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (kExtinctionMultiplier));
    VolumetricParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (on));
    VolumetricParams.NativeFieldInfoPtr_distGlobalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (distGlobalScale));
    VolumetricParams.NativeFieldInfoPtr_farDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (farDistance));
    VolumetricParams.NativeFieldInfoPtr_horizonHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (horizonHeight));
    VolumetricParams.NativeFieldInfoPtr_isGlobalFog0On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (isGlobalFog0On));
    VolumetricParams.NativeFieldInfoPtr_globalFogStartDistanceSqr0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogStartDistanceSqr0Ws));
    VolumetricParams.NativeFieldInfoPtr_globalFogHeight0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogHeight0Ws));
    VolumetricParams.NativeFieldInfoPtr_globalFogAlbedo0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogAlbedo0));
    VolumetricParams.NativeFieldInfoPtr_globalFogExtinction0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogExtinction0));
    VolumetricParams.NativeFieldInfoPtr_globalFogAnisotropy0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogAnisotropy0));
    VolumetricParams.NativeFieldInfoPtr_isGlobalFog1On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (isGlobalFog1On));
    VolumetricParams.NativeFieldInfoPtr_globalFogStartDistanceSqr1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogStartDistanceSqr1Ws));
    VolumetricParams.NativeFieldInfoPtr_globalFogHeight1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogHeight1Ws));
    VolumetricParams.NativeFieldInfoPtr_globalFogAlbedo1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogAlbedo1));
    VolumetricParams.NativeFieldInfoPtr_globalFogExtinction1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogExtinction1));
    VolumetricParams.NativeFieldInfoPtr_globalFogAnisotropy1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, nameof (globalFogAnisotropy1));
    VolumetricParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, 100663609);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926839, RefRangeEnd = 926840, XrefRangeStart = 926829, XrefRangeEnd = 926839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VolumetricParams(bool on, VolumeStack volumeStack)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &on;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VolumetricParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VolumetricParams>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe float kExtinctionMultiplier
  {
    get
    {
      float extinctionMultiplier;
      IL2CPP.il2cpp_field_static_get_value(VolumetricParams.NativeFieldInfoPtr_kExtinctionMultiplier, (void*) &extinctionMultiplier);
      return extinctionMultiplier;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VolumetricParams.NativeFieldInfoPtr_kExtinctionMultiplier, (void*) &value);
    }
  }
}
