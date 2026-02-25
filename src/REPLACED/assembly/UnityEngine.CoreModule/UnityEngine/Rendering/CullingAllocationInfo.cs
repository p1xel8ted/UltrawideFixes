// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CullingAllocationInfo
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CullingAllocationInfo
{
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightsPtr;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleReflectionProbesPtr;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffscreenVertexLightCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleReflectionProbeCount;
  [FieldOffset(0)]
  public System.IntPtr visibleLightsPtr;
  [FieldOffset(8)]
  public System.IntPtr visibleOffscreenVertexLightsPtr;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr visibleReflectionProbesPtr;
  [FieldOffset(24)]
  public int visibleLightCount;
  [FieldOffset(28)]
  public int visibleOffscreenVertexLightCount;
  [FieldOffset(32 /*0x20*/)]
  public int visibleReflectionProbeCount;

  static CullingAllocationInfo()
  {
    Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CullingAllocationInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr);
    CullingAllocationInfo.NativeFieldInfoPtr_visibleLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, nameof (visibleLightsPtr));
    CullingAllocationInfo.NativeFieldInfoPtr_visibleOffscreenVertexLightsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, nameof (visibleOffscreenVertexLightsPtr));
    CullingAllocationInfo.NativeFieldInfoPtr_visibleReflectionProbesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, nameof (visibleReflectionProbesPtr));
    CullingAllocationInfo.NativeFieldInfoPtr_visibleLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, nameof (visibleLightCount));
    CullingAllocationInfo.NativeFieldInfoPtr_visibleOffscreenVertexLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, nameof (visibleOffscreenVertexLightCount));
    CullingAllocationInfo.NativeFieldInfoPtr_visibleReflectionProbeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, nameof (visibleReflectionProbeCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingAllocationInfo>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
