// Decompiled with JetBrains decompiler
// Type: JohnGambleCreations.DevPaletteEntry
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace JohnGambleCreations;

[Serializable]
public class DevPaletteEntry(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_obj;
  private static readonly System.IntPtr NativeFieldInfoPtr_isLocked;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

  static DevPaletteEntry()
  {
    Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "JohnGambleCreations", nameof (DevPaletteEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr);
    DevPaletteEntry.NativeFieldInfoPtr_obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr, nameof (obj));
    DevPaletteEntry.NativeFieldInfoPtr_isLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr, nameof (isLocked));
    DevPaletteEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr, 100673658);
    DevPaletteEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr, 100673659);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DevPaletteEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPaletteEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DevPaletteEntry(UnityEngine.Object obj)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DevPaletteEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DevPaletteEntry.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UnityEngine.Object obj
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DevPaletteEntry.NativeFieldInfoPtr_obj));
      return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DevPaletteEntry.NativeFieldInfoPtr_obj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isLocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DevPaletteEntry.NativeFieldInfoPtr_isLocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DevPaletteEntry.NativeFieldInfoPtr_isLocked)) = value;
    }
  }
}
