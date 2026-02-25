// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Levels.SaveInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Levels;

[Serializable]
public class SaveInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_GlobalSaveInfo;
  private static readonly System.IntPtr NativeFieldInfoPtr_LevelSaveInfo;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveToJson_Public_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SaveInfo()
  {
    Il2CppClassPointerStore<SaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Levels", nameof (SaveInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr);
    SaveInfo.NativeFieldInfoPtr_GlobalSaveInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, nameof (GlobalSaveInfo));
    SaveInfo.NativeFieldInfoPtr_LevelSaveInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, nameof (LevelSaveInfo));
    SaveInfo.NativeMethodInfoPtr_SaveToJson_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100671894);
    SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100671895);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96834, XrefRangeEnd = 96835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string SaveToJson()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SaveInfo.NativeMethodInfoPtr_SaveToJson_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SaveInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GlobalSaveInfo GlobalSaveInfo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_GlobalSaveInfo));
      return num == System.IntPtr.Zero ? (GlobalSaveInfo) null : Il2CppObjectPool.Get<GlobalSaveInfo>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_GlobalSaveInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SadCatStudios.Levels.LevelSaveInfo> LevelSaveInfo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_LevelSaveInfo));
      return num == System.IntPtr.Zero ? (List<SadCatStudios.Levels.LevelSaveInfo>) null : Il2CppObjectPool.Get<List<SadCatStudios.Levels.LevelSaveInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_LevelSaveInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
