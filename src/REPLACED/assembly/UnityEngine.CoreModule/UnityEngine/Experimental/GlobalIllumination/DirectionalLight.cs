// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.DirectionalLight
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct DirectionalLight
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadow;
  private static readonly System.IntPtr NativeFieldInfoPtr_mode;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_orientation;
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_penumbraWidthRadian;
  private static readonly System.IntPtr NativeFieldInfoPtr_direction;
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
  public float penumbraWidthRadian;
  [FieldOffset(72)]
  public Vector3 direction;

  static DirectionalLight()
  {
    Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (DirectionalLight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr);
    DirectionalLight.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (instanceID));
    DirectionalLight.NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (shadow));
    DirectionalLight.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (mode));
    DirectionalLight.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (position));
    DirectionalLight.NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (orientation));
    DirectionalLight.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (color));
    DirectionalLight.NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (indirectColor));
    DirectionalLight.NativeFieldInfoPtr_penumbraWidthRadian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (penumbraWidthRadian));
    DirectionalLight.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, nameof (direction));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
