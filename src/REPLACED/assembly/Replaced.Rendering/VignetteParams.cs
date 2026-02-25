// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VignetteParams
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
public struct VignetteParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_edgeSmoothness;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Single_Single_0;
  [FieldOffset(0)]
  public readonly Color color;
  [FieldOffset(16 /*0x10*/)]
  public readonly float intensity;
  [FieldOffset(20)]
  public readonly float edgeSmoothness;

  static VignetteParams()
  {
    Il2CppClassPointerStore<VignetteParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VignetteParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteParams>.NativeClassPtr);
    VignetteParams.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteParams>.NativeClassPtr, nameof (color));
    VignetteParams.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteParams>.NativeClassPtr, nameof (intensity));
    VignetteParams.NativeFieldInfoPtr_edgeSmoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteParams>.NativeClassPtr, nameof (edgeSmoothness));
    VignetteParams.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteParams>.NativeClassPtr, 100663644);
  }

  [CallerCount(0)]
  public unsafe VignetteParams(Color color, float intensity, float edgeSmoothness)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &color;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &intensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &edgeSmoothness;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VignetteParams.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VignetteParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
