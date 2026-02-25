// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.ClientCredentialsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

[StructLayout(LayoutKind.Explicit)]
public struct ClientCredentialsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientSecret;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientSecret_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ClientCredentials_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientId;
  [FieldOffset(8)]
  public System.IntPtr m_ClientSecret;

  static ClientCredentialsInternal()
  {
    Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (ClientCredentialsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr);
    ClientCredentialsInternal.NativeFieldInfoPtr_m_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, nameof (m_ClientId));
    ClientCredentialsInternal.NativeFieldInfoPtr_m_ClientSecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, nameof (m_ClientSecret));
    ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667940);
    ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667941);
    ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientSecret_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667942);
    ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667943);
    ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Void_ClientCredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667944);
    ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667945);
    ClientCredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, 100667946);
  }

  public unsafe string ClientId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385485, XrefRangeEnd = 385489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385489, XrefRangeEnd = 385493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ClientSecret
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385493, XrefRangeEnd = 385497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_get_ClientSecret_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385497, XrefRangeEnd = 385501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_set_ClientSecret_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 385509, RefRangeEnd = 385510, XrefRangeStart = 385501, XrefRangeEnd = 385509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ClientCredentials other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Void_ClientCredentials_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385510, XrefRangeEnd = 385513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385513, XrefRangeEnd = 385518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClientCredentialsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClientCredentialsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
