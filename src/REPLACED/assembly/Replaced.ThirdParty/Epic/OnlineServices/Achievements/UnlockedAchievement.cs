// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.UnlockedAchievement
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

public class UnlockedAchievement(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AchievementId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UnlockTime_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_UnlockedAchievementInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnlockedAchievement()
  {
    Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (UnlockedAchievement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr);
    UnlockedAchievement.NativeFieldInfoPtr__AchievementId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, "<AchievementId>k__BackingField");
    UnlockedAchievement.NativeFieldInfoPtr__UnlockTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, "<UnlockTime>k__BackingField");
    UnlockedAchievement.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673624);
    UnlockedAchievement.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673625);
    UnlockedAchievement.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673626);
    UnlockedAchievement.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673627);
    UnlockedAchievement.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_UnlockedAchievementInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673628);
    UnlockedAchievement.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673629);
    UnlockedAchievement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr, 100673630);
  }

  public unsafe string AchievementId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr_get_AchievementId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> UnlockTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr_get_UnlockTime_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr_set_UnlockTime_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402991, XrefRangeEnd = 403005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<UnlockedAchievementInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_UnlockedAchievementInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403005, XrefRangeEnd = 403023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnlockedAchievement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnlockedAchievement>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnlockedAchievement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _AchievementId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockedAchievement.NativeFieldInfoPtr__AchievementId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnlockedAchievement.NativeFieldInfoPtr__AchievementId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> _UnlockTime_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockedAchievement.NativeFieldInfoPtr__UnlockTime_k__BackingField);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnlockedAchievement.NativeFieldInfoPtr__UnlockTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
