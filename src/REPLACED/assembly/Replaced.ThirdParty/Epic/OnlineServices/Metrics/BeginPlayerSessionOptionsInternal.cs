// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.BeginPlayerSessionOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics;

[StructLayout(LayoutKind.Explicit)]
public struct BeginPlayerSessionOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ControllerType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ServerIp;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_GameSessionId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_BeginPlayerSessionOptionsAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ControllerType_Public_set_Void_UserControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ServerIp_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_GameSessionId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_BeginPlayerSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public BeginPlayerSessionOptionsAccountIdInternal m_AccountId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_DisplayName;
  [FieldOffset(24)]
  public UserControllerType m_ControllerType;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ServerIp;
  [FieldOffset(40)]
  public System.IntPtr m_GameSessionId;

  static BeginPlayerSessionOptionsInternal()
  {
    Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (BeginPlayerSessionOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr);
    BeginPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    BeginPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_AccountId));
    BeginPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_DisplayName));
    BeginPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_ControllerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_ControllerType));
    BeginPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_ServerIp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_ServerIp));
    BeginPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_GameSessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_GameSessionId));
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668760);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668761);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_ControllerType_Public_set_Void_UserControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668762);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_ServerIp_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668763);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_GameSessionId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668764);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_BeginPlayerSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668765);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668766);
    BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, 100668767);
  }

  public unsafe BeginPlayerSessionOptionsAccountId AccountId
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 387949, RefRangeEnd = 387950, XrefRangeStart = 387943, XrefRangeEnd = 387949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_BeginPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387950, XrefRangeEnd = 387954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe UserControllerType ControllerType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_ControllerType_Public_set_Void_UserControllerType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ServerIp
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387954, XrefRangeEnd = 387958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_ServerIp_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string GameSessionId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387958, XrefRangeEnd = 387962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_GameSessionId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 387975, RefRangeEnd = 387976, XrefRangeStart = 387962, XrefRangeEnd = 387975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(BeginPlayerSessionOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_BeginPlayerSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387976, XrefRangeEnd = 387979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387979, XrefRangeEnd = 387988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginPlayerSessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
