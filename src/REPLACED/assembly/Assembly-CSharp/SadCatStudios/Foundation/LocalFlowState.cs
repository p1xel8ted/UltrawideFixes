// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.LocalFlowState
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
public class LocalFlowState(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_LocalVariables;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalFlowState()
  {
    Il2CppClassPointerStore<LocalFlowState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (LocalFlowState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalFlowState>.NativeClassPtr);
    LocalFlowState.NativeFieldInfoPtr_LocalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalFlowState>.NativeClassPtr, nameof (LocalVariables));
    LocalFlowState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalFlowState>.NativeClassPtr, 100671200);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91633, XrefRangeEnd = 91640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalFlowState()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalFlowState>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalFlowState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Dictionary<Il2CppSystem.Guid, Dictionary<Il2CppSystem.Type, Il2CppSystem.Object>> LocalVariables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalFlowState.NativeFieldInfoPtr_LocalVariables));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Guid, Dictionary<Il2CppSystem.Type, Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Guid, Dictionary<Il2CppSystem.Type, Il2CppSystem.Object>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalFlowState.NativeFieldInfoPtr_LocalVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
