// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineMixerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.CameraMovement;

public sealed class CinemachineMixerController(IntPtr pointer) : CinemachineControllerBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mixingCurve;
  private static readonly IntPtr NativeFieldInfoPtr_mixer;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MaxPos_Protected_Virtual_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessCamera_Protected_Virtual_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineMixerController()
  {
    Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineMixerController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr);
    CinemachineMixerController.NativeFieldInfoPtr_mixingCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr, nameof (mixingCurve));
    CinemachineMixerController.NativeFieldInfoPtr_mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr, nameof (mixer));
    CinemachineMixerController.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr, 100676401);
    CinemachineMixerController.NativeMethodInfoPtr_MaxPos_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr, 100676402);
    CinemachineMixerController.NativeMethodInfoPtr_ProcessCamera_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr, 100676403);
    CinemachineMixerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr, 100676404);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123212, XrefRangeEnd = 123214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixerController.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123214, XrefRangeEnd = 123215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe float MaxPos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineMixerController.NativeMethodInfoPtr_MaxPos_Protected_Virtual_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123215, XrefRangeEnd = 123221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessCamera(float resultPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &resultPos
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixerController.NativeMethodInfoPtr_ProcessCamera_Protected_Virtual_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123221, XrefRangeEnd = 123223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineMixerController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineMixerController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationCurve mixingCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixerController.NativeFieldInfoPtr_mixingCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixerController.NativeFieldInfoPtr_mixingCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineMixingCamera mixer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixerController.NativeFieldInfoPtr_mixer));
      return num == IntPtr.Zero ? (CinemachineMixingCamera) null : Il2CppObjectPool.Get<CinemachineMixingCamera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixerController.NativeFieldInfoPtr_mixer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
