// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.OnAchievementsUnlockedCallbackV2InfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct OnAchievementsUnlockedCallbackV2InfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_AchievementId;
  [FieldOffset(24)]
  public long m_UnlockTime;

  static OnAchievementsUnlockedCallbackV2InfoInternal()
  {
    Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (OnAchievementsUnlockedCallbackV2InfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr);
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, nameof (m_UserId));
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, nameof (m_AchievementId));
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeFieldInfoPtr_m_UnlockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, nameof (m_UnlockTime));
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, 100673450);
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, 100673451);
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, 100673452);
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, 100673453);
    OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, 100673454);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402495, XrefRangeEnd = 402499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402499, XrefRangeEnd = 402505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402505, XrefRangeEnd = 402509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> UnlockTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402509, XrefRangeEnd = 402513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackV2InfoInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackV2InfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
