// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MipmapTexturePyramid
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

public sealed class MipmapTexturePyramid(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__textures;
  private static readonly System.IntPtr NativeFieldInfoPtr__textureNames;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_RenderTextureResource_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameSetup_Public_Int32_Vector2Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrameRelease_Public_Void_0;

  static MipmapTexturePyramid()
  {
    Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MipmapTexturePyramid));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr);
    MipmapTexturePyramid.NativeFieldInfoPtr__textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr, nameof (_textures));
    MipmapTexturePyramid.NativeFieldInfoPtr__textureNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr, nameof (_textureNames));
    MipmapTexturePyramid.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr, 100664165);
    MipmapTexturePyramid.NativeMethodInfoPtr_get_Item_Public_get_RenderTextureResource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr, 100664166);
    MipmapTexturePyramid.NativeMethodInfoPtr_FrameSetup_Public_Int32_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr, 100664167);
    MipmapTexturePyramid.NativeMethodInfoPtr_FrameRelease_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr, 100664168);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934008, XrefRangeEnd = 934021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MipmapTexturePyramid(string textureName, int maxMipmapCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MipmapTexturePyramid>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(textureName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxMipmapCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MipmapTexturePyramid.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe RenderTextureResource this[int index]
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MipmapTexturePyramid.NativeMethodInfoPtr_get_Item_Public_get_RenderTextureResource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new RenderTextureResource(pointer);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934021, XrefRangeEnd = 934042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int FrameSetup(Vector2Int sizeMip0, int mipmapCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sizeMip0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipmapCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MipmapTexturePyramid.NativeMethodInfoPtr_FrameSetup_Public_Int32_Vector2Int_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934042, XrefRangeEnd = 934047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FrameRelease()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MipmapTexturePyramid.NativeMethodInfoPtr_FrameRelease_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<RenderTextureResource> _textures
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MipmapTexturePyramid.NativeFieldInfoPtr__textures));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RenderTextureResource>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTextureResource>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MipmapTexturePyramid.NativeFieldInfoPtr__textures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray _textureNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MipmapTexturePyramid.NativeFieldInfoPtr__textureNames));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MipmapTexturePyramid.NativeFieldInfoPtr__textureNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
