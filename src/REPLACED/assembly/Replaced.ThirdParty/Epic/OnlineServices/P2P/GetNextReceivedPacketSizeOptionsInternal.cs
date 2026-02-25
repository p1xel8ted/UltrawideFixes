// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.GetNextReceivedPacketSizeOptionsInternal
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
public struct GetNextReceivedPacketSizeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RequestedChannel;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_GetNextReceivedPacketSizeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RequestedChannel;

  static GetNextReceivedPacketSizeOptionsInternal()
  {
    Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (GetNextReceivedPacketSizeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr);
    GetNextReceivedPacketSizeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    GetNextReceivedPacketSizeOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    GetNextReceivedPacketSizeOptionsInternal.NativeFieldInfoPtr_m_RequestedChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, nameof (m_RequestedChannel));
    GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668255);
    GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668256);
    GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetNextReceivedPacketSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668257);
    GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668258);
    GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, 100668259);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386390, XrefRangeEnd = 386394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<byte> RequestedChannel
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 386400, RefRangeEnd = 386402, XrefRangeStart = 386394, XrefRangeEnd = 386400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_set_RequestedChannel_Public_set_Void_Nullable_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386402, XrefRangeEnd = 386407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(GetNextReceivedPacketSizeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetNextReceivedPacketSizeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386407, XrefRangeEnd = 386414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386414, XrefRangeEnd = 386419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetNextReceivedPacketSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetNextReceivedPacketSizeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
