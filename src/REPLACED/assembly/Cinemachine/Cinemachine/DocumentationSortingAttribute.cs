// Decompiled with JetBrains decompiler
// Type: Cinemachine.DocumentationSortingAttribute
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Cinemachine;

public sealed class DocumentationSortingAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Category_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Category_Private_set_Void_Level_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Level_0;

  static DocumentationSortingAttribute()
  {
    Il2CppClassPointerStore<DocumentationSortingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (DocumentationSortingAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentationSortingAttribute>.NativeClassPtr);
    DocumentationSortingAttribute.NativeFieldInfoPtr__Category_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentationSortingAttribute>.NativeClassPtr, "<Category>k__BackingField");
    DocumentationSortingAttribute.NativeMethodInfoPtr_set_Category_Private_set_Void_Level_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationSortingAttribute>.NativeClassPtr, 100664048 /*0x060002F0*/);
    DocumentationSortingAttribute.NativeMethodInfoPtr__ctor_Public_Void_Level_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentationSortingAttribute>.NativeClassPtr, 100664049);
  }

  public unsafe DocumentationSortingAttribute.Level Category
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DocumentationSortingAttribute.NativeMethodInfoPtr_set_Category_Private_set_Void_Level_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 255094, RefRangeEnd = 255121, XrefRangeStart = 255094, XrefRangeEnd = 255121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DocumentationSortingAttribute(DocumentationSortingAttribute.Level category)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentationSortingAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &category
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DocumentationSortingAttribute.NativeMethodInfoPtr__ctor_Public_Void_Level_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DocumentationSortingAttribute.Level _Category_k__BackingField
  {
    get
    {
      return *(DocumentationSortingAttribute.Level*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DocumentationSortingAttribute.NativeFieldInfoPtr__Category_k__BackingField));
    }
    [param: In] set
    {
      *(DocumentationSortingAttribute.Level*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DocumentationSortingAttribute.NativeFieldInfoPtr__Category_k__BackingField)) = value;
    }
  }

  public enum Level
  {
    Undoc,
    API,
    UserRef,
  }
}
