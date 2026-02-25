// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineBlenderSettings
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

[Serializable]
public sealed class CinemachineBlenderSettings(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomBlends;
  private static readonly System.IntPtr NativeFieldInfoPtr_kBlendFromAnyCameraLabel;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBlendForVirtualCameras_Public_CinemachineBlendDefinition_String_String_CinemachineBlendDefinition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineBlenderSettings()
  {
    Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineBlenderSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr);
    CinemachineBlenderSettings.NativeFieldInfoPtr_m_CustomBlends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr, nameof (m_CustomBlends));
    CinemachineBlenderSettings.NativeFieldInfoPtr_kBlendFromAnyCameraLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr, nameof (kBlendFromAnyCameraLabel));
    CinemachineBlenderSettings.NativeMethodInfoPtr_GetBlendForVirtualCameras_Public_CinemachineBlendDefinition_String_String_CinemachineBlendDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr, 100663937);
    CinemachineBlenderSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr, 100663938);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 942802, RefRangeEnd = 942808, XrefRangeStart = 942783, XrefRangeEnd = 942802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlendDefinition GetBlendForVirtualCameras(
    string fromCameraName,
    string toCameraName,
    CinemachineBlendDefinition defaultBlend)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fromCameraName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(toCameraName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) defaultBlend));
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CinemachineBlenderSettings.NativeMethodInfoPtr_GetBlendForVirtualCameras_Public_CinemachineBlendDefinition_String_String_CinemachineBlendDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new CinemachineBlendDefinition(pointer);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineBlenderSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineBlenderSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CinemachineBlenderSettings.CustomBlend> m_CustomBlends
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.NativeFieldInfoPtr_m_CustomBlends));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CinemachineBlenderSettings.CustomBlend>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CinemachineBlenderSettings.CustomBlend>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.NativeFieldInfoPtr_m_CustomBlends), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string kBlendFromAnyCameraLabel
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(CinemachineBlenderSettings.NativeFieldInfoPtr_kBlendFromAnyCameraLabel, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineBlenderSettings.NativeFieldInfoPtr_kBlendFromAnyCameraLabel, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  [Serializable]
  public sealed class CustomBlend : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_To;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Blend;

    static CustomBlend()
    {
      Il2CppClassPointerStore<CinemachineBlenderSettings.CustomBlend>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineBlenderSettings>.NativeClassPtr, nameof (CustomBlend));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineBlenderSettings.CustomBlend>.NativeClassPtr);
      CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlenderSettings.CustomBlend>.NativeClassPtr, nameof (m_From));
      CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlenderSettings.CustomBlend>.NativeClassPtr, nameof (m_To));
      CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_Blend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineBlenderSettings.CustomBlend>.NativeClassPtr, nameof (m_Blend));
    }

    public CustomBlend(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public CustomBlend()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineBlenderSettings.CustomBlend>.NativeClassPtr))
    {
    }

    public unsafe string m_From
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_From)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_From), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string m_To
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_To)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_To), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public CinemachineBlendDefinition m_Blend
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_Blend);
        return new CinemachineBlendDefinition(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineBlenderSettings.CustomBlend.NativeFieldInfoPtr_m_Blend), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineBlendDefinition>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
