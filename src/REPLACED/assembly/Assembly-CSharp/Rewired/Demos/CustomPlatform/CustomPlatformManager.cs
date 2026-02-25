// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.CustomPlatformManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired.Platforms.Custom;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public sealed class CustomPlatformManager(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mapProvider;
  private static readonly IntPtr NativeMethodInfoPtr_GetCustomPlatformInitOptions_Public_Virtual_Final_New_CustomPlatformInitOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CustomPlatformManager()
  {
    Il2CppClassPointerStore<CustomPlatformManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (CustomPlatformManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomPlatformManager>.NativeClassPtr);
    CustomPlatformManager.NativeFieldInfoPtr_mapProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomPlatformManager>.NativeClassPtr, nameof (mapProvider));
    CustomPlatformManager.NativeMethodInfoPtr_GetCustomPlatformInitOptions_Public_Virtual_Final_New_CustomPlatformInitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformManager>.NativeClassPtr, 100670510);
    CustomPlatformManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomPlatformManager>.NativeClassPtr, 100670511);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85533, XrefRangeEnd = 85579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe CustomPlatformInitOptions GetCustomPlatformInitOptions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomPlatformManager.NativeMethodInfoPtr_GetCustomPlatformInitOptions_Public_Virtual_Final_New_CustomPlatformInitOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (CustomPlatformInitOptions) null : Il2CppObjectPool.Get<CustomPlatformInitOptions>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomPlatformManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomPlatformManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomPlatformManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CustomPlatformHardwareJoystickMapProvider mapProvider
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformManager.NativeFieldInfoPtr_mapProvider));
      return num == IntPtr.Zero ? (CustomPlatformHardwareJoystickMapProvider) null : Il2CppObjectPool.Get<CustomPlatformHardwareJoystickMapProvider>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomPlatformManager.NativeFieldInfoPtr_mapProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
