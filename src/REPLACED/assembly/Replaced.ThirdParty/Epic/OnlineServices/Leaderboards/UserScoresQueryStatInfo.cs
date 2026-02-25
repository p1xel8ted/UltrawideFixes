// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.UserScoresQueryStatInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

public class UserScoresQueryStatInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__StatName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Aggregation_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_UserScoresQueryStatInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UserScoresQueryStatInfo()
  {
    Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (UserScoresQueryStatInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr);
    UserScoresQueryStatInfo.NativeFieldInfoPtr__StatName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, "<StatName>k__BackingField");
    UserScoresQueryStatInfo.NativeFieldInfoPtr__Aggregation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, "<Aggregation>k__BackingField");
    UserScoresQueryStatInfo.NativeMethodInfoPtr_get_StatName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670125);
    UserScoresQueryStatInfo.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670126);
    UserScoresQueryStatInfo.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670127);
    UserScoresQueryStatInfo.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670128);
    UserScoresQueryStatInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_UserScoresQueryStatInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670129);
    UserScoresQueryStatInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670130);
    UserScoresQueryStatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr, 100670131);
  }

  public unsafe string StatName
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_get_StatName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LeaderboardAggregation Aggregation
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LeaderboardAggregation*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392264, XrefRangeEnd = 392274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<UserScoresQueryStatInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_UserScoresQueryStatInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392274, XrefRangeEnd = 392288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UserScoresQueryStatInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UserScoresQueryStatInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UserScoresQueryStatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _StatName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__StatName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__StatName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LeaderboardAggregation _Aggregation_k__BackingField
  {
    get
    {
      return *(LeaderboardAggregation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__Aggregation_k__BackingField));
    }
    [param: In] set
    {
      *(LeaderboardAggregation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UserScoresQueryStatInfo.NativeFieldInfoPtr__Aggregation_k__BackingField)) = value;
    }
  }
}
