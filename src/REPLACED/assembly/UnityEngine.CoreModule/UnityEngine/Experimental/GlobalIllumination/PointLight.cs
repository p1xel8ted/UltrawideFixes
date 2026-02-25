// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.PointLight
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct PointLight
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadow;
  private static readonly System.IntPtr NativeFieldInfoPtr_mode;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientation;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_range;
  private static readonly System.IntPtr NativeFieldInfoPtr_sphereRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_falloff;
  [FieldOffset(0)]
  public int instanceID;
  [FieldOffset(4)]
  public bool shadow;
  [FieldOffset(5)]
  public LightMode mode;
  [FieldOffset(8)]
  public Vector3 position;
  [FieldOffset(20)]
  public Quaternion orientation;
  [FieldOffset(36)]
  public LinearColor color;
  [FieldOffset(52)]
  public LinearColor indirectColor;
  [FieldOffset(68)]
  public float range;
  [FieldOffset(72)]
  public float sphereRadius;
  [FieldOffset(76)]
  public FalloffType falloff;

  static PointLight()
  {
    Il2CppClassPointerStore<PointLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (PointLight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointLight>.NativeClassPtr);
    PointLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (instanceID));
    PointLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (shadow));
    PointLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (mode));
    PointLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (position));
    PointLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (orientation));
    PointLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (color));
    PointLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (indirectColor));
    PointLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (range));
    PointLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (sphereRadius));
    PointLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointLight>.NativeClassPtr, nameof (falloff));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointLight>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
