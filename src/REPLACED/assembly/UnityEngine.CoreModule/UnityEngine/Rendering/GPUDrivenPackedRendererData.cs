// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenPackedRendererData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenPackedRendererData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  [FieldOffset(0)]
  public uint data;

  static GPUDrivenPackedRendererData()
  {
    Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenPackedRendererData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr);
    GPUDrivenPackedRendererData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, nameof (data));
    GPUDrivenPackedRendererData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, 100670313);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487261, RefRangeEnd = 487263, XrefRangeStart = 487261, XrefRangeEnd = 487261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GPUDrivenPackedRendererData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenPackedRendererData.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenPackedRendererData>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public bool receiveShadows => (this.data & 1U) > 0U;

  public bool staticShadowCaster => (this.data & 2U) > 0U;

  public byte lodMask => (byte) (this.data >> 2 & (uint) byte.MaxValue);

  public ShadowCastingMode shadowCastingMode => (ShadowCastingMode) ((int) (this.data >> 10) & 3);

  public LightProbeUsage lightProbeUsage => (LightProbeUsage) ((int) (this.data >> 12) & 7);

  public MotionVectorGenerationMode motionVecGenMode
  {
    get => (MotionVectorGenerationMode) ((int) (this.data >> 15) & 3);
  }

  public bool isPartOfStaticBatch => (this.data & 131072U /*0x020000*/) > 0U;

  public bool movedCurrentFrame => (this.data & 262144U /*0x040000*/) > 0U;

  public bool hasTree => (this.data & 524288U /*0x080000*/) > 0U;

  public bool smallMeshCulling => (this.data & 1048576U /*0x100000*/) > 0U;

  public bool supportsIndirect => (this.data & 2097152U /*0x200000*/) > 0U;
}
