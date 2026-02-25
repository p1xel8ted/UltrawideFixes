// Decompiled with JetBrains decompiler
// Type: UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents
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
public class PlayerEditorConnectionEvents(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MessageTypeSubscribers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SubscriberLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_connectionEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_disconnectionEvent;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_messageTypeSubscribers_Public_get_IReadOnlyList_1_MessageTypeSubscribers_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuildLookup_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerEditorConnectionEvents()
  {
    Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Networking.PlayerConnection", nameof (PlayerEditorConnectionEvents));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr);
    PlayerEditorConnectionEvents.NativeFieldInfoPtr_m_MessageTypeSubscribers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (m_MessageTypeSubscribers));
    PlayerEditorConnectionEvents.NativeFieldInfoPtr_m_SubscriberLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (m_SubscriberLookup));
    PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (connectionEvent));
    PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (disconnectionEvent));
    PlayerEditorConnectionEvents.NativeMethodInfoPtr_get_messageTypeSubscribers_Public_get_IReadOnlyList_1_MessageTypeSubscribers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100669337);
    PlayerEditorConnectionEvents.NativeMethodInfoPtr_BuildLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100669338);
    PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100669339);
    PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100669340);
    PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100669341);
    PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, 100669342);
  }

  public unsafe IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_get_messageTypeSubscribers_Public_get_IReadOnlyList_1_MessageTypeSubscribers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers>) null : Il2CppObjectPool.Get<IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers>>(num3);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 479795, RefRangeEnd = 479800, XrefRangeStart = 479767, XrefRangeEnd = 479795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BuildLookup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_BuildLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479800, XrefRangeEnd = 479813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokeMessageIdSubscribers(
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
    IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_InvokeMessageIdSubscribers_Public_Void_Guid_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479841, RefRangeEnd = 479842, XrefRangeStart = 479813, XrefRangeEnd = 479841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityEvent<MessageEventArgs> AddAndCreate(Il2CppSystem.Guid messageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &messageId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_AddAndCreate_Public_UnityEvent_1_MessageEventArgs_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityEvent<MessageEventArgs>) null : Il2CppObjectPool.Get<UnityEvent<MessageEventArgs>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479842, XrefRangeEnd = 479855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterManagedCallback(
    Il2CppSystem.Guid messageId,
    UnityAction<MessageEventArgs> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr_UnregisterManagedCallback_Public_Void_Guid_UnityAction_1_MessageEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479855, XrefRangeEnd = 479873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerEditorConnectionEvents()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_m_MessageTypeSubscribers));
      return num == System.IntPtr.Zero ? (List<PlayerEditorConnectionEvents.MessageTypeSubscribers>) null : Il2CppObjectPool.Get<List<PlayerEditorConnectionEvents.MessageTypeSubscribers>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_m_MessageTypeSubscribers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Il2CppSystem.Guid, PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_m_SubscriberLookup));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Guid, PlayerEditorConnectionEvents.MessageTypeSubscribers>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Guid, PlayerEditorConnectionEvents.MessageTypeSubscribers>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_m_SubscriberLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent));
      return num == System.IntPtr.Zero ? (PlayerEditorConnectionEvents.ConnectionChangeEvent) null : Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_connectionEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent));
      return num == System.IntPtr.Zero ? (PlayerEditorConnectionEvents.ConnectionChangeEvent) null : Il2CppObjectPool.Get<PlayerEditorConnectionEvents.ConnectionChangeEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.NativeFieldInfoPtr_disconnectionEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public void Clear()
  {
    if (this.m_SubscriberLookup != null)
      this.m_SubscriberLookup.Clear();
    this.m_MessageTypeSubscribers.Clear();
  }

  [Serializable]
  public class MessageEvent(System.IntPtr pointer) : UnityEvent<MessageEventArgs>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MessageEvent()
    {
      Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (MessageEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr);
      PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr, 100669343);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479752, XrefRangeEnd = 479755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MessageEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class ConnectionChangeEvent(System.IntPtr pointer) : UnityEvent<int>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ConnectionChangeEvent()
    {
      Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (ConnectionChangeEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr);
      PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr, 100669344);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479755, XrefRangeEnd = 479758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConnectionChangeEvent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.ConnectionChangeEvent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.ConnectionChangeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class MessageTypeSubscribers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_messageTypeId;
    private static readonly System.IntPtr NativeFieldInfoPtr_subscriberCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_messageCallback;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MessageTypeSubscribers()
    {
      Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEditorConnectionEvents>.NativeClassPtr, nameof (MessageTypeSubscribers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr);
      PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, nameof (m_messageTypeId));
      PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, nameof (subscriberCount));
      PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, nameof (messageCallback));
      PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100669345);
      PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100669346);
      PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr, 100669347);
    }

    public unsafe Il2CppSystem.Guid MessageTypeId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479758, XrefRangeEnd = 479759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_get_MessageTypeId_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Il2CppSystem.Guid*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479759, XrefRangeEnd = 479760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr_set_MessageTypeId_Public_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479760, XrefRangeEnd = 479767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MessageTypeSubscribers()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEditorConnectionEvents.MessageTypeSubscribers>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe string m_messageTypeId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_m_messageTypeId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int subscriberCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_subscriberCount)) = value;
      }
    }

    public unsafe PlayerEditorConnectionEvents.MessageEvent messageCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback));
        return num == System.IntPtr.Zero ? (PlayerEditorConnectionEvents.MessageEvent) null : Il2CppObjectPool.Get<PlayerEditorConnectionEvents.MessageEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerEditorConnectionEvents.MessageTypeSubscribers.NativeFieldInfoPtr_messageCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
