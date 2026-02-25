// Decompiled with JetBrains decompiler
// Type: UnityEngine.GradientColorKey
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct GradientColorKey
{
  private static readonly System.IntPtr NativeFieldInfoPtr_color;
  private static readonly System.IntPtr NativeFieldInfoPtr_time;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0;
  [FieldOffset(0)]
  public Color color;
  [FieldOffset(16 /*0x10*/)]
  public float time;

  static GradientColorKey()
  {
    Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (GradientColorKey));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr);
    GradientColorKey.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, nameof (color));
    GradientColorKey.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, nameof (time));
    GradientColorKey.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, 100667287);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 438317, RefRangeEnd = 438321, XrefRangeStart = 438317, XrefRangeEnd = 438317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GradientColorKey(Color col, float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &col;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &time;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GradientColorKey.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientColorKey>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
