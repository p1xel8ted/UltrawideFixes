// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.IngestStatOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats;

[StructLayout(LayoutKind.Explicit)]
public struct IngestStatOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Stats;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Stats_Public_set_Void_Il2CppReferenceArray_1_IngestData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_IngestStatOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Stats;
  [FieldOffset(24)]
  public uint m_StatsCount;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_TargetUserId;

  static IngestStatOptionsInternal()
  {
    Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Stats", nameof (IngestStatOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr);
    IngestStatOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    IngestStatOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    IngestStatOptionsInternal.NativeFieldInfoPtr_m_Stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_Stats));
    IngestStatOptionsInternal.NativeFieldInfoPtr_m_StatsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_StatsCount));
    IngestStatOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    IngestStatOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665176);
    IngestStatOptionsInternal.NativeMethodInfoPtr_set_Stats_Public_set_Void_Il2CppReferenceArray_1_IngestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665177);
    IngestStatOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665178);
    IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_IngestStatOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665179);
    IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665180);
    IngestStatOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, 100665181);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376121, XrefRangeEnd = 376127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<IngestData> Stats
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 376133, RefRangeEnd = 376134, XrefRangeStart = 376127, XrefRangeEnd = 376133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_set_Stats_Public_set_Void_Il2CppReferenceArray_1_IngestData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376134, XrefRangeEnd = 376140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 376153, RefRangeEnd = 376154, XrefRangeStart = 376140, XrefRangeEnd = 376153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(IngestStatOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_IngestStatOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376154, XrefRangeEnd = 376157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376157, XrefRangeEnd = 376172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IngestStatOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IngestStatOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
