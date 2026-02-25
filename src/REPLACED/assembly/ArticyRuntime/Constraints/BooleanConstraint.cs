// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.BooleanConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Constraints;

public sealed class BooleanConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__DisplayAsCombobox_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayAsCombobox_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayAsCombobox_Private_set_Void_Boolean_0;

  static BooleanConstraint()
  {
    Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (BooleanConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr);
    BooleanConstraint.NativeFieldInfoPtr__DisplayAsCombobox_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr, "<DisplayAsCombobox>k__BackingField");
    BooleanConstraint.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr, 100664599);
    BooleanConstraint.NativeMethodInfoPtr_get_DisplayAsCombobox_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr, 100664600);
    BooleanConstraint.NativeMethodInfoPtr_set_DisplayAsCombobox_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr, 100664601);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 664381, RefRangeEnd = 664386, XrefRangeStart = 664381, XrefRangeEnd = 664386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BooleanConstraint(bool aDisplayAsCombobox)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aDisplayAsCombobox
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BooleanConstraint.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool DisplayAsCombobox
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BooleanConstraint.NativeMethodInfoPtr_get_DisplayAsCombobox_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BooleanConstraint.NativeMethodInfoPtr_set_DisplayAsCombobox_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool _DisplayAsCombobox_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BooleanConstraint.NativeFieldInfoPtr__DisplayAsCombobox_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BooleanConstraint.NativeFieldInfoPtr__DisplayAsCombobox_k__BackingField)) = value;
    }
  }
}
