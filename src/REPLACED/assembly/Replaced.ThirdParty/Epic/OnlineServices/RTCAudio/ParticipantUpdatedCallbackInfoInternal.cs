// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.ParticipantUpdatedCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

[StructLayout(LayoutKind.Explicit)]
public struct ParticipantUpdatedCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Speaking;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AudioStatus;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Speaking_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioStatus_Public_get_RTCAudioStatus_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public System.IntPtr m_ParticipantId;
  [FieldOffset(32 /*0x20*/)]
  public int m_Speaking;
  [FieldOffset(36)]
  public RTCAudioStatus m_AudioStatus;

  static ParticipantUpdatedCallbackInfoInternal()
  {
    Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (ParticipantUpdatedCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr);
    ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
    ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantId));
    ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_Speaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_Speaking));
    ParticipantUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_AudioStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_AudioStatus));
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666509);
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666510);
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666511);
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666512 /*0x06000C90*/);
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666513);
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_Speaking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666514);
    ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_AudioStatus_Public_get_RTCAudioStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, 100666515);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380786, XrefRangeEnd = 380790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380790, XrefRangeEnd = 380796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380796, XrefRangeEnd = 380800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ProductUserId ParticipantId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380800, XrefRangeEnd = 380806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe bool Speaking
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380806, XrefRangeEnd = 380810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_Speaking_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe RTCAudioStatus AudioStatus
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_AudioStatus_Public_get_RTCAudioStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RTCAudioStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticipantUpdatedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
