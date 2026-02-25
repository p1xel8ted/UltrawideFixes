// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModificationAddMemberAttributeOptionsInternal
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
public struct LobbyModificationAddMemberAttributeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Attribute;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Visibility;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Attribute_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LobbyModificationAddMemberAttributeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Attribute;
  [FieldOffset(16 /*0x10*/)]
  public LobbyAttributeVisibility m_Visibility;

  static LobbyModificationAddMemberAttributeOptionsInternal()
  {
    Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModificationAddMemberAttributeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr);
    LobbyModificationAddMemberAttributeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LobbyModificationAddMemberAttributeOptionsInternal.NativeFieldInfoPtr_m_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, nameof (m_Attribute));
    LobbyModificationAddMemberAttributeOptionsInternal.NativeFieldInfoPtr_m_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, nameof (m_Visibility));
    LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_set_Attribute_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, 100669428);
    LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, 100669429);
    LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyModificationAddMemberAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, 100669430);
    LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, 100669431);
    LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, 100669432);
  }

  public unsafe AttributeData Attribute
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 390669, RefRangeEnd = 390671, XrefRangeStart = 390663, XrefRangeEnd = 390669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_set_Attribute_Public_set_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LobbyAttributeVisibility Visibility
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390671, XrefRangeEnd = 390672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LobbyModificationAddMemberAttributeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyModificationAddMemberAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390672, XrefRangeEnd = 390675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390675, XrefRangeEnd = 390679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddMemberAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyModificationAddMemberAttributeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
