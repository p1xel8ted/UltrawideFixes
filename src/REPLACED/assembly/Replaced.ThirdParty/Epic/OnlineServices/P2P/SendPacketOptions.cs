// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SendPacketOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

public class SendPacketOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RemoteUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SocketId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Channel_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Reliability_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Channel_Public_get_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowDelayedDelivery_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Reliability_Public_get_PacketReliability_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SendPacketOptions()
  {
    Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SendPacketOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr);
    SendPacketOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
    SendPacketOptions.NativeFieldInfoPtr__RemoteUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<RemoteUserId>k__BackingField");
    SendPacketOptions.NativeFieldInfoPtr__SocketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<SocketId>k__BackingField");
    SendPacketOptions.NativeFieldInfoPtr__Channel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<Channel>k__BackingField");
    SendPacketOptions.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<Data>k__BackingField");
    SendPacketOptions.NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<AllowDelayedDelivery>k__BackingField");
    SendPacketOptions.NativeFieldInfoPtr__Reliability_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, "<Reliability>k__BackingField");
    SendPacketOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668483);
    SendPacketOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668484);
    SendPacketOptions.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668485);
    SendPacketOptions.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668486);
    SendPacketOptions.NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668487);
    SendPacketOptions.NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668488);
    SendPacketOptions.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668489);
    SendPacketOptions.NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668490);
    SendPacketOptions.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668491);
    SendPacketOptions.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668492);
    SendPacketOptions.NativeMethodInfoPtr_get_AllowDelayedDelivery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668493);
    SendPacketOptions.NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668494);
    SendPacketOptions.NativeMethodInfoPtr_get_Reliability_Public_get_PacketReliability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668495);
    SendPacketOptions.NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668496);
    SendPacketOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr, 100668497);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId RemoteUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SocketId SocketId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SocketId) null : Il2CppObjectPool.Get<SocketId>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe byte Channel
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_Channel_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<byte> Data
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowDelayedDelivery
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_AllowDelayedDelivery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PacketReliability Reliability
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_get_Reliability_Public_get_PacketReliability_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PacketReliability*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 123416, RefRangeEnd = 123429, XrefRangeStart = 123416, XrefRangeEnd = 123429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SendPacketOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendPacketOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPacketOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ProductUserId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _RemoteUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__RemoteUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__RemoteUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SocketId _SocketId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__SocketId_k__BackingField));
      return num == System.IntPtr.Zero ? (SocketId) null : Il2CppObjectPool.Get<SocketId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__SocketId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe byte _Channel_k__BackingField
  {
    get
    {
      return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Channel_k__BackingField));
    }
    [param: In] set
    {
      *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Channel_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppStructArray<byte> _Data_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Data_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _AllowDelayedDelivery_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__AllowDelayedDelivery_k__BackingField)) = value;
    }
  }

  public unsafe PacketReliability _Reliability_k__BackingField
  {
    get
    {
      return *(PacketReliability*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Reliability_k__BackingField));
    }
    [param: In] set
    {
      *(PacketReliability*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SendPacketOptions.NativeFieldInfoPtr__Reliability_k__BackingField)) = value;
    }
  }
}
