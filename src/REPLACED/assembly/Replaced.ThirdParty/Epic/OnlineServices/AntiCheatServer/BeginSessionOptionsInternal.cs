// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.BeginSessionOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer;

[StructLayout(LayoutKind.Explicit)]
public struct BeginSessionOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RegisterTimeoutSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableGameplayData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RegisterTimeoutSeconds_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableGameplayData_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_BeginSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_RegisterTimeoutSeconds;
  [FieldOffset(8)]
  public System.IntPtr m_ServerName;
  [FieldOffset(16 /*0x10*/)]
  public int m_EnableGameplayData;
  [FieldOffset(24)]
  public System.IntPtr m_LocalUserId;

  static BeginSessionOptionsInternal()
  {
    Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatServer", nameof (BeginSessionOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr);
    BeginSessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    BeginSessionOptionsInternal.NativeFieldInfoPtr_m_RegisterTimeoutSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_RegisterTimeoutSeconds));
    BeginSessionOptionsInternal.NativeFieldInfoPtr_m_ServerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_ServerName));
    BeginSessionOptionsInternal.NativeFieldInfoPtr_m_EnableGameplayData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_EnableGameplayData));
    BeginSessionOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    BeginSessionOptionsInternal.NativeMethodInfoPtr_set_RegisterTimeoutSeconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672497);
    BeginSessionOptionsInternal.NativeMethodInfoPtr_set_ServerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672498);
    BeginSessionOptionsInternal.NativeMethodInfoPtr_set_EnableGameplayData_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672499);
    BeginSessionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672500);
    BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_BeginSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672501);
    BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672502);
    BeginSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, 100672503);
  }

  public unsafe uint RegisterTimeoutSeconds
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_RegisterTimeoutSeconds_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ServerName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399756, XrefRangeEnd = 399760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_ServerName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool EnableGameplayData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399760, XrefRangeEnd = 399764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_EnableGameplayData_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399764, XrefRangeEnd = 399768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 399780, RefRangeEnd = 399781, XrefRangeStart = 399768, XrefRangeEnd = 399780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(BeginSessionOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_BeginSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399781, XrefRangeEnd = 399784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399784, XrefRangeEnd = 399789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginSessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
