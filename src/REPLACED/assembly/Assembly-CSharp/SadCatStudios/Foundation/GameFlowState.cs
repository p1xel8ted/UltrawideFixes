// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.GameFlowState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using SadCatStudios.Foundation.SaveData;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation;

[Serializable]
public class GameFlowState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_extension;
  private static readonly System.IntPtr NativeFieldInfoPtr_backupExtension;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlaceholderId;
  private static readonly System.IntPtr NativeFieldInfoPtr_Global;
  private static readonly System.IntPtr NativeFieldInfoPtr_Local;
  private static readonly System.IntPtr NativeFieldInfoPtr_SelectedSlot;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveDataImplemenentation;
  private static readonly System.IntPtr NativeMethodInfoPtr_SlotForNumber_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveDataImplementation_Public_Static_get_PCSaveData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ListSavedGames_Public_Static_Void_Int32_Promise_1_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSpecialSave_Public_Static_GameFlowState_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadFrom_Public_Static_IEnumerator_String_DataFormat_Promise_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Void_MonoBehaviour_Promise_1_GameFlowState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exists_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveDataReady_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Achieve_Public_Static_Void_Achievement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProgressAchievementStat_Public_Static_Void_Achievement_AchievementStat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GameFlowState()
  {
    Il2CppClassPointerStore<GameFlowState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (GameFlowState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr);
    GameFlowState.NativeFieldInfoPtr_extension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (extension));
    GameFlowState.NativeFieldInfoPtr_backupExtension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (backupExtension));
    GameFlowState.NativeFieldInfoPtr_PlaceholderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (PlaceholderId));
    GameFlowState.NativeFieldInfoPtr_Global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (Global));
    GameFlowState.NativeFieldInfoPtr_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (Local));
    GameFlowState.NativeFieldInfoPtr_SelectedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (SelectedSlot));
    GameFlowState.NativeFieldInfoPtr_saveDataImplemenentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, nameof (saveDataImplemenentation));
    GameFlowState.NativeMethodInfoPtr_SlotForNumber_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671178);
    GameFlowState.NativeMethodInfoPtr_get_SaveDataImplementation_Public_Static_get_PCSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671179);
    GameFlowState.NativeMethodInfoPtr_ListSavedGames_Public_Static_Void_Int32_Promise_1_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671180);
    GameFlowState.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671181);
    GameFlowState.NativeMethodInfoPtr_LoadSpecialSave_Public_Static_GameFlowState_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671182);
    GameFlowState.NativeMethodInfoPtr_LoadFrom_Public_Static_IEnumerator_String_DataFormat_Promise_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671183);
    GameFlowState.NativeMethodInfoPtr_Load_Public_Static_Void_MonoBehaviour_Promise_1_GameFlowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671184);
    GameFlowState.NativeMethodInfoPtr_Exists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671185);
    GameFlowState.NativeMethodInfoPtr_Delete_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671186);
    GameFlowState.NativeMethodInfoPtr_SaveDataReady_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671187);
    GameFlowState.NativeMethodInfoPtr_Achieve_Public_Static_Void_Achievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671188);
    GameFlowState.NativeMethodInfoPtr_ProgressAchievementStat_Public_Static_Void_Achievement_AchievementStat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671189);
    GameFlowState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671190);
    GameFlowState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, 100671191);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91416, RefRangeEnd = 91417, XrefRangeStart = 91409, XrefRangeEnd = 91416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string SlotForNumber(int i)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_SlotForNumber_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static unsafe PCSaveData SaveDataImplementation
  {
    [CallerCount(18), CachedScanResults(RefRangeStart = 91440, RefRangeEnd = 91458, XrefRangeStart = 91417, XrefRangeEnd = 91440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_get_SaveDataImplementation_Public_Static_get_PCSaveData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (PCSaveData) null : Il2CppObjectPool.Get<PCSaveData>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91469, RefRangeEnd = 91470, XrefRangeStart = 91458, XrefRangeEnd = 91469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ListSavedGames(int slotCount, Promise<List<string>> result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &slotCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_ListSavedGames_Public_Static_Void_Int32_Promise_1_List_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91504, RefRangeEnd = 91505, XrefRangeStart = 91470, XrefRangeEnd = 91504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Save()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91533, RefRangeEnd = 91534, XrefRangeStart = 91505, XrefRangeEnd = 91533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameFlowState LoadSpecialSave(string slotFileName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(slotFileName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_LoadSpecialSave_Public_Static_GameFlowState_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameFlowState) null : Il2CppObjectPool.Get<GameFlowState>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 91538, RefRangeEnd = 91540, XrefRangeStart = 91534, XrefRangeEnd = 91538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IEnumerator LoadFrom<T>(
    string slotFileName,
    Sirenix.Serialization.DataFormat dataFormat,
    Promise<T> result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(slotFileName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dataFormat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState.MethodInfoStoreGeneric_LoadFrom_Public_Static_IEnumerator_String_DataFormat_Promise_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91553, RefRangeEnd = 91554, XrefRangeStart = 91540, XrefRangeEnd = 91553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Load(MonoBehaviour coroutineHolder, Promise<GameFlowState> result)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coroutineHolder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_Load_Public_Static_Void_MonoBehaviour_Promise_1_GameFlowState_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91565, RefRangeEnd = 91566, XrefRangeStart = 91554, XrefRangeEnd = 91565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Exists()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_Exists_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 91579, RefRangeEnd = 91581, XrefRangeStart = 91566, XrefRangeEnd = 91579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Delete()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_Delete_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 91586, RefRangeEnd = 91588, XrefRangeStart = 91581, XrefRangeEnd = 91586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SaveDataReady()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_SaveDataReady_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 91593, RefRangeEnd = 91596, XrefRangeStart = 91588, XrefRangeEnd = 91593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Achieve(BaseSaveData.Achievement ach)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ach
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_Achieve_Public_Static_Void_Achievement_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 91600, RefRangeEnd = 91607, XrefRangeStart = 91596, XrefRangeEnd = 91600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ProgressAchievementStat(
    BaseSaveData.Achievement achievement,
    BaseSaveData.AchievementStat stat,
    int delta,
    int maxValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &achievement;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &stat;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_ProgressAchievementStat_Public_Static_Void_Achievement_AchievementStat_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 91612, RefRangeEnd = 91613, XrefRangeStart = 91607, XrefRangeEnd = 91612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91613, XrefRangeEnd = 91630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameFlowState()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string extension
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GameFlowState.NativeFieldInfoPtr_extension, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameFlowState.NativeFieldInfoPtr_extension, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string backupExtension
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GameFlowState.NativeFieldInfoPtr_backupExtension, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameFlowState.NativeFieldInfoPtr_backupExtension, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe string PlaceholderId
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GameFlowState.NativeFieldInfoPtr_PlaceholderId, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameFlowState.NativeFieldInfoPtr_PlaceholderId, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe GlobalFlowState Global
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState.NativeFieldInfoPtr_Global));
      return num == System.IntPtr.Zero ? (GlobalFlowState) null : Il2CppObjectPool.Get<GlobalFlowState>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState.NativeFieldInfoPtr_Global), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalFlowState Local
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState.NativeFieldInfoPtr_Local));
      return num == System.IntPtr.Zero ? (LocalFlowState) null : Il2CppObjectPool.Get<LocalFlowState>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState.NativeFieldInfoPtr_Local), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string SelectedSlot
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(GameFlowState.NativeFieldInfoPtr_SelectedSlot, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameFlowState.NativeFieldInfoPtr_SelectedSlot, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe PCSaveData saveDataImplemenentation
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GameFlowState.NativeFieldInfoPtr_saveDataImplemenentation, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (PCSaveData) null : Il2CppObjectPool.Get<PCSaveData>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GameFlowState.NativeFieldInfoPtr_saveDataImplemenentation, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowState+<LoadFrom>d__13`1")]
  public sealed class _LoadFrom_d__13<T>(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_slotFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_result;
    private static readonly System.IntPtr NativeFieldInfoPtr_dataFormat;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _LoadFrom_d__13()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowState>.NativeClassPtr, "<LoadFrom>d__13`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr);
      GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, "<>1__state");
      GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, "<>2__current");
      GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_slotFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, nameof (slotFileName));
      GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, nameof (result));
      GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_dataFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, nameof (dataFormat));
      GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, 100671193);
      GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, 100671194);
      GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, 100671195);
      GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, 100671196);
      GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, 100671197);
      GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr, 100671198);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _LoadFrom_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowState._LoadFrom_d__13<T>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91375, XrefRangeEnd = 91409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowState._LoadFrom_d__13<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string slotFileName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_slotFileName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_slotFileName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Promise<T> result
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_result));
        return num == System.IntPtr.Zero ? (Promise<T>) null : Il2CppObjectPool.Get<Promise<T>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Sirenix.Serialization.DataFormat dataFormat
    {
      get
      {
        return *(Sirenix.Serialization.DataFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_dataFormat));
      }
      [param: In] set
      {
        *(Sirenix.Serialization.DataFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowState._LoadFrom_d__13<T>.NativeFieldInfoPtr_dataFormat)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_LoadFrom_Public_Static_IEnumerator_String_DataFormat_Promise_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameFlowState.NativeMethodInfoPtr_LoadFrom_Public_Static_IEnumerator_String_DataFormat_Promise_1_T_0, Il2CppClassPointerStore<GameFlowState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
