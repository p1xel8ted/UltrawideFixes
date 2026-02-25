// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.DefinitionV2
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

public class DefinitionV2(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AchievementId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedDisplayName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedDescription_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LockedDisplayName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LockedDescription_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__FlavorText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UnlockedIconURL_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LockedIconURL_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsHidden_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__StatThresholds_k__BackingField;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_DefinitionV2Internal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefinitionV2()
  {
    Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (DefinitionV2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr);
    DefinitionV2.NativeFieldInfoPtr__AchievementId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<AchievementId>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__UnlockedDisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<UnlockedDisplayName>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__UnlockedDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<UnlockedDescription>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__LockedDisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<LockedDisplayName>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__LockedDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<LockedDescription>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__FlavorText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<FlavorText>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__UnlockedIconURL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<UnlockedIconURL>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__LockedIconURL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<LockedIconURL>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__IsHidden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<IsHidden>k__BackingField");
    DefinitionV2.NativeFieldInfoPtr__StatThresholds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, "<StatThresholds>k__BackingField");
    DefinitionV2.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673344);
    DefinitionV2.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673345);
    DefinitionV2.NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673346);
    DefinitionV2.NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673347);
    DefinitionV2.NativeMethodInfoPtr_get_UnlockedDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673348);
    DefinitionV2.NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673349);
    DefinitionV2.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673350);
    DefinitionV2.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673351);
    DefinitionV2.NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673352);
    DefinitionV2.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673353);
    DefinitionV2.NativeMethodInfoPtr_get_FlavorText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673354);
    DefinitionV2.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673355);
    DefinitionV2.NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673356);
    DefinitionV2.NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673357);
    DefinitionV2.NativeMethodInfoPtr_get_LockedIconURL_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673358);
    DefinitionV2.NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673359);
    DefinitionV2.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673360);
    DefinitionV2.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673361);
    DefinitionV2.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673362);
    DefinitionV2.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673363);
    DefinitionV2.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_DefinitionV2Internal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673364);
    DefinitionV2.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673365);
    DefinitionV2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr, 100673366);
  }

  public unsafe string AchievementId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedDisplayName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_UnlockedDisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_UnlockedDisplayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedDescription
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_UnlockedDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_UnlockedDescription_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedDisplayName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_LockedDisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_LockedDisplayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedDescription
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_LockedDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_LockedDescription_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string FlavorText
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_FlavorText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_FlavorText_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string UnlockedIconURL
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_UnlockedIconURL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_UnlockedIconURL_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LockedIconURL
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_LockedIconURL_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_LockedIconURL_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsHidden
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_IsHidden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_IsHidden_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds> StatThresholds
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_get_StatThresholds_Public_get_Il2CppReferenceArray_1_StatThresholds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>>(num3);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_set_StatThresholds_Public_set_Void_Il2CppReferenceArray_1_StatThresholds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 402185, RefRangeEnd = 402186, XrefRangeStart = 402121, XrefRangeEnd = 402185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<DefinitionV2Internal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_DefinitionV2Internal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402186, XrefRangeEnd = 402191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefinitionV2()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefinitionV2>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefinitionV2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _AchievementId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__AchievementId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__AchievementId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _UnlockedDisplayName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__UnlockedDisplayName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__UnlockedDisplayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _UnlockedDescription_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__UnlockedDescription_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__UnlockedDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _LockedDisplayName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__LockedDisplayName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__LockedDisplayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _LockedDescription_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__LockedDescription_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__LockedDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _FlavorText_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__FlavorText_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__FlavorText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _UnlockedIconURL_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__UnlockedIconURL_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__UnlockedIconURL_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _LockedIconURL_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__LockedIconURL_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__LockedIconURL_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _IsHidden_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__IsHidden_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__IsHidden_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds> _StatThresholds_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__StatThresholds_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.Achievements.StatThresholds>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefinitionV2.NativeFieldInfoPtr__StatThresholds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
