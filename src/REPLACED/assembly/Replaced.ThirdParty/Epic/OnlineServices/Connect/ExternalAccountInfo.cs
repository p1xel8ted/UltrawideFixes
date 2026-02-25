// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.ExternalAccountInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

public class ExternalAccountInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ProductUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DisplayName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AccountId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AccountIdType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LastLoginTime_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastLoginTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LastLoginTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_ExternalAccountInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ExternalAccountInfo()
  {
    Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (ExternalAccountInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr);
    ExternalAccountInfo.NativeFieldInfoPtr__ProductUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, "<ProductUserId>k__BackingField");
    ExternalAccountInfo.NativeFieldInfoPtr__DisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, "<DisplayName>k__BackingField");
    ExternalAccountInfo.NativeFieldInfoPtr__AccountId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, "<AccountId>k__BackingField");
    ExternalAccountInfo.NativeFieldInfoPtr__AccountIdType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, "<AccountIdType>k__BackingField");
    ExternalAccountInfo.NativeFieldInfoPtr__LastLoginTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, "<LastLoginTime>k__BackingField");
    ExternalAccountInfo.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671601);
    ExternalAccountInfo.NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671602);
    ExternalAccountInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671603);
    ExternalAccountInfo.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671604);
    ExternalAccountInfo.NativeMethodInfoPtr_get_AccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671605);
    ExternalAccountInfo.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671606);
    ExternalAccountInfo.NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671607);
    ExternalAccountInfo.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671608);
    ExternalAccountInfo.NativeMethodInfoPtr_get_LastLoginTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671609);
    ExternalAccountInfo.NativeMethodInfoPtr_set_LastLoginTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671610);
    ExternalAccountInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_ExternalAccountInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671611);
    ExternalAccountInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671612);
    ExternalAccountInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr, 100671613);
  }

  public unsafe ProductUserId ProductUserId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_get_AccountId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType AccountIdType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> LastLoginTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_get_LastLoginTime_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_set_LastLoginTime_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397049, XrefRangeEnd = 397079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<ExternalAccountInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_ExternalAccountInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397079, XrefRangeEnd = 397113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ExternalAccountInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalAccountInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ProductUserId _ProductUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__ProductUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__ProductUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _DisplayName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__DisplayName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__DisplayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _AccountId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__AccountId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__AccountId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ExternalAccountType _AccountIdType_k__BackingField
  {
    get
    {
      return *(ExternalAccountType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__AccountIdType_k__BackingField));
    }
    [param: In] set
    {
      *(ExternalAccountType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__AccountIdType_k__BackingField)) = value;
    }
  }

  public Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> _LastLoginTime_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__LastLoginTime_k__BackingField);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExternalAccountInfo.NativeFieldInfoPtr__LastLoginTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
