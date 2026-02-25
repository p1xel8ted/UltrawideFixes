// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyPackage
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyPackage(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mPackageId;
  private static readonly IntPtr NativeFieldInfoPtr_mPackageName;
  private static readonly IntPtr NativeFieldInfoPtr_mPackagePath;
  private static readonly IntPtr NativeFieldInfoPtr_mResourceKey;
  private static readonly IntPtr NativeFieldInfoPtr__Auxiliary_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_mObjects;
  private static readonly IntPtr NativeFieldInfoPtr_objectIds;
  private static readonly IntPtr NativeMethodInfoPtr_get_PackageId_Public_get_UInt64_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_PackageId_Private_set_Void_UInt64_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PackageName_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_PackageName_Private_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PackagePath_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_PackagePath_Private_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ResourceKey_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ResourceKey_Private_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetupPackage_Private_Void_UInt64_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddObject_Internal_Void_ArticyObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearPackage_Internal_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_PackageObjects_Internal_get_List_1_ArticyObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyPackage()
  {
    Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyPackage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr);
    ArticyPackage.NativeFieldInfoPtr_mPackageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, nameof (mPackageId));
    ArticyPackage.NativeFieldInfoPtr_mPackageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, nameof (mPackageName));
    ArticyPackage.NativeFieldInfoPtr_mPackagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, nameof (mPackagePath));
    ArticyPackage.NativeFieldInfoPtr_mResourceKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, nameof (mResourceKey));
    ArticyPackage.NativeFieldInfoPtr__Auxiliary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, "<Auxiliary>k__BackingField");
    ArticyPackage.NativeFieldInfoPtr_mObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, nameof (mObjects));
    ArticyPackage.NativeFieldInfoPtr_objectIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, nameof (objectIds));
    ArticyPackage.NativeMethodInfoPtr_get_PackageId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663738);
    ArticyPackage.NativeMethodInfoPtr_set_PackageId_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663739);
    ArticyPackage.NativeMethodInfoPtr_get_PackageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663740);
    ArticyPackage.NativeMethodInfoPtr_set_PackageName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663741);
    ArticyPackage.NativeMethodInfoPtr_get_PackagePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663742);
    ArticyPackage.NativeMethodInfoPtr_set_PackagePath_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663743);
    ArticyPackage.NativeMethodInfoPtr_get_ResourceKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663744 /*0x060001C0*/);
    ArticyPackage.NativeMethodInfoPtr_set_ResourceKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663745);
    ArticyPackage.NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663746);
    ArticyPackage.NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663747);
    ArticyPackage.NativeMethodInfoPtr_SetupPackage_Private_Void_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663748);
    ArticyPackage.NativeMethodInfoPtr_AddObject_Internal_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663749);
    ArticyPackage.NativeMethodInfoPtr_Reset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663750);
    ArticyPackage.NativeMethodInfoPtr_ClearPackage_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663751);
    ArticyPackage.NativeMethodInfoPtr_get_PackageObjects_Internal_get_List_1_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663752);
    ArticyPackage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr, 100663753);
  }

  public unsafe ulong PackageId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_get_PackageId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_set_PackageId_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string PackageName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_get_PackageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_set_PackageName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string PackagePath
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_get_PackagePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_set_PackagePath_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ResourceKey
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_get_ResourceKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_set_ResourceKey_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe ArticyEditorAuxiliary Auxiliary
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990321, XrefRangeEnd = 990323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990323, XrefRangeEnd = 990325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990325, XrefRangeEnd = 990345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupPackage(ulong aId, string aName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &aId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aName);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_SetupPackage_Private_Void_UInt64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990345, XrefRangeEnd = 990348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddObject(ArticyObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_AddObject_Internal_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990348, XrefRangeEnd = 990350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_Reset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearPackage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_ClearPackage_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<ArticyObject> PackageObjects
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr_get_PackageObjects_Internal_get_List_1_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990350, XrefRangeEnd = 990357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyPackage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyPackage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPackage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong mPackageId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mPackageId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mPackageId)) = value;
    }
  }

  public unsafe string mPackageName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mPackageName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mPackageName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string mPackagePath
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mPackagePath)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mPackagePath), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string mResourceKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mResourceKey)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mResourceKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe ArticyEditorAuxiliary _Auxiliary_k__BackingField
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyPackage.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyPackage.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyObject> mObjects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mObjects));
      return num == IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_mObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<ulong> objectIds
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_objectIds));
      return num == IntPtr.Zero ? (HashSet<ulong>) null : Il2CppObjectPool.Get<HashSet<ulong>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackage.NativeFieldInfoPtr_objectIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
