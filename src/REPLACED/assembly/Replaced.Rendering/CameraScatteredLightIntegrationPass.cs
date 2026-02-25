// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CameraScatteredLightIntegrationPass
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

public sealed class CameraScatteredLightIntegrationPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kThreadGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDensityBufferLit;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCameraScatteredLight;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_Vector3Int_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector3Int_0;

  static CameraScatteredLightIntegrationPass()
  {
    Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CameraScatteredLightIntegrationPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr);
    CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kThreadGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, nameof (kThreadGroupSize));
    CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kSidTexDensityBufferLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, nameof (kSidTexDensityBufferLit));
    CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kSidTexCameraScatteredLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, nameof (kSidTexCameraScatteredLight));
    CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, nameof (_cbuffer));
    CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, nameof (_compute));
    CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, nameof (_kernel));
    CameraScatteredLightIntegrationPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, 100664238);
    CameraScatteredLightIntegrationPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_Vector3Int_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, 100664239);
    CameraScatteredLightIntegrationPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, 100664240 /*0x060003B0*/);
    CameraScatteredLightIntegrationPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr, 100664241);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935390, XrefRangeEnd = 935402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraScatteredLightIntegrationPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraScatteredLightIntegrationPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraScatteredLightIntegrationPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 935421, RefRangeEnd = 935422, XrefRangeStart = 935402, XrefRangeEnd = 935421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref Vector3Int volumeSize,
    [In] ref RenderTextureResource texDensityBufferLit,
    [In] ref RenderTextureResource texCameraScatteredLight)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumeSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texDensityBufferLit);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCameraScatteredLight);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraScatteredLightIntegrationPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_Vector3Int_byref_RenderTextureResource_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935422, XrefRangeEnd = 935426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraScatteredLightIntegrationPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935426, XrefRangeEnd = 935440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(CommandBuffer cmd, [In] ref Vector3Int volumeSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref volumeSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraScatteredLightIntegrationPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector3Int kThreadGroupSize
  {
    get
    {
      Vector3Int kThreadGroupSize;
      IL2CPP.il2cpp_field_static_get_value(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kThreadGroupSize, (void*) &kThreadGroupSize);
      return kThreadGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kThreadGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexDensityBufferLit
  {
    get
    {
      int densityBufferLit;
      IL2CPP.il2cpp_field_static_get_value(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kSidTexDensityBufferLit, (void*) &densityBufferLit);
      return densityBufferLit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kSidTexDensityBufferLit, (void*) &value);
    }
  }

  public static unsafe int kSidTexCameraScatteredLight
  {
    get
    {
      int cameraScatteredLight;
      IL2CPP.il2cpp_field_static_get_value(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kSidTexCameraScatteredLight, (void*) &cameraScatteredLight);
      return cameraScatteredLight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr_kSidTexCameraScatteredLight, (void*) &value);
    }
  }

  public unsafe CBuffer<CameraScatteredLightIntegrationCBuffer> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<CameraScatteredLightIntegrationCBuffer>) null : Il2CppObjectPool.Get<CBuffer<CameraScatteredLightIntegrationCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraScatteredLightIntegrationPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }
}
