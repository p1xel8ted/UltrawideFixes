// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.DefaultSupportingCharacterTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Features;
using Articy.Replaced.Templates;
using Articy.Unity;
using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced;

public class DefaultSupportingCharacterTemplate(System.IntPtr pointer) : Entity(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Template_Public_get_DefaultSupportingCharacterTemplateTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_DefaultSupportingCharacterTemplateTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_Static_get_DefaultSupportingCharacterTemplateTemplateConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDefaultBasicCharacterFeature_Public_Virtual_Final_New_DefaultBasicCharacterFeatureFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultSupportingCharacterTemplate()
  {
    Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (DefaultSupportingCharacterTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr);
    DefaultSupportingCharacterTemplate.NativeFieldInfoPtr_mTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, nameof (mTemplate));
    DefaultSupportingCharacterTemplate.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, nameof (mConstraints));
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_get_Template_Public_get_DefaultSupportingCharacterTemplateTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678122);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_set_Template_Public_set_Void_DefaultSupportingCharacterTemplateTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678123);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_get_Constraints_Public_Static_get_DefaultSupportingCharacterTemplateTemplateConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678124);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_GetFeatureDefaultBasicCharacterFeature_Public_Virtual_Final_New_DefaultBasicCharacterFeatureFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678125);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678126);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678127);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678128);
    DefaultSupportingCharacterTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr, 100678129);
  }

  public unsafe DefaultSupportingCharacterTemplateTemplate Template
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 132567, RefRangeEnd = 132572, XrefRangeStart = 132567, XrefRangeEnd = 132572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_get_Template_Public_get_DefaultSupportingCharacterTemplateTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultSupportingCharacterTemplateTemplate) null : Il2CppObjectPool.Get<DefaultSupportingCharacterTemplateTemplate>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_set_Template_Public_set_Void_DefaultSupportingCharacterTemplateTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe DefaultSupportingCharacterTemplateTemplateConstraint Constraints
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134022, XrefRangeEnd = 134026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_get_Constraints_Public_Static_get_DefaultSupportingCharacterTemplateTemplateConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultSupportingCharacterTemplateTemplateConstraint) null : Il2CppObjectPool.Get<DefaultSupportingCharacterTemplateTemplateConstraint>(num3);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 133330, RefRangeEnd = 133334, XrefRangeStart = 133330, XrefRangeEnd = 133334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe DefaultBasicCharacterFeatureFeature GetFeatureDefaultBasicCharacterFeature()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_GetFeatureDefaultBasicCharacterFeature_Public_Virtual_Final_New_DefaultBasicCharacterFeatureFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (DefaultBasicCharacterFeatureFeature) null : Il2CppObjectPool.Get<DefaultBasicCharacterFeatureFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134026, XrefRangeEnd = 134054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134054, XrefRangeEnd = 134058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134058, XrefRangeEnd = 134062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultSupportingCharacterTemplate.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134062, XrefRangeEnd = 134067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultSupportingCharacterTemplate()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultSupportingCharacterTemplate>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultSupportingCharacterTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueDefaultSupportingCharacterTemplateTemplate mTemplate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultSupportingCharacterTemplate.NativeFieldInfoPtr_mTemplate));
      return num == System.IntPtr.Zero ? (ArticyValueDefaultSupportingCharacterTemplateTemplate) null : Il2CppObjectPool.Get<ArticyValueDefaultSupportingCharacterTemplateTemplate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultSupportingCharacterTemplate.NativeFieldInfoPtr_mTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe DefaultSupportingCharacterTemplateTemplateConstraint mConstraints
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(DefaultSupportingCharacterTemplate.NativeFieldInfoPtr_mConstraints, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (DefaultSupportingCharacterTemplateTemplateConstraint) null : Il2CppObjectPool.Get<DefaultSupportingCharacterTemplateTemplateConstraint>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DefaultSupportingCharacterTemplate.NativeFieldInfoPtr_mConstraints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
