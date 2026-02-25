// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal
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
public struct CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LeaderboardId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardDefinitionByLeaderboardIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LeaderboardId;

  static CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr);
    CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeFieldInfoPtr_m_LeaderboardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, nameof (m_LeaderboardId));
    CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100669894);
    CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardDefinitionByLeaderboardIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100669895);
    CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100669896);
    CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, 100669897);
  }

  public unsafe string LeaderboardId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391568, XrefRangeEnd = 391572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391572, XrefRangeEnd = 391576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    CopyLeaderboardDefinitionByLeaderboardIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyLeaderboardDefinitionByLeaderboardIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391576, XrefRangeEnd = 391582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391582, XrefRangeEnd = 391586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyLeaderboardDefinitionByLeaderboardIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
