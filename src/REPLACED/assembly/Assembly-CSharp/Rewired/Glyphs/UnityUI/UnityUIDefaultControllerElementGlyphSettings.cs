// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIDefaultControllerElementGlyphSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUIDefaultControllerElementGlyphSettings(IntPtr pointer) : 
  DefaultControllerElementGlyphSettingsBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SetDefaultGlyphOrTextPrefab_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnityUIDefaultControllerElementGlyphSettings()
  {
    Il2CppClassPointerStore<UnityUIDefaultControllerElementGlyphSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUIDefaultControllerElementGlyphSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUIDefaultControllerElementGlyphSettings>.NativeClassPtr);
    UnityUIDefaultControllerElementGlyphSettings.NativeMethodInfoPtr_SetDefaultGlyphOrTextPrefab_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIDefaultControllerElementGlyphSettings>.NativeClassPtr, 100668642);
    UnityUIDefaultControllerElementGlyphSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIDefaultControllerElementGlyphSettings>.NativeClassPtr, 100668643);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69806, XrefRangeEnd = 69808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void SetDefaultGlyphOrTextPrefab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIDefaultControllerElementGlyphSettings.NativeMethodInfoPtr_SetDefaultGlyphOrTextPrefab_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUIDefaultControllerElementGlyphSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUIDefaultControllerElementGlyphSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIDefaultControllerElementGlyphSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
