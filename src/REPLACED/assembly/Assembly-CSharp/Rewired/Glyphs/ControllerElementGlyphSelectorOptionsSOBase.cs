// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphSelectorOptionsSOBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

[Serializable]
public class ControllerElementGlyphSelectorOptionsSOBase(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_Abstract_Virtual_New_get_ControllerElementGlyphSelectorOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static ControllerElementGlyphSelectorOptionsSOBase()
  {
    Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSOBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (ControllerElementGlyphSelectorOptionsSOBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSOBase>.NativeClassPtr);
    ControllerElementGlyphSelectorOptionsSOBase.NativeMethodInfoPtr_get_options_Public_Abstract_Virtual_New_get_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSOBase>.NativeClassPtr, 100668548);
    ControllerElementGlyphSelectorOptionsSOBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSOBase>.NativeClassPtr, 100668549);
  }

  public virtual unsafe ControllerElementGlyphSelectorOptions options
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphSelectorOptionsSOBase.NativeMethodInfoPtr_get_options_Public_Abstract_Virtual_New_get_ControllerElementGlyphSelectorOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num3);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerElementGlyphSelectorOptionsSOBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptionsSOBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptionsSOBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
