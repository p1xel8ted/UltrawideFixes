// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GenerateMipmapsSceneColorPass
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

public sealed class GenerateMipmapsSceneColorPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputSceneColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexOutputSceneColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GenerateMipmapsSceneColorPass()
  {
    Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GenerateMipmapsSceneColorPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr);
    GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (kGroupSize));
    GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kSidTexInputSceneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (kSidTexInputSceneColor));
    GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kSidTexOutputSceneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (kSidTexOutputSceneColor));
    GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (_cbuffer));
    GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (_compute));
    GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (_kernel));
    GenerateMipmapsSceneColorPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, 100664161);
    GenerateMipmapsSceneColorPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, 100664162);
    GenerateMipmapsSceneColorPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, 100664163);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933956, XrefRangeEnd = 933968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenerateMipmapsSceneColorPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateMipmapsSceneColorPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933968, XrefRangeEnd = 933994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    [In] ref RenderTextureResource texInputSceneColor,
    [In] ref RenderTextureResource texOutputSceneColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texInputSceneColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texOutputSceneColor);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateMipmapsSceneColorPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_byref_RenderTextureResource_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933994, XrefRangeEnd = 934008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenerateMipmapsSceneColorPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputSceneColor
  {
    get
    {
      int texInputSceneColor;
      IL2CPP.il2cpp_field_static_get_value(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kSidTexInputSceneColor, (void*) &texInputSceneColor);
      return texInputSceneColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kSidTexInputSceneColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexOutputSceneColor
  {
    get
    {
      int outputSceneColor;
      IL2CPP.il2cpp_field_static_get_value(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kSidTexOutputSceneColor, (void*) &outputSceneColor);
      return outputSceneColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr_kSidTexOutputSceneColor, (void*) &value);
    }
  }

  public unsafe CBuffer<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer>) null : Il2CppObjectPool.Get<CBuffer<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenerateMipmapsSceneColorPass.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GenerateMipmapsSceneColorCBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texCoordScaleOffset;
    [FieldOffset(0)]
    public Vector4 texCoordScaleOffset;

    static GenerateMipmapsSceneColorCBuffer()
    {
      Il2CppClassPointerStore<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass>.NativeClassPtr, nameof (GenerateMipmapsSceneColorCBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer>.NativeClassPtr);
      GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer.NativeFieldInfoPtr_texCoordScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer>.NativeClassPtr, nameof (texCoordScaleOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenerateMipmapsSceneColorPass.GenerateMipmapsSceneColorCBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
