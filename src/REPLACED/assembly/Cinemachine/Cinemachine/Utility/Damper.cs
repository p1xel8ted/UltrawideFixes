// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.Damper
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public static class Damper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Damp_Public_Static_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Damp_Public_Static_Vector3_Vector3_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Damp_Public_Static_Vector3_Vector3_Single_Single_0;

  static Damper()
  {
    Il2CppClassPointerStore<Damper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (Damper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Damper>.NativeClassPtr);
    Damper.NativeMethodInfoPtr_Damp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Damper>.NativeClassPtr, 100664481);
    Damper.NativeMethodInfoPtr_Damp_Public_Static_Vector3_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Damper>.NativeClassPtr, 100664482);
    Damper.NativeMethodInfoPtr_Damp_Public_Static_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Damper>.NativeClassPtr, 100664483);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 947847, RefRangeEnd = 947860, XrefRangeStart = 947846, XrefRangeEnd = 947847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Damp(float initial, float dampTime, float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Damper.NativeMethodInfoPtr_Damp_Public_Static_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 947867, RefRangeEnd = 947870, XrefRangeStart = 947860, XrefRangeEnd = 947867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Damp(Vector3 initial, Vector3 dampTime, float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Damper.NativeMethodInfoPtr_Damp_Public_Static_Vector3_Vector3_Vector3_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 947877, RefRangeEnd = 947884, XrefRangeStart = 947870, XrefRangeEnd = 947877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 Damp(Vector3 initial, float dampTime, float deltaTime)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &initial;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dampTime;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Damper.NativeMethodInfoPtr_Damp_Public_Static_Vector3_Vector3_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Damper(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
