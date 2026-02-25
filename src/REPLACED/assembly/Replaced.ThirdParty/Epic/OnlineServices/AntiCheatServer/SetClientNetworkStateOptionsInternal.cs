// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatServer.SetClientNetworkStateOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatServer;

[StructLayout(LayoutKind.Explicit)]
public struct SetClientNetworkStateOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsNetworkActive;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetClientNetworkStateOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(16 /*0x10*/)]
  public int m_IsNetworkActive;

  static SetClientNetworkStateOptionsInternal()
  {
    Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatServer", nameof (SetClientNetworkStateOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr);
    SetClientNetworkStateOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetClientNetworkStateOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
    SetClientNetworkStateOptionsInternal.NativeFieldInfoPtr_m_IsNetworkActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, nameof (m_IsNetworkActive));
    SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100672586);
    SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100672587);
    SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetClientNetworkStateOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100672588);
    SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100672589);
    SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, 100672590);
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
      IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsNetworkActive
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399853, XrefRangeEnd = 399857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_set_IsNetworkActive_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399857, XrefRangeEnd = 399861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SetClientNetworkStateOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetClientNetworkStateOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399861, XrefRangeEnd = 399867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399867, XrefRangeEnd = 399871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientNetworkStateOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetClientNetworkStateOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
