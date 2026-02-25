// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.UserScoresQueryStatInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

[StructLayout(LayoutKind.Explicit)]
public struct UserScoresQueryStatInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Aggregation;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_UserScoresQueryStatInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_StatName;
  [FieldOffset(16 /*0x10*/)]
  public LeaderboardAggregation m_Aggregation;

  static UserScoresQueryStatInfoInternal()
  {
    Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (UserScoresQueryStatInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr);
    UserScoresQueryStatInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    UserScoresQueryStatInfoInternal.NativeFieldInfoPtr_m_StatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, nameof (m_StatName));
    UserScoresQueryStatInfoInternal.NativeFieldInfoPtr_m_Aggregation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, nameof (m_Aggregation));
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_StatName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670132);
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670133);
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670134);
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670135);
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Void_UserScoresQueryStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670136);
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670137);
    UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, 100670138);
  }

  public unsafe string StatName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392288, XrefRangeEnd = 392292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_StatName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392292, XrefRangeEnd = 392296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LeaderboardAggregation Aggregation
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LeaderboardAggregation*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392296, XrefRangeEnd = 392300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(UserScoresQueryStatInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Void_UserScoresQueryStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392300, XrefRangeEnd = 392306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392306, XrefRangeEnd = 392310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserScoresQueryStatInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
