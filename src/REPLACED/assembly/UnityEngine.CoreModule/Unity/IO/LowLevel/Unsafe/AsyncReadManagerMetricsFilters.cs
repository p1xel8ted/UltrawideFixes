// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetricsFilters
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

public class AsyncReadManagerMetricsFilters(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_TypeIDs;
  private static readonly System.IntPtr NativeFieldInfoPtr_States;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReadTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_PriorityLevels;
  private static readonly System.IntPtr NativeFieldInfoPtr_Subsystems;

  static AsyncReadManagerMetricsFilters()
  {
    Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (AsyncReadManagerMetricsFilters));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr);
    AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, nameof (TypeIDs));
    AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, nameof (States));
    AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, nameof (ReadTypes));
    AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, nameof (PriorityLevels));
    AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerMetricsFilters>.NativeClassPtr, nameof (Subsystems));
  }

  public unsafe Il2CppStructArray<ulong> TypeIDs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ulong>) null : Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_TypeIDs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<ProcessingState> States
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ProcessingState>) null : Il2CppObjectPool.Get<Il2CppStructArray<ProcessingState>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_States), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<FileReadType> ReadTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<FileReadType>) null : Il2CppObjectPool.Get<Il2CppStructArray<FileReadType>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_ReadTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Priority> PriorityLevels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Priority>) null : Il2CppObjectPool.Get<Il2CppStructArray<Priority>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_PriorityLevels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<AssetLoadingSubsystem> Subsystems
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<AssetLoadingSubsystem>) null : Il2CppObjectPool.Get<Il2CppStructArray<AssetLoadingSubsystem>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerMetricsFilters.NativeFieldInfoPtr_Subsystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public void SetTypeIDFilter(Il2CppStructArray<ulong> _typeIDs) => this.TypeIDs = _typeIDs;

  public void SetStateFilter(Il2CppStructArray<ProcessingState> _states) => this.States = _states;

  public void SetReadTypeFilter(Il2CppStructArray<FileReadType> _readTypes)
  {
    this.ReadTypes = _readTypes;
  }

  public void SetPriorityFilter(Il2CppStructArray<Priority> _priorityLevels)
  {
    this.PriorityLevels = _priorityLevels;
  }

  public void SetSubsystemFilter(
    Il2CppStructArray<AssetLoadingSubsystem> _subsystems)
  {
    this.Subsystems = _subsystems;
  }

  public void SetTypeIDFilter(ulong _typeID)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetStateFilter(ProcessingState _state)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetReadTypeFilter(FileReadType _readType)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetPriorityFilter(Priority _priorityLevel)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void SetSubsystemFilter(AssetLoadingSubsystem _subsystem)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void RemoveTypeIDFilter() => this.TypeIDs = (Il2CppStructArray<ulong>) null;

  public void RemoveStateFilter() => this.States = (Il2CppStructArray<ProcessingState>) null;

  public void RemoveReadTypeFilter() => this.ReadTypes = (Il2CppStructArray<FileReadType>) null;

  public void RemovePriorityFilter() => this.PriorityLevels = (Il2CppStructArray<Priority>) null;

  public void RemoveSubsystemFilter()
  {
    this.Subsystems = (Il2CppStructArray<AssetLoadingSubsystem>) null;
  }

  public void ClearFilters()
  {
    this.RemoveTypeIDFilter();
    this.RemoveStateFilter();
    this.RemoveReadTypeFilter();
    this.RemovePriorityFilter();
    this.RemoveSubsystemFilter();
  }
}
