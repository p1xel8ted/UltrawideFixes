// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CameraEventUtils
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public static class CameraEventUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0;
  public const CameraEvent k_MinimumValue = CameraEvent.BeforeDepthTexture;
  public const CameraEvent k_MaximumValue = CameraEvent.AfterHaloAndLensFlares;

  static CameraEventUtils()
  {
    Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CameraEventUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr);
    CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraEventUtils>.NativeClassPtr, 100669628);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 482011, RefRangeEnd = 482014, XrefRangeStart = 482011, XrefRangeEnd = 482011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValid(CameraEvent value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraEventUtils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_CameraEvent_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public CameraEventUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
