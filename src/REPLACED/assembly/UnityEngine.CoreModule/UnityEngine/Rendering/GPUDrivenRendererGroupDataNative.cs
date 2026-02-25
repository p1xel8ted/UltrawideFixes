// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenRendererGroupDataNative
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenRendererGroupDataNative
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_localBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapScaleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_motionVecGenMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_packedRendererData;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshStartIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialsOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_instancesOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_instancesCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_editorData;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_invalidRendererGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_invalidRendererGroupIDCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_prevLocalToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshID;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDescOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_subMeshDescCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialIndexCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialID;
  private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialData;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialFilterFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialCount;
  [FieldOffset(0)]
  public System.IntPtr rendererGroupID;
  [FieldOffset(8)]
  public System.IntPtr localBounds;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr lightmapScaleOffset;
  [FieldOffset(24)]
  public System.IntPtr gameObjectLayer;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr renderingLayerMask;
  [FieldOffset(40)]
  public System.IntPtr lodGroupID;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr motionVecGenMode;
  [FieldOffset(56)]
  public System.IntPtr packedRendererData;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr rendererPriority;
  [FieldOffset(72)]
  public System.IntPtr meshIndex;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr subMeshStartIndex;
  [FieldOffset(88)]
  public System.IntPtr materialsOffset;
  [FieldOffset(96 /*0x60*/)]
  public System.IntPtr materialsCount;
  [FieldOffset(104)]
  public System.IntPtr instancesOffset;
  [FieldOffset(112 /*0x70*/)]
  public System.IntPtr instancesCount;
  [FieldOffset(120)]
  public System.IntPtr editorData;
  [FieldOffset(128 /*0x80*/)]
  public int rendererGroupCount;
  [FieldOffset(136)]
  public System.IntPtr invalidRendererGroupID;
  [FieldOffset(144 /*0x90*/)]
  public int invalidRendererGroupIDCount;
  [FieldOffset(152)]
  public System.IntPtr localToWorldMatrix;
  [FieldOffset(160 /*0xA0*/)]
  public System.IntPtr prevLocalToWorldMatrix;
  [FieldOffset(168)]
  public System.IntPtr rendererGroupIndex;
  [FieldOffset(176 /*0xB0*/)]
  public int instanceCount;
  [FieldOffset(184)]
  public System.IntPtr meshID;
  [FieldOffset(192 /*0xC0*/)]
  public System.IntPtr subMeshCount;
  [FieldOffset(200)]
  public System.IntPtr subMeshDescOffset;
  [FieldOffset(208 /*0xD0*/)]
  public int meshCount;
  [FieldOffset(216)]
  public System.IntPtr subMeshDesc;
  [FieldOffset(224 /*0xE0*/)]
  public int subMeshDescCount;
  [FieldOffset(232)]
  public System.IntPtr materialIndex;
  [FieldOffset(240 /*0xF0*/)]
  public int materialIndexCount;
  [FieldOffset(248)]
  public System.IntPtr materialID;
  [FieldOffset(256 /*0x0100*/)]
  public System.IntPtr packedMaterialData;
  [FieldOffset(264)]
  public System.IntPtr materialFilterFlags;
  [FieldOffset(272)]
  public int materialCount;

  static GPUDrivenRendererGroupDataNative()
  {
    Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenRendererGroupDataNative));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr);
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_rendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (rendererGroupID));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_localBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (localBounds));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_lightmapScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (lightmapScaleOffset));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_gameObjectLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (gameObjectLayer));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (renderingLayerMask));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (lodGroupID));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_motionVecGenMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (motionVecGenMode));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_packedRendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (packedRendererData));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (rendererPriority));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_meshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (meshIndex));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_subMeshStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (subMeshStartIndex));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialsOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialsOffset));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialsCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_instancesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (instancesOffset));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (instancesCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_editorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (editorData));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_rendererGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (rendererGroupCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_invalidRendererGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (invalidRendererGroupID));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_invalidRendererGroupIDCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (invalidRendererGroupIDCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (localToWorldMatrix));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_prevLocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (prevLocalToWorldMatrix));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_rendererGroupIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (rendererGroupIndex));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (instanceCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (meshID));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_subMeshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (subMeshCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_subMeshDescOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (subMeshDescOffset));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_meshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (meshCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_subMeshDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (subMeshDesc));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_subMeshDescCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (subMeshDescCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialIndex));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialIndexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialIndexCount));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialID));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_packedMaterialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (packedMaterialData));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialFilterFlags));
    GPUDrivenRendererGroupDataNative.NativeFieldInfoPtr_materialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, nameof (materialCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenRendererGroupDataNative>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
