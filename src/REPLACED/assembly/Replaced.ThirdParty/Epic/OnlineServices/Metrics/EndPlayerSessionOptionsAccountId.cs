// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.EndPlayerSessionOptionsAccountId
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

public class EndPlayerSessionOptionsAccountId(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_EndPlayerSessionOptionsAccountIdInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EndPlayerSessionOptionsAccountId()
  {
    Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (EndPlayerSessionOptionsAccountId));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr);
    EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_AccountIdType));
    EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_Epic));
    EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_External));
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668793);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668794);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668795);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668796);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668797);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668798);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668799);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668800);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_EndPlayerSessionOptionsAccountIdInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668801);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668802);
    EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100668803);
  }

  public unsafe MetricsAccountIdType AccountIdType
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId Epic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388147, XrefRangeEnd = 388153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 388159, RefRangeEnd = 388162, XrefRangeStart = 388153, XrefRangeEnd = 388159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string External
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388162, XrefRangeEnd = 388168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 388174, RefRangeEnd = 388177, XrefRangeStart = 388168, XrefRangeEnd = 388174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388177, XrefRangeEnd = 388182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator EndPlayerSessionOptionsAccountId(EpicAccountId value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_EpicAccountId_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EndPlayerSessionOptionsAccountId) null : Il2CppObjectPool.Get<EndPlayerSessionOptionsAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388182, XrefRangeEnd = 388187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator EndPlayerSessionOptionsAccountId(string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EndPlayerSessionOptionsAccountId) null : Il2CppObjectPool.Get<EndPlayerSessionOptionsAccountId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388187, XrefRangeEnd = 388207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<EndPlayerSessionOptionsAccountIdInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_EndPlayerSessionOptionsAccountIdInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388207, XrefRangeEnd = 388231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EndPlayerSessionOptionsAccountId()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MetricsAccountIdType m_AccountIdType
  {
    get
    {
      return *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType));
    }
    [param: In] set
    {
      *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType)) = value;
    }
  }

  public unsafe EpicAccountId m_Epic
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic));
      return num == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string m_External
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
