// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.CredentialsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct CredentialsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Token;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Token_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_ExternalCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_ExternalCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Credentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Token;
  [FieldOffset(16 /*0x10*/)]
  public ExternalCredentialType m_Type;

  static CredentialsInternal()
  {
    Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (CredentialsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr);
    CredentialsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CredentialsInternal.NativeFieldInfoPtr_m_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_Token));
    CredentialsInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, nameof (m_Type));
    CredentialsInternal.NativeMethodInfoPtr_get_Token_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671579);
    CredentialsInternal.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671580);
    CredentialsInternal.NativeMethodInfoPtr_get_Type_Public_get_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671581);
    CredentialsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671582);
    CredentialsInternal.NativeMethodInfoPtr_Set_Public_Void_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671583);
    CredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671584 /*0x06002060*/);
    CredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialsInternal>.NativeClassPtr, 100671585);
  }

  public unsafe string Token
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396994, XrefRangeEnd = 396998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_Token_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396998, XrefRangeEnd = 397002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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

  public unsafe ExternalCredentialType Type
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_get_Type_Public_get_ExternalCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalCredentialType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CredentialsInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_ExternalCredentialType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397002, XrefRangeEnd = 397006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397006, XrefRangeEnd = 397012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397012, XrefRangeEnd = 397016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
