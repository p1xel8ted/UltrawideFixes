// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.Events.PlayerFinisherStartEventActionNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Foundation.Events;
using System;

#nullable disable
namespace SadCatStudios.FSM.Actions.BasicActions.Events;

public class PlayerFinisherStartEventActionNode(IntPtr pointer) : 
  BaseEventActionNode<PlayerFinisherStartEvent>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerFinisherStartEventActionNode()
  {
    Il2CppClassPointerStore<PlayerFinisherStartEventActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions.Events", nameof (PlayerFinisherStartEventActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFinisherStartEventActionNode>.NativeClassPtr);
    PlayerFinisherStartEventActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFinisherStartEventActionNode>.NativeClassPtr, 100674606);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112561, XrefRangeEnd = 112564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerFinisherStartEventActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFinisherStartEventActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerFinisherStartEventActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
