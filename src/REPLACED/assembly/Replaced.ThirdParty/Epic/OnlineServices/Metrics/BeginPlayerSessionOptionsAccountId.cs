// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.BeginPlayerSessionOptionsAccountId
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics;

public class BeginPlayerSessionOptionsAccountId(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_BeginPlayerSessionOptionsAccountIdInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BeginPlayerSessionOptionsAccountId()
  {
    Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (BeginPlayerSessionOptionsAccountId));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr);
    BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_AccountIdType));
    BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_Epic));
    BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_External));
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668768);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668769);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668770);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668771);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668772);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668773);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668774);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668775);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_BeginPlayerSessionOptionsAccountIdInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668776);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668777);
    BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr, 100668778);
  }

  public unsafe MetricsAccountIdType AccountIdType
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(MetricsAccountIdType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId Epic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387988, XrefRangeEnd = 387994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 388000, RefRangeEnd = 388003, XrefRangeStart = 387994, XrefRangeEnd = 388000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string External
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388003, XrefRangeEnd = 388009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 388015, RefRangeEnd = 388018, XrefRangeStart = 388009, XrefRangeEnd = 388015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388018, XrefRangeEnd = 388023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator BeginPlayerSessionOptionsAccountId(EpicAccountId value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_EpicAccountId_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BeginPlayerSessionOptionsAccountId) null : Il2CppObjectPool.Get<BeginPlayerSessionOptionsAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388023, XrefRangeEnd = 388028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator BeginPlayerSessionOptionsAccountId(string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_BeginPlayerSessionOptionsAccountId_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BeginPlayerSessionOptionsAccountId) null : Il2CppObjectPool.Get<BeginPlayerSessionOptionsAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388028, XrefRangeEnd = 388048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<BeginPlayerSessionOptionsAccountIdInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_BeginPlayerSessionOptionsAccountIdInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388048, XrefRangeEnd = 388072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BeginPlayerSessionOptionsAccountId()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountId>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MetricsAccountIdType m_AccountIdType
  {
    get
    {
      return *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType));
    }
    [param: In] set
    {
      *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType)) = value;
    }
  }

  public unsafe EpicAccountId m_Epic
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic));
      return num == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string m_External
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeginPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
