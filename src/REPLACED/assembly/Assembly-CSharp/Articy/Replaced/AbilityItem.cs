// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.AbilityItem
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

public class AbilityItem(System.IntPtr pointer) : Entity(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Template_Public_get_AbilityItemTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_AbilityItemTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_Static_get_AbilityItemTemplateConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureAbility_Public_Virtual_Final_New_AbilityFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureItem_Public_Virtual_Final_New_ItemFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AbilityItem()
  {
    Il2CppClassPointerStore<AbilityItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (AbilityItem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr);
    AbilityItem.NativeFieldInfoPtr_mTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, nameof (mTemplate));
    AbilityItem.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, nameof (mConstraints));
    AbilityItem.NativeMethodInfoPtr_get_Template_Public_get_AbilityItemTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677924);
    AbilityItem.NativeMethodInfoPtr_set_Template_Public_set_Void_AbilityItemTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677925);
    AbilityItem.NativeMethodInfoPtr_get_Constraints_Public_Static_get_AbilityItemTemplateConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677926);
    AbilityItem.NativeMethodInfoPtr_GetFeatureAbility_Public_Virtual_Final_New_AbilityFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677927);
    AbilityItem.NativeMethodInfoPtr_GetFeatureItem_Public_Virtual_Final_New_ItemFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677928);
    AbilityItem.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677929);
    AbilityItem.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677930);
    AbilityItem.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677931);
    AbilityItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr, 100677932);
  }

  public unsafe AbilityItemTemplate Template
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 132567, RefRangeEnd = 132572, XrefRangeStart = 132566, XrefRangeEnd = 132567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityItem.NativeMethodInfoPtr_get_Template_Public_get_AbilityItemTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AbilityItemTemplate) null : Il2CppObjectPool.Get<AbilityItemTemplate>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132572, XrefRangeEnd = 132573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AbilityItem.NativeMethodInfoPtr_set_Template_Public_set_Void_AbilityItemTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe AbilityItemTemplateConstraint Constraints
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132573, XrefRangeEnd = 132577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityItem.NativeMethodInfoPtr_get_Constraints_Public_Static_get_AbilityItemTemplateConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AbilityItemTemplateConstraint) null : Il2CppObjectPool.Get<AbilityItemTemplateConstraint>(num3);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 132579, RefRangeEnd = 132586, XrefRangeStart = 132577, XrefRangeEnd = 132579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe AbilityFeature GetFeatureAbility()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityItem.NativeMethodInfoPtr_GetFeatureAbility_Public_Virtual_Final_New_AbilityFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AbilityFeature) null : Il2CppObjectPool.Get<AbilityFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132586, XrefRangeEnd = 132594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ItemFeature GetFeatureItem()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityItem.NativeMethodInfoPtr_GetFeatureItem_Public_Virtual_Final_New_ItemFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ItemFeature) null : Il2CppObjectPool.Get<ItemFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132594, XrefRangeEnd = 132604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityItem.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132604, XrefRangeEnd = 132610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityItem.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132610, XrefRangeEnd = 132616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityItem.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132616, XrefRangeEnd = 132623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AbilityItem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityItem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueAbilityItemTemplate mTemplate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityItem.NativeFieldInfoPtr_mTemplate));
      return num == System.IntPtr.Zero ? (ArticyValueAbilityItemTemplate) null : Il2CppObjectPool.Get<ArticyValueAbilityItemTemplate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityItem.NativeFieldInfoPtr_mTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe AbilityItemTemplateConstraint mConstraints
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(AbilityItem.NativeFieldInfoPtr_mConstraints, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (AbilityItemTemplateConstraint) null : Il2CppObjectPool.Get<AbilityItemTemplateConstraint>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AbilityItem.NativeFieldInfoPtr_mConstraints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
