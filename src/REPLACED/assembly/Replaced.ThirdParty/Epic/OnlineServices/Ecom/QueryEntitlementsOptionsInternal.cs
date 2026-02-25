// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.QueryEntitlementsOptionsInternal
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
public struct QueryEntitlementsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntitlementNameCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IncludeRedeemed;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EntitlementNames_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncludeRedeemed_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryEntitlementsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_EntitlementNames;
  [FieldOffset(24)]
  public uint m_EntitlementNameCount;
  [FieldOffset(28)]
  public int m_IncludeRedeemed;

  static QueryEntitlementsOptionsInternal()
  {
    Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (QueryEntitlementsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr);
    QueryEntitlementsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryEntitlementsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryEntitlementsOptionsInternal.NativeFieldInfoPtr_m_EntitlementNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_EntitlementNames));
    QueryEntitlementsOptionsInternal.NativeFieldInfoPtr_m_EntitlementNameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_EntitlementNameCount));
    QueryEntitlementsOptionsInternal.NativeFieldInfoPtr_m_IncludeRedeemed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, nameof (m_IncludeRedeemed));
    QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, 100671163);
    QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_set_EntitlementNames_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, 100671164);
    QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_set_IncludeRedeemed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, 100671165);
    QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryEntitlementsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, 100671166);
    QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, 100671167);
    QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, 100671168);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395461, XrefRangeEnd = 395465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray EntitlementNames
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 395471, RefRangeEnd = 395472, XrefRangeStart = 395465, XrefRangeEnd = 395471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_set_EntitlementNames_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IncludeRedeemed
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395472, XrefRangeEnd = 395476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_set_IncludeRedeemed_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 395485, RefRangeEnd = 395486, XrefRangeStart = 395476, XrefRangeEnd = 395485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryEntitlementsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryEntitlementsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395486, XrefRangeEnd = 395489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395489, XrefRangeEnd = 395494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryEntitlementsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryEntitlementsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
