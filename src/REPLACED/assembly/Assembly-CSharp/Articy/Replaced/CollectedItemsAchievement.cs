// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.CollectedItemsAchievement
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

public class CollectedItemsAchievement(System.IntPtr pointer) : Entity(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Template_Public_get_CollectedItemsAchievementTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_CollectedItemsAchievementTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_Static_get_CollectedItemsAchievementTemplateConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeatureCollectedItemsAchievement_Public_Virtual_Final_New_CollectedItemsAchievementFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CollectedItemsAchievement()
  {
    Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (CollectedItemsAchievement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr);
    CollectedItemsAchievement.NativeFieldInfoPtr_mTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, nameof (mTemplate));
    CollectedItemsAchievement.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, nameof (mConstraints));
    CollectedItemsAchievement.NativeMethodInfoPtr_get_Template_Public_get_CollectedItemsAchievementTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678043);
    CollectedItemsAchievement.NativeMethodInfoPtr_set_Template_Public_set_Void_CollectedItemsAchievementTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678044);
    CollectedItemsAchievement.NativeMethodInfoPtr_get_Constraints_Public_Static_get_CollectedItemsAchievementTemplateConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678045);
    CollectedItemsAchievement.NativeMethodInfoPtr_GetFeatureCollectedItemsAchievement_Public_Virtual_Final_New_CollectedItemsAchievementFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678046);
    CollectedItemsAchievement.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678047);
    CollectedItemsAchievement.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678048);
    CollectedItemsAchievement.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678049);
    CollectedItemsAchievement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr, 100678050);
  }

  public unsafe CollectedItemsAchievementTemplate Template
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 132567, RefRangeEnd = 132572, XrefRangeStart = 132567, XrefRangeEnd = 132572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievement.NativeMethodInfoPtr_get_Template_Public_get_CollectedItemsAchievementTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CollectedItemsAchievementTemplate) null : Il2CppObjectPool.Get<CollectedItemsAchievementTemplate>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievement.NativeMethodInfoPtr_set_Template_Public_set_Void_CollectedItemsAchievementTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe CollectedItemsAchievementTemplateConstraint Constraints
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133315, XrefRangeEnd = 133319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievement.NativeMethodInfoPtr_get_Constraints_Public_Static_get_CollectedItemsAchievementTemplateConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CollectedItemsAchievementTemplateConstraint) null : Il2CppObjectPool.Get<CollectedItemsAchievementTemplateConstraint>(num3);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 133330, RefRangeEnd = 133334, XrefRangeStart = 133319, XrefRangeEnd = 133330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CollectedItemsAchievementFeature GetFeatureCollectedItemsAchievement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievement.NativeMethodInfoPtr_GetFeatureCollectedItemsAchievement_Public_Virtual_Final_New_CollectedItemsAchievementFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CollectedItemsAchievementFeature) null : Il2CppObjectPool.Get<CollectedItemsAchievementFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133334, XrefRangeEnd = 133352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollectedItemsAchievement.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133352, XrefRangeEnd = 133356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollectedItemsAchievement.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133356, XrefRangeEnd = 133360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollectedItemsAchievement.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133360, XrefRangeEnd = 133365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CollectedItemsAchievement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectedItemsAchievement>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueCollectedItemsAchievementTemplate mTemplate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievement.NativeFieldInfoPtr_mTemplate));
      return num == System.IntPtr.Zero ? (ArticyValueCollectedItemsAchievementTemplate) null : Il2CppObjectPool.Get<ArticyValueCollectedItemsAchievementTemplate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievement.NativeFieldInfoPtr_mTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CollectedItemsAchievementTemplateConstraint mConstraints
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CollectedItemsAchievement.NativeFieldInfoPtr_mConstraints, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CollectedItemsAchievementTemplateConstraint) null : Il2CppObjectPool.Get<CollectedItemsAchievementTemplateConstraint>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CollectedItemsAchievement.NativeFieldInfoPtr_mConstraints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
