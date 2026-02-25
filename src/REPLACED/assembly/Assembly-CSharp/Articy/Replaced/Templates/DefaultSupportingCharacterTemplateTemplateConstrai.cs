// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Templates.DefaultSupportingCharacterTemplateTemplateConstraint
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

public class DefaultSupportingCharacterTemplateTemplateConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultBasicCharacterFeature;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultBasicCharacterFeature_Public_get_DefaultBasicCharacterFeatureFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultSupportingCharacterTemplateTemplateConstraint()
  {
    Il2CppClassPointerStore<DefaultSupportingCharacterTemplateTemplateConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Templates", nameof (DefaultSupportingCharacterTemplateTemplateConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultSupportingCharacterTemplateTemplateConstraint>.NativeClassPtr);
    DefaultSupportingCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultBasicCharacterFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultSupportingCharacterTemplateTemplateConstraint>.NativeClassPtr, nameof (mDefaultBasicCharacterFeature));
    DefaultSupportingCharacterTemplateTemplateConstraint.NativeMethodInfoPtr_get_DefaultBasicCharacterFeature_Public_get_DefaultBasicCharacterFeatureFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplateTemplateConstraint>.NativeClassPtr, 100678606);
    DefaultSupportingCharacterTemplateTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplateTemplateConstraint>.NativeClassPtr, 100678607);
  }

  public unsafe DefaultBasicCharacterFeatureFeatureConstraint DefaultBasicCharacterFeature
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplateTemplateConstraint.NativeMethodInfoPtr_get_DefaultBasicCharacterFeature_Public_get_DefaultBasicCharacterFeatureFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultBasicCharacterFeatureFeatureConstraint) null : Il2CppObjectPool.Get<DefaultBasicCharacterFeatureFeatureConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137950, XrefRangeEnd = 137955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultSupportingCharacterTemplateTemplateConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultSupportingCharacterTemplateTemplateConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplateTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DefaultBasicCharacterFeatureFeatureConstraint mDefaultBasicCharacterFeature
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultSupportingCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultBasicCharacterFeature));
      return num == System.IntPtr.Zero ? (DefaultBasicCharacterFeatureFeatureConstraint) null : Il2CppObjectPool.Get<DefaultBasicCharacterFeatureFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultSupportingCharacterTemplateTemplateConstraint.NativeFieldInfoPtr_mDefaultBasicCharacterFeature), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
