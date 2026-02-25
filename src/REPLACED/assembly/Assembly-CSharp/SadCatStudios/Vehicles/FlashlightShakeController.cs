// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Vehicles.FlashlightShakeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Vehicles;

public class FlashlightShakeController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_shakeSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_baseShakeAmount;
  private static readonly IntPtr NativeFieldInfoPtr_noiseIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_speedFactor;
  private static readonly IntPtr NativeFieldInfoPtr_deltaFactor;
  private static readonly IntPtr NativeFieldInfoPtr_previousPosition;
  private static readonly IntPtr NativeFieldInfoPtr_originalPosition;
  private static readonly IntPtr NativeFieldInfoPtr_originalRotation;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlashlightShakeController()
  {
    Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Vehicles", nameof (FlashlightShakeController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr);
    FlashlightShakeController.NativeFieldInfoPtr_shakeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (shakeSpeed));
    FlashlightShakeController.NativeFieldInfoPtr_baseShakeAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (baseShakeAmount));
    FlashlightShakeController.NativeFieldInfoPtr_noiseIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (noiseIntensity));
    FlashlightShakeController.NativeFieldInfoPtr_speedFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (speedFactor));
    FlashlightShakeController.NativeFieldInfoPtr_deltaFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (deltaFactor));
    FlashlightShakeController.NativeFieldInfoPtr_previousPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (previousPosition));
    FlashlightShakeController.NativeFieldInfoPtr_originalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (originalPosition));
    FlashlightShakeController.NativeFieldInfoPtr_originalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, nameof (originalRotation));
    FlashlightShakeController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, 100673009);
    FlashlightShakeController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, 100673010);
    FlashlightShakeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr, 100673011);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105473, XrefRangeEnd = 105479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlashlightShakeController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105479, XrefRangeEnd = 105507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlashlightShakeController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105507, XrefRangeEnd = 105508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlashlightShakeController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlashlightShakeController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlashlightShakeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float shakeSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_shakeSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_shakeSpeed)) = value;
    }
  }

  public unsafe float baseShakeAmount
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_baseShakeAmount));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_baseShakeAmount)) = value;
    }
  }

  public unsafe float noiseIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_noiseIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_noiseIntensity)) = value;
    }
  }

  public unsafe float speedFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_speedFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_speedFactor)) = value;
    }
  }

  public unsafe float deltaFactor
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_deltaFactor));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_deltaFactor)) = value;
    }
  }

  public unsafe Vector3 previousPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_previousPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_previousPosition)) = value;
    }
  }

  public unsafe Vector3 originalPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_originalPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_originalPosition)) = value;
    }
  }

  public unsafe Quaternion originalRotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_originalRotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlashlightShakeController.NativeFieldInfoPtr_originalRotation)) = value;
    }
  }
}
