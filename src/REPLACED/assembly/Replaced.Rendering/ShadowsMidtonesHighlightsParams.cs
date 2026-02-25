// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowsMidtonesHighlightsParams
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
public struct ShadowsMidtonesHighlightsParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_shadows;
  private static readonly System.IntPtr NativeFieldInfoPtr_midtones;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlights;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowsStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowsEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightsStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_highlightsEnd;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Single_Single_Single_Single_0;
  [FieldOffset(0)]
  public Vector4 shadows;
  [FieldOffset(16 /*0x10*/)]
  public Vector4 midtones;
  [FieldOffset(32 /*0x20*/)]
  public Vector4 highlights;
  [FieldOffset(48 /*0x30*/)]
  public float shadowsStart;
  [FieldOffset(52)]
  public float shadowsEnd;
  [FieldOffset(56)]
  public float highlightsStart;
  [FieldOffset(60)]
  public float highlightsEnd;

  static ShadowsMidtonesHighlightsParams()
  {
    Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowsMidtonesHighlightsParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr);
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (shadows));
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_midtones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (midtones));
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (highlights));
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_shadowsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (shadowsStart));
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_shadowsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (shadowsEnd));
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_highlightsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (highlightsStart));
    ShadowsMidtonesHighlightsParams.NativeFieldInfoPtr_highlightsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, nameof (highlightsEnd));
    ShadowsMidtonesHighlightsParams.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, 100663639);
  }

  [CallerCount(0)]
  public unsafe ShadowsMidtonesHighlightsParams(
    Vector4 shadows,
    Vector4 midtones,
    Vector4 highlights,
    float shadowsStart,
    float shadowsEnd,
    float highlightsStart,
    float highlightsEnd)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &shadows;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &midtones;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &highlights;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowsStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowsEnd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &highlightsStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &highlightsEnd;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowsMidtonesHighlightsParams.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowsMidtonesHighlightsParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
