// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.ArmorBreakVariant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Combat;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Character;

[Serializable]
public sealed class ArmorBreakVariant : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_SyncGraphs;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArmorBreak;

  static ArmorBreakVariant()
  {
    Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (ArmorBreakVariant));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr);
    ArmorBreakVariant.NativeFieldInfoPtr_SyncGraphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr, nameof (SyncGraphs));
    ArmorBreakVariant.NativeFieldInfoPtr_ArmorBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr, nameof (ArmorBreak));
  }

  public ArmorBreakVariant(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ArmorBreakVariant()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArmorBreakVariant>.NativeClassPtr))
  {
  }

  public unsafe FinisherVariant SyncGraphs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorBreakVariant.NativeFieldInfoPtr_SyncGraphs));
      return num == System.IntPtr.Zero ? (FinisherVariant) null : Il2CppObjectPool.Get<FinisherVariant>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorBreakVariant.NativeFieldInfoPtr_SyncGraphs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference ArmorBreak
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorBreakVariant.NativeFieldInfoPtr_ArmorBreak));
      return num == System.IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorBreakVariant.NativeFieldInfoPtr_ArmorBreak), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
