// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.QueryDefinitionsOptionsInternal
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
public struct QueryDefinitionsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EpicUserId_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HiddenAchievementIds_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HiddenAchievementsCount_DEPRECATED;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EpicUserId_DEPRECATED_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HiddenAchievementIds_DEPRECATED_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryDefinitionsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_EpicUserId_DEPRECATED;
  [FieldOffset(24)]
  public System.IntPtr m_HiddenAchievementIds_DEPRECATED;
  [FieldOffset(32 /*0x20*/)]
  public uint m_HiddenAchievementsCount_DEPRECATED;

  static QueryDefinitionsOptionsInternal()
  {
    Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (QueryDefinitionsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr);
    QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_EpicUserId_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_EpicUserId_DEPRECATED));
    QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_HiddenAchievementIds_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_HiddenAchievementIds_DEPRECATED));
    QueryDefinitionsOptionsInternal.NativeFieldInfoPtr_m_HiddenAchievementsCount_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, nameof (m_HiddenAchievementsCount_DEPRECATED));
    QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100673584);
    QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_EpicUserId_DEPRECATED_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100673585);
    QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_HiddenAchievementIds_DEPRECATED_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100673586);
    QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryDefinitionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100673587);
    QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100673588);
    QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, 100673589);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402857, XrefRangeEnd = 402861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId EpicUserId_DEPRECATED
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402861, XrefRangeEnd = 402865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_EpicUserId_DEPRECATED_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray HiddenAchievementIds_DEPRECATED
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 402871, RefRangeEnd = 402872, XrefRangeStart = 402865, XrefRangeEnd = 402871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_set_HiddenAchievementIds_DEPRECATED_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 402881, RefRangeEnd = 402882, XrefRangeStart = 402872, XrefRangeEnd = 402881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryDefinitionsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryDefinitionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402882, XrefRangeEnd = 402885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402885, XrefRangeEnd = 402891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryDefinitionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryDefinitionsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
