// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.ModIdentifierInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods;

[StructLayout(LayoutKind.Explicit)]
public struct ModIdentifierInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NamespaceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ItemId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ArtifactId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Title;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NamespaceId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NamespaceId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArtifactId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArtifactId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Title_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_NamespaceId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ItemId;
  [FieldOffset(24)]
  public System.IntPtr m_ArtifactId;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_Title;
  [FieldOffset(40)]
  public System.IntPtr m_Version;

  static ModIdentifierInternal()
  {
    Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (ModIdentifierInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr);
    ModIdentifierInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ModIdentifierInternal.NativeFieldInfoPtr_m_NamespaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, nameof (m_NamespaceId));
    ModIdentifierInternal.NativeFieldInfoPtr_m_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, nameof (m_ItemId));
    ModIdentifierInternal.NativeFieldInfoPtr_m_ArtifactId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, nameof (m_ArtifactId));
    ModIdentifierInternal.NativeFieldInfoPtr_m_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, nameof (m_Title));
    ModIdentifierInternal.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, nameof (m_Version));
    ModIdentifierInternal.NativeMethodInfoPtr_get_NamespaceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668625);
    ModIdentifierInternal.NativeMethodInfoPtr_set_NamespaceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668626);
    ModIdentifierInternal.NativeMethodInfoPtr_get_ItemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668627);
    ModIdentifierInternal.NativeMethodInfoPtr_set_ItemId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668628);
    ModIdentifierInternal.NativeMethodInfoPtr_get_ArtifactId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668629);
    ModIdentifierInternal.NativeMethodInfoPtr_set_ArtifactId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668630);
    ModIdentifierInternal.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668631);
    ModIdentifierInternal.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668632);
    ModIdentifierInternal.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668633);
    ModIdentifierInternal.NativeMethodInfoPtr_set_Version_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668634);
    ModIdentifierInternal.NativeMethodInfoPtr_Set_Public_Void_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668635);
    ModIdentifierInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668636);
    ModIdentifierInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, 100668637);
  }

  public unsafe string NamespaceId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387501, XrefRangeEnd = 387505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_get_NamespaceId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387505, XrefRangeEnd = 387509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_set_NamespaceId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ItemId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387509, XrefRangeEnd = 387513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_get_ItemId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387513, XrefRangeEnd = 387517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_set_ItemId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ArtifactId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387517, XrefRangeEnd = 387521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_get_ArtifactId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387521, XrefRangeEnd = 387525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_set_ArtifactId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Title
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387525, XrefRangeEnd = 387529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_get_Title_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387529, XrefRangeEnd = 387533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_set_Title_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Version
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387533, XrefRangeEnd = 387537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_get_Version_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387537, XrefRangeEnd = 387541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_set_Version_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 387561, RefRangeEnd = 387562, XrefRangeStart = 387541, XrefRangeEnd = 387561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ModIdentifier other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_Set_Public_Void_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387562, XrefRangeEnd = 387565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387565, XrefRangeEnd = 387573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModIdentifierInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModIdentifierInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
