// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CameraShakeOptions
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

public class CameraShakeOptions(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ImpulseDefinition;
  private static readonly IntPtr NativeFieldInfoPtr_waveForce;
  private static readonly IntPtr NativeFieldInfoPtr_useInvokerPosition;
  private static readonly IntPtr NativeFieldInfoPtr_clearActiveImpulses;
  private static readonly IntPtr NativeFieldInfoPtr_defaultVelocity;
  private static readonly IntPtr NativeMethodInfoPtr_get_WaveForce_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_UseInvokerPosition_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DefaultVelocity_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ClearActiveImpulses_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GenerateImpulse_Public_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CameraShakeOptions()
  {
    Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CameraShakeOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr);
    CameraShakeOptions.NativeFieldInfoPtr_ImpulseDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, nameof (ImpulseDefinition));
    CameraShakeOptions.NativeFieldInfoPtr_waveForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, nameof (waveForce));
    CameraShakeOptions.NativeFieldInfoPtr_useInvokerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, nameof (useInvokerPosition));
    CameraShakeOptions.NativeFieldInfoPtr_clearActiveImpulses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, nameof (clearActiveImpulses));
    CameraShakeOptions.NativeFieldInfoPtr_defaultVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, nameof (defaultVelocity));
    CameraShakeOptions.NativeMethodInfoPtr_get_WaveForce_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, 100676322);
    CameraShakeOptions.NativeMethodInfoPtr_get_UseInvokerPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, 100676323);
    CameraShakeOptions.NativeMethodInfoPtr_get_DefaultVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, 100676324);
    CameraShakeOptions.NativeMethodInfoPtr_get_ClearActiveImpulses_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, 100676325);
    CameraShakeOptions.NativeMethodInfoPtr_GenerateImpulse_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, 100676326);
    CameraShakeOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr, 100676327);
  }

  public unsafe float WaveForce
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 122837, RefRangeEnd = 122838, XrefRangeStart = 122835, XrefRangeEnd = 122837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraShakeOptions.NativeMethodInfoPtr_get_WaveForce_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool UseInvokerPosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraShakeOptions.NativeMethodInfoPtr_get_UseInvokerPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 DefaultVelocity
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraShakeOptions.NativeMethodInfoPtr_get_DefaultVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ClearActiveImpulses
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraShakeOptions.NativeMethodInfoPtr_get_ClearActiveImpulses_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122838, XrefRangeEnd = 122842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GenerateImpulse(Transform sourceTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceTransform)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraShakeOptions.NativeMethodInfoPtr_GenerateImpulse_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122842, XrefRangeEnd = 122845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraShakeOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraShakeOptions>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraShakeOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CinemachineImpulseDefinition ImpulseDefinition
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_ImpulseDefinition));
      return num == IntPtr.Zero ? (CinemachineImpulseDefinition) null : Il2CppObjectPool.Get<CinemachineImpulseDefinition>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_ImpulseDefinition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float waveForce
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_waveForce));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_waveForce)) = value;
    }
  }

  public unsafe bool useInvokerPosition
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_useInvokerPosition));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_useInvokerPosition)) = value;
    }
  }

  public unsafe bool clearActiveImpulses
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_clearActiveImpulses));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_clearActiveImpulses)) = value;
    }
  }

  public unsafe Vector3 defaultVelocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_defaultVelocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraShakeOptions.NativeFieldInfoPtr_defaultVelocity)) = value;
    }
  }
}
