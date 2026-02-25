// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CommandBufferExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Rendering;

public static class CommandBufferExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_Boolean_0;

  static CommandBufferExtensions()
  {
    Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CommandBufferExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr);
    CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100670249);
    CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100670250);
    CommandBufferExtensions.NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100670251);
    CommandBufferExtensions.NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100670252);
    CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100670253);
    CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100670254);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486813, XrefRangeEnd = 486821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SwitchIntoFastMemory(
    CommandBuffer cmd,
    ref RenderTargetIdentifier rt,
    FastMemoryFlags fastMemoryFlags,
    float residency,
    bool copyContents)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fastMemoryFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &residency;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &copyContents;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486821, XrefRangeEnd = 486829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SwitchOutOfFastMemory(
    CommandBuffer cmd,
    ref RenderTargetIdentifier rt,
    bool copyContents)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &copyContents;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 486834, RefRangeEnd = 486836, XrefRangeStart = 486829, XrefRangeEnd = 486834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SwitchIntoFastMemory(
    this CommandBuffer cmd,
    RenderTargetIdentifier rid,
    FastMemoryFlags fastMemoryFlags,
    float residency,
    bool copyContents)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fastMemoryFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &residency;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &copyContents;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 486841, RefRangeEnd = 486842, XrefRangeStart = 486836, XrefRangeEnd = 486841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SwitchOutOfFastMemory(
    this CommandBuffer cmd,
    RenderTargetIdentifier rid,
    bool copyContents)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &copyContents;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486842, XrefRangeEnd = 486844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SwitchIntoFastMemory_Injected(
    System.IntPtr cmd,
    ref RenderTargetIdentifier rt,
    FastMemoryFlags fastMemoryFlags,
    float residency,
    bool copyContents)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &cmd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &fastMemoryFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &residency;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &copyContents;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 486844, XrefRangeEnd = 486846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SwitchOutOfFastMemory_Injected(
    System.IntPtr cmd,
    ref RenderTargetIdentifier rt,
    bool copyContents)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &cmd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rt;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &copyContents;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommandBufferExtensions.NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public CommandBufferExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
