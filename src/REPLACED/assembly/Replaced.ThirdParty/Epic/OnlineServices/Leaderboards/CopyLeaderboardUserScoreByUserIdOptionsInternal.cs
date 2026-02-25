// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardUserScoreByUserIdOptionsInternal
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
public struct CopyLeaderboardUserScoreByUserIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatName;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardUserScoreByUserIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_StatName;

  static CopyLeaderboardUserScoreByUserIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardUserScoreByUserIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr);
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, nameof (m_UserId));
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeFieldInfoPtr_m_StatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, nameof (m_StatName));
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, 100669927);
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, 100669928);
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardUserScoreByUserIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, 100669929);
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, 100669930);
    CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, 100669931);
  }

  public unsafe ProductUserId UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391624, XrefRangeEnd = 391628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string StatName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391628, XrefRangeEnd = 391632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 391640, RefRangeEnd = 391641, XrefRangeStart = 391632, XrefRangeEnd = 391640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CopyLeaderboardUserScoreByUserIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardUserScoreByUserIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391641, XrefRangeEnd = 391644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391644, XrefRangeEnd = 391649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardUserScoreByUserIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLeaderboardUserScoreByUserIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
