// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.ICounterReceiveHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class ICounterReceiveHandler(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_NeedResponce_Public_Abstract_Virtual_New_Boolean_AttackObject_ICounterSender_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessReceivedCounter_Public_Abstract_Virtual_New_Void_ICounterSender_0;

  static ICounterReceiveHandler()
  {
    Il2CppClassPointerStore<ICounterReceiveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (ICounterReceiveHandler));
    ICounterReceiveHandler.NativeMethodInfoPtr_NeedResponce_Public_Abstract_Virtual_New_Boolean_AttackObject_ICounterSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterReceiveHandler>.NativeClassPtr, 100677588);
    ICounterReceiveHandler.NativeMethodInfoPtr_ProcessReceivedCounter_Public_Abstract_Virtual_New_Void_ICounterSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICounterReceiveHandler>.NativeClassPtr, 100677589);
  }

  [CallerCount(0)]
  public virtual unsafe bool NeedResponce(AttackObject attack, ICounterSender counterSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) counterSender);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterReceiveHandler.NativeMethodInfoPtr_NeedResponce_Public_Abstract_Virtual_New_Boolean_AttackObject_ICounterSender_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessReceivedCounter(ICounterSender counterSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) counterSender)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICounterReceiveHandler.NativeMethodInfoPtr_ProcessReceivedCounter_Public_Abstract_Virtual_New_Void_ICounterSender_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
