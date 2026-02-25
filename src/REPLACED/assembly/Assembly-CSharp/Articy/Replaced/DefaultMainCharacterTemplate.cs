// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.DefaultMainCharacterTemplate
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

public class DefaultMainCharacterTemplate(System.IntPtr pointer) : Entity(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Template_Public_get_DefaultMainCharacterTemplateTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_DefaultMainCharacterTemplateTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_Static_get_DefaultMainCharacterTemplateTemplateConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDefaultExtendedCharacterFeature_Public_Virtual_Final_New_DefaultExtendedCharacterFeatureFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureDefaultBasicCharacterFeature_Public_Virtual_Final_New_DefaultBasicCharacterFeatureFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultMainCharacterTemplate()
  {
    Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (DefaultMainCharacterTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr);
    DefaultMainCharacterTemplate.NativeFieldInfoPtr_mTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, nameof (mTemplate));
    DefaultMainCharacterTemplate.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, nameof (mConstraints));
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_get_Template_Public_get_DefaultMainCharacterTemplateTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678112);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_set_Template_Public_set_Void_DefaultMainCharacterTemplateTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678113);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_get_Constraints_Public_Static_get_DefaultMainCharacterTemplateTemplateConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678114);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_GetFeatureDefaultExtendedCharacterFeature_Public_Virtual_Final_New_DefaultExtendedCharacterFeatureFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678115);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_GetFeatureDefaultBasicCharacterFeature_Public_Virtual_Final_New_DefaultBasicCharacterFeatureFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678116);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678117);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678118);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678119);
    DefaultMainCharacterTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr, 100678120);
  }

  public unsafe DefaultMainCharacterTemplateTemplate Template
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 132567, RefRangeEnd = 132572, XrefRangeStart = 132567, XrefRangeEnd = 132572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplate.NativeMethodInfoPtr_get_Template_Public_get_DefaultMainCharacterTemplateTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultMainCharacterTemplateTemplate) null : Il2CppObjectPool.Get<DefaultMainCharacterTemplateTemplate>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplate.NativeMethodInfoPtr_set_Template_Public_set_Void_DefaultMainCharacterTemplateTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe DefaultMainCharacterTemplateTemplateConstraint Constraints
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133964, XrefRangeEnd = 133968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplate.NativeMethodInfoPtr_get_Constraints_Public_Static_get_DefaultMainCharacterTemplateTemplateConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (DefaultMainCharacterTemplateTemplateConstraint) null : Il2CppObjectPool.Get<DefaultMainCharacterTemplateTemplateConstraint>(num3);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 133330, RefRangeEnd = 133334, XrefRangeStart = 133330, XrefRangeEnd = 133334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe DefaultExtendedCharacterFeatureFeature GetFeatureDefaultExtendedCharacterFeature()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplate.NativeMethodInfoPtr_GetFeatureDefaultExtendedCharacterFeature_Public_Virtual_Final_New_DefaultExtendedCharacterFeatureFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (DefaultExtendedCharacterFeatureFeature) null : Il2CppObjectPool.Get<DefaultExtendedCharacterFeatureFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133968, XrefRangeEnd = 133983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe DefaultBasicCharacterFeatureFeature GetFeatureDefaultBasicCharacterFeature()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplate.NativeMethodInfoPtr_GetFeatureDefaultBasicCharacterFeature_Public_Virtual_Final_New_DefaultBasicCharacterFeatureFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (DefaultBasicCharacterFeatureFeature) null : Il2CppObjectPool.Get<DefaultBasicCharacterFeatureFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133983, XrefRangeEnd = 134007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultMainCharacterTemplate.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134007, XrefRangeEnd = 134011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultMainCharacterTemplate.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134011, XrefRangeEnd = 134015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultMainCharacterTemplate.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134015, XrefRangeEnd = 134022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultMainCharacterTemplate()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultMainCharacterTemplate>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultMainCharacterTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueDefaultMainCharacterTemplateTemplate mTemplate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultMainCharacterTemplate.NativeFieldInfoPtr_mTemplate));
      return num == System.IntPtr.Zero ? (ArticyValueDefaultMainCharacterTemplateTemplate) null : Il2CppObjectPool.Get<ArticyValueDefaultMainCharacterTemplateTemplate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultMainCharacterTemplate.NativeFieldInfoPtr_mTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe DefaultMainCharacterTemplateTemplateConstraint mConstraints
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(DefaultMainCharacterTemplate.NativeFieldInfoPtr_mConstraints, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (DefaultMainCharacterTemplateTemplateConstraint) null : Il2CppObjectPool.Get<DefaultMainCharacterTemplateTemplateConstraint>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DefaultMainCharacterTemplate.NativeFieldInfoPtr_mConstraints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
