// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CustomInvites.CustomInvitesInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.CustomInvites;

public sealed class CustomInvitesInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_FinalizeinviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxPayloadLength;
  private static readonly System.IntPtr NativeFieldInfoPtr_SendcustominviteApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_SetcustominviteApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyCustomInviteAccepted_Public_UInt64_AddNotifyCustomInviteAcceptedOptions_Object_OnCustomInviteAcceptedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyCustomInviteReceived_Public_UInt64_AddNotifyCustomInviteReceivedOptions_Object_OnCustomInviteReceivedCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeInvite_Public_Result_FinalizeInviteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyCustomInviteAccepted_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyCustomInviteReceived_Public_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendCustomInvite_Public_Void_SendCustomInviteOptions_Object_OnSendCustomInviteCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomInvite_Public_Result_SetCustomInviteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCustomInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCustomInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSendCustomInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static CustomInvitesInterface()
  {
    Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.CustomInvites", nameof (CustomInvitesInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr);
    CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (AddnotifycustominviteacceptedApiLatest));
    CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (AddnotifycustominvitereceivedApiLatest));
    CustomInvitesInterface.NativeFieldInfoPtr_FinalizeinviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (FinalizeinviteApiLatest));
    CustomInvitesInterface.NativeFieldInfoPtr_MaxPayloadLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (MaxPayloadLength));
    CustomInvitesInterface.NativeFieldInfoPtr_SendcustominviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (SendcustominviteApiLatest));
    CustomInvitesInterface.NativeFieldInfoPtr_SetcustominviteApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, nameof (SetcustominviteApiLatest));
    CustomInvitesInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671302);
    CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteAccepted_Public_UInt64_AddNotifyCustomInviteAcceptedOptions_Object_OnCustomInviteAcceptedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671304);
    CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteReceived_Public_UInt64_AddNotifyCustomInviteReceivedOptions_Object_OnCustomInviteReceivedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671305);
    CustomInvitesInterface.NativeMethodInfoPtr_FinalizeInvite_Public_Result_FinalizeInviteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671306);
    CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteAccepted_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671307);
    CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteReceived_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671308);
    CustomInvitesInterface.NativeMethodInfoPtr_SendCustomInvite_Public_Void_SendCustomInviteOptions_Object_OnSendCustomInviteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671309);
    CustomInvitesInterface.NativeMethodInfoPtr_SetCustomInvite_Public_Result_SetCustomInviteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671310);
    CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671311);
    CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671312);
    CustomInvitesInterface.NativeMethodInfoPtr_OnSendCustomInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr, 100671313);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomInvitesInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomInvitesInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395902, XrefRangeEnd = 395922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyCustomInviteAccepted(
    AddNotifyCustomInviteAcceptedOptions options,
    Il2CppSystem.Object clientData,
    OnCustomInviteAcceptedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteAccepted_Public_UInt64_AddNotifyCustomInviteAcceptedOptions_Object_OnCustomInviteAcceptedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395922, XrefRangeEnd = 395942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ulong AddNotifyCustomInviteReceived(
    AddNotifyCustomInviteReceivedOptions options,
    Il2CppSystem.Object clientData,
    OnCustomInviteReceivedCallback notificationFn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_AddNotifyCustomInviteReceived_Public_UInt64_AddNotifyCustomInviteReceivedOptions_Object_OnCustomInviteReceivedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395942, XrefRangeEnd = 395950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result FinalizeInvite(FinalizeInviteOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_FinalizeInvite_Public_Result_FinalizeInviteOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395950, XrefRangeEnd = 395955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyCustomInviteAccepted(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteAccepted_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395955, XrefRangeEnd = 395960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveNotifyCustomInviteReceived(ulong inId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_RemoveNotifyCustomInviteReceived_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395960, XrefRangeEnd = 395979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendCustomInvite(
    SendCustomInviteOptions options,
    Il2CppSystem.Object clientData,
    OnSendCustomInviteCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_SendCustomInvite_Public_Void_SendCustomInviteOptions_Object_OnSendCustomInviteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395979, XrefRangeEnd = 395987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result SetCustomInvite(SetCustomInviteOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_SetCustomInvite_Public_Result_SetCustomInviteOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395987, XrefRangeEnd = 395993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCustomInviteAcceptedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteAcceptedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395993, XrefRangeEnd = 395999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnCustomInviteReceivedCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnCustomInviteReceivedCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395999, XrefRangeEnd = 396005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSendCustomInviteCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomInvitesInterface.NativeMethodInfoPtr_OnSendCustomInviteCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddnotifycustominviteacceptedApiLatest
  {
    get
    {
      int addnotifycustominviteacceptedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest, (void*) &addnotifycustominviteacceptedApiLatest);
      return addnotifycustominviteacceptedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominviteacceptedApiLatest, (void*) &value);
    }
  }

  public static unsafe int AddnotifycustominvitereceivedApiLatest
  {
    get
    {
      int addnotifycustominvitereceivedApiLatest;
      IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest, (void*) &addnotifycustominvitereceivedApiLatest);
      return addnotifycustominvitereceivedApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_AddnotifycustominvitereceivedApiLatest, (void*) &value);
    }
  }

  public static unsafe int FinalizeinviteApiLatest
  {
    get
    {
      int finalizeinviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_FinalizeinviteApiLatest, (void*) &finalizeinviteApiLatest);
      return finalizeinviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_FinalizeinviteApiLatest, (void*) &value);
    }
  }

  public static unsafe int MaxPayloadLength
  {
    get
    {
      int maxPayloadLength;
      IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_MaxPayloadLength, (void*) &maxPayloadLength);
      return maxPayloadLength;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_MaxPayloadLength, (void*) &value);
    }
  }

  public static unsafe int SendcustominviteApiLatest
  {
    get
    {
      int sendcustominviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_SendcustominviteApiLatest, (void*) &sendcustominviteApiLatest);
      return sendcustominviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_SendcustominviteApiLatest, (void*) &value);
    }
  }

  public static unsafe int SetcustominviteApiLatest
  {
    get
    {
      int setcustominviteApiLatest;
      IL2CPP.il2cpp_field_static_get_value(CustomInvitesInterface.NativeFieldInfoPtr_SetcustominviteApiLatest, (void*) &setcustominviteApiLatest);
      return setcustominviteApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomInvitesInterface.NativeFieldInfoPtr_SetcustominviteApiLatest, (void*) &value);
    }
  }
}
