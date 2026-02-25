// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.CustomPlatformHardwareJoystickMapProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.Data.Mapping;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

[Serializable]
public class CustomPlatformHardwareJoystickMapProvider(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_platformJoystickDataSets;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformMap_Public_Virtual_Final_New_Platform_Int32_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformDataSet_Private_CustomPlatformHardwareJoystickMapPlatformDataSet_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformMap_Private_Static_Platform_CustomPlatformHardwareJoystickMapPlatformDataSet_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CustomPlatformHardwareJoystickMapProvider()
  {
    Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (CustomPlatformHardwareJoystickMapProvider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr);
    CustomPlatformHardwareJoystickMapProvider.NativeFieldInfoPtr_platformJoystickDataSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr, nameof (platformJoystickDataSets));
    CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr_GetPlatformMap_Public_Virtual_Final_New_Platform_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr, 100670505);
    CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr_GetPlatformDataSet_Private_CustomPlatformHardwareJoystickMapPlatformDataSet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr, 100670506);
    CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr_GetPlatformMap_Private_Static_Platform_CustomPlatformHardwareJoystickMapPlatformDataSet_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr, 100670507);
    CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr, 100670508);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85485, XrefRangeEnd = 85514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe HardwareJoystickMap.Platform GetPlatformMap(
    int customPlatformId,
    Il2CppSystem.Guid hardwareTypeGuid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &customPlatformId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hardwareTypeGuid;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr_GetPlatformMap_Public_Virtual_Final_New_Platform_Int32_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (HardwareJoystickMap.Platform) null : Il2CppObjectPool.Get<HardwareJoystickMap.Platform>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85514, XrefRangeEnd = 85520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomPlatformHardwareJoystickMapPlatformDataSet GetPlatformDataSet(
    int customPlatformId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &customPlatformId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr_GetPlatformDataSet_Private_CustomPlatformHardwareJoystickMapPlatformDataSet_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (CustomPlatformHardwareJoystickMapPlatformDataSet) null : Il2CppObjectPool.Get<CustomPlatformHardwareJoystickMapPlatformDataSet>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85520, XrefRangeEnd = 85533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe HardwareJoystickMap.Platform GetPlatformMap(
    CustomPlatformHardwareJoystickMapPlatformDataSet platformDataSet,
    Il2CppSystem.Guid hardwareTypeGuid)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) platformDataSet);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hardwareTypeGuid;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr_GetPlatformMap_Private_Static_Platform_CustomPlatformHardwareJoystickMapPlatformDataSet_Guid_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (HardwareJoystickMap.Platform) null : Il2CppObjectPool.Get<HardwareJoystickMap.Platform>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomPlatformHardwareJoystickMapProvider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomPlatformHardwareJoystickMapProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet> platformJoystickDataSets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapProvider.NativeFieldInfoPtr_platformJoystickDataSets));
      return num == System.IntPtr.Zero ? (List<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>) null : Il2CppObjectPool.Get<List<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapProvider.NativeFieldInfoPtr_platformJoystickDataSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class PlatformDataSet(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_platformType;
    private static readonly System.IntPtr NativeFieldInfoPtr_dataSet;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static PlatformDataSet()
    {
      Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider>.NativeClassPtr, nameof (PlatformDataSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>.NativeClassPtr);
      CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeFieldInfoPtr_platformType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>.NativeClassPtr, nameof (platformType));
      CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeFieldInfoPtr_dataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>.NativeClassPtr, nameof (dataSet));
      CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>.NativeClassPtr, 100670509);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlatformDataSet()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapProvider.PlatformDataSet>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe CustomPlatformType platformType
    {
      get
      {
        return *(CustomPlatformType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeFieldInfoPtr_platformType));
      }
      [param: In] set
      {
        *(CustomPlatformType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeFieldInfoPtr_platformType)) = value;
      }
    }

    public unsafe CustomPlatformHardwareJoystickMapPlatformDataSet dataSet
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeFieldInfoPtr_dataSet));
        return num == System.IntPtr.Zero ? (CustomPlatformHardwareJoystickMapPlatformDataSet) null : Il2CppObjectPool.Get<CustomPlatformHardwareJoystickMapPlatformDataSet>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapProvider.PlatformDataSet.NativeFieldInfoPtr_dataSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
