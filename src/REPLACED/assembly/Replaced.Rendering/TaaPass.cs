// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.TaaPass
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

public sealed class TaaPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexColorHistory;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSceneDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutput;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_AntiAliasingParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector2Int_byref_AntiAliasingParams_0;

  static TaaPass()
  {
    Il2CppClassPointerStore<TaaPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (TaaPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaPass>.NativeClassPtr);
    TaaPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (kGroupSize));
    TaaPass.NativeFieldInfoPtr_kSidTexSceneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (kSidTexSceneColor));
    TaaPass.NativeFieldInfoPtr_kSidTexColorHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (kSidTexColorHistory));
    TaaPass.NativeFieldInfoPtr_kSidTexSceneDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (kSidTexSceneDepth));
    TaaPass.NativeFieldInfoPtr_kSidTexOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (kSidTexOutput));
    TaaPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (_cbuffer));
    TaaPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (_compute));
    TaaPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, nameof (_kernel));
    TaaPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, 100664184);
    TaaPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_AntiAliasingParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, 100664185);
    TaaPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, 100664186);
    TaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector2Int_byref_AntiAliasingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPass>.NativeClassPtr, 100664187);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934376, XrefRangeEnd = 934388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TaaPass(ComputeShader taaCompute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaaPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) taaCompute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TaaPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934420, RefRangeEnd = 934421, XrefRangeStart = 934388, XrefRangeEnd = 934420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref AntiAliasingParams antiAliasing,
    RenderTextureResource texSceneColor,
    RenderTextureResource texSceneDepth,
    RenderTextureResource texHistoryColor,
    RenderTextureResource texOutput)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref antiAliasing;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texHistoryColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutput));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TaaPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_AntiAliasingParams_RenderTextureResource_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934421, XrefRangeEnd = 934425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TaaPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934425, XrefRangeEnd = 934448, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref Vector2Int textureSize,
    [In] ref AntiAliasingParams antiAliasing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref textureSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref antiAliasing;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TaaPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector2Int_byref_AntiAliasingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(TaaPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TaaPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneColor
  {
    get
    {
      int sidTexSceneColor;
      IL2CPP.il2cpp_field_static_get_value(TaaPass.NativeFieldInfoPtr_kSidTexSceneColor, (void*) &sidTexSceneColor);
      return sidTexSceneColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TaaPass.NativeFieldInfoPtr_kSidTexSceneColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexColorHistory
  {
    get
    {
      int sidTexColorHistory;
      IL2CPP.il2cpp_field_static_get_value(TaaPass.NativeFieldInfoPtr_kSidTexColorHistory, (void*) &sidTexColorHistory);
      return sidTexColorHistory;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TaaPass.NativeFieldInfoPtr_kSidTexColorHistory, (void*) &value);
    }
  }

  public static unsafe int kSidTexSceneDepth
  {
    get
    {
      int sidTexSceneDepth;
      IL2CPP.il2cpp_field_static_get_value(TaaPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &sidTexSceneDepth);
      return sidTexSceneDepth;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TaaPass.NativeFieldInfoPtr_kSidTexSceneDepth, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutput
  {
    get
    {
      int kSidTexOutput;
      IL2CPP.il2cpp_field_static_get_value(TaaPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &kSidTexOutput);
      return kSidTexOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TaaPass.NativeFieldInfoPtr_kSidTexOutput, (void*) &value);
    }
  }

  public unsafe CBuffer<TaaCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TaaPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<TaaCBufferData>) null : Il2CppObjectPool.Get<CBuffer<TaaCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TaaPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TaaPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TaaPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TaaPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TaaPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }
}
