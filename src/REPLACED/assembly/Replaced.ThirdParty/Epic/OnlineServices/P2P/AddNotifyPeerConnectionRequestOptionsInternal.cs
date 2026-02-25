// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.AddNotifyPeerConnectionRequestOptionsInternal
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
public struct AddNotifyPeerConnectionRequestOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SocketId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AddNotifyPeerConnectionRequestOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_SocketId;

  static AddNotifyPeerConnectionRequestOptionsInternal()
  {
    Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (AddNotifyPeerConnectionRequestOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr);
    AddNotifyPeerConnectionRequestOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AddNotifyPeerConnectionRequestOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    AddNotifyPeerConnectionRequestOptionsInternal.NativeFieldInfoPtr_m_SocketId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, nameof (m_SocketId));
    AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, 100668205);
    AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, 100668206);
    AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AddNotifyPeerConnectionRequestOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, 100668207);
    AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, 100668208);
    AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, 100668209);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386262, XrefRangeEnd = 386266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SocketId SocketId
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 386272, RefRangeEnd = 386274, XrefRangeStart = 386266, XrefRangeEnd = 386272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_set_SocketId_Public_set_Void_SocketId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386274, XrefRangeEnd = 386279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AddNotifyPeerConnectionRequestOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AddNotifyPeerConnectionRequestOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386279, XrefRangeEnd = 386286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386286, XrefRangeEnd = 386291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifyPeerConnectionRequestOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddNotifyPeerConnectionRequestOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
