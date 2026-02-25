// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.CrowdActorController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class CrowdActorController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_palettes;
  private static readonly IntPtr NativeFieldInfoPtr_paletteId;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Dictionary_2_Texture2D_Material_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CrowdActorController()
  {
    Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (CrowdActorController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr);
    CrowdActorController.NativeFieldInfoPtr_palettes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr, nameof (palettes));
    CrowdActorController.NativeFieldInfoPtr_paletteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr, nameof (paletteId));
    CrowdActorController.NativeMethodInfoPtr_Init_Public_Void_Dictionary_2_Texture2D_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr, 100675827);
    CrowdActorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr, 100675828);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119898, XrefRangeEnd = 119922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(Dictionary<Texture2D, Material> paletteMaterials)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) paletteMaterials)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdActorController.NativeMethodInfoPtr_Init_Public_Void_Dictionary_2_Texture2D_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119922, XrefRangeEnd = 119926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CrowdActorController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CrowdActorController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CrowdActorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<Texture2D> palettes
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdActorController.NativeFieldInfoPtr_palettes));
      return num == IntPtr.Zero ? (List<Texture2D>) null : Il2CppObjectPool.Get<List<Texture2D>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CrowdActorController.NativeFieldInfoPtr_palettes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int paletteId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdActorController.NativeFieldInfoPtr_paletteId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CrowdActorController.NativeFieldInfoPtr_paletteId)) = value;
    }
  }
}
