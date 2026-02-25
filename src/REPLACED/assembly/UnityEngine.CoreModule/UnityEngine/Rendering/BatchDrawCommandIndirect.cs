// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchDrawCommandIndirect
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommandIndirect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_batchID;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialID;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshID;
  private static readonly System.IntPtr NativeFieldInfoPtr_topology;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferWindowOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferWindowSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectArgsBufferHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectArgsBufferOffset;
  [FieldOffset(0)]
  public BatchDrawCommandFlags flags;
  [FieldOffset(4)]
  public BatchID batchID;
  [FieldOffset(8)]
  public BatchMaterialID materialID;
  [FieldOffset(12)]
  public ushort splitVisibilityMask;
  [FieldOffset(14)]
  public ushort lightmapIndex;
  [FieldOffset(16 /*0x10*/)]
  public int sortingPosition;
  [FieldOffset(20)]
  public uint visibleOffset;
  [FieldOffset(24)]
  public BatchMeshID meshID;
  [FieldOffset(28)]
  public MeshTopology topology;
  [FieldOffset(32 /*0x20*/)]
  public GraphicsBufferHandle visibleInstancesBufferHandle;
  [FieldOffset(36)]
  public uint visibleInstancesBufferWindowOffset;
  [FieldOffset(40)]
  public uint visibleInstancesBufferWindowSizeBytes;
  [FieldOffset(44)]
  public GraphicsBufferHandle indirectArgsBufferHandle;
  [FieldOffset(48 /*0x30*/)]
  public uint indirectArgsBufferOffset;

  static BatchDrawCommandIndirect()
  {
    Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchDrawCommandIndirect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr);
    BatchDrawCommandIndirect.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (flags));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (batchID));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (materialID));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (splitVisibilityMask));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (lightmapIndex));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (sortingPosition));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (visibleOffset));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (meshID));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (topology));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_visibleInstancesBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (visibleInstancesBufferHandle));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_visibleInstancesBufferWindowOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (visibleInstancesBufferWindowOffset));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_visibleInstancesBufferWindowSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (visibleInstancesBufferWindowSizeBytes));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_indirectArgsBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (indirectArgsBufferHandle));
    BatchDrawCommandIndirect.NativeFieldInfoPtr_indirectArgsBufferOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, nameof (indirectArgsBufferOffset));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommandIndirect>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
