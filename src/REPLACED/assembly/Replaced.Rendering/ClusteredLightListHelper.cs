// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ClusteredLightListHelper
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public static class ClusteredLightListHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CalcCommonDifference_Public_Static_Single_Single_Single_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNearClipPlaneDepthVs_Public_Static_Single_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFarClipPlaneDepthVs_Public_Static_Single_byref_FrameRenderingParams_0;

  static ClusteredLightListHelper()
  {
    Il2CppClassPointerStore<ClusteredLightListHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ClusteredLightListHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClusteredLightListHelper>.NativeClassPtr);
    ClusteredLightListHelper.NativeMethodInfoPtr_CalcCommonDifference_Public_Static_Single_Single_Single_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHelper>.NativeClassPtr, 100663839);
    ClusteredLightListHelper.NativeMethodInfoPtr_GetNearClipPlaneDepthVs_Public_Static_Single_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHelper>.NativeClassPtr, 100663840 /*0x06000220*/);
    ClusteredLightListHelper.NativeMethodInfoPtr_GetFarClipPlaneDepthVs_Public_Static_Single_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClusteredLightListHelper>.NativeClassPtr, 100663841);
  }

  [CallerCount(0)]
  public static unsafe float CalcCommonDifference(float nearVs, float farVs, Vector3Int gridSize3D)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &nearVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &farVs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &gridSize3D;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHelper.NativeMethodInfoPtr_CalcCommonDifference_Public_Static_Single_Single_Single_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float GetNearClipPlaneDepthVs([In] ref FrameRenderingParams frp)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHelper.NativeMethodInfoPtr_GetNearClipPlaneDepthVs_Public_Static_Single_byref_FrameRenderingParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float GetFarClipPlaneDepthVs([In] ref FrameRenderingParams frp)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClusteredLightListHelper.NativeMethodInfoPtr_GetFarClipPlaneDepthVs_Public_Static_Single_byref_FrameRenderingParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public ClusteredLightListHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
