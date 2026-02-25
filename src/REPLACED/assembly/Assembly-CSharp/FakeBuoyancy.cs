// Decompiled with JetBrains decompiler
// Type: FakeBuoyancy
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
public class FakeBuoyancy(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_bounceVector;
  private static readonly IntPtr NativeFieldInfoPtr_frequencyMin;
  private static readonly IntPtr NativeFieldInfoPtr_frequencyMax;
  private static readonly IntPtr NativeFieldInfoPtr_magnitude;
  private static readonly IntPtr NativeFieldInfoPtr_rotationVector;
  private static readonly IntPtr NativeFieldInfoPtr_angleMax;
  private static readonly IntPtr NativeFieldInfoPtr_angleMagnitude;
  private static readonly IntPtr NativeFieldInfoPtr_startPos;
  private static readonly IntPtr NativeFieldInfoPtr_startEuler;
  private static readonly IntPtr NativeFieldInfoPtr_randomInterval;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FakeBuoyancy()
  {
    Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FakeBuoyancy));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr);
    FakeBuoyancy.NativeFieldInfoPtr_bounceVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (bounceVector));
    FakeBuoyancy.NativeFieldInfoPtr_frequencyMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (frequencyMin));
    FakeBuoyancy.NativeFieldInfoPtr_frequencyMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (frequencyMax));
    FakeBuoyancy.NativeFieldInfoPtr_magnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (magnitude));
    FakeBuoyancy.NativeFieldInfoPtr_rotationVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (rotationVector));
    FakeBuoyancy.NativeFieldInfoPtr_angleMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (angleMax));
    FakeBuoyancy.NativeFieldInfoPtr_angleMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (angleMagnitude));
    FakeBuoyancy.NativeFieldInfoPtr_startPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (startPos));
    FakeBuoyancy.NativeFieldInfoPtr_startEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (startEuler));
    FakeBuoyancy.NativeFieldInfoPtr_randomInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, nameof (randomInterval));
    FakeBuoyancy.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, 100663549 /*0x060000FD*/);
    FakeBuoyancy.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, 100663550 /*0x060000FE*/);
    FakeBuoyancy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr, 100663551 /*0x060000FF*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20396, XrefRangeEnd = 20401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FakeBuoyancy.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20401, XrefRangeEnd = 20412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FakeBuoyancy.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20412, XrefRangeEnd = 20413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FakeBuoyancy()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeBuoyancy>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FakeBuoyancy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 bounceVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_bounceVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_bounceVector)) = value;
    }
  }

  public unsafe float frequencyMin
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_frequencyMin));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_frequencyMin)) = value;
    }
  }

  public unsafe float frequencyMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_frequencyMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_frequencyMax)) = value;
    }
  }

  public unsafe float magnitude
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_magnitude));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_magnitude)) = value;
    }
  }

  public unsafe Vector3 rotationVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_rotationVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_rotationVector)) = value;
    }
  }

  public unsafe float angleMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_angleMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_angleMax)) = value;
    }
  }

  public unsafe float angleMagnitude
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_angleMagnitude));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_angleMagnitude)) = value;
    }
  }

  public unsafe Vector3 startPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_startPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_startPos)) = value;
    }
  }

  public unsafe Vector3 startEuler
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_startEuler));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_startEuler)) = value;
    }
  }

  public unsafe float randomInterval
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_randomInterval));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FakeBuoyancy.NativeFieldInfoPtr_randomInterval)) = value;
    }
  }
}
