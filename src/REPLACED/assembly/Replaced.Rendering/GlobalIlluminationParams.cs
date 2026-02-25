// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GlobalIlluminationParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GlobalIlluminationParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_doGlobalIllumination;
  private static readonly System.IntPtr NativeFieldInfoPtr_radianceSourceLimit;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssdoSelfShadowingBias;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssdoRadiusPixels;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssdoMaxOccluderDistance2Ws;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssdoAVContrast;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrFadeDistanceWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_screenEdgeFade;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrAcLeftColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrAcRightColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrAcBottomColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrAcTopColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrAcFrontColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_ssrAcBackColor;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Single_Single_Single_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0;
  [FieldOffset(0)]
  public readonly bool doGlobalIllumination;
  [FieldOffset(4)]
  public readonly float radianceSourceLimit;
  [FieldOffset(8)]
  public readonly float ssdoSelfShadowingBias;
  [FieldOffset(12)]
  public readonly float ssdoRadiusPixels;
  [FieldOffset(16 /*0x10*/)]
  public readonly float ssdoMaxOccluderDistance2Ws;
  [FieldOffset(20)]
  public readonly float ssdoAVContrast;
  [FieldOffset(24)]
  public readonly float ssrFadeDistanceWs;
  [FieldOffset(28)]
  public readonly float screenEdgeFade;
  [FieldOffset(32 /*0x20*/)]
  public readonly Vector3 ssrAcLeftColor;
  [FieldOffset(44)]
  public readonly Vector3 ssrAcRightColor;
  [FieldOffset(56)]
  public readonly Vector3 ssrAcBottomColor;
  [FieldOffset(68)]
  public readonly Vector3 ssrAcTopColor;
  [FieldOffset(80 /*0x50*/)]
  public readonly Vector3 ssrAcFrontColor;
  [FieldOffset(92)]
  public readonly Vector3 ssrAcBackColor;

  static GlobalIlluminationParams()
  {
    Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GlobalIlluminationParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr);
    GlobalIlluminationParams.NativeFieldInfoPtr_doGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (doGlobalIllumination));
    GlobalIlluminationParams.NativeFieldInfoPtr_radianceSourceLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (radianceSourceLimit));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssdoSelfShadowingBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssdoSelfShadowingBias));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssdoRadiusPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssdoRadiusPixels));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssdoMaxOccluderDistance2Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssdoMaxOccluderDistance2Ws));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssdoAVContrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssdoAVContrast));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrFadeDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrFadeDistanceWs));
    GlobalIlluminationParams.NativeFieldInfoPtr_screenEdgeFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (screenEdgeFade));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrAcLeftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrAcLeftColor));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrAcRightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrAcRightColor));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrAcBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrAcBottomColor));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrAcTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrAcTopColor));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrAcFrontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrAcFrontColor));
    GlobalIlluminationParams.NativeFieldInfoPtr_ssrAcBackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, nameof (ssrAcBackColor));
    GlobalIlluminationParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Single_Single_Single_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, 100663607);
  }

  [CallerCount(0)]
  public unsafe GlobalIlluminationParams(
    bool doGlobalIllumination,
    float radianceSourceLimit,
    float ssdoSelfShadowingBias,
    float ssdoRadiusPixels,
    float ssdoMaxOccluderDistance2Ws,
    float ssdoAVContrast,
    float ssrFadeDistanceWs,
    float screenEdgeFade,
    Vector3 ssrAcLeftColor,
    Vector3 ssrAcRightColor,
    Vector3 ssrAcBottomColor,
    Vector3 ssrAcTopColor,
    Vector3 ssrAcFrontColor,
    Vector3 ssrAcBackColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[14];
    numPtr[0] = (System.IntPtr) &doGlobalIllumination;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &radianceSourceLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ssdoSelfShadowingBias;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ssdoRadiusPixels;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &ssdoMaxOccluderDistance2Ws;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &ssdoAVContrast;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrFadeDistanceWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &screenEdgeFade;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrAcLeftColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrAcRightColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrAcBottomColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrAcTopColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrAcFrontColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &ssrAcBackColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalIlluminationParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Single_Single_Single_Single_Single_Single_Single_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalIlluminationParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
