// Decompiled with JetBrains decompiler
// Type: UnityEngine.PropertyAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class PropertyAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__applyToCollection_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

  static PropertyAttribute()
  {
    Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PropertyAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr);
    PropertyAttribute.NativeFieldInfoPtr__applyToCollection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, "<applyToCollection>k__BackingField");
    PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, 100667734);
    PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, 100667735);
  }

  [CallerCount(68)]
  [CachedScanResults(RefRangeStart = 441800, RefRangeEnd = 441868, XrefRangeStart = 441799, XrefRangeEnd = 441800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PropertyAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441868, XrefRangeEnd = 441869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PropertyAttribute(bool applyToCollection)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &applyToCollection
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _applyToCollection_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PropertyAttribute.NativeFieldInfoPtr__applyToCollection_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PropertyAttribute.NativeFieldInfoPtr__applyToCollection_k__BackingField)) = value;
    }
  }

  public int order
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public bool applyToCollection => this._applyToCollection_k__BackingField;
}
