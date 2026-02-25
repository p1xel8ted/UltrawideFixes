// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenPackedMaterialData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenPackedMaterialData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  [FieldOffset(0)]
  public uint data;

  static GPUDrivenPackedMaterialData()
  {
    Il2CppClassPointerStore<GPUDrivenPackedMaterialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenPackedMaterialData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenPackedMaterialData>.NativeClassPtr);
    GPUDrivenPackedMaterialData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenPackedMaterialData>.NativeClassPtr, nameof (data));
    GPUDrivenPackedMaterialData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUDrivenPackedMaterialData>.NativeClassPtr, 100670314);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487261, RefRangeEnd = 487263, XrefRangeStart = 487261, XrefRangeEnd = 487263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GPUDrivenPackedMaterialData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GPUDrivenPackedMaterialData.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenPackedMaterialData>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public bool isTransparent => (this.data & 1U) > 0U;

  public bool isMotionVectorsPassEnabled => (this.data & 2U) > 0U;

  public bool isIndirectSupported => (this.data & 4U) > 0U;

  public bool Equals(GPUDrivenPackedMaterialData other)
  {
    return ((int) other.data & 7) == ((int) this.data & 7);
  }
}
