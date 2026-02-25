// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchDrawCommandProcedural
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommandProcedural
{
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_batchID;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialID;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_topology;
  private static readonly System.IntPtr NativeFieldInfoPtr_indexBufferHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_baseVertex;
  private static readonly System.IntPtr NativeFieldInfoPtr_indexOffsetBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementCount;
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
  public uint visibleCount;
  [FieldOffset(28)]
  public MeshTopology topology;
  [FieldOffset(32 /*0x20*/)]
  public GraphicsBufferHandle indexBufferHandle;
  [FieldOffset(36)]
  public uint baseVertex;
  [FieldOffset(40)]
  public uint indexOffsetBytes;
  [FieldOffset(44)]
  public uint elementCount;

  static BatchDrawCommandProcedural()
  {
    Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchDrawCommandProcedural));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr);
    BatchDrawCommandProcedural.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (flags));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (batchID));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (materialID));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (splitVisibilityMask));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (lightmapIndex));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (sortingPosition));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (visibleOffset));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (visibleCount));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_topology = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (topology));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_indexBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (indexBufferHandle));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_baseVertex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (baseVertex));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_indexOffsetBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (indexOffsetBytes));
    BatchDrawCommandProcedural.NativeFieldInfoPtr_elementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, nameof (elementCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommandProcedural>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
