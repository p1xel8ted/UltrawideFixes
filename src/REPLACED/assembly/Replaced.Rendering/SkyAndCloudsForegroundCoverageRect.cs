// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SkyAndCloudsForegroundCoverageRect
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public class SkyAndCloudsForegroundCoverageRect(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_MakePointOnSphere_Private_Static_Vector3_Single_Single_Single_Single_Vector3_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SkyAndCloudsForegroundCoverageRect()
  {
    Il2CppClassPointerStore<SkyAndCloudsForegroundCoverageRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SkyAndCloudsForegroundCoverageRect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyAndCloudsForegroundCoverageRect>.NativeClassPtr);
    SkyAndCloudsForegroundCoverageRect.NativeMethodInfoPtr_MakePointOnSphere_Private_Static_Vector3_Single_Single_Single_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsForegroundCoverageRect>.NativeClassPtr, 100663752);
    SkyAndCloudsForegroundCoverageRect.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsForegroundCoverageRect>.NativeClassPtr, 100663753);
    SkyAndCloudsForegroundCoverageRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyAndCloudsForegroundCoverageRect>.NativeClassPtr, 100663754);
  }

  [CallerCount(0)]
  public static unsafe Vector3 MakePointOnSphere(
    float sinTheta,
    float cosTheta,
    float sinPhi,
    float cosPhi,
    Vector3 sphereOriginWs,
    Vector3 sphereRadius3Ws)
  {
    IntPtr* numPtr = stackalloc IntPtr[6];
    numPtr[0] = (IntPtr) &sinTheta;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &cosTheta;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &sinPhi;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &cosPhi;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &sphereOriginWs;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &sphereRadius3Ws;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsForegroundCoverageRect.NativeMethodInfoPtr_MakePointOnSphere_Private_Static_Vector3_Single_Single_Single_Single_Vector3_Vector3_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928547, XrefRangeEnd = 928564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmosSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsForegroundCoverageRect.NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SkyAndCloudsForegroundCoverageRect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyAndCloudsForegroundCoverageRect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SkyAndCloudsForegroundCoverageRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
