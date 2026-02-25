// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.QueryIdTokenOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

[StructLayout(LayoutKind.Explicit)]
public struct QueryIdTokenOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetAccountId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetAccountId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_QueryIdTokenOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_TargetAccountId;

  static QueryIdTokenOptionsInternal()
  {
    Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (QueryIdTokenOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr);
    QueryIdTokenOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    QueryIdTokenOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    QueryIdTokenOptionsInternal.NativeFieldInfoPtr_m_TargetAccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, nameof (m_TargetAccountId));
    QueryIdTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, 100672323);
    QueryIdTokenOptionsInternal.NativeMethodInfoPtr_set_TargetAccountId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, 100672324);
    QueryIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryIdTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, 100672325);
    QueryIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, 100672326);
    QueryIdTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, 100672327);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399097, XrefRangeEnd = 399101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryIdTokenOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId TargetAccountId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399101, XrefRangeEnd = 399105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QueryIdTokenOptionsInternal.NativeMethodInfoPtr_set_TargetAccountId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 399113, RefRangeEnd = 399114, XrefRangeStart = 399105, XrefRangeEnd = 399113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(QueryIdTokenOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_QueryIdTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399114, XrefRangeEnd = 399117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399117, XrefRangeEnd = 399122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QueryIdTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryIdTokenOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
