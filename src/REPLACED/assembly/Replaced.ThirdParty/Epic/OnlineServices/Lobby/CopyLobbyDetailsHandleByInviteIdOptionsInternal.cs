// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.CopyLobbyDetailsHandleByInviteIdOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

[StructLayout(LayoutKind.Explicit)]
public struct CopyLobbyDetailsHandleByInviteIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InviteId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InviteId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyLobbyDetailsHandleByInviteIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_InviteId;

  static CopyLobbyDetailsHandleByInviteIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (CopyLobbyDetailsHandleByInviteIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr);
    CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeFieldInfoPtr_m_InviteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, nameof (m_InviteId));
    CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_set_InviteId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, 100668931);
    CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLobbyDetailsHandleByInviteIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, 100668932);
    CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, 100668933);
    CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, 100668934);
  }

  public unsafe string InviteId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388790, XrefRangeEnd = 388794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_set_InviteId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388794, XrefRangeEnd = 388798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CopyLobbyDetailsHandleByInviteIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLobbyDetailsHandleByInviteIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388798, XrefRangeEnd = 388804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388804, XrefRangeEnd = 388808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByInviteIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLobbyDetailsHandleByInviteIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
