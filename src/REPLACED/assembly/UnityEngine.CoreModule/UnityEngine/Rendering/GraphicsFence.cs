// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GraphicsFence
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GraphicsFence
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FenceType;
  private static readonly System.IntPtr NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0;
  [FieldOffset(0)]
  public System.IntPtr m_Ptr;
  [FieldOffset(8)]
  public int m_Version;
  [FieldOffset(12)]
  public GraphicsFenceType m_FenceType;
  private static readonly GraphicsFence.HasFencePassed_InternalDelegate HasFencePassed_InternalDelegateField;

  static GraphicsFence()
  {
    Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GraphicsFence));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr);
    GraphicsFence.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, nameof (m_Ptr));
    GraphicsFence.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, nameof (m_Version));
    GraphicsFence.NativeFieldInfoPtr_m_FenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, nameof (m_FenceType));
    GraphicsFence.NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100669679);
    GraphicsFence.NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100669680);
    GraphicsFence.NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100669681);
    GraphicsFence.NativeMethodInfoPtr_Validate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100669682);
    GraphicsFence.NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100669683);
    GraphicsFence.NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, 100669684);
    GraphicsFence.HasFencePassed_InternalDelegateField = IL2CPP.ResolveICall<GraphicsFence.HasFencePassed_InternalDelegate>("UnityEngine.Rendering.GraphicsFence::HasFencePassed_Internal");
  }

  [CallerCount(0)]
  public static unsafe SynchronisationStageFlags TranslateSynchronizationStageToFlags(
    SynchronisationStage s)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &s
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_TranslateSynchronizationStageToFlags_Internal_Static_SynchronisationStageFlags_SynchronisationStage_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SynchronisationStageFlags*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482310, XrefRangeEnd = 482312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitPostAllocation()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_InitPostAllocation_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482312, XrefRangeEnd = 482314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsFencePending()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_IsFencePending_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482315, RefRangeEnd = 482316, XrefRangeStart = 482314, XrefRangeEnd = 482315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Validate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_Validate_Internal_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe int GetPlatformNotSupportedVersion()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_GetPlatformNotSupportedVersion_Private_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482316, XrefRangeEnd = 482318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetVersionNumber(System.IntPtr fencePtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &fencePtr
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphicsFence.NativeMethodInfoPtr_GetVersionNumber_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphicsFence>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public bool passed
  {
    get
    {
      this.Validate();
      if (!SystemInfo.supportsGraphicsFence)
        throw new Il2CppSystem.NotSupportedException("Cannot determine if this GraphicsFence has passed as this platform has not implemented GraphicsFences.");
      if (this.m_FenceType == GraphicsFenceType.AsyncQueueSynchronisation && !SystemInfo.supportsAsyncCompute)
        throw new Il2CppSystem.NotSupportedException("Cannot determine if this AsyncQueueSynchronisation GraphicsFence has passed as this platform does not support async compute.");
      return !this.IsFencePending() || GraphicsFence.HasFencePassed_Internal(this.m_Ptr);
    }
  }

  public static bool HasFencePassed_Internal(System.IntPtr fencePtr)
  {
    return GraphicsFence.HasFencePassed_InternalDelegateField(fencePtr);
  }

  private delegate bool HasFencePassed_InternalDelegate(System.IntPtr fencePtr);
}
