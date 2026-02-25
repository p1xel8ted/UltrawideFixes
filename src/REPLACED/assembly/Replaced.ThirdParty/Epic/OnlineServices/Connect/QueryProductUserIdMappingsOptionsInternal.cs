// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.QueryProductUserIdMappingsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct QueryProductUserIdMappingsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType_DEPRECATED;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserIdCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_DEPRECATED_Public_set_Void_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryProductUserIdMappingsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public ExternalAccountType m_AccountIdType_DEPRECATED;
  [FieldOffset(24)]
  public System.IntPtr m_ProductUserIds;
  [FieldOffset(32 /*0x20*/)]
  public uint m_ProductUserIdCount;

  static QueryProductUserIdMappingsOptionsInternal()
  {
    Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (QueryProductUserIdMappingsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr);
    QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_AccountIdType_DEPRECATED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_AccountIdType_DEPRECATED));
    QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_ProductUserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_ProductUserIds));
    QueryProductUserIdMappingsOptionsInternal.NativeFieldInfoPtr_m_ProductUserIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, nameof (m_ProductUserIdCount));
    QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100671886);
    QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_DEPRECATED_Public_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100671887);
    QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_ProductUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100671888);
    QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryProductUserIdMappingsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100671889);
    QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100671890);
    QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, 100671891);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397681, XrefRangeEnd = 397685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType AccountIdType_DEPRECATED
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_AccountIdType_DEPRECATED_Public_set_Void_ExternalAccountType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> ProductUserIds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 397691, RefRangeEnd = 397693, XrefRangeStart = 397685, XrefRangeEnd = 397691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_set_ProductUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397693, XrefRangeEnd = 397698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryProductUserIdMappingsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryProductUserIdMappingsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397698, XrefRangeEnd = 397705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397705, XrefRangeEnd = 397710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryProductUserIdMappingsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryProductUserIdMappingsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
