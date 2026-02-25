// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.IPatternDestructor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class IPatternDestructor(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_DestructionPattern_Public_Abstract_Virtual_New_Il2CppObjectBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_DestructionOffset_Public_Abstract_Virtual_New_Vector2_0;

  static IPatternDestructor()
  {
    Il2CppClassPointerStore<IPatternDestructor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (IPatternDestructor));
    IPatternDestructor.NativeMethodInfoPtr_DestructionPattern_Public_Abstract_Virtual_New_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPatternDestructor>.NativeClassPtr, 100676681);
    IPatternDestructor.NativeMethodInfoPtr_DestructionOffset_Public_Abstract_Virtual_New_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPatternDestructor>.NativeClassPtr, 100676682);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppObjectBase DestructionPattern()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPatternDestructor.NativeMethodInfoPtr_DestructionPattern_Public_Abstract_Virtual_New_Il2CppObjectBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe Vector2 DestructionOffset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPatternDestructor.NativeMethodInfoPtr_DestructionOffset_Public_Abstract_Virtual_New_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
