// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.GameStateChangedEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.Events;

[StructLayout(LayoutKind.Explicit)]
public struct GameStateChangedEvent
{
  private static readonly System.IntPtr NativeFieldInfoPtr_State;
  private static readonly System.IntPtr NativeFieldInfoPtr_PreviousState;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameState_GameState_0;
  [FieldOffset(0)]
  public readonly GameStateManager.GameState State;
  [FieldOffset(4)]
  public readonly GameStateManager.GameState PreviousState;

  static GameStateChangedEvent()
  {
    Il2CppClassPointerStore<GameStateChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (GameStateChangedEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStateChangedEvent>.NativeClassPtr);
    GameStateChangedEvent.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateChangedEvent>.NativeClassPtr, nameof (State));
    GameStateChangedEvent.NativeFieldInfoPtr_PreviousState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateChangedEvent>.NativeClassPtr, nameof (PreviousState));
    GameStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_GameState_GameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateChangedEvent>.NativeClassPtr, 100671461);
  }

  [CallerCount(54)]
  [CachedScanResults(RefRangeStart = 94193, RefRangeEnd = 94247, XrefRangeStart = 94193, XrefRangeEnd = 94193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameStateChangedEvent(
    GameStateManager.GameState state,
    GameStateManager.GameState previous)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &state;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &previous;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameStateChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_GameState_GameState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameStateChangedEvent>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
