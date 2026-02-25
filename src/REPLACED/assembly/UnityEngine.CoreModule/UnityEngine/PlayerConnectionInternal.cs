// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerConnectionInternal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class PlayerConnectionInternal(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PollInternal_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySendMessage_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0;

  static PlayerConnectionInternal()
  {
    Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PlayerConnectionInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667690);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667691);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667692);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667693);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667694);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667695);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667696);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667697);
    PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667698);
    PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667699);
    PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667700);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667701);
    PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667702);
    PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667703);
    PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667704);
    PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667705);
    PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667706);
    PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667707);
    PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667708);
    PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667709);
    PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr, 100667710);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441457, XrefRangeEnd = 441464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_IPlayerEditorConnectionNative_SendMessage(
    Il2CppSystem.Guid messageId,
    Il2CppStructArray<byte> data,
    int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_SendMessage_Private_Virtual_Final_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441464, XrefRangeEnd = 441471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool UnityEngine_IPlayerEditorConnectionNative_TrySendMessage(
    Il2CppSystem.Guid messageId,
    Il2CppStructArray<byte> data,
    int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_TrySendMessage_Private_Virtual_Final_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441471, XrefRangeEnd = 441473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_IPlayerEditorConnectionNative_Poll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Poll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441473, XrefRangeEnd = 441477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_IPlayerEditorConnectionNative_RegisterInternal(
    Il2CppSystem.Guid messageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &messageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_RegisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441477, XrefRangeEnd = 441481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal(
    Il2CppSystem.Guid messageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &messageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_UnregisterInternal_Private_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441481, XrefRangeEnd = 441483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_IPlayerEditorConnectionNative_Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_Initialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441483, XrefRangeEnd = 441485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool UnityEngine_IPlayerEditorConnectionNative_IsConnected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_IsConnected_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441485, XrefRangeEnd = 441487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_IPlayerEditorConnectionNative_DisconnectAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnityEngine_IPlayerEditorConnectionNative_DisconnectAll_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsConnected()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_IsConnected_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Initialize()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_Initialize_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441501, RefRangeEnd = 441502, XrefRangeStart = 441487, XrefRangeEnd = 441501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RegisterInternal(string messageId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(messageId)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441516, RefRangeEnd = 441517, XrefRangeStart = 441502, XrefRangeEnd = 441516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnregisterInternal(string messageId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(messageId)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Private_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441537, RefRangeEnd = 441538, XrefRangeStart = 441517, XrefRangeEnd = 441537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SendMessage(
    string messageId,
    Il2CppStructArray<byte> data,
    int playerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(messageId);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Private_Static_Void_String_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441558, RefRangeEnd = 441559, XrefRangeStart = 441538, XrefRangeEnd = 441558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySendMessage(
    string messageId,
    Il2CppStructArray<byte> data,
    int playerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(messageId);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Private_Static_Boolean_String_Il2CppStructArray_1_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PollInternal()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_PollInternal_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DisconnectAll()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_DisconnectAll_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerConnectionInternal()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerConnectionInternal>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441559, XrefRangeEnd = 441561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RegisterInternal_Injected(ref ManagedSpanWrapper messageId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref messageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_RegisterInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441561, XrefRangeEnd = 441563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnregisterInternal_Injected(ref ManagedSpanWrapper messageId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref messageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_UnregisterInternal_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441563, XrefRangeEnd = 441565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SendMessage_Injected(
    ref ManagedSpanWrapper messageId,
    ref ManagedSpanWrapper data,
    int playerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_SendMessage_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441565, XrefRangeEnd = 441567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TrySendMessage_Injected(
    ref ManagedSpanWrapper messageId,
    ref ManagedSpanWrapper data,
    int playerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerConnectionInternal.NativeMethodInfoPtr_TrySendMessage_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public enum MulticastFlags
  {
    kRequestImmediateConnect = 1,
    kSupportsProfile = 2,
    kCustomMessage = 4,
    kUseAlternateIP = 8,
  }
}
