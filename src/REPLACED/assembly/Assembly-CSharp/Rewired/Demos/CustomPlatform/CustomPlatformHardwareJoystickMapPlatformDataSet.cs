// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.CustomPlatformHardwareJoystickMapPlatformDataSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.Platforms.Custom;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

[Serializable]
public class CustomPlatformHardwareJoystickMapPlatformDataSet(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_platformMaps;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CustomPlatformHardwareJoystickMapPlatformDataSet()
  {
    Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapPlatformDataSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (CustomPlatformHardwareJoystickMapPlatformDataSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapPlatformDataSet>.NativeClassPtr);
    CustomPlatformHardwareJoystickMapPlatformDataSet.NativeFieldInfoPtr_platformMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapPlatformDataSet>.NativeClassPtr, nameof (platformMaps));
    CustomPlatformHardwareJoystickMapPlatformDataSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapPlatformDataSet>.NativeClassPtr, 100670504);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomPlatformHardwareJoystickMapPlatformDataSet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomPlatformHardwareJoystickMapPlatformDataSet>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomPlatformHardwareJoystickMapPlatformDataSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<HardwareJoystickMapCustomPlatformMapSO> platformMaps
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapPlatformDataSet.NativeFieldInfoPtr_platformMaps));
      return num == IntPtr.Zero ? (List<HardwareJoystickMapCustomPlatformMapSO>) null : Il2CppObjectPool.Get<List<HardwareJoystickMapCustomPlatformMapSO>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformHardwareJoystickMapPlatformDataSet.NativeFieldInfoPtr_platformMaps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
