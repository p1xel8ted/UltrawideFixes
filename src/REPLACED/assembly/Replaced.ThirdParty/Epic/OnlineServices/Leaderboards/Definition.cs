// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.Definition
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

public class Definition(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LeaderboardId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__StatName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Aggregation_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__StartTime_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EndTime_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_DefinitionInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Definition()
  {
    Il2CppClassPointerStore<Definition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (Definition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Definition>.NativeClassPtr);
    Definition.NativeFieldInfoPtr__LeaderboardId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Definition>.NativeClassPtr, "<LeaderboardId>k__BackingField");
    Definition.NativeFieldInfoPtr__StatName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Definition>.NativeClassPtr, "<StatName>k__BackingField");
    Definition.NativeFieldInfoPtr__Aggregation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Definition>.NativeClassPtr, "<Aggregation>k__BackingField");
    Definition.NativeFieldInfoPtr__StartTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Definition>.NativeClassPtr, "<StartTime>k__BackingField");
    Definition.NativeFieldInfoPtr__EndTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Definition>.NativeClassPtr, "<EndTime>k__BackingField");
    Definition.NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669932);
    Definition.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669933);
    Definition.NativeMethodInfoPtr_get_StatName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669934);
    Definition.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669935);
    Definition.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669936);
    Definition.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669937);
    Definition.NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669938);
    Definition.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669939);
    Definition.NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669940);
    Definition.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669941);
    Definition.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_DefinitionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669942);
    Definition.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669943);
    Definition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Definition>.NativeClassPtr, 100669944);
  }

  public unsafe string LeaderboardId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_get_LeaderboardId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_set_LeaderboardId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string StatName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_get_StatName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_set_StatName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LeaderboardAggregation Aggregation
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_get_Aggregation_Public_get_LeaderboardAggregation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LeaderboardAggregation*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_set_Aggregation_Public_set_Void_LeaderboardAggregation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> StartTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_get_StartTime_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_set_StartTime_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> EndTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_get_EndTime_Public_get_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_set_EndTime_Public_set_Void_Nullable_1_DateTimeOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 391677, RefRangeEnd = 391678, XrefRangeStart = 391649, XrefRangeEnd = 391677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<DefinitionInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_DefinitionInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391678, XrefRangeEnd = 391683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Definition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Definition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Definition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _LeaderboardId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__LeaderboardId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__LeaderboardId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _StatName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__StatName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__StatName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe LeaderboardAggregation _Aggregation_k__BackingField
  {
    get
    {
      return *(LeaderboardAggregation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__Aggregation_k__BackingField));
    }
    [param: In] set
    {
      *(LeaderboardAggregation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__Aggregation_k__BackingField)) = value;
    }
  }

  public Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> _StartTime_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__StartTime_k__BackingField);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__StartTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset> _EndTime_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__EndTime_k__BackingField);
      return new Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Definition.NativeFieldInfoPtr__EndTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTimeOffset>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
