// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphSelectorOptionsSO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Glyphs;

[Serializable]
public class ControllerElementGlyphSelectorOptionsSO(IntPtr pointer) : 
  ControllerElementGlyphSelectorOptionsSOBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__options;
  private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_Virtual_get_ControllerElementGlyphSelectorOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ControllerElementGlyphSelectorOptionsSO()
  {
    Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (ControllerElementGlyphSelectorOptionsSO));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSO>.NativeClassPtr);
    ControllerElementGlyphSelectorOptionsSO.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSO>.NativeClassPtr, nameof (_options));
    ControllerElementGlyphSelectorOptionsSO.NativeMethodInfoPtr_get_options_Public_Virtual_get_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSO>.NativeClassPtr, 100668546);
    ControllerElementGlyphSelectorOptionsSO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSO>.NativeClassPtr, 100668547);
  }

  public override unsafe ControllerElementGlyphSelectorOptions options
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphSelectorOptionsSO.NativeMethodInfoPtr_get_options_Public_Virtual_get_ControllerElementGlyphSelectorOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num3);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69131, XrefRangeEnd = 69132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerElementGlyphSelectorOptionsSO()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSO>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptionsSO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ControllerElementGlyphSelectorOptions _options
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphSelectorOptionsSO.NativeFieldInfoPtr__options));
      return num == IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphSelectorOptionsSO.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
