// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.CheckoutOptionsInternal
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
public struct CheckoutOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideCatalogNamespace;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EntryCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Entries;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideCatalogNamespace_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Entries_Public_set_Void_Il2CppReferenceArray_1_CheckoutEntry_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CheckoutOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_OverrideCatalogNamespace;
  [FieldOffset(24)]
  public uint m_EntryCount;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_Entries;

  static CheckoutOptionsInternal()
  {
    Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (CheckoutOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr);
    CheckoutOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CheckoutOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CheckoutOptionsInternal.NativeFieldInfoPtr_m_OverrideCatalogNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_OverrideCatalogNamespace));
    CheckoutOptionsInternal.NativeFieldInfoPtr_m_EntryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_EntryCount));
    CheckoutOptionsInternal.NativeFieldInfoPtr_m_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, nameof (m_Entries));
    CheckoutOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100670782);
    CheckoutOptionsInternal.NativeMethodInfoPtr_set_OverrideCatalogNamespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100670783);
    CheckoutOptionsInternal.NativeMethodInfoPtr_set_Entries_Public_set_Void_Il2CppReferenceArray_1_CheckoutEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100670784);
    CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CheckoutOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100670785);
    CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100670786);
    CheckoutOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, 100670787);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394318, XrefRangeEnd = 394322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string OverrideCatalogNamespace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394322, XrefRangeEnd = 394326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_set_OverrideCatalogNamespace_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<CheckoutEntry> Entries
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 394332, RefRangeEnd = 394333, XrefRangeStart = 394326, XrefRangeEnd = 394332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_set_Entries_Public_set_Void_Il2CppReferenceArray_1_CheckoutEntry_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 394342, RefRangeEnd = 394343, XrefRangeStart = 394333, XrefRangeEnd = 394342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CheckoutOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CheckoutOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 394346, RefRangeEnd = 394347, XrefRangeStart = 394343, XrefRangeEnd = 394346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 394347, XrefRangeEnd = 394353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CheckoutOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckoutOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
