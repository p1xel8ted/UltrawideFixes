// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.GraphyDebugger
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Tayx.Graphy.Audio;
using Tayx.Graphy.Fps;
using Tayx.Graphy.Ram;
using Tayx.Graphy.Utils;
using UnityEngine.Events;

#nullable disable
namespace Tayx.Graphy;

public class GraphyDebugger(System.IntPtr pointer) : G_Singleton<GraphyDebugger>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_debugPackets;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_fpsMonitor;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ramMonitor;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_audioMonitor;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_DebugPacket_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_List_1_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_List_1_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstDebugPacketWithId_Public_DebugPacket_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllDebugPacketsWithId_Public_List_1_DebugPacket_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFirstDebugPacketWithId_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllDebugPacketsWithId_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCallbackToFirstDebugPacketWithId_Public_Void_Action_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCallbackToAllDebugPacketWithId_Public_Void_Action_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckDebugPackets_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckIfConditionIsMet_Private_Boolean_DebugCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRequestedValueFromDebugVariable_Private_Single_DebugVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteOperationsInDebugPacket_Private_Void_DebugPacket_0;

  static GraphyDebugger()
  {
    Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy", nameof (GraphyDebugger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr);
    GraphyDebugger.NativeFieldInfoPtr_m_debugPackets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, nameof (m_debugPackets));
    GraphyDebugger.NativeFieldInfoPtr_m_fpsMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, nameof (m_fpsMonitor));
    GraphyDebugger.NativeFieldInfoPtr_m_ramMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, nameof (m_ramMonitor));
    GraphyDebugger.NativeFieldInfoPtr_m_audioMonitor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, nameof (m_audioMonitor));
    GraphyDebugger.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663398 /*0x06000066*/);
    GraphyDebugger.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663399 /*0x06000067*/);
    GraphyDebugger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663400 /*0x06000068*/);
    GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663401 /*0x06000069*/);
    GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663402 /*0x0600006A*/);
    GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663403 /*0x0600006B*/);
    GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663404 /*0x0600006C*/);
    GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_List_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663405 /*0x0600006D*/);
    GraphyDebugger.NativeMethodInfoPtr_GetFirstDebugPacketWithId_Public_DebugPacket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663406 /*0x0600006E*/);
    GraphyDebugger.NativeMethodInfoPtr_GetAllDebugPacketsWithId_Public_List_1_DebugPacket_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663407 /*0x0600006F*/);
    GraphyDebugger.NativeMethodInfoPtr_RemoveFirstDebugPacketWithId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663408 /*0x06000070*/);
    GraphyDebugger.NativeMethodInfoPtr_RemoveAllDebugPacketsWithId_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663409 /*0x06000071*/);
    GraphyDebugger.NativeMethodInfoPtr_AddCallbackToFirstDebugPacketWithId_Public_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663410 /*0x06000072*/);
    GraphyDebugger.NativeMethodInfoPtr_AddCallbackToAllDebugPacketWithId_Public_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663411 /*0x06000073*/);
    GraphyDebugger.NativeMethodInfoPtr_CheckDebugPackets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663412 /*0x06000074*/);
    GraphyDebugger.NativeMethodInfoPtr_CheckIfConditionIsMet_Private_Boolean_DebugCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663413 /*0x06000075*/);
    GraphyDebugger.NativeMethodInfoPtr_GetRequestedValueFromDebugVariable_Private_Single_DebugVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663414 /*0x06000076*/);
    GraphyDebugger.NativeMethodInfoPtr_ExecuteOperationsInDebugPacket_Private_Void_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, 100663415 /*0x06000077*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361004, XrefRangeEnd = 361016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphyDebugger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361016, XrefRangeEnd = 361025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361025, XrefRangeEnd = 361026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 361029, RefRangeEnd = 361033, XrefRangeStart = 361026, XrefRangeEnd = 361029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNewDebugPacket(GraphyDebugger.DebugPacket newDebugPacket)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newDebugPacket)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361033, XrefRangeEnd = 361048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNewDebugPacket(
    int newId,
    GraphyDebugger.DebugCondition newDebugCondition,
    GraphyDebugger.MessageType newMessageType,
    string newMessage,
    bool newDebugBreak,
    Il2CppSystem.Action newCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &newId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newDebugCondition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newMessageType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newDebugBreak;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361048, XrefRangeEnd = 361059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNewDebugPacket(
    int newId,
    List<GraphyDebugger.DebugCondition> newDebugConditions,
    GraphyDebugger.MessageType newMessageType,
    string newMessage,
    bool newDebugBreak,
    Il2CppSystem.Action newCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &newId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newDebugConditions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newMessageType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newDebugBreak;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361059, XrefRangeEnd = 361070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNewDebugPacket(
    int newId,
    GraphyDebugger.DebugCondition newDebugCondition,
    GraphyDebugger.MessageType newMessageType,
    string newMessage,
    bool newDebugBreak,
    List<Il2CppSystem.Action> newCallbacks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &newId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newDebugCondition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newMessageType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newDebugBreak;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newCallbacks);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_DebugCondition_MessageType_String_Boolean_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361070, XrefRangeEnd = 361076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNewDebugPacket(
    int newId,
    List<GraphyDebugger.DebugCondition> newDebugConditions,
    GraphyDebugger.MessageType newMessageType,
    string newMessage,
    bool newDebugBreak,
    List<Il2CppSystem.Action> newCallbacks)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &newId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newDebugConditions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newMessageType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(newMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &newDebugBreak;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newCallbacks);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddNewDebugPacket_Public_Void_Int32_List_1_DebugCondition_MessageType_String_Boolean_List_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 361090, RefRangeEnd = 361094, XrefRangeStart = 361076, XrefRangeEnd = 361090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GraphyDebugger.DebugPacket GetFirstDebugPacketWithId(int packetId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &packetId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_GetFirstDebugPacketWithId_Public_DebugPacket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GraphyDebugger.DebugPacket) null : Il2CppObjectPool.Get<GraphyDebugger.DebugPacket>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 361108, RefRangeEnd = 361110, XrefRangeStart = 361094, XrefRangeEnd = 361108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<GraphyDebugger.DebugPacket> GetAllDebugPacketsWithId(int packetId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &packetId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_GetAllDebugPacketsWithId_Public_List_1_DebugPacket_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<GraphyDebugger.DebugPacket>) null : Il2CppObjectPool.Get<List<GraphyDebugger.DebugPacket>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361110, XrefRangeEnd = 361115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveFirstDebugPacketWithId(int packetId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &packetId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_RemoveFirstDebugPacketWithId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361115, XrefRangeEnd = 361128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveAllDebugPacketsWithId(int packetId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &packetId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_RemoveAllDebugPacketsWithId_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361128, XrefRangeEnd = 361133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCallbackToFirstDebugPacketWithId(Il2CppSystem.Action callback, int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddCallbackToFirstDebugPacketWithId_Public_Void_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361133, XrefRangeEnd = 361152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddCallbackToAllDebugPacketWithId(Il2CppSystem.Action callback, int id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_AddCallbackToAllDebugPacketWithId_Public_Void_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361211, RefRangeEnd = 361212, XrefRangeStart = 361152, XrefRangeEnd = 361211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckDebugPackets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_CheckDebugPackets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 361212, RefRangeEnd = 361214, XrefRangeStart = 361212, XrefRangeEnd = 361212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckIfConditionIsMet(GraphyDebugger.DebugCondition debugCondition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &debugCondition
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_CheckIfConditionIsMet_Private_Boolean_DebugCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361214, XrefRangeEnd = 361218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetRequestedValueFromDebugVariable(GraphyDebugger.DebugVariable debugVariable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &debugVariable
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_GetRequestedValueFromDebugVariable_Private_Single_DebugVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 361284, RefRangeEnd = 361286, XrefRangeStart = 361218, XrefRangeEnd = 361284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExecuteOperationsInDebugPacket(GraphyDebugger.DebugPacket debugPacket)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) debugPacket)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.NativeMethodInfoPtr_ExecuteOperationsInDebugPacket_Private_Void_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<GraphyDebugger.DebugPacket> m_debugPackets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_debugPackets));
      return num == System.IntPtr.Zero ? (List<GraphyDebugger.DebugPacket>) null : Il2CppObjectPool.Get<List<GraphyDebugger.DebugPacket>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_debugPackets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_FpsMonitor m_fpsMonitor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_fpsMonitor));
      return num == System.IntPtr.Zero ? (G_FpsMonitor) null : Il2CppObjectPool.Get<G_FpsMonitor>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_fpsMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_RamMonitor m_ramMonitor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_ramMonitor));
      return num == System.IntPtr.Zero ? (G_RamMonitor) null : Il2CppObjectPool.Get<G_RamMonitor>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_ramMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe G_AudioMonitor m_audioMonitor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_audioMonitor));
      return num == System.IntPtr.Zero ? (G_AudioMonitor) null : Il2CppObjectPool.Get<G_AudioMonitor>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.NativeFieldInfoPtr_m_audioMonitor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum DebugVariable
  {
    Fps,
    Fps_Min,
    Fps_Max,
    Fps_Avg,
    Ram_Allocated,
    Ram_Reserved,
    Ram_Mono,
    Audio_DB,
  }

  public enum DebugComparer
  {
    Less_than,
    Equals_or_less_than,
    Equals,
    Equals_or_greater_than,
    Greater_than,
  }

  public enum ConditionEvaluation
  {
    All_conditions_must_be_met,
    Only_one_condition_has_to_be_met,
  }

  public enum MessageType
  {
    Log,
    Warning,
    Error,
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct DebugCondition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Variable;
    private static readonly System.IntPtr NativeFieldInfoPtr_Comparer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    [FieldOffset(0)]
    public GraphyDebugger.DebugVariable Variable;
    [FieldOffset(4)]
    public GraphyDebugger.DebugComparer Comparer;
    [FieldOffset(8)]
    public float Value;

    static DebugCondition()
    {
      Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, nameof (DebugCondition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr);
      GraphyDebugger.DebugCondition.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, nameof (Variable));
      GraphyDebugger.DebugCondition.NativeFieldInfoPtr_Comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, nameof (Comparer));
      GraphyDebugger.DebugCondition.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, nameof (Value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GraphyDebugger.DebugCondition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  public class DebugPacket(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Active;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExecuteOnce;
    private static readonly System.IntPtr NativeFieldInfoPtr_InitSleepTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExecuteSleepTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionEvaluation;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugConditions;
    private static readonly System.IntPtr NativeFieldInfoPtr_MessageType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Message;
    private static readonly System.IntPtr NativeFieldInfoPtr_TakeScreenshot;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScreenshotFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_DebugBreak;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnityEvents;
    private static readonly System.IntPtr NativeFieldInfoPtr_Callbacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_canBeChecked;
    private static readonly System.IntPtr NativeFieldInfoPtr_executed;
    private static readonly System.IntPtr NativeFieldInfoPtr_timePassed;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Check_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Executed_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DebugPacket()
    {
      Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, nameof (DebugPacket));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr);
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (Active));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (Id));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (ExecuteOnce));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_InitSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (InitSleepTime));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (ExecuteSleepTime));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ConditionEvaluation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (ConditionEvaluation));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (DebugConditions));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_MessageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (MessageType));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (Message));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_TakeScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (TakeScreenshot));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ScreenshotFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (ScreenshotFileName));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (DebugBreak));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_UnityEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (UnityEvents));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (Callbacks));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_canBeChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (canBeChecked));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_executed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (executed));
      GraphyDebugger.DebugPacket.NativeFieldInfoPtr_timePassed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, nameof (timePassed));
      GraphyDebugger.DebugPacket.NativeMethodInfoPtr_get_Check_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100663416 /*0x06000078*/);
      GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100663417 /*0x06000079*/);
      GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Executed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100663418 /*0x0600007A*/);
      GraphyDebugger.DebugPacket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr, 100663419 /*0x0600007B*/);
    }

    public unsafe bool Check
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr_get_Check_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 360983, RefRangeEnd = 360984, XrefRangeStart = 360982, XrefRangeEnd = 360983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void Executed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr_Executed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 361000, RefRangeEnd = 361004, XrefRangeStart = 360984, XrefRangeEnd = 361000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugPacket()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.DebugPacket>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.DebugPacket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool Active
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Active));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Active)) = value;
      }
    }

    public unsafe int Id
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Id));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Id)) = value;
      }
    }

    public unsafe bool ExecuteOnce
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteOnce));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteOnce)) = value;
      }
    }

    public unsafe float InitSleepTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_InitSleepTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_InitSleepTime)) = value;
      }
    }

    public unsafe float ExecuteSleepTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteSleepTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ExecuteSleepTime)) = value;
      }
    }

    public unsafe GraphyDebugger.ConditionEvaluation ConditionEvaluation
    {
      get
      {
        return *(GraphyDebugger.ConditionEvaluation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ConditionEvaluation));
      }
      [param: In] set
      {
        *(GraphyDebugger.ConditionEvaluation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ConditionEvaluation)) = value;
      }
    }

    public unsafe List<GraphyDebugger.DebugCondition> DebugConditions
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugConditions));
        return num == System.IntPtr.Zero ? (List<GraphyDebugger.DebugCondition>) null : Il2CppObjectPool.Get<List<GraphyDebugger.DebugCondition>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugConditions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GraphyDebugger.MessageType MessageType
    {
      get
      {
        return *(GraphyDebugger.MessageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_MessageType));
      }
      [param: In] set
      {
        *(GraphyDebugger.MessageType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_MessageType)) = value;
      }
    }

    public unsafe string Message
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Message)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool TakeScreenshot
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_TakeScreenshot));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_TakeScreenshot)) = value;
      }
    }

    public unsafe string ScreenshotFileName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ScreenshotFileName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_ScreenshotFileName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool DebugBreak
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugBreak));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_DebugBreak)) = value;
      }
    }

    public unsafe UnityEvent UnityEvents
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_UnityEvents));
        return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_UnityEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Il2CppSystem.Action> Callbacks
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Callbacks));
        return num == System.IntPtr.Zero ? (List<Il2CppSystem.Action>) null : Il2CppObjectPool.Get<List<Il2CppSystem.Action>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_Callbacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool canBeChecked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_canBeChecked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_canBeChecked)) = value;
      }
    }

    public unsafe bool executed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_executed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_executed)) = value;
      }
    }

    public unsafe float timePassed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_timePassed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.DebugPacket.NativeFieldInfoPtr_timePassed)) = value;
      }
    }
  }

  [ObfuscatedName("Tayx.Graphy.GraphyDebugger+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__CheckDebugPackets_b__24_0_Internal_Boolean_DebugPacket_0;

    static __c()
    {
      Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr);
      GraphyDebugger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, "<>9");
      GraphyDebugger.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, "<>9__24_0");
      GraphyDebugger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, 100663421 /*0x0600007D*/);
      GraphyDebugger.__c.NativeMethodInfoPtr__CheckDebugPackets_b__24_0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr, 100663422 /*0x0600007E*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _CheckDebugPackets_b__24_0(GraphyDebugger.DebugPacket packet)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) packet)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c.NativeMethodInfoPtr__CheckDebugPackets_b__24_0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe GraphyDebugger.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GraphyDebugger.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GraphyDebugger.__c) null : Il2CppObjectPool.Get<GraphyDebugger.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphyDebugger.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Predicate<GraphyDebugger.DebugPacket> __9__24_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GraphyDebugger.__c.NativeFieldInfoPtr___9__24_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Predicate<GraphyDebugger.DebugPacket>) null : Il2CppObjectPool.Get<Il2CppSystem.Predicate<GraphyDebugger.DebugPacket>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphyDebugger.__c.NativeFieldInfoPtr___9__24_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Tayx.Graphy.GraphyDebugger+<>c__DisplayClass18_0")]
  public sealed class __c__DisplayClass18_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_packetId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetFirstDebugPacketWithId_b__0_Internal_Boolean_DebugPacket_0;

    static __c__DisplayClass18_0()
    {
      Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c__DisplayClass18_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr);
      GraphyDebugger.__c__DisplayClass18_0.NativeFieldInfoPtr_packetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr, nameof (packetId));
      GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr, 100663423 /*0x0600007F*/);
      GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__GetFirstDebugPacketWithId_b__0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr, 100663424 /*0x06000080*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass18_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass18_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _GetFirstDebugPacketWithId_b__0(GraphyDebugger.DebugPacket x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass18_0.NativeMethodInfoPtr__GetFirstDebugPacketWithId_b__0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe int packetId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass18_0.NativeFieldInfoPtr_packetId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass18_0.NativeFieldInfoPtr_packetId)) = value;
      }
    }
  }

  [ObfuscatedName("Tayx.Graphy.GraphyDebugger+<>c__DisplayClass19_0")]
  public sealed class __c__DisplayClass19_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_packetId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0;

    static __c__DisplayClass19_0()
    {
      Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c__DisplayClass19_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr);
      GraphyDebugger.__c__DisplayClass19_0.NativeFieldInfoPtr_packetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr, nameof (packetId));
      GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr, 100663425 /*0x06000081*/);
      GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__GetAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr, 100663426 /*0x06000082*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass19_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass19_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _GetAllDebugPacketsWithId_b__0(GraphyDebugger.DebugPacket x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass19_0.NativeMethodInfoPtr__GetAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe int packetId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass19_0.NativeFieldInfoPtr_packetId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass19_0.NativeFieldInfoPtr_packetId)) = value;
      }
    }
  }

  [ObfuscatedName("Tayx.Graphy.GraphyDebugger+<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_packetId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RemoveAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0;

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphyDebugger>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr);
      GraphyDebugger.__c__DisplayClass21_0.NativeFieldInfoPtr_packetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr, nameof (packetId));
      GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr, 100663427 /*0x06000083*/);
      GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__RemoveAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr, 100663428 /*0x06000084*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphyDebugger.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _RemoveAllDebugPacketsWithId_b__0(GraphyDebugger.DebugPacket x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GraphyDebugger.__c__DisplayClass21_0.NativeMethodInfoPtr__RemoveAllDebugPacketsWithId_b__0_Internal_Boolean_DebugPacket_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe int packetId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass21_0.NativeFieldInfoPtr_packetId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphyDebugger.__c__DisplayClass21_0.NativeFieldInfoPtr_packetId)) = value;
      }
    }
  }
}
