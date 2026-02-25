// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.PlayerAchievementInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct PlayerAchievementInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Progress;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfoCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Description;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IconURL;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FlavorText;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Progress_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Progress_Public_set_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatInfo_Public_get_Il2CppReferenceArray_1_PlayerStatInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_PlayerStatInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IconURL_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IconURL_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FlavorText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PlayerAchievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AchievementId;
  [FieldOffset(16 /*0x10*/)]
  public double m_Progress;
  [FieldOffset(24)]
  public long m_UnlockTime;
  [FieldOffset(32 /*0x20*/)]
  public int m_StatInfoCount;
  [FieldOffset(40)]
  public System.IntPtr m_StatInfo;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_DisplayName;
  [FieldOffset(56)]
  public System.IntPtr m_Description;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_IconURL;
  [FieldOffset(72)]
  public System.IntPtr m_FlavorText;

  static PlayerAchievementInternal()
  {
    Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (PlayerAchievementInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr);
    PlayerAchievementInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_AchievementId));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_Progress));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_UnlockTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_UnlockTime));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_StatInfoCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_StatInfoCount));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_StatInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_StatInfo));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_DisplayName));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_Description));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_IconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_IconURL));
    PlayerAchievementInternal.NativeFieldInfoPtr_m_FlavorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, nameof (m_FlavorText));
    PlayerAchievementInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673540);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673541);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_Progress_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673542);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_Progress_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673543);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673544);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673545);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_StatInfo_Public_get_Il2CppReferenceArray_1_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673546);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673547);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673548);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673549);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673550);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673551);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_IconURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673552);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_IconURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673553);
    PlayerAchievementInternal.NativeMethodInfoPtr_get_FlavorText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673554);
    PlayerAchievementInternal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673555);
    PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Void_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673556);
    PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673557);
    PlayerAchievementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, 100673558);
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402708, XrefRangeEnd = 402712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402712, XrefRangeEnd = 402716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe double Progress
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_Progress_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_Progress_Public_set_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> UnlockTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402716, XrefRangeEnd = 402720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402720, XrefRangeEnd = 402724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<PlayerStatInfo> StatInfo
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402724, XrefRangeEnd = 402730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_StatInfo_Public_get_Il2CppReferenceArray_1_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<PlayerStatInfo>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerStatInfo>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 402736, RefRangeEnd = 402737, XrefRangeStart = 402730, XrefRangeEnd = 402736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_StatInfo_Public_set_Void_Il2CppReferenceArray_1_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402737, XrefRangeEnd = 402741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402741, XrefRangeEnd = 402745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Description
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402745, XrefRangeEnd = 402749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_Description_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402749, XrefRangeEnd = 402753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string IconURL
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402753, XrefRangeEnd = 402757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_IconURL_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402757, XrefRangeEnd = 402761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_IconURL_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string FlavorText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402761, XrefRangeEnd = 402765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_get_FlavorText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402765, XrefRangeEnd = 402769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 402794, RefRangeEnd = 402795, XrefRangeStart = 402769, XrefRangeEnd = 402794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PlayerAchievement other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Void_PlayerAchievement_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402795, XrefRangeEnd = 402798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402798, XrefRangeEnd = 402807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerAchievementInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerAchievementInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
