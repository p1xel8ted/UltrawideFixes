// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.DialogueFlowEndEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.Events;

[StructLayout(LayoutKind.Explicit)]
public struct DialogueFlowEndEvent
{
  static DialogueFlowEndEvent()
  {
    Il2CppClassPointerStore<DialogueFlowEndEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (DialogueFlowEndEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueFlowEndEvent>.NativeClassPtr);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DialogueFlowEndEvent>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
