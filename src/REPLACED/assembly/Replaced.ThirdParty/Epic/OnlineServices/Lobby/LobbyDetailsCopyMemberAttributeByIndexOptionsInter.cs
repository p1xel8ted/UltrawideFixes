// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyDetailsCopyMemberAttributeByIndexOptionsInternal
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
public struct LobbyDetailsCopyMemberAttributeByIndexOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AttrIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AttrIndex_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LobbyDetailsCopyMemberAttributeByIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_AttrIndex;

  static LobbyDetailsCopyMemberAttributeByIndexOptionsInternal()
  {
    Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyDetailsCopyMemberAttributeByIndexOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr);
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeFieldInfoPtr_m_AttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, nameof (m_AttrIndex));
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, 100669199);
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_set_AttrIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, 100669200);
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyDetailsCopyMemberAttributeByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, 100669201);
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, 100669202);
    LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, 100669203);
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389538, XrefRangeEnd = 389542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint AttrIndex
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_set_AttrIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389542, XrefRangeEnd = 389546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    LobbyDetailsCopyMemberAttributeByIndexOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyDetailsCopyMemberAttributeByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389546, XrefRangeEnd = 389552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389552, XrefRangeEnd = 389556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyDetailsCopyMemberAttributeByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyDetailsCopyMemberAttributeByIndexOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
