// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.ParticipantStatusChangedCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTC;

[StructLayout(LayoutKind.Explicit)]
public struct ParticipantStatusChangedCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantMetadataCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantMetadata;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public System.IntPtr m_ParticipantId;
  [FieldOffset(32 /*0x20*/)]
  public RTCParticipantStatus m_ParticipantStatus;
  [FieldOffset(36)]
  public uint m_ParticipantMetadataCount;
  [FieldOffset(40)]
  public System.IntPtr m_ParticipantMetadata;

  static ParticipantStatusChangedCallbackInfoInternal()
  {
    Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTC", nameof (ParticipantStatusChangedCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr);
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantId));
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantStatus));
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantMetadataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantMetadataCount));
    ParticipantStatusChangedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantMetadata));
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667047);
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667048);
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667049);
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667050);
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667051);
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667052);
    ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, 100667053);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382461, XrefRangeEnd = 382465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382465, XrefRangeEnd = 382471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382471, XrefRangeEnd = 382475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ProductUserId ParticipantId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382475, XrefRangeEnd = 382481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe RTCParticipantStatus ParticipantStatus
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RTCParticipantStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata> ParticipantMetadata
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382481, XrefRangeEnd = 382487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
