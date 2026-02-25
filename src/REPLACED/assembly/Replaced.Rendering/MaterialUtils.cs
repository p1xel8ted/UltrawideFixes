// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MaterialUtils
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public static class MaterialUtils : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_InitBlendModes_Public_Static_Void_BlendModePresets_byref_BlendMode_byref_BlendMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderQueueIndex_Public_Static_Int32_RenderQueueType_0;

  static MaterialUtils()
  {
    Il2CppClassPointerStore<MaterialUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MaterialUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialUtils>.NativeClassPtr);
    MaterialUtils.NativeMethodInfoPtr_InitBlendModes_Public_Static_Void_BlendModePresets_byref_BlendMode_byref_BlendMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialUtils>.NativeClassPtr, 100664075 /*0x0600030B*/);
    MaterialUtils.NativeMethodInfoPtr_GetRenderQueueIndex_Public_Static_Int32_RenderQueueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialUtils>.NativeClassPtr, 100664076 /*0x0600030C*/);
  }

  [CallerCount(0)]
  public static unsafe void InitBlendModes(
    BlendModePresets preset,
    out BlendMode src,
    out BlendMode dest)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &preset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref src;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref dest;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialUtils.NativeMethodInfoPtr_InitBlendModes_Public_Static_Void_BlendModePresets_byref_BlendMode_byref_BlendMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe int GetRenderQueueIndex(RenderQueueType renderQueue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &renderQueue
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialUtils.NativeMethodInfoPtr_GetRenderQueueIndex_Public_Static_Int32_RenderQueueType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public MaterialUtils(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
