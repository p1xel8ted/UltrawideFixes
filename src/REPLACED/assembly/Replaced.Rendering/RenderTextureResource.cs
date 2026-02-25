// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.RenderTextureResource
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

public sealed class RenderTextureResource : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexNone;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexSmallBlackTexture;
  private static readonly System.IntPtr NativeFieldInfoPtr_texture;
  private static readonly System.IntPtr NativeFieldInfoPtr_rtid;
  private static readonly System.IntPtr NativeFieldInfoPtr__resourceKind;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCameraTarget_Public_Static_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakePersistent_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeTransient_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_RenderTexture_byref_RenderTargetIdentifier_RenderTextureResourceKind_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Descriptor_Public_get_RenderTextureDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPersistentTextureMissing_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNone_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumeSize_Public_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AllocateContentsIfNecessary_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static RenderTextureResource()
  {
    Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (RenderTextureResource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr);
    RenderTextureResource.NativeFieldInfoPtr_kTexNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, nameof (kTexNone));
    RenderTextureResource.NativeFieldInfoPtr_kTexSmallBlackTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, nameof (kTexSmallBlackTexture));
    RenderTextureResource.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, nameof (texture));
    RenderTextureResource.NativeFieldInfoPtr_rtid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, nameof (rtid));
    RenderTextureResource.NativeFieldInfoPtr__resourceKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, nameof (_resourceKind));
    RenderTextureResource.NativeMethodInfoPtr_MakeCameraTarget_Public_Static_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663355 /*0x0600003B*/);
    RenderTextureResource.NativeMethodInfoPtr_MakePersistent_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663356 /*0x0600003C*/);
    RenderTextureResource.NativeMethodInfoPtr_MakeTransient_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663357 /*0x0600003D*/);
    RenderTextureResource.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663358 /*0x0600003E*/);
    RenderTextureResource.NativeMethodInfoPtr__ctor_Private_Void_RenderTexture_byref_RenderTargetIdentifier_RenderTextureResourceKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663359 /*0x0600003F*/);
    RenderTextureResource.NativeMethodInfoPtr_get_Descriptor_Public_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663360 /*0x06000040*/);
    RenderTextureResource.NativeMethodInfoPtr_get_IsPersistentTextureMissing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663361 /*0x06000041*/);
    RenderTextureResource.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663362 /*0x06000042*/);
    RenderTextureResource.NativeMethodInfoPtr_get_IsNone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663363 /*0x06000043*/);
    RenderTextureResource.NativeMethodInfoPtr_get_Size_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663364 /*0x06000044*/);
    RenderTextureResource.NativeMethodInfoPtr_get_VolumeSize_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663365 /*0x06000045*/);
    RenderTextureResource.NativeMethodInfoPtr_AllocateContentsIfNecessary_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663366 /*0x06000046*/);
    RenderTextureResource.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, 100663367 /*0x06000047*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924417, XrefRangeEnd = 924418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeCameraTarget()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_MakeCameraTarget_Public_Static_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 924424, RefRangeEnd = 924432, XrefRangeStart = 924418, XrefRangeEnd = 924424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakePersistent(
    string label,
    [In] ref RenderTextureDescriptor desc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref desc;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_MakePersistent_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(37)]
  [CachedScanResults(RefRangeStart = 924435, RefRangeEnd = 924472, XrefRangeStart = 924432, XrefRangeEnd = 924435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RenderTextureResource MakeTransient(
    string label,
    [In] ref RenderTextureDescriptor desc)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref desc;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_MakeTransient_Public_Static_RenderTextureResource_String_byref_RenderTextureDescriptor_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  public static unsafe implicit operator RenderTargetIdentifier(RenderTextureResource tex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) tex))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_RenderTextureResource_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderTargetIdentifier*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe RenderTextureResource(
    RenderTexture texture,
    [In] ref RenderTargetIdentifier rtid,
    RenderTextureResourceKind kind)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rtid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &kind;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr__ctor_Private_Void_RenderTexture_byref_RenderTargetIdentifier_RenderTextureResourceKind_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe RenderTextureDescriptor Descriptor
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 924473, RefRangeEnd = 924479, XrefRangeStart = 924472, XrefRangeEnd = 924473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_get_Descriptor_Public_get_RenderTextureDescriptor_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTextureDescriptor*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsPersistentTextureMissing
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924479, XrefRangeEnd = 924480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_get_IsPersistentTextureMissing_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsValid
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 924484, RefRangeEnd = 924499, XrefRangeStart = 924480, XrefRangeEnd = 924484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsNone
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_get_IsNone_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2Int Size
  {
    [CallerCount(62), CachedScanResults(RefRangeStart = 924499, RefRangeEnd = 924561, XrefRangeStart = 924499, XrefRangeEnd = 924499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_get_Size_Public_get_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3Int VolumeSize
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 924562, RefRangeEnd = 924564, XrefRangeStart = 924561, XrefRangeEnd = 924562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_get_VolumeSize_Public_get_Vector3Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 924570, RefRangeEnd = 924614, XrefRangeStart = 924564, XrefRangeEnd = 924570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AllocateContentsIfNecessary()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_AllocateContentsIfNecessary_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(50)]
  [CachedScanResults(RefRangeStart = 924619, RefRangeEnd = 924669, XrefRangeStart = 924614, XrefRangeEnd = 924619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTextureResource.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public RenderTextureResource(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public RenderTextureResource()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr))
  {
  }

  public static unsafe RenderTextureResource kTexNone
  {
    get
    {
      System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(RenderTextureResource.NativeFieldInfoPtr_kTexNone, (void*) num);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderTextureResource.NativeFieldInfoPtr_kTexNone, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public static unsafe RenderTextureResource kTexSmallBlackTexture
  {
    get
    {
      System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(RenderTextureResource.NativeFieldInfoPtr_kTexSmallBlackTexture, (void*) num);
      return new RenderTextureResource(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureResource>.NativeClassPtr, num));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderTextureResource.NativeFieldInfoPtr_kTexSmallBlackTexture, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public unsafe RenderTexture texture
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureResource.NativeFieldInfoPtr_texture));
      return num == System.IntPtr.Zero ? (RenderTexture) null : Il2CppObjectPool.Get<RenderTexture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureResource.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTargetIdentifier rtid
  {
    get
    {
      return *(RenderTargetIdentifier*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureResource.NativeFieldInfoPtr_rtid));
    }
    [param: In] set
    {
      *(RenderTargetIdentifier*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureResource.NativeFieldInfoPtr_rtid)) = value;
    }
  }

  public unsafe RenderTextureResourceKind _resourceKind
  {
    get
    {
      return *(RenderTextureResourceKind*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureResource.NativeFieldInfoPtr__resourceKind));
    }
    [param: In] set
    {
      *(RenderTextureResourceKind*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTextureResource.NativeFieldInfoPtr__resourceKind)) = value;
    }
  }
}
