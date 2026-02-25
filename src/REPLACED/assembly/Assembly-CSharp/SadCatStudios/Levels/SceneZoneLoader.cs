// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Levels.SceneZoneLoader
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

#nullable disable
namespace SadCatStudios.Levels;

public class SceneZoneLoader(IntPtr pointer) : LocalSingletonBehaviour<SceneZoneLoader>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_sceneZones;
  private static readonly IntPtr NativeFieldInfoPtr_sceneZoneTimeout;
  private static readonly IntPtr NativeMethodInfoPtr_PlayerZonesLoaded_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SceneZoneLoader()
  {
    Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Levels", nameof (SceneZoneLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr);
    SceneZoneLoader.NativeFieldInfoPtr_sceneZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr, nameof (sceneZones));
    SceneZoneLoader.NativeFieldInfoPtr_sceneZoneTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr, nameof (sceneZoneTimeout));
    SceneZoneLoader.NativeMethodInfoPtr_PlayerZonesLoaded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr, 100671950);
    SceneZoneLoader.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr, 100671951);
    SceneZoneLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr, 100671952);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 96973, RefRangeEnd = 96975, XrefRangeStart = 96969, XrefRangeEnd = 96973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool PlayerZonesLoaded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneZoneLoader.NativeMethodInfoPtr_PlayerZonesLoaded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96975, XrefRangeEnd = 96978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneZoneLoader.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96978, XrefRangeEnd = 96981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneZoneLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneZoneLoader>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneZoneLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<SceneZone> sceneZones
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneZoneLoader.NativeFieldInfoPtr_sceneZones));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<SceneZone>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SceneZone>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneZoneLoader.NativeFieldInfoPtr_sceneZones), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float sceneZoneTimeout
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneZoneLoader.NativeFieldInfoPtr_sceneZoneTimeout));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneZoneLoader.NativeFieldInfoPtr_sceneZoneTimeout)) = value;
    }
  }
}
