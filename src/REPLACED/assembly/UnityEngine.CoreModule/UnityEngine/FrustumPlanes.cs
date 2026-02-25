// Decompiled with JetBrains decompiler
// Type: UnityEngine.FrustumPlanes
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct FrustumPlanes
{
  private static readonly System.IntPtr NativeFieldInfoPtr_left;
  private static readonly System.IntPtr NativeFieldInfoPtr_right;
  private static readonly System.IntPtr NativeFieldInfoPtr_bottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_top;
  private static readonly System.IntPtr NativeFieldInfoPtr_zNear;
  private static readonly System.IntPtr NativeFieldInfoPtr_zFar;
  [FieldOffset(0)]
  public float left;
  [FieldOffset(4)]
  public float right;
  [FieldOffset(8)]
  public float bottom;
  [FieldOffset(12)]
  public float top;
  [FieldOffset(16 /*0x10*/)]
  public float zNear;
  [FieldOffset(20)]
  public float zFar;

  static FrustumPlanes()
  {
    Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (FrustumPlanes));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr);
    FrustumPlanes.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, nameof (left));
    FrustumPlanes.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, nameof (right));
    FrustumPlanes.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, nameof (bottom));
    FrustumPlanes.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, nameof (top));
    FrustumPlanes.NativeFieldInfoPtr_zNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, nameof (zNear));
    FrustumPlanes.NativeFieldInfoPtr_zFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, nameof (zFar));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrustumPlanes>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
