// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.Character
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class Character(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_rimColor;
  private static readonly IntPtr NativeFieldInfoPtr_rimIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_highlightColor;
  private static readonly IntPtr NativeFieldInfoPtr_hightlightIntensity;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Character()
  {
    Il2CppClassPointerStore<Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (Character));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Character>.NativeClassPtr);
    Character.NativeFieldInfoPtr_rimColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (rimColor));
    Character.NativeFieldInfoPtr_rimIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (rimIntensity));
    Character.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (highlightColor));
    Character.NativeFieldInfoPtr_hightlightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, nameof (hightlightIntensity));
    Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100663579);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926430, XrefRangeEnd = 926445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Character()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ColorParameter rimColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_rimColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_rimColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter rimIntensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_rimIntensity));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_rimIntensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter highlightColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_highlightColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_highlightColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter hightlightIntensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_hightlightIntensity));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_hightlightIntensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
