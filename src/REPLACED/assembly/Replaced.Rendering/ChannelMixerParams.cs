// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ChannelMixerParams
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
public struct ChannelMixerParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_red;
  private static readonly System.IntPtr NativeFieldInfoPtr_green;
  private static readonly System.IntPtr NativeFieldInfoPtr_blue;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0;
  [FieldOffset(0)]
  public readonly Vector3 red;
  [FieldOffset(12)]
  public readonly Vector3 green;
  [FieldOffset(24)]
  public readonly Vector3 blue;

  static ChannelMixerParams()
  {
    Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ChannelMixerParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr);
    ChannelMixerParams.NativeFieldInfoPtr_red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr, nameof (red));
    ChannelMixerParams.NativeFieldInfoPtr_green = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr, nameof (green));
    ChannelMixerParams.NativeFieldInfoPtr_blue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr, nameof (blue));
    ChannelMixerParams.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr, 100663635);
  }

  [CallerCount(0)]
  public unsafe ChannelMixerParams(Vector3 red, Vector3 green, Vector3 blue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &red;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &green;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &blue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ChannelMixerParams.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChannelMixerParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
