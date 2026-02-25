// Decompiled with JetBrains decompiler
// Type: Articy.Unity.TextExtensionPropertyInfo
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public class TextExtensionPropertyInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ArticyObjectRef_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ArticyType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ArticyPropertyInfo_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyObjectRef_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArticyObjectRef_Public_set_Void_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyType_Public_get_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArticyType_Public_set_Void_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyPropertyInfo_Public_get_ArticyPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArticyPropertyInfo_Public_set_Void_ArticyPropertyInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyObject_ArticyType_ArticyPropertyInfo_0;

  static TextExtensionPropertyInfo()
  {
    Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (TextExtensionPropertyInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr);
    TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyObjectRef_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, "<ArticyObjectRef>k__BackingField");
    TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, "<ArticyType>k__BackingField");
    TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyPropertyInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, "<ArticyPropertyInfo>k__BackingField");
    TextExtensionPropertyInfo.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, "<Name>k__BackingField");
    TextExtensionPropertyInfo.NativeMethodInfoPtr_get_ArticyObjectRef_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663893);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_set_ArticyObjectRef_Public_set_Void_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663894);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_get_ArticyType_Public_get_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663895);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_set_ArticyType_Public_set_Void_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663896);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_get_ArticyPropertyInfo_Public_get_ArticyPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663897);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_set_ArticyPropertyInfo_Public_set_Void_ArticyPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663898);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663899);
    TextExtensionPropertyInfo.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663900);
    TextExtensionPropertyInfo.NativeMethodInfoPtr__ctor_Public_Void_ArticyObject_ArticyType_ArticyPropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr, 100663901);
  }

  public unsafe ArticyRef ArticyObjectRef
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_get_ArticyObjectRef_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_set_ArticyObjectRef_Public_set_Void_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyType ArticyType
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_get_ArticyType_Public_get_ArticyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_set_ArticyType_Public_set_Void_ArticyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyPropertyInfo ArticyPropertyInfo
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_get_ArticyPropertyInfo_Public_get_ArticyPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyPropertyInfo) null : Il2CppObjectPool.Get<ArticyPropertyInfo>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_set_ArticyPropertyInfo_Public_set_Void_ArticyPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Name
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991988, XrefRangeEnd = 991992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextExtensionPropertyInfo(
    ArticyObject aArticyObject,
    ArticyType aArticyType,
    ArticyPropertyInfo aArticyPropertyInfo)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextExtensionPropertyInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyPropertyInfo);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextExtensionPropertyInfo.NativeMethodInfoPtr__ctor_Public_Void_ArticyObject_ArticyType_ArticyPropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef _ArticyObjectRef_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyObjectRef_k__BackingField));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyObjectRef_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyType _ArticyType_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyType_k__BackingField));
      return num == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyPropertyInfo _ArticyPropertyInfo_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyPropertyInfo_k__BackingField));
      return num == System.IntPtr.Zero ? (ArticyPropertyInfo) null : Il2CppObjectPool.Get<ArticyPropertyInfo>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__ArticyPropertyInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _Name_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__Name_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextExtensionPropertyInfo.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
