// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.OnMessageToServerCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient;

[StructLayout(LayoutKind.Explicit)]
public struct OnMessageToServerCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MessageData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MessageDataSizeBytes;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MessageData_Public_get_Il2CppStructArray_1_Byte_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_MessageData;
  [FieldOffset(16 /*0x10*/)]
  public uint m_MessageDataSizeBytes;

  static OnMessageToServerCallbackInfoInternal()
  {
    Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (OnMessageToServerCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr);
    OnMessageToServerCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnMessageToServerCallbackInfoInternal.NativeFieldInfoPtr_m_MessageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, nameof (m_MessageData));
    OnMessageToServerCallbackInfoInternal.NativeFieldInfoPtr_m_MessageDataSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, nameof (m_MessageDataSizeBytes));
    OnMessageToServerCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, 100673099);
    OnMessageToServerCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, 100673100);
    OnMessageToServerCallbackInfoInternal.NativeMethodInfoPtr_get_MessageData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, 100673101);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401387, XrefRangeEnd = 401391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnMessageToServerCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnMessageToServerCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppStructArray<byte> MessageData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401391, XrefRangeEnd = 401397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnMessageToServerCallbackInfoInternal.NativeMethodInfoPtr_get_MessageData_Public_get_Il2CppStructArray_1_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnMessageToServerCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
