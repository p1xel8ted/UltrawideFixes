// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.ExternalAccountInfoInternal
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

[StructLayout(LayoutKind.Explicit)]
public struct ExternalAccountInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LastLoginTime;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ExternalAccountInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ProductUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_DisplayName;
  [FieldOffset(24)]
  public System.IntPtr m_AccountId;
  [FieldOffset(32 /*0x20*/)]
  public ExternalAccountType m_AccountIdType;
  [FieldOffset(40)]
  public long m_LastLoginTime;

  static ExternalAccountInfoInternal()
  {
    Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (ExternalAccountInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr);
    ExternalAccountInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ExternalAccountInfoInternal.NativeFieldInfoPtr_m_ProductUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, nameof (m_ProductUserId));
    ExternalAccountInfoInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, nameof (m_DisplayName));
    ExternalAccountInfoInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, nameof (m_AccountId));
    ExternalAccountInfoInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, nameof (m_AccountIdType));
    ExternalAccountInfoInternal.NativeFieldInfoPtr_m_LastLoginTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, nameof (m_LastLoginTime));
    ExternalAccountInfoInternal.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671614);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671615);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671616 /*0x06002080*/);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671617);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_get_AccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671618);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671619);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671620);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671621);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_get_LastLoginTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671622);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_set_LastLoginTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671623);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_Set_Public_Void_ExternalAccountInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671624);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671625);
    ExternalAccountInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, 100671626);
  }

  public unsafe ProductUserId ProductUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397113, XrefRangeEnd = 397119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397119, XrefRangeEnd = 397123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397123, XrefRangeEnd = 397127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397127, XrefRangeEnd = 397131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397131, XrefRangeEnd = 397135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_get_AccountId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397135, XrefRangeEnd = 397139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType AccountIdType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_get_AccountIdType_Public_get_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_set_AccountIdType_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> LastLoginTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397139, XrefRangeEnd = 397143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_get_LastLoginTime_Public_get_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397143, XrefRangeEnd = 397147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_set_LastLoginTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 397163, RefRangeEnd = 397164, XrefRangeStart = 397147, XrefRangeEnd = 397163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ExternalAccountInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_Set_Public_Void_ExternalAccountInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397164, XrefRangeEnd = 397167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397167, XrefRangeEnd = 397173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalAccountInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExternalAccountInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
