// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.PDAMusicEntry
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

public class PDAMusicEntry(System.IntPtr pointer) : Entity(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTemplate;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraints;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Template_Public_get_PDAMusicEntryTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Template_Public_set_Void_PDAMusicEntryTemplate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Constraints_Public_Static_get_PDAMusicEntryTemplateConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFeaturePDAEntryMusic_Public_Virtual_Final_New_PDAEntryMusicFeature_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAMusicEntry()
  {
    Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (PDAMusicEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr);
    PDAMusicEntry.NativeFieldInfoPtr_mTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, nameof (mTemplate));
    PDAMusicEntry.NativeFieldInfoPtr_mConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, nameof (mConstraints));
    PDAMusicEntry.NativeMethodInfoPtr_get_Template_Public_get_PDAMusicEntryTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678467);
    PDAMusicEntry.NativeMethodInfoPtr_set_Template_Public_set_Void_PDAMusicEntryTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678468);
    PDAMusicEntry.NativeMethodInfoPtr_get_Constraints_Public_Static_get_PDAMusicEntryTemplateConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678469);
    PDAMusicEntry.NativeMethodInfoPtr_GetFeaturePDAEntryMusic_Public_Virtual_Final_New_PDAEntryMusicFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678470);
    PDAMusicEntry.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678471);
    PDAMusicEntry.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678472);
    PDAMusicEntry.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678473);
    PDAMusicEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr, 100678474);
  }

  public unsafe PDAMusicEntryTemplate Template
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 132567, RefRangeEnd = 132572, XrefRangeStart = 132567, XrefRangeEnd = 132572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAMusicEntry.NativeMethodInfoPtr_get_Template_Public_get_PDAMusicEntryTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (PDAMusicEntryTemplate) null : Il2CppObjectPool.Get<PDAMusicEntryTemplate>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PDAMusicEntry.NativeMethodInfoPtr_set_Template_Public_set_Void_PDAMusicEntryTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe PDAMusicEntryTemplateConstraint Constraints
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137223, XrefRangeEnd = 137227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAMusicEntry.NativeMethodInfoPtr_get_Constraints_Public_Static_get_PDAMusicEntryTemplateConstraint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (PDAMusicEntryTemplateConstraint) null : Il2CppObjectPool.Get<PDAMusicEntryTemplateConstraint>(num3);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 132579, RefRangeEnd = 132586, XrefRangeStart = 132579, XrefRangeEnd = 132586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PDAEntryMusicFeature GetFeaturePDAEntryMusic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAMusicEntry.NativeMethodInfoPtr_GetFeaturePDAEntryMusic_Public_Virtual_Final_New_PDAEntryMusicFeature_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (PDAEntryMusicFeature) null : Il2CppObjectPool.Get<PDAEntryMusicFeature>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137227, XrefRangeEnd = 137243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMusicEntry.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137243, XrefRangeEnd = 137249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMusicEntry.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137249, XrefRangeEnd = 137255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMusicEntry.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137255, XrefRangeEnd = 137262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAMusicEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAMusicEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMusicEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValuePDAMusicEntryTemplate mTemplate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMusicEntry.NativeFieldInfoPtr_mTemplate));
      return num == System.IntPtr.Zero ? (ArticyValuePDAMusicEntryTemplate) null : Il2CppObjectPool.Get<ArticyValuePDAMusicEntryTemplate>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMusicEntry.NativeFieldInfoPtr_mTemplate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe PDAMusicEntryTemplateConstraint mConstraints
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PDAMusicEntry.NativeFieldInfoPtr_mConstraints, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (PDAMusicEntryTemplateConstraint) null : Il2CppObjectPool.Get<PDAMusicEntryTemplateConstraint>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PDAMusicEntry.NativeFieldInfoPtr_mConstraints, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
