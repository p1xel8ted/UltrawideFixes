// Decompiled with JetBrains decompiler
// Type: UnityEngine.Flare
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine;

public sealed class Flare(IntPtr pointer) : Object(pointer)
{
  private static readonly Flare.Internal_CreateDelegate Internal_CreateDelegateField;

  static Flare()
  {
    Il2CppClassPointerStore<Flare>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Flare));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flare>.NativeClassPtr);
    Flare.Internal_CreateDelegateField = IL2CPP.ResolveICall<Flare.Internal_CreateDelegate>("UnityEngine.Flare::Internal_Create");
  }

  public static void Internal_Create(Flare self)
  {
    Flare.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) self));
  }

  private delegate void Internal_CreateDelegate(IntPtr self);
}
