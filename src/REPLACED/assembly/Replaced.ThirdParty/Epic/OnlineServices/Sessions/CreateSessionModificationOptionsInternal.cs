// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.CreateSessionModificationOptionsInternal
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
public struct CreateSessionModificationOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BucketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxPlayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PresenceEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SanctionsEnabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CreateSessionModificationOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_BucketId;
  [FieldOffset(24)]
  public uint m_MaxPlayers;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(40)]
  public int m_PresenceEnabled;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_SessionId;
  [FieldOffset(56)]
  public int m_SanctionsEnabled;

  static CreateSessionModificationOptionsInternal()
  {
    Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (CreateSessionModificationOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr);
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_SessionName));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_BucketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_BucketId));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_MaxPlayers));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_PresenceEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_PresenceEnabled));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_SessionId));
    CreateSessionModificationOptionsInternal.NativeFieldInfoPtr_m_SanctionsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, nameof (m_SanctionsEnabled));
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665405);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665406);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665407);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665408 /*0x06000840*/);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665409);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_SessionId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665410);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665411);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateSessionModificationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665412);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665413);
    CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, 100665414);
  }

  public unsafe string SessionName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377539, XrefRangeEnd = 377543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string BucketId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377543, XrefRangeEnd = 377547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_BucketId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint MaxPlayers
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_MaxPlayers_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377547, XrefRangeEnd = 377553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool PresenceEnabled
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 377559, RefRangeEnd = 377560, XrefRangeStart = 377553, XrefRangeEnd = 377559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_PresenceEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string SessionId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377560, XrefRangeEnd = 377564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_SessionId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool SanctionsEnabled
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 377570, RefRangeEnd = 377571, XrefRangeStart = 377564, XrefRangeEnd = 377570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_set_SanctionsEnabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 377591, RefRangeEnd = 377592, XrefRangeStart = 377571, XrefRangeEnd = 377591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CreateSessionModificationOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateSessionModificationOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377592, XrefRangeEnd = 377595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377595, XrefRangeEnd = 377614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateSessionModificationOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateSessionModificationOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
