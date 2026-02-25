// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.UnityQuaternionExtensions
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public static class UnityQuaternionExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalized_Public_Static_Quaternion_Quaternion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraRotationToTarget_Public_Static_Vector2_Quaternion_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ApplyCameraRotation_Public_Static_Quaternion_Quaternion_Vector2_Vector3_0;

  static UnityQuaternionExtensions()
  {
    Il2CppClassPointerStore<UnityQuaternionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (UnityQuaternionExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityQuaternionExtensions>.NativeClassPtr);
    UnityQuaternionExtensions.NativeMethodInfoPtr_Normalized_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityQuaternionExtensions>.NativeClassPtr, 100664507);
    UnityQuaternionExtensions.NativeMethodInfoPtr_GetCameraRotationToTarget_Public_Static_Vector2_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityQuaternionExtensions>.NativeClassPtr, 100664508);
    UnityQuaternionExtensions.NativeMethodInfoPtr_ApplyCameraRotation_Public_Static_Quaternion_Quaternion_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityQuaternionExtensions>.NativeClassPtr, 100664509);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 948088, RefRangeEnd = 948089, XrefRangeStart = 948080, XrefRangeEnd = 948088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion Normalized(this Quaternion q)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &q
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityQuaternionExtensions.NativeMethodInfoPtr_Normalized_Public_Static_Quaternion_Quaternion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 948111, RefRangeEnd = 948116, XrefRangeStart = 948089, XrefRangeEnd = 948111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetCameraRotationToTarget(
    this Quaternion orient,
    Vector3 lookAtDir,
    Vector3 worldUp)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &orient;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lookAtDir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityQuaternionExtensions.NativeMethodInfoPtr_GetCameraRotationToTarget_Public_Static_Vector2_Quaternion_Vector3_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 948121, RefRangeEnd = 948127, XrefRangeStart = 948116, XrefRangeEnd = 948121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion ApplyCameraRotation(
    this Quaternion orient,
    Vector2 rot,
    Vector3 worldUp)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &orient;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &worldUp;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityQuaternionExtensions.NativeMethodInfoPtr_ApplyCameraRotation_Public_Static_Quaternion_Quaternion_Vector2_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public UnityQuaternionExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
