// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.BloomTexturePyramid
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class BloomTexturePyramid(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kDonwsampleTextureCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kUpsampleTextureCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_downsampleTextures;
  private static readonly System.IntPtr NativeFieldInfoPtr_upsampleTextures;
  private static readonly System.IntPtr NativeFieldInfoPtr__downsampleTextureNames;
  private static readonly System.IntPtr NativeFieldInfoPtr__upsampleTextureNames;
  private static readonly System.IntPtr NativeFieldInfoPtr__textureDescriptorPrototype;
  private static readonly System.IntPtr NativeFieldInfoPtr__textureCount;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DownsampleIterationCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UpsampleIterationCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameSetup_Public_Void_byref_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameRelease_Public_Void_0;

  static BloomTexturePyramid()
  {
    Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (BloomTexturePyramid));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr);
    BloomTexturePyramid.NativeFieldInfoPtr_kDonwsampleTextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (kDonwsampleTextureCount));
    BloomTexturePyramid.NativeFieldInfoPtr_kUpsampleTextureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (kUpsampleTextureCount));
    BloomTexturePyramid.NativeFieldInfoPtr_downsampleTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (downsampleTextures));
    BloomTexturePyramid.NativeFieldInfoPtr_upsampleTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (upsampleTextures));
    BloomTexturePyramid.NativeFieldInfoPtr__downsampleTextureNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (_downsampleTextureNames));
    BloomTexturePyramid.NativeFieldInfoPtr__upsampleTextureNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (_upsampleTextureNames));
    BloomTexturePyramid.NativeFieldInfoPtr__textureDescriptorPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (_textureDescriptorPrototype));
    BloomTexturePyramid.NativeFieldInfoPtr__textureCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, nameof (_textureCount));
    BloomTexturePyramid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, 100664083);
    BloomTexturePyramid.NativeMethodInfoPtr_get_DownsampleIterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, 100664084);
    BloomTexturePyramid.NativeMethodInfoPtr_get_UpsampleIterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, 100664085);
    BloomTexturePyramid.NativeMethodInfoPtr_FrameSetup_Public_Void_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, 100664086);
    BloomTexturePyramid.NativeMethodInfoPtr_FrameRelease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr, 100664087);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932581, RefRangeEnd = 932583, XrefRangeStart = 932550, XrefRangeEnd = 932581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BloomTexturePyramid()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomTexturePyramid>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomTexturePyramid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int DownsampleIterationCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomTexturePyramid.NativeMethodInfoPtr_get_DownsampleIterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int UpsampleIterationCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomTexturePyramid.NativeMethodInfoPtr_get_UpsampleIterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 932602, RefRangeEnd = 932604, XrefRangeStart = 932583, XrefRangeEnd = 932602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FrameSetup([In] ref Vector2Int renderTargetSize)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref renderTargetSize
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomTexturePyramid.NativeMethodInfoPtr_FrameSetup_Public_Void_byref_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 932611, RefRangeEnd = 932616, XrefRangeStart = 932604, XrefRangeEnd = 932611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FrameRelease()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomTexturePyramid.NativeMethodInfoPtr_FrameRelease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kDonwsampleTextureCount
  {
    get
    {
      int donwsampleTextureCount;
      IL2CPP.il2cpp_field_static_get_value(BloomTexturePyramid.NativeFieldInfoPtr_kDonwsampleTextureCount, (void*) &donwsampleTextureCount);
      return donwsampleTextureCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomTexturePyramid.NativeFieldInfoPtr_kDonwsampleTextureCount, (void*) &value);
    }
  }

  public static unsafe int kUpsampleTextureCount
  {
    get
    {
      int upsampleTextureCount;
      IL2CPP.il2cpp_field_static_get_value(BloomTexturePyramid.NativeFieldInfoPtr_kUpsampleTextureCount, (void*) &upsampleTextureCount);
      return upsampleTextureCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomTexturePyramid.NativeFieldInfoPtr_kUpsampleTextureCount, (void*) &value);
    }
  }

  public unsafe Il2CppReferenceArray<RenderTextureResource> downsampleTextures
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr_downsampleTextures));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RenderTextureResource>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTextureResource>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr_downsampleTextures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<RenderTextureResource> upsampleTextures
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr_upsampleTextures));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RenderTextureResource>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTextureResource>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr_upsampleTextures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray _downsampleTextureNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__downsampleTextureNames));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__downsampleTextureNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray _upsampleTextureNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__upsampleTextureNames));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__upsampleTextureNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTextureDescriptor _textureDescriptorPrototype
  {
    get
    {
      return *(RenderTextureDescriptor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__textureDescriptorPrototype));
    }
    [param: In] set
    {
      *(RenderTextureDescriptor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__textureDescriptorPrototype)) = value;
    }
  }

  public unsafe int _textureCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__textureCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BloomTexturePyramid.NativeFieldInfoPtr__textureCount)) = value;
    }
  }
}
