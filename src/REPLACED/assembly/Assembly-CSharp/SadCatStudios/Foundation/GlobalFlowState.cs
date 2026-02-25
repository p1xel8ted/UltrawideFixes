// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.GlobalFlowState
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
namespace SadCatStudios.Foundation;

[Serializable]
public class GlobalFlowState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSceneLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_SaveDateTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_Playtime;
  private static readonly System.IntPtr NativeFieldInfoPtr_GlobalVariables;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GlobalFlowState()
  {
    Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (GlobalFlowState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr);
    GlobalFlowState.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr, nameof (Id));
    GlobalFlowState.NativeFieldInfoPtr_CurrentSceneLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr, nameof (CurrentSceneLabel));
    GlobalFlowState.NativeFieldInfoPtr_SaveDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr, nameof (SaveDateTime));
    GlobalFlowState.NativeFieldInfoPtr_Playtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr, nameof (Playtime));
    GlobalFlowState.NativeFieldInfoPtr_GlobalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr, nameof (GlobalVariables));
    GlobalFlowState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr, 100671199);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91630, XrefRangeEnd = 91633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalFlowState()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalFlowState>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalFlowState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string Id
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_Id)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string CurrentSceneLabel
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_CurrentSceneLabel)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_CurrentSceneLabel), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string SaveDateTime
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_SaveDateTime)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_SaveDateTime), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float Playtime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_Playtime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_Playtime)) = value;
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> GlobalVariables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_GlobalVariables));
      return num == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalFlowState.NativeFieldInfoPtr_GlobalVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
