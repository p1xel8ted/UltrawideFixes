// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.SaveData.BaseSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.SaveData;

public class BaseSaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
  private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ListSavedGames_Public_Abstract_Virtual_New_List_1_String_Int32_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Abstract_Virtual_New_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Abstract_Virtual_New_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Achieve_Public_Virtual_New_Void_Achievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressAchievementStat_Public_Virtual_New_Void_Achievement_AchievementStat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSystemLanguage_Public_Virtual_New_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveDataReady_Public_Virtual_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static BaseSaveData()
  {
    Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.SaveData", nameof (BaseSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr);
    BaseSaveData.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, nameof (Initialized));
    BaseSaveData.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671428);
    BaseSaveData.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671429);
    BaseSaveData.NativeMethodInfoPtr_ListSavedGames_Public_Abstract_Virtual_New_List_1_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671430);
    BaseSaveData.NativeMethodInfoPtr_Exists_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671431);
    BaseSaveData.NativeMethodInfoPtr_Delete_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671432);
    BaseSaveData.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671433);
    BaseSaveData.NativeMethodInfoPtr_Achieve_Public_Virtual_New_Void_Achievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671434);
    BaseSaveData.NativeMethodInfoPtr_ProgressAchievementStat_Public_Virtual_New_Void_Achievement_AchievementStat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671435);
    BaseSaveData.NativeMethodInfoPtr_GetSystemLanguage_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671436);
    BaseSaveData.NativeMethodInfoPtr_SaveDataReady_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671437);
    BaseSaveData.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671438);
    BaseSaveData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr, 100671439);
  }

  [CallerCount(0)]
  public virtual unsafe void Write(string slot, Il2CppStructArray<byte> buf)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(slot);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buf);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_String_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppStructArray<byte> Read(string saveFileName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(saveFileName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe List<string> ListSavedGames(int maxSaveFiles, string id, string extension)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &maxSaveFiles;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(extension);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_ListSavedGames_Public_Abstract_Virtual_New_List_1_String_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe bool Exists(string slot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(slot)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Exists_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Delete(string saveFileName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(saveFileName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Delete_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 93981, RefRangeEnd = 93983, XrefRangeStart = 93981, XrefRangeEnd = 93981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Achieve(BaseSaveData.Achievement ach)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ach
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Achieve_Public_Virtual_New_Void_Achievement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProgressAchievementStat(
    BaseSaveData.Achievement achievement,
    BaseSaveData.AchievementStat stat,
    int delta,
    int maxValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &achievement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_ProgressAchievementStat_Public_Virtual_New_Void_Achievement_AchievementStat_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93983, XrefRangeEnd = 94004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string GetSystemLanguage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_GetSystemLanguage_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool SaveDataReady()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_SaveDataReady_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseSaveData.NativeMethodInfoPtr_Dispose_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseSaveData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseSaveData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool Initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseSaveData.NativeFieldInfoPtr_Initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseSaveData.NativeFieldInfoPtr_Initialized)) = value;
    }
  }

  public enum Achievement
  {
    ACH_PROLOGUE,
    ACH_C1,
    ACH_C2,
    ACH_C3,
    ACH_C4,
    ACH_C5,
    ACH_C6,
    ACH_C7,
    ACH_C8,
    ACH_C9,
    ACH_C10,
    ACH_SUNSHINE,
    ACH_BLOOD,
    ACH_REUNION,
    ACH_GOOD_BOY,
    ACH_HUNTED,
    ACH_BIGGEST_FAN,
    ACH_LOOKALIKE,
    ACH_OLDSCHOOL,
    ACH_SADCATS,
    ACH_HERE_FOR_IT,
    ACH_WORLD_WE_LIVE_IN,
    ACH_REFLEXES,
    ACH_BODY_MACHINE,
    ACH_TOP_GEAR,
    ACH_CYBERNINJA,
    ACH_REFLASHED,
    ACH_FIRSTLAW,
    ACH_ANGER,
    ACH_NOT_W_GUN,
    ACH_CHIP_DAMAGE,
    ACH_BATCH_PROCESSING,
    ACH_WORTH,
    ACH_MUSIC,
  }

  public enum AchievementStat
  {
    STAT_ANGER_MANAGEMENT,
    STAT_BATCH_PROCESSING,
    STAT_BREAKING_THE_FIRST_LAW,
    STAT_CHIP_DAMAGE,
    STAT_CYBERNINJA,
    STAT_NOT_WITH_A_GUN,
  }
}
