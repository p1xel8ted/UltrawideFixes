// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.EnumConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Constraints;

public sealed class EnumConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__IsLocalized_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SortMode_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalized_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLocalized_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SortMode_Public_get_EnumSortMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SortMode_Private_set_Void_EnumSortMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

  static EnumConstraint()
  {
    Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (EnumConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr);
    EnumConstraint.NativeFieldInfoPtr__IsLocalized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, "<IsLocalized>k__BackingField");
    EnumConstraint.NativeFieldInfoPtr__SortMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, "<SortMode>k__BackingField");
    EnumConstraint.NativeMethodInfoPtr_get_IsLocalized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, 100664602);
    EnumConstraint.NativeMethodInfoPtr_set_IsLocalized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, 100664603);
    EnumConstraint.NativeMethodInfoPtr_get_SortMode_Public_get_EnumSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, 100664604);
    EnumConstraint.NativeMethodInfoPtr_set_SortMode_Private_set_Void_EnumSortMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, 100664605);
    EnumConstraint.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr, 100664606);
  }

  public unsafe bool IsLocalized
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumConstraint.NativeMethodInfoPtr_get_IsLocalized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(EnumConstraint.NativeMethodInfoPtr_set_IsLocalized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EnumSortMode SortMode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumConstraint.NativeMethodInfoPtr_get_SortMode_Public_get_EnumSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EnumSortMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EnumConstraint.NativeMethodInfoPtr_set_SortMode_Private_set_Void_EnumSortMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 1000108, RefRangeEnd = 1000112, XrefRangeStart = 1000096, XrefRangeEnd = 1000108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnumConstraint(bool aIsLocalized, string aSortMode)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aIsLocalized;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aSortMode);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnumConstraint.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _IsLocalized_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumConstraint.NativeFieldInfoPtr__IsLocalized_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumConstraint.NativeFieldInfoPtr__IsLocalized_k__BackingField)) = value;
    }
  }

  public unsafe EnumSortMode _SortMode_k__BackingField
  {
    get
    {
      return *(EnumSortMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumConstraint.NativeFieldInfoPtr__SortMode_k__BackingField));
    }
    [param: In] set
    {
      *(EnumSortMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumConstraint.NativeFieldInfoPtr__SortMode_k__BackingField)) = value;
    }
  }
}
