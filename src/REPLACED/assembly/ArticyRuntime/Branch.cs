// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Branch
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class Branch(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__BranchId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsValid_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Target_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Path_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OriginPinId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsFallback_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UsedFallbackValue_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BranchId_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BranchId_Internal_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsValid_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_get_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Target_Internal_set_Void_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Path_Public_get_List_1_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Path_Private_set_Void_List_1_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginPinId_Public_get_Nullable_1_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginPinId_Internal_set_Void_Nullable_1_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsFallback_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsFallback_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UsedFallbackValue_Internal_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UsedFallbackValue_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultDescription_Public_get_String_0;

  static Branch()
  {
    Il2CppClassPointerStore<Branch>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (Branch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Branch>.NativeClassPtr);
    Branch.NativeFieldInfoPtr__BranchId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<BranchId>k__BackingField");
    Branch.NativeFieldInfoPtr__IsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<IsValid>k__BackingField");
    Branch.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<Target>k__BackingField");
    Branch.NativeFieldInfoPtr__Path_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<Path>k__BackingField");
    Branch.NativeFieldInfoPtr__OriginPinId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<OriginPinId>k__BackingField");
    Branch.NativeFieldInfoPtr__IsFallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<IsFallback>k__BackingField");
    Branch.NativeFieldInfoPtr__UsedFallbackValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Branch>.NativeClassPtr, "<UsedFallbackValue>k__BackingField");
    Branch.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664168);
    Branch.NativeMethodInfoPtr_get_BranchId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664169);
    Branch.NativeMethodInfoPtr_set_BranchId_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664170);
    Branch.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664171);
    Branch.NativeMethodInfoPtr_set_IsValid_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664172);
    Branch.NativeMethodInfoPtr_get_Target_Public_get_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664173);
    Branch.NativeMethodInfoPtr_set_Target_Internal_set_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664174);
    Branch.NativeMethodInfoPtr_get_Path_Public_get_List_1_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664175);
    Branch.NativeMethodInfoPtr_set_Path_Private_set_Void_List_1_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664176 /*0x06000370*/);
    Branch.NativeMethodInfoPtr_get_OriginPinId_Public_get_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664177);
    Branch.NativeMethodInfoPtr_set_OriginPinId_Internal_set_Void_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664178);
    Branch.NativeMethodInfoPtr_get_IsFallback_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664179);
    Branch.NativeMethodInfoPtr_set_IsFallback_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664180);
    Branch.NativeMethodInfoPtr_get_UsedFallbackValue_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664181);
    Branch.NativeMethodInfoPtr_set_UsedFallbackValue_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664182);
    Branch.NativeMethodInfoPtr_get_DefaultDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Branch>.NativeClassPtr, 100664183);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996185, XrefRangeEnd = 996192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Branch(int aBranchId)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Branch>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aBranchId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int BranchId
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_BranchId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_BranchId_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsValid
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_IsValid_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IFlowObject Target
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_Target_Public_get_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_Target_Internal_set_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<IFlowObject> Path
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_Path_Public_get_List_1_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<IFlowObject>) null : Il2CppObjectPool.Get<List<IFlowObject>>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_Path_Private_set_Void_List_1_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<ulong> OriginPinId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_OriginPinId_Public_get_Nullable_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<ulong>(pointer);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 79557, RefRangeEnd = 79563, XrefRangeStart = 79557, XrefRangeEnd = 79563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_OriginPinId_Internal_set_Void_Nullable_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsFallback
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_IsFallback_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_IsFallback_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UsedFallbackValue
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_UsedFallbackValue_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_set_UsedFallbackValue_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DefaultDescription
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996192, XrefRangeEnd = 996213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Branch.NativeMethodInfoPtr_get_DefaultDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe int _BranchId_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__BranchId_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__BranchId_k__BackingField)) = value;
    }
  }

  public unsafe bool _IsValid_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__IsValid_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__IsValid_k__BackingField)) = value;
    }
  }

  public unsafe IFlowObject _Target_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__Target_k__BackingField));
      return num == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<IFlowObject> _Path_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__Path_k__BackingField));
      return num == System.IntPtr.Zero ? (List<IFlowObject>) null : Il2CppObjectPool.Get<List<IFlowObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__Path_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Nullable<ulong> _OriginPinId_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__OriginPinId_k__BackingField);
      return new Il2CppSystem.Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__OriginPinId_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe bool _IsFallback_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__IsFallback_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__IsFallback_k__BackingField)) = value;
    }
  }

  public unsafe bool _UsedFallbackValue_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__UsedFallbackValue_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Branch.NativeFieldInfoPtr__UsedFallbackValue_k__BackingField)) = value;
    }
  }
}
