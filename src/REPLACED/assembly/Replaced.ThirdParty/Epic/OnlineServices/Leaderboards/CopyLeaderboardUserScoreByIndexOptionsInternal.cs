// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardUserScoreByIndexOptionsInternal
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
public struct CopyLeaderboardUserScoreByIndexOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LeaderboardUserScoreIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatName;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardUserScoreIndex_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardUserScoreByIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_LeaderboardUserScoreIndex;
  [FieldOffset(8)]
  public System.IntPtr m_StatName;

  static CopyLeaderboardUserScoreByIndexOptionsInternal()
  {
    Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardUserScoreByIndexOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr);
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeFieldInfoPtr_m_LeaderboardUserScoreIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, nameof (m_LeaderboardUserScoreIndex));
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeFieldInfoPtr_m_StatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, nameof (m_StatName));
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_set_LeaderboardUserScoreIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, 100669917);
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, 100669918);
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardUserScoreByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, 100669919);
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, 100669920);
    CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, 100669921);
  }

  public unsafe uint LeaderboardUserScoreIndex
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_set_LeaderboardUserScoreIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string StatName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391606, XrefRangeEnd = 391610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391610, XrefRangeEnd = 391614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CopyLeaderboardUserScoreByIndexOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardUserScoreByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391614, XrefRangeEnd = 391620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391620, XrefRangeEnd = 391624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLeaderboardUserScoreByIndexOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
