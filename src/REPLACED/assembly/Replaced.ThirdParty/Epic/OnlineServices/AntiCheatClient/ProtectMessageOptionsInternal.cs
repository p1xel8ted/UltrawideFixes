// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.ProtectMessageOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient;

[StructLayout(LayoutKind.Explicit)]
public struct ProtectMessageOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutBufferSizeBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ProtectMessageOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_DataLengthBytes;
  [FieldOffset(8)]
  public System.IntPtr m_Data;
  [FieldOffset(16 /*0x10*/)]
  public uint m_OutBufferSizeBytes;

  static ProtectMessageOptionsInternal()
  {
    Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (ProtectMessageOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr);
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_Data));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_OutBufferSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_OutBufferSizeBytes));
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100673130);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100673131);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ProtectMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100673132);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100673133);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100673134);
  }

  public unsafe Il2CppStructArray<byte> Data
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 401405, RefRangeEnd = 401407, XrefRangeStart = 401399, XrefRangeEnd = 401405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OutBufferSizeBytes
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401407, XrefRangeEnd = 401408 /*0x062000*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ProtectMessageOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProtectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ProtectMessageOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401408 /*0x062000*/, XrefRangeEnd = 401411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProtectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401411, XrefRangeEnd = 401415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProtectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
