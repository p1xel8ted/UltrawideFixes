// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPacketQueueSizeOptionsInternal
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
public struct SetPacketQueueSizeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetPacketQueueSizeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public ulong m_IncomingPacketQueueMaxSizeBytes;
  [FieldOffset(16 /*0x10*/)]
  public ulong m_OutgoingPacketQueueMaxSizeBytes;

  static SetPacketQueueSizeOptionsInternal()
  {
    Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SetPacketQueueSizeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr);
    SetPacketQueueSizeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetPacketQueueSizeOptionsInternal.NativeFieldInfoPtr_m_IncomingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, nameof (m_IncomingPacketQueueMaxSizeBytes));
    SetPacketQueueSizeOptionsInternal.NativeFieldInfoPtr_m_OutgoingPacketQueueMaxSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, nameof (m_OutgoingPacketQueueMaxSizeBytes));
    SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100668513);
    SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100668514);
    SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetPacketQueueSizeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100668515);
    SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100668516);
    SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, 100668517);
  }

  public unsafe ulong IncomingPacketQueueMaxSizeBytes
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueMaxSizeBytes
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(SetPacketQueueSizeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetPacketQueueSizeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387214, XrefRangeEnd = 387216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPacketQueueSizeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
