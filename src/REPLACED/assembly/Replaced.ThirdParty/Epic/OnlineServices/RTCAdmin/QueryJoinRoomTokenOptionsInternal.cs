// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAdmin.QueryJoinRoomTokenOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAdmin;

[StructLayout(LayoutKind.Explicit)]
public struct QueryJoinRoomTokenOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserIdsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserIpAddresses;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserIpAddresses_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryJoinRoomTokenOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public System.IntPtr m_TargetUserIds;
  [FieldOffset(32 /*0x20*/)]
  public uint m_TargetUserIdsCount;
  [FieldOffset(40)]
  public System.IntPtr m_TargetUserIpAddresses;

  static QueryJoinRoomTokenOptionsInternal()
  {
    Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAdmin", nameof (QueryJoinRoomTokenOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr);
    QueryJoinRoomTokenOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryJoinRoomTokenOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryJoinRoomTokenOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
    QueryJoinRoomTokenOptionsInternal.NativeFieldInfoPtr_m_TargetUserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, nameof (m_TargetUserIds));
    QueryJoinRoomTokenOptionsInternal.NativeFieldInfoPtr_m_TargetUserIdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, nameof (m_TargetUserIdsCount));
    QueryJoinRoomTokenOptionsInternal.NativeFieldInfoPtr_m_TargetUserIpAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, nameof (m_TargetUserIpAddresses));
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666774);
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666775);
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_TargetUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666776);
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_TargetUserIpAddresses_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666777);
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryJoinRoomTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666778);
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666779);
    QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, 100666780);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381610, XrefRangeEnd = 381614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381614, XrefRangeEnd = 381618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> TargetUserIds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 381624, RefRangeEnd = 381625, XrefRangeStart = 381618, XrefRangeEnd = 381624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_TargetUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TargetUserIpAddresses
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381625, XrefRangeEnd = 381629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_set_TargetUserIpAddresses_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 381642, RefRangeEnd = 381643, XrefRangeStart = 381629, XrefRangeEnd = 381642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryJoinRoomTokenOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryJoinRoomTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381643, XrefRangeEnd = 381646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381646, XrefRangeEnd = 381653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryJoinRoomTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryJoinRoomTokenOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
