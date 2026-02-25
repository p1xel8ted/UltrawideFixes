// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchRendererCullingOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Jobs;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchRendererCullingOutput
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingJobsFence;
  private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_receiverPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplits;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingSplitCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewType;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectionType;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_viewID;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_splitExclusionMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_brgId;
  private static readonly System.IntPtr NativeFieldInfoPtr_occlusionBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_customCullingResult;
  [FieldOffset(0)]
  public JobHandle cullingJobsFence;
  [FieldOffset(16 /*0x10*/)]
  public Matrix4x4 localToWorldMatrix;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr cullingPlanes;
  [FieldOffset(88)]
  public int cullingPlaneCount;
  [FieldOffset(92)]
  public int receiverPlaneOffset;
  [FieldOffset(96 /*0x60*/)]
  public int receiverPlaneCount;
  [FieldOffset(104)]
  public System.IntPtr cullingSplits;
  [FieldOffset(112 /*0x70*/)]
  public int cullingSplitCount;
  [FieldOffset(116)]
  public BatchCullingViewType viewType;
  [FieldOffset(120)]
  public BatchCullingProjectionType projectionType;
  [FieldOffset(124)]
  public BatchCullingFlags cullingFlags;
  [FieldOffset(128 /*0x80*/)]
  public ulong viewID;
  [FieldOffset(136)]
  public uint cullingLayerMask;
  [FieldOffset(140)]
  public byte splitExclusionMask;
  [FieldOffset(144 /*0x90*/)]
  public ulong sceneCullingMask;
  [FieldOffset(152)]
  public System.IntPtr drawCommands;
  [FieldOffset(160 /*0xA0*/)]
  public uint brgId;
  [FieldOffset(168)]
  public System.IntPtr occlusionBuffer;
  [FieldOffset(176 /*0xB0*/)]
  public System.IntPtr customCullingResult;

  static BatchRendererCullingOutput()
  {
    Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchRendererCullingOutput));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr);
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingJobsFence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingJobsFence));
    BatchRendererCullingOutput.NativeFieldInfoPtr_localToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (localToWorldMatrix));
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingPlanes));
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingPlaneCount));
    BatchRendererCullingOutput.NativeFieldInfoPtr_receiverPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (receiverPlaneOffset));
    BatchRendererCullingOutput.NativeFieldInfoPtr_receiverPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (receiverPlaneCount));
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingSplits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingSplits));
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingSplitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingSplitCount));
    BatchRendererCullingOutput.NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (viewType));
    BatchRendererCullingOutput.NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (projectionType));
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingFlags));
    BatchRendererCullingOutput.NativeFieldInfoPtr_viewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (viewID));
    BatchRendererCullingOutput.NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (cullingLayerMask));
    BatchRendererCullingOutput.NativeFieldInfoPtr_splitExclusionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (splitExclusionMask));
    BatchRendererCullingOutput.NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (sceneCullingMask));
    BatchRendererCullingOutput.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (drawCommands));
    BatchRendererCullingOutput.NativeFieldInfoPtr_brgId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (brgId));
    BatchRendererCullingOutput.NativeFieldInfoPtr_occlusionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (occlusionBuffer));
    BatchRendererCullingOutput.NativeFieldInfoPtr_customCullingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, nameof (customCullingResult));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchRendererCullingOutput>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
