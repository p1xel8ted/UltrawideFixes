// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SendPacketOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

[StructLayout(LayoutKind.Explicit)]
public struct SendPacketOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RemoteUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SocketId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Channel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowDelayedDelivery;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Reliability;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SendPacketOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RemoteUserId;
  [FieldOffset(24)]
  public System.IntPtr m_SocketId;
  [FieldOffset(32 /*0x20*/)]
  public byte m_Channel;
  [FieldOffset(36)]
  public uint m_DataLengthBytes;
  [FieldOffset(40)]
  public System.IntPtr m_Data;
  [FieldOffset(48 /*0x30*/)]
  public int m_AllowDelayedDelivery;
  [FieldOffset(52)]
  public PacketReliability m_Reliability;

  static SendPacketOptionsInternal()
  {
    Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SendPacketOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr);
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_RemoteUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_RemoteUserId));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_SocketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_SocketId));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_Channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_Channel));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_Data));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_AllowDelayedDelivery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_AllowDelayedDelivery));
    SendPacketOptionsInternal.NativeFieldInfoPtr_m_Reliability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, nameof (m_Reliability));
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668498);
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668499);
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668500);
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668501);
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668502);
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668503);
    SendPacketOptionsInternal.NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668504);
    SendPacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendPacketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668505);
    SendPacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668506);
    SendPacketOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, 100668507);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387163, XrefRangeEnd = 387167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId RemoteUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387167, XrefRangeEnd = 387171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_RemoteUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SocketId SocketId
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 387177, RefRangeEnd = 387178, XrefRangeStart = 387171, XrefRangeEnd = 387177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe byte Channel
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_Channel_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<byte> Data
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 387184, RefRangeEnd = 387185, XrefRangeStart = 387178, XrefRangeEnd = 387184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AllowDelayedDelivery
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387185, XrefRangeEnd = 387189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_AllowDelayedDelivery_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PacketReliability Reliability
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_set_Reliability_Public_set_Void_PacketReliability_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 387203, RefRangeEnd = 387204, XrefRangeStart = 387189, XrefRangeEnd = 387203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SendPacketOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendPacketOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387204, XrefRangeEnd = 387207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387207, XrefRangeEnd = 387214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendPacketOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendPacketOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
