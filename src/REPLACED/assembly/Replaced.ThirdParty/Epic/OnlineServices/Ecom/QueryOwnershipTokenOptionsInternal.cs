// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.QueryOwnershipTokenOptionsInternal
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
public struct QueryOwnershipTokenOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogItemIdCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CatalogNamespace;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryOwnershipTokenOptions_0;
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

  static QueryOwnershipTokenOptionsInternal()
  {
    Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (QueryOwnershipTokenOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr);
    QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_CatalogItemIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_CatalogItemIds));
    QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_CatalogItemIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_CatalogItemIdCount));
    QueryOwnershipTokenOptionsInternal.NativeFieldInfoPtr_m_CatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, nameof (m_CatalogNamespace));
    QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100671247);
    QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100671248);
    QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100671249);
    QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryOwnershipTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100671250);
    QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100671251);
    QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, 100671252);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395750, XrefRangeEnd = 395754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray CatalogItemIds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 395760, RefRangeEnd = 395761, XrefRangeStart = 395754, XrefRangeEnd = 395760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogItemIds_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CatalogNamespace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395761, XrefRangeEnd = 395765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_set_CatalogNamespace_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 395774, RefRangeEnd = 395775, XrefRangeStart = 395765, XrefRangeEnd = 395774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryOwnershipTokenOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryOwnershipTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395775, XrefRangeEnd = 395778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395778, XrefRangeEnd = 395784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryOwnershipTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryOwnershipTokenOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
