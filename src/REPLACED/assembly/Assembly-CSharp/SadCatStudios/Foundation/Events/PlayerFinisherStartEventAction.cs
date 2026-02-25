// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.PlayerFinisherStartEventAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Foundation.Events;

public class PlayerFinisherStartEventAction(IntPtr pointer) : 
  EventActionBase<PlayerFinisherStartEvent>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerFinisherStartEventAction()
  {
    Il2CppClassPointerStore<PlayerFinisherStartEventAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (PlayerFinisherStartEventAction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFinisherStartEventAction>.NativeClassPtr);
    PlayerFinisherStartEventAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFinisherStartEventAction>.NativeClassPtr, 100671465);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94258, XrefRangeEnd = 94261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerFinisherStartEventAction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFinisherStartEventAction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerFinisherStartEventAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
