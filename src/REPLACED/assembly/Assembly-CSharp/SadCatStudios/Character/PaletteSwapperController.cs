// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.PaletteSwapperController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class PaletteSwapperController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_paletteLut;
  private static readonly IntPtr NativeFieldInfoPtr_emissionColor;
  private static readonly IntPtr NativeFieldInfoPtr_emissionThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_TEXColorPalette;
  private static readonly IntPtr NativeFieldInfoPtr_TEXColorEmission;
  private static readonly IntPtr NativeFieldInfoPtr_TEXThresholdEmission;
  private static readonly IntPtr NativeMethodInfoPtr_SwapPalette_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PaletteSwapperController()
  {
    Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (PaletteSwapperController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr);
    PaletteSwapperController.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (spriteRenderer));
    PaletteSwapperController.NativeFieldInfoPtr_paletteLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (paletteLut));
    PaletteSwapperController.NativeFieldInfoPtr_emissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (emissionColor));
    PaletteSwapperController.NativeFieldInfoPtr_emissionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (emissionThreshold));
    PaletteSwapperController.NativeFieldInfoPtr_TEXColorPalette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (TEXColorPalette));
    PaletteSwapperController.NativeFieldInfoPtr_TEXColorEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (TEXColorEmission));
    PaletteSwapperController.NativeFieldInfoPtr_TEXThresholdEmission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, nameof (TEXThresholdEmission));
    PaletteSwapperController.NativeMethodInfoPtr_SwapPalette_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, 100675604);
    PaletteSwapperController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, 100675605);
    PaletteSwapperController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr, 100675606);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118353, XrefRangeEnd = 118378, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwapPalette()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PaletteSwapperController.NativeMethodInfoPtr_SwapPalette_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PaletteSwapperController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PaletteSwapperController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PaletteSwapperController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PaletteSwapperController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_spriteRenderer));
      return num == IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D paletteLut
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_paletteLut));
      return num == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_paletteLut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color emissionColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_emissionColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_emissionColor)) = value;
    }
  }

  public unsafe float emissionThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_emissionThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PaletteSwapperController.NativeFieldInfoPtr_emissionThreshold)) = value;
    }
  }

  public static unsafe int TEXColorPalette
  {
    get
    {
      int texColorPalette;
      IL2CPP.il2cpp_field_static_get_value(PaletteSwapperController.NativeFieldInfoPtr_TEXColorPalette, (void*) &texColorPalette);
      return texColorPalette;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PaletteSwapperController.NativeFieldInfoPtr_TEXColorPalette, (void*) &value);
    }
  }

  public static unsafe int TEXColorEmission
  {
    get
    {
      int texColorEmission;
      IL2CPP.il2cpp_field_static_get_value(PaletteSwapperController.NativeFieldInfoPtr_TEXColorEmission, (void*) &texColorEmission);
      return texColorEmission;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PaletteSwapperController.NativeFieldInfoPtr_TEXColorEmission, (void*) &value);
    }
  }

  public static unsafe int TEXThresholdEmission
  {
    get
    {
      int thresholdEmission;
      IL2CPP.il2cpp_field_static_get_value(PaletteSwapperController.NativeFieldInfoPtr_TEXThresholdEmission, (void*) &thresholdEmission);
      return thresholdEmission;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PaletteSwapperController.NativeFieldInfoPtr_TEXThresholdEmission, (void*) &value);
    }
  }
}
