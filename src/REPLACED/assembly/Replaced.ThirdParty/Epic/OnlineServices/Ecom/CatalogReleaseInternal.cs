// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CatalogReleaseInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

[StructLayout(LayoutKind.Explicit)]
public struct CatalogReleaseInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatibleAppIdCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatibleAppIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatiblePlatformCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompatiblePlatforms;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReleaseNote;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReleaseNote_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CatalogRelease_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_CompatibleAppIdCount;
  [FieldOffset(8)]
  public System.IntPtr m_CompatibleAppIds;
  [FieldOffset(16 /*0x10*/)]
  public uint m_CompatiblePlatformCount;
  [FieldOffset(24)]
  public System.IntPtr m_CompatiblePlatforms;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ReleaseNote;

  static CatalogReleaseInternal()
  {
    Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (CatalogReleaseInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr);
    CatalogReleaseInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatibleAppIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatibleAppIdCount));
    CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatibleAppIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatibleAppIds));
    CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatiblePlatformCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatiblePlatformCount));
    CatalogReleaseInternal.NativeFieldInfoPtr_m_CompatiblePlatforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_CompatiblePlatforms));
    CatalogReleaseInternal.NativeFieldInfoPtr_m_ReleaseNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, nameof (m_ReleaseNote));
    CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670739);
    CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670740);
    CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670741);
    CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670742);
    CatalogReleaseInternal.NativeMethodInfoPtr_get_ReleaseNote_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670743);
    CatalogReleaseInternal.NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670744);
    CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Void_CatalogRelease_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670745);
    CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670746);
    CatalogReleaseInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, 100670747);
  }

  public unsafe Il2CppStringArray CompatibleAppIds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394149, XrefRangeEnd = 394155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatibleAppIds_Public_get_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 394161, RefRangeEnd = 394163, XrefRangeStart = 394155, XrefRangeEnd = 394161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatibleAppIds_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray CompatiblePlatforms
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394163, XrefRangeEnd = 394169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_get_CompatiblePlatforms_Public_get_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 394175, RefRangeEnd = 394177, XrefRangeStart = 394169, XrefRangeEnd = 394175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_set_CompatiblePlatforms_Public_set_Void_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ReleaseNote
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394177, XrefRangeEnd = 394181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_get_ReleaseNote_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394181, XrefRangeEnd = 394185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_set_ReleaseNote_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394185, XrefRangeEnd = 394191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CatalogRelease other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Void_CatalogRelease_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394191, XrefRangeEnd = 394199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394199, XrefRangeEnd = 394205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CatalogReleaseInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CatalogReleaseInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
