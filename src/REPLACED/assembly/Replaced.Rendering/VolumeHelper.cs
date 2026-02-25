// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VolumeHelper
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public static class VolumeHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Single_ClampedFloatParameter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Single_MaxFloatParameter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_Single_MinFloatParameter_0;

  static VolumeHelper()
  {
    Il2CppClassPointerStore<VolumeHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VolumeHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumeHelper>.NativeClassPtr);
    VolumeHelper.NativeMethodInfoPtr_Get_Public_Static_Single_ClampedFloatParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeHelper>.NativeClassPtr, 100663664 /*0x06000170*/);
    VolumeHelper.NativeMethodInfoPtr_Get_Public_Static_Single_MaxFloatParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeHelper>.NativeClassPtr, 100663665);
    VolumeHelper.NativeMethodInfoPtr_Get_Public_Static_Single_MinFloatParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumeHelper>.NativeClassPtr, 100663666);
  }

  [CallerCount(0)]
  public static unsafe float Get(ClampedFloatParameter p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VolumeHelper.NativeMethodInfoPtr_Get_Public_Static_Single_ClampedFloatParameter_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Get(MaxFloatParameter p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VolumeHelper.NativeMethodInfoPtr_Get_Public_Static_Single_MaxFloatParameter_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe float Get(MinFloatParameter p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VolumeHelper.NativeMethodInfoPtr_Get_Public_Static_Single_MinFloatParameter_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public VolumeHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
