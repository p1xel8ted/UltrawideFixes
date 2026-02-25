// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.GlobalIllumination.Cookie
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct Cookie
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_scale;
  private static readonly System.IntPtr NativeFieldInfoPtr_sizes;
  [FieldOffset(0)]
  public int instanceID;
  [FieldOffset(4)]
  public float scale;
  [FieldOffset(8)]
  public Vector2 sizes;

  static Cookie()
  {
    Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", nameof (Cookie));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
    Cookie.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, nameof (instanceID));
    Cookie.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, nameof (scale));
    Cookie.NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, nameof (sizes));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cookie>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static Cookie Defaults()
  {
    Cookie cookie;
    cookie.instanceID = 0;
    cookie.scale = 1f;
    cookie.sizes = new Vector2(1f, 1f);
    return cookie;
  }
}
