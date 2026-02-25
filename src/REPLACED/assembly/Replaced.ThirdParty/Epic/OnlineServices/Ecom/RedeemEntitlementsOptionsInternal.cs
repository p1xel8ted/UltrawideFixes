// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.RedeemEntitlementsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

[StructLayout(LayoutKind.Explicit)]
public struct RedeemEntitlementsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementIdCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementIds;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementIds_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RedeemEntitlementsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_EntitlementIdCount;
  [FieldOffset(24)]
  public System.IntPtr m_EntitlementIds;

  static RedeemEntitlementsOptionsInternal()
  {
    Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (RedeemEntitlementsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr);
    RedeemEntitlementsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RedeemEntitlementsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    RedeemEntitlementsOptionsInternal.NativeFieldInfoPtr_m_EntitlementIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_EntitlementIdCount));
    RedeemEntitlementsOptionsInternal.NativeFieldInfoPtr_m_EntitlementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_EntitlementIds));
    RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, 100671272);
    RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_set_EntitlementIds_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, 100671273);
    RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RedeemEntitlementsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, 100671274);
    RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, 100671275);
    RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, 100671276);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395837, XrefRangeEnd = 395841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray EntitlementIds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 395847, RefRangeEnd = 395849, XrefRangeStart = 395841, XrefRangeEnd = 395847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_set_EntitlementIds_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395849, XrefRangeEnd = 395854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RedeemEntitlementsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RedeemEntitlementsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395854, XrefRangeEnd = 395861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395861, XrefRangeEnd = 395866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RedeemEntitlementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RedeemEntitlementsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
