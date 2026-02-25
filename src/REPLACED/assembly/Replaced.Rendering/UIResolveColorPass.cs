// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIResolveColorPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class UIResolveColorPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexUIColorMsaaX4;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel_x2;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel_x4;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel_x8;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAppropriateKernel_Private_Int32_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static UIResolveColorPass()
  {
    Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIResolveColorPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr);
    UIResolveColorPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (kGroupSize));
    UIResolveColorPass.NativeFieldInfoPtr_kSidTexUIColorMsaaX4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (kSidTexUIColorMsaaX4));
    UIResolveColorPass.NativeFieldInfoPtr_kSidTexOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (kSidTexOutput));
    UIResolveColorPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (_compute));
    UIResolveColorPass.NativeFieldInfoPtr__kernel_x2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (_kernel_x2));
    UIResolveColorPass.NativeFieldInfoPtr__kernel_x4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (_kernel_x4));
    UIResolveColorPass.NativeFieldInfoPtr__kernel_x8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, nameof (_kernel_x8));
    UIResolveColorPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, 100664233);
    UIResolveColorPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, 100664234);
    UIResolveColorPass.NativeMethodInfoPtr_GetAppropriateKernel_Private_Int32_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, 100664235);
    UIResolveColorPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr, 100664236);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935331, XrefRangeEnd = 935341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIResolveColorPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIResolveColorPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIResolveColorPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935383, RefRangeEnd = 935384, XrefRangeStart = 935341, XrefRangeEnd = 935383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    RenderTextureResource texUIColorMsaa,
    RenderTextureResource texUIColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIColorMsaa));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIColor));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIResolveColorPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935384, XrefRangeEnd = 935390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetAppropriateKernel(RenderTextureResource texMsaa)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texMsaa))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIResolveColorPass.NativeMethodInfoPtr_GetAppropriateKernel_Private_Int32_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIResolveColorPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(UIResolveColorPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIResolveColorPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexUIColorMsaaX4
  {
    get
    {
      int texUiColorMsaaX4;
      IL2CPP.il2cpp_field_static_get_value(UIResolveColorPass.NativeFieldInfoPtr_kSidTexUIColorMsaaX4, (void*) &texUiColorMsaaX4);
      return texUiColorMsaaX4;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIResolveColorPass.NativeFieldInfoPtr_kSidTexUIColorMsaaX4, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutput
  {
    get
    {
      int kSidTexOutput;
      IL2CPP.il2cpp_field_static_get_value(UIResolveColorPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &kSidTexOutput);
      return kSidTexOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIResolveColorPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &value);
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel_x2
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__kernel_x2));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__kernel_x2)) = value;
    }
  }

  public unsafe int _kernel_x4
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__kernel_x4));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__kernel_x4)) = value;
    }
  }

  public unsafe int _kernel_x8
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__kernel_x8));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIResolveColorPass.NativeFieldInfoPtr__kernel_x8)) = value;
    }
  }
}
