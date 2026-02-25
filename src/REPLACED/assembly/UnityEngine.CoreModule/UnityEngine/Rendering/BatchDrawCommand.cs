// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchDrawCommand
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchDrawCommand
{
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_batchID;
  private static readonly System.IntPtr NativeFieldInfoPtr_materialID;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitVisibilityMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightmapIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_sortingPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshID;
  private static readonly System.IntPtr NativeFieldInfoPtr_submeshIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_unusedPadding2;
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
  public BatchMeshID meshID;
  [FieldOffset(32 /*0x20*/)]
  public ushort submeshIndex;
  [FieldOffset(34)]
  public ushort unusedPadding2;

  static BatchDrawCommand()
  {
    Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchDrawCommand));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr);
    BatchDrawCommand.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (flags));
    BatchDrawCommand.NativeFieldInfoPtr_batchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (batchID));
    BatchDrawCommand.NativeFieldInfoPtr_materialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (materialID));
    BatchDrawCommand.NativeFieldInfoPtr_splitVisibilityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (splitVisibilityMask));
    BatchDrawCommand.NativeFieldInfoPtr_lightmapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (lightmapIndex));
    BatchDrawCommand.NativeFieldInfoPtr_sortingPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (sortingPosition));
    BatchDrawCommand.NativeFieldInfoPtr_visibleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (visibleOffset));
    BatchDrawCommand.NativeFieldInfoPtr_visibleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (visibleCount));
    BatchDrawCommand.NativeFieldInfoPtr_meshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (meshID));
    BatchDrawCommand.NativeFieldInfoPtr_submeshIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (submeshIndex));
    BatchDrawCommand.NativeFieldInfoPtr_unusedPadding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, nameof (unusedPadding2));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchDrawCommand>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
