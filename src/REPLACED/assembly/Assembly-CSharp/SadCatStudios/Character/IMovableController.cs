// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.IMovableController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.MovementPhysics;
using System;

#nullable disable
namespace SadCatStudios.Character;

public class IMovableController(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SnapMovable_Public_Abstract_Virtual_New_Void_MovableObjectPhysics_0;
  private static readonly IntPtr NativeMethodInfoPtr_FreeMovable_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Void_Single_Single_Single_0;

  static IMovableController()
  {
    Il2CppClassPointerStore<IMovableController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (IMovableController));
    IMovableController.NativeMethodInfoPtr_SnapMovable_Public_Abstract_Virtual_New_Void_MovableObjectPhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMovableController>.NativeClassPtr, 100675589 /*0x06003005*/);
    IMovableController.NativeMethodInfoPtr_FreeMovable_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMovableController>.NativeClassPtr, 100675590 /*0x06003006*/);
    IMovableController.NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMovableController>.NativeClassPtr, 100675591 /*0x06003007*/);
  }

  [CallerCount(0)]
  public virtual unsafe void SnapMovable(MovableObjectPhysics movablePhysics)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) movablePhysics)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IMovableController.NativeMethodInfoPtr_SnapMovable_Public_Abstract_Virtual_New_Void_MovableObjectPhysics_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void FreeMovable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IMovableController.NativeMethodInfoPtr_FreeMovable_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Move(float move, float friction, float acceleration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &move;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &friction;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &acceleration;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IMovableController.NativeMethodInfoPtr_Move_Public_Abstract_Virtual_New_Void_Single_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
