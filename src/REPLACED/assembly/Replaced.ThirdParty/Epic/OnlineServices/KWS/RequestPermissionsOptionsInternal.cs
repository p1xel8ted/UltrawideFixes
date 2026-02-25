// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.KWS.RequestPermissionsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.KWS;

[StructLayout(LayoutKind.Explicit)]
public struct RequestPermissionsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionKeyCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PermissionKeys;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PermissionKeys_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RequestPermissionsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_PermissionKeyCount;
  [FieldOffset(24)]
  public System.IntPtr m_PermissionKeys;

  static RequestPermissionsOptionsInternal()
  {
    Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.KWS", nameof (RequestPermissionsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr);
    RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_PermissionKeyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_PermissionKeyCount));
    RequestPermissionsOptionsInternal.NativeFieldInfoPtr_m_PermissionKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, nameof (m_PermissionKeys));
    RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100670364);
    RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_PermissionKeys_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100670365);
    RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RequestPermissionsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100670366);
    RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100670367);
    RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, 100670368);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392962, XrefRangeEnd = 392966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray PermissionKeys
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 392972, RefRangeEnd = 392974, XrefRangeStart = 392966, XrefRangeEnd = 392972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_set_PermissionKeys_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392974, XrefRangeEnd = 392979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RequestPermissionsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RequestPermissionsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392979, XrefRangeEnd = 392986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392986, XrefRangeEnd = 392991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RequestPermissionsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RequestPermissionsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
