// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.OffsetGammaGainParams
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
public struct OffsetGammaGainParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_offset;
  private static readonly System.IntPtr NativeFieldInfoPtr_gamma;
  private static readonly System.IntPtr NativeFieldInfoPtr_gain;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_0;
  [FieldOffset(0)]
  public readonly Vector4 offset;
  [FieldOffset(16 /*0x10*/)]
  public readonly Vector4 gamma;
  [FieldOffset(32 /*0x20*/)]
  public readonly Vector4 gain;

  static OffsetGammaGainParams()
  {
    Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (OffsetGammaGainParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr);
    OffsetGammaGainParams.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr, nameof (offset));
    OffsetGammaGainParams.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr, nameof (gamma));
    OffsetGammaGainParams.NativeFieldInfoPtr_gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr, nameof (gain));
    OffsetGammaGainParams.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr, 100663638);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 927050, RefRangeEnd = 927052, XrefRangeStart = 927050, XrefRangeEnd = 927050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OffsetGammaGainParams(Vector4 offset, Vector4 gamma, Vector4 gain)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gamma;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gain;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OffsetGammaGainParams.NativeMethodInfoPtr__ctor_Public_Void_Vector4_Vector4_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OffsetGammaGainParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
