// Decompiled with JetBrains decompiler
// Type: PingPongRotationController
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
public class PingPongRotationController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_currentRot;
  private static readonly IntPtr NativeFieldInfoPtr_reverseRotation;
  private static readonly IntPtr NativeFieldInfoPtr_amplitudeCache;
  private static readonly IntPtr NativeFieldInfoPtr_qAmplitude;
  private static readonly IntPtr NativeFieldInfoPtr_randomnessRange;
  private static readonly IntPtr NativeFieldInfoPtr_amplitude;
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_aroundAxis;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_updateRotation_Private_Void_byref_Single_byref_Single_byref_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_updateQuaternions_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PingPongRotationController()
  {
    Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PingPongRotationController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr);
    PingPongRotationController.NativeFieldInfoPtr_currentRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (currentRot));
    PingPongRotationController.NativeFieldInfoPtr_reverseRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (reverseRotation));
    PingPongRotationController.NativeFieldInfoPtr_amplitudeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (amplitudeCache));
    PingPongRotationController.NativeFieldInfoPtr_qAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (qAmplitude));
    PingPongRotationController.NativeFieldInfoPtr_randomnessRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (randomnessRange));
    PingPongRotationController.NativeFieldInfoPtr_amplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (amplitude));
    PingPongRotationController.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (speed));
    PingPongRotationController.NativeFieldInfoPtr_aroundAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, nameof (aroundAxis));
    PingPongRotationController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, 100663662);
    PingPongRotationController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, 100663663);
    PingPongRotationController.NativeMethodInfoPtr_updateRotation_Private_Void_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, 100663664 /*0x06000170*/);
    PingPongRotationController.NativeMethodInfoPtr_updateQuaternions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, 100663665);
    PingPongRotationController.NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, 100663666);
    PingPongRotationController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr, 100663667);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22156, XrefRangeEnd = 22166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PingPongRotationController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22166, XrefRangeEnd = 22174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PingPongRotationController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22177, RefRangeEnd = 22178, XrefRangeStart = 22174, XrefRangeEnd = 22177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void updateRotation(
    ref float localRotationPart,
    ref float randomnessRangePart,
    ref float qAmplitudePart)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) ref localRotationPart;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref randomnessRangePart;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref qAmplitudePart;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PingPongRotationController.NativeMethodInfoPtr_updateRotation_Private_Void_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 22186, RefRangeEnd = 22188, XrefRangeStart = 22178, XrefRangeEnd = 22186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void updateQuaternions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PingPongRotationController.NativeMethodInfoPtr_updateQuaternions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PingPongRotationController.NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PingPongRotationController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PingPongRotationController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PingPongRotationController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float currentRot
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_currentRot));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_currentRot)) = value;
    }
  }

  public unsafe bool reverseRotation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_reverseRotation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_reverseRotation)) = value;
    }
  }

  public unsafe float amplitudeCache
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_amplitudeCache));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_amplitudeCache)) = value;
    }
  }

  public unsafe Quaternion qAmplitude
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_qAmplitude));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_qAmplitude)) = value;
    }
  }

  public unsafe Quaternion randomnessRange
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_randomnessRange));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_randomnessRange)) = value;
    }
  }

  public unsafe float amplitude
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_amplitude));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_amplitude)) = value;
    }
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe PingPongRotationController.AroundAxis aroundAxis
  {
    get
    {
      return *(PingPongRotationController.AroundAxis*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_aroundAxis));
    }
    [param: In] set
    {
      *(PingPongRotationController.AroundAxis*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PingPongRotationController.NativeFieldInfoPtr_aroundAxis)) = value;
    }
  }

  public enum AroundAxis
  {
    X,
    Y,
    Z,
  }
}
