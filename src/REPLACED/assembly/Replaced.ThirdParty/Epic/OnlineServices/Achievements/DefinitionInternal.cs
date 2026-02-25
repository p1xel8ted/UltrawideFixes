// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.DefinitionInternal
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
public struct DefinitionInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Description;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HiddenDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompletionDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnlockedIconId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LockedIconId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsHidden;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatThresholdsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StatThresholds;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HiddenDescription_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HiddenDescription_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CompletionDescription_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CompletionDescription_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockedIconId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockedIconId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LockedIconId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LockedIconId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Definition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AchievementId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_DisplayName;
  [FieldOffset(24)]
  public System.IntPtr m_Description;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_LockedDisplayName;
  [FieldOffset(40)]
  public System.IntPtr m_LockedDescription;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_HiddenDescription;
  [FieldOffset(56)]
  public System.IntPtr m_CompletionDescription;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_UnlockedIconId;
  [FieldOffset(72)]
  public System.IntPtr m_LockedIconId;
  [FieldOffset(80 /*0x50*/)]
  public int m_IsHidden;
  [FieldOffset(84)]
  public int m_StatThresholdsCount;
  [FieldOffset(88)]
  public System.IntPtr m_StatThresholds;

  static DefinitionInternal()
  {
    Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (DefinitionInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr);
    DefinitionInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_ApiVersion));
    DefinitionInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_AchievementId));
    DefinitionInternal.NativeFieldInfoPtr_m_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_DisplayName));
    DefinitionInternal.NativeFieldInfoPtr_m_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_Description));
    DefinitionInternal.NativeFieldInfoPtr_m_LockedDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_LockedDisplayName));
    DefinitionInternal.NativeFieldInfoPtr_m_LockedDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_LockedDescription));
    DefinitionInternal.NativeFieldInfoPtr_m_HiddenDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_HiddenDescription));
    DefinitionInternal.NativeFieldInfoPtr_m_CompletionDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_CompletionDescription));
    DefinitionInternal.NativeFieldInfoPtr_m_UnlockedIconId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_UnlockedIconId));
    DefinitionInternal.NativeFieldInfoPtr_m_LockedIconId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_LockedIconId));
    DefinitionInternal.NativeFieldInfoPtr_m_IsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_IsHidden));
    DefinitionInternal.NativeFieldInfoPtr_m_StatThresholdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_StatThresholdsCount));
    DefinitionInternal.NativeFieldInfoPtr_m_StatThresholds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, nameof (m_StatThresholds));
    DefinitionInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673319);
    DefinitionInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673320);
    DefinitionInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673321);
    DefinitionInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673322);
    DefinitionInternal.NativeMethodInfoPtr_get_Description_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673323);
    DefinitionInternal.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673324);
    DefinitionInternal.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673325);
    DefinitionInternal.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673326);
    DefinitionInternal.NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673327);
    DefinitionInternal.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673328);
    DefinitionInternal.NativeMethodInfoPtr_get_HiddenDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673329);
    DefinitionInternal.NativeMethodInfoPtr_set_HiddenDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673330);
    DefinitionInternal.NativeMethodInfoPtr_get_CompletionDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673331);
    DefinitionInternal.NativeMethodInfoPtr_set_CompletionDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673332);
    DefinitionInternal.NativeMethodInfoPtr_get_UnlockedIconId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673333);
    DefinitionInternal.NativeMethodInfoPtr_set_UnlockedIconId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673334);
    DefinitionInternal.NativeMethodInfoPtr_get_LockedIconId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673335);
    DefinitionInternal.NativeMethodInfoPtr_set_LockedIconId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673336);
    DefinitionInternal.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673337);
    DefinitionInternal.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673338);
    DefinitionInternal.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673339);
    DefinitionInternal.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673340);
    DefinitionInternal.NativeMethodInfoPtr_Set_Public_Void_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673341);
    DefinitionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673342);
    DefinitionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, 100673343);
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401970, XrefRangeEnd = 401974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401974, XrefRangeEnd = 401978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401978, XrefRangeEnd = 401982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401982, XrefRangeEnd = 401986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_DisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Description
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401986, XrefRangeEnd = 401990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_Description_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401990, XrefRangeEnd = 401994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_Description_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedDisplayName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401994, XrefRangeEnd = 401998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401998, XrefRangeEnd = 402002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedDescription
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402002, XrefRangeEnd = 402006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402006, XrefRangeEnd = 402010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string HiddenDescription
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402010, XrefRangeEnd = 402014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_HiddenDescription_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402014, XrefRangeEnd = 402018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_HiddenDescription_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CompletionDescription
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402018, XrefRangeEnd = 402022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_CompletionDescription_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402022, XrefRangeEnd = 402026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_CompletionDescription_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedIconId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402026, XrefRangeEnd = 402030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_UnlockedIconId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402030, XrefRangeEnd = 402034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_UnlockedIconId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedIconId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402034, XrefRangeEnd = 402038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_LockedIconId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402038, XrefRangeEnd = 402042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_LockedIconId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsHidden
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402042, XrefRangeEnd = 402046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402046, XrefRangeEnd = 402050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds> StatThresholds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402050, XrefRangeEnd = 402056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 402062, RefRangeEnd = 402063, XrefRangeStart = 402056, XrefRangeEnd = 402062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 402104, RefRangeEnd = 402105, XrefRangeStart = 402063, XrefRangeEnd = 402104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Definition other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_Set_Public_Void_Definition_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402105, XrefRangeEnd = 402108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402108, XrefRangeEnd = 402121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DefinitionInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
