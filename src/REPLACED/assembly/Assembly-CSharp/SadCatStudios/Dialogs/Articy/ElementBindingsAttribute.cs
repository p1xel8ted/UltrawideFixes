// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.ElementBindingsAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class ElementBindingsAttribute : Il2CppSystem.Attribute
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_SpecialBindingTypes;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_SpecialBindingType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SpecialBindingType_0;

  static ElementBindingsAttribute()
  {
    Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (ElementBindingsAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr);
    ElementBindingsAttribute.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr, nameof (Name));
    ElementBindingsAttribute.NativeFieldInfoPtr_SpecialBindingTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr, nameof (SpecialBindingTypes));
    ElementBindingsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_SpecialBindingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr, 100672880);
    ElementBindingsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SpecialBindingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr, 100672881);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104367, XrefRangeEnd = 104374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ElementBindingsAttribute(
    string name,
    [Optional] Il2CppStructArray<ElementBindingsAttribute.SpecialBindingType> specialBindingTypes)
  {
    if (specialBindingTypes == null)
      specialBindingTypes = new Il2CppStructArray<ElementBindingsAttribute.SpecialBindingType>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) specialBindingTypes);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ElementBindingsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStructArray_1_SpecialBindingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104374, XrefRangeEnd = 104381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ElementBindingsAttribute(
    [Optional] Il2CppStructArray<ElementBindingsAttribute.SpecialBindingType> specialBindingTypes)
  {
    if (specialBindingTypes == null)
      specialBindingTypes = new Il2CppStructArray<ElementBindingsAttribute.SpecialBindingType>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElementBindingsAttribute>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) specialBindingTypes)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ElementBindingsAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_SpecialBindingType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ElementBindingsAttribute(
    string name,
    params ElementBindingsAttribute.SpecialBindingType[] specialBindingTypes)
    : this(name, new Il2CppStructArray<ElementBindingsAttribute.SpecialBindingType>(specialBindingTypes))
  {
  }

  public ElementBindingsAttribute(
    params ElementBindingsAttribute.SpecialBindingType[] specialBindingTypes)
    : this(new Il2CppStructArray<ElementBindingsAttribute.SpecialBindingType>(specialBindingTypes))
  {
  }

  public ElementBindingsAttribute(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe string Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ElementBindingsAttribute.NativeFieldInfoPtr_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ElementBindingsAttribute.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe HashSet<ElementBindingsAttribute.SpecialBindingType> SpecialBindingTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ElementBindingsAttribute.NativeFieldInfoPtr_SpecialBindingTypes));
      return num == System.IntPtr.Zero ? (HashSet<ElementBindingsAttribute.SpecialBindingType>) null : Il2CppObjectPool.Get<HashSet<ElementBindingsAttribute.SpecialBindingType>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ElementBindingsAttribute.NativeFieldInfoPtr_SpecialBindingTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum SpecialBindingType
  {
    Actors,
  }
}
