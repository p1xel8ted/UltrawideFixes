// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.SaveData.PCSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.SaveData;

public class PCSaveData(IntPtr pointer) : BaseSaveData(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_subfolder;
  private static readonly IntPtr NativeFieldInfoPtr_fullSaveDirPathCached;
  private static readonly IntPtr NativeFieldInfoPtr_achievementNameCache;
  private static readonly IntPtr NativeFieldInfoPtr_statNameCache;
  private static readonly IntPtr NativeMethodInfoPtr_get_fullSaveDirPath_Private_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EnsureSaveDirExists_Private_DirectoryInfo_0;
  private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_Il2CppStructArray_1_Byte_0;
  private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Il2CppStructArray_1_Byte_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_ListSavedGames_Public_Virtual_List_1_String_Int32_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Exists_Public_Virtual_Boolean_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Virtual_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Achieve_Public_Virtual_Void_Achievement_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProgressAchievementStat_Public_Virtual_Void_Achievement_AchievementStat_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSystemLanguage_Public_Virtual_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PCSaveData()
  {
    Il2CppClassPointerStore<PCSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.SaveData", nameof (PCSaveData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr);
    PCSaveData.NativeFieldInfoPtr_subfolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, nameof (subfolder));
    PCSaveData.NativeFieldInfoPtr_fullSaveDirPathCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, nameof (fullSaveDirPathCached));
    PCSaveData.NativeFieldInfoPtr_achievementNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, nameof (achievementNameCache));
    PCSaveData.NativeFieldInfoPtr_statNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, nameof (statNameCache));
    PCSaveData.NativeMethodInfoPtr_get_fullSaveDirPath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671441);
    PCSaveData.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671442);
    PCSaveData.NativeMethodInfoPtr_EnsureSaveDirExists_Private_DirectoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671443);
    PCSaveData.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671444);
    PCSaveData.NativeMethodInfoPtr_Read_Public_Virtual_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671445);
    PCSaveData.NativeMethodInfoPtr_ListSavedGames_Public_Virtual_List_1_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671446);
    PCSaveData.NativeMethodInfoPtr_Exists_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671447);
    PCSaveData.NativeMethodInfoPtr_Delete_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671448);
    PCSaveData.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671449);
    PCSaveData.NativeMethodInfoPtr_Achieve_Public_Virtual_Void_Achievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671450);
    PCSaveData.NativeMethodInfoPtr_ProgressAchievementStat_Public_Virtual_Void_Achievement_AchievementStat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671451);
    PCSaveData.NativeMethodInfoPtr_GetSystemLanguage_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671452);
    PCSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr, 100671453);
  }

  public unsafe string fullSaveDirPath
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 94024, RefRangeEnd = 94031, XrefRangeStart = 94004, XrefRangeEnd = 94024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCSaveData.NativeMethodInfoPtr_get_fullSaveDirPath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94031, XrefRangeEnd = 94035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94035, XrefRangeEnd = 94037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DirectoryInfo EnsureSaveDirExists()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCSaveData.NativeMethodInfoPtr_EnsureSaveDirExists_Private_DirectoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (DirectoryInfo) null : Il2CppObjectPool.Get<DirectoryInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94037, XrefRangeEnd = 94049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Write(string saveFileName, Il2CppStructArray<byte> buf)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(saveFileName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buf);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94049, XrefRangeEnd = 94057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppStructArray<byte> Read(string saveFileName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(saveFileName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Read_Public_Virtual_Il2CppStructArray_1_Byte_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94057, XrefRangeEnd = 94076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe List<string> ListSavedGames(
    int maxSavedGames,
    string id,
    string extension)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &maxSavedGames;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(extension);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_ListSavedGames_Public_Virtual_List_1_String_Int32_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94076, XrefRangeEnd = 94082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Exists(string saveFileName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(saveFileName)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Exists_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94082, XrefRangeEnd = 94090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Delete(string saveFileName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(saveFileName)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Delete_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94090, XrefRangeEnd = 94094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Achieve(BaseSaveData.Achievement ach)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &ach
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_Achieve_Public_Virtual_Void_Achievement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94094, XrefRangeEnd = 94101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProgressAchievementStat(
    BaseSaveData.Achievement achievement,
    BaseSaveData.AchievementStat stat,
    int delta,
    int maxValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &achievement;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stat;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &delta;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxValue;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_ProgressAchievementStat_Public_Virtual_Void_Achievement_AchievementStat_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94101, XrefRangeEnd = 94135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string GetSystemLanguage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCSaveData.NativeMethodInfoPtr_GetSystemLanguage_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94135, XrefRangeEnd = 94148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PCSaveData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCSaveData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string subfolder
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(PCSaveData.NativeFieldInfoPtr_subfolder, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PCSaveData.NativeFieldInfoPtr_subfolder, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string fullSaveDirPathCached
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCSaveData.NativeFieldInfoPtr_fullSaveDirPathCached)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCSaveData.NativeFieldInfoPtr_fullSaveDirPathCached), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStringArray achievementNameCache
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCSaveData.NativeFieldInfoPtr_achievementNameCache));
      return num == IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCSaveData.NativeFieldInfoPtr_achievementNameCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray statNameCache
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCSaveData.NativeFieldInfoPtr_statNameCache));
      return num == IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCSaveData.NativeFieldInfoPtr_statNameCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
