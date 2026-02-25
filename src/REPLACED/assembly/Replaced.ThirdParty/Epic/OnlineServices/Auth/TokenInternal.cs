// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.TokenInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

[StructLayout(LayoutKind.Explicit)]
public struct TokenInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_App;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccessToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiresIn;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiresAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AuthType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshExpiresIn;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshExpiresAt;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_App_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_App_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AccessToken_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccessToken_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresAt_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresAt_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AuthType_Public_get_AuthTokenType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthType_Public_set_Void_AuthTokenType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RefreshExpiresIn_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshExpiresIn_Public_set_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RefreshExpiresAt_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshExpiresAt_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Token_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_App;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ClientId;
  [FieldOffset(24)]
  public System.IntPtr m_AccountId;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_AccessToken;
  [FieldOffset(40)]
  public double m_ExpiresIn;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_ExpiresAt;
  [FieldOffset(56)]
  public AuthTokenType m_AuthType;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_RefreshToken;
  [FieldOffset(72)]
  public double m_RefreshExpiresIn;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr m_RefreshExpiresAt;

  static TokenInternal()
  {
    Il2CppClassPointerStore<TokenInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (TokenInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr);
    TokenInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ApiVersion));
    TokenInternal.NativeFieldInfoPtr_m_App = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_App));
    TokenInternal.NativeFieldInfoPtr_m_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ClientId));
    TokenInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_AccountId));
    TokenInternal.NativeFieldInfoPtr_m_AccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_AccessToken));
    TokenInternal.NativeFieldInfoPtr_m_ExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ExpiresIn));
    TokenInternal.NativeFieldInfoPtr_m_ExpiresAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_ExpiresAt));
    TokenInternal.NativeFieldInfoPtr_m_AuthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_AuthType));
    TokenInternal.NativeFieldInfoPtr_m_RefreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_RefreshToken));
    TokenInternal.NativeFieldInfoPtr_m_RefreshExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_RefreshExpiresIn));
    TokenInternal.NativeFieldInfoPtr_m_RefreshExpiresAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, nameof (m_RefreshExpiresAt));
    TokenInternal.NativeMethodInfoPtr_get_App_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672351);
    TokenInternal.NativeMethodInfoPtr_set_App_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672352);
    TokenInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672353);
    TokenInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672354);
    TokenInternal.NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672355);
    TokenInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672356);
    TokenInternal.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672357);
    TokenInternal.NativeMethodInfoPtr_set_AccessToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672358);
    TokenInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672359);
    TokenInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672360);
    TokenInternal.NativeMethodInfoPtr_get_ExpiresAt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672361);
    TokenInternal.NativeMethodInfoPtr_set_ExpiresAt_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672362);
    TokenInternal.NativeMethodInfoPtr_get_AuthType_Public_get_AuthTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672363);
    TokenInternal.NativeMethodInfoPtr_set_AuthType_Public_set_Void_AuthTokenType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672364);
    TokenInternal.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672365);
    TokenInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672366);
    TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresIn_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672367);
    TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresIn_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672368);
    TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresAt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672369);
    TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresAt_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672370);
    TokenInternal.NativeMethodInfoPtr_Set_Public_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672371);
    TokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672372);
    TokenInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, 100672373);
  }

  public unsafe string App
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399180, XrefRangeEnd = 399184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_App_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399184, XrefRangeEnd = 399188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_App_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ClientId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399188, XrefRangeEnd = 399192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399192, XrefRangeEnd = 399196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId AccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399196, XrefRangeEnd = 399202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_AccountId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399202, XrefRangeEnd = 399206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AccessToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399206, XrefRangeEnd = 399210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_AccessToken_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399210, XrefRangeEnd = 399214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_AccessToken_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe double ExpiresIn
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ExpiresAt
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399214, XrefRangeEnd = 399218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_ExpiresAt_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399218, XrefRangeEnd = 399222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_ExpiresAt_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AuthTokenType AuthType
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_AuthType_Public_get_AuthTokenType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AuthTokenType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 123407, RefRangeEnd = 123416, XrefRangeStart = 123407, XrefRangeEnd = 123416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_AuthType_Public_set_Void_AuthTokenType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RefreshToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399222, XrefRangeEnd = 399226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_RefreshToken_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399226, XrefRangeEnd = 399230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe double RefreshExpiresIn
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresIn_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresIn_Public_set_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RefreshExpiresAt
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399230, XrefRangeEnd = 399234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_get_RefreshExpiresAt_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399234, XrefRangeEnd = 399238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_set_RefreshExpiresAt_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 399266, RefRangeEnd = 399267, XrefRangeStart = 399238, XrefRangeEnd = 399266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Token other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Set_Public_Void_Token_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399267, XrefRangeEnd = 399270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399270, XrefRangeEnd = 399280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TokenInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TokenInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
