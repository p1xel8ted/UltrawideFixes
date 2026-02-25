// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.CredentialsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

[StructLayout(LayoutKind.Explicit)]
public struct CredentialsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Token;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SystemAuthCredentialsOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExternalType;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Token_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Credentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Id;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Token;
  [FieldOffset(24)]
  public LoginCredentialType m_Type;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_SystemAuthCredentialsOptions;
  [FieldOffset(40)]
  public ExternalCredentialType m_ExternalType;

  static CredentialsInternal()
  {
    Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (CredentialsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr);
    CredentialsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CredentialsInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_Id));
    CredentialsInternal.NativeFieldInfoPtr_m_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_Token));
    CredentialsInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_Type));
    CredentialsInternal.NativeFieldInfoPtr_m_SystemAuthCredentialsOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_SystemAuthCredentialsOptions));
    CredentialsInternal.NativeFieldInfoPtr_m_ExternalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_ExternalType));
    CredentialsInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672063);
    CredentialsInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672064);
    CredentialsInternal.NativeMethodInfoPtr_get_Token_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672065);
    CredentialsInternal.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672066);
    CredentialsInternal.NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672067);
    CredentialsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672068);
    CredentialsInternal.NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672069);
    CredentialsInternal.NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672070);
    CredentialsInternal.NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672071);
    CredentialsInternal.NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672072);
    CredentialsInternal.NativeMethodInfoPtr_Set_Public_Void_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672073);
    CredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672074);
    CredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100672075);
  }

  public unsafe string Id
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398418, XrefRangeEnd = 398422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398422, XrefRangeEnd = 398426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Token
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398426, XrefRangeEnd = 398430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_Token_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398430, XrefRangeEnd = 398434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LoginCredentialType Type
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_Type_Public_get_LoginCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LoginCredentialType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_LoginCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr SystemAuthCredentialsOptions
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_SystemAuthCredentialsOptions_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_set_SystemAuthCredentialsOptions_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalCredentialType ExternalType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_ExternalType_Public_get_ExternalCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalCredentialType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_set_ExternalType_Public_set_Void_ExternalCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 398442, RefRangeEnd = 398443, XrefRangeStart = 398434, XrefRangeEnd = 398442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Credentials other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_Set_Public_Void_Credentials_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398443, XrefRangeEnd = 398446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398446, XrefRangeEnd = 398452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
