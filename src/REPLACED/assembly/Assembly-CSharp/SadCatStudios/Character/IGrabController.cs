// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.IGrabController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class IGrabController(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SaveGrabPoint_Public_Abstract_Virtual_New_Void_BoxCollider_Vector3_GrabType_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGrabPoint_Public_Abstract_Virtual_New_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGrabTarget_Public_Abstract_Virtual_New_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetGrabType_Public_Abstract_Virtual_New_GrabType_0;

  static IGrabController()
  {
    Il2CppClassPointerStore<IGrabController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (IGrabController));
    IGrabController.NativeMethodInfoPtr_SaveGrabPoint_Public_Abstract_Virtual_New_Void_BoxCollider_Vector3_GrabType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabController>.NativeClassPtr, 100675583);
    IGrabController.NativeMethodInfoPtr_GetGrabPoint_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabController>.NativeClassPtr, 100675584 /*0x06003000*/);
    IGrabController.NativeMethodInfoPtr_GetGrabTarget_Public_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabController>.NativeClassPtr, 100675585 /*0x06003001*/);
    IGrabController.NativeMethodInfoPtr_GetGrabType_Public_Abstract_Virtual_New_GrabType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabController>.NativeClassPtr, 100675586 /*0x06003002*/);
  }

  [CallerCount(0)]
  public virtual unsafe void SaveGrabPoint(
    BoxCollider ledgeCollider,
    Vector3 hitPoint,
    GrabType grabType,
    bool dropdown = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ledgeCollider);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &hitPoint;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &grabType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &dropdown;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabController.NativeMethodInfoPtr_SaveGrabPoint_Public_Abstract_Virtual_New_Void_BoxCollider_Vector3_GrabType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Vector3 GetGrabPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabController.NativeMethodInfoPtr_GetGrabPoint_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe Vector3 GetGrabTarget()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabController.NativeMethodInfoPtr_GetGrabTarget_Public_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe GrabType GetGrabType()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabController.NativeMethodInfoPtr_GetGrabType_Public_Abstract_Virtual_New_GrabType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GrabType*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
