// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CullingSplit
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CullingSplit
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereCenter;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlaneOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_cascadeBlendCullingFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_nearPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingMatrix;
  [FieldOffset(0)]
  public Vector3 sphereCenter;
  [FieldOffset(12)]
  public float sphereRadius;
  [FieldOffset(16 /*0x10*/)]
  public int cullingPlaneOffset;
  [FieldOffset(20)]
  public int cullingPlaneCount;
  [FieldOffset(24)]
  public float cascadeBlendCullingFactor;
  [FieldOffset(28)]
  public float nearPlane;
  [FieldOffset(32 /*0x20*/)]
  public Matrix4x4 cullingMatrix;

  static CullingSplit()
  {
    Il2CppClassPointerStore<CullingSplit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CullingSplit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr);
    CullingSplit.NativeFieldInfoPtr_sphereCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (sphereCenter));
    CullingSplit.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (sphereRadius));
    CullingSplit.NativeFieldInfoPtr_cullingPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (cullingPlaneOffset));
    CullingSplit.NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (cullingPlaneCount));
    CullingSplit.NativeFieldInfoPtr_cascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (cascadeBlendCullingFactor));
    CullingSplit.NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (nearPlane));
    CullingSplit.NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, nameof (cullingMatrix));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
