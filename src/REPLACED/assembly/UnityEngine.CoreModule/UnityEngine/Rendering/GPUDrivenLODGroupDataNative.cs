// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenLODGroupDataNative
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenLODGroupDataNative
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceReferencePoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastLODIsBillboard;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceLODMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_invalidLODGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_invalidLODGroupCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodRenderersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodScreenRelativeTransitionHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodFadeTransitionWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodDataCount;
  [FieldOffset(0)]
  public System.IntPtr lodGroupID;
  [FieldOffset(8)]
  public System.IntPtr lodOffset;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr lodCount;
  [FieldOffset(24)]
  public System.IntPtr fadeMode;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr worldSpaceReferencePoint;
  [FieldOffset(40)]
  public System.IntPtr worldSpaceSize;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr renderersCount;
  [FieldOffset(56)]
  public System.IntPtr lastLODIsBillboard;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr forceLODMask;
  [FieldOffset(72)]
  public int lodGroupCount;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr invalidLODGroupID;
  [FieldOffset(88)]
  public int invalidLODGroupCount;
  [FieldOffset(96 /*0x60*/)]
  public System.IntPtr lodRenderersCount;
  [FieldOffset(104)]
  public System.IntPtr lodScreenRelativeTransitionHeight;
  [FieldOffset(112 /*0x70*/)]
  public System.IntPtr lodFadeTransitionWidth;
  [FieldOffset(120)]
  public int lodDataCount;

  static GPUDrivenLODGroupDataNative()
  {
    Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenLODGroupDataNative));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr);
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodGroupID));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodOffset));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodCount));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_fadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (fadeMode));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_worldSpaceReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (worldSpaceReferencePoint));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_worldSpaceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (worldSpaceSize));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_renderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (renderersCount));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lastLODIsBillboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lastLODIsBillboard));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_forceLODMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (forceLODMask));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodGroupCount));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_invalidLODGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (invalidLODGroupID));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_invalidLODGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (invalidLODGroupCount));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodRenderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodRenderersCount));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodScreenRelativeTransitionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodScreenRelativeTransitionHeight));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodFadeTransitionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodFadeTransitionWidth));
    GPUDrivenLODGroupDataNative.NativeFieldInfoPtr_lodDataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, nameof (lodDataCount));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenLODGroupDataNative>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
