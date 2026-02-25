// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.DefaultControllerElementGlyphSettingsBase
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
namespace Rewired.Glyphs;

public class DefaultControllerElementGlyphSettingsBase(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__options;
  private static readonly IntPtr NativeFieldInfoPtr__glyphOrTextPrefab;
  private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_get_ControllerElementGlyphSelectorOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_set_Void_ControllerElementGlyphSelectorOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_glyphOrTextPrefab_Public_get_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_glyphOrTextPrefab_Public_set_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDefaults_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDefaultOptions_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetDefaultGlyphOrTextPrefab_Protected_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static DefaultControllerElementGlyphSettingsBase()
  {
    Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (DefaultControllerElementGlyphSettingsBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr);
    DefaultControllerElementGlyphSettingsBase.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, nameof (_options));
    DefaultControllerElementGlyphSettingsBase.NativeFieldInfoPtr__glyphOrTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, nameof (_glyphOrTextPrefab));
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_get_options_Public_get_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668550);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_set_options_Public_set_Void_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668551);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_get_glyphOrTextPrefab_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668552);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_set_glyphOrTextPrefab_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668553);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668554);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668555);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_SetDefaults_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668556);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_SetDefaultOptions_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668557);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_SetDefaultGlyphOrTextPrefab_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668558);
    DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr, 100668559);
  }

  public unsafe ControllerElementGlyphSelectorOptions options
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_get_options_Public_get_ControllerElementGlyphSelectorOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_set_options_Public_set_Void_ControllerElementGlyphSelectorOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe GameObject glyphOrTextPrefab
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_get_glyphOrTextPrefab_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_set_glyphOrTextPrefab_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69177, RefRangeEnd = 69179, XrefRangeStart = 69177, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void SetDefaults()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_SetDefaults_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69179, XrefRangeEnd = 69181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetDefaultOptions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_SetDefaultOptions_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void SetDefaultGlyphOrTextPrefab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr_SetDefaultGlyphOrTextPrefab_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultControllerElementGlyphSettingsBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultControllerElementGlyphSettingsBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultControllerElementGlyphSettingsBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ControllerElementGlyphSelectorOptions _options
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultControllerElementGlyphSettingsBase.NativeFieldInfoPtr__options));
      return num == IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultControllerElementGlyphSettingsBase.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject _glyphOrTextPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultControllerElementGlyphSettingsBase.NativeFieldInfoPtr__glyphOrTextPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultControllerElementGlyphSettingsBase.NativeFieldInfoPtr__glyphOrTextPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
