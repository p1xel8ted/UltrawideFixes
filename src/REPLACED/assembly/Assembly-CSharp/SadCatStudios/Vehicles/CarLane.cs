// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.CarLane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Vehicles;

public class CarLane(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Lane;
  private static readonly System.IntPtr NativeFieldInfoPtr_RoadStartPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_RoadCrossingPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_RoadInclinePoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_RoadEndPoint;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopLaneAtCrossing_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartLane_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AllCarsStopped_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeFromPuzzle_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CarLane()
  {
    Il2CppClassPointerStore<CarLane>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (CarLane));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarLane>.NativeClassPtr);
    CarLane.NativeFieldInfoPtr_Lane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane>.NativeClassPtr, nameof (Lane));
    CarLane.NativeFieldInfoPtr_RoadStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane>.NativeClassPtr, nameof (RoadStartPoint));
    CarLane.NativeFieldInfoPtr_RoadCrossingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane>.NativeClassPtr, nameof (RoadCrossingPoint));
    CarLane.NativeFieldInfoPtr_RoadInclinePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane>.NativeClassPtr, nameof (RoadInclinePoint));
    CarLane.NativeFieldInfoPtr_RoadEndPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane>.NativeClassPtr, nameof (RoadEndPoint));
    CarLane.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672972);
    CarLane.NativeMethodInfoPtr_Sort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672973);
    CarLane.NativeMethodInfoPtr_StopLaneAtCrossing_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672974);
    CarLane.NativeMethodInfoPtr_StartLane_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672975);
    CarLane.NativeMethodInfoPtr_AllCarsStopped_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672976);
    CarLane.NativeMethodInfoPtr_InitializeFromPuzzle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672977);
    CarLane.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane>.NativeClassPtr, 100672978);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105238, XrefRangeEnd = 105239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105255, RefRangeEnd = 105256, XrefRangeStart = 105239, XrefRangeEnd = 105255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Sort()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr_Sort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105257, RefRangeEnd = 105258, XrefRangeStart = 105256, XrefRangeEnd = 105257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopLaneAtCrossing()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr_StopLaneAtCrossing_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105259, RefRangeEnd = 105260, XrefRangeStart = 105258, XrefRangeEnd = 105259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartLane()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr_StartLane_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105262, RefRangeEnd = 105263, XrefRangeStart = 105260, XrefRangeEnd = 105262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AllCarsStopped()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr_AllCarsStopped_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105277, RefRangeEnd = 105278, XrefRangeStart = 105263, XrefRangeEnd = 105277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeFromPuzzle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr_InitializeFromPuzzle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CarLane()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarLane>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarLane.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CarMovementController> Lane
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_Lane));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CarMovementController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CarMovementController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_Lane), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 RoadStartPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadStartPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadStartPoint)) = value;
    }
  }

  public unsafe Vector3 RoadCrossingPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadCrossingPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadCrossingPoint)) = value;
    }
  }

  public unsafe Vector3 RoadInclinePoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadInclinePoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadInclinePoint)) = value;
    }
  }

  public unsafe Vector3 RoadEndPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadEndPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarLane.NativeFieldInfoPtr_RoadEndPoint)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Vehicles.CarLane+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Sort_b__6_0_Internal_Int32_CarMovementController_CarMovementController_0;

    static __c()
    {
      Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CarLane>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr);
      CarLane.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr, "<>9");
      CarLane.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr, "<>9__6_0");
      CarLane.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr, 100672980);
      CarLane.__c.NativeMethodInfoPtr__Sort_b__6_0_Internal_Int32_CarMovementController_CarMovementController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr, 100672981);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarLane.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CarLane.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105233, XrefRangeEnd = 105238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Sort_b__6_0(CarMovementController a, CarMovementController b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarLane.__c.NativeMethodInfoPtr__Sort_b__6_0_Internal_Int32_CarMovementController_CarMovementController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CarLane.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CarLane.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CarLane.__c) null : Il2CppObjectPool.Get<CarLane.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CarLane.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<CarMovementController> __9__6_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CarLane.__c.NativeFieldInfoPtr___9__6_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<CarMovementController>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<CarMovementController>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CarLane.__c.NativeFieldInfoPtr___9__6_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
