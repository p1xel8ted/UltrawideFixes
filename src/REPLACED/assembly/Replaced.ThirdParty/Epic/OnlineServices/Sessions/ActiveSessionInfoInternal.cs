// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.ActiveSessionInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct ActiveSessionInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_State;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionDetails;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_State_Public_get_OnlineSessionState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_State_Public_set_Void_OnlineSessionState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionDetails_Public_get_SessionDetailsInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionDetails_Public_set_Void_SessionDetailsInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ActiveSessionInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(24)]
  public OnlineSessionState m_State;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_SessionDetails;

  static ActiveSessionInfoInternal()
  {
    Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (ActiveSessionInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr);
    ActiveSessionInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ActiveSessionInfoInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, nameof (m_SessionName));
    ActiveSessionInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    ActiveSessionInfoInternal.NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, nameof (m_State));
    ActiveSessionInfoInternal.NativeFieldInfoPtr_m_SessionDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, nameof (m_SessionDetails));
    ActiveSessionInfoInternal.NativeMethodInfoPtr_get_SessionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665297);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665298);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665299);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665300);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_get_State_Public_get_OnlineSessionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665301);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_set_State_Public_set_Void_OnlineSessionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665302);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_get_SessionDetails_Public_get_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665303);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_set_SessionDetails_Public_set_Void_SessionDetailsInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665304);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_Set_Public_Void_ActiveSessionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665305);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665306);
    ActiveSessionInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, 100665307);
  }

  public unsafe string SessionName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377076, XrefRangeEnd = 377080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_get_SessionName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377080, XrefRangeEnd = 377084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377084, XrefRangeEnd = 377090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377090, XrefRangeEnd = 377096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe OnlineSessionState State
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_get_State_Public_get_OnlineSessionState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(OnlineSessionState*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_set_State_Public_set_Void_OnlineSessionState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SessionDetailsInfo SessionDetails
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377096, XrefRangeEnd = 377102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_get_SessionDetails_Public_get_SessionDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SessionDetailsInfo) null : Il2CppObjectPool.Get<SessionDetailsInfo>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 377108, RefRangeEnd = 377109, XrefRangeStart = 377102, XrefRangeEnd = 377108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_set_SessionDetails_Public_set_Void_SessionDetailsInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 377120, RefRangeEnd = 377121, XrefRangeStart = 377109, XrefRangeEnd = 377120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ActiveSessionInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_Set_Public_Void_ActiveSessionInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377121, XrefRangeEnd = 377124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377124, XrefRangeEnd = 377139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActiveSessionInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActiveSessionInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
