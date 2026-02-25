// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationSetDataOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

[StructLayout(LayoutKind.Explicit)]
public struct PresenceModificationSetDataOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecordsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Records;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PresenceModificationSetDataOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public int m_RecordsCount;
  [FieldOffset(8)]
  public System.IntPtr m_Records;

  static PresenceModificationSetDataOptionsInternal()
  {
    Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationSetDataOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr);
    PresenceModificationSetDataOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PresenceModificationSetDataOptionsInternal.NativeFieldInfoPtr_m_RecordsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, nameof (m_RecordsCount));
    PresenceModificationSetDataOptionsInternal.NativeFieldInfoPtr_m_Records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, nameof (m_Records));
    PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, 100667432);
    PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_PresenceModificationSetDataOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, 100667433);
    PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, 100667434);
    PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, 100667435);
  }

  public unsafe Il2CppReferenceArray<DataRecord> Records
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 383780, RefRangeEnd = 383782, XrefRangeStart = 383774, XrefRangeEnd = 383780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383782, XrefRangeEnd = 383783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PresenceModificationSetDataOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_PresenceModificationSetDataOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383783, XrefRangeEnd = 383786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383786, XrefRangeEnd = 383790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresenceModificationSetDataOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
