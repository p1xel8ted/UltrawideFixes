// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.UpdateReceivingCallbackInfoInternal
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
public struct UpdateReceivingCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticipantId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AudioEnabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioEnabled_Public_get_Boolean_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(24)]
  public System.IntPtr m_RoomName;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ParticipantId;
  [FieldOffset(40)]
  public int m_AudioEnabled;

  static UpdateReceivingCallbackInfoInternal()
  {
    Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (UpdateReceivingCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr);
    UpdateReceivingCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    UpdateReceivingCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    UpdateReceivingCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    UpdateReceivingCallbackInfoInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, nameof (m_RoomName));
    UpdateReceivingCallbackInfoInternal.NativeFieldInfoPtr_m_ParticipantId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, nameof (m_ParticipantId));
    UpdateReceivingCallbackInfoInternal.NativeFieldInfoPtr_m_AudioEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, nameof (m_AudioEnabled));
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666621);
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666622);
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666623);
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666624 /*0x06000D00*/);
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666625 /*0x06000D01*/);
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666626 /*0x06000D02*/);
    UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_AudioEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, 100666627 /*0x06000D03*/);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381299, XrefRangeEnd = 381303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381303, XrefRangeEnd = 381309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381309, XrefRangeEnd = 381313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_RoomName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ProductUserId ParticipantId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381313, XrefRangeEnd = 381319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe bool AudioEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381319, XrefRangeEnd = 381323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateReceivingCallbackInfoInternal.NativeMethodInfoPtr_get_AudioEnabled_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateReceivingCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
