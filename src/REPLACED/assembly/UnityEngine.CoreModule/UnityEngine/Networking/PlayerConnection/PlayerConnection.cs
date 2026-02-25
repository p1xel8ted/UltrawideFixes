// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.PlayerConnection.PlayerConnection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;

#nullable disable
namespace UnityEngine.Networking.PlayerConnection;

[Serializable]
public class PlayerConnection(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_connectionNative;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayerEditorConnectionEvents;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_connectedPlayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsInitilized;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerConnection()
  {
    Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", nameof (PlayerConnection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_connectionNative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, nameof (connectionNative));
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, nameof (m_PlayerEditorConnectionEvents));
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, nameof (m_connectedPlayers));
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_IsInitilized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, nameof (m_IsInitilized));
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, nameof (s_Instance));
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669312);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669313);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669314);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669315);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669316);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669317);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669318);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669319);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669320);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669321);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669322);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669323);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669324);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669325);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669326);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669327);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669328);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669329);
    UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, 100669330);
  }

  public static unsafe UnityEngine.Networking.PlayerConnection.PlayerConnection instance
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 479482, RefRangeEnd = 479487, XrefRangeStart = 479468, XrefRangeEnd = 479482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_get_instance_Public_Static_get_PlayerConnection_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityEngine.Networking.PlayerConnection.PlayerConnection) null : Il2CppObjectPool.Get<UnityEngine.Networking.PlayerConnection.PlayerConnection>(num3);
    }
  }

  public unsafe bool isConnected
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479487, XrefRangeEnd = 479497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_get_isConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479497, XrefRangeEnd = 479505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_CreateInstance_Private_Static_PlayerConnection_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityEngine.Networking.PlayerConnection.PlayerConnection) null : Il2CppObjectPool.Get<UnityEngine.Networking.PlayerConnection.PlayerConnection>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479505, XrefRangeEnd = 479509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 479515, RefRangeEnd = 479518, XrefRangeStart = 479509, XrefRangeEnd = 479515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPlayerEditorConnectionNative GetConnectionNativeApi()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_GetConnectionNativeApi_Private_IPlayerEditorConnectionNative_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPlayerEditorConnectionNative) null : Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479551, RefRangeEnd = 479552, XrefRangeStart = 479518, XrefRangeEnd = 479551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Register(Il2CppSystem.Guid messageId, UnityAction<MessageEventArgs> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_Register_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479582, RefRangeEnd = 479583, XrefRangeStart = 479552, XrefRangeEnd = 479582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Unregister(Il2CppSystem.Guid messageId, UnityAction<MessageEventArgs> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_Unregister_Public_Virtual_Final_New_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479583, XrefRangeEnd = 479600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RegisterConnection(UnityAction<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_RegisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479600, XrefRangeEnd = 479604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RegisterDisconnection(UnityAction<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_RegisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479604, XrefRangeEnd = 479608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnregisterConnection(UnityAction<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_UnregisterConnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479608, XrefRangeEnd = 479612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnregisterDisconnection(UnityAction<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_UnregisterDisconnection_Public_Virtual_Final_New_Void_UnityAction_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479612, XrefRangeEnd = 479624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Send(Il2CppSystem.Guid messageId, Il2CppStructArray<byte> data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_Send_Public_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479624, XrefRangeEnd = 479636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool TrySend(Il2CppSystem.Guid messageId, Il2CppStructArray<byte> data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_TrySend_Public_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479636, XrefRangeEnd = 479671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool BlockUntilRecvMsg(Il2CppSystem.Guid messageId, int timeout)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &timeout;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_BlockUntilRecvMsg_Public_Boolean_Guid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479671, XrefRangeEnd = 479681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void DisconnectAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_DisconnectAll_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479681, XrefRangeEnd = 479704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MessageCallbackInternal(
    System.IntPtr data,
    ulong size,
    ulong guid,
    string messageId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &guid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(messageId);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_MessageCallbackInternal_Private_Static_Void_IntPtr_UInt64_UInt64_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479704, XrefRangeEnd = 479715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ConnectedCallbackInternal(int playerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_ConnectedCallbackInternal_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479715, XrefRangeEnd = 479724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DisconnectedCallback(int playerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playerId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr_DisconnectedCallback_Private_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479724, XrefRangeEnd = 479752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerConnection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe IPlayerEditorConnectionNative connectionNative
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_connectionNative, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (IPlayerEditorConnectionNative) null : Il2CppObjectPool.Get<IPlayerEditorConnectionNative>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_connectionNative, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents));
      return num == System.IntPtr.Zero ? (PlayerEditorConnectionEvents) null : Il2CppObjectPool.Get<PlayerEditorConnectionEvents>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_PlayerEditorConnectionEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<int> m_connectedPlayers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers));
      return num == System.IntPtr.Zero ? (List<int>) null : Il2CppObjectPool.Get<List<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_connectedPlayers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_IsInitilized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_IsInitilized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_m_IsInitilized)) = value;
    }
  }

  public static unsafe UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_s_Instance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (UnityEngine.Networking.PlayerConnection.PlayerConnection) null : Il2CppObjectPool.Get<UnityEngine.Networking.PlayerConnection.PlayerConnection>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityEngine.Networking.PlayerConnection.PlayerConnection.NativeFieldInfoPtr_s_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass12_0")]
  public sealed class __c__DisplayClass12_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_messageId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0;

    static __c__DisplayClass12_0()
    {
      Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, "<>c__DisplayClass12_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, nameof (messageId));
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100669331);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr, 100669332);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass12_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479466, XrefRangeEnd = 479468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Register_b__0(
      PlayerEditorConnectionEvents.MessageTypeSubscribers x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeMethodInfoPtr__Register_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Il2CppSystem.Guid messageId
    {
      get
      {
        return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId));
      }
      [param: In] set
      {
        *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass12_0.NativeFieldInfoPtr_messageId)) = value;
      }
    }
  }

  [ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass13_0")]
  public sealed class __c__DisplayClass13_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_messageId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0;

    static __c__DisplayClass13_0()
    {
      Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, "<>c__DisplayClass13_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, nameof (messageId));
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100669333);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr, 100669334);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass13_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Unregister_b__0(
      PlayerEditorConnectionEvents.MessageTypeSubscribers x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeMethodInfoPtr__Unregister_b__0_Internal_Boolean_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Il2CppSystem.Guid messageId
    {
      get
      {
        return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId));
      }
      [param: In] set
      {
        *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass13_0.NativeFieldInfoPtr_messageId)) = value;
      }
    }
  }

  [ObfuscatedName("UnityEngine.Networking.PlayerConnection.PlayerConnection+<>c__DisplayClass20_0")]
  public sealed class __c__DisplayClass20_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_msgReceived;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0;

    static __c__DisplayClass20_0()
    {
      Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection>.NativeClassPtr, "<>c__DisplayClass20_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, nameof (msgReceived));
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100669335);
      UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr, 100669336);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 93981, RefRangeEnd = 93983, XrefRangeStart = 93981, XrefRangeEnd = 93983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _BlockUntilRecvMsg_b__0(MessageEventArgs args)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeMethodInfoPtr__BlockUntilRecvMsg_b__0_Internal_Void_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool msgReceived
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEngine.Networking.PlayerConnection.PlayerConnection.__c__DisplayClass20_0.NativeFieldInfoPtr_msgReceived)) = value;
      }
    }
  }

  public sealed class \u003C\u003Ec__DisplayClass12_0
  {
  }

  public sealed class \u003C\u003Ec__DisplayClass13_0
  {
  }

  public sealed class \u003C\u003Ec__DisplayClass20_0
  {
  }
}
