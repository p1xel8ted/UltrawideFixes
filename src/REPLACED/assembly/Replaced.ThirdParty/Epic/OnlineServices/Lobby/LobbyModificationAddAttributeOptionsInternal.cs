// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbyModificationAddAttributeOptionsInternal
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
public struct LobbyModificationAddAttributeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Attribute;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Visibility;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Attribute_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LobbyModificationAddAttributeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Attribute;
  [FieldOffset(16 /*0x10*/)]
  public LobbyAttributeVisibility m_Visibility;

  static LobbyModificationAddAttributeOptionsInternal()
  {
    Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbyModificationAddAttributeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr);
    LobbyModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LobbyModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_Attribute));
    LobbyModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_Visibility));
    LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_Attribute_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, 100669418);
    LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, 100669419);
    LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, 100669420);
    LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, 100669421);
    LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, 100669422);
  }

  public unsafe AttributeData Attribute
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 390653, RefRangeEnd = 390655, XrefRangeStart = 390647, XrefRangeEnd = 390653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_Attribute_Public_set_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390655, XrefRangeEnd = 390656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LobbyModificationAddAttributeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbyModificationAddAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390656, XrefRangeEnd = 390659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390659, XrefRangeEnd = 390663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbyModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyModificationAddAttributeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
