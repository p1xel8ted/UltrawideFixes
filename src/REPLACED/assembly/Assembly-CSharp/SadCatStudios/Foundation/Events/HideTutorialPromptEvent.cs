// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.HideTutorialPromptEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.Events;

[StructLayout(LayoutKind.Explicit)]
public struct HideTutorialPromptEvent
{
  static HideTutorialPromptEvent()
  {
    Il2CppClassPointerStore<HideTutorialPromptEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (HideTutorialPromptEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideTutorialPromptEvent>.NativeClassPtr);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HideTutorialPromptEvent>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
