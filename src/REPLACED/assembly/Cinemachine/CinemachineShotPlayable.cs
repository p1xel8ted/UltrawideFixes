// Decompiled with JetBrains decompiler
// Type: CinemachineShotPlayable
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
public sealed class CinemachineShotPlayable(IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_VirtualCamera;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineShotPlayable()
  {
    Il2CppClassPointerStore<CinemachineShotPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineShotPlayable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineShotPlayable>.NativeClassPtr);
    CinemachineShotPlayable.NativeFieldInfoPtr_VirtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineShotPlayable>.NativeClassPtr, nameof (VirtualCamera));
    CinemachineShotPlayable.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineShotPlayable>.NativeClassPtr, 100663315 /*0x06000013*/);
    CinemachineShotPlayable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineShotPlayable>.NativeClassPtr, 100663316 /*0x06000014*/);
  }

  public unsafe bool IsValid
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 936739, RefRangeEnd = 936740, XrefRangeStart = 936735, XrefRangeEnd = 936739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineShotPlayable.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineShotPlayable()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineShotPlayable>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineShotPlayable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineVirtualCameraBase VirtualCamera
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineShotPlayable.NativeFieldInfoPtr_VirtualCamera));
      return num == IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineShotPlayable.NativeFieldInfoPtr_VirtualCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
