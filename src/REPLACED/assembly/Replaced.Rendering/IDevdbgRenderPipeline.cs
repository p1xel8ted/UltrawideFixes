// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.IDevdbgRenderPipeline
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public class IDevdbgRenderPipeline(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kTexAmbientColorSourceSize;
  private static readonly IntPtr NativeMethodInfoPtr_get_TexAmbientColorSource_Public_Abstract_Virtual_New_get_RenderTextureResource_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BokehPointCount_Public_Abstract_Virtual_New_get_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_EncodeAfterAntiAliasing_Public_Abstract_Virtual_New_Void_CommandBuffer_RenderTextureResource_0;
  private static readonly IntPtr NativeMethodInfoPtr_EncodeAfterPostProcessing_Public_Abstract_Virtual_New_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetBokehPointCount_Public_Abstract_Virtual_New_Void_CommandBuffer_ComputeBuffer_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0;

  static IDevdbgRenderPipeline()
  {
    Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (IDevdbgRenderPipeline));
    IDevdbgRenderPipeline.NativeFieldInfoPtr_kTexAmbientColorSourceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, nameof (kTexAmbientColorSourceSize));
    IDevdbgRenderPipeline.NativeMethodInfoPtr_get_TexAmbientColorSource_Public_Abstract_Virtual_New_get_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, 100663462 /*0x060000A6*/);
    IDevdbgRenderPipeline.NativeMethodInfoPtr_get_BokehPointCount_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, 100663463 /*0x060000A7*/);
    IDevdbgRenderPipeline.NativeMethodInfoPtr_EncodeAfterAntiAliasing_Public_Abstract_Virtual_New_Void_CommandBuffer_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, 100663464 /*0x060000A8*/);
    IDevdbgRenderPipeline.NativeMethodInfoPtr_EncodeAfterPostProcessing_Public_Abstract_Virtual_New_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, 100663465 /*0x060000A9*/);
    IDevdbgRenderPipeline.NativeMethodInfoPtr_ResetBokehPointCount_Public_Abstract_Virtual_New_Void_CommandBuffer_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, 100663466 /*0x060000AA*/);
    IDevdbgRenderPipeline.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDevdbgRenderPipeline>.NativeClassPtr, 100663467 /*0x060000AB*/);
  }

  public virtual unsafe RenderTextureResource TexAmbientColorSource
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDevdbgRenderPipeline.NativeMethodInfoPtr_get_TexAmbientColorSource_Public_Abstract_Virtual_New_get_RenderTextureResource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new RenderTextureResource(pointer);
    }
  }

  public virtual unsafe uint BokehPointCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDevdbgRenderPipeline.NativeMethodInfoPtr_get_BokehPointCount_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void EncodeAfterAntiAliasing(
    CommandBuffer cmd,
    RenderTextureResource texColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColor));
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDevdbgRenderPipeline.NativeMethodInfoPtr_EncodeAfterAntiAliasing_Public_Abstract_Virtual_New_Void_CommandBuffer_RenderTextureResource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void EncodeAfterPostProcessing(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) ref ctx;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDevdbgRenderPipeline.NativeMethodInfoPtr_EncodeAfterPostProcessing_Public_Abstract_Virtual_New_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResetBokehPointCount(
    CommandBuffer cmd,
    ComputeBuffer bufferWithCounter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bufferWithCounter);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDevdbgRenderPipeline.NativeMethodInfoPtr_ResetBokehPointCount_Public_Abstract_Virtual_New_Void_CommandBuffer_ComputeBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IDevdbgRenderPipeline.NativeMethodInfoPtr_Release_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kTexAmbientColorSourceSize
  {
    get
    {
      Vector2Int ambientColorSourceSize;
      IL2CPP.il2cpp_field_static_get_value(IDevdbgRenderPipeline.NativeFieldInfoPtr_kTexAmbientColorSourceSize, (void*) &ambientColorSourceSize);
      return ambientColorSourceSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IDevdbgRenderPipeline.NativeFieldInfoPtr_kTexAmbientColorSourceSize, (void*) &value);
    }
  }
}
