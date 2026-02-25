// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowElementBlock
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
namespace SadCatStudios.Dialogs.Articy;

[Serializable]
public class FlowElementBlock(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowElements;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlowElementBlock()
  {
    Il2CppClassPointerStore<FlowElementBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowElementBlock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowElementBlock>.NativeClassPtr);
    FlowElementBlock.NativeFieldInfoPtr_FlowElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowElementBlock>.NativeClassPtr, nameof (FlowElements));
    FlowElementBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowElementBlock>.NativeClassPtr, 100672844);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104266, XrefRangeEnd = 104273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowElementBlock()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowElementBlock>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowElementBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<FlowElement> FlowElements
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowElementBlock.NativeFieldInfoPtr_FlowElements));
      return num == System.IntPtr.Zero ? (List<FlowElement>) null : Il2CppObjectPool.Get<List<FlowElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowElementBlock.NativeFieldInfoPtr_FlowElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
