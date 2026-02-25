// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.CopyLobbyDetailsHandleByUiEventIdOptionsInternal
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
public struct CopyLobbyDetailsHandleByUiEventIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UiEventId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyLobbyDetailsHandleByUiEventIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public ulong m_UiEventId;

  static CopyLobbyDetailsHandleByUiEventIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (CopyLobbyDetailsHandleByUiEventIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr);
    CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeFieldInfoPtr_m_UiEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, nameof (m_UiEventId));
    CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, 100668938);
    CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLobbyDetailsHandleByUiEventIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, 100668939);
    CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, 100668940);
    CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, 100668941);
  }

  public unsafe ulong UiEventId
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(CopyLobbyDetailsHandleByUiEventIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLobbyDetailsHandleByUiEventIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388808, XrefRangeEnd = 388810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLobbyDetailsHandleByUiEventIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLobbyDetailsHandleByUiEventIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
