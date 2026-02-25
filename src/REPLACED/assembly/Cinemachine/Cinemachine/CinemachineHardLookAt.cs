// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineHardLookAt
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Cinemachine;

public class CinemachineHardLookAt(IntPtr pointer) : CinemachineComponentBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0;
  private static readonly IntPtr NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineHardLookAt()
  {
    Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineHardLookAt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr);
    CinemachineHardLookAt.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr, 100663793);
    CinemachineHardLookAt.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr, 100663794);
    CinemachineHardLookAt.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr, 100663795);
    CinemachineHardLookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr, 100663796);
  }

  public override unsafe bool IsValid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941578, XrefRangeEnd = 941580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineHardLookAt.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe CinemachineCore.Stage Stage
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineHardLookAt.NativeMethodInfoPtr_get_Stage_Public_Virtual_get_Stage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CinemachineCore.Stage*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941580, XrefRangeEnd = 941595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void MutateCameraState(ref CameraState curState, float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) curState);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &deltaTime;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineHardLookAt.NativeMethodInfoPtr_MutateCameraState_Public_Virtual_Void_byref_CameraState_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineHardLookAt()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineHardLookAt>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineHardLookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
