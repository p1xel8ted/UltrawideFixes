// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.IPlayableOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Playables;

public class IPlayableOutput(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0;

  static IPlayableOutput()
  {
    Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (IPlayableOutput));
    IPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableOutput>.NativeClassPtr, 100669385);
  }

  [CallerCount(0)]
  public virtual unsafe PlayableOutputHandle GetHandle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Abstract_Virtual_New_PlayableOutputHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutputHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
