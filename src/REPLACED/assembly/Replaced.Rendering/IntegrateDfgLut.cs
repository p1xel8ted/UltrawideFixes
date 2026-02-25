// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.IntegrateDfgLut
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

public sealed class IntegrateDfgLut(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kDfgLutSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDfgLut;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexDfgLutResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexDfgLutDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__kernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__texDfgLut;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTexDfgLut_Private_Static_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static IntegrateDfgLut()
  {
    Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (IntegrateDfgLut));
    IntegrateDfgLut.NativeFieldInfoPtr_kGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (kGroupSize));
    IntegrateDfgLut.NativeFieldInfoPtr_kDfgLutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (kDfgLutSize));
    IntegrateDfgLut.NativeFieldInfoPtr_kSidTexDfgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (kSidTexDfgLut));
    IntegrateDfgLut.NativeFieldInfoPtr_kSidTexDfgLutResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (kSidTexDfgLutResult));
    IntegrateDfgLut.NativeFieldInfoPtr_kTexDfgLutDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (kTexDfgLutDesc));
    IntegrateDfgLut.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (_compute));
    IntegrateDfgLut.NativeFieldInfoPtr__kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (_kernel));
    IntegrateDfgLut.NativeFieldInfoPtr__texDfgLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, nameof (_texDfgLut));
    IntegrateDfgLut.NativeMethodInfoPtr_MakeTexDfgLut_Private_Static_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, 100663919);
    IntegrateDfgLut.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, 100663920 /*0x06000270*/);
    IntegrateDfgLut.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, 100663921);
    IntegrateDfgLut.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr, 100663922);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930820, XrefRangeEnd = 930831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTexDfgLut()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IntegrateDfgLut.NativeMethodInfoPtr_MakeTexDfgLut_Private_Static_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930835, RefRangeEnd = 930836, XrefRangeStart = 930831, XrefRangeEnd = 930835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IntegrateDfgLut(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegrateDfgLut>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateDfgLut.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 930836, XrefRangeEnd = 930884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateDfgLut.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 930923, RefRangeEnd = 930924, XrefRangeStart = 930884, XrefRangeEnd = 930923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntegrateDfgLut.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Vector2Int kGroupSize
  {
    get
    {
      Vector2Int kGroupSize;
      IL2CPP.il2cpp_field_static_get_value(IntegrateDfgLut.NativeFieldInfoPtr_kGroupSize, (void*) &kGroupSize);
      return kGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateDfgLut.NativeFieldInfoPtr_kGroupSize, (void*) &value);
    }
  }

  public static unsafe Vector2Int kDfgLutSize
  {
    get
    {
      Vector2Int kDfgLutSize;
      IL2CPP.il2cpp_field_static_get_value(IntegrateDfgLut.NativeFieldInfoPtr_kDfgLutSize, (void*) &kDfgLutSize);
      return kDfgLutSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateDfgLut.NativeFieldInfoPtr_kDfgLutSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexDfgLut
  {
    get
    {
      int kSidTexDfgLut;
      IL2CPP.il2cpp_field_static_get_value(IntegrateDfgLut.NativeFieldInfoPtr_kSidTexDfgLut, (void*) &kSidTexDfgLut);
      return kSidTexDfgLut;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateDfgLut.NativeFieldInfoPtr_kSidTexDfgLut, (void*) &value);
    }
  }

  public static unsafe int kSidTexDfgLutResult
  {
    get
    {
      int sidTexDfgLutResult;
      IL2CPP.il2cpp_field_static_get_value(IntegrateDfgLut.NativeFieldInfoPtr_kSidTexDfgLutResult, (void*) &sidTexDfgLutResult);
      return sidTexDfgLutResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateDfgLut.NativeFieldInfoPtr_kSidTexDfgLutResult, (void*) &value);
    }
  }

  public static unsafe RenderTextureDescriptor kTexDfgLutDesc
  {
    get
    {
      RenderTextureDescriptor kTexDfgLutDesc;
      IL2CPP.il2cpp_field_static_get_value(IntegrateDfgLut.NativeFieldInfoPtr_kTexDfgLutDesc, (void*) &kTexDfgLutDesc);
      return kTexDfgLutDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(IntegrateDfgLut.NativeFieldInfoPtr_kTexDfgLutDesc, (void*) &value);
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateDfgLut.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IntegrateDfgLut.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _kernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateDfgLut.NativeFieldInfoPtr__kernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateDfgLut.NativeFieldInfoPtr__kernel)) = value;
    }
  }

  public RenderTextureResource _texDfgLut
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateDfgLut.NativeFieldInfoPtr__texDfgLut);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntegrateDfgLut.NativeFieldInfoPtr__texDfgLut), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
