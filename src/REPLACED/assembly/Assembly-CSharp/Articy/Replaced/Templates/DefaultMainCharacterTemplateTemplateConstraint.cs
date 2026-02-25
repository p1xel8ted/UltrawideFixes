// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Templates.DefaultMainCharacterTemplateTemplateConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Features;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Templates;

public class DefaultMainCharacterTemplateTemplateConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultExtendedCharacterFeature;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultBasicCharacterFeature;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultExtendedCharacterFeature_Public_get_DefaultExtendedCharacterFeatureFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultBasicCharacterFeature_Public_get_DefaultBasicCharacterFeatureFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultMainCharacterTemplateTemplateConstraint()
  {
    Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Templates", nameof (DefaultMainCharacterTemplateTemplateConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr);
    DefaultMainCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultExtendedCharacterFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr, nameof (mDefaultExtendedCharacterFeature));
    DefaultMainCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultBasicCharacterFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr, nameof (mDefaultBasicCharacterFeature));
    DefaultMainCharacterTemplateTemplateConstraint.NativeMethodInfoPtr_get_DefaultExtendedCharacterFeature_Public_get_DefaultExtendedCharacterFeatureFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr, 100678592);
    DefaultMainCharacterTemplateTemplateConstraint.NativeMethodInfoPtr_get_DefaultBasicCharacterFeature_Public_get_DefaultBasicCharacterFeatureFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr, 100678593);
    DefaultMainCharacterTemplateTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr, 100678594);
  }

  public unsafe DefaultExtendedCharacterFeatureFeatureConstraint DefaultExtendedCharacterFeature
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplateTemplateConstraint.NativeMethodInfoPtr_get_DefaultExtendedCharacterFeature_Public_get_DefaultExtendedCharacterFeatureFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultExtendedCharacterFeatureFeatureConstraint) null : Il2CppObjectPool.Get<DefaultExtendedCharacterFeatureFeatureConstraint>(num3);
    }
  }

  public unsafe DefaultBasicCharacterFeatureFeatureConstraint DefaultBasicCharacterFeature
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplateTemplateConstraint.NativeMethodInfoPtr_get_DefaultBasicCharacterFeature_Public_get_DefaultBasicCharacterFeatureFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultBasicCharacterFeatureFeatureConstraint) null : Il2CppObjectPool.Get<DefaultBasicCharacterFeatureFeatureConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137904, XrefRangeEnd = 137913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultMainCharacterTemplateTemplateConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMainCharacterTemplateTemplateConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplateTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DefaultExtendedCharacterFeatureFeatureConstraint mDefaultExtendedCharacterFeature
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultMainCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultExtendedCharacterFeature));
      return num == System.IntPtr.Zero ? (DefaultExtendedCharacterFeatureFeatureConstraint) null : Il2CppObjectPool.Get<DefaultExtendedCharacterFeatureFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultMainCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultExtendedCharacterFeature), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DefaultBasicCharacterFeatureFeatureConstraint mDefaultBasicCharacterFeature
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultMainCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultBasicCharacterFeature));
      return num == System.IntPtr.Zero ? (DefaultBasicCharacterFeatureFeatureConstraint) null : Il2CppObjectPool.Get<DefaultBasicCharacterFeatureFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultMainCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultBasicCharacterFeature), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
