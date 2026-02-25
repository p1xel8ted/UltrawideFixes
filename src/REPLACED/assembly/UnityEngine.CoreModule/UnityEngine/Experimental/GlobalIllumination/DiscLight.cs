// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.DiscLight
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct DiscLight
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadow;
  private static readonly System.IntPtr NativeFieldInfoPtr_mode;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientation;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_range;
  private static readonly System.IntPtr NativeFieldInfoPtr_radius;
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
  public float radius;
  [FieldOffset(76)]
  public FalloffType falloff;

  static DiscLight()
  {
    Il2CppClassPointerStore<DiscLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (DiscLight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscLight>.NativeClassPtr);
    DiscLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (instanceID));
    DiscLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (shadow));
    DiscLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (mode));
    DiscLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (position));
    DiscLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (orientation));
    DiscLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (color));
    DiscLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (indirectColor));
    DiscLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (range));
    DiscLight.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (radius));
    DiscLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, nameof (falloff));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscLight>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
