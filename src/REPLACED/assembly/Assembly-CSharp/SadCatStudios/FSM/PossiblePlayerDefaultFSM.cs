// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.PossiblePlayerDefaultFSM
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.FSM;

public class PossiblePlayerDefaultFSM(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_PossibleFSM;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PossiblePlayerDefaultFSM()
  {
    Il2CppClassPointerStore<PossiblePlayerDefaultFSM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (PossiblePlayerDefaultFSM));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossiblePlayerDefaultFSM>.NativeClassPtr);
    PossiblePlayerDefaultFSM.NativeFieldInfoPtr_PossibleFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PossiblePlayerDefaultFSM>.NativeClassPtr, nameof (PossibleFSM));
    PossiblePlayerDefaultFSM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossiblePlayerDefaultFSM>.NativeClassPtr, 100673146);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PossiblePlayerDefaultFSM()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossiblePlayerDefaultFSM>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PossiblePlayerDefaultFSM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PossiblePlayerDefaultFSM.PossibleFSMDict PossibleFSM
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PossiblePlayerDefaultFSM.NativeFieldInfoPtr_PossibleFSM));
      return num == IntPtr.Zero ? (PossiblePlayerDefaultFSM.PossibleFSMDict) null : Il2CppObjectPool.Get<PossiblePlayerDefaultFSM.PossibleFSMDict>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PossiblePlayerDefaultFSM.NativeFieldInfoPtr_PossibleFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class PossibleFSMDict(IntPtr pointer) : UnitySerializedDictionary<string, FSMGraph>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static PossibleFSMDict()
    {
      Il2CppClassPointerStore<PossiblePlayerDefaultFSM.PossibleFSMDict>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PossiblePlayerDefaultFSM>.NativeClassPtr, nameof (PossibleFSMDict));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PossiblePlayerDefaultFSM.PossibleFSMDict>.NativeClassPtr);
      PossiblePlayerDefaultFSM.PossibleFSMDict.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PossiblePlayerDefaultFSM.PossibleFSMDict>.NativeClassPtr, 100673147);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106464, XrefRangeEnd = 106467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PossibleFSMDict()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PossiblePlayerDefaultFSM.PossibleFSMDict>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PossiblePlayerDefaultFSM.PossibleFSMDict.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
