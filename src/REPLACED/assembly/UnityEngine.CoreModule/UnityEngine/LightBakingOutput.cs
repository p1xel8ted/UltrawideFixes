// Decompiled with JetBrains decompiler
// Type: UnityEngine.LightBakingOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct LightBakingOutput
{
  private static readonly System.IntPtr NativeFieldInfoPtr_probeOcclusionLightIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMaskChannel;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapBakeType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mixedLightingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_isBaked;
  [FieldOffset(0)]
  public int probeOcclusionLightIndex;
  [FieldOffset(4)]
  public int occlusionMaskChannel;
  [FieldOffset(8)]
  public LightmapBakeType lightmapBakeType;
  [FieldOffset(12)]
  public MixedLightingMode mixedLightingMode;
  [FieldOffset(16 /*0x10*/)]
  public bool isBaked;

  static LightBakingOutput()
  {
    Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LightBakingOutput));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr);
    LightBakingOutput.NativeFieldInfoPtr_probeOcclusionLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, nameof (probeOcclusionLightIndex));
    LightBakingOutput.NativeFieldInfoPtr_occlusionMaskChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, nameof (occlusionMaskChannel));
    LightBakingOutput.NativeFieldInfoPtr_lightmapBakeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, nameof (lightmapBakeType));
    LightBakingOutput.NativeFieldInfoPtr_mixedLightingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, nameof (mixedLightingMode));
    LightBakingOutput.NativeFieldInfoPtr_isBaked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, nameof (isBaked));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightBakingOutput>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
