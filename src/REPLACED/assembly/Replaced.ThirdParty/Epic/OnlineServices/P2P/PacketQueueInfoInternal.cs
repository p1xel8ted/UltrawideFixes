// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.PacketQueueInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

[StructLayout(LayoutKind.Explicit)]
public struct PacketQueueInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueCurrentSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueCurrentPacketCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentPacketCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PacketQueueInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public ulong m_IncomingPacketQueueMaxSizeBytes;
  [FieldOffset(8)]
  public ulong m_IncomingPacketQueueCurrentSizeBytes;
  [FieldOffset(16 /*0x10*/)]
  public ulong m_IncomingPacketQueueCurrentPacketCount;
  [FieldOffset(24)]
  public ulong m_OutgoingPacketQueueMaxSizeBytes;
  [FieldOffset(32 /*0x20*/)]
  public ulong m_OutgoingPacketQueueCurrentSizeBytes;
  [FieldOffset(40)]
  public ulong m_OutgoingPacketQueueCurrentPacketCount;

  static PacketQueueInfoInternal()
  {
    Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (PacketQueueInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr);
    PacketQueueInfoInternal.NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueMaxSizeBytes));
    PacketQueueInfoInternal.NativeFieldInfoPtr_m_IncomingPacketQueueCurrentSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueCurrentSizeBytes));
    PacketQueueInfoInternal.NativeFieldInfoPtr_m_IncomingPacketQueueCurrentPacketCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueCurrentPacketCount));
    PacketQueueInfoInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueMaxSizeBytes));
    PacketQueueInfoInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueCurrentSizeBytes));
    PacketQueueInfoInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueCurrentPacketCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueCurrentPacketCount));
    PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668451);
    PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668452);
    PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668453);
    PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668454);
    PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668455);
    PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668456);
    PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668457);
    PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668458);
    PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668459);
    PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668460);
    PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668461);
    PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668462);
    PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Void_PacketQueueInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668463);
    PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668464);
    PacketQueueInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, 100668465);
  }

  public unsafe ulong IncomingPacketQueueMaxSizeBytes
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong IncomingPacketQueueCurrentSizeBytes
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong IncomingPacketQueueCurrentPacketCount
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueMaxSizeBytes
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueCurrentSizeBytes
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueCurrentPacketCount
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(PacketQueueInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Void_PacketQueueInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387130, XrefRangeEnd = 387132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PacketQueueInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PacketQueueInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
