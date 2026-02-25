// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.JoinSessionOptionsInternal
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
public struct JoinSessionOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PresenceEnabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionHandle_Public_set_Void_SessionDetails_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_JoinSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_SessionHandle;
  [FieldOffset(24)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(32 /*0x20*/)]
  public int m_PresenceEnabled;

  static JoinSessionOptionsInternal()
  {
    Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (JoinSessionOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr);
    JoinSessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    JoinSessionOptionsInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, nameof (m_SessionName));
    JoinSessionOptionsInternal.NativeFieldInfoPtr_m_SessionHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, nameof (m_SessionHandle));
    JoinSessionOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    JoinSessionOptionsInternal.NativeFieldInfoPtr_m_PresenceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, nameof (m_PresenceEnabled));
    JoinSessionOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665526);
    JoinSessionOptionsInternal.NativeMethodInfoPtr_set_SessionHandle_Public_set_Void_SessionDetails_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665527);
    JoinSessionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665528);
    JoinSessionOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665529);
    JoinSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_JoinSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665530);
    JoinSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665531);
    JoinSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, 100665532);
  }

  public unsafe string SessionName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377907, XrefRangeEnd = 377911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SessionDetails SessionHandle
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377911, XrefRangeEnd = 377917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_set_SessionHandle_Public_set_Void_SessionDetails_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377917, XrefRangeEnd = 377923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PresenceEnabled
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 377929, RefRangeEnd = 377930, XrefRangeStart = 377923, XrefRangeEnd = 377929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 377947, RefRangeEnd = 377948, XrefRangeStart = 377930, XrefRangeEnd = 377947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(JoinSessionOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_JoinSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377948, XrefRangeEnd = 377951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377951, XrefRangeEnd = 377966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JoinSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JoinSessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
