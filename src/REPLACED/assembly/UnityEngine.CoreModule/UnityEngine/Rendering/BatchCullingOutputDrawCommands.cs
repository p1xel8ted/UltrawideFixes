// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchCullingOutputDrawCommands
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchCullingOutputDrawCommands
{
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectDrawCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_proceduralDrawCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_proceduralIndirectDrawCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstances;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawRanges;
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceSortingPositions;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandPickingInstanceIDs;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommandCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_indirectDrawCommandCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_proceduralDrawCommandCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_proceduralIndirectDrawCommandCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstanceCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawRangeCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceSortingPositionFloatCount;
  [FieldOffset(0)]
  public System.IntPtr drawCommands;
  [FieldOffset(8)]
  public System.IntPtr indirectDrawCommands;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr proceduralDrawCommands;
  [FieldOffset(24)]
  public System.IntPtr proceduralIndirectDrawCommands;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr visibleInstances;
  [FieldOffset(40)]
  public System.IntPtr drawRanges;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr instanceSortingPositions;
  [FieldOffset(56)]
  public System.IntPtr drawCommandPickingInstanceIDs;
  [FieldOffset(64 /*0x40*/)]
  public int drawCommandCount;
  [FieldOffset(68)]
  public int indirectDrawCommandCount;
  [FieldOffset(72)]
  public int proceduralDrawCommandCount;
  [FieldOffset(76)]
  public int proceduralIndirectDrawCommandCount;
  [FieldOffset(80 /*0x50*/)]
  public int visibleInstanceCount;
  [FieldOffset(84)]
  public int drawRangeCount;
  [FieldOffset(88)]
  public int instanceSortingPositionFloatCount;

  static BatchCullingOutputDrawCommands()
  {
    Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchCullingOutputDrawCommands));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr);
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (drawCommands));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_indirectDrawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (indirectDrawCommands));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_proceduralDrawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (proceduralDrawCommands));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_proceduralIndirectDrawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (proceduralIndirectDrawCommands));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_visibleInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (visibleInstances));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (drawRanges));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_instanceSortingPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (instanceSortingPositions));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommandPickingInstanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (drawCommandPickingInstanceIDs));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (drawCommandCount));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_indirectDrawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (indirectDrawCommandCount));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_proceduralDrawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (proceduralDrawCommandCount));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_proceduralIndirectDrawCommandCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (proceduralIndirectDrawCommandCount));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_visibleInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (visibleInstanceCount));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_drawRangeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (drawRangeCount));
    BatchCullingOutputDrawCommands.NativeFieldInfoPtr_instanceSortingPositionFloatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, nameof (instanceSortingPositionFloatCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchCullingOutputDrawCommands>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
