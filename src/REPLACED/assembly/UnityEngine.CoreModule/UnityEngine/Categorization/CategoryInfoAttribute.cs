// Decompiled with JetBrains decompiler
// Type: UnityEngine.Categorization.CategoryInfoAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Categorization;

public sealed class CategoryInfoAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Order_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Order_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CategoryInfoAttribute()
  {
    Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Categorization", nameof (CategoryInfoAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr);
    CategoryInfoAttribute.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr, "<Order>k__BackingField");
    CategoryInfoAttribute.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr, "<Name>k__BackingField");
    CategoryInfoAttribute.NativeMethodInfoPtr_set_Order_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr, 100669182);
    CategoryInfoAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr, 100669183);
    CategoryInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr, 100669184 /*0x06001700*/);
  }

  public unsafe int Order
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CategoryInfoAttribute.NativeMethodInfoPtr_set_Order_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._Order_k__BackingField;
  }

  public unsafe string Name
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CategoryInfoAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._Name_k__BackingField;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CategoryInfoAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryInfoAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CategoryInfoAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _Order_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CategoryInfoAttribute.NativeFieldInfoPtr__Order_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CategoryInfoAttribute.NativeFieldInfoPtr__Order_k__BackingField)) = value;
    }
  }

  public unsafe string _Name_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CategoryInfoAttribute.NativeFieldInfoPtr__Name_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CategoryInfoAttribute.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
