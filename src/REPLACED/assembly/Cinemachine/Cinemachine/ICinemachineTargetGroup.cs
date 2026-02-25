// Decompiled with JetBrains decompiler
// Type: Cinemachine.ICinemachineTargetGroup
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class ICinemachineTargetGroup(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_Sphere_Public_Abstract_Virtual_New_get_BoundingSphere_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetViewSpaceBoundingBox_Public_Abstract_Virtual_New_Bounds_Matrix4x4_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetViewSpaceAngularBounds_Public_Abstract_Virtual_New_Void_Matrix4x4_byref_Vector2_byref_Vector2_byref_Vector2_0;

  static ICinemachineTargetGroup()
  {
    Il2CppClassPointerStore<ICinemachineTargetGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (ICinemachineTargetGroup));
    ICinemachineTargetGroup.NativeMethodInfoPtr_get_Sphere_Public_Abstract_Virtual_New_get_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICinemachineTargetGroup>.NativeClassPtr, 100663644);
    ICinemachineTargetGroup.NativeMethodInfoPtr_get_IsEmpty_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICinemachineTargetGroup>.NativeClassPtr, 100663645);
    ICinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceBoundingBox_Public_Abstract_Virtual_New_Bounds_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICinemachineTargetGroup>.NativeClassPtr, 100663646);
    ICinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceAngularBounds_Public_Abstract_Virtual_New_Void_Matrix4x4_byref_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICinemachineTargetGroup>.NativeClassPtr, 100663647);
  }

  public virtual unsafe BoundingSphere Sphere
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICinemachineTargetGroup.NativeMethodInfoPtr_get_Sphere_Public_Abstract_Virtual_New_get_BoundingSphere_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(BoundingSphere*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe bool IsEmpty
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICinemachineTargetGroup.NativeMethodInfoPtr_get_IsEmpty_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe Bounds GetViewSpaceBoundingBox(Matrix4x4 observer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &observer
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceBoundingBox_Public_Abstract_Virtual_New_Bounds_Matrix4x4_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void GetViewSpaceAngularBounds(
    Matrix4x4 observer,
    out Vector2 minAngles,
    out Vector2 maxAngles,
    out Vector2 zRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &observer;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref minAngles;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref maxAngles;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref zRange;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICinemachineTargetGroup.NativeMethodInfoPtr_GetViewSpaceAngularBounds_Public_Abstract_Virtual_New_Void_Matrix4x4_byref_Vector2_byref_Vector2_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
