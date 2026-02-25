// Decompiled with JetBrains decompiler
// Type: UnityEngine.CreateAssetMenuAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class CreateAssetMenuAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__menuName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__fileName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__order_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CreateAssetMenuAttribute()
  {
    Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CreateAssetMenuAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr);
    CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<menuName>k__BackingField");
    CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<fileName>k__BackingField");
    CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<order>k__BackingField");
    CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100667858);
    CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100667859);
    CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100667860);
    CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100667861);
  }

  public unsafe string menuName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._menuName_k__BackingField;
  }

  public unsafe string fileName
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._fileName_k__BackingField;
  }

  public unsafe int order
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._order_k__BackingField;
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CreateAssetMenuAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _menuName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _fileName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int _order_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField)) = value;
    }
  }
}
