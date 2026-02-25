// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.SpotLight
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct SpotLight
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
  private static readonly System.IntPtr NativeFieldInfoPtr_coneAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_innerConeAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_falloff;
  private static readonly System.IntPtr NativeFieldInfoPtr_angularFalloff;
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
  public float coneAngle;
  [FieldOffset(80 /*0x50*/)]
  public float innerConeAngle;
  [FieldOffset(84)]
  public FalloffType falloff;
  [FieldOffset(85)]
  public AngularFalloffType angularFalloff;

  static SpotLight()
  {
    Il2CppClassPointerStore<SpotLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (SpotLight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLight>.NativeClassPtr);
    SpotLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (instanceID));
    SpotLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (shadow));
    SpotLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (mode));
    SpotLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (position));
    SpotLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (orientation));
    SpotLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (color));
    SpotLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (indirectColor));
    SpotLight.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (range));
    SpotLight.NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (sphereRadius));
    SpotLight.NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (coneAngle));
    SpotLight.NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (innerConeAngle));
    SpotLight.NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (falloff));
    SpotLight.NativeFieldInfoPtr_angularFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, nameof (angularFalloff));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
