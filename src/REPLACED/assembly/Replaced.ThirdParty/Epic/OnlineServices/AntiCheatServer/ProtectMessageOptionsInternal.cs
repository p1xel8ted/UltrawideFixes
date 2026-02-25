// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.ProtectMessageOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer;

[StructLayout(LayoutKind.Explicit)]
public struct ProtectMessageOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DataLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutBufferSizeBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ProtectMessageOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(16 /*0x10*/)]
  public uint m_DataLengthBytes;
  [FieldOffset(24)]
  public System.IntPtr m_Data;
  [FieldOffset(32 /*0x20*/)]
  public uint m_OutBufferSizeBytes;

  static ProtectMessageOptionsInternal()
  {
    Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatServer", nameof (ProtectMessageOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr);
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_DataLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_DataLengthBytes));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_Data));
    ProtectMessageOptionsInternal.NativeFieldInfoPtr_m_OutBufferSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, nameof (m_OutBufferSizeBytes));
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100672546);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100672547);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_OutBufferSizeBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100672548);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ProtectMessageOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100672549);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100672550);
    ProtectMessageOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProtectMessageOptionsInternal>.NativeClassPtr, 100672551);
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ProtectMessageOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<byte> Data
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 399799, RefRangeEnd = 399801, XrefRangeStart = 399793, XrefRangeEnd = 399799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399801, XrefRangeEnd = 399802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399802, XrefRangeEnd = 399805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399805, XrefRangeEnd = 399810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
