// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IFinisherSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class IFinisherSender(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ProcessFinisherConnection_Public_Abstract_Virtual_New_Void_Transform_FinisherVariant_0;

  static IFinisherSender()
  {
    Il2CppClassPointerStore<IFinisherSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IFinisherSender));
    IFinisherSender.NativeMethodInfoPtr_ProcessFinisherConnection_Public_Abstract_Virtual_New_Void_Transform_FinisherVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFinisherSender>.NativeClassPtr, 100677391);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessFinisherConnection(
    Transform receiverTransform,
    FinisherVariant finisherVariant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiverTransform);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finisherVariant);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFinisherSender.NativeMethodInfoPtr_ProcessFinisherConnection_Public_Abstract_Virtual_New_Void_Transform_FinisherVariant_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
