// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.UnlockAchievementsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct UnlockAchievementsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementsCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementIds_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_UnlockAchievementsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_AchievementIds;
  [FieldOffset(24)]
  public uint m_AchievementsCount;

  static UnlockAchievementsOptionsInternal()
  {
    Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (UnlockAchievementsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr);
    UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_UserId));
    UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_AchievementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_AchievementIds));
    UnlockAchievementsOptionsInternal.NativeFieldInfoPtr_m_AchievementsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, nameof (m_AchievementsCount));
    UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100673619);
    UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_AchievementIds_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100673620);
    UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_UnlockAchievementsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100673621);
    UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100673622);
    UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, 100673623);
  }

  public unsafe ProductUserId UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402962, XrefRangeEnd = 402966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray AchievementIds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 402972, RefRangeEnd = 402974, XrefRangeStart = 402966, XrefRangeEnd = 402972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_set_AchievementIds_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402974, XrefRangeEnd = 402979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(UnlockAchievementsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_UnlockAchievementsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402979, XrefRangeEnd = 402986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402986, XrefRangeEnd = 402991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnlockAchievementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnlockAchievementsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
