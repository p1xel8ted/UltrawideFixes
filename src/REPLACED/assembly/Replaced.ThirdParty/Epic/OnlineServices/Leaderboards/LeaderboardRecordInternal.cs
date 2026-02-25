// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.LeaderboardRecordInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

[StructLayout(LayoutKind.Explicit)]
public struct LeaderboardRecordInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Rank;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Score;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserDisplayName;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Rank_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Rank_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Score_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Score_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserDisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserDisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LeaderboardRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_Rank;
  [FieldOffset(20)]
  public int m_Score;
  [FieldOffset(24)]
  public System.IntPtr m_UserDisplayName;

  static LeaderboardRecordInternal()
  {
    Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (LeaderboardRecordInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr);
    LeaderboardRecordInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LeaderboardRecordInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, nameof (m_UserId));
    LeaderboardRecordInternal.NativeFieldInfoPtr_m_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, nameof (m_Rank));
    LeaderboardRecordInternal.NativeFieldInfoPtr_m_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, nameof (m_Score));
    LeaderboardRecordInternal.NativeFieldInfoPtr_m_UserDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, nameof (m_UserDisplayName));
    LeaderboardRecordInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669984);
    LeaderboardRecordInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669985);
    LeaderboardRecordInternal.NativeMethodInfoPtr_get_Rank_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669986);
    LeaderboardRecordInternal.NativeMethodInfoPtr_set_Rank_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669987);
    LeaderboardRecordInternal.NativeMethodInfoPtr_get_Score_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669988);
    LeaderboardRecordInternal.NativeMethodInfoPtr_set_Score_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669989);
    LeaderboardRecordInternal.NativeMethodInfoPtr_get_UserDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669990);
    LeaderboardRecordInternal.NativeMethodInfoPtr_set_UserDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669991);
    LeaderboardRecordInternal.NativeMethodInfoPtr_Set_Public_Void_LeaderboardRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669992);
    LeaderboardRecordInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669993);
    LeaderboardRecordInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, 100669994);
  }

  public unsafe ProductUserId UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391806, XrefRangeEnd = 391812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391812, XrefRangeEnd = 391816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint Rank
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_get_Rank_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_set_Rank_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int Score
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_get_Score_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_set_Score_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UserDisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391816, XrefRangeEnd = 391820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_get_UserDisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391820, XrefRangeEnd = 391824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_set_UserDisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 391832, RefRangeEnd = 391833, XrefRangeStart = 391824, XrefRangeEnd = 391832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LeaderboardRecord other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_Set_Public_Void_LeaderboardRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391833, XrefRangeEnd = 391836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391836, XrefRangeEnd = 391841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LeaderboardRecordInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LeaderboardRecordInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
