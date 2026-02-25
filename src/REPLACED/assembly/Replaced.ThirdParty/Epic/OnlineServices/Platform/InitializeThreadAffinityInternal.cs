// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeThreadAffinityInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

[StructLayout(LayoutKind.Explicit)]
public struct InitializeThreadAffinityInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NetworkWork;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StorageIo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WebSocketIo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_P2PIo;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HttpRequestIo;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_InitializeThreadAffinity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public ulong m_NetworkWork;
  [FieldOffset(16 /*0x10*/)]
  public ulong m_StorageIo;
  [FieldOffset(24)]
  public ulong m_WebSocketIo;
  [FieldOffset(32 /*0x20*/)]
  public ulong m_P2PIo;
  [FieldOffset(40)]
  public ulong m_HttpRequestIo;

  static InitializeThreadAffinityInternal()
  {
    Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (InitializeThreadAffinityInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr);
    InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_ApiVersion));
    InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_NetworkWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_NetworkWork));
    InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_StorageIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_StorageIo));
    InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_WebSocketIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_WebSocketIo));
    InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_P2PIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_P2PIo));
    InitializeThreadAffinityInternal.NativeFieldInfoPtr_m_HttpRequestIo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, nameof (m_HttpRequestIo));
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667985);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667986);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667987);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667988);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667989);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667990);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667991);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667992);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667993);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667994);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Void_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667995);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667996);
    InitializeThreadAffinityInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, 100667997);
  }

  public unsafe ulong NetworkWork
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong StorageIo
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong WebSocketIo
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong P2PIo
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong HttpRequestIo
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(InitializeThreadAffinity other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Void_InitializeThreadAffinity_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385594, XrefRangeEnd = 385596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinityInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeThreadAffinityInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
