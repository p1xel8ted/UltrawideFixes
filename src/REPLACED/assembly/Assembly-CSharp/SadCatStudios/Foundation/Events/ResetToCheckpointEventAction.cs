// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.ResetToCheckpointEventAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Foundation.Events;

public class ResetToCheckpointEventAction(IntPtr pointer) : EventActionBase<ResetToCheckpointEvent>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ResetToCheckpointEventAction()
  {
    Il2CppClassPointerStore<ResetToCheckpointEventAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (ResetToCheckpointEventAction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetToCheckpointEventAction>.NativeClassPtr);
    ResetToCheckpointEventAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResetToCheckpointEventAction>.NativeClassPtr, 100671466);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94261, XrefRangeEnd = 94264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResetToCheckpointEventAction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResetToCheckpointEventAction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResetToCheckpointEventAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
