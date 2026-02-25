// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.DefinitionV2Internal
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
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct DefinitionV2Internal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FlavorText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedIconURL;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedIconURL;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsHidden;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatThresholdsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatThresholds;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedDescription_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FlavorText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedIconURL_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_DefinitionV2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AchievementId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_UnlockedDisplayName;
  [FieldOffset(24)]
  public System.IntPtr m_UnlockedDescription;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_LockedDisplayName;
  [FieldOffset(40)]
  public System.IntPtr m_LockedDescription;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_FlavorText;
  [FieldOffset(56)]
  public System.IntPtr m_UnlockedIconURL;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_LockedIconURL;
  [FieldOffset(72)]
  public int m_IsHidden;
  [FieldOffset(76)]
  public uint m_StatThresholdsCount;
  [FieldOffset(80 /*0x50*/)]
  public System.IntPtr m_StatThresholds;

  static DefinitionV2Internal()
  {
    Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (DefinitionV2Internal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr);
    DefinitionV2Internal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_ApiVersion));
    DefinitionV2Internal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_AchievementId));
    DefinitionV2Internal.NativeFieldInfoPtr_m_UnlockedDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_UnlockedDisplayName));
    DefinitionV2Internal.NativeFieldInfoPtr_m_UnlockedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_UnlockedDescription));
    DefinitionV2Internal.NativeFieldInfoPtr_m_LockedDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_LockedDisplayName));
    DefinitionV2Internal.NativeFieldInfoPtr_m_LockedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_LockedDescription));
    DefinitionV2Internal.NativeFieldInfoPtr_m_FlavorText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_FlavorText));
    DefinitionV2Internal.NativeFieldInfoPtr_m_UnlockedIconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_UnlockedIconURL));
    DefinitionV2Internal.NativeFieldInfoPtr_m_LockedIconURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_LockedIconURL));
    DefinitionV2Internal.NativeFieldInfoPtr_m_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_IsHidden));
    DefinitionV2Internal.NativeFieldInfoPtr_m_StatThresholdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_StatThresholdsCount));
    DefinitionV2Internal.NativeFieldInfoPtr_m_StatThresholds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, nameof (m_StatThresholds));
    DefinitionV2Internal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673367);
    DefinitionV2Internal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673368);
    DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673369);
    DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673370);
    DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673371);
    DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673372);
    DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673373);
    DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673374);
    DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673375);
    DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673376);
    DefinitionV2Internal.NativeMethodInfoPtr_get_FlavorText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673377);
    DefinitionV2Internal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673378);
    DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673379);
    DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673380);
    DefinitionV2Internal.NativeMethodInfoPtr_get_LockedIconURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673381);
    DefinitionV2Internal.NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673382);
    DefinitionV2Internal.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673383);
    DefinitionV2Internal.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673384);
    DefinitionV2Internal.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673385);
    DefinitionV2Internal.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673386);
    DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Void_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673387);
    DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673388);
    DefinitionV2Internal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, 100673389);
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402191, XrefRangeEnd = 402195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402195, XrefRangeEnd = 402199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedDisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402199, XrefRangeEnd = 402203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402203, XrefRangeEnd = 402207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedDescription
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402207, XrefRangeEnd = 402211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedDescription_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402211, XrefRangeEnd = 402215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedDisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402215, XrefRangeEnd = 402219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402219, XrefRangeEnd = 402223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedDescription
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402223, XrefRangeEnd = 402227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402227, XrefRangeEnd = 402231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string FlavorText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402231, XrefRangeEnd = 402235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_FlavorText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402235, XrefRangeEnd = 402239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedIconURL
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402239, XrefRangeEnd = 402243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402243, XrefRangeEnd = 402247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedIconURL
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402247, XrefRangeEnd = 402251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_LockedIconURL_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402251, XrefRangeEnd = 402255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsHidden
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402255, XrefRangeEnd = 402259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402259, XrefRangeEnd = 402263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds> StatThresholds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402263, XrefRangeEnd = 402269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 402275, RefRangeEnd = 402276, XrefRangeStart = 402269, XrefRangeEnd = 402275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 402313, RefRangeEnd = 402314, XrefRangeStart = 402276, XrefRangeEnd = 402313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(DefinitionV2 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Void_DefinitionV2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402314, XrefRangeEnd = 402317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402317, XrefRangeEnd = 402329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionV2Internal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefinitionV2Internal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
