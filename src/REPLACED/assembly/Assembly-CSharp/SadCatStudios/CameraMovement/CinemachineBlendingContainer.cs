// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineBlendingContainer
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

public class CinemachineBlendingContainer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_cameraFrom;
  private static readonly IntPtr NativeFieldInfoPtr_cameraTo;
  private static readonly IntPtr NativeFieldInfoPtr_blendBetween;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineBlendingContainer()
  {
    Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineBlendingContainer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr);
    CinemachineBlendingContainer.NativeFieldInfoPtr_cameraFrom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr, nameof (cameraFrom));
    CinemachineBlendingContainer.NativeFieldInfoPtr_cameraTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr, nameof (cameraTo));
    CinemachineBlendingContainer.NativeFieldInfoPtr_blendBetween = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr, nameof (blendBetween));
    CinemachineBlendingContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr, 100676328);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlendingContainer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBlendingContainer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBlendingContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineVirtualCameraBase cameraFrom
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendingContainer.NativeFieldInfoPtr_cameraFrom));
      return num == IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendingContainer.NativeFieldInfoPtr_cameraFrom), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase cameraTo
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendingContainer.NativeFieldInfoPtr_cameraTo));
      return num == IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendingContainer.NativeFieldInfoPtr_cameraTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public CinemachineBlendDefinition blendBetween
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendingContainer.NativeFieldInfoPtr_blendBetween);
      return new CinemachineBlendDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlendingContainer.NativeFieldInfoPtr_blendBetween), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }
}
