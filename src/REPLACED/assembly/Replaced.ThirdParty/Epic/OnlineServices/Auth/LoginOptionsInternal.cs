// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.LoginOptionsInternal
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
public struct LoginOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Credentials;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ScopeFlags;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Credentials_Public_set_Void_Credentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LoginOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Credentials;
  [FieldOffset(16 /*0x10*/)]
  public AuthScopeFlags m_ScopeFlags;

  static LoginOptionsInternal()
  {
    Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (LoginOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr);
    LoginOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LoginOptionsInternal.NativeFieldInfoPtr_m_Credentials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_Credentials));
    LoginOptionsInternal.NativeFieldInfoPtr_m_ScopeFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, nameof (m_ScopeFlags));
    LoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Credentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672172);
    LoginOptionsInternal.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672173);
    LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LoginOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672174);
    LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672175);
    LoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, 100672176);
  }

  public unsafe Credentials Credentials
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 398793, RefRangeEnd = 398795, XrefRangeStart = 398787, XrefRangeEnd = 398793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_set_Credentials_Public_set_Void_Credentials_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AuthScopeFlags ScopeFlags
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_set_ScopeFlags_Public_set_Void_AuthScopeFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398795, XrefRangeEnd = 398796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LoginOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LoginOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398796, XrefRangeEnd = 398799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398799, XrefRangeEnd = 398803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoginOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoginOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
