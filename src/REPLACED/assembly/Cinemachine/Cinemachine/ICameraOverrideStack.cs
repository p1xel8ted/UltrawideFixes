// Decompiled with JetBrains decompiler
// Type: Cinemachine.ICameraOverrideStack
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Cinemachine;

public class ICameraOverrideStack(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_SetCameraOverride_Public_Abstract_Virtual_New_Int32_Int32_ICinemachineCamera_ICinemachineCamera_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReleaseCameraOverride_Public_Abstract_Virtual_New_Void_Int32_0;

  static ICameraOverrideStack()
  {
    Il2CppClassPointerStore<ICameraOverrideStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (ICameraOverrideStack));
    ICameraOverrideStack.NativeMethodInfoPtr_SetCameraOverride_Public_Abstract_Virtual_New_Int32_Int32_ICinemachineCamera_ICinemachineCamera_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraOverrideStack>.NativeClassPtr, 100663354 /*0x0600003A*/);
    ICameraOverrideStack.NativeMethodInfoPtr_ReleaseCameraOverride_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICameraOverrideStack>.NativeClassPtr, 100663355 /*0x0600003B*/);
  }

  [CallerCount(0)]
  public virtual unsafe int SetCameraOverride(
    int overrideId,
    ICinemachineCamera camA,
    ICinemachineCamera camB,
    float weightB,
    float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = (IntPtr) &overrideId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camA);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camB);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &weightB;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICameraOverrideStack.NativeMethodInfoPtr_SetCameraOverride_Public_Abstract_Virtual_New_Int32_Int32_ICinemachineCamera_ICinemachineCamera_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void ReleaseCameraOverride(int overrideId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &overrideId
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICameraOverrideStack.NativeMethodInfoPtr_ReleaseCameraOverride_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
