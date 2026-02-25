// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.Utils.SpecialSavesList
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
namespace Replaced.Scripts.Utils;

public class SpecialSavesList(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SpecialSaves;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpecialSavesList()
  {
    Il2CppClassPointerStore<SpecialSavesList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.Utils", nameof (SpecialSavesList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialSavesList>.NativeClassPtr);
    SpecialSavesList.NativeFieldInfoPtr_SpecialSaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialSavesList>.NativeClassPtr, nameof (SpecialSaves));
    SpecialSavesList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialSavesList>.NativeClassPtr, 100670637);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpecialSavesList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialSavesList>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpecialSavesList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStringArray SpecialSaves
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpecialSavesList.NativeFieldInfoPtr_SpecialSaves));
      return num == IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpecialSavesList.NativeFieldInfoPtr_SpecialSaves), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
