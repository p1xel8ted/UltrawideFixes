// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationDeleteDataOptionsInternal
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
public struct PresenceModificationDeleteDataOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecordsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Records;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_PresenceModificationDataRecordId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PresenceModificationDeleteDataOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public int m_RecordsCount;
  [FieldOffset(8)]
  public System.IntPtr m_Records;

  static PresenceModificationDeleteDataOptionsInternal()
  {
    Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationDeleteDataOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr);
    PresenceModificationDeleteDataOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PresenceModificationDeleteDataOptionsInternal.NativeFieldInfoPtr_m_RecordsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, nameof (m_RecordsCount));
    PresenceModificationDeleteDataOptionsInternal.NativeFieldInfoPtr_m_Records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, nameof (m_Records));
    PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_PresenceModificationDataRecordId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, 100667425);
    PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_PresenceModificationDeleteDataOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, 100667426);
    PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, 100667427);
    PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, 100667428);
  }

  public unsafe Il2CppReferenceArray<PresenceModificationDataRecordId> Records
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 383764, RefRangeEnd = 383766, XrefRangeStart = 383758, XrefRangeEnd = 383764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_PresenceModificationDataRecordId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383766, XrefRangeEnd = 383767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PresenceModificationDeleteDataOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_PresenceModificationDeleteDataOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383767, XrefRangeEnd = 383770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383770, XrefRangeEnd = 383774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationDeleteDataOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresenceModificationDeleteDataOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
