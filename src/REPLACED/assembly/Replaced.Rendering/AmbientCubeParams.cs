// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.AmbientCubeParams
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
public struct AmbientCubeParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_leftColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottomColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_topColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_frontColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_backColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetricLeftColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetricRightColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetricBottomColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetricTopColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetricFrontColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_volumetricBackColor;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0;
  [FieldOffset(0)]
  public readonly Vector3 leftColor;
  [FieldOffset(12)]
  public readonly Vector3 rightColor;
  [FieldOffset(24)]
  public readonly Vector3 bottomColor;
  [FieldOffset(36)]
  public readonly Vector3 topColor;
  [FieldOffset(48 /*0x30*/)]
  public readonly Vector3 frontColor;
  [FieldOffset(60)]
  public readonly Vector3 backColor;
  [FieldOffset(72)]
  public readonly Vector3 volumetricLeftColor;
  [FieldOffset(84)]
  public readonly Vector3 volumetricRightColor;
  [FieldOffset(96 /*0x60*/)]
  public readonly Vector3 volumetricBottomColor;
  [FieldOffset(108)]
  public readonly Vector3 volumetricTopColor;
  [FieldOffset(120)]
  public readonly Vector3 volumetricFrontColor;
  [FieldOffset(132)]
  public readonly Vector3 volumetricBackColor;

  static AmbientCubeParams()
  {
    Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (AmbientCubeParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr);
    AmbientCubeParams.NativeFieldInfoPtr_leftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (leftColor));
    AmbientCubeParams.NativeFieldInfoPtr_rightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (rightColor));
    AmbientCubeParams.NativeFieldInfoPtr_bottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (bottomColor));
    AmbientCubeParams.NativeFieldInfoPtr_topColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (topColor));
    AmbientCubeParams.NativeFieldInfoPtr_frontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (frontColor));
    AmbientCubeParams.NativeFieldInfoPtr_backColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (backColor));
    AmbientCubeParams.NativeFieldInfoPtr_volumetricLeftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (volumetricLeftColor));
    AmbientCubeParams.NativeFieldInfoPtr_volumetricRightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (volumetricRightColor));
    AmbientCubeParams.NativeFieldInfoPtr_volumetricBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (volumetricBottomColor));
    AmbientCubeParams.NativeFieldInfoPtr_volumetricTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (volumetricTopColor));
    AmbientCubeParams.NativeFieldInfoPtr_volumetricFrontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (volumetricFrontColor));
    AmbientCubeParams.NativeFieldInfoPtr_volumetricBackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, nameof (volumetricBackColor));
    AmbientCubeParams.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, 100663606);
  }

  [CallerCount(0)]
  public unsafe AmbientCubeParams(
    Vector3 leftColor,
    Vector3 rightColor,
    Vector3 bottomColor,
    Vector3 topColor,
    Vector3 frontColor,
    Vector3 backColor,
    Vector3 volumetricLeftColor,
    Vector3 volumetricRightColor,
    Vector3 volumetricBottomColor,
    Vector3 volumetricTopColor,
    Vector3 volumetricFrontColor,
    Vector3 volumetricBackColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = (System.IntPtr) &leftColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rightColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bottomColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &topColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &frontColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &backColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &volumetricLeftColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &volumetricRightColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &volumetricBottomColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &volumetricTopColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &volumetricFrontColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &volumetricBackColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AmbientCubeParams.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AmbientCubeParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
