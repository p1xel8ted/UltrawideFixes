// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.ICounterFeedbackHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class ICounterFeedbackHandler(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveCounterFeedback_Public_Abstract_Virtual_New_Void_CounterVariant_0;
  private static readonly IntPtr NativeMethodInfoPtr_TurnAround_Public_Abstract_Virtual_New_Void_0;

  static ICounterFeedbackHandler()
  {
    Il2CppClassPointerStore<ICounterFeedbackHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (ICounterFeedbackHandler));
    ICounterFeedbackHandler.NativeMethodInfoPtr_ReceiveCounterFeedback_Public_Abstract_Virtual_New_Void_CounterVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterFeedbackHandler>.NativeClassPtr, 100677421);
    ICounterFeedbackHandler.NativeMethodInfoPtr_TurnAround_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterFeedbackHandler>.NativeClassPtr, 100677422);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveCounterFeedback(CounterVariant counterVariant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) counterVariant)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterFeedbackHandler.NativeMethodInfoPtr_ReceiveCounterFeedback_Public_Abstract_Virtual_New_Void_CounterVariant_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void TurnAround()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterFeedbackHandler.NativeMethodInfoPtr_TurnAround_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
