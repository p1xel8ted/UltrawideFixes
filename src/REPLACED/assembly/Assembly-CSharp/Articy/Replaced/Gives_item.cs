// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Gives_item
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

public class Gives_item(System.IntPtr pointer) : DialogueFragment(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Template_Public_get_Gives_itemTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_Gives_itemTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_Static_get_Gives_itemTemplateConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureGiveItem_Public_Virtual_Final_New_GiveItemFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Gives_item()
  {
    Il2CppClassPointerStore<Gives_item>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (Gives_item));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gives_item>.NativeClassPtr);
    Gives_item.NativeFieldInfoPtr_mTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, nameof (mTemplate));
    Gives_item.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, nameof (mConstraints));
    Gives_item.NativeMethodInfoPtr_get_Template_Public_get_Gives_itemTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678291);
    Gives_item.NativeMethodInfoPtr_set_Template_Public_set_Void_Gives_itemTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678292);
    Gives_item.NativeMethodInfoPtr_get_Constraints_Public_Static_get_Gives_itemTemplateConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678293);
    Gives_item.NativeMethodInfoPtr_GetFeatureGiveItem_Public_Virtual_Final_New_GiveItemFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678294);
    Gives_item.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678295);
    Gives_item.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678296);
    Gives_item.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678297);
    Gives_item.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gives_item>.NativeClassPtr, 100678298);
  }

  public unsafe Gives_itemTemplate Template
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 135831, RefRangeEnd = 135835, XrefRangeStart = 135830, XrefRangeEnd = 135831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gives_item.NativeMethodInfoPtr_get_Template_Public_get_Gives_itemTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Gives_itemTemplate) null : Il2CppObjectPool.Get<Gives_itemTemplate>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135835, XrefRangeEnd = 135836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Gives_item.NativeMethodInfoPtr_set_Template_Public_set_Void_Gives_itemTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Gives_itemTemplateConstraint Constraints
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135836, XrefRangeEnd = 135840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gives_item.NativeMethodInfoPtr_get_Constraints_Public_Static_get_Gives_itemTemplateConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Gives_itemTemplateConstraint) null : Il2CppObjectPool.Get<Gives_itemTemplateConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135840, XrefRangeEnd = 135851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GiveItemFeature GetFeatureGiveItem()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Gives_item.NativeMethodInfoPtr_GetFeatureGiveItem_Public_Virtual_Final_New_GiveItemFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GiveItemFeature) null : Il2CppObjectPool.Get<GiveItemFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135851, XrefRangeEnd = 135869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Gives_item.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135869, XrefRangeEnd = 135873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Gives_item.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135873, XrefRangeEnd = 135877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Gives_item.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135877, XrefRangeEnd = 135882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Gives_item()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gives_item>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Gives_item.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueGives_itemTemplate mTemplate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Gives_item.NativeFieldInfoPtr_mTemplate));
      return num == System.IntPtr.Zero ? (ArticyValueGives_itemTemplate) null : Il2CppObjectPool.Get<ArticyValueGives_itemTemplate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Gives_item.NativeFieldInfoPtr_mTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Gives_itemTemplateConstraint mConstraints
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Gives_item.NativeFieldInfoPtr_mConstraints, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Gives_itemTemplateConstraint) null : Il2CppObjectPool.Get<Gives_itemTemplateConstraint>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Gives_item.NativeFieldInfoPtr_mConstraints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
