// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.OnDemandRendering
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public class OnDemandRendering(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderFrameInterval;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0;
  private static readonly OnDemandRendering.GetEffectiveRenderFrameRateDelegate GetEffectiveRenderFrameRateDelegateField;

  static OnDemandRendering()
  {
    Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (OnDemandRendering));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr);
    OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, nameof (m_RenderFrameInterval));
    OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100669708);
    OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100669709);
    OnDemandRendering.GetEffectiveRenderFrameRateDelegateField = IL2CPP.ResolveICall<OnDemandRendering.GetEffectiveRenderFrameRateDelegate>("UnityEngine.Rendering.OnDemandRendering::GetEffectiveRenderFrameRate");
  }

  public static unsafe int renderFrameInterval
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482558, XrefRangeEnd = 482562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => OnDemandRendering.m_RenderFrameInterval = Il2CppSystem.Math.Max(1, value);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482562, XrefRangeEnd = 482569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetRenderFrameInterval(out int frameInterval)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref frameInterval
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int m_RenderFrameInterval
  {
    get
    {
      int renderFrameInterval;
      IL2CPP.il2cpp_field_static_get_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*) &renderFrameInterval);
      return renderFrameInterval;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*) &value);
    }
  }

  public static bool willCurrentFrameRender
  {
    get => Time.frameCount % OnDemandRendering.renderFrameInterval == 0;
  }

  public static float GetEffectiveRenderFrameRate()
  {
    return OnDemandRendering.GetEffectiveRenderFrameRateDelegateField();
  }

  public static int effectiveRenderFrameRate
  {
    get
    {
      float effectiveRenderFrameRate = OnDemandRendering.GetEffectiveRenderFrameRate();
      return (double) effectiveRenderFrameRate <= 0.0 ? (int) effectiveRenderFrameRate : (int) ((double) effectiveRenderFrameRate + 0.5);
    }
  }

  private delegate float GetEffectiveRenderFrameRateDelegate();
}
