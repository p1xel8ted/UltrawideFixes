// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.ReadFileOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.TitleStorage;

[StructLayout(LayoutKind.Explicit)]
public struct ReadFileOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Filename;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadChunkLengthBytes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadFileDataCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FileTransferProgressCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_ReadFileDataCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_FileTransferProgressCallback;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReadFileDataCallback_Public_Static_get_OnReadFileDataCallbackInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ReadFileOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Filename;
  [FieldOffset(24)]
  public uint m_ReadChunkLengthBytes;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ReadFileDataCallback;
  [FieldOffset(40)]
  public System.IntPtr m_FileTransferProgressCallback;

  static ReadFileOptionsInternal()
  {
    Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.TitleStorage", nameof (ReadFileOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr);
    ReadFileOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ReadFileOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    ReadFileOptionsInternal.NativeFieldInfoPtr_m_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_Filename));
    ReadFileOptionsInternal.NativeFieldInfoPtr_m_ReadChunkLengthBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_ReadChunkLengthBytes));
    ReadFileOptionsInternal.NativeFieldInfoPtr_m_ReadFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_ReadFileDataCallback));
    ReadFileOptionsInternal.NativeFieldInfoPtr_m_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (m_FileTransferProgressCallback));
    ReadFileOptionsInternal.NativeFieldInfoPtr_s_ReadFileDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (s_ReadFileDataCallback));
    ReadFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, nameof (s_FileTransferProgressCallback));
    ReadFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665082);
    ReadFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665083);
    ReadFileOptionsInternal.NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665084);
    ReadFileOptionsInternal.NativeMethodInfoPtr_get_ReadFileDataCallback_Public_Static_get_OnReadFileDataCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665085);
    ReadFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665086);
    ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ReadFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665087);
    ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665088 /*0x06000700*/);
    ReadFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, 100665089 /*0x06000701*/);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375148, XrefRangeEnd = 375154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Filename
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375154, XrefRangeEnd = 375158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_set_Filename_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint ReadChunkLengthBytes
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_set_ReadChunkLengthBytes_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe OnReadFileDataCallbackInternal ReadFileDataCallback
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 375169, RefRangeEnd = 375171, XrefRangeStart = 375158, XrefRangeEnd = 375169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_get_ReadFileDataCallback_Public_Static_get_OnReadFileDataCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (OnReadFileDataCallbackInternal) null : Il2CppObjectPool.Get<OnReadFileDataCallbackInternal>(num3);
    }
  }

  public static unsafe OnFileTransferProgressCallbackInternal FileTransferProgressCallback
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 375182, RefRangeEnd = 375184, XrefRangeStart = 375171, XrefRangeEnd = 375182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_get_FileTransferProgressCallback_Public_Static_get_OnFileTransferProgressCallbackInternal_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : Il2CppObjectPool.Get<OnFileTransferProgressCallbackInternal>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 375208, RefRangeEnd = 375209, XrefRangeStart = 375184, XrefRangeEnd = 375208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ReadFileOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_ReadFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375209, XrefRangeEnd = 375212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375212, XrefRangeEnd = 375231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReadFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadFileOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe OnReadFileDataCallbackInternal s_ReadFileDataCallback
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_ReadFileDataCallback, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (OnReadFileDataCallbackInternal) null : Il2CppObjectPool.Get<OnReadFileDataCallbackInternal>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_ReadFileDataCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe OnFileTransferProgressCallbackInternal s_FileTransferProgressCallback
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (OnFileTransferProgressCallbackInternal) null : Il2CppObjectPool.Get<OnFileTransferProgressCallbackInternal>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ReadFileOptionsInternal.NativeFieldInfoPtr_s_FileTransferProgressCallback, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
