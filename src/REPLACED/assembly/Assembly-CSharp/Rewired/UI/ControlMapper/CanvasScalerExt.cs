// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.CanvasScalerExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class CanvasScalerExt(IntPtr pointer) : CanvasScaler(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ForceRefresh_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CanvasScalerExt()
  {
    Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (CanvasScalerExt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr);
    CanvasScalerExt.NativeMethodInfoPtr_ForceRefresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr, 100668988);
    CanvasScalerExt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr, 100668989);
  }

  [CallerCount(0)]
  public unsafe void ForceRefresh()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CanvasScalerExt.NativeMethodInfoPtr_ForceRefresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72324, XrefRangeEnd = 72325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CanvasScalerExt()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScalerExt>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CanvasScalerExt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
