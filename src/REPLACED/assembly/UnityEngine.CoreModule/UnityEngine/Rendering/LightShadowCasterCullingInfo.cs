// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.LightShadowCasterCullingInfo
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct LightShadowCasterCullingInfo
{
  private static readonly System.IntPtr NativeFieldInfoPtr_splitRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionType;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitExclusionMask;
  [FieldOffset(0)]
  public RangeInt splitRange;
  [FieldOffset(8)]
  public BatchCullingProjectionType projectionType;
  [FieldOffset(12)]
  public ushort splitExclusionMask;

  static LightShadowCasterCullingInfo()
  {
    Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (LightShadowCasterCullingInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr);
    LightShadowCasterCullingInfo.NativeFieldInfoPtr_splitRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, nameof (splitRange));
    LightShadowCasterCullingInfo.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, nameof (projectionType));
    LightShadowCasterCullingInfo.NativeFieldInfoPtr_splitExclusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, nameof (splitExclusionMask));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightShadowCasterCullingInfo>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
