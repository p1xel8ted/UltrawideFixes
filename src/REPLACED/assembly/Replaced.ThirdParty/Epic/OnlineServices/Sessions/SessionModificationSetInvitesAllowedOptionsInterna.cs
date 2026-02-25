// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionModificationSetInvitesAllowedOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct SessionModificationSetInvitesAllowedOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InvitesAllowed;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionModificationSetInvitesAllowedOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public int m_InvitesAllowed;

  static SessionModificationSetInvitesAllowedOptionsInternal()
  {
    Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionModificationSetInvitesAllowedOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr);
    SessionModificationSetInvitesAllowedOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionModificationSetInvitesAllowedOptionsInternal.NativeFieldInfoPtr_m_InvitesAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, nameof (m_InvitesAllowed));
    SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, 100665907);
    SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionModificationSetInvitesAllowedOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, 100665908);
    SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, 100665909);
    SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, 100665910);
  }

  public unsafe bool InvitesAllowed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378886, XrefRangeEnd = 378890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_set_InvitesAllowed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378890, XrefRangeEnd = 378894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionModificationSetInvitesAllowedOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionModificationSetInvitesAllowedOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378894, XrefRangeEnd = 378900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModificationSetInvitesAllowedOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionModificationSetInvitesAllowedOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
