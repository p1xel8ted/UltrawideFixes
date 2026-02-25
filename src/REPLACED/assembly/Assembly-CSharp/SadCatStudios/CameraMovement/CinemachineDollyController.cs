// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineDollyController
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

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CinemachineDollyController(IntPtr pointer) : CinemachineControllerBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_dollyTrack;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MaxPos_Protected_Virtual_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessCamera_Protected_Virtual_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineDollyController()
  {
    Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineDollyController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr);
    CinemachineDollyController.NativeFieldInfoPtr_dollyTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr, nameof (dollyTrack));
    CinemachineDollyController.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr, 100676397);
    CinemachineDollyController.NativeMethodInfoPtr_MaxPos_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr, 100676398);
    CinemachineDollyController.NativeMethodInfoPtr_ProcessCamera_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr, 100676399);
    CinemachineDollyController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr, 100676400);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123205, XrefRangeEnd = 123210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineDollyController.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123210, XrefRangeEnd = 123211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe float MaxPos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineDollyController.NativeMethodInfoPtr_MaxPos_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe void ProcessCamera(float resultPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &resultPos
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineDollyController.NativeMethodInfoPtr_ProcessCamera_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123211, XrefRangeEnd = 123212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineDollyController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineDollyController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDollyController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineTrackedDolly dollyTrack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyController.NativeFieldInfoPtr_dollyTrack));
      return num == IntPtr.Zero ? (CinemachineTrackedDolly) null : Il2CppObjectPool.Get<CinemachineTrackedDolly>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineDollyController.NativeFieldInfoPtr_dollyTrack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
