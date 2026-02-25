// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.CopyPlayerAchievementByAchievementIdOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct CopyPlayerAchievementByAchievementIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyPlayerAchievementByAchievementIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_AchievementId;
  [FieldOffset(24)]
  public System.IntPtr m_LocalUserId;

  static CopyPlayerAchievementByAchievementIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (CopyPlayerAchievementByAchievementIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr);
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_AchievementId));
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, 100673255);
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, 100673256);
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, 100673257);
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyPlayerAchievementByAchievementIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, 100673258);
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, 100673259);
    CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, 100673260);
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401792, XrefRangeEnd = 401796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401796, XrefRangeEnd = 401800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401800, XrefRangeEnd = 401804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 401816, RefRangeEnd = 401817, XrefRangeStart = 401804, XrefRangeEnd = 401816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CopyPlayerAchievementByAchievementIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyPlayerAchievementByAchievementIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401817, XrefRangeEnd = 401820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401820, XrefRangeEnd = 401826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyPlayerAchievementByAchievementIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyPlayerAchievementByAchievementIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
