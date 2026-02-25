// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnIncomingPacketQueueFullInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

[StructLayout(LayoutKind.Explicit)]
public struct OnIncomingPacketQueueFullInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PacketQueueMaxSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PacketQueueCurrentSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverflowPacketLocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverflowPacketChannel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverflowPacketSizeBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public ulong m_PacketQueueMaxSizeBytes;
  [FieldOffset(16 /*0x10*/)]
  public ulong m_PacketQueueCurrentSizeBytes;
  [FieldOffset(24)]
  public System.IntPtr m_OverflowPacketLocalUserId;
  [FieldOffset(32 /*0x20*/)]
  public byte m_OverflowPacketChannel;
  [FieldOffset(36)]
  public uint m_OverflowPacketSizeBytes;

  static OnIncomingPacketQueueFullInfoInternal()
  {
    Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (OnIncomingPacketQueueFullInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr);
    OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_PacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_PacketQueueMaxSizeBytes));
    OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_PacketQueueCurrentSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_PacketQueueCurrentSizeBytes));
    OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_OverflowPacketLocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_OverflowPacketLocalUserId));
    OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_OverflowPacketChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_OverflowPacketChannel));
    OnIncomingPacketQueueFullInfoInternal.NativeFieldInfoPtr_m_OverflowPacketSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, nameof (m_OverflowPacketSizeBytes));
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668321);
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668322);
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668323);
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668324);
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668325);
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668326);
    OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, 100668327);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386567, XrefRangeEnd = 386571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ulong PacketQueueMaxSizeBytes
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ulong PacketQueueCurrentSizeBytes
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId OverflowPacketLocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386571, XrefRangeEnd = 386577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe byte OverflowPacketChannel
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe uint OverflowPacketSizeBytes
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfoInternal.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
