// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.QueryReferenceStripConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Constraints;

public sealed class QueryReferenceStripConstraint(IntPtr pointer) : BaseReferenceConstraint(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__MaxReferenceCount_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxReferenceCount_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_MaxReferenceCount_Private_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_String_String_0;

  static QueryReferenceStripConstraint()
  {
    Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (QueryReferenceStripConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr);
    QueryReferenceStripConstraint.NativeFieldInfoPtr__MaxReferenceCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr, "<MaxReferenceCount>k__BackingField");
    QueryReferenceStripConstraint.NativeMethodInfoPtr_get_MaxReferenceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr, 100664620);
    QueryReferenceStripConstraint.NativeMethodInfoPtr_set_MaxReferenceCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr, 100664621);
    QueryReferenceStripConstraint.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr, 100664622);
  }

  public unsafe int MaxReferenceCount
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QueryReferenceStripConstraint.NativeMethodInfoPtr_get_MaxReferenceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryReferenceStripConstraint.NativeMethodInfoPtr_set_MaxReferenceCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 1000115, RefRangeEnd = 1000117, XrefRangeStart = 1000114, XrefRangeEnd = 1000115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe QueryReferenceStripConstraint(
    int aMaxReferenceCount,
    string aAllowedModelTypes,
    string aPlaceholderValue,
    string aAllowedAssetCategories,
    string aAllowedModelTemplates)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryReferenceStripConstraint>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &aMaxReferenceCount;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedModelTypes);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPlaceholderValue);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedAssetCategories);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedModelTemplates);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryReferenceStripConstraint.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int _MaxReferenceCount_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryReferenceStripConstraint.NativeFieldInfoPtr__MaxReferenceCount_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QueryReferenceStripConstraint.NativeFieldInfoPtr__MaxReferenceCount_k__BackingField)) = value;
    }
  }
}
