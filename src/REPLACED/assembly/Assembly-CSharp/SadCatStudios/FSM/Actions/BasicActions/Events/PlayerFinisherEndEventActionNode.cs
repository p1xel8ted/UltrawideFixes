// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.Actions.BasicActions.Events.PlayerFinisherEndEventActionNode
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

public class PlayerFinisherEndEventActionNode(IntPtr pointer) : 
  BaseEventActionNode<PlayerFinisherEndEvent>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerFinisherEndEventActionNode()
  {
    Il2CppClassPointerStore<PlayerFinisherEndEventActionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM.Actions.BasicActions.Events", nameof (PlayerFinisherEndEventActionNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFinisherEndEventActionNode>.NativeClassPtr);
    PlayerFinisherEndEventActionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFinisherEndEventActionNode>.NativeClassPtr, 100674605);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112558, XrefRangeEnd = 112561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerFinisherEndEventActionNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFinisherEndEventActionNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerFinisherEndEventActionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
