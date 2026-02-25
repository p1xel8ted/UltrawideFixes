// Decompiled with JetBrains decompiler
// Type: CinemachineShot
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
public sealed class CinemachineShot(IntPtr pointer) : PlayableAsset(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_DisplayName;
  private static readonly IntPtr NativeFieldInfoPtr_VirtualCamera;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineShot()
  {
    Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineShot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr);
    CinemachineShot.NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr, nameof (DisplayName));
    CinemachineShot.NativeFieldInfoPtr_VirtualCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr, nameof (VirtualCamera));
    CinemachineShot.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr, 100663312 /*0x06000010*/);
    CinemachineShot.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr, 100663313 /*0x06000011*/);
    CinemachineShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr, 100663314 /*0x06000012*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936676, XrefRangeEnd = 936692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineShot.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936692, XrefRangeEnd = 936735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void GatherProperties(PlayableDirector director, IPropertyCollector driver)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) director);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) driver);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineShot.NativeMethodInfoPtr_GatherProperties_Public_Virtual_Final_New_Void_PlayableDirector_IPropertyCollector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineShot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineShot>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string DisplayName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineShot.NativeFieldInfoPtr_DisplayName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineShot.NativeFieldInfoPtr_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera
  {
    get
    {
      IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineShot.NativeFieldInfoPtr_VirtualCamera);
      return new ExposedReference<CinemachineVirtualCameraBase>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExposedReference<CinemachineVirtualCameraBase>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineShot.NativeFieldInfoPtr_VirtualCamera), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExposedReference<CinemachineVirtualCameraBase>>.NativeClassPtr, (uint&) IntPtr.Zero));
    }
  }
}
