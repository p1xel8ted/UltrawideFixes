// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.QueryOwnershipOptionsInternal
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
public struct QueryOwnershipOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemIdCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryOwnershipOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_CatalogItemIds;
  [FieldOffset(24)]
  public uint m_CatalogItemIdCount;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_CatalogNamespace;

  static QueryOwnershipOptionsInternal()
  {
    Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (QueryOwnershipOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr);
    QueryOwnershipOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryOwnershipOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryOwnershipOptionsInternal.NativeFieldInfoPtr_m_CatalogItemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, nameof (m_CatalogItemIds));
    QueryOwnershipOptionsInternal.NativeFieldInfoPtr_m_CatalogItemIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, nameof (m_CatalogItemIdCount));
    QueryOwnershipOptionsInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
    QueryOwnershipOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, 100671217);
    QueryOwnershipOptionsInternal.NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, 100671218);
    QueryOwnershipOptionsInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, 100671219);
    QueryOwnershipOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryOwnershipOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, 100671220);
    QueryOwnershipOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, 100671221);
    QueryOwnershipOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, 100671222);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395647, XrefRangeEnd = 395651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray CatalogItemIds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 395657, RefRangeEnd = 395658, XrefRangeStart = 395651, XrefRangeEnd = 395657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipOptionsInternal.NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CatalogNamespace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395658, XrefRangeEnd = 395662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipOptionsInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 395671, RefRangeEnd = 395672, XrefRangeStart = 395662, XrefRangeEnd = 395671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryOwnershipOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryOwnershipOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryOwnershipOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395672, XrefRangeEnd = 395675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryOwnershipOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395675, XrefRangeEnd = 395681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryOwnershipOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryOwnershipOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
