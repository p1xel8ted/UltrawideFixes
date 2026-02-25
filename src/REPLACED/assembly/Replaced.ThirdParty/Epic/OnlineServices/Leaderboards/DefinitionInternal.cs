// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.DefinitionInternal
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
public struct DefinitionInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LeaderboardId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Aggregation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EndTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Definition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LeaderboardId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_StatName;
  [FieldOffset(24)]
  public LeaderboardAggregation m_Aggregation;
  [FieldOffset(32 /*0x20*/)]
  public long m_StartTime;
  [FieldOffset(40)]
  public long m_EndTime;

  static DefinitionInternal()
  {
    Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (DefinitionInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr);
    DefinitionInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_ApiVersion));
    DefinitionInternal.NativeFieldInfoPtr_m_LeaderboardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_LeaderboardId));
    DefinitionInternal.NativeFieldInfoPtr_m_StatName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_StatName));
    DefinitionInternal.NativeFieldInfoPtr_m_Aggregation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_Aggregation));
    DefinitionInternal.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_StartTime));
    DefinitionInternal.NativeFieldInfoPtr_m_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_EndTime));
    DefinitionInternal.NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669945);
    DefinitionInternal.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669946);
    DefinitionInternal.NativeMethodInfoPtr_get_StatName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669947);
    DefinitionInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669948);
    DefinitionInternal.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669949);
    DefinitionInternal.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669950);
    DefinitionInternal.NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669951);
    DefinitionInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669952 /*0x06001A00*/);
    DefinitionInternal.NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669953);
    DefinitionInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669954);
    DefinitionInternal.NativeMethodInfoPtr_Set_Public_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669955);
    DefinitionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669956);
    DefinitionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100669957);
  }

  public unsafe string LeaderboardId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391683, XrefRangeEnd = 391687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391687, XrefRangeEnd = 391691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string StatName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391691, XrefRangeEnd = 391695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_StatName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391695, XrefRangeEnd = 391699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LeaderboardAggregation Aggregation
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LeaderboardAggregation*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> StartTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391699, XrefRangeEnd = 391703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391703, XrefRangeEnd = 391707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> EndTime
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391707, XrefRangeEnd = 391711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391711, XrefRangeEnd = 391715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 391731, RefRangeEnd = 391732, XrefRangeStart = 391715, XrefRangeEnd = 391731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Definition other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_Set_Public_Void_Definition_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391732, XrefRangeEnd = 391735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391735, XrefRangeEnd = 391740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
