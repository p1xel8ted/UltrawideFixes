// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MaskDecal
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public class MaskDecal(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kFalloffEnd;
  private static readonly IntPtr NativeFieldInfoPtr_mainFalloffStart;
  private static readonly IntPtr NativeFieldInfoPtr_mainFalloffEnd;
  private static readonly IntPtr NativeFieldInfoPtr_mainFalloffLength;
  private static readonly IntPtr NativeFieldInfoPtr_mainFalloffSaturation;
  private static readonly IntPtr NativeFieldInfoPtr_sideFalloffLength;
  private static readonly IntPtr NativeFieldInfoPtr_texMask;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MaskDecal()
  {
    Il2CppClassPointerStore<MaskDecal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MaskDecal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr);
    MaskDecal.NativeFieldInfoPtr_kFalloffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (kFalloffEnd));
    MaskDecal.NativeFieldInfoPtr_mainFalloffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (mainFalloffStart));
    MaskDecal.NativeFieldInfoPtr_mainFalloffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (mainFalloffEnd));
    MaskDecal.NativeFieldInfoPtr_mainFalloffLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (mainFalloffLength));
    MaskDecal.NativeFieldInfoPtr_mainFalloffSaturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (mainFalloffSaturation));
    MaskDecal.NativeFieldInfoPtr_sideFalloffLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (sideFalloffLength));
    MaskDecal.NativeFieldInfoPtr_texMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, nameof (texMask));
    MaskDecal.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, 100663725);
    MaskDecal.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, 100663726);
    MaskDecal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr, 100663727);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928138, XrefRangeEnd = 928149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecal.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928149, XrefRangeEnd = 928160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecal.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928160, XrefRangeEnd = 928161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MaskDecal()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskDecal>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kFalloffEnd
  {
    get
    {
      float kFalloffEnd;
      IL2CPP.il2cpp_field_static_get_value(MaskDecal.NativeFieldInfoPtr_kFalloffEnd, (void*) &kFalloffEnd);
      return kFalloffEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecal.NativeFieldInfoPtr_kFalloffEnd, (void*) &value);
    }
  }

  public unsafe float mainFalloffStart
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffStart));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffStart)) = value;
    }
  }

  public unsafe float mainFalloffEnd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffEnd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffEnd)) = value;
    }
  }

  public unsafe float mainFalloffLength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffLength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffLength)) = value;
    }
  }

  public unsafe float mainFalloffSaturation
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffSaturation));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_mainFalloffSaturation)) = value;
    }
  }

  public unsafe float sideFalloffLength
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_sideFalloffLength));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_sideFalloffLength)) = value;
    }
  }

  public unsafe Texture2D texMask
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_texMask));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecal.NativeFieldInfoPtr_texMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
