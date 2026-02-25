// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.ReceivePacketOptionsInternal
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
public struct ReceivePacketOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxDataSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RequestedChannel;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxDataSizeBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ReceivePacketOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_MaxDataSizeBytes;
  [FieldOffset(24)]
  public System.IntPtr m_RequestedChannel;

  static ReceivePacketOptionsInternal()
  {
    Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (ReceivePacketOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr);
    ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_MaxDataSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_MaxDataSizeBytes));
    ReceivePacketOptionsInternal.NativeFieldInfoPtr_m_RequestedChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, nameof (m_RequestedChannel));
    ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100668477);
    ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_MaxDataSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100668478);
    ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100668479);
    ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ReceivePacketOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100668480);
    ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100668481);
    ReceivePacketOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, 100668482);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387134, XrefRangeEnd = 387138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint MaxDataSizeBytes
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_MaxDataSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<byte> RequestedChannel
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 387144, RefRangeEnd = 387146, XrefRangeStart = 387138, XrefRangeEnd = 387144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387146, XrefRangeEnd = 387151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ReceivePacketOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ReceivePacketOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387151, XrefRangeEnd = 387158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387158, XrefRangeEnd = 387163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReceivePacketOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReceivePacketOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
